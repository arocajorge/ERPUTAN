CREATE view [dbo].[vwin_Ing_Egr_Inven_para_devolucion]
as
SELECT        dbo.in_Ing_Egr_Inven.IdEmpresa, dbo.in_Ing_Egr_Inven.IdSucursal, dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven.IdNumMovi, 
                         ISNULL(SUM(ABS(dbo.in_devolucion_inven_det.cantidad_devuelta)), 0) AS cantidad_devuelta, SUM(ABS(dbo.in_movi_inve_detalle.dm_cantidad)) AS cantidad_movimiento, dbo.in_Ing_Egr_Inven.cm_fecha, 
                         dbo.in_Ing_Egr_Inven.cm_observacion, dbo.in_Ing_Egr_Inven.signo, dbo.tb_sucursal.Su_Descripcion, dbo.in_movi_inven_tipo.tm_descripcion, dbo.in_Ing_Egr_Inven.CodMoviInven
FROM            dbo.in_Ing_Egr_Inven INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                         dbo.in_movi_inve_detalle ON dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv = dbo.in_movi_inve_detalle.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal_inv = dbo.in_movi_inve_detalle.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdBodega_inv = dbo.in_movi_inve_detalle.IdBodega AND dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv = dbo.in_movi_inve_detalle.IdNumMovi AND dbo.in_Ing_Egr_Inven_det.secuencia_inv = dbo.in_movi_inve_detalle.Secuencia INNER JOIN
                         dbo.in_movi_inve ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve.IdBodega AND dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve.IdNumMovi INNER JOIN
                         dbo.in_movi_inven_tipo ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo LEFT OUTER JOIN
                         dbo.tb_sucursal ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                         dbo.in_devolucion_inven_det ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_devolucion_inven_det.IdEmpresa_movi_inv AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_devolucion_inven_det.IdSucursal_movi_inv AND dbo.in_movi_inve_detalle.IdBodega = dbo.in_devolucion_inven_det.IdBodega_movi_inv AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_devolucion_inven_det.IdMovi_inven_tipo_movi_inv AND dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_devolucion_inven_det.IdNumMovi_movi_inv AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_devolucion_inven_det.Secuencia_movi_inv
GROUP BY dbo.in_Ing_Egr_Inven.IdEmpresa, dbo.in_Ing_Egr_Inven.IdSucursal, dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven.IdNumMovi, dbo.in_Ing_Egr_Inven.cm_fecha, 
                         dbo.in_Ing_Egr_Inven.cm_observacion, dbo.in_Ing_Egr_Inven.signo, dbo.tb_sucursal.Su_Descripcion, dbo.in_movi_inven_tipo.tm_descripcion, dbo.in_Ing_Egr_Inven.CodMoviInven
HAVING        (SUM(ABS(dbo.in_movi_inve_detalle.dm_cantidad)) - ISNULL(SUM(ABS(dbo.in_devolucion_inven_det.cantidad_devuelta)), 0) > 0)