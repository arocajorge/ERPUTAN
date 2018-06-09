using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt009_Data
    {
        public List<XCONTA_Rpt009_Info> Get_list_CbteCble_x_cp_Conciliacion_caja(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                List<XCONTA_Rpt009_Info> Lista = new List<XCONTA_Rpt009_Info>();

                using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
                {
                    var lst = from q in Context.vwCONTA_Rpt009
                              where IdEmpresa == q.IdEmpresa &&
                              IdConciliacion_caja == q.IdConciliacion_Caja
                              select q;
                    foreach (var item in lst)
                    {
                        XCONTA_Rpt009_Info info = new XCONTA_Rpt009_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.tc_TipoCbte = item.tc_TipoCbte;
                        info.IdEmpresa = item.IdEmpresa_cbte;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.secuencia = item.secuencia;
                        info.IdCtaCble = item.IdCtaCble;
                        info.nom_Cuenta = item.nom_Cuenta;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.Debe = item.Debe;
                        info.Haber = item.Haber;
                        info.dc_Observacion = item.dc_Observacion;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        Lista.Add(info);
                    }
                }

                return Lista;
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
