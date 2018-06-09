create view [dbo].[vwin_prd_CidersusConsultaProductosCortados] as 

SELECT        dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo, dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, dbo.in_movi_inve.cm_observacion, 
                         dbo.in_movi_inve.cm_fecha, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion
FROM            dbo.in_movi_inve INNER JOIN
                         dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_movi_inve.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                         dbo.in_movi_inve.IdSucursal = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal AND 
                         dbo.in_movi_inve.IdBodega = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega AND 
                         dbo.in_movi_inve.IdMovi_inven_tipo = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve.IdNumMovi = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto = dbo.in_Producto.IdProducto
WHERE        (dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo IN (3, 5))