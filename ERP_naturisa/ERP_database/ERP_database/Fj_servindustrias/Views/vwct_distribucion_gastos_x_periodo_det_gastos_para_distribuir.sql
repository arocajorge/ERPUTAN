create view [Fj_servindustrias].[vwct_distribucion_gastos_x_periodo_det_gastos_para_distribuir]
as
SELECT        ct_plancta.IdEmpresa, ct_plancta.IdCtaCble, ct_plancta.pc_Cuenta,ct_cbtecble.IdPeriodo, SUM(ct_cbtecble_det.dc_Valor) AS dc_Valor
FROM            ct_cbtecble INNER JOIN
                         ct_cbtecble_det ON ct_cbtecble.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND 
                         ct_cbtecble.IdCbteCble = ct_cbtecble_det.IdCbteCble INNER JOIN
                         ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                         ct_grupocble ON ct_plancta.IdGrupoCble = ct_grupocble.IdGrupoCble
WHERE (ct_grupocble.gc_estado_financiero = 'ER') AND (ct_cbtecble_det.IdPunto_cargo IS NULL)
GROUP BY ct_plancta.IdEmpresa, ct_plancta.IdCtaCble,ct_plancta.pc_Cuenta, ct_cbtecble.IdPeriodo
HAVING round(SUM(ct_cbtecble_det.dc_Valor),2) <> 0
--ORDER BY ct_plancta.IdEmpresa, ct_plancta.IdCtaCble, ct_cbtecble.IdPeriodo