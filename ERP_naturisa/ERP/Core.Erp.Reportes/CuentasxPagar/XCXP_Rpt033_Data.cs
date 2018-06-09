using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt033_Data
    {
        public List<XCXP_Rpt033_Info> Get_List_Data(int IdEmpresa, decimal IdConciliacion_Caja, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();

            List<XCXP_Rpt033_Info> listadatos = new List<XCXP_Rpt033_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    var select = from q in OEnti.vwCXP_Rpt033
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdConciliacion_Caja == IdConciliacion_Caja
                                 select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt033_Info info = new XCXP_Rpt033_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja=item.IdConciliacion_Caja;
                        info.Secuencia=item.Secuencia;
                        info.IdEmpresa_movcaja=item.IdEmpresa_movcaja;
                        info.IdCbteCble_movcaja=item.IdCbteCble_movcaja;
                        info.IdTipocbte_movcaja=item.IdTipocbte_movcaja;
                        info.IdCtaCble=item.IdCtaCble;
                        info.IdPunto_cargo=item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo=item.IdPunto_cargo_grupo;
                        info.cm_beneficiario=item.cm_beneficiario;
                        info.cm_observacion=item.cm_observacion;
                        info.cm_fecha=item.cm_fecha;
                        info.IdPersona=item.IdPersona;
                        info.nom_persona=item.nom_persona;
                        info.IdTipoMovi=item.IdTipoMovi;
                        info.nom_TipoMovi=item.nom_TipoMovi;
                        info.cm_valor = item.cm_valor;
                        info.em_Nombre = infoEmp.em_nombre;

                        listadatos.Add(info);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt033_Info>(); ;
            }
        }
    }
}
