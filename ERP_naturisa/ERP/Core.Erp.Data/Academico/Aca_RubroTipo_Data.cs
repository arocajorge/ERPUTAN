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
  public  class Aca_RubroTipo_Data
    {
      string mensaje = "";

      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Rubro_Tipo
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Rubro_Tipo
                                   select q.IdTipoRubro).Max();
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

      public List<Aca_RubroTipo_Info> Get_List_RubroTipo() {
          List<Aca_RubroTipo_Info> lista = new List<Aca_RubroTipo_Info>();
          try
          {
              Aca_RubroTipo_Info rubroTipoInfo;
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var rubroTipo = from r in Base.Aca_Rubro_Tipo
                                  orderby r.IdTipoRubro
                                  select r;
                  foreach (var item in rubroTipo)
                  {
                      rubroTipoInfo = new Aca_RubroTipo_Info();
                      rubroTipoInfo.IdTipoRubro = item.IdTipoRubro;
                      rubroTipoInfo.CodTipoRubro = item.codTipoRubro;
                      rubroTipoInfo.IdRubroComportamiento_cat = item.IdRubroComportamiento_cat;
                      rubroTipoInfo.DescripcionTipoRubro = item.descripcion_tipo;
                      rubroTipoInfo.Estado = item.estado;
                      lista.Add(rubroTipoInfo);
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
              throw new Exception(ex.ToString());
          }
      }

      public bool GrabarDB(Aca_RubroTipo_Info info, ref int idTipoRubro, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  Aca_Rubro_Tipo addressRubro = new Aca_Rubro_Tipo();
                  idTipoRubro = GetId();
                  addressRubro.IdTipoRubro = idTipoRubro;
                  addressRubro.codTipoRubro = string.IsNullOrEmpty(info.CodTipoRubro) ? idTipoRubro.ToString() : info.CodTipoRubro;                  
                  addressRubro.descripcion_tipo = info.DescripcionTipoRubro;                  
                  addressRubro.estado = info.Estado;
                  addressRubro.IdRubroComportamiento_cat = info.IdRubroComportamiento_cat;
                  addressRubro.FechaCreacion = DateTime.Now;
                  addressRubro.UsuarioCreacion = info.UsuarioCreacion;
                  Base.Aca_Rubro_Tipo.Add(addressRubro);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar el Tipo Rubro #: " + idTipoRubro.ToString() + " exitosamente.";

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

      public bool ActualizarDB(Aca_RubroTipo_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {

                  var vRubro = Base.Aca_Rubro_Tipo.FirstOrDefault(j => j.IdTipoRubro == info.IdTipoRubro);

                  if (vRubro != null)
                  {
                      vRubro.codTipoRubro = string.IsNullOrEmpty(info.CodTipoRubro) ? info.IdTipoRubro.ToString() : info.CodTipoRubro == "0" ? info.IdTipoRubro.ToString() : info.CodTipoRubro;
                      vRubro.descripcion_tipo = info.DescripcionTipoRubro;
                      vRubro.IdRubroComportamiento_cat = info.IdRubroComportamiento_cat;
                      vRubro.UsuarioModificacion = info.UsuarioModificacion;
                      vRubro.FechaModificacion = DateTime.Now;
                      vRubro.estado = info.Estado;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar el Tipo Rubro #: " + info.IdTipoRubro.ToString() + " exitosamente.";
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

      public Boolean AnularDB(Aca_RubroTipo_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Rubro_Tipo.FirstOrDefault(a => a.IdTipoRubro == info.IdTipoRubro);

                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular el Tipo Rubro #: " + info.IdTipoRubro.ToString() + " exitosamente.";
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
