CREATE VIEW [mobileSCI].[vw_stock]
AS
SELECT        dbo.in_Ing_Egr_Inven_det.IdEmpresa, dbo.in_Ing_Egr_Inven_det.IdSucursal, dbo.in_Ing_Egr_Inven_det.IdBodega, dbo.in_Ing_Egr_Inven_det.IdProducto, dbo.in_Producto.pr_codigo AS CodProducto, 
                         dbo.in_Producto.pr_descripcion AS NomProducto, dbo.in_Producto.IdUnidadMedida_Consumo, ISNULL(ROUND(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad), 2), 0) + ISNULL(SUM(mov.cantidad), 0) AS Stock, 
                         dbo.in_UnidadMedida.Descripcion AS NomUnidadMedida
FROM            mobileSCI.tbl_bodega INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON mobileSCI.tbl_bodega.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND mobileSCI.tbl_bodega.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         mobileSCI.tbl_bodega.IdBodega = dbo.in_Ing_Egr_Inven_det.IdBodega INNER JOIN
                         mobileSCI.tbl_producto ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = mobileSCI.tbl_producto.IdProducto INNER JOIN
                         dbo.in_Ing_Egr_Inven ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Ing_Egr_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.in_Ing_Egr_Inven.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven_det.IdNumMovi = dbo.in_Ing_Egr_Inven.IdNumMovi AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Ing_Egr_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.in_Ing_Egr_Inven.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven_det.IdNumMovi = dbo.in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                         dbo.in_Motivo_Inven ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Motivo_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMotivo_Inv = dbo.in_Motivo_Inven.IdMotivo_Inv AND 
                         dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Motivo_Inven.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMotivo_Inv = dbo.in_Motivo_Inven.IdMotivo_Inv INNER JOIN
                         dbo.in_movi_inven_tipo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                         dbo.in_Producto ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = dbo.in_Producto.IdProducto AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.in_UnidadMedida ON dbo.in_Producto.IdUnidadMedida_Consumo = dbo.in_UnidadMedida.IdUnidadMedida LEFT OUTER JOIN
                         (SELECT        mobileSCI.tbl_movimientos_det.IdEmpresa,mobileSCI.tbl_movimientos_det.IdSucursal, mobileSCI.tbl_movimientos_det.IdBodega, mobileSCI.tbl_movimientos_det.IdProducto, mobileSCI.tbl_movimientos_det.cantidad * dbo.in_UnidadMedida_Equiv_conversion.valor_equiv as cantidad
							FROM            mobileSCI.tbl_movimientos_det INNER JOIN
											dbo.in_Producto ON mobileSCI.tbl_movimientos_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND mobileSCI.tbl_movimientos_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
											dbo.in_UnidadMedida_Equiv_conversion ON mobileSCI.tbl_movimientos_det.IdUnidadMedida = dbo.in_UnidadMedida_Equiv_conversion.IdUnidadMedida AND 
											dbo.in_Producto.IdUnidadMedida_Consumo = dbo.in_UnidadMedida_Equiv_conversion.IdUnidadMedida_equiva
							where mobileSCI.tbl_movimientos_det.Estado = 'A' and mobileSCI.tbl_movimientos_det.Aprobado = 0) AS mov 
							ON mov.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND mov.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND dbo.in_Ing_Egr_Inven_det.IdBodega = mov.IdBodega AND 
                         dbo.in_Ing_Egr_Inven_det.IdProducto = mov.IdProducto 
WHERE        (dbo.in_Motivo_Inven.Genera_Movi_Inven = 'S') AND (dbo.in_movi_inven_tipo.Genera_Movi_Inven = 1) AND (dbo.in_Ing_Egr_Inven.Estado = 'A')
GROUP BY dbo.in_Ing_Egr_Inven_det.IdEmpresa, dbo.in_Ing_Egr_Inven_det.IdSucursal, dbo.in_Ing_Egr_Inven_det.IdBodega, dbo.in_Ing_Egr_Inven_det.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, 
                         dbo.in_Producto.IdUnidadMedida_Consumo, dbo.in_UnidadMedida.Descripcion