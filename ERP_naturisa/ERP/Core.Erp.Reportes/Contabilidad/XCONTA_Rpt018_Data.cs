using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt018_Data
    {
        public List<XCONTA_Rpt018_Info> Get_list_reporte(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_cargo_grupo, bool Mostrar_detalle)
        {
            try
            {
                int IdPunto_cargo_grupo_ini = IdPunto_cargo_grupo;
                int IdPunto_cargo_grupo_fin = IdPunto_cargo_grupo == 0 ? 99999 : IdPunto_cargo_grupo;                

                List<XCONTA_Rpt018_Info> Lista = new List<XCONTA_Rpt018_Info>();

                using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
                {
                    var lst = from q in Context.spCONTA_Rpt018(Fecha_ini.Date, Fecha_fin.Date, IdEmpresa, IdPunto_cargo_grupo_ini, IdPunto_cargo_grupo_fin, Mostrar_detalle)
                              select q;

                    foreach (var item in lst)
                    {
                        XCONTA_Rpt018_Info info = new XCONTA_Rpt018_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRow = item.IdRow;
                        info.IdCtaCble = item.IdCtaCble;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.Observacion = item.Observacion;
                        info.Valor = item.Valor;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.Comprobante = item.Comprobante;
                        info.IdCbteCble = item.IdCbteCble;
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
