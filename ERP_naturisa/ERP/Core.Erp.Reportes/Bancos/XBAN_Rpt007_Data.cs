using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt007_Data
    {
        public List<XBAN_Rpt007_Info> Get_list_reporte(int IdEmpresa, List<int> lst_IdTipoFlujo, DateTime FechaIni, DateTime FechaFin, bool Mostrar_detallado, int IdBanco, bool Mostrar_solo_conciliado, bool Mostrar_beneficiario)
        {
            try
            {
                List<XBAN_Rpt007_Info> lstRpt = new List<XBAN_Rpt007_Info>();

                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                int IdBanco_ini = IdBanco;
                int IdBanco_fin = IdBanco == 0 ? 9999 : IdBanco;

                using (EntitiesBancos_Reporte_Ge Context = new EntitiesBancos_Reporte_Ge())
                {
                    foreach (var item_tipoFlujo in lst_IdTipoFlujo)
                    {
                        var lst = from q in Context.spBAN_Rpt007(IdEmpresa, FechaIni, FechaFin, item_tipoFlujo, item_tipoFlujo,IdBanco_ini,IdBanco_fin, Mostrar_detallado,Mostrar_solo_conciliado)
                                  select q;
                        
                        foreach (var item in lst)
                        {
                            XBAN_Rpt007_Info info = new XBAN_Rpt007_Info();
                            info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            info.Tipo_cbte_cxp = item.Tipo_cbte_cxp;
                            info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            info.IdEmpresa_pago = item.IdEmpresa_pago;
                            info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                            info.Tipo_cbte_pago = item.Tipo_cbte_pago;
                            info.IdCbteCble_pago = item.IdCbteCble_pago;
                            info.co_observacion = Mostrar_beneficiario == true ? item.pe_nombreCompleto : item.co_observacion;
                            info.cb_Fecha = item.cb_Fecha;
                            info.IdTipoFlujo = item.IdTipoFlujo;
                            info.nom_tipo_flujo = item.nom_tipo_flujo;
                            info.cod_flujo = item.cod_flujo;
                            info.Tipo = item.Tipo;
                            info.dc_Valor = item.dc_Valor;
                            info.IdBanco = item.IdBanco;
                            info.nom_banco = item.nom_banco;
                            info.Tipo_movi = item.Tipo_movi;
                            info.orden = item.orden;
                            lstRpt.Add(info);
                        }
                    }

                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_Data) };
            }
        }
    }
}