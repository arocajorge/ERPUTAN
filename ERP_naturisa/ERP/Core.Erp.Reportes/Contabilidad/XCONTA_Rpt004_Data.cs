using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt004_Data
    {
        string mensaje = "";

        public List<XCONTA_Rpt004_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
              
                List<XCONTA_Rpt004_Info> listado = new List<XCONTA_Rpt004_Info>();

                using (EntitiesContabilidadRptGeneral db = new EntitiesContabilidadRptGeneral())
                { 
                    var datos = (from a in db.vwCONTA_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 select a);

                    foreach (var item in datos)
                    {
                        XCONTA_Rpt004_Info info = new XCONTA_Rpt004_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCtaCblePadre = item.IdCtaCblePadre;
                        info.IdGrupoCble = item.IdGrupoCble;
                        info.IdNivelCta = item.IdNivelCta;
                        info.IdTipoCtaCble = item.IdTipoCtaCble;
                        info.pc_clave_corta = item.pc_clave_corta;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                        info.pc_EsMovimiento = item.pc_EsMovimiento;
                        info.pc_Estado = item.pc_Estado;
                        info.pc_Naturaleza = item.pc_Naturaleza;                        
                      

                        listado.Add(info);
                    }

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }

        }
    }
}
