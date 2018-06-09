

CREATE VIEW [dbo].[vwcom_GenerOCompra_Det]
AS
SELECT     GOC.IdEmpresa, GOC.IdTransaccion, GOC.IdDetTrans, GOC.IdProveedor, GOC.CodObra, GOC.IdOrdenTaller, GOC.Motivo, GOC.IdProducto, GOC.Cantidad, GOC.Kg, 
                      GOC.IdEstadoAprob, MR.Codigo AS mr_codigo, MR.descripcion AS mr_descripcion, EA.Codigo AS ea_codigo, EA.descripcion AS ea_descripcion, 
                      OT.Codigo AS ot_codigo, PROD.pr_descripcion, PROD.pr_codigo, OB.Descripcion AS ob_descripcion, PROV.pr_nombre AS prov_descripcion, GOC.FechaRequer, 
                      GOC.IdListadoMateriales, GOC.IdDetalle, GOC.precio, GOC.oc_IdEmpresa, GOC.oc_IdOrdenCompra, GOC.usuariosolicitante
FROM         dbo.com_GenerOCompra_Det AS GOC INNER JOIN
                      dbo.vwcom_EstadoAprobacion AS EA ON GOC.IdEstadoAprob = EA.Codigo INNER JOIN
                      dbo.prd_Orden_Taller AS OT ON GOC.IdEmpresa = OT.IdEmpresa AND GOC.CodObra = OT.CodObra AND GOC.IdOrdenTaller = OT.IdOrdenTaller INNER JOIN
                      dbo.vwcom_MotivoRequerimiento AS MR ON GOC.Motivo = MR.Codigo INNER JOIN
                      dbo.prd_Obra AS OB ON GOC.IdEmpresa = OB.IdEmpresa AND GOC.CodObra = OB.CodObra INNER JOIN
                      dbo.in_Producto AS PROD ON GOC.IdEmpresa = PROD.IdEmpresa AND GOC.IdProducto = PROD.IdProducto LEFT OUTER JOIN
                      dbo.cp_proveedor AS PROV ON GOC.IdEmpresa = PROV.IdEmpresa AND GOC.IdProveedor = PROV.IdProveedor