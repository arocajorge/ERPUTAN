using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    class XCONTA_NATU_Rpt003_Data
    {
        public List<XCONTA_NATU_Rpt003_Info> consultar_data(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref String mensajeError)
        {
            try
            {
                List<XCONTA_NATU_Rpt003_Info> lista = new List<XCONTA_NATU_Rpt003_Info>();

                using (EntitiesContabilidad_Natu_Rpt OEnti = new EntitiesContabilidad_Natu_Rpt())
                {
                    var select = from k in OEnti.vwCONTA_NATU_Rpt003
                                 where k.IdEmpresa == IdEmpresa
                                 && k.IdTipoCbte == IdTipoCbte
                                 && k.IdCbteCble == IdCbteCble
                                 select k;
                    foreach (var item in select)
                    {
                        XCONTA_NATU_Rpt003_Info info = new XCONTA_NATU_Rpt003_Info();
                        info.debe = item.debe;
                        info.Cred = item.Cred;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.CodCbteCble = item.CodCbteCble;
                        info.IdPeriodo = item.IdPeriodo;
                        info.cb_Fecha = item.cb_Fecha;
                        info.cb_Valor = item.cb_Valor;
                        info.cb_Observacion = item.cb_Observacion;
                        info.cb_Estado = item.cb_Estado;
                        info.cb_Anio = item.cb_Anio;
                        info.cb_mes = item.cb_mes;
                        info.IdCtaCble = item.IdCtaCble;
                        info.dc_Valor = item.dc_Valor;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.tc_TipoCbte = item.tc_TipoCbte;
                        info.pc_clave_corta = item.pc_clave_corta;
                        lista.Add(info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
