using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
     public class XINV_Rpt002_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

       public  List<XINV_Rpt002_Info> consultar_data(int IdEmpresa,	int IdSucursal, int IdBodega, int IdMovi_inven_tipo,decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                List<XINV_Rpt002_Info> listadedatos = new List<XINV_Rpt002_Info>();
                using (Entities_Inventario_General EgresosVarios = new Entities_Inventario_General())
                {
                    var select = from h in EgresosVarios.vwINV_Rpt002
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdSucursal == IdSucursal
                                 && h.IdBodega == IdBodega
                                 && h.IdMovi_inven_tipo == IdMovi_inven_tipo
                                 && h.IdNumMovi == IdNumMovi
                                 select h;
                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XINV_Rpt002_Info itemInfo = new XINV_Rpt002_Info();
                        itemInfo.cantidad = item.cantidad;
                        itemInfo.cod_producto = item.cod_producto;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.Empresa = item.Empresa;
                        itemInfo.fecha = item.fecha;
                        itemInfo.IdBodega = (item.IdBodega == null) ? 0 : Convert.ToInt32(item.IdBodega);
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.nom_producto = item.nom_producto;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.observacion = item.observacion;
                        itemInfo.observacion_det = item.observacion_det;
                        itemInfo.stock_act = item.stock_act;
                        itemInfo.stock_ant = item.stock_ant;
                        itemInfo.Tipo_Movimiento = item.Tipo_Movimiento;
                        itemInfo.UnidadMedida = item.UnidadMedida;
                        itemInfo.Logo = infoEmp.em_logo_Image;
                        itemInfo.IdEstadoDespacho_cat = item.IdEstadoDespacho_cat;
                        itemInfo.Fecha_registro = item.Fecha_registro;
                        itemInfo.Fecha_ingreso = item.Fecha_ingreso;
                        itemInfo.Fecha_despacho = item.Fecha_despacho;
                        itemInfo.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                        itemInfo.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        itemInfo.UnidadMedida_sinConversion = item.UnidadMedida_sinConversion;
                        itemInfo.mv_costo_sinConversion = itemInfo.mv_costo_sinConversion;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;

            }
            catch (Exception ex)
            {

                return new List<XINV_Rpt002_Info>();
            }
	     }
    }
}
