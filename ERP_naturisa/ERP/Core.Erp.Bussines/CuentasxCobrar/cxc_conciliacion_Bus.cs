using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Business.CuentasxCobrar
{
   public class cxc_conciliacion_Bus
    {
       cxc_conciliacion_Data oData = new cxc_conciliacion_Data();
       cxc_conciliacion_det_Data oDataDetalle = new cxc_conciliacion_det_Data();
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       cxc_cobro_Bus cobro_B = new cxc_cobro_Bus();
       fa_notaCreDeb_x_cxc_cobro_Bus Bus_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Bus();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       

       public Boolean GuardarDB(cxc_conciliacion_Info Item, ct_Cbtecble_Info CbteCbleInfo , Cl_Enumeradores.TipoConciliacion TipoConciliacion,  ref decimal Id, ref string mensaje)
       {
           string mensajeError = "";
           try
           {               
               cxc_cobro_Info CobrosInfo = new cxc_cobro_Info();
               cxc_cobro_Det_Info CobroDetalleInfo = new cxc_cobro_Det_Info();
               List<cxc_cobro_Det_Info> lstCobDetInfo = new List<cxc_cobro_Det_Info>();
               fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
               decimal IdCobroDet = 0;
               Boolean resultCobro = true;
               oData.Guardar_Conciliacion(Item, ref Id, ref  mensaje);
               decimal idConciliacion = Id;
                
               //si es por anticipo solo inserto el detalle del cobro
                if (Cl_Enumeradores.TipoConciliacion.ANT_CLI == TipoConciliacion)
                {
                    ct_Cbtecble_Bus CbteCbleBus = new ct_Cbtecble_Bus();
                    string codCbteCble = "";
                    decimal idCbteCble = 0;
                    lstCobDetInfo = GetDetalleCobro(Item, ref IdCobroDet);
                    CobrosInfo = cobro_B.Get_Info_cobro_x_cliente(Item.IdEmpresa, Item.IdSucursal, IdCobroDet, Convert.ToInt32(Item.IdCliente));
                    CobrosInfo.ListaCobro = lstCobDetInfo;
                    cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
                    resultCobro = BusDet_cobro.GuardarDB(CobrosInfo.ListaCobro);
                    //inserto la contabilidad de los registros
                    if (CbteCbleBus.GrabarDB(CbteCbleInfo, ref idCbteCble, ref mensaje))
                    {
                        //actualizo la cabecera de la concilacion con los id del cbte cble
                        Item.IdEmpresa_cbte_cble = CbteCbleInfo.IdEmpresa;
                        Item.IdTipoCbte_cbte_cble = CbteCbleInfo.IdTipoCbte;
                        Item.IdCbteCble_cbte_cble = idCbteCble;
                        Item.IdConciliacion = Id;
                        oData.ModificarConciliacion(Item, ref mensaje);
                    }
                }
                else
                {
                    CobrosInfo = Get_Cobro(Item, ref Id);
                    decimal IdCobro = 0;
                    resultCobro = cobro_B.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref CobrosInfo, ref mensaje);                    
                }

               if (resultCobro)
               {
                   ModificarDB(Item, CobrosInfo, Id, ref mensaje);
                   info_NotaCreDeb = Get_faNotaCreDeb_x_Cobro(CobrosInfo, Item);
                   Bus_NotaCreDeb.GuardarDB(info_NotaCreDeb, ref mensaje);
               }


               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }



       public void ModificarDB(cxc_conciliacion_Info Item,cxc_cobro_Info CobrosInfo,  decimal Id, ref string mensaje) 
       {
           try
           {
               List<cxc_conciliacion_Info> listAnticipoDetalle = new List<cxc_conciliacion_Info>();
               cxc_conciliacion_det_Info conciliacionDetalle = new cxc_conciliacion_det_Info();
               int contCobro = 1;
               foreach (var item in Item.Detalle)
               {
                   conciliacionDetalle = new cxc_conciliacion_det_Info();
                   conciliacionDetalle = item;
                   conciliacionDetalle.IdConciliacion = Id;
                   conciliacionDetalle.Secuencia = contCobro;
                   conciliacionDetalle.IdEmpresa_cbr = CobrosInfo.IdEmpresa;
                   conciliacionDetalle.IdSucursal_cbr = CobrosInfo.IdSucursal;
                   conciliacionDetalle.IdCobro = CobrosInfo.IdCobro;
                   oDataDetalle.ModificarDB(conciliacionDetalle, ref mensaje);                   
                   contCobro++;
               }
               
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetModificarConciliacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
               
           }
       }



       public cxc_cobro_Info Get_Cobro(cxc_conciliacion_Info cab,  ref decimal Id)
       {
           try
           {
              cxc_cobro_Info info = new cxc_cobro_Info();
               info.IdEmpresa = cab.IdEmpresa;
               info.IdSucursal = cab.IdSucursal;
               info.IdCliente = cab.IdCliente;

               info.cr_fecha = cab.Fecha;
               info.cr_fechaDocu = cab.Fecha;
               info.cr_fechaCobro = cab.Fecha;

               info.IdCobro_a_aplicar = null;
               info.cr_Banco = null;
               info.cr_cuenta = null;
               info.cr_NumDocumento = null;
               info.cr_Tarjeta = null;
               info.cr_propietarioCta = null;
               info.cr_estado = "A";
               info.cr_recibo = 0;
               info.IdBanco = null;
               info.MotiAnula = null;
               info.cr_Codigo = "";

               info.nom_pc = param.nom_pc;
               info.ip = param.ip;
               // _Info.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
               info.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
               info.IdUsuario = param.IdUsuario;

               // campos vista
               info.IdCobro_tipo = cab.cxc_cobro_Info.IdCobro_tipo;
               info.IdTipoNotaCredito = cab.cxc_cobro_Info.IdTipoNotaCredito;
               info.IdCaja = cab.cxc_cobro_Info.IdCaja;
               info.cr_TotalCobro = cab.cxc_cobro_Info.cr_TotalCobro;
               // campos vista      
               info.cr_observacion = "Conciliación #: " + Id + " del cliente " + cab.cxc_cobro_Info.cr_observacion;

               //Detalle conciliacion
               info.ListaCobro = new List<cxc_cobro_Det_Info>();
               decimal IdCobroDet = 0;
               info.ListaCobro = GetDetalleCobro(cab, ref IdCobroDet);

               return info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }

       }



       public List<cxc_cobro_Det_Info> GetDetalleCobro(cxc_conciliacion_Info cab, ref decimal IdCobro)
       {
           try
           {
               List<cxc_cobro_Det_Info> lstCobroDet = new  List<cxc_cobro_Det_Info>();
               foreach (var item in cab.DetalleCobroFact)
               {

                   cxc_cobro_Det_Info info_det = new cxc_cobro_Det_Info();

                   info_det.IdEmpresa = item.IdEmpresa;
                   IdCobro = Convert.ToDecimal(item.IdCobro);
                   info_det.IdSucursal = item.IdSucursal;
                   info_det.IdCobro = Convert.ToDecimal(item.IdCobro);
                   info_det.secuencial = item.Secuencia;
                   info_det.dc_TipoDocumento = item.TipoDoc_vta;
                   info_det.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_fa);
                   info_det.IdCbte_vta_nota = Convert.ToDecimal(item.IdCbteVta_fa);
                   info_det.dc_ValorPago = item.Valor_Aplicado;
                   info_det.IdUsuario = param.IdUsuario;

                   info_det.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                   info_det.nom_pc = param.nom_pc;
                   info_det.ip = param.ip;

                   lstCobroDet.Add(info_det);
               }
               return lstCobroDet;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       
       }


       public fa_notaCreDeb_x_cxc_cobro_Info Get_faNotaCreDeb_x_Cobro(cxc_cobro_Info info, cxc_conciliacion_Info Item)
        {
            try
            {
                string mensaje = "";
                fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
                cxc_conciliacion_det_Info conciliaInfo = new cxc_conciliacion_det_Info();
                    info_NotaCreDeb.IdEmpresa_cbr= info.IdEmpresa;
                    info_NotaCreDeb.IdSucursal_cbr = info.IdSucursal;
                    info_NotaCreDeb.IdCobro_cbr = info.IdCobro;
                    conciliaInfo = Item.Detalle.First();
                    info_NotaCreDeb.IdEmpresa_nt = Convert.ToInt32(conciliaInfo.IdEmpresa_nt);
                    info_NotaCreDeb.IdSucursal_nt = Convert.ToInt32(conciliaInfo.IdSucursal_nt);;
                    info_NotaCreDeb.IdBodega_nt = Convert.ToInt32(conciliaInfo.IdBodega_nt);
                    info_NotaCreDeb.IdNota_nt = Convert.ToInt32(conciliaInfo.IdNota_nt);

                    info_NotaCreDeb.Valor_cobro = info.cr_TotalCobro;

                    return info_NotaCreDeb;                    
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_faNotaCreDeb_x_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }
        
        }



       public List<cxc_conciliacion_Info> Get_List_conciliacion(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return oData.Get_List_conciliacion(IdEmpresa, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }

       public Boolean Anular_Conciliacion(cxc_conciliacion_Info SETINFO_, ref string mensaje)
       {
           try
           {
               return oData.Anular_Conciliacion(SETINFO_, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_Conciliacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }
    }
}
