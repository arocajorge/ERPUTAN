CREATE VIEW XXXAUDITORIANCNDFAC
AS
SELECT fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.no_fecha, fa_notaCreDeb.Serie1 ESTABLECIMIENTO, fa_notaCreDeb.Serie2 PUNTOEMISION, fa_notaCreDeb.NumNota_Impresa NUMERODOCUMENTO,
 fa_notaCreDeb.IdCliente, 
                  tb_persona.pe_nombreCompleto, fa_notaCreDeb.sc_observacion, d.SUBTOTALIVA, d.SUBTOTAL0, d.DESCUENTO, d.VALORIVA, d.TOTAL, 
				  CASE WHEN fa_notaCreDeb.Estado = 'A' THEN 'ACTIVO' ELSE 'INACTIVO' END AS ESTADO,
				  CASE WHEN fa_notaCreDeb.CodDocumentoTipo = 'NTDB' THEN 'NOTA DE DEBITO' ELSE 'NOTA DE CREDITO' END AS TIPODOCUMENTO,
				   tb_persona.pe_cedulaRuc RUC
FROM     fa_notaCreDeb INNER JOIN
                  fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente INNER JOIN
                  tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona LEFT OUTER JOIN
                      (SELECT IdEmpresa, IdSucursal, IdBodega, IdNota, SUM(SUBTOTAL0) AS SUBTOTAL0, SUM(SUBTOTALIVA) AS SUBTOTALIVA, SUM(DESCUENTO) AS DESCUENTO, SUM(VALORIVA) AS VALORIVA, SUM(TOTAL) AS TOTAL
                       FROM      (SELECT IdEmpresa, IdSucursal, IdBodega, IdNota, CASE WHEN det.vt_por_iva = 0 THEN det.sc_subtotal ELSE 0 END AS SUBTOTAL0, CASE WHEN det.vt_por_iva > 0 THEN det.sc_subtotal ELSE 0 END AS SUBTOTALIVA, 
                                                            sc_cantidad * sc_descUni AS DESCUENTO, sc_iva AS VALORIVA, sc_total AS TOTAL
                                          FROM      fa_notaCreDeb_det AS det) AS GRUPO
                       GROUP BY IdEmpresa, IdSucursal, IdBodega, IdNota) AS d ON fa_notaCreDeb.IdEmpresa = d.IdEmpresa AND fa_notaCreDeb.IdSucursal = d.IdSucursal AND fa_notaCreDeb.IdBodega = d.IdBodega AND 
                  fa_notaCreDeb.IdNota = d.IdNota
WHERE  (fa_notaCreDeb.NaturalezaNota = 'SRI')