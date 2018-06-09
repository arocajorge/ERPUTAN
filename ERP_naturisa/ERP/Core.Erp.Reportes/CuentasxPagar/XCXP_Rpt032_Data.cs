using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt032_Data
    {
        public List<XCXP_Rpt032_Info> Get_List_Data(int IdEmpresa, decimal IdConciliacion_Caja, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();

            List<XCXP_Rpt032_Info> listadatos = new List<XCXP_Rpt032_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    var select = from q in OEnti.vwCXP_Rpt032
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdConciliacion_Caja == IdConciliacion_Caja
                                 select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt032_Info info = new XCXP_Rpt032_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_OGiro = item.IdEmpresa_OGiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdTipoMovi = item.IdTipoMovi;
                        info.Valor_a_aplicar = item.Valor_a_aplicar;
                        info.Tipo_documento = item.Tipo_documento;
                        info.IdEmpresa_OP = item.IdEmpresa_OP;
                        info.IdOrdenPago_OP = item.IdOrdenPago_OP;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_nombre = item.pr_nombre;
                        info.co_serie = item.co_serie;
                        info.co_factura = item.co_factura;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.co_plazo = item.co_plazo;
                        info.co_observacion = item.co_observacion;
                        info.co_baseImponible = item.co_baseImponible;
                        info.co_total = item.co_total;
                        info.co_valorpagar = item.co_valorpagar;
                        info.Codigo = item.Codigo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_centro_costo = item.nom_centro_costo;
                        info.em_Nombre = infoEmp.em_nombre;

                        listadatos.Add(info);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt032_Info>(); ;
            }
        }
    }
}
