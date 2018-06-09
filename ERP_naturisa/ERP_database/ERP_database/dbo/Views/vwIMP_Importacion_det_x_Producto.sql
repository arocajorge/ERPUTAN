CREATE view [dbo].[vwIMP_Importacion_det_x_Producto]
as
SELECT      IdEmpresa,cast(IdEmpresa as varchar(10))+ cast(IdSucursal as varchar(10)) +cast(IdProducto as varchar(10))  IdProducto, IdOrdenCompraExt
FROM         imp_ordencompra_ext_det