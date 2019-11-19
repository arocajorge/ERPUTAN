CREATE view vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det
as
SELECT OC_det.IdEmpresa, OC_det.IdSucursal, OC_det.IdOrdenCompra, OC_det.Secuencia, OC_det.do_Cantidad, OC_det.do_precioFinal, LTRIM(RTRIM(ISNULL(OC_det.do_observacion, ''))) + ' - ' + LTRIM(RTRIM(ISNULL(OC.oc_observacion, ''))) 
                  AS co_observacion, OC.oc_fecha, OC.Estado, OC.IdEstadoAprobacion_cat, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion AS nom_producto, dbo.in_Producto.pr_codigo, SUM(ISNULL(GUIA.Cantidad_enviar, 0)) 
                  AS Cantidad_enviar, ISNULL(OC_det.do_Cantidad - SUM(ISNULL(GUIA.Cantidad_enviar, 0)), 0) AS Saldo_x_Enviar, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.pr_nombre AS nom_proveedor, OC.oc_NumDocumento, 
                  dbo.ct_punto_cargo.nom_punto_cargo
FROM     dbo.com_ordencompra_local_det AS OC_det INNER JOIN
                  dbo.com_ordencompra_local AS OC ON OC_det.IdEmpresa = OC.IdEmpresa AND OC_det.IdSucursal = OC.IdSucursal AND OC_det.IdOrdenCompra = OC.IdOrdenCompra INNER JOIN
                  dbo.cp_proveedor ON OC.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND OC.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.in_Producto ON OC_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND OC_det.IdProducto = dbo.in_Producto.IdProducto LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON OC_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND OC_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  dbo.in_Guia_x_traspaso_bodega_det AS GUIA ON OC_det.IdEmpresa = GUIA.IdEmpresa_OC AND OC_det.IdSucursal = GUIA.IdSucursal_OC AND OC_det.IdOrdenCompra = GUIA.IdOrdenCompra_OC AND 
                  OC_det.Secuencia = GUIA.Secuencia_OC
GROUP BY OC_det.IdEmpresa, OC_det.IdSucursal, OC_det.IdOrdenCompra, OC_det.Secuencia, OC_det.do_Cantidad, OC_det.do_precioFinal, LTRIM(RTRIM(ISNULL(OC_det.do_observacion, ''))) + ' - ' + LTRIM(RTRIM(ISNULL(OC.oc_observacion, 
                  ''))), OC.oc_fecha, OC.Estado, OC.IdEstadoAprobacion_cat, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.pr_nombre, OC.oc_NumDocumento, 
                  dbo.ct_punto_cargo.nom_punto_cargo