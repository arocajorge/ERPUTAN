CREATE VIEW [dbo].[vwprd_Saldos_Requerimientos_x_OT]
AS
SELECT     dbo.com_GenerOCompra_Det.IdEmpresa, dbo.com_GenerOCompra_Det.IdTransaccion, dbo.com_GenerOCompra_Det.IdDetTrans, 
                      dbo.com_GenerOCompra_Det.IdProveedor, dbo.com_GenerOCompra_Det.CodObra, dbo.com_GenerOCompra_Det.IdOrdenTaller, 
                      dbo.com_GenerOCompra_Det.IdProducto, dbo.com_GenerOCompra_Det.Cantidad, dbo.com_GenerOCompra.IdSucursal, dbo.prd_Orden_Taller.Codigo, 
                      dbo.com_GenerOCompra_Det.IdListadoMateriales, dbo.com_GenerOCompra_Det.IdDetalle, dbo.com_GenerOCompra_Det.oc_IdEmpresa, 
                      dbo.com_GenerOCompra_Det.oc_IdOrdenCompra, dbo.com_GenerOCompra_Det.IdEstadoAprob, dbo.com_ordencompra_local.oc_NumDocumento, 
                      dbo.com_ordencompra_local.IdEstadoRecepcion_cat EstadoRecepcion
FROM         dbo.com_GenerOCompra_Det INNER JOIN
                      dbo.com_GenerOCompra ON dbo.com_GenerOCompra_Det.IdEmpresa = dbo.com_GenerOCompra.IdEmpresa AND 
                      dbo.com_GenerOCompra_Det.IdTransaccion = dbo.com_GenerOCompra.IdTransaccion INNER JOIN
                      dbo.prd_Orden_Taller ON dbo.com_GenerOCompra.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                      dbo.com_GenerOCompra.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND dbo.com_GenerOCompra_Det.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller AND 
                      dbo.com_GenerOCompra_Det.CodObra = dbo.prd_Orden_Taller.CodObra INNER JOIN
                      dbo.com_ordencompra_local ON dbo.com_GenerOCompra_Det.oc_IdEmpresa = dbo.com_ordencompra_local.IdEmpresa AND 
                      dbo.com_GenerOCompra_Det.oc_IdOrdenCompra = dbo.com_ordencompra_local.IdOrdenCompra AND 
                      dbo.com_GenerOCompra.IdSucursal = dbo.com_ordencompra_local.IdSucursal
WHERE     (dbo.com_GenerOCompra_Det.IdEstadoAprob = 'COMP') AND (dbo.com_ordencompra_local.IdEstadoRecepcion_cat = 'REC')