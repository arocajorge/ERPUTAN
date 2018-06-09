CREATE VIEW [dbo].[vwFAC_Rpt002]
AS
SELECT        cabfac.IdEmpresa, cabfac.IdSucursal, cabfac.IdBodega, cabfac.vt_tipoDoc, SUBSTRING(cabfac.vt_tipoDoc, 1, 2) 
                         + '-' + cabfac.vt_serie1 + '-' + cabfac.vt_serie2 + '-' + cabfac.vt_NumFactura + '/' + CAST(cabfac.IdCbteVta AS varchar(100)) AS vt_NunDocumento, 
                         cabfac.vt_Observacion AS Referencia, cabfac.IdCbteVta AS IdComprobante, cabfac.CodCbteVta AS CodComprobante, Sucu.Su_Descripcion, cabfac.IdCliente, 
                         dbo.tb_persona.pe_nombreCompleto AS nombreCliente, dbo.tb_persona.pe_cedulaRuc, cabfac.vt_fecha, ROUND(SUM(detfac.vt_total) + AVG(cabfac.vt_flete) 
                         + AVG(cabfac.vt_interes) + AVG(cabfac.vt_OtroValor1) + AVG(cabfac.vt_OtroValor2), 2) AS vt_total, ROUND(SUM(detfac.vt_total) + AVG(cabfac.vt_flete) 
                         + AVG(cabfac.vt_interes) + AVG(cabfac.vt_OtroValor1) + AVG(cabfac.vt_OtroValor2), 2) - ROUND(ISNULL(AVG(dbo.vwcxc_total_cobros_x_Docu.dc_ValorPago), 0), 2) 
                         AS Saldo, ISNULL(AVG(dbo.vwcxc_total_cobros_x_Docu.dc_ValorPago), 0) AS TotalCobrado, ROUND(SUM(detfac.vt_Subtotal), 2) AS vt_Subtotal, 
                         ROUND(SUM(detfac.vt_iva), 2) AS vt_iva, cabfac.vt_fech_venc, ROUND(ISNULL(AVG(Cob_RtFu.dc_ValorPago), 0), 2) AS dc_ValorRetFu, 
                         ROUND(ISNULL(AVG(Cob_RtIVA.dc_ValorPago), 0), 2) AS dc_ValorRetIva, cabfac.vt_plazo, cabfac.IdUsuario, 
                         ISNULL(AVG(dbo.vwfa_factura_subtotal_iva_0_totales.SubTotal_0), 0) AS SubTotal_0, ISNULL(AVG(dbo.vwfa_factura_subtotal_iva_0_totales.SubTotal_Iva), 0) 
                         AS SubTotal_Iva, dbo.fa_factura_x_formaPago.IdFormaPago, dbo.fa_formaPago.nom_FormaPago
