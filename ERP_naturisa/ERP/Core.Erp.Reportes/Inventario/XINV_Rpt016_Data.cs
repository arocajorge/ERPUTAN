using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt016_Data
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <param name="IdSucursal"></param> si id Sucarsal=0 extrae todos
        /// <param name="IdCentroCosto"></param>
        /// <param name="IdSubCentroCosto"></param>
        /// <param name="IdPuntoCargo"></param>
        /// <param name="IdProductoIni"></param>
        /// <param name="IdProductoFin"></param>
        /// <param name="FechaIni"></param>
        /// <param name="FechaFin"></param>
        /// <param name="i_tipo_movi"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public List<XINV_Rpt016_Info> Get_List_Consumo_Detalle(int IdEmpresa, int IdSucursal, string IdCentroCosto, string IdSubCentroCosto, 
            string IdPuntoCargo, decimal IdProductoIni, decimal IdProductoFin, DateTime FechaIni, DateTime FechaFin, string i_tipo_movi, ref string mensaje)
        {
            try
            {
                int IdSucursalIni=(IdSucursal==0?1:IdSucursal);
                int IdSucursalFin=(IdSucursal==0?9999:IdSucursal);

                decimal IdProductoIni1 = (IdProductoIni == 0 ? 1 : IdProductoIni);
                decimal IdProductoFin1 = (IdProductoFin == 0 ? 9999 : IdProductoFin);

                List<XINV_Rpt016_Info> listadedatos = new List<XINV_Rpt016_Info>();

                using (Entities_Inventario_General Consumos = new Entities_Inventario_General())
                {
                    var Q = from h in Consumos.vwINV_Rpt016
                            where h.IdEmpresa == IdEmpresa
                            && h.IdSucursal >= IdSucursalIni && h.IdSucursal <= IdSucursalFin
                            && h.IdSubCentro_Costo.Contains(IdSubCentroCosto)
                            && h.IdCentroCosto.Contains(IdCentroCosto)
                            //&& h.IdSubCentro_Costo.Contains(IdPuntoCargo)
                            && h.IdProducto >= IdProductoIni1 && h.IdProducto <= IdProductoFin1
                            && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                            select h;

                    foreach (var item in Q)
                    {
                        XINV_Rpt016_Info itemInfo = new XINV_Rpt016_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.nom_empresa = item.nom_empresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.nom_Movi_inven_tipo = item.nom_Movi_inven_tipo;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.nom_Producto = item.nom_Producto;
                        itemInfo.IdSubCentro_Costo = item.IdSubCentro_Costo;
                        itemInfo.nom_CentroCosto = item.nom_CentroCosto;
                        itemInfo.nom_subCentroCosto = item.nom_subCentroCosto;
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                        itemInfo.dm_cantidad = item.dm_cantidad;
                        itemInfo.mv_costo = item.mv_costo;
                        itemInfo.SubTotal = item.SubTotal;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.cm_tipo_movi = item.cm_tipo_movi;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt016_Info>();
            }
        }
    }
}
