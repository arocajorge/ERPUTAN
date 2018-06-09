using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt001_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt001_Info> consultar_data(int IdEmpresa,	int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                List<XINV_Rpt001_Info> listadedatos = new List<XINV_Rpt001_Info>();
                using (Entities_Inventario_General ingresoVarios = new Entities_Inventario_General())
                {
                    var select = from h in ingresoVarios.vwINV_Rpt001
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdSucursal == IdSucursal
                                 && h.IdBodega == IdBodega
                                 && h.IdMovi_inven_tipo == IdMovi_inven_tipo
                                 && h.IdNumMovi == IdNumMovi
                                 select h;
                    
                    foreach (var item in select)
                    {
                        XINV_Rpt001_Info itemInfo = new XINV_Rpt001_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.Tipo_Movimiento = item.Tipo_Movimiento;
                        itemInfo.Empresa = item.Empresa;
                        itemInfo.cod_producto = item.cod_producto;
                        itemInfo.nom_producto = item.nom_producto;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.UnidadMedida = item.UnidadMedida;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.Cantidad = item.Cantidad;
                        itemInfo.Stock_Ant = item.Stock_Ant;
                        itemInfo.Stock_Act = item.Stock_Act;
                        itemInfo.Observacion_det = item.Observacion_det;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        itemInfo.IdEstadoAproba = item.IdEstadoAproba;
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                        itemInfo.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        itemInfo.mv_costo_sinConversion = item.mv_costo_sinConversion;
                        itemInfo.UnidadMedida_sinConversion = item.UnidadMedida_sinConversion;
                        itemInfo.signo = item.signo;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {

                return new List<XINV_Rpt001_Info>();
            }
          }
       }
    }