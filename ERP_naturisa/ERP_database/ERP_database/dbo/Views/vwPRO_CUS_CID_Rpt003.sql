create  view vwPRO_CUS_CID_Rpt003 as 
SELECT     dbo.com_cotizacion_compra.IdEmpresa, dbo.com_cotizacion_compra.IdCotizacion, dbo.com_cotizacion_compra.IdSucursal, 
                      dbo.com_cotizacion_compra_det.Secuencia, dbo.com_cotizacion_compra_det.Idproducto, dbo.com_cotizacion_compra_det.Cant_soli, 
                      dbo.com_cotizacion_compra_det.Cant_a_cotizar, dbo.com_cotizacion_compra_det.IdListadoMateriales_lq, dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, 
                      dbo.vwcom_ListadoMateriales_Detalle.FechaReg, dbo.com_cotizacion_compra_det.IdDetalle_lq, dbo.in_Producto.pr_descripcion, 
                      dbo.com_cotizacion_compra.Observacion, dbo.cp_proveedor.pr_nombre
FROM         dbo.com_cotizacion_compra INNER JOIN
                      dbo.com_cotizacion_compra_det ON dbo.com_cotizacion_compra.IdEmpresa = dbo.com_cotizacion_compra_det.IdEmpresa AND 
                      dbo.com_cotizacion_compra.IdCotizacion = dbo.com_cotizacion_compra_det.IdCotizacion INNER JOIN
                      dbo.tb_sucursal ON dbo.com_cotizacion_compra.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      dbo.com_cotizacion_compra.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.in_Producto ON dbo.com_cotizacion_compra_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.Idproducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.cp_proveedor ON dbo.com_cotizacion_compra.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                      dbo.com_cotizacion_compra.IdProveedor = dbo.cp_proveedor.IdProveedor LEFT OUTER JOIN
                      dbo.vwcom_ListadoMateriales_Detalle ON dbo.com_cotizacion_compra_det.IdDetalle_lq = dbo.vwcom_ListadoMateriales_Detalle.IdDetalle AND 
                      dbo.com_cotizacion_compra_det.Idproducto = dbo.vwcom_ListadoMateriales_Detalle.IdProducto AND 
                      dbo.com_cotizacion_compra_det.IdEmpresa = dbo.vwcom_ListadoMateriales_Detalle.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.IdListadoMateriales_lq = dbo.vwcom_ListadoMateriales_Detalle.IdListadoMateriales