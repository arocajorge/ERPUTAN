using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
  public  class cp_retencion_det_Data
    {

      string mensaje = "";

      public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
      {
          try
          {
              List<cp_retencion_det_Info> lM = new List<cp_retencion_det_Info>();
              EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

              var select_ = from T in db.vwcp_OrdenGiroRetencionReport
                            where T.IdEmpresa == IdEmpresa && T.IdCbteCble_Ogiro == IdCbteCble_Ogiro && T.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                            select T;

              foreach (var item in select_)
              {
                  cp_retencion_det_Info dat = new cp_retencion_det_Info();
                  dat.IdEmpresa = item.IdEmpresa;

                


                  dat.Idsecuencia = item.Idsecuencia;
                  dat.IdRetencion = item.IdRetencion;
                //  dat.NumRetencion = item.NumRetencion;
                  dat.re_Tiene_RTiva = item.re_Tiene_RTiva;
                  dat.re_Tiene_RFuente = item.re_Tiene_RFuente;
                  dat.re_tipoRet = item.re_tipoRet;
                  dat.re_baseRetencion = item.re_baseRetencion;
                  dat.IdCodigo_SRI = item.IdCodigo_SRI;
                  dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                  dat.re_Porcen_retencion = item.re_Porcen_retencion;
                  dat.re_valor_retencion =Convert.ToDouble( item.re_valor_retencion);
                 
                  dat.re_estado = item.re_estado;
                  dat.IdUsuario = item.IdUsuario;
                  dat.Fecha_Transac = item.Fecha_Transac;
                  dat.nom_pc = item.nom_pc;
                  dat.ip = item.ip;
            
                  dat.nRetencionSRI = item.nRetencionSRI;
                  dat.FVigCoSRI = item.FVigCoSRI;
                  dat.CodigoSRI = item.codigoSRI; //item.CodigoSRI;
            

                  lM.Add(dat);
              }
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdRetencion)
      {
          try
          {
              List<cp_retencion_det_Info> lM = new List<cp_retencion_det_Info>();
              EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

              var select_ = from T in db.vwcp_OrdenGiroRetencionReport
                            where T.IdEmpresa == IdEmpresa && T.IdRetencion == IdRetencion 
                            select T;

              foreach (var item in select_)
              {
                  cp_retencion_det_Info dat = new cp_retencion_det_Info();
                  dat.IdEmpresa = item.IdEmpresa;

                


                  dat.Idsecuencia = item.Idsecuencia;
                  dat.IdRetencion = item.IdRetencion;
                  dat.re_Tiene_RTiva = item.re_Tiene_RTiva;
                  dat.re_Tiene_RFuente = item.re_Tiene_RFuente;
                  dat.re_tipoRet = item.re_tipoRet;
                  dat.re_baseRetencion = item.re_baseRetencion;
                  dat.IdCodigo_SRI = item.IdCodigo_SRI;
                  dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                  dat.re_Porcen_retencion = item.re_Porcen_retencion;
                  dat.re_valor_retencion = Convert.ToDouble(item.re_valor_retencion);
              
                  dat.re_estado = item.re_estado;
                  dat.IdUsuario = item.IdUsuario;
                  dat.Fecha_Transac = item.Fecha_Transac;
                  dat.nom_pc = item.nom_pc;
                  dat.ip = item.ip;
                
                  dat.nRetencionSRI = item.nRetencionSRI;
                  dat.FVigCoSRI = item.FVigCoSRI;
                  dat.CodigoSRI = item.codigoSRI; 
              

                  lM.Add(dat);
              }
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdRetencion, ref string mensaje)
      {
          try
          {
              List<cp_retencion_det_Info> lM = new List<cp_retencion_det_Info>();
              EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

              var consulta = from T in db.vwcp_OrdenGiroRetencionReport
                            where T.IdEmpresa == IdEmpresa && T.IdRetencion == IdRetencion
                            select T;
              foreach (var item in consulta)
              {
                  cp_retencion_det_Info info = new cp_retencion_det_Info();

                  info.IdEmpresa = item.IdEmpresa;
                  info.IdRetencion = item.IdRetencion;
                  info.Idsecuencia = item.Idsecuencia;
                  info.re_tipoRet = item.re_tipoRet;
                  info.re_baseRetencion = item.re_baseRetencion;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.re_Codigo_impuesto = item.re_Codigo_impuesto;
                  info.re_Porcen_retencion = item.re_Porcen_retencion;
                  info.re_valor_retencion = item.re_valor_retencion;
                  info.re_estado = item.re_estado;

                  lM.Add(info);
              }

              return lM;

          }
          catch (Exception ex)
          {
              
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      
      }

      public Boolean GrabarDB(List<cp_retencion_det_Info> lista)
      {
          try
          {

              int secuencia = 0;
              EntitiesCuentasxPagar Cp = new EntitiesCuentasxPagar();
              foreach (var item in lista)
              {
                  cp_retencion_det det = new cp_retencion_det();
                  det.IdEmpresa = item.IdEmpresa;
                //  det.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                //  det.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                  det.IdRetencion = item.IdRetencion;
                  det.Idsecuencia = ++secuencia;
                  det.re_tipoRet = item.re_tipoRet;
                  det.re_baseRetencion = item.re_baseRetencion;
                  det.IdCodigo_SRI = item.IdCodigo_SRI;
                  det.re_Codigo_impuesto = item.re_Codigo_impuesto;
                  det.re_Porcen_retencion = item.re_Porcen_retencion;
                  det.re_valor_retencion = Convert.ToDouble(item.re_valor_retencion);
                
                  det.re_estado = "A";
                
                  det.IdUsuario = item.IdUsuario;
                  det.Fecha_Transac = DateTime.Now;
                
                  det.nom_pc = item.nom_pc;
                  det.ip = item.ip;
               
                  Cp.cp_retencion_det.Add(det);
              }
              Cp.SaveChanges();

              return true;
          }

          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<cp_retencion_det_Info> Get_List_retencion_det(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
      {
          try
          {
              List<cp_retencion_det_Info> lista = new List<cp_retencion_det_Info>();
              EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

              var consulta = from det in db.cp_retencion_det
                             join sri in db.cp_codigo_SRI
                             on new { det.IdCodigo_SRI } equals new { sri.IdCodigo_SRI }

                             join ret in db.cp_retencion
                             on new { det.IdEmpresa,det.IdRetencion } equals new { ret.IdEmpresa,ret.IdRetencion }

                             where ret.IdEmpresa == IdEmpresa && ret.IdCbteCble_Ogiro == IdCbteCble_Ogiro && ret.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro

                             select new
                             {
                                 det.IdEmpresa,
                                // det.IdCbteCble_Ogiro,
                                // det.IdTipoCbte_Ogiro,

                                ret.IdEmpresa_Ogiro,
                                ret.IdCbteCble_Ogiro,
                                ret.IdTipoCbte_Ogiro,

                                 det.IdRetencion,
                                 det.Idsecuencia,
                                 det.re_tipoRet,
                                 det.re_baseRetencion,
                                 det.IdCodigo_SRI,
                                 det.re_Codigo_impuesto,
                                 det.re_Porcen_retencion,
                                 det.re_valor_retencion,
                                // det.IdCtaCble,
                                 det.re_estado,
                               //  det.re_Autorizacion,

                                 sri.co_descripcion,
                                 sri.co_f_valides_desde,
                                 sri.co_f_valides_hasta,
                                 sri.IdTipoSRI

                             };

              foreach (var item in consulta)
              {
                  cp_retencion_det_Info info = new cp_retencion_det_Info();

                  info.IdEmpresa = item.IdEmpresa;

               
                  info.IdRetencion = item.IdRetencion;
                  info.Idsecuencia = item.Idsecuencia;
                  info.re_tipoRet = item.re_tipoRet;
                  info.re_baseRetencion = item.re_baseRetencion;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.re_Codigo_impuesto = item.re_Codigo_impuesto;
                  info.re_Porcen_retencion = item.re_Porcen_retencion;
                  info.re_valor_retencion = item.re_valor_retencion;
                //  info.IdCtaCble = item.IdCtaCble;
                  info.re_estado = item.re_estado;
                 // info.re_Autorizacion = item.re_Autorizacion;

                  info.co_descripcion = item.co_descripcion;
                  info.IdTipoSRI = item.IdTipoSRI;
             

                  lista.Add(info);

              }
              return lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean EliminarDB(cp_retencion_det_Info info)
      {
          try
          {
              Boolean res = false;
              using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
              {
                  var contact = context.cp_retencion_det.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa                    
                      && minfo.IdRetencion == info.IdRetencion
                      && minfo.Idsecuencia == info.Idsecuencia);
                  if (contact != null)
                  {
                      context.cp_retencion_det.Remove(contact);
                      context.SaveChanges();
                      res = true;
                  }
              }
              return res;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean EliminarDB(List<cp_retencion_det_Info> lista)
      {
          try
          {
              foreach (var item in lista)
              {
                  EliminarDB(item);
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean ActualizarDB(List<cp_retencion_det_Info> listaNueva, List<cp_retencion_det_Info> listaAntigua)
      {
          try
          {
              EliminarDB(listaAntigua);
              GrabarDB(listaNueva);

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

    }
}
