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
  public  class Aca_InstitucionFinanciera_Data
    {
      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_InstitucionFinanciera                            
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_InstitucionFinanciera                                   
                                   select q.IdInstitucionFinaciera).Max();
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
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<Aca_InstitucionFinanciera_Info> Get_List_InstitucionFinanciero()
      {
          List<Aca_InstitucionFinanciera_Info> lista = new List<Aca_InstitucionFinanciera_Info>();
          try
          {
              Aca_InstitucionFinanciera_Info institucionInfo;
             
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vInstitucionFinanciera = from i in Base.Aca_InstitucionFinanciera
                                               select i;

                  foreach (var item in vInstitucionFinanciera)
                  {
                      institucionInfo = new Aca_InstitucionFinanciera_Info();
                      institucionInfo.IdInstitucionFinanciera = item.IdInstitucionFinaciera;
                      institucionInfo.CodigoAlterno = item.CodAlterno;
                      institucionInfo.CodigoInstitucion = item.CodigoInstitucion;
                      institucionInfo.IdTipoCuentaCatalogo = item.IdTipoCuenta_catalogo;

                      var catalogo = Base.Aca_Catalogo.FirstOrDefault(c=>c.IdCatalogo==institucionInfo.IdTipoCuentaCatalogo);
                      Aca_Catalogo_Info catalogoInfo = new Aca_Catalogo_Info();
                      catalogoInfo.IdCatalogo = institucionInfo.IdTipoCuentaCatalogo;
                      catalogoInfo.Descripcion = catalogo.Descripcion;

                      institucionInfo.catalogoInfo = catalogoInfo;
                      institucionInfo.NombreAlterno = item.NombreAlterno;
                      institucionInfo.NombreInstitucion = item.NombreInstitucion;
                      institucionInfo.Porc_comision = item.Porc_comision;
                      institucionInfo.Estado = item.Estado;                      
                      lista.Add(institucionInfo);

                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public bool GuardarDB(Aca_InstitucionFinanciera_Info info,ref int idInstitucionFinanciera,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  Aca_InstitucionFinanciera vInstitucionF = new Aca_InstitucionFinanciera();
                  vInstitucionF.IdTipoCuenta_catalogo = info.IdTipoCuentaCatalogo;
                  idInstitucionFinanciera = GetId();
                  vInstitucionF.IdInstitucionFinaciera = idInstitucionFinanciera;
                  vInstitucionF.CodigoInstitucion = info.CodigoInstitucion;
                  vInstitucionF.CodAlterno = info.CodigoAlterno;
                  vInstitucionF.NombreAlterno = info.NombreAlterno;
                  vInstitucionF.NombreInstitucion = info.NombreInstitucion;
                  vInstitucionF.Porc_comision = info.Porc_comision;
                  vInstitucionF.Estado = info.Estado;
                  vInstitucionF.UsuarioCreacion = info.UsuarioCreacion;
                  vInstitucionF.FechaCreacion = DateTime.Now;
                  Base.Aca_InstitucionFinanciera.Add(vInstitucionF);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar la Institución Financiera " + idInstitucionFinanciera.ToString() + " exitosamente.";
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = "";
              throw new Exception(ex.InnerException.ToString());
          }      
      }

      public bool ActualizarDB(Aca_InstitucionFinanciera_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vInstitucionFin = Base.Aca_InstitucionFinanciera.FirstOrDefault(a => a.IdInstitucionFinaciera == info.IdInstitucionFinanciera);

                  if (vInstitucionFin != null)
                  {

                      vInstitucionFin.IdInstitucionFinaciera = info.IdInstitucionFinanciera;
                      vInstitucionFin.CodigoInstitucion = info.CodigoInstitucion;
                      vInstitucionFin.CodAlterno = info.CodigoAlterno;
                      vInstitucionFin.NombreAlterno = info.NombreAlterno;
                      vInstitucionFin.IdTipoCuenta_catalogo = info.IdTipoCuentaCatalogo;
                      vInstitucionFin.NombreInstitucion = info.NombreInstitucion;
                      vInstitucionFin.Porc_comision = info.Porc_comision;
                      vInstitucionFin.Estado = info.Estado;
                      vInstitucionFin.UsuarioModificacion = info.UsuarioModificacion;
                      vInstitucionFin.FechaModificacion = DateTime.Now;
                      Base.SaveChanges();

                      mensaje = "Se ha procedido actualizar la Institución Financiera " + info.IdInstitucionFinanciera.ToString() + " exitosamente.";
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

      public bool AnularDB(Aca_InstitucionFinanciera_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_InstitucionFinanciera.FirstOrDefault(a => a.IdInstitucionFinaciera==info.IdInstitucionFinanciera);
                  if (address != null)
                  {
                      address.Estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      mensaje = "Se ha procedido anular la Institución Financiera " + info.IdInstitucionFinanciera.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
