using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt014_Data
    {
        public List<XCONTA_Rpt014_Info> Get_list_reporte(int IdEmpresa, List<string> IdGrupoCble, string IdCtaCble, string IdCentroCosto,DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XCONTA_Rpt014_Info> Lista = new List<XCONTA_Rpt014_Info>();
                using (EntitiesContabilidadRptGeneral Context = new EntitiesContabilidadRptGeneral())
                {
                    var lst = from q in Context.vwCONTA_Rpt014
                              where IdEmpresa == q.IdEmpresa &&
                              FechaIni <= q.cb_Fecha && q.cb_Fecha <= FechaFin
                              select q;

                    if (IdGrupoCble.Count!=0)
                    {
                        
                        lst = lst.Where(q => IdGrupoCble.Contains(q.IdGrupoCble));
                    }
                    if (IdCtaCble!="")
                    {
                        lst = lst.Where(q => q.IdCtaCble == IdCtaCble);
                    }
                    if (IdCentroCosto!="")
                    {
                        lst = lst.Where(q => q.IdCentroCosto == IdCentroCosto);
                    }
                    foreach (var item in lst)
                    {
                        XCONTA_Rpt014_Info info = new XCONTA_Rpt014_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.secuencia = item.secuencia;
                        info.cb_Observacion = item.cb_Observacion;
                        info.cb_Fecha = item.cb_Fecha;
                        info.tc_TipoCbte = item.tc_TipoCbte;
                        info.IdCtaCble = item.IdCtaCble;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Centro_costo = item.Centro_costo;
                        info.dc_Valor = item.dc_Valor;
                        info.IdGrupoCble = item.IdGrupoCble;
                        info.gc_GrupoCble = item.gc_GrupoCble == "" ? "Sin centro de costo" : item.gc_GrupoCble;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.nom_subcentro = item.nom_subcentro;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.gc_Orden = item.gc_Orden;
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
