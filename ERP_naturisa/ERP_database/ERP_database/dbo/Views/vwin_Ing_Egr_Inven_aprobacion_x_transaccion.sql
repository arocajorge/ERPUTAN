CREATE VIEW vwin_Ing_Egr_Inven_aprobacion_x_transaccion
AS
SELECT in_Ing_Egr_Inven.IdEmpresa, in_Ing_Egr_Inven.IdSucursal, in_Ing_Egr_Inven.IdMovi_inven_tipo, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.signo, in_Ing_Egr_Inven.cm_observacion, in_Ing_Egr_Inven.cm_fecha, 
                  tb_sucursal.Su_Descripcion, in_movi_inven_tipo.tm_descripcion, in_Ing_Egr_Inven.CodMoviInven
FROM     in_Ing_Egr_Inven_det INNER JOIN
                  in_Ing_Egr_Inven ON in_Ing_Egr_Inven_det.IdEmpresa = in_Ing_Egr_Inven.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = in_Ing_Egr_Inven.IdSucursal AND 
                  in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_Ing_Egr_Inven.IdMovi_inven_tipo AND in_Ing_Egr_Inven_det.IdNumMovi = in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                  tb_sucursal ON in_Ing_Egr_Inven.IdEmpresa = tb_sucursal.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = tb_sucursal.IdSucursal LEFT OUTER JOIN
                  in_movi_inven_tipo ON in_Ing_Egr_Inven.IdEmpresa = in_movi_inven_tipo.IdEmpresa AND in_Ing_Egr_Inven.IdMovi_inven_tipo = in_movi_inven_tipo.IdMovi_inven_tipo LEFT OUTER JOIN
                  in_Motivo_Inven ON in_Ing_Egr_Inven.IdEmpresa = in_Motivo_Inven.IdEmpresa AND in_Ing_Egr_Inven.IdMotivo_Inv = in_Motivo_Inven.IdMotivo_Inv
WHERE  (in_Motivo_Inven.Genera_Movi_Inven = 'S') AND (in_Ing_Egr_Inven.Estado = 'A') AND (in_Ing_Egr_Inven_det.IdEstadoAproba = 'PEND') AND (in_Ing_Egr_Inven_det.IdNumMovi_inv IS NULL)
GROUP BY in_Ing_Egr_Inven.IdEmpresa, in_Ing_Egr_Inven.IdSucursal, in_Ing_Egr_Inven.IdMovi_inven_tipo, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.signo, in_Ing_Egr_Inven.cm_observacion, in_Ing_Egr_Inven.cm_fecha, 
                  tb_sucursal.Su_Descripcion, in_movi_inven_tipo.tm_descripcion,in_Ing_Egr_Inven.CodMoviInven