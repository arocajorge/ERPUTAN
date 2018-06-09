using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt029_Data
    {
        public List<XCXP_Rpt029_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            tb_Empresa_Data dataEmp = new tb_Empresa_Data();
            tb_Empresa_Info infoEmp = new tb_Empresa_Info();

            List<XCXP_Rpt029_Info> listadatos = new List<XCXP_Rpt029_Info>();
            try
            {
                using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
                {
                    var select = from q in OEnti.vwCXP_Rpt029
                                 where q.IdEmpresa == IdEmpresa
                                 && q.fecha >= FechaIni
                                 && q.fecha <= FechaFin
                                 select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XCXP_Rpt029_Info Info = new XCXP_Rpt029_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.em_nombre = infoEmp.em_nombre;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_nombre = item.pr_nombre;
                        Info.Factura = item.Factura;
                        Info.NumRetencion = item.NumRetencion;
                        Info.co_Por_iva = item.co_Por_iva;
                        Info.co_valoriva = item.co_valoriva;
                        Info.co_subtotal_iva = item.co_subtotal_iva;
                        Info.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info.fecha = item.fecha;
                        Info.Base_Fuente = item.Base_Fuente;
                        Info.Diferencia = item.Diferencia;
                        Info.Tiene_retencion = item.Tiene_retencion.Trim();
                        Info.re_tipoRet = item.re_tipoRet==null? "" :item.re_tipoRet.Trim();

                        listadatos.Add(Info);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt029_Info>(); ;
            }
        }
    }
}
