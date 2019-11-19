CREATE VIEW [dbo].[vwfa_ContabilizacionFactura_x_Subcentro]
AS
SELECT ISNULL(ROW_NUMBER() OVER (ORDER BY fac.IdEmpresa), 0) AS IdFila, fac.IdEmpresa, fac.IdSucursal, fac.IdBodega, fac.IdCbteVta, SUM(fac.vt_Subtotal) AS Subtotal, SUM(fac.vt_DescUnitario) AS Descuento, SUM(fac.vt_iva) AS iva, SUM(fac.vt_total) AS Total, ct_centro_costo_sub_centro_costo.IdCtaCble AS IdCtaCble_Ven0, ct_centro_costo_sub_centro_costo.IdCtaCble
                  AS IdCtaCble_VenIva, fa_factura.vt_tipo_venta, fa_factura.vt_plazo, NULL AS IdCtaCble_DesIva, NULL AS IdCtaCble_Des0, fac.Secuencia, fac.IdCod_Impuesto_Iva, fac.IdCentroCosto, fac.IdCentroCosto_sub_centro_costo, 
                  tb_sis_Impuesto_x_ctacble.IdCtaCble AS IdCtaCble_Imp_Iva
FROM     fa_factura_det_subcentro AS fac INNER JOIN
                  fa_factura ON fa_factura.IdEmpresa = fac.IdEmpresa AND fa_factura.IdSucursal = fac.IdSucursal AND fa_factura.IdBodega = fac.IdBodega AND fa_factura.IdCbteVta = fac.IdCbteVta LEFT OUTER JOIN
                  ct_centro_costo_sub_centro_costo ON fac.IdEmpresa = ct_centro_costo_sub_centro_costo.IdEmpresa AND fac.IdCentroCosto = ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                  fac.IdCentroCosto_sub_centro_costo = ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo LEFT OUTER JOIN
                  tb_sis_Impuesto_x_ctacble ON fac.IdEmpresa = tb_sis_Impuesto_x_ctacble.IdEmpresa_cta AND fac.IdCod_Impuesto_Iva = tb_sis_Impuesto_x_ctacble.IdCod_Impuesto
GROUP BY fac.IdEmpresa, fac.IdSucursal, fac.IdBodega, fac.IdCbteVta, fa_factura.vt_tipo_venta, fa_factura.vt_plazo, fac.Secuencia, fac.IdCod_Impuesto_Iva, fac.IdCentroCosto, fac.IdCentroCosto_sub_centro_costo, 
                  tb_sis_Impuesto_x_ctacble.IdCtaCble, ct_centro_costo_sub_centro_costo.IdCtaCble