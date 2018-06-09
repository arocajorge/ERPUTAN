using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt031_Data
    {
        public List<XCXP_Rpt031_Info> Get_List_Data(int IdEmpresa, decimal IdConciliacion_Caja, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();

            List<XCXP_Rpt031_Info> listadatos = new List<XCXP_Rpt031_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    var select = from q in OEnti.vwCXP_Rpt031
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdConciliacion_Caja == IdConciliacion_Caja
                                 select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt031_Info info = new XCXP_Rpt031_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha = item.Fecha;
                        info.IdCaja = item.IdCaja;
                        info.IdEstadoCierre = item.IdEstadoCierre;
                        info.nom_estado_cierre = item.nom_estado_cierre;
                        info.Observacion = item.Observacion;
                        info.IdEmpresa_op = item.IdEmpresa_op;
                        info.IdOrdenPago_op = item.IdOrdenPago_op;
                        info.IdCtaCble = item.IdCtaCble;
                        info.Saldo_cont_al_periodo = item.Saldo_cont_al_periodo;
                        info.Ingresos = item.Ingresos;
                        info.Total_Ing = item.Total_Ing;
                        info.Total_fact_vale = item.Total_fact_vale;
                        info.Total_fondo = item.Total_fondo;
                        info.Dif_x_pagar_o_cobrar = item.Dif_x_pagar_o_cobrar;
                        info.ca_Descripcion = item.ca_Descripcion;
                        info.em_Nombre = infoEmp.em_nombre;

                        listadatos.Add(info);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt031_Info>(); ;
            }
        }
    }
}
