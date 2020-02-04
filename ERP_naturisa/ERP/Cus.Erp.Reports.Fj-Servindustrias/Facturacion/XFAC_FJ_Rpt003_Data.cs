using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt003_Data
    {
        string mensajeError = "";

        public List<XFAC_FJ_Rpt003_Info> Get_Liquidaciones_x_Cliente(int idEmpresa, decimal IdLiquidaciones)
        {
            try
            {
                List<XFAC_FJ_Rpt003_Info> Lista = new List<XFAC_FJ_Rpt003_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt003
                              where q.IdEmpresa == idEmpresa
                              && q.IdLiquidacion == IdLiquidaciones
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt003_Info info = new XFAC_FJ_Rpt003_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdLiquidaciones = item.IdLiquidacion;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Observacion_x_liqui = item.Observacion_x_liqui;
                        info.pe_razonSocial = item.pe_razonSocial;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.pe_nombre = item.pe_nombre;
                        info.precio = item.precio;
                        info.cantidad = item.cantidad;
                        info.detalle_x_producto = item.detalle_x_producto;
                        info.subtotal = item.subtotal;
                        info.Total_liq = item.Total_liq;
                        info.valor_iva = item.valor_iva;                     
                        Lista.Add(info);
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
