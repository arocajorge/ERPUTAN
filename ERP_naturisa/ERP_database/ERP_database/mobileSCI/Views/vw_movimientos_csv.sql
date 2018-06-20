CREATE VIEW [mobileSCI].[vw_movimientos_csv]
AS
SELECT        mobileSCI.tbl_movimientos_det.IdSincronizacion, mobileSCI.tbl_movimientos_det.IdSecuencia, dbo.in_movi_inve_detalle.IdEmpresa, dbo.in_movi_inve_detalle.IdSucursal, dbo.in_movi_inve_detalle.IdBodega, 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo, dbo.in_movi_inve_detalle.IdNumMovi, dbo.in_movi_inve_detalle.Secuencia, dbo.in_movi_inve_detalle.IdCentroCosto, dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo, 
                         dbo.ct_centro_costo.Centro_costo AS NomCentroCosto, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS NomSubCentro, dbo.ct_centro_costo_sub_centro_costo.mobile_cod_produccion AS CodProduccionSC, 
                         dbo.in_Producto.pr_descripcion, dbo.in_Producto.mobile_cod_produccion AS CodProduccionPro, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, ISNULL( ABS(dbo.in_movi_inve_detalle.dm_cantidad),0) AS Cantidad, 
                         dbo.in_movi_inve_detalle.IdProducto, mobileSCI.tbl_movimientos_det.Fecha, dbo.in_movi_inve_detalle.IdUnidadMedida
FROM            dbo.tb_sucursal INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.in_movi_inve_detalle INNER JOIN
                         mobileSCI.tbl_movimientos_det INNER JOIN
                         mobileSCI.tbl_movimientos_det_apro ON mobileSCI.tbl_movimientos_det.IdSincronizacion = mobileSCI.tbl_movimientos_det_apro.IdSincronizacion AND 
                         mobileSCI.tbl_movimientos_det.IdSecuencia = mobileSCI.tbl_movimientos_det_apro.IdSecuencia INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON mobileSCI.tbl_movimientos_det_apro.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND mobileSCI.tbl_movimientos_det_apro.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         mobileSCI.tbl_movimientos_det_apro.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND mobileSCI.tbl_movimientos_det_apro.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi AND 
                         mobileSCI.tbl_movimientos_det_apro.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_inv AND dbo.in_movi_inve_detalle.IdBodega = dbo.in_Ing_Egr_Inven_det.IdBodega_inv AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv AND dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_Ing_Egr_Inven_det.secuencia_inv INNER JOIN
                         dbo.tb_bodega ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_movi_inve_detalle.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.tb_bodega.IdBodega ON dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.in_movi_inve_detalle.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.in_movi_inve_detalle.IdEmpresa INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto ON 
                         dbo.tb_sucursal.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.tb_bodega.IdSucursal INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_movi_inve_detalle.IdProducto = dbo.in_Producto.IdProducto
WHERE        (mobileSCI.tbl_movimientos_det.Estado = 'A') AND (mobileSCI.tbl_movimientos_det.IdCentroCosto_sub_centro_costo IS NOT NULL)