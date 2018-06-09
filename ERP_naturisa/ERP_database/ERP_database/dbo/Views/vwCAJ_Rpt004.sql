CREATE view [dbo].[vwCAJ_Rpt004]
as
SELECT        ISNULL(ROW_NUMBER() OVER (ORDER BY A.IdEmpresa), 0) AS IdRow, A.*
FROM            (/* querry `para extraer el gasto que no es la caja*/ SELECT cp_conciliacion_Caja.IdEmpresa, cp_conciliacion_Caja.IdConciliacion_Caja, cp_conciliacion_Caja.IdCaja,
                                                     cp_conciliacion_Caja.Fecha_ini, cp_conciliacion_Caja.Fecha_fin, cp_conciliacion_Caja.IdEstadoCierre, ct_cbtecble_det.IdCtaCble, 
                                                    ct_plancta.pc_clave_corta, ct_plancta.pc_Cuenta, ct_cbtecble_det.dc_Valor AS Debe, 0 AS Haber, ct_cbtecble_det.dc_Observacion, 
                                                    ct_cbtecble_det.IdEmpresa AS IdEmpresa_cbte, ct_cbtecble_tipo.tc_TipoCbte AS nom_tipo_cbte, ct_cbtecble_det.IdTipoCbte, ct_cbtecble_det.IdCbteCble, 
                                                    caj_Caja.ca_Descripcion AS nom_caja, ct_cbtecble.cb_Fecha
                          FROM            ct_cbtecble_det INNER JOIN
                                                    ct_cbtecble ON ct_cbtecble_det.IdEmpresa = ct_cbtecble.IdEmpresa AND ct_cbtecble_det.IdTipoCbte = ct_cbtecble.IdTipoCbte AND 
                                                    ct_cbtecble_det.IdCbteCble = ct_cbtecble.IdCbteCble INNER JOIN
                                                    cp_conciliacion_Caja_det_x_ValeCaja INNER JOIN
                                                    cp_conciliacion_Caja ON cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa = cp_conciliacion_Caja.IdEmpresa AND 
                                                    cp_conciliacion_Caja_det_x_ValeCaja.IdConciliacion_Caja = cp_conciliacion_Caja.IdConciliacion_Caja ON 
                                                    ct_cbtecble_det.IdCtaCble <> cp_conciliacion_Caja.IdCtaCble AND 
                                                    ct_cbtecble.IdEmpresa = cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja AND 
                                                    ct_cbtecble.IdCbteCble = cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja AND 
                                                    ct_cbtecble.IdTipoCbte = cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja INNER JOIN
                                                    ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                                                    ct_cbtecble_tipo ON ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte INNER JOIN
                                                    caj_Caja ON cp_conciliacion_Caja.IdEmpresa = caj_Caja.IdEmpresa AND cp_conciliacion_Caja.IdCaja = caj_Caja.IdCaja
                          UNION ALL
                          /* querry `para extraer la caja y se agrupa*/ SELECT cp_conciliacion_Caja.IdEmpresa, cp_conciliacion_Caja.IdConciliacion_Caja, cp_conciliacion_Caja.IdCaja, 
                                                   cp_conciliacion_Caja.Fecha_ini, cp_conciliacion_Caja.Fecha_fin, cp_conciliacion_Caja.IdEstadoCierre, ct_cbtecble_det.IdCtaCble, 
                                                   ct_plancta.pc_clave_corta, ct_plancta.pc_Cuenta, 0 AS Debe, abs(sum(ct_cbtecble_det.dc_Valor)) AS Haber, NULL AS dc_Observacion, NULL 
                                                   AS IdEmpresa, NULL AS IdTipoCbte, NULL AS nom_tipo_cbte, NULL AS IdCbteCble, caj_Caja.ca_Descripcion,null as cb_Fecha
                          FROM            ct_cbtecble_det INNER JOIN
                                                   ct_cbtecble ON ct_cbtecble_det.IdEmpresa = ct_cbtecble.IdEmpresa AND ct_cbtecble_det.IdTipoCbte = ct_cbtecble.IdTipoCbte AND 
                                                   ct_cbtecble_det.IdCbteCble = ct_cbtecble.IdCbteCble INNER JOIN
                                                   cp_conciliacion_Caja_det_x_ValeCaja INNER JOIN
                                                   cp_conciliacion_Caja ON cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa = cp_conciliacion_Caja.IdEmpresa AND 
                                                   cp_conciliacion_Caja_det_x_ValeCaja.IdConciliacion_Caja = cp_conciliacion_Caja.IdConciliacion_Caja ON 
                                                   ct_cbtecble_det.IdCtaCble = cp_conciliacion_Caja.IdCtaCble AND ct_cbtecble.IdEmpresa = cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja AND
                                                    ct_cbtecble.IdCbteCble = cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja AND 
                                                   ct_cbtecble.IdTipoCbte = cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja AND 
                                                   ct_cbtecble_det.IdCtaCble = cp_conciliacion_Caja.IdCtaCble INNER JOIN
                                                   ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                                                   ct_cbtecble_tipo ON ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte INNER JOIN
                                                   caj_Caja ON cp_conciliacion_Caja.IdEmpresa = caj_Caja.IdEmpresa AND cp_conciliacion_Caja.IdCaja = caj_Caja.IdCaja
                          GROUP BY cp_conciliacion_Caja.IdEmpresa, cp_conciliacion_Caja.IdConciliacion_Caja, cp_conciliacion_Caja.IdCaja, cp_conciliacion_Caja.Fecha_ini, 
                                                   cp_conciliacion_Caja.Fecha_fin, cp_conciliacion_Caja.IdEstadoCierre, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_Cuenta, ct_plancta.pc_clave_corta, 
                                                   caj_Caja.ca_Descripcion
                          UNION ALL
                          SELECT        cp_conciliacion_Caja.IdEmpresa, cp_conciliacion_Caja.IdConciliacion_Caja, cp_conciliacion_Caja.IdCaja, cp_conciliacion_Caja.Fecha_ini, 
                                                   cp_conciliacion_Caja.Fecha_fin, cp_conciliacion_Caja.IdEstadoCierre, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_clave_corta, ct_plancta.pc_Cuenta, 
                                                   ct_cbtecble_det.dc_Valor AS Debe, 0 AS Haber, ct_cbtecble_det.dc_Observacion, ct_cbtecble_det.IdEmpresa AS IdEmpresa_cbte, 
                                                   ct_cbtecble_tipo.tc_TipoCbte AS nom_tipo_cbte, ct_cbtecble_det.IdTipoCbte, ct_cbtecble_det.IdCbteCble, caj_Caja.ca_Descripcion AS nom_caja,
												   ct_cbtecble.cb_Fecha
                          FROM            cp_orden_pago_cancelaciones INNER JOIN
                                                   ct_cbtecble_det INNER JOIN
                                                   ct_cbtecble ON ct_cbtecble_det.IdEmpresa = ct_cbtecble.IdEmpresa AND ct_cbtecble_det.IdTipoCbte = ct_cbtecble.IdTipoCbte AND 
                                                   ct_cbtecble_det.IdCbteCble = ct_cbtecble.IdCbteCble INNER JOIN
                                                   ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                                                   ct_cbtecble_tipo ON ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte ON 
                                                   cp_orden_pago_cancelaciones.IdEmpresa_pago = ct_cbtecble.IdEmpresa AND 
                                                   cp_orden_pago_cancelaciones.IdTipoCbte_pago = ct_cbtecble.IdTipoCbte AND 
                                                   cp_orden_pago_cancelaciones.IdCbteCble_pago = ct_cbtecble.IdCbteCble INNER JOIN
                                                   caj_Caja INNER JOIN
                                                   cp_conciliacion_Caja ON caj_Caja.IdEmpresa = cp_conciliacion_Caja.IdEmpresa AND caj_Caja.IdCaja = cp_conciliacion_Caja.IdCaja INNER JOIN
                                                   cp_conciliacion_Caja_det ON cp_conciliacion_Caja.IdEmpresa = cp_conciliacion_Caja_det.IdEmpresa AND 
                                                   cp_conciliacion_Caja.IdConciliacion_Caja = cp_conciliacion_Caja_det.IdConciliacion_Caja ON 
                                                   cp_orden_pago_cancelaciones.IdEmpresa_cxp = cp_conciliacion_Caja_det.IdEmpresa_OGiro AND 
                                                   cp_orden_pago_cancelaciones.IdTipoCbte_cxp = cp_conciliacion_Caja_det.IdTipoCbte_Ogiro AND 
                                                   cp_orden_pago_cancelaciones.IdCbteCble_cxp = cp_conciliacion_Caja_det.IdCbteCble_Ogiro AND 
                                                   ct_cbtecble_det.IdCtaCble <> cp_conciliacion_Caja.IdCtaCble
                          UNION ALL
                          SELECT        conci.IdEmpresa, conci.IdConciliacion_Caja, conci.IdCaja, conci.Fecha_ini, conci.Fecha_fin, conci.IdEstadoCierre, ct_det.IdCtaCble, 
                                                   dbo.ct_plancta.pc_clave_corta, dbo.ct_plancta.pc_Cuenta, 0 AS Debe, ABS(SUM(ct_det.dc_Valor)) AS Haber, NULL AS dc_Observacion, NULL 
                                                   AS IdEmpresa_cbte, NULL AS IdTipoCbte, NULL AS nom_tipo_cbte, NULL AS IdCbteCble, dbo.caj_Caja.ca_Descripcion AS nom_caja, null as cb_Fecha
                          FROM            cp_conciliacion_Caja_det conci_det INNER JOIN
                                                   cp_orden_pago_cancelaciones canc ON canc.IdEmpresa_op = conci_det.IdEmpresa_OP AND 
                                                   canc.IdOrdenPago_op = conci_det.IdOrdenPago_OP INNER JOIN
                                                   ct_cbtecble_det ct_det ON ct_det.IdEmpresa = canc.IdEmpresa_pago AND ct_det.IdTipoCbte = canc.IdTipoCbte_pago AND 
                                                   ct_det.IdCbteCble = canc.IdCbteCble_pago INNER JOIN
                                                   cp_conciliacion_Caja conci ON conci.IdEmpresa = conci_det.IdEmpresa AND conci.IdConciliacion_Caja = conci_det.IdConciliacion_Caja AND 
                                                   conci.IdCtaCble = ct_det.IdCtaCble INNER JOIN
                                                   ct_plancta ON ct_plancta.IdEmpresa = ct_det.IdEmpresa AND ct_plancta.IdCtaCble = ct_det.IdCtaCble INNER JOIN
                                                   ct_cbtecble_tipo ON ct_cbtecble_tipo.IdEmpresa = ct_det.IdEmpresa AND ct_cbtecble_tipo.IdTipoCbte = ct_det.IdTipoCbte INNER JOIN
                                                   caj_Caja ON caj_Caja.IdEmpresa = conci.IdEmpresa AND caj_Caja.IdCaja = conci.IdCaja
                          WHERE        conci.IdCtaCble = ct_det.IdCtaCble
                          GROUP BY conci.IdEmpresa, conci.IdConciliacion_Caja, conci.IdCaja, conci.Fecha_ini, conci.Fecha_fin, conci.IdEstadoCierre, ct_det.IdCtaCble, 
                                                   dbo.ct_plancta.pc_Cuenta, dbo.ct_plancta.pc_clave_corta, dbo.caj_Caja.ca_Descripcion) AS A