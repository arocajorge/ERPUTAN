CREATE VIEW vwin_transferencia_det_ParaCorreccion
AS
SELECT dbo.in_transferencia_det.IdEmpresa, dbo.in_transferencia_det.IdSucursalOrigen, dbo.in_transferencia_det.IdBodegaOrigen, dbo.in_transferencia_det.IdTransferencia, dbo.in_transferencia_det.dt_secuencia, 
                  dbo.in_transferencia_det.IdProducto, dbo.in_transferencia_det.pr_descripcion, dbo.in_transferencia_det.dt_cantidad, dbo.in_transferencia_det.tr_Observacion, dbo.in_transferencia_det.IdUnidadMedida, 
                  dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion
FROM     dbo.in_transferencia_det INNER JOIN
                  dbo.in_transferencia ON dbo.in_transferencia_det.IdEmpresa = dbo.in_transferencia.IdEmpresa AND dbo.in_transferencia_det.IdSucursalOrigen = dbo.in_transferencia.IdSucursalOrigen AND 
                  dbo.in_transferencia_det.IdBodegaOrigen = dbo.in_transferencia.IdBodegaOrigen AND dbo.in_transferencia_det.IdTransferencia = dbo.in_transferencia.IdTransferencia LEFT OUTER JOIN
                  dbo.in_Ing_Egr_Inven_det ON dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Destino = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Destino = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                  dbo.in_transferencia.IdMovi_inven_tipo_SucuDest = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Destino = dbo.in_Ing_Egr_Inven_det.IdNumMovi AND 
                  dbo.in_transferencia_det.dt_secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia
WHERE  (dbo.in_transferencia.EstadoRevision = 'E')