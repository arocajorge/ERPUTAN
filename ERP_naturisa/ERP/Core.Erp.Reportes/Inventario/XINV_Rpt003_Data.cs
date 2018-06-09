using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt003_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt003_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                List<XINV_Rpt003_Info> listadedatos = new List<XINV_Rpt003_Info>();
                using (Entities_Inventario_General EgresosRequisicion = new Entities_Inventario_General())
                {
                    var select = from h in EgresosRequisicion.vwINV_Rpt003
                                 where h.IdEmpresa == IdEmpresa
                                  && h.IdSucursal == IdSucursal
                                  && h.IdMovi_inven_tipo == IdMovi_inven_tipo
                                  && h.IdNumMovi == IdNumMovi
                                 select h;
                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XINV_Rpt003_Info itemInfo = new XINV_Rpt003_Info();
                        itemInfo.bodega = item.bodega;
                        itemInfo.Centro_costo = item.Centro_costo;
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.cm_observacion = item.cm_observacion;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.Descripcion = item.Descripcion;
                        itemInfo.dm_cantidad = Math.Abs(item.dm_cantidad);
                        itemInfo.dm_observacion = item.dm_observacion;
                        itemInfo.dm_precio = item.dm_precio;
                        itemInfo.Estado = item.Estado;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdBodega_inv =Convert.ToInt32(item.IdBodega_inv);
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdEmpresa_inv =Convert.ToInt32(item.IdEmpresa_inv);
                        itemInfo.IdEstadoAproba = item.IdEstadoAproba;
                        itemInfo.IdMotivo_Inv = item.IdMotivo_Inv;
                        itemInfo.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdMovi_inven_tipo_inv = Convert.ToInt32( item.IdMovi_inven_tipo_inv);
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.IdNumMovi_inv = Convert.ToDecimal(item.IdNumMovi_inv);
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdPunto_cargo =Convert.ToInt32( item.IdPunto_cargo);
                        itemInfo.IdSubCentro_Costo = item.IdSubCentro_Costo;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdSucursal_inv = Convert.ToInt32(item.IdSucursal_inv);
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.mv_costo = item.mv_costo;
                        itemInfo.Nom_Motivo_Inv = item.Nom_Motivo_Inv;
                        itemInfo.Nom_Unidad_Medida = item.Nom_Unidad_Medida;
                        itemInfo.punto_cargo = item.punto_cargo;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.signo = item.signo;
                        itemInfo.SubCentro_costo = item.SubCentro_costo;
                        itemInfo.sucursal = item.sucursal;
                        itemInfo.Tipo_Movi_Inven = item.Tipo_Movi_Inven;
                        itemInfo.Nom_producto = item.Nom_producto;
                        itemInfo.Logo = infoEmp.em_logo_Image;
                        itemInfo.Empresa = infoEmp.em_nombre;
                        itemInfo.stock_act = item.dm_stock_actu;
                        itemInfo.stock_ant = item.dm_stock_ante;
                        itemInfo.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                        itemInfo.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        itemInfo.mv_costo_sinConversion = item.mv_costo_sinConversion;
                        itemInfo.nom_unidad_medida_sinConversion = item.nom_unidad_medida_sinConversion;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt003_Info>();
            }
		
	    }
    }
}
