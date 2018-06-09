using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt006_Data
    {

        public List<XBAN_Rpt006_Info> Get_Data_Reporte(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                List<XBAN_Rpt006_Info> lstRpt = new List<XBAN_Rpt006_Info>();
                using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
                {
                    var select = from q in listado.vwBAN_Rpt006
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdTipocbte == IdTipoCbte
                                 && q.IdCbteCble == IdCbteCble
                                 select q;

                    foreach (var item in select)
                    {
                
                        XBAN_Rpt006_Info infoRpt = new XBAN_Rpt006_Info();
                       
                        infoRpt.IdEmpresa=item.IdEmpresa;
                        infoRpt.IdPeriodo=Convert.ToInt32(item.IdPeriodo);
                        infoRpt.IdBanco=item.IdBanco;
                        infoRpt.ba_descripcion=item.ba_descripcion;
                        infoRpt.tc_TipoCbte=item.tc_TipoCbte;
                        infoRpt.IdCbteCble=item.IdCbteCble;
                        infoRpt.IdTipocbte=item.IdTipocbte;
                        infoRpt.Cod_Cbtecble=item.Cod_Cbtecble;
                        infoRpt.IdProveedor=item.IdProveedor;
                        infoRpt.NombreProveedor=item.NombreProveedor;
                        infoRpt.cb_Fecha=item.cb_Fecha;
                        infoRpt.cb_Observacion=item.cb_Observacion;
                        infoRpt.cb_secuencia=item.cb_secuencia;
                        infoRpt.cb_Valor=item.cb_Valor;
                        infoRpt.ValorEnLetras = item.ValorEnLetras;
                        infoRpt.cb_Cheque=item.cb_Cheque;
                        infoRpt.cb_FechaCheque=item.cb_FechaCheque;
                        infoRpt.Estado=item.Estado;
                        infoRpt.MotivoAnulacion=item.MotivoAnulacion;
                        infoRpt.cb_giradoA=item.cb_giradoA;
                        infoRpt.cb_ciudadChq=item.cb_ciudadChq;
                        infoRpt.IdCbteCble_Anulacion=item.IdCbteCble_Anulacion;
                        infoRpt.IdTipoCbte_Anulacion=item.IdTipoCbte_Anulacion;
                        infoRpt.IdTipoFlujo=item.IdTipoFlujo;
                        infoRpt.IdTipoNota=item.IdTipoNota;
                        infoRpt.NomTipoNota=item.NomTipoNota;
                        infoRpt.Por_Anticipo=item.Por_Anticipo;
                        infoRpt.PosFechado=item.PosFechado;
                        infoRpt.IdPersona_Girado_a = item.IdPersona_Girado_a;
                        infoRpt.nom_ciudadChq = item.nom_ciudadChq;

                        
                        lstRpt.Add(infoRpt);
                        break;
                    }
                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt006_Data) };
            }
        }
    }
}
