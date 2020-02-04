using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt003_Data
    {
        tb_Empresa_Data empresa_data = new tb_Empresa_Data();
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        public List<XCOMP_Rpt003_Info> consultar_data(int idempresa, int idsucursal, int IdMovi_inven_tipo, decimal IdNumMovi,int IdBodega,ref string mensaje)
        {
            try
            {
                info_empresa = empresa_data.Get_Info_Empresa(idempresa);

                List<XCOMP_Rpt003_Info> listadatos = new List<XCOMP_Rpt003_Info>();

                using (EntitiesCompras_natu_rpt EIngresoCompras = new EntitiesCompras_natu_rpt())
                {
                    var select = from h in EIngresoCompras.vwCOMP_Rpt003
                                 where h.IdEmpresa == idempresa
                                 && h.IdSucursal == idsucursal
                                 && h.IdNumMovi == IdNumMovi
                                 && h.IdMovi_inven_tipo == IdMovi_inven_tipo
                                 && h.IdBodega==IdBodega
                                 select h;
                    foreach (var item in select)
                    {
                        XCOMP_Rpt003_Info itemInfo = new XCOMP_Rpt003_Info();
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.cm_observacion = item.cm_observacion;
                        itemInfo.cm_tipo = item.cm_tipo;                        
                        itemInfo.dm_observacion = item.dm_observacion;
                        itemInfo.dm_peso = Convert.ToDouble(item.dm_peso);
                        itemInfo.dm_precio = item.dm_precio;
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

                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.do_ManejaIva = item.do_ManejaIva;
                        itemInfo.Subtotal = item.SubTotal;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                        
                        
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.bo_Descripcion = item.bo_Descripcion;
                        itemInfo.pr_nombre = item.pr_nombre;
                        itemInfo.pr_codigo = item.pr_codigo;
                        
                        itemInfo.IdMotivo_Inv = Convert.ToInt32(item.IdMotivo_Inv);
                        itemInfo.Desc_mov_inv = item.Desc_mov_inv;
                        itemInfo.em_logo = info_empresa.em_logo;
                        itemInfo.Referencia = item.CodMoviInven;
                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCOMP_Rpt003_Info>();


            }
        }
    }
}

