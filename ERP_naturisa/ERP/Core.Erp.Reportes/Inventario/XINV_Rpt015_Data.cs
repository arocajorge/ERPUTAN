using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt015_Data
    {
        public List<XINV_Rpt015_Info> consultar_data(int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string IdCentroCosto, List<string> lst_subcentro,DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_anuladas)
        {
                    try
                    {
                        Fecha_ini = Fecha_ini.Date;
                        Fecha_fin = Fecha_fin.Date;

                        int IdSucursal_ini = IdSucursal;
                        int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                        decimal IdProducto_ini = IdProducto;
                        decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                        string Estado = Mostrar_anuladas == true ? "" : "A";

                        List<XINV_Rpt015_Info> listadedatos = new List<XINV_Rpt015_Info>();

                        using (Entities_Inventario_General Consumos = new Entities_Inventario_General())
                        {
                            IQueryable<vwINV_Rpt015> lst;
                            if (IdCentroCosto != "")
                            {
                                lst = from q in Consumos.vwINV_Rpt015
                                      where q.IdEmpresa == IdEmpresa
                                      && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                                      && lst_bodega.Contains(q.IdBodega)
                                      && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                                      && q.IdCentroCosto.Contains(IdCentroCosto)
                                      && lst_subcentro.Contains(q.IdCentroCosto_sub_centro_costo)
                                      && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                      && q.Estado.Contains(Estado)
                                      select q;
                            }
                            else
                            {
                                lst = from q in Consumos.vwINV_Rpt015
                                      where q.IdEmpresa == IdEmpresa
                                      && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                                      && lst_bodega.Contains(q.IdBodega)
                                      && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin                                      
                                      && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                      && q.Estado.Contains(Estado)
                                      select q;
                            }                            

                            foreach (var item in lst)
                            {
                                XINV_Rpt015_Info info = new XINV_Rpt015_Info();
                                info.IdEmpresa = item.IdEmpresa;
                                info.IdSucursal = item.IdSucursal;
                                info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                                info.IdNumMovi = item.IdNumMovi;
                                info.Secuencia = item.Secuencia;
                                info.IdProducto = item.IdProducto;
                                info.cod_producto = item.cod_producto;
                                info.nom_producto = item.nom_producto;
                                info.IdBodega = item.IdBodega;
                                info.cod_bodega = item.cod_bodega;
                                info.nom_bodega = item.nom_bodega;
                                info.cod_sucursal = item.cod_sucursal;
                                info.nom_sucursal = item.nom_sucursal;
                                info.IdProveedor = item.IdProveedor;
                                info.cod_proveedor = item.cod_proveedor;
                                info.nom_proveedor = item.nom_proveedor;
                                info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                                info.nom_subcentro = item.nom_subcentro;
                                info.nom_centro = item.nom_centro;
                                info.IdCentroCosto = item.IdCentroCosto;
                                info.co_factura = item.co_factura;
                                info.IdEmpresa_oc = item.IdEmpresa_oc;
                                info.IdSucursal_oc = item.IdSucursal_oc;
                                info.IdOrdenCompra = item.IdOrdenCompra;
                                info.Secuencia_oc = item.Secuencia_oc;
                                info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                                info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                                info.mv_costo_sinConversion = item.mv_costo_sinConversion;
                                info.IdUnidadMedida = item.IdUnidadMedida;
                                info.dm_cantidad = item.dm_cantidad;
                                info.mv_costo = item.mv_costo;
                                info.signo = item.signo;
                                info.IdEstadoAproba = item.IdEstadoAproba;
                                info.cm_observacion = item.cm_observacion;
                                info.cm_fecha = item.cm_fecha;
                                info.Estado = item.Estado;
                                info.Total_convertido = item.Total_convertido;
                                info.Total_sinConversion = item.Total_sinConversion;
                                info.Codigo = item.Codigo;
                                info.tm_descripcion = item.tm_descripcion;
                                info.cm_descripcionCorta = item.cm_descripcionCorta;

                                listadedatos.Add(info);
                            }
                        }
                        return listadedatos;
                    }


                    catch (Exception ex)
                    {

                        return new List<XINV_Rpt015_Info>();
                    }
          }
    }
}
