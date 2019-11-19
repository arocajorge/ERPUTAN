CREATE VIEW XXXTRANSFERENCIA_CON_MAL_COSTO
AS
SELECT        in_transferencia.IdEmpresa, case when in_transferencia.IdEmpresa = 1 then 'NATURISA' WHEN in_transferencia.IdEmpresa = 3 THEN 'RIO NILO' END AS Empresa, in_transferencia.tr_fecha, in_transferencia.IdSucursalOrigen, in_transferencia.IdBodegaOrigen, in_transferencia.IdTransferencia, sue.Su_Descripcion AS SucursalEgr, 
                         sui.Su_Descripcion AS SucursalIng,mov_ing.IdProducto, p.pr_descripcion, mov_egr.mv_costo AS costo_egr, mov_ing.mv_costo AS costo_ing
FROM            in_transferencia INNER JOIN
                         in_Ing_Egr_Inven_det AS egr ON in_transferencia.IdEmpresa_Ing_Egr_Inven_Origen = egr.IdEmpresa AND in_transferencia.IdSucursal_Ing_Egr_Inven_Origen = egr.IdSucursal AND 
                         in_transferencia.IdMovi_inven_tipo_SucuOrig = egr.IdMovi_inven_tipo AND in_transferencia.IdNumMovi_Ing_Egr_Inven_Origen = egr.IdNumMovi INNER JOIN
                         in_Ing_Egr_Inven_det AS ing ON in_transferencia.IdEmpresa_Ing_Egr_Inven_Destino = ing.IdEmpresa AND in_transferencia.IdSucursal_Ing_Egr_Inven_Destino = ing.IdSucursal AND 
                         in_transferencia.IdMovi_inven_tipo_SucuDest = ing.IdMovi_inven_tipo AND in_transferencia.IdNumMovi_Ing_Egr_Inven_Destino = ing.IdNumMovi AND egr.Secuencia = ing.Secuencia INNER JOIN
                         in_movi_inve_detalle AS mov_egr ON egr.IdEmpresa_inv = mov_egr.IdEmpresa AND egr.IdSucursal_inv = mov_egr.IdSucursal AND egr.IdBodega_inv = mov_egr.IdBodega AND 
                         egr.IdMovi_inven_tipo_inv = mov_egr.IdMovi_inven_tipo AND egr.IdNumMovi_inv = mov_egr.IdNumMovi AND egr.secuencia_inv = mov_egr.Secuencia INNER JOIN
                         in_movi_inve_detalle AS mov_ing ON ing.IdEmpresa_inv = mov_ing.IdEmpresa AND ing.IdSucursal_inv = mov_ing.IdSucursal AND ing.IdBodega_inv = mov_ing.IdBodega AND ing.IdNumMovi_inv = mov_ing.IdNumMovi AND 
                         ing.IdMovi_inven_tipo_inv = mov_ing.IdMovi_inven_tipo AND ing.secuencia_inv = mov_ing.Secuencia INNER JOIN
                         in_Producto AS p ON mov_ing.IdEmpresa = p.IdEmpresa AND mov_ing.IdProducto = p.IdProducto INNER JOIN
                         tb_sucursal AS sue ON mov_egr.IdEmpresa = sue.IdEmpresa AND mov_egr.IdSucursal = sue.IdSucursal INNER JOIN
                         tb_sucursal AS sui ON mov_ing.IdEmpresa = sui.IdEmpresa AND mov_ing.IdSucursal = sui.IdSucursal
WHERE        (ROUND(mov_egr.mv_costo - mov_ing.mv_costo, 2) <> 0) and in_transferencia.tr_fecha > dateadd(month,-3,getdate())