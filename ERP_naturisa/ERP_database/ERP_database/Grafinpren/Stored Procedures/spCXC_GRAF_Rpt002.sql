
--exec [Grafinpren].[spCXC_GRAF_Rpt002] 1,33,33,1,9999,'17/08/2016'

CREATE PROCEDURE [Grafinpren].[spCXC_GRAF_Rpt002]
(@IdEmpresa int, @IdClienteIni numeric, @IdClienteFin numeric, @IdVendedorIni numeric, @IdVendedorFin numeric, @FechaCorte datetime)
AS
BEGIN
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY A.IdEmpresa),0) as fila,* from(
SELECT        vwfa_factura_SubTotal_Iva_total.IdEmpresa, vwfa_factura_SubTotal_Iva_total.IdSucursal, vwfa_factura_SubTotal_Iva_total.IdBodega, 
                vwfa_factura_SubTotal_Iva_total.IdCbteVta, ROUND(vwfa_factura_SubTotal_Iva_total.vt_Subtotal, 2) AS vt_Subtotal, ROUND(vwfa_factura_SubTotal_Iva_total.vt_iva, 
                2) AS vt_iva, ROUND(vwfa_factura_SubTotal_Iva_total.vt_total, 2) AS vt_total, vwfa_factura_SubTotal_Iva_total.vt_por_iva, fa_factura.IdCliente, 
                tb_persona.IdPersona, tb_persona.pe_nombreCompleto, ROUND(SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2) AS dc_ValorPago, 
                ROUND(vwfa_factura_SubTotal_Iva_total.vt_total - SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2) AS Saldo, fa_factura.vt_fecha, fa_factura.vt_fech_venc, 
                fa_Vendedor.Ve_Vendedor, fa_Vendedor.IdVendedor, fa_factura.CodCbteVta, IIF(DATEDIFF(DAY,fa_factura.vt_fech_venc,@FechaCorte)<0,0,DATEDIFF(DAY,fa_factura.vt_fech_venc,@FechaCorte))AS Dias_vcdos,
				tb_persona.pe_telefonoOfic
FROM            fa_factura INNER JOIN
                vwfa_factura_SubTotal_Iva_total ON fa_factura.IdEmpresa = vwfa_factura_SubTotal_Iva_total.IdEmpresa AND 
                fa_factura.IdSucursal = vwfa_factura_SubTotal_Iva_total.IdSucursal AND fa_factura.IdBodega = vwfa_factura_SubTotal_Iva_total.IdBodega AND 
                fa_factura.IdCbteVta = vwfa_factura_SubTotal_Iva_total.IdCbteVta INNER JOIN
                fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona LEFT OUTER JOIN
                cxc_cobro_det ON fa_factura.IdEmpresa = cxc_cobro_det.IdEmpresa AND fa_factura.IdSucursal = cxc_cobro_det.IdSucursal AND 
                fa_factura.IdBodega = cxc_cobro_det.IdBodega_Cbte AND fa_factura.IdCbteVta = cxc_cobro_det.IdCbte_vta_nota AND 
                fa_factura.vt_tipoDoc = cxc_cobro_det.dc_TipoDocumento LEFT OUTER JOIN
                cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND 
                cxc_cobro_det.IdCobro = cxc_cobro.IdCobro right outer JOIN
                fa_Vendedor ON fa_factura.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_factura.IdVendedor = fa_Vendedor.IdVendedor
WHERE			(CAST(cxc_cobro.cr_fechaCobro AS DATE)<=@FechaCorte or cxc_cobro.cr_fecha is null) and fa_factura.IdCliente between @IdClienteIni and @IdClienteFin and fa_factura.IdVendedor between @IdVendedorIni
and @IdVendedorFin 
GROUP BY vwfa_factura_SubTotal_Iva_total.IdEmpresa, vwfa_factura_SubTotal_Iva_total.IdSucursal, vwfa_factura_SubTotal_Iva_total.IdBodega, 
                vwfa_factura_SubTotal_Iva_total.IdCbteVta, vwfa_factura_SubTotal_Iva_total.vt_Subtotal, vwfa_factura_SubTotal_Iva_total.vt_iva, 
                vwfa_factura_SubTotal_Iva_total.vt_total, vwfa_factura_SubTotal_Iva_total.vt_por_iva, fa_factura.IdCliente, tb_persona.IdPersona, tb_persona.pe_nombreCompleto, 
                fa_factura.vt_fecha, fa_factura.vt_fech_venc, fa_Vendedor.Ve_Vendedor, fa_Vendedor.IdVendedor, fa_factura.CodCbteVta,tb_persona.pe_telefonoOfic
HAVING ROUND(vwfa_factura_SubTotal_Iva_total.vt_total - SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2)>0
UNION
SELECT        vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa, vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal, vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega, 
                vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota, ROUND(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_subtotal, 2) AS vt_Subtotal, ROUND(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva, 
                2) AS vt_iva, ROUND(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, 2) AS vt_total, vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva, fa_notaCreDeb.IdCliente, 
                tb_persona.IdPersona, tb_persona.pe_nombreCompleto, ROUND(SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2) AS dc_ValorPago, 
                ROUND(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total - SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2) AS Saldo, fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc, 
                fa_Vendedor.Ve_Vendedor, fa_Vendedor.IdVendedor, fa_notaCreDeb.CodNota, IIF(DATEDIFF(DAY,fa_notaCreDeb.no_fecha_venc,@FechaCorte)<0,0,DATEDIFF(DAY,fa_notaCreDeb.no_fecha_venc,@FechaCorte))AS Dias_vcdos,
				tb_persona.pe_telefonoOfic
FROM            fa_Vendedor INNER JOIN
                         fa_notaCreDeb INNER JOIN
                         vwfa_notaCreDeb_det_Subtotal_Iva_total ON fa_notaCreDeb.IdEmpresa = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega AND 
                         fa_notaCreDeb.IdNota = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota INNER JOIN
                         fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON fa_Vendedor.IdEmpresa = fa_notaCreDeb.IdEmpresa AND 
                         fa_Vendedor.IdVendedor = fa_notaCreDeb.IdVendedor LEFT OUTER JOIN
                         cxc_cobro LEFT OUTER JOIN
                         cxc_cobro_det ON cxc_cobro.IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro.IdSucursal = cxc_cobro_det.IdSucursal AND 
                         cxc_cobro.IdCobro = cxc_cobro_det.IdCobro ON fa_notaCreDeb.IdEmpresa = cxc_cobro_det.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = cxc_cobro_det.IdSucursal AND fa_notaCreDeb.IdBodega = cxc_cobro_det.IdBodega_Cbte AND 
                         fa_notaCreDeb.IdNota = cxc_cobro_det.IdCbte_vta_nota AND fa_notaCreDeb.CodDocumentoTipo = cxc_cobro_det.dc_TipoDocumento
WHERE			(CAST(cxc_cobro.cr_fechaCobro AS DATE)<=@FechaCorte or cxc_cobro.cr_fecha is null) and fa_notaCreDeb.IdCliente between @IdClienteIni and @IdClienteFin and fa_notaCreDeb.IdVendedor between @IdVendedorIni  
and @IdVendedorFin AND fa_notaCreDeb.CreDeb = 'D'
										AND NOT EXISTS(
										SELECT        *
										FROM            fa_notaCreDeb_x_fa_factura_NotaDeb Cruce
										WHERE        Cruce.IdEmpresa_nt = fa_notaCreDeb.IdEmpresa AND Cruce.IdSucursal_nt = fa_notaCreDeb.IdSucursal AND Cruce.IdBodega_nt = fa_notaCreDeb.IdBodega AND Cruce.IdNota_nt = fa_notaCreDeb.IdNota
										)
GROUP BY vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa, vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal, vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega, 
                vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota, vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_subtotal, vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva, 
                vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva, fa_notaCreDeb.IdCliente, tb_persona.IdPersona, tb_persona.pe_nombreCompleto, 
                fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc, fa_Vendedor.Ve_Vendedor, fa_Vendedor.IdVendedor, fa_notaCreDeb.CodNota,tb_persona.pe_telefonoOfic
HAVING ROUND(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total - SUM(ISNULL(cxc_cobro_det.dc_ValorPago, 0)), 2)>0
) A
END