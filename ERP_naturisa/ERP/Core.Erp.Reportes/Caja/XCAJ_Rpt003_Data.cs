using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Caja
{
   public class XCAJ_Rpt003_Data
    { 

        string MensajeError = "";

        public List<XCAJ_Rpt003_Info> Get_List_Conciliacion_Caja_X_Usuario(int IdEmpresa, decimal IdConciliacion_Caja)
        {
            try
            {
                List<XCAJ_Rpt003_Info> Lista = new List<XCAJ_Rpt003_Info>();
                using (EntitiesCaja_General context = new EntitiesCaja_General())
                {
                    var contact = from c in context.vwCAJ_Rpt003
                                  where c.IdEmpresa == IdEmpresa
                                  && c.IdConciliacion_Caja == IdConciliacion_Caja
                                  orderby c.co_FechaFactura
                                  select c;

                    foreach (var item in contact)
                    {
                        XCAJ_Rpt003_Info Info = new XCAJ_Rpt003_Info();
                        Info.IdEmpresa =item.IdEmpresa;
                        Info.IdCbteCble_Ogiro= item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info.co_fechaOg = item.co_fechaOg;
                        Info.IdPersona =  item.IdPersona;
                        Info.pe_cedulaRuc =  item.pe_cedulaRuc;
                        Info.IdTipoDocumento =  item.IdTipoDocumento;
                        Info.IdOrden_giro_Tipo =  item.IdOrden_giro_Tipo;
                        Info.Descripcion =  item.Descripcion;
                        Info.IdProveedor =  item.IdProveedor;
                        Info.Num_Autorizacion =  item.Num_Autorizacion;
                        Info.co_serie =  item.co_serie;
                        Info.co_factura =  item.co_factura;
                        Info.co_FechaFactura =  item.co_FechaFactura;
                        Info.IdConciliacion_Caja =  item.IdConciliacion_Caja;
                        Info.pe_FechaIni =  item.pe_FechaIni;
                        Info.pe_FechaFin =  item.pe_FechaFin;
                        Info.IdCaja =  item.IdCaja;
                        Info.ca_Descripcion =  item.ca_Descripcion;
                        Info.IdCtaCble =  item.IdCtaCble;
                        Info.co_observacion =  item.co_observacion;
                        Info.IdTipoMovi = item.IdTipoMovi;
                        Info.tm_descripcion = item.tm_descripcion;
                        Info.co_baseImponible = item.co_baseImponible;
                        Info.co_subtotal_iva = item.co_subtotal_iva;
                        Info.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info.co_valoriva = item.co_valoriva;
                        Info.co_Serv_valor = item.co_Serv_valor;
                        Info.co_total = item.co_total;
                        Info.co_valorpagar = item.co_valorpagar;
                        Info.IdRetencion = item.IdRetencion;
                        Info.serie = item.serie;
                        Info.NumRetencion = item.NumRetencion;
                        Info.NAutorizacion = item.NAutorizacion;
                        Info.re_tipoRet_RF = item.re_tipoRet_RF;
                        Info.re_baseRetencion_RF = item.re_baseRetencion_RF;
                        Info.re_Porcen_retencion_RF = item.re_Porcen_retencion_RF;
                        Info.re_valor_retencion_RF = item.re_valor_retencion_RF;
                        Info.re_tipoRet_RIVA = item.re_tipoRet_RIVA;
                        Info.re_baseRetencion_RIVA = item.re_baseRetencion_RIVA;
                        Info.re_Porcen_retencion_RIVA = item.re_Porcen_retencion_RIVA;
                        Info.re_valor_retencion_RIVA = item.re_valor_retencion_RIVA;
                        Info.pe_nombreCompleto =item.pe_nombreCompleto;
                        Info.pe_razonSocial =item.pe_razonSocial;
                        Info. pe_apellido =item.pe_apellido;
                        Info.pe_nombre = item.pe_nombre;

                        Info.pe_mes = item.pe_mes;
                        Info.smes = item.smes;
                        Info.Fecha = item.Fecha;
                        Info.IdanioFiscal = item.IdanioFiscal;
                        Info.IdEstadoCierre = item.IdEstadoCierre;
                        Info.Observacion = item.Observacion;
                        Info.Saldo_cont_al_periodo = item.Saldo_cont_al_periodo;
                        Info.Ingresos = item.Ingresos;
                        Info.Total_Ing = item.Total_Ing;
                        Info.Total_fact_vale = item.Total_fact_vale;
                        Info.Total_fondo = item.Total_fondo;
                        Info.Dif_x_pagar_o_cobrar = item.Dif_x_pagar_o_cobrar;
                        Info.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt003_Data) };
            }
        }
   
    }
}
