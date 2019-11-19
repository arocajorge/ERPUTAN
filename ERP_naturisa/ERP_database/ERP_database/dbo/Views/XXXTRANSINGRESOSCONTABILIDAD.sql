CREATE VIEW XXXTRANSINGRESOSCONTABILIDAD
AS
SELECT        in_transferencia.IdEmpresa, in_transferencia.IdSucursalOrigen, in_transferencia.IdBodegaOrigen, in_transferencia.IdTransferencia, in_movi_inve_x_ct_cbteCble.IdEmpresa_ct, in_movi_inve_x_ct_cbteCble.IdTipoCbte, 
                         in_movi_inve_x_ct_cbteCble.IdCbteCble, CT.IdCtaCble, CT.dc_Valor, in_transferencia.tr_fecha
FROM            in_Ing_Egr_Inven_det INNER JOIN
                         in_Ing_Egr_Inven ON in_Ing_Egr_Inven_det.IdEmpresa = in_Ing_Egr_Inven.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = in_Ing_Egr_Inven.IdSucursal AND 
                         in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_Ing_Egr_Inven.IdMovi_inven_tipo AND in_Ing_Egr_Inven_det.IdNumMovi = in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                         in_transferencia ON in_Ing_Egr_Inven.IdEmpresa = in_transferencia.IdEmpresa_Ing_Egr_Inven_Origen AND in_Ing_Egr_Inven.IdSucursal = in_transferencia.IdSucursal_Ing_Egr_Inven_Origen AND 
                         in_Ing_Egr_Inven.IdMovi_inven_tipo = in_transferencia.IdMovi_inven_tipo_SucuOrig AND in_Ing_Egr_Inven.IdNumMovi = in_transferencia.IdNumMovi_Ing_Egr_Inven_Origen INNER JOIN
                         in_movi_inve_x_ct_cbteCble ON in_Ing_Egr_Inven_det.IdEmpresa_inv = in_movi_inve_x_ct_cbteCble.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal_inv = in_movi_inve_x_ct_cbteCble.IdSucursal AND 
                         in_Ing_Egr_Inven_det.IdBodega_inv = in_movi_inve_x_ct_cbteCble.IdBodega AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = in_movi_inve_x_ct_cbteCble.IdMovi_inven_tipo AND 
                         in_Ing_Egr_Inven_det.IdNumMovi_inv = in_movi_inve_x_ct_cbteCble.IdNumMovi LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdTipoCbte, IdCbteCble, IdCtaCble, dc_Valor
                               FROM            ct_cbtecble_det) AS CT ON in_movi_inve_x_ct_cbteCble.IdCbteCble = CT.IdCbteCble AND in_movi_inve_x_ct_cbteCble.IdTipoCbte = CT.IdTipoCbte AND 
                         CT.IdEmpresa = in_movi_inve_x_ct_cbteCble.IdEmpresa_ct
where in_transferencia.IdEmpresa = 1 and in_transferencia.tr_fecha between datefromparts(2018,8,1) and datefromparts(2018,8,31) and CT.IdCtaCble = '1010501010010044' and CT.dc_Valor < 0
GROUP BY in_transferencia.IdEmpresa, in_transferencia.IdSucursalOrigen, in_transferencia.IdBodegaOrigen, in_transferencia.IdTransferencia, in_movi_inve_x_ct_cbteCble.IdEmpresa_ct, in_movi_inve_x_ct_cbteCble.IdTipoCbte, 
                         in_movi_inve_x_ct_cbteCble.IdCbteCble, CT.IdCtaCble, CT.dc_Valor, in_transferencia.tr_fecha