using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Curso_Data
    {
      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_curso
                            select q).Count();
              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_curso
                                   select q.IdCurso).Max();
                  Id = Convert.ToInt32(select_as.ToString()) + 1;
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
          
      }

      public List<Aca_Curso_Info> Get_Lista_Curso(int IdInstitucion)
      {
          List<Aca_Curso_Info> lista = new List<Aca_Curso_Info>();
          Aca_Curso_Info cursoInfo;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vCurso = from c in Base.Aca_curso
                               join sec in Base.Aca_Seccion on c.IdSeccion equals sec.IdSeccion
                               join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                               join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                               where sed.IdInstitucion == IdInstitucion 
                               select c;
                  foreach (var item in vCurso)
                  {
                      cursoInfo = new Aca_Curso_Info();
                      cursoInfo.IdSeccion = item.IdSeccion;
                      cursoInfo.IdCurso = item.IdCurso;
                      cursoInfo.CodCurso = item.CodCurso;
                      cursoInfo.CodAlternoCurso = item.CodAlternoCur;
                      cursoInfo.DescripcionCurso = item.Descripcion_cur;
                      cursoInfo.Estado = item.estado;
                      lista.Add(cursoInfo);
                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.InnerException.ToString());
          }

      }
      public List<Aca_Curso_Info> Get_List_Curso(int IdInstitucion,int IdSeccion) {
          List<Aca_Curso_Info> lista = new List<Aca_Curso_Info>();
          Aca_Curso_Info cursoInfo;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vCurso = from c in Base.Aca_curso
                               join sec in Base.Aca_Seccion on c.IdSeccion equals sec.IdSeccion
                               join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                               join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                               where sed.IdInstitucion == IdInstitucion && c.IdSeccion == IdSeccion
                               select c;
                  foreach (var item in vCurso)
                  {
                      cursoInfo = new Aca_Curso_Info();                      
                      cursoInfo.IdSeccion = item.IdSeccion;
                      cursoInfo.IdCurso = item.IdCurso;
                      cursoInfo.CodCurso = item.CodCurso;
                      cursoInfo.CodAlternoCurso = item.CodAlternoCur;
                      cursoInfo.DescripcionCurso = item.Descripcion_cur;                      
                      cursoInfo.Estado = item.estado;
                      cursoInfo.es_sistema_dual = item.es_sistema_dual;
                      lista.Add(cursoInfo);
                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.InnerException.ToString());
          }
          
      }

      public bool GrabarDB(Aca_Curso_Info info, ref int IdCurso, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  Aca_curso curso = new Aca_curso();
                  curso.IdSeccion = info.IdSeccion;
                  IdCurso = GetId();
                  curso.IdCurso = IdCurso;
                  curso.CodCurso = string.IsNullOrEmpty(info.CodCurso) ? Convert.ToString(IdCurso) : info.CodCurso;
                  curso.CodAlternoCur = string.IsNullOrEmpty(info.CodAlternoCurso) ? "" : info.CodAlternoCurso;
                  curso.Descripcion_cur = info.DescripcionCurso;
                  curso.estado = info.Estado;
                  curso.FechaCreacion = DateTime.Now;
                  curso.FechaModificacion = DateTime.Now;
                  curso.UsuarioCreacion = info.UsuarioCreacion;
                  curso.UsuarioModificacion = info.UsuarioModificacion;

                  Base.Aca_curso.Add(curso);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar el Curso #: " + IdCurso.ToString() + " exitosamente.";
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public bool ActualizarDB(Aca_Curso_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vSeccion = Base.Aca_curso.FirstOrDefault(j => j.IdCurso == info.IdCurso);
                  if (vSeccion!=null)
                  {
                  vSeccion.IdSeccion = info.IdSeccion;
                  vSeccion.CodCurso = string.IsNullOrEmpty(info.CodCurso) ? info.IdCurso.ToString() : info.CodCurso;
                  vSeccion.CodAlternoCur = string.IsNullOrEmpty(info.CodAlternoCurso) ? "" : info.CodAlternoCurso;
                  vSeccion.Descripcion_cur = info.DescripcionCurso;                  
                  vSeccion.estado = info.Estado;
                  vSeccion.FechaModificacion = DateTime.Now;                  
                  vSeccion.UsuarioModificacion = info.UsuarioModificacion;

                  Base.SaveChanges();
                  mensaje = "Se ha procedido actualizar el Curso #: " + info.IdCurso.ToString() + " exitosamente.";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }


      public Boolean AnularDB(Aca_Curso_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_curso.FirstOrDefault(a => a.IdCurso == info.IdCurso);
                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular Curso #: " + info.IdCurso.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msg = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
