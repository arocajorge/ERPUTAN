using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt004_Data
    {
        public List<XINV_NAT_Rpt004_Info> consultar_data(int idempresa, int idsucursal, int IdMovi_inven_tipo, decimal IdNumMovi, int IdBodega, ref string mensaje)
        {
            try
            {
                List<XINV_NAT_Rpt004_Info> listadatos = new List<XINV_NAT_Rpt004_Info>();

                using (EntitiesInventario_Rpt_Natu EIngresoCompras = new EntitiesInventario_Rpt_Natu())
                {
                    var select = from h in EIngresoCompras.vwINV_NAT_Rpt004
                                 where h.IdEmpresa == idempresa
                                 && h.IdSucursal == idsucursal
                                 && h.IdNumMovi == IdNumMovi
                                 && h.IdMovi_inven_tipo == IdMovi_inven_tipo
                                 && h.IdBodega == IdBodega
                                 select h;
                    foreach (var item in select)
                    {
                        XINV_NAT_Rpt004_Info itemInfo = new XINV_NAT_Rpt004_Info();
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.cm_observacion = item.cm_observacion;
                        itemInfo.cm_tipo = item.cm_tipo;
                        // itemInfo.cod_producto = item.cod_producto;

                        itemInfo.dm_observacion = item.dm_observacion;
                        itemInfo.dm_peso = Convert.ToDouble(item.dm_peso);
                        itemInfo.dm_precio = item.dm_precio;
                        //itemInfo.emp_direccion = item.emp_direccion;
                        //itemInfo.emp_nombre = item.emp_nombre;
                        //itemInfo.emp_ruc = item.emp_ruc;
                        //itemInfo.emp_tele = item.emp_tele;
                        itemInfo.Estado = item.Estado;
                        itemInfo.IdBodega = Convert.ToInt32(item.IdBodega);
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;


                        if (item.cm_tipo == "+")
                        {
                            itemInfo.mv_costo = Convert.ToDouble(item.mv_costo_sinConversion);
                            itemInfo.nom_unidad = item.nom_unidad_sinConversion;
                            itemInfo.dm_cantidad = item.dm_cantidad_sinConversion;
                            itemInfo.IdUnidadMedida = item.IdUnidadMedida_sinConversion;
                        }
                        else
                        {
                            itemInfo.mv_costo = item.mv_costo;
                            itemInfo.nom_unidad = item.nom_unidad;
                            itemInfo.dm_cantidad = item.dm_cantidad;
                            itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        }

                        // itemInfo.nom_bodega = item.nom_bodega;
                        //itemInfo.nom_producto = item.nom_producto;
                        // itemInfo.TipoMovi_Inven = item.TipoMovi_Inven;
                        //itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.IdProveedor = item.IdProveedor;
                        // itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.do_ManejaIva = item.do_ManejaIva;
                        // itemInfo.IVA = item.IVA;
                        itemInfo.Subtotal = item.SubTotal;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;

                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.bo_Descripcion = item.bo_Descripcion;
                        itemInfo.pr_nombre = item.pr_nombre;
                        itemInfo.pr_codigo = item.pr_codigo;

                        itemInfo.IdMotivo_Inv = Convert.ToInt32(item.IdMotivo_Inv);
                        itemInfo.Desc_mov_inv = item.Desc_mov_inv;

                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_NAT_Rpt004_Info>();
            }
        }
    }
}
