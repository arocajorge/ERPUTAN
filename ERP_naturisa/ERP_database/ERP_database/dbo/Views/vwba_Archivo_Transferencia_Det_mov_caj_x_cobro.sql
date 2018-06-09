CREATE view [dbo].[vwba_Archivo_Transferencia_Det_mov_caj_x_cobro]
as
SELECT        isnull(ROW_NUMBER() OVER (ORDER BY ba_Archivo_Transferencia_Det.IdEmpresa), 0) AS IdRow, ba_Archivo_Transferencia_Det.IdEmpresa, 
ba_Archivo_Transferencia_Det.IdArchivo, ba_Archivo_Transferencia_Det.Secuencia, cxc_cobro_x_caj_Caja_Movimiento.mcj_IdEmpresa, 
cxc_cobro_x_caj_Caja_Movimiento.mcj_IdTipocbte, cxc_cobro_x_caj_Caja_Movimiento.mcj_IdCbteCble, ct_cbtecble_det.secuencia AS mcj_secuencia, 
cxc_cobro_x_caj_Caja_Movimiento.cbr_IdEmpresa, cxc_cobro_x_caj_Caja_Movimiento.cbr_IdSucursal, cxc_cobro_x_caj_Caja_Movimiento.cbr_IdCobro, 
ct_cbtecble_det.IdCtaCble, ct_cbtecble_det.dc_Valor, isnull(CASE WHEN caj.IdCaja IS NULL THEN cast(0 AS bit) ELSE cast(1 AS bit) END, cast(0 AS bit)) Es_CtaCble_caja, 
isnull(ba_Archivo_Transferencia_Det.Contabilizado, 0) Contabilizado
FROM            ba_Archivo_Transferencia_Det INNER JOIN
                         Aca_Pre_Facturacion_det ON ba_Archivo_Transferencia_Det.IdInstitucion_col = Aca_Pre_Facturacion_det.IdInstitucion AND 
                         ba_Archivo_Transferencia_Det.IdPreFacturacion_col = Aca_Pre_Facturacion_det.IdPreFacturacion AND 
                         ba_Archivo_Transferencia_Det.Secuencia_Proce_col = Aca_Pre_Facturacion_det.Secuencia_Proce AND 
                         ba_Archivo_Transferencia_Det.secuencia_col = Aca_Pre_Facturacion_det.secuencia INNER JOIN
                         cxc_cobro_det ON Aca_Pre_Facturacion_det.IdEmpresa_fac = cxc_cobro_det.IdEmpresa AND 
                         Aca_Pre_Facturacion_det.IdSucursal_fac = cxc_cobro_det.IdSucursal AND Aca_Pre_Facturacion_det.IdBodega_fac = cxc_cobro_det.IdBodega_Cbte AND 
                         Aca_Pre_Facturacion_det.IdCbteVta_fac = cxc_cobro_det.IdCbte_vta_nota INNER JOIN
                         cxc_cobro_x_caj_Caja_Movimiento ON cxc_cobro_det.IdEmpresa = cxc_cobro_x_caj_Caja_Movimiento.cbr_IdEmpresa AND 
                         cxc_cobro_det.IdSucursal = cxc_cobro_x_caj_Caja_Movimiento.cbr_IdSucursal AND 
                         cxc_cobro_det.IdCobro = cxc_cobro_x_caj_Caja_Movimiento.cbr_IdCobro INNER JOIN
                         ct_cbtecble_det ON cxc_cobro_x_caj_Caja_Movimiento.mcj_IdEmpresa = ct_cbtecble_det.IdEmpresa AND 
                         cxc_cobro_x_caj_Caja_Movimiento.mcj_IdCbteCble = ct_cbtecble_det.IdCbteCble AND 
                         cxc_cobro_x_caj_Caja_Movimiento.mcj_IdTipocbte = ct_cbtecble_det.IdTipoCbte LEFT JOIN
                             (SELECT        IdEmpresa, IdCaja, IdCtaCble
                               FROM            caj_Caja) caj ON ct_cbtecble_det.IdEmpresa = caj.IdEmpresa AND ct_cbtecble_det.IdCtaCble = caj.IdCtaCble
WHERE        (cxc_cobro_det.dc_TipoDocumento = 'FACT')