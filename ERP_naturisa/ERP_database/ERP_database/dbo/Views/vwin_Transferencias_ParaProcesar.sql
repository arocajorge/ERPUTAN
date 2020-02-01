CREATE VIEW [dbo].[vwin_Transferencias_ParaProcesar]
AS
SELECT        SucuOrig.Su_Descripcion AS SucuOrigen, bodegaOri.bo_Descripcion AS BodegaORIG, sucuDest.Su_Descripcion AS SucuDEST, bodegaDes.bo_Descripcion AS BodegDest, dbo.in_transferencia.IdEmpresa, 
                         dbo.in_transferencia.IdSucursalOrigen, dbo.in_transferencia.IdBodegaOrigen, dbo.in_transferencia.IdTransferencia, dbo.in_transferencia.IdSucursalDest, dbo.in_transferencia.IdBodegaDest, 
                         dbo.in_transferencia.tr_Observacion, dbo.in_transferencia.tr_fecha, dbo.in_transferencia.Estado, dbo.in_transferencia.IdUsuario, dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Origen, 
                         dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Origen, dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Origen, dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Destino, 
                         dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Destino, dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Destino, dbo.in_transferencia.tr_fechaAnulacion, dbo.in_transferencia.tr_userAnulo, dbo.in_transferencia.Codigo, 
                         dbo.in_transferencia.IdMovi_inven_tipo_SucuOrig, dbo.in_transferencia.IdMovi_inven_tipo_SucuDest, MIN(Ingreso_det.IdEstadoAproba) AS IdEstadoAproba_ing, MIN(Egreso_det.IdEstadoAproba) AS IdEstadoAproba_egr, 
                         dbo.in_transferencia.IdGuia, dbo.in_transferencia.EstadoRevision, dbo.in_transferencia.IdUsuarioRevision, dbo.in_transferencia.FechaRevision
FROM            dbo.in_Ing_Egr_Inven_det AS Egreso_det INNER JOIN
                         dbo.in_Ing_Egr_Inven AS Egreso ON Egreso_det.IdEmpresa = Egreso.IdEmpresa AND Egreso_det.IdSucursal = Egreso.IdSucursal AND Egreso_det.IdMovi_inven_tipo = Egreso.IdMovi_inven_tipo AND 
                         Egreso_det.IdNumMovi = Egreso.IdNumMovi RIGHT OUTER JOIN
                         dbo.in_Ing_Egr_Inven AS Ingreso INNER JOIN
                         dbo.in_Ing_Egr_Inven_det AS Ingreso_det ON Ingreso.IdEmpresa = Ingreso_det.IdEmpresa AND Ingreso.IdSucursal = Ingreso_det.IdSucursal AND Ingreso.IdMovi_inven_tipo = Ingreso_det.IdMovi_inven_tipo AND 
                         Ingreso.IdNumMovi = Ingreso_det.IdNumMovi RIGHT OUTER JOIN
                         dbo.tb_bodega AS bodegaDes INNER JOIN
                         dbo.tb_sucursal AS sucuDest ON bodegaDes.IdEmpresa = sucuDest.IdEmpresa AND bodegaDes.IdSucursal = sucuDest.IdSucursal INNER JOIN
                         dbo.in_transferencia INNER JOIN
                         dbo.tb_bodega AS bodegaOri ON dbo.in_transferencia.IdEmpresa = bodegaOri.IdEmpresa AND dbo.in_transferencia.IdBodegaOrigen = bodegaOri.IdBodega AND 
                         dbo.in_transferencia.IdSucursalOrigen = bodegaOri.IdSucursal INNER JOIN
                         dbo.tb_sucursal AS SucuOrig ON bodegaOri.IdEmpresa = SucuOrig.IdEmpresa AND bodegaOri.IdSucursal = SucuOrig.IdSucursal ON bodegaDes.IdEmpresa = dbo.in_transferencia.IdEmpresa AND 
                         bodegaDes.IdBodega = dbo.in_transferencia.IdBodegaDest AND bodegaDes.IdSucursal = dbo.in_transferencia.IdSucursalDest ON Ingreso.IdEmpresa = dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Destino AND 
                         Ingreso.IdSucursal = dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Destino AND Ingreso.IdMovi_inven_tipo = dbo.in_transferencia.IdMovi_inven_tipo_SucuDest AND 
                         Ingreso.IdNumMovi = dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Destino ON Egreso.IdEmpresa = dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Origen AND 
                         Egreso.IdSucursal = dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Origen AND Egreso.IdMovi_inven_tipo = dbo.in_transferencia.IdMovi_inven_tipo_SucuOrig AND 
                         Egreso.IdNumMovi = dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Origen
WHERE        (dbo.in_transferencia.EstadoRevision IN ('P', 'E')) and dbo.in_transferencia.EStado = 'A'
GROUP BY SucuOrig.Su_Descripcion, bodegaOri.bo_Descripcion, sucuDest.Su_Descripcion, bodegaDes.bo_Descripcion, dbo.in_transferencia.IdEmpresa, dbo.in_transferencia.IdSucursalOrigen, dbo.in_transferencia.IdBodegaOrigen, 
                         dbo.in_transferencia.IdTransferencia, dbo.in_transferencia.IdSucursalDest, dbo.in_transferencia.IdBodegaDest, dbo.in_transferencia.tr_Observacion, dbo.in_transferencia.tr_fecha, dbo.in_transferencia.Estado, 
                         dbo.in_transferencia.IdUsuario, dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Origen, dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Origen, dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Origen, 
                         dbo.in_transferencia.IdEmpresa_Ing_Egr_Inven_Destino, dbo.in_transferencia.IdSucursal_Ing_Egr_Inven_Destino, dbo.in_transferencia.IdNumMovi_Ing_Egr_Inven_Destino, dbo.in_transferencia.tr_fechaAnulacion, 
                         dbo.in_transferencia.tr_userAnulo, dbo.in_transferencia.Codigo, dbo.in_transferencia.IdMovi_inven_tipo_SucuOrig, dbo.in_transferencia.IdMovi_inven_tipo_SucuDest, dbo.in_transferencia.IdGuia, 
                         dbo.in_transferencia.EstadoRevision, dbo.in_transferencia.IdUsuarioRevision, dbo.in_transferencia.FechaRevision