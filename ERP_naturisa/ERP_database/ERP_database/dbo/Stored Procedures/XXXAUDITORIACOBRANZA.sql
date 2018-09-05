
CREATE PROCEDURE [dbo].[XXXAUDITORIACOBRANZA]
(
@IdEmpresa int,
@FECHACORTE DATETIME
)
AS
SELECT * FROM(
SELECT c.IdEmpresa, vt_fecha FECHA, vt_serie1 ESTABLECIMIENTO, vt_serie2 PUNTOEMISION, vt_NumFactura NUMDOCUMENTO, cli.IdCliente CODCLIENTE, p.pe_nombreCompleto NOMCLIENTE, SUBTOTAL0, SUBTOTALIVA, VALORIVA, DESCUENTO, TOTAL, ISNULL(MONTORET,0)MONTORET, ISNULL(ABONO,0)ABONO,
ROUND( TOTAL - ISNULL(MONTORET,0) - ISNULL(ABONO,0),2) AS SALDO,
case when c.Estado = 'I' then  'INACTIVO' else  'ACTIVO' end AS ESTADO, 'FACTURA' AS TIPODOC, p.pe_cedulaRuc RUC, C.vt_plazo AS PLAZO,c.IdUsuario, c.Fecha_Transaccion, c.IdUsuarioUltModi, c.Fecha_UltMod, c.IdUsuarioUltAnu, c.Fecha_UltAnu
FROM     fa_factura AS c LEFT JOIN
                  fa_cliente AS cli ON c.IdEmpresa = cli.IdEmpresa AND c.IdCliente = cli.IdCliente INNER JOIN
                  tb_persona AS p ON p.IdPersona = cli.IdPersona LEFT JOIN
                      (SELECT grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdCbteVta, sum(grupo.SUBTOTAL0) SUBTOTAL0, sum(grupo.SUBTOTALIVA) SUBTOTALIVA, sum(grupo.VALORIVA) VALORIVA, sum(grupo.DESCUENTO) 
                                         DESCUENTO, sum(grupo.TOTAL) TOTAL
                       FROM      (SELECT d .IdEmpresa, d .IdSucursal, d .IdBodega, d .IdCbteVta, iif(d .vt_por_iva = 0, vt_Subtotal, 0) AS SUBTOTAL0, iif(d .vt_por_iva > 0, vt_Subtotal, 0) SUBTOTALIVA, D .vt_iva AS VALORIVA, 
                                                            (d .vt_cantidad * d .vt_DescUnitario) AS DESCUENTO, vt_total AS TOTAL
                                          FROM      fa_factura_det AS d) grupo
                       GROUP BY grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdCbteVta) AS det ON c.IdEmpresa = det.IdEmpresa AND c.IdSucursal = det.IdSucursal AND c.IdBodega = det.IdBodega AND c.IdCbteVta = det.IdCbteVta
LEFT OUTER JOIN(
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ABONO
FROM     cxc_cobro_det INNER JOIN
                  cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                  cxc_cobro_tipo ON cxc_cobro.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE  (cxc_cobro_tipo.IdMotivo_tipo_cobro <> 'RET') AND cxc_cobro.cr_fecha <= @FECHACORTE
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS cobros on c.IdEmpresa = cobros.IdEmpresa and c.IdSucursal = cobros.IdSucursal and c.IdBodega = cobros.IdBodega_Cbte and c.IdCbteVta = cobros.IdCbte_vta_nota and c.vt_tipoDoc = cobros.dc_TipoDocumento

LEFT OUTER JOIN(
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS MONTORET
FROM     cxc_cobro_det INNER JOIN
                  cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                  cxc_cobro_tipo ON cxc_cobro.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE  (cxc_cobro_tipo.IdMotivo_tipo_cobro = 'RET') AND cxc_cobro.cr_fecha <= @FECHACORTE
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS retenciones on c.IdEmpresa = retenciones.IdEmpresa and c.IdSucursal = retenciones.IdSucursal and c.IdBodega = retenciones.IdBodega_Cbte and c.IdCbteVta = retenciones.IdCbte_vta_nota and c.vt_tipoDoc = retenciones.dc_TipoDocumento

UNION ALL

SELECT c.IdEmpresa, no_fecha FECHA, Serie1 ESTABLECIMIENTO, Serie2 PUNTOEMISION, c.NumNota_Impresa NUMDOCUMENTO, cli.IdCliente CODCLIENTE, p.pe_nombreCompleto NOMCLIENTE, SUBTOTAL0, SUBTOTALIVA, VALORIVA, DESCUENTO, TOTAL, ISNULL(MONTORET,0)MONTORET, ISNULL(ABONO,0)ABONO,
ROUND( TOTAL - ISNULL(MONTORET,0) - ISNULL(ABONO,0),2) AS SALDO,
case when c.Estado = 'I' then  'INACTIVO' else  'ACTIVO' end AS ESTADO, 'NOTA DE DEBITO' AS TIPODOC, p.pe_cedulaRuc RUC, DATEDIFF(DAY,C.no_fecha,no_fecha_venc) as Plazo,c.IdUsuario, c.no_fecha, c.IdUsuarioUltMod, c.Fecha_UltMod, c.IdUsuarioUltAnu, c.Fecha_UltAnu
FROM     fa_notaCreDeb AS c LEFT JOIN
                  fa_cliente AS cli ON c.IdEmpresa = cli.IdEmpresa AND c.IdCliente = cli.IdCliente INNER JOIN
                  tb_persona AS p ON p.IdPersona = cli.IdPersona LEFT JOIN
                      (SELECT grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdNota, sum(grupo.SUBTOTAL0) SUBTOTAL0, sum(grupo.SUBTOTALIVA) SUBTOTALIVA, sum(grupo.VALORIVA) VALORIVA, sum(grupo.DESCUENTO) 
                                         DESCUENTO, sum(grupo.TOTAL) TOTAL
                       FROM      (SELECT d .IdEmpresa, d .IdSucursal, d .IdBodega, d .IdNota, iif(d .vt_por_iva = 0, sc_subtotal, 0) AS SUBTOTAL0, iif(d .vt_por_iva > 0, sc_subtotal, 0) SUBTOTALIVA, D .sc_iva AS VALORIVA, 
                                                            (d .sc_cantidad * d .sc_descUni) AS DESCUENTO, sc_total AS TOTAL
                                          FROM      fa_notaCreDeb_det AS d) grupo
                       GROUP BY grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdNota) AS det ON c.IdEmpresa = det.IdEmpresa AND c.IdSucursal = det.IdSucursal AND c.IdBodega = det.IdBodega AND c.IdNota = det.IdNota
LEFT OUTER JOIN(
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ABONO
FROM     cxc_cobro_det INNER JOIN
                  cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                  cxc_cobro_tipo ON cxc_cobro.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE  (cxc_cobro_tipo.IdMotivo_tipo_cobro <> 'RET') AND cxc_cobro.cr_fecha <= @FECHACORTE
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS cobros on c.IdEmpresa = cobros.IdEmpresa and c.IdSucursal = cobros.IdSucursal and c.IdBodega = cobros.IdBodega_Cbte and c.IdNota = cobros.IdCbte_vta_nota and c.CodDocumentoTipo = cobros.dc_TipoDocumento

LEFT OUTER JOIN(
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS MONTORET
FROM     cxc_cobro_det INNER JOIN
                  cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                  cxc_cobro_tipo ON cxc_cobro.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE  (cxc_cobro_tipo.IdMotivo_tipo_cobro = 'RET') AND cxc_cobro.cr_fecha <= @FECHACORTE
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS retenciones on c.IdEmpresa = retenciones.IdEmpresa and c.IdSucursal = retenciones.IdSucursal and c.IdBodega = retenciones.IdBodega_Cbte and c.IdNota = retenciones.IdCbte_vta_nota and c.CodDocumentoTipo = retenciones.dc_TipoDocumento
where c.CreDeb = 'D'

) A
WHERE A.IdEmpresa <= @IdEmpresa AND A.FECHA <= @FECHACORTE
order by a.FECHA