﻿
CREATE VIEW [dbo].[vwINV_FJ_Rpt005]
AS
SELECT        dbo.in_movi_inve.IdEmpresa, dbo.in_movi_inve.IdSucursal, dbo.in_movi_inve.IdBodega, dbo.in_movi_inve.IdMovi_inven_tipo, dbo.in_movi_inve.IdNumMovi, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, dbo.tb_bodega.bo_Descripcion AS nom_bodega, dbo.in_movi_inve.cm_fecha AS Fecha, 
                         dbo.in_movi_inven_tipo.Codigo AS cod_Movi_Inven_tipo, dbo.in_movi_inven_tipo.tm_descripcion AS nom_Movi_Inven_tipo, 
                         dbo.in_movi_inve.NumDocumentoRelacionado, dbo.in_movi_inve.NumFactura, dbo.in_movi_inve.cm_observacion AS Observacion, 
                         dbo.in_movi_inve_detalle.mv_tipo_movi, (CASE WHEN dbo.in_movi_inve_detalle.mv_tipo_movi = '+' THEN dbo.in_movi_inve_detalle.dm_cantidad ELSE 0 END) 
                         AS CantiIngreso, (CASE WHEN dbo.in_movi_inve_detalle.mv_tipo_movi = '-' THEN (dbo.in_movi_inve_detalle.dm_cantidad) ELSE 0 END) AS CantiEgreso, 
                         (CASE WHEN dbo.in_movi_inve_detalle.mv_tipo_movi = '+' THEN dbo.in_movi_inve_detalle.mv_costo ELSE 0 END) AS CostoUniIngreso, 
                         (CASE WHEN dbo.in_movi_inve_detalle.mv_tipo_movi = '-' THEN (dbo.in_movi_inve_detalle.mv_costo) ELSE 0 END) AS CostoUniEgreso, 
                         dbo.in_movi_inve_detalle.mv_costo AS Costo, dbo.in_Producto.pr_codigo AS Cod_producto, dbo.in_Producto.pr_descripcion AS nom_producto, 
                         dbo.in_movi_inve_detalle.IdProducto, dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc, dbo.in_Ing_Egr_Inven_det.IdSucursal_oc, 
                         dbo.in_Ing_Egr_Inven_det.IdOrdenCompra, dbo.vwcom_ordencompra_local.IdProveedor, dbo.vwcom_ordencompra_local.pr_nombre, 
                         ISNULL(dbo.in_movi_inve_detalle.IdCentroCosto, '') AS IdCentroCosto, ISNULL(dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo, '') 
                         AS IdCentroCosto_sub_centro_costo, dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_SubCentro_costo
FROM            dbo.tb_bodega INNER JOIN
                         dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.in_movi_inve ON dbo.tb_bodega.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.in_movi_inve.IdSucursal AND 
                         dbo.tb_bodega.IdBodega = dbo.in_movi_inve.IdBodega INNER JOIN
                         dbo.in_movi_inven_tipo ON dbo.in_movi_inve.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND 
                         dbo.in_movi_inve.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                         dbo.in_movi_inve_detalle ON dbo.in_movi_inve.IdEmpresa = dbo.in_movi_inve_detalle.IdEmpresa AND 
                         dbo.in_movi_inve.IdSucursal = dbo.in_movi_inve_detalle.IdSucursal AND dbo.in_movi_inve.IdBodega = dbo.in_movi_inve_detalle.IdBodega AND 
                         dbo.in_movi_inve.IdMovi_inven_tipo = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve.IdNumMovi = dbo.in_movi_inve_detalle.IdNumMovi INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdProducto = dbo.in_Producto.IdProducto LEFT OUTER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_movi_inve_detalle.Secuencia = dbo.in_Ing_Egr_Inven_det.secuencia_inv AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv = dbo.in_movi_inve_detalle.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven_det.IdSucursal_inv = dbo.in_movi_inve_detalle.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdBodega_inv = dbo.in_movi_inve_detalle.IdBodega AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv = dbo.in_movi_inve_detalle.IdNumMovi LEFT OUTER JOIN
                         dbo.ct_centro_costo ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto LEFT OUTER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo LEFT OUTER JOIN
                         dbo.vwcom_ordencompra_local ON dbo.vwcom_ordencompra_local.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc AND 
                         dbo.vwcom_ordencompra_local.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_oc AND 
                         dbo.vwcom_ordencompra_local.IdOrdenCompra = dbo.in_Ing_Egr_Inven_det.IdOrdenCompra