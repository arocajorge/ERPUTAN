using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.ActivoFijo
{
    public class vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info> Get_List_OC_Factura_ActivoFijo(int IdEmpresa, decimal IdProveedor,  List<fa_catalogo_Info> lstNaturaleza)
        {
            try
            {
                List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info> lstInfo = new List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info>();
                
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdProveedor == IdProveedor                                
                                 select q;

                    foreach (var item in select)
                    {
                        
                                vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info Info = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
                                Info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                                Info.IdSucursal = Convert.ToInt32(item.IdSucursal);
                                Info.IdNumMovi = Convert.ToDecimal(item.IdNumMovi);
                                Info.Secuencia = Convert.ToInt32(item.Secuencia);
                                Info.IdBodega = Convert.ToInt32(item.IdBodega);
                                Info.IdProducto = item.IdProducto;
                                Info.nom_producto = item.nom_producto;
                                Info.dm_cantidad = item.dm_cantidad;
                                Info.mv_costo = Convert.ToDouble(item.mv_costo);
                                Info.dm_precio = Convert.ToDouble(item.dm_precio);
                                Info.dm_observacion = item.dm_observacion;
                                Info.Fecha_Ing_Bod = Convert.ToDateTime(item.Fecha_Ing_Bod);
                                Info.nom_bodega = item.nom_bodega;
                                Info.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                                Info.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                                Info.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                                Info.Secuencia_oc = Convert.ToInt32(item.Secuencia_oc);
                                Info.IdProveedor = item.IdProveedor;
                                Info.nom_proveedor = item.nom_proveedor;
                                Info.IdAprobacion = Convert.ToDecimal(item.IdAprobacion);
                                Info.numDocumento = item.numDocumento;
                                Info.Fecha_Factura = Convert.ToDateTime(item.Fecha_Factura);
                                Info.Cantidad = Convert.ToDouble(item.Cantidad);
                                Info.Costo_uni = Convert.ToDouble(item.Costo_uni);
                                Info.SubTotal = Convert.ToDouble(item.SubTotal);
                                Info.PorIva = Convert.ToDouble(item.PorIva);
                                Info.valor_Iva = Convert.ToDouble(item.valor_Iva);
                                Info.Total = Convert.ToDouble(item.Total);
                                Info.IdEmpresa_Ogiro = Convert.ToInt32(item.IdEmpresa_Ogiro);
                                Info.IdCbteCble_Ogiro = Convert.ToDecimal(item.IdCbteCble_Ogiro);
                                Info.IdTipoCbte_Ogiro = Convert.ToInt32(item.IdTipoCbte_Ogiro);
                                Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                                Info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                                Info.IdCtaCble_IVA = item.IdCtaCble_IVA;
                                Info.Saldo_Factu = Convert.ToDouble(item.Saldo_Factu);
                                lstInfo.Add(Info);
                            }
                        }
                    
                
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
