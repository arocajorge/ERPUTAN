
CREATE VIEW [dbo].[vwin_ReimpresionCodigoBarra_cusCider]
AS
SELECT        dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_precio, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_costo, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdProcesoProductivo, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdEmpresa, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEtapa, dbo.in_Producto.pr_descripcion, dbo.in_Producto.IdUnidadMedida, dbo.in_Producto.pr_precio_publico, 
                         dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, dbo.in_Producto.pr_peso
FROM            dbo.in_movi_inve_detalle_x_Producto_CusCider INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.tb_sucursal ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.tb_bodega ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.tb_bodega.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega = dbo.tb_bodega.IdBodega