FROM            dbo.fa_formaPago INNER JOIN
                         dbo.fa_factura_x_formaPago ON dbo.fa_formaPago.IdFormaPago = dbo.fa_factura_x_formaPago.IdFormaPago RIGHT OUTER JOIN
                         dbo.fa_factura_det AS detfac INNER JOIN
                         dbo.fa_factura AS cabfac ON detfac.IdBodega = cabfac.IdBodega AND detfac.IdSucursal = cabfac.IdSucursal AND detfac.IdEmpresa = cabfac.IdEmpresa AND 
                         detfac.IdCbteVta = cabfac.IdCbteVta INNER JOIN
                         dbo.tb_sucursal AS Sucu ON cabfac.IdEmpresa = Sucu.IdEmpresa AND cabfac.IdSucursal = Sucu.IdSucursal INNER JOIN
                         dbo.tb_bodega AS Bod ON cabfac.IdEmpresa = Bod.IdEmpresa AND cabfac.IdSucursal = Bod.IdSucursal AND cabfac.IdBodega = Bod.IdBodega AND 
                         Sucu.IdEmpresa = Bod.IdEmpresa AND Sucu.IdSucursal = Bod.IdSucursal INNER JOIN
                         dbo.fa_cliente AS Cli ON cabfac.IdEmpresa = Cli.IdEmpresa AND cabfac.IdCliente = Cli.IdCliente INNER JOIN
                         dbo.tb_persona ON Cli.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.tb_empresa ON cabfac.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.vwfa_factura_subtotal_iva_0_totales ON cabfac.IdEmpresa = dbo.vwfa_factura_subtotal_iva_0_totales.IdEmpresa AND 
                         cabfac.IdSucursal = dbo.vwfa_factura_subtotal_iva_0_totales.IdSucursal AND cabfac.IdBodega = dbo.vwfa_factura_subtotal_iva_0_totales.IdBodega AND 
                         cabfac.IdCbteVta = dbo.vwfa_factura_subtotal_iva_0_totales.IdCbteVta ON dbo.fa_factura_x_formaPago.IdEmpresa = cabfac.IdEmpresa AND 
                         dbo.fa_factura_x_formaPago.IdSucursal = cabfac.IdSucursal AND dbo.fa_factura_x_formaPago.IdBodega = cabfac.IdBodega AND 
                         dbo.fa_factura_x_formaPago.IdCbteVta = cabfac.IdCbteVta LEFT OUTER JOIN
                         dbo.vwcxc_cobros_x_vta_nota_x_RetFuente_Sumatoria AS Cob_RtFu ON cabfac.vt_tipoDoc = Cob_RtFu.dc_TipoDocumento AND 
                         cabfac.IdEmpresa = Cob_RtFu.IdEmpresa AND cabfac.IdSucursal = Cob_RtFu.IdSucursal AND cabfac.IdBodega = Cob_RtFu.IdBodega_Cbte AND 
                         cabfac.IdCbteVta = Cob_RtFu.IdCbte_vta_nota LEFT OUTER JOIN
                         dbo.vwcxc_cobros_x_vta_nota_x_RetIVA_Sumatoria AS Cob_RtIVA ON cabfac.vt_tipoDoc = Cob_RtIVA.dc_TipoDocumento AND 
                         cabfac.IdEmpresa = Cob_RtIVA.IdEmpresa AND cabfac.IdSucursal = Cob_RtIVA.IdSucursal AND cabfac.IdBodega = Cob_RtIVA.IdBodega_Cbte AND 
                         cabfac.IdCbteVta = Cob_RtIVA.IdCbte_vta_nota LEFT OUTER JOIN
                         dbo.vwcxc_total_cobros_x_Docu ON cabfac.IdEmpresa = dbo.vwcxc_total_cobros_x_Docu.IdEmpresa AND 
                         cabfac.IdSucursal = dbo.vwcxc_total_cobros_x_Docu.IdSucursal AND cabfac.IdBodega = dbo.vwcxc_total_cobros_x_Docu.IdBodega_Cbte AND 
                         cabfac.vt_tipoDoc = dbo.vwcxc_total_cobros_x_Docu.dc_TipoDocumento AND cabfac.IdCbteVta = dbo.vwcxc_total_cobros_x_Docu.IdCbte_vta_nota
where cabfac.Estado = 'A'
GROUP BY SUBSTRING(cabfac.vt_tipoDoc, 1, 2) + '-' + cabfac.vt_serie1 + '-' + cabfac.vt_serie2 + '-' + cabfac.vt_NumFactura + '/' + CAST(cabfac.IdCbteVta AS varchar(100)), 
                         cabfac.IdEmpresa, cabfac.IdSucursal, cabfac.IdBodega, cabfac.IdCbteVta, cabfac.CodCbteVta, Sucu.Su_Descripcion, cabfac.vt_tipoDoc, cabfac.IdCliente, 
                         cabfac.vt_fecha, cabfac.vt_Observacion, Bod.bo_Descripcion, cabfac.vt_fech_venc, Cli.Codigo, dbo.tb_persona.pe_nombreCompleto, dbo.tb_empresa.em_nombre, 
                         cabfac.vt_plazo, cabfac.IdUsuario, dbo.tb_persona.pe_cedulaRuc, dbo.fa_factura_x_formaPago.IdFormaPago, dbo.fa_formaPago.nom_FormaPago