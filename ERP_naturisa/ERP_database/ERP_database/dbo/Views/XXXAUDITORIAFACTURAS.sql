
CREATE VIEW [dbo].[XXXAUDITORIAFACTURAS]
AS
SELECT c.IdEmpresa, vt_fecha FECHA, vt_serie1 ESTABLECIMIENTO, vt_serie2 PUNTOEMISION, vt_NumFactura NUMDOCUMENTO, cli.IdCliente CODCLIENTE, p.pe_nombreCompleto NOMCLIENTE, REPLACE(REPLACE(c.vt_Observacion, CHAR(10), ''), CHAR(13), '')  DETALLE, SUBTOTAL0, 
                  SUBTOTALIVA, VALORIVA, DESCUENTO, TOTAL, iif(c.Estado = 'I', 'INACTIVO', 'ACTIVO') AS ESTADO, 'FACTURA' AS TIPODOC, p.pe_cedulaRuc
FROM     fa_factura AS c LEFT JOIN
                  fa_cliente AS cli ON c.IdEmpresa = cli.IdEmpresa AND c.IdCliente = cli.IdCliente INNER JOIN
                  tb_persona AS p ON p.IdPersona = cli.IdPersona LEFT JOIN
                      (SELECT grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdCbteVta, sum(grupo.SUBTOTAL0) SUBTOTAL0, sum(grupo.SUBTOTALIVA) SUBTOTALIVA, sum(grupo.VALORIVA) VALORIVA, sum(grupo.DESCUENTO) 
                                         DESCUENTO, sum(grupo.TOTAL) TOTAL
                       FROM      (SELECT d .IdEmpresa, d .IdSucursal, d .IdBodega, d .IdCbteVta, iif(d .vt_por_iva = 0, vt_Subtotal, 0) AS SUBTOTAL0, iif(d .vt_por_iva > 0, vt_Subtotal, 0) SUBTOTALIVA, D .vt_iva AS VALORIVA, 
                                                            (d .vt_cantidad * d .vt_DescUnitario) AS DESCUENTO, vt_total AS TOTAL
                                          FROM      fa_factura_det AS d) grupo
                       GROUP BY grupo.IdEmpresa, grupo.IdSucursal, grupo.IdBodega, grupo.IdCbteVta) AS det ON c.IdEmpresa = det.IdEmpresa AND c.IdSucursal = det.IdSucursal AND c.IdBodega = det.IdBodega AND c.IdCbteVta = det.IdCbteVta