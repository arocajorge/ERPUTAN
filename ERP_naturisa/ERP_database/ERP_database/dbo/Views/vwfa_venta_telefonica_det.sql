CREATE view [dbo].[vwfa_venta_telefonica_det]
as

SELECT     fa_venta_telefonica_det.IdEmpresa, fa_venta_telefonica_det.IdSucursal, fa_venta_telefonica_det.IdVenta_tel, fa_venta_telefonica_det.Secuencia, 
                      fa_venta_telefonica_det.IdProducto, fa_venta_telefonica_det.Observacion, fa_venta_telefonica_det.Cantidad, in_Producto.pr_descripcion AS nom_producto
                      ,'S' as Viene_Base
FROM         fa_venta_telefonica_det INNER JOIN
                      in_Producto ON fa_venta_telefonica_det.IdEmpresa = in_Producto.IdEmpresa AND fa_venta_telefonica_det.IdProducto = in_Producto.IdProducto