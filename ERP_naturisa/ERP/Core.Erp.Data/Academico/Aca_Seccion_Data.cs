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
  public  class Aca_Seccion_Data
    {
      string mensaje = "";

      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Seccion
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Seccion
                                   select q.IdSeccion).Max();
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

      public int GetIdSeccion(int IdCurso) {
          int IdSeccion = 0;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var curso = from c in Base.Aca_curso
                             where c.IdCurso == IdCurso
                             select c;
                  foreach (var item in curso)
                  {
                      IdSeccion = item.IdSeccion;
                  }
              }
              return IdSeccion;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<Aca_Seccion_Info> Get_List_Seccion(int IdInstitucion,int IdJornada) {
          List<Aca_Seccion_Info> lista = new List<Aca_Seccion_Info>();
          Aca_Seccion_Info SeccionInfo;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vSeccion = from s in Base.Aca_Seccion 
                                 join jo in Base.Aca_Jornada on s.IdJornada equals jo.IdJornada
                                 join se in Base.Aca_Sede on jo.IdSede equals se.IdSede 
                                 where se.IdInstitucion == IdInstitucion 
                                    && s.IdJornada == IdJornada
                                 select s;
                  foreach (var item in vSeccion)
                  {
                      SeccionInfo = new Aca_Seccion_Info();                      
                      SeccionInfo.IdSeccion = item.IdSeccion;
                      SeccionInfo.IdJornada = item.IdJornada;
                      SeccionInfo.CodAlternoSeccion = item.CodAlterno_Sec;
                      SeccionInfo.CodSeccion = item.CodSeccion;
                      SeccionInfo.DescripcionSeccion = item.Descripcion_secc;
                      SeccionInfo.Estado = item.estado;
                      lista.Add(SeccionInfo);                      
                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


      public List<Aca_Seccion_Info> Get_List_Seccion(int IdInstitucion)
      {
          List<Aca_Seccion_Info> lista = new List<Aca_Seccion_Info>();
          Aca_Seccion_Info SeccionInfo;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vSeccion = from s in Base.Aca_Seccion
                                 join jo in Base.Aca_Jornada on s.IdJornada equals jo.IdJornada
                                 join se in Base.Aca_Sede on jo.IdSede equals se.IdSede
                                 where se.IdInstitucion == IdInstitucion
                                 select s;
                  foreach (var item in vSeccion)
                  {
                      SeccionInfo = new Aca_Seccion_Info();
                      SeccionInfo.IdSeccion = item.IdSeccion;
                      SeccionInfo.IdJornada = item.IdJornada;
                      SeccionInfo.CodAlternoSeccion = item.CodAlterno_Sec;
                      SeccionInfo.CodSeccion = item.CodSeccion;
                      SeccionInfo.DescripcionSeccion = item.Descripcion_secc;
                      SeccionInfo.Estado = item.estado;
                      lista.Add(SeccionInfo);
                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


      public bool GrabarDB(Aca_Seccion_Info info, ref int idSeccion, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  Aca_Seccion addressSecc = new Aca_Seccion();
                  addressSecc.IdJornada=info.IdJornada;                  
                  idSeccion = GetId();
                  addressSecc.IdSeccion=idSeccion;                  
                  addressSecc.CodSeccion= string.IsNullOrEmpty(info.CodSeccion)?idSeccion.ToString():info.CodSeccion;
                  addressSecc.CodAlterno_Sec= string.IsNullOrEmpty(info.CodAlternoSeccion)?"":info.CodAlternoSeccion;                  
                  addressSecc.Descripcion_secc=info.DescripcionSeccion;
                  addressSecc.estado=info.Estado;
                  addressSecc.FechaCreacion = DateTime.Now;
                  addressSecc.FechaModificacion = DateTime.Now;
                  addressSecc.UsuarioCreacion = info.UsuarioCreacion;
                  addressSecc.UsuarioModificacion = info.UsuarioModificacion;
                  Base.Aca_Seccion.Add(addressSecc);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar la Sección #: " + idSeccion.ToString() + " exitosamente.";
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
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public bool ActualizarDB(Aca_Seccion_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vSeccion = Base.Aca_Seccion.First(j => j.IdSeccion == info.IdSeccion );
                  vSeccion.Descripcion_secc = info.DescripcionSeccion;
                  vSeccion.CodSeccion = string.IsNullOrEmpty(info.CodSeccion)?info.IdSeccion.ToString():info.CodSeccion;
                  vSeccion.CodAlterno_Sec = string.IsNullOrEmpty(info.CodAlternoSeccion) ? "" : info.CodAlternoSeccion;
                  vSeccion.IdJornada = info.IdJornada;
                  vSeccion.estado = info.Estado;
                  vSeccion.FechaModificacion = DateTime.Now;
                  vSeccion.UsuarioModificacion = info.UsuarioModificacion;
                  Base.SaveChanges();
                  mensaje = "Se ha procedido actualizar la Sección #: " + info.IdSeccion.ToString() + " exitosamente.";
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
              throw new Exception(ex.ToString());
          }
      }


      public Boolean AnularDB(Aca_Seccion_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Seccion.FirstOrDefault(a => a.IdSeccion == info.IdSeccion);

                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular Sección #: " + info.IdSeccion.ToString() + " exitosamente.";
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
