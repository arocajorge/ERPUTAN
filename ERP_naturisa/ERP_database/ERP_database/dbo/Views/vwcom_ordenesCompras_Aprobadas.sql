
CREATE VIEW [dbo].[vwcom_ordenesCompras_Aprobadas]
AS
SELECT        dbo.com_GenerOCompra.IdEmpresa, dbo.com_GenerOCompra.IdSucursal, dbo.com_GenerOCompra.FechaReg, dbo.com_GenerOCompra.g_ocObservacion, 
                         dbo.com_GenerOCompra.Estado, dbo.cp_proveedor.pr_nombre, dbo.com_GenerOCompra_Det.precio, dbo.com_GenerOCompra_Det.IdDetalle, 
                         dbo.com_GenerOCompra_Det.IdListadoMateriales, dbo.com_GenerOCompra_Det.FechaRequer, dbo.com_GenerOCompra_Det.IdEstadoAprob, 
                         dbo.com_GenerOCompra_Det.Kg, dbo.com_GenerOCompra_Det.Cantidad, dbo.com_GenerOCompra_Det.IdProducto, dbo.com_GenerOCompra_Det.Motivo, 
                         dbo.com_GenerOCompra_Det.IdOrdenTaller, dbo.com_GenerOCompra_Det.CodObra, dbo.com_GenerOCompra_Det.IdProveedor, 
                         dbo.vwcom_AllListDetMateriales.pr_descripcion, dbo.com_GenerOCompra.IdTransaccion, dbo.com_GenerOCompra_Det.IdDetTrans
FROM            dbo.com_GenerOCompra INNER JOIN
                         dbo.com_GenerOCompra_Det ON dbo.com_GenerOCompra.IdEmpresa = dbo.com_GenerOCompra_Det.IdEmpresa AND 
                         dbo.com_GenerOCompra.IdTransaccion = dbo.com_GenerOCompra_Det.IdTransaccion INNER JOIN
                         dbo.cp_proveedor ON dbo.com_GenerOCompra_Det.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                         dbo.com_GenerOCompra_Det.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.vwcom_AllListDetMateriales ON dbo.com_GenerOCompra_Det.IdProducto = dbo.vwcom_AllListDetMateriales.IdProducto AND 
                         dbo.com_GenerOCompra_Det.IdDetalle = dbo.vwcom_AllListDetMateriales.IdDetalle AND 
                         dbo.com_GenerOCompra_Det.IdOrdenTaller = dbo.vwcom_AllListDetMateriales.IdOrdenTaller AND 
                         dbo.com_GenerOCompra_Det.CodObra = dbo.vwcom_AllListDetMateriales.CodObra