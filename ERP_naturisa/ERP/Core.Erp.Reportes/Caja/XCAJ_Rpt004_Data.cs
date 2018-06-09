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
    public class XCAJ_Rpt004_Data
    {
        public List<XCAJ_Rpt004_Info> Get_List(int IdEmpresa, decimal IdConcilacion_Caja)
        {
            try
            {
                List<XCAJ_Rpt004_Info> Lista = new List<XCAJ_Rpt004_Info>();
                using (EntitiesCaja_General Context = new EntitiesCaja_General())
                {
                    var contact = from c in Context.vwCAJ_Rpt004
                                  where c.IdEmpresa == IdEmpresa
                                  && c.IdConciliacion_Caja == IdConcilacion_Caja
                                  select c;
                    foreach (var item in contact)
                    {
                        XCAJ_Rpt004_Info info = new XCAJ_Rpt004_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.IdCaja = item.IdCaja;
                        info.Fecha_ini = item.Fecha_ini;
                        info.Fecha_fin = item.Fecha_fin;
                        info.IdEstadoCierre = item.IdEstadoCierre;
                        info.IdCtaCble = item.IdCtaCble;
                        info.pc_clave_corta = item.pc_clave_corta;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.Debe = item.Debe;
                        info.Haber = item.Haber;
                        info.dc_Observacion = item.dc_Observacion;
                        info.IdEmpresa_cbte = item.IdEmpresa_cbte;
                        info.nom_tipo_cbte = item.nom_tipo_cbte;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.nom_caja = item.nom_caja;
                        info.cb_Fecha = item.cb_Fecha;
                        Lista.Add(info);
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt004_Data) };
            }
        }
    }
}
