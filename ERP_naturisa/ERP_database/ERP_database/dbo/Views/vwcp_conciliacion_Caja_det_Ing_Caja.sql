create view vwcp_conciliacion_Caja_det_Ing_Caja
as
SELECT        cp_conciliacion_Caja_det_Ing_Caja.IdEmpresa, cp_conciliacion_Caja_det_Ing_Caja.IdConciliacion_Caja, cp_conciliacion_Caja_det_Ing_Caja.secuencia, 
                         cp_conciliacion_Caja_det_Ing_Caja.IdEmpresa_movcaj, cp_conciliacion_Caja_det_Ing_Caja.IdCbteCble_movcaj, 
                         cp_conciliacion_Caja_det_Ing_Caja.IdTipocbte_movcaj, cp_conciliacion_Caja_det_Ing_Caja.valor_aplicado, caj_Caja_Movimiento.cm_observacion, 
                         caj_Caja_Movimiento.cm_valor, caj_Caja_Movimiento.cm_fecha, caj_Caja_Movimiento.IdPeriodo
FROM            cp_conciliacion_Caja_det_Ing_Caja INNER JOIN
                         caj_Caja_Movimiento ON cp_conciliacion_Caja_det_Ing_Caja.IdEmpresa_movcaj = caj_Caja_Movimiento.IdEmpresa AND 
                         cp_conciliacion_Caja_det_Ing_Caja.IdCbteCble_movcaj = caj_Caja_Movimiento.IdCbteCble AND 
                         cp_conciliacion_Caja_det_Ing_Caja.IdTipocbte_movcaj = caj_Caja_Movimiento.IdTipocbte