using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt006_Data
    {
        public List<XINV_FJ_Rpt006_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni,int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {              

                List<XINV_FJ_Rpt006_Info> lista = new List<XINV_FJ_Rpt006_Info>();
                using (EntitiesInventario_FJ_Rpt  conexion = new EntitiesInventario_FJ_Rpt())
                {
                    //double Subtotal = 0;                   
                    var querry = from q in conexion.vwINV_FJ_Rpt006
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdSucursal >= IdSucursalIni && q.IdSucursal <=IdSucursalFin
                                  && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                  && q.IdCentro_costo.Contains(IdCentroCosto)
                                  && q.IdSubcentro_costo.Contains(IdSubCentroCosto)
                                  && q.IdMovi_inven_tipo >= IdMov_inven_tipoIni && q.IdMovi_inven_tipo <= IdMov_inven_tipoFin
                                  && q.IdProducto >= IdProductoIni && q.IdProducto <= IdProductoFin
                                  && q.cm_tipo.Contains(TipoMov)
                                  && q.cm_fecha >= FechaIni && q.cm_fecha <= FechaFin
                                  select q;

                   
                    foreach (var item in querry)
                    {

                        XINV_FJ_Rpt006_Info itemInfo = new XINV_FJ_Rpt006_Info();
                        
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.nom_empresa = item.nom_empresa;
                        itemInfo.ruc_empresa = item.ruc_empresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.cm_tipo = item.cm_tipo;
                        itemInfo.mv_costo = item.mv_costo;
                        itemInfo.dm_cantidad = item.dm_cantidad;
                        itemInfo.SubTotal = item.dm_cantidad * item.mv_costo;
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.cod_producto = item.cod_producto;
                        itemInfo.nom_producto = item.nom_producto;                        
                        itemInfo.dm_observacion = item.dm_observacion;                        
                        itemInfo.nom_tipo_inven = item.nom_tipo_inven;
                        itemInfo.nom_centro_costo = item.nom_centro_costo;
                        itemInfo.nom_subcentro_costo = item.nom_subcentro_costo;
                        itemInfo.IdCentro_costo = item.IdCentro_costo;
                        itemInfo.IdSubcentro_costo = item.IdSubcentro_costo;
                        lista.Add(itemInfo);
                    }
                }
                return lista;

            }
            catch (Exception)
            {

                return new List<XINV_FJ_Rpt006_Info>();
            }
        }
    }
}
