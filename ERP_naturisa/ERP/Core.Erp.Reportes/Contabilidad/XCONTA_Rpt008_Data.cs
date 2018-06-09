using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt008_Data
    {
        string MensajeError = "";
        public List<XCONTA_Rpt008_Info> Get_List_Reporte(int IdEmpresa, Decimal IdOrdenPago)
        {
            try
            {
                List<XCONTA_Rpt008_Info> Lista = new List<XCONTA_Rpt008_Info>();

                using (EntitiesContabilidadRptGeneral context = new EntitiesContabilidadRptGeneral())
                {
                    var contact = from q in context.vwCONTA_Rpt008
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdOrdenPago == IdOrdenPago
                                  select q;

                    foreach (var item in contact)
                    {
                        XCONTA_Rpt008_Info Info = new XCONTA_Rpt008_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdOrdenPago = item.IdOrdenPago;
                        Info.Secuencia_op = item.Secuencia_op;
                        Info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        Info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        Info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        Info.secuencia_cxp = item.secuencia_cxp;
                        Info.IdCtaCble = item.IdCtaCble;
                        Info.pc_Cuenta = item.pc_Cuenta;
                        Info.pc_clave_corta = item.pc_clave_corta;
                        Info.dc_Observacion = item.dc_Observacion;
                        Info.cb_Fecha = item.cb_Fecha;
                        Info.dc_Valor = item.dc_Valor;
                        Info.CodTipoCbte = item.CodTipoCbte;
                        Info.tc_TipoCbte = item.tc_TipoCbte;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
