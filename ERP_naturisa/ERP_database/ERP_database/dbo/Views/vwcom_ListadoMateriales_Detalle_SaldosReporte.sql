
CREATE view [dbo].[vwcom_ListadoMateriales_Detalle_SaldosReporte] as

SELECT        dbo.prd_Obra.IdEmpresa, dbo.prd_Orden_Taller.IdSucursal, dbo.prd_Obra.CodObra, dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdListadoMateriales, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdDetalle, dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdProducto, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.Unidades, dbo.vwcom_ListadoMateriales_Detalle_Saldos.Det_Kg, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.pr_codigo, dbo.vwcom_ListadoMateriales_Detalle_Saldos.pr_descripcion, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdEstadoAprob, dbo.vwcom_ListadoMateriales_Detalle_Saldos.FechaReg, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.Estado, dbo.vwcom_ListadoMateriales_Detalle_Saldos.lm_Observacion, 
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdCategoria, dbo.vwcom_ListadoMateriales_Detalle_Saldos.saldo, dbo.tb_sucursal.Su_Descripcion, 
                         dbo.prd_Orden_Taller.Observacion, dbo.prd_Obra.Descripcion
FROM            dbo.prd_Orden_Taller INNER JOIN
                         dbo.prd_Obra ON dbo.prd_Orden_Taller.IdEmpresa = dbo.prd_Obra.IdEmpresa AND dbo.prd_Orden_Taller.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                         dbo.tb_sucursal ON dbo.prd_Orden_Taller.IdSucursal = dbo.tb_sucursal.IdSucursal AND dbo.prd_Orden_Taller.IdEmpresa = dbo.tb_sucursal.IdEmpresa INNER JOIN
                         dbo.vwcom_ListadoMateriales_Detalle_Saldos ON dbo.prd_Orden_Taller.IdEmpresa = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdEmpresa AND 
                         dbo.prd_Obra.CodObra = dbo.vwcom_ListadoMateriales_Detalle_Saldos.CodObra AND 
                         dbo.prd_Obra.IdEmpresa = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdEmpresa AND 
                         dbo.prd_Orden_Taller.IdOrdenTaller = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdOrdenTaller