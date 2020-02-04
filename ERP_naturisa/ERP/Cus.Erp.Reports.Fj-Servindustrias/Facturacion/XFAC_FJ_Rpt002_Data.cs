using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt002_Data
    {
        public List<XFAC_FJ_Rpt002_Info> Get_List_Liquidacion(int idEmpresa, decimal IdLiquidacion)
        {
            try
            {
                List<XFAC_FJ_Rpt002_Info> Lista = new List<XFAC_FJ_Rpt002_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt002
                              where q.IdEmpresa == idEmpresa
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt002_Info Info = new XFAC_FJ_Rpt002_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacion = item.IdLiquidacion;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.cod_liquidacion = item.cod_liquidacion;
                        Info.IdCliente = item.IdCliente;
                        Info.fecha_liqui = item.fecha_liqui;
                        Info.Observacion = item.Observacion;
                        Info.estado = item.estado;
                        Info.pe_nombre = item.pe_nombre;
                        Info.pe_apellido = item.pe_apellido;
                        Info.secuencia = item.secuencia;
                        Info.IdProducto_Liqui = item.IdProducto_Liqui;
                        Info.detalle_x_producto = item.detalle_x_producto;
                        Info.cantidad = item.cantidad;
                        Info.precio = item.precio;
                        Info.subtotal = item.subtotal;
                        Info.aplica_iva = item.aplica_iva;
                        Info.por_iva = item.por_iva;
                        Info.valor_iva = item.valor_iva;
                        Info.Total_liq = item.Total_liq;
                        Info.nom_producto_Liqui = item.nom_producto_Liqui;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
