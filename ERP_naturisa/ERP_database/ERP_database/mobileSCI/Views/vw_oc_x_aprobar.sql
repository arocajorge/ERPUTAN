CREATE VIEW [mobileSCI].[vw_oc_x_aprobar]
AS
SELECT        ISNULL(ROW_NUMBER() OVER (ORDER BY dbo.com_ordencompra_local_det.IdEmpresa), 0) IdRow, dbo.com_ordencompra_local_det.IdEmpresa, dbo.com_ordencompra_local_det.IdSucursal, 
dbo.com_ordencompra_local_det.IdOrdenCompra, dbo.com_ordencompra_local_det.Secuencia, dbo.com_ordencompra_local_det.IdProducto, dbo.com_ordencompra_local_det.IdUnidadMedida, dbo.com_ordencompra_local.IdProveedor, 
isnull(SUM(dbo.com_ordencompra_local_det.do_Cantidad), 0) AS cant_oc, ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0) AS cant_in, isnull(SUM(dbo.com_ordencompra_local_det.do_Cantidad) 
- ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0), 0) AS saldo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, dbo.in_UnidadMedida.Descripcion, dbo.tb_persona.pe_nombreCompleto, 
dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.in_Producto.IdUnidadMedida_Consumo
FROM            dbo.tb_persona INNER JOIN
                         dbo.cp_proveedor INNER JOIN
                         dbo.com_ordencompra_local INNER JOIN
                         dbo.com_ordencompra_local_det ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND 
                         dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra ON dbo.cp_proveedor.IdEmpresa = dbo.com_ordencompra_local.IdEmpresa AND 
                         dbo.cp_proveedor.IdProveedor = dbo.com_ordencompra_local.IdProveedor INNER JOIN
                         dbo.in_Producto ON dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_ordencompra_local_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.in_UnidadMedida ON dbo.com_ordencompra_local_det.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida ON dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona INNER JOIN
                         mobileSCI.tbl_producto ON dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND 
                         dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND 
                         dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto AND dbo.in_Producto.IdEmpresa = mobileSCI.tbl_producto.IdEmpresa AND dbo.in_Producto.IdProducto = mobileSCI.tbl_producto.IdProducto LEFT OUTER JOIN
                         dbo.in_Ing_Egr_Inven INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi ON 
                         dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc AND dbo.com_ordencompra_local_det.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_oc AND 
                         dbo.com_ordencompra_local_det.IdOrdenCompra = dbo.in_Ing_Egr_Inven_det.IdOrdenCompra AND dbo.com_ordencompra_local_det.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia_oc
WHERE        (dbo.com_ordencompra_local.IdEstadoAprobacion_cat = 'APRO') AND (dbo.com_ordencompra_local.IdEstado_cierre <> 'CER') AND (dbo.com_ordencompra_local.Estado = 'A') AND 
                         (dbo.com_ordencompra_local.oc_fecha BETWEEN DATEADD(MONTH, - 3, GETDATE()) AND GETDATE())
GROUP BY dbo.com_ordencompra_local_det.IdEmpresa, dbo.com_ordencompra_local_det.IdSucursal, dbo.com_ordencompra_local_det.IdOrdenCompra, dbo.com_ordencompra_local_det.Secuencia, 
                         dbo.com_ordencompra_local_det.IdProducto, dbo.com_ordencompra_local_det.IdUnidadMedida, dbo.com_ordencompra_local.IdProveedor, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, 
                         dbo.in_UnidadMedida.Descripcion, dbo.tb_persona.pe_nombreCompleto, dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.in_Producto.IdUnidadMedida_Consumo
HAVING        (ROUND(SUM(dbo.com_ordencompra_local_det.do_Cantidad) - ISNULL(SUM(dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion), 0), 2) > 0)