using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Jornada_Data
    {
      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Jornada
                            select q).Count();
              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Jornada
                                   select q.IdJornada).Max();
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

      public int GetIdJornada(int idSeccion) {
          int idJornada = 0;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var seccion = from j in Base.Aca_Seccion
                                where j.IdSeccion == idSeccion
                                select j;
                  foreach (var item in seccion)
                  {
                      idJornada = item.IdJornada;                      
                  }
              }
              return idJornada;
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
   
      public List<Aca_Jornada_Info> Get_List_Jornada(int IdInstitucion, int idSede) {
          List<Aca_Jornada_Info> lista = new List<Aca_Jornada_Info>();
          Aca_Jornada_Info infoJornada;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vjornada = from j in Base.Aca_Jornada
                                 join s in Base.Aca_Sede on j.IdSede equals s.IdSede
                                 where s.IdInstitucion == IdInstitucion && j.IdSede == idSede
                                select j;

                  foreach (var item in vjornada)
                  {
                      infoJornada = new Aca_Jornada_Info();                      
                      infoJornada.IdJornada = item.IdJornada;
                      infoJornada.IdSede = item.IdSede;
                      infoJornada.CodJornada = item.CodJornada;
                      infoJornada.CodAternoJornada = item.CodAlternoJor;
                      infoJornada.DescripcionJornada = item.Descripcion_Jor;                      
                      infoJornada.Estado = item.estado;
                      lista.Add(infoJornada);
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

      public List<Aca_Jornada_Info> Get_Lista_Jornada(int IdInstitucion)
      {
          List<Aca_Jornada_Info> lista = new List<Aca_Jornada_Info>();
          Aca_Jornada_Info infoJornada;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vjornada = from j in Base.Aca_Jornada
                                 join s in Base.Aca_Sede on j.IdSede equals s.IdSede
                                 where s.IdInstitucion == IdInstitucion
                                 select j;

                  foreach (var item in vjornada)
                  {
                      infoJornada = new Aca_Jornada_Info();
                      infoJornada.IdJornada = item.IdJornada;
                      infoJornada.IdSede = item.IdSede;
                      infoJornada.CodJornada = item.CodJornada;
                      infoJornada.CodAternoJornada = item.CodAlternoJor;
                      infoJornada.DescripcionJornada = item.Descripcion_Jor;
                      infoJornada.Estado = item.estado;
                      lista.Add(infoJornada);
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

      public bool GrabarDB(Aca_Jornada_Info info,ref int idJornada,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  Aca_Jornada addressJor = new Aca_Jornada();                  
                  addressJor.IdSede = info.IdSede == null ? 0 : Convert.ToInt32(info.IdSede);
                  idJornada = GetId();
                  addressJor.IdJornada = idJornada;
                  addressJor.Descripcion_Jor = info.DescripcionJornada;
                  addressJor.CodJornada = (info.CodJornada == "0" || string.IsNullOrEmpty(info.CodJornada) == true) ? idJornada.ToString() : info.CodJornada;
                  addressJor.CodAlternoJor = string.IsNullOrEmpty( info.CodAternoJornada)?"":info.CodAternoJornada;
                  addressJor.estado = info.Estado;
                  addressJor.FechaCreacion = DateTime.Now;
                  addressJor.FechaModificacion = DateTime.Now;
                  addressJor.UsuarioCreacion = info.UsuarioCreacion;
                  addressJor.UsuarioModificacion = info.UsuarioModificacion;

                  Base.Aca_Jornada.Add(addressJor);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar la Jornada #: " + idJornada.ToString() + " exitosamente.";
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

      public bool ActualizarDB(Aca_Jornada_Info info,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vjornada = Base.Aca_Jornada.FirstOrDefault(j=> j.IdSede==info.IdSede && j.IdJornada==info.IdJornada);

                  if (vjornada != null)
                  {
                      vjornada.Descripcion_Jor = info.DescripcionJornada;
                      vjornada.CodAlternoJor = string.IsNullOrEmpty(info.CodAternoJornada) ? "" : info.CodAternoJornada;
                      vjornada.estado = info.Estado;
                      vjornada.FechaModificacion = DateTime.Now;
                      vjornada.UsuarioModificacion = info.UsuarioModificacion;

                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar la Jornada #: " + info.IdJornada.ToString() + " exitosamente.";
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
              throw new Exception(ex.ToString());
          }
      }

      public Boolean AnularDB(Aca_Jornada_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Jornada.FirstOrDefault(a => a.IdJornada == info.IdJornada);
                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular Jornada #: " + info.IdJornada.ToString() + " exitosamente.";
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
