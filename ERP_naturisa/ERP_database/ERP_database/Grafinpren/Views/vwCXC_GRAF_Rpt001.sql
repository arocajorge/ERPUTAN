CREATE view [Grafinpren].[vwCXC_GRAF_Rpt001]
as
SELECT        com.IdEmpresa AS IdEmpresa_cbr, com.IdSucursal AS IdSucursal_cbr, com.IdCobro AS IdCobro_cbr, com.Secuencia AS Secuencial_cbr, cxc_cobro.IdCobro_tipo, 
                         cxc_cobro.cr_fechaCobro, ISNULL(SUM(cxc_cobro_det.dc_ValorPago), 0) AS Pago, fa_factura.IdEmpresa AS IdEmpresa_fact, fa_factura.IdSucursal AS IdSucursal_fact,
                          fa_factura.IdBodega AS IdBodega_fact, fa_factura.IdCbteVta AS IdCbteVta_fact, fa_factura.IdVendedor, fa_Vendedor.Ve_Vendedor, 
                         ISNULL(Grafinpren.fa_factura_graf.porc_comision, 0) AS porc_comision, fa_factura.vt_fecha AS fecha_fact, fa_factura.vt_fech_venc AS fecha_vcto_fact, 
                         tb_persona.pe_nombreCompleto AS nom_Cliente, isnull(vwfa_factura_SubTotal_Iva_total.vt_total, 0) AS Fa_total, CASE WHEN ISNULL(DATEDIFF(day, 
                         dbo.fa_factura.vt_fech_venc, dbo.cxc_cobro.cr_fechaCobro), 0) < 0 THEN 0 ELSE ISNULL(DATEDIFF(day, dbo.fa_factura.vt_fech_venc, dbo.cxc_cobro.cr_fechaCobro), 
                         0) END AS Dias_atraso, com.Porc_pagado, com.Valor_pagado, fa_cliente.IdCliente, CASE WHEN AVG(vwfa_factura_SubTotal_Iva_total.vt_iva) 
                         > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) / ((AVG(vwfa_factura_SubTotal_Iva_total.vt_por_iva) / 100) + 1)) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) 
                         END AS Base_com, CAST(1 AS bit) AS Esta_en_base, dbo.fa_factura.CodCbteVta as vt_NumFactura, fa_TerminoPago.Dias_Vct, CASE WHEN AVG(vwfa_factura_SubTotal_Iva_total.vt_iva)
                          > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) / ((AVG(vwfa_factura_SubTotal_Iva_total.vt_por_iva) / 100) + 1)) * (Grafinpren.fa_factura_graf.porc_comision / 100) 
                         ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) * (Grafinpren.fa_factura_graf.porc_comision / 100) END AS com_negociada, Grafinpren.fa_factura_graf.num_op, 
                         Grafinpren.fa_factura_graf.num_cotizacion, fa_factura.vt_tipoDoc
FROM            Grafinpren.fa_factura_graf INNER JOIN
                         fa_factura INNER JOIN
                         fa_Vendedor ON fa_factura.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_factura.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON Grafinpren.fa_factura_graf.IdEmpresa = fa_factura.IdEmpresa AND 
                         Grafinpren.fa_factura_graf.IdSucursal = fa_factura.IdSucursal AND Grafinpren.fa_factura_graf.IdBodega = fa_factura.IdBodega AND 
                         Grafinpren.fa_factura_graf.IdCbteVta = fa_factura.IdCbteVta AND Grafinpren.fa_factura_graf.IdEmpresa = fa_factura.IdEmpresa AND 
                         Grafinpren.fa_factura_graf.IdSucursal = fa_factura.IdSucursal AND Grafinpren.fa_factura_graf.IdBodega = fa_factura.IdBodega AND 
                         Grafinpren.fa_factura_graf.IdCbteVta = fa_factura.IdCbteVta INNER JOIN
                         fa_TerminoPago ON fa_factura.vt_tipo_venta = fa_TerminoPago.IdTerminoPago INNER JOIN
                         cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND 
                         cxc_cobro_det.IdCobro = cxc_cobro.IdCobro ON fa_factura.IdEmpresa = cxc_cobro_det.IdEmpresa AND fa_factura.IdSucursal = cxc_cobro_det.IdSucursal AND 
                         fa_factura.IdBodega = cxc_cobro_det.IdBodega_Cbte AND fa_factura.IdCbteVta = cxc_cobro_det.IdCbte_vta_nota AND 
                         fa_factura.vt_tipoDoc = cxc_cobro_det.dc_TipoDocumento INNER JOIN
                         Grafinpren.cxc_Comisiones_x_vendedor AS com ON cxc_cobro_det.IdEmpresa = com.IdEmpresa AND cxc_cobro_det.IdSucursal = com.IdSucursal AND 
                         cxc_cobro_det.IdCobro = com.IdCobro AND cxc_cobro_det.secuencial = com.Secuencia INNER JOIN
                         vwfa_factura_SubTotal_Iva_total ON fa_factura.IdEmpresa = vwfa_factura_SubTotal_Iva_total.IdEmpresa AND 
                         fa_factura.IdSucursal = vwfa_factura_SubTotal_Iva_total.IdSucursal AND fa_factura.IdBodega = vwfa_factura_SubTotal_Iva_total.IdBodega AND 
                         fa_factura.IdCbteVta = vwfa_factura_SubTotal_Iva_total.IdCbteVta
GROUP BY com.IdEmpresa, com.IdSucursal, com.IdCobro, com.Secuencia, cxc_cobro.IdCobro_tipo, cxc_cobro.cr_fechaCobro, cxc_cobro_det.dc_ValorPago, 
                         fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.IdVendedor, fa_Vendedor.Ve_Vendedor, fa_factura.vt_fecha, 
                         fa_factura.vt_fech_venc, tb_persona.pe_nombreCompleto, fa_factura.vt_fech_venc, cxc_cobro.cr_fechaCobro, com.Porc_pagado, 
                         Grafinpren.fa_factura_graf.porc_comision, fa_cliente.IdCliente, cxc_cobro_det.dc_ValorPago, dbo.fa_factura.CodCbteVta, fa_TerminoPago.Dias_Vct, 
                         com.Valor_pagado, Grafinpren.fa_factura_graf.num_op, Grafinpren.fa_factura_graf.num_cotizacion, fa_factura.vt_tipoDoc, 
                         vwfa_factura_SubTotal_Iva_total.vt_total
UNION
SELECT        cxc_cobro_det.IdEmpresa AS IdEmpresa_cbr, cxc_cobro_det.IdSucursal AS IdSucursal_cbr, cxc_cobro_det.IdCobro AS IdCobro_cbr, 
                         cxc_cobro_det.secuencial AS Secuencial_cbr, dbo.cxc_cobro.IdCobro_tipo, dbo.cxc_cobro.cr_fechaCobro, ISNULL(SUM(dbo.cxc_cobro_det.dc_ValorPago), 0) 
                         AS Pago, dbo.fa_factura.IdEmpresa AS IdEmpresa_fact, dbo.fa_factura.IdSucursal AS IdSucursal_fact, dbo.fa_factura.IdBodega AS IdBodega_fact, 
                         dbo.fa_factura.IdCbteVta AS IdCbteVta_fact, dbo.fa_factura.IdVendedor, dbo.fa_Vendedor.Ve_Vendedor, ISNULL(Grafinpren.fa_factura_graf.porc_comision, 0) 
                         AS porc_comision, dbo.fa_factura.vt_fecha AS fecha_fact, dbo.fa_factura.vt_fech_venc AS fecha_vcto_fact, dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, 
                         ISNULL(dbo.vwfa_factura_SubTotal_Iva_total.vt_total, 0) AS Expr2, CASE WHEN ISNULL(DATEDIFF(day, dbo.fa_factura.vt_fech_venc, dbo.cxc_cobro.cr_fechaCobro), 
                         0) < 0 THEN 0 ELSE ISNULL(DATEDIFF(day, dbo.fa_factura.vt_fech_venc, dbo.cxc_cobro.cr_fechaCobro), 0) END AS Dias_atraso, 
                         CASE WHEN (fa_factura.vt_fech_venc > cxc_cobro.cr_fechaCobro) THEN Grafinpren.fa_factura_graf.porc_comision WHEN (CEILING(datediff(DAY, 
                         fa_factura.vt_fech_venc, dateadd(day, - 1, cxc_cobro.cr_fechaCobro)) / fa_TerminoPago.Dias_Vct) > Grafinpren.fa_factura_graf.porc_comision) 
                         THEN 0 WHEN (CEILING(datediff(DAY, fa_factura.vt_fech_venc, cxc_cobro.cr_fechaCobro) / fa_TerminoPago.Dias_Vct) > 1) 
                         THEN Grafinpren.fa_factura_graf.porc_comision - (CEILING(datediff(DAY, fa_factura.vt_fech_venc, dateadd(day, - 1, cxc_cobro.cr_fechaCobro)) 
                         / fa_TerminoPago.Dias_Vct) - 1) ELSE Grafinpren.fa_factura_graf.porc_comision END AS Porc_pagado, cxc_cobro_det.dc_ValorPago, dbo.fa_cliente.IdCliente, 
                         CASE WHEN AVG(vwfa_factura_SubTotal_Iva_total.vt_iva) > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) / ((AVG(vwfa_factura_SubTotal_Iva_total.vt_por_iva) 
                         / 100) + 1)) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) END AS Base_com, CAST(1 AS bit) AS Esta_en_base, dbo.fa_factura.CodCbteVta as vt_NumFactura, 
                         dbo.fa_TerminoPago.Dias_Vct, CASE WHEN AVG(vwfa_factura_SubTotal_Iva_total.vt_iva) > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) 
                         / ((AVG(vwfa_factura_SubTotal_Iva_total.vt_por_iva) / 100) + 1)) * (Grafinpren.fa_factura_graf.porc_comision / 100) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) 
                         * (Grafinpren.fa_factura_graf.porc_comision / 100) END AS Expr1, Grafinpren.fa_factura_graf.num_op, Grafinpren.fa_factura_graf.num_cotizacion, 
                         dbo.fa_factura.vt_tipoDoc
FROM            Grafinpren.fa_factura_graf INNER JOIN
                         dbo.fa_factura INNER JOIN
                         dbo.fa_Vendedor ON dbo.fa_factura.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_factura.IdVendedor = dbo.fa_Vendedor.IdVendedor INNER JOIN
                         dbo.fa_cliente ON dbo.fa_factura.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_factura.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona ON Grafinpren.fa_factura_graf.IdEmpresa = dbo.fa_factura.IdEmpresa AND 
                         Grafinpren.fa_factura_graf.IdSucursal = dbo.fa_factura.IdSucursal AND Grafinpren.fa_factura_graf.IdBodega = dbo.fa_factura.IdBodega AND 
                         Grafinpren.fa_factura_graf.IdCbteVta = dbo.fa_factura.IdCbteVta AND Grafinpren.fa_factura_graf.IdEmpresa = dbo.fa_factura.IdEmpresa AND 
                         Grafinpren.fa_factura_graf.IdSucursal = dbo.fa_factura.IdSucursal AND Grafinpren.fa_factura_graf.IdBodega = dbo.fa_factura.IdBodega AND 
                         Grafinpren.fa_factura_graf.IdCbteVta = dbo.fa_factura.IdCbteVta INNER JOIN
                         dbo.fa_TerminoPago ON dbo.fa_factura.vt_tipo_venta = dbo.fa_TerminoPago.IdTerminoPago INNER JOIN
                         dbo.cxc_cobro_det INNER JOIN
                         dbo.cxc_cobro ON dbo.cxc_cobro_det.IdEmpresa = dbo.cxc_cobro.IdEmpresa AND dbo.cxc_cobro_det.IdSucursal = dbo.cxc_cobro.IdSucursal AND 
                         dbo.cxc_cobro_det.IdCobro = dbo.cxc_cobro.IdCobro ON dbo.fa_factura.IdEmpresa = dbo.cxc_cobro_det.IdEmpresa AND 
                         dbo.fa_factura.IdSucursal = dbo.cxc_cobro_det.IdSucursal AND dbo.fa_factura.IdBodega = dbo.cxc_cobro_det.IdBodega_Cbte AND 
                         dbo.fa_factura.IdCbteVta = dbo.cxc_cobro_det.IdCbte_vta_nota AND dbo.fa_factura.vt_tipoDoc = dbo.cxc_cobro_det.dc_TipoDocumento INNER JOIN
                         dbo.vwfa_factura_SubTotal_Iva_total ON dbo.fa_factura.IdEmpresa = dbo.vwfa_factura_SubTotal_Iva_total.IdEmpresa AND 
                         dbo.fa_factura.IdSucursal = dbo.vwfa_factura_SubTotal_Iva_total.IdSucursal AND dbo.fa_factura.IdBodega = dbo.vwfa_factura_SubTotal_Iva_total.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = dbo.vwfa_factura_SubTotal_Iva_total.IdCbteVta
WHERE        (NOT EXISTS
                             (SELECT        cxc_cobro_det.IdEmpresa
                               FROM            cxc_cobro_det AS D INNER JOIN
                                                         Grafinpren.cxc_Comisiones_x_vendedor AS COM ON D .IdEmpresa = COM.IdEmpresa AND D .IdSucursal = COM.IdSucursal AND 
                                                         D .IdCobro = COM.IdCobro AND D .secuencial = COM.Secuencia AND COM.IdEmpresa = cxc_cobro_det.IdEmpresa AND 
                                                         COM.IdSucursal = cxc_cobro_det.IdSucursal AND COM.IdCobro = cxc_cobro_det.IdCobro AND COM.Secuencia = cxc_cobro_det.secuencial))
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro.IdCobro_tipo, cxc_cobro.cr_fechaCobro, cxc_cobro_det.secuencial, 
                         fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.IdVendedor, fa_Vendedor.Ve_Vendedor, 
                         Grafinpren.fa_factura_graf.porc_comision, fa_factura.vt_fecha, fa_factura.vt_fech_venc, tb_persona.pe_nombreCompleto, vwfa_factura_SubTotal_Iva_total.vt_total, 
                         fa_Vendedor.IdVendedor, fa_cliente.IdCliente, cxc_cobro_det.dc_ValorPago, fa_factura.CodCbteVta, Grafinpren.fa_factura_graf.num_op, 
                         Grafinpren.fa_factura_graf.num_cotizacion, fa_factura.vt_tipoDoc, fa_TerminoPago.Dias_Vct, dbo.fa_factura.CodCbteVta 
UNION
SELECT        cxc_cobro_det.IdEmpresa AS IdEmpresa_cbr, cxc_cobro_det.IdSucursal AS IdSucursal_cbr, cxc_cobro_det.IdCobro AS IdCobro_cbr, 
                         cxc_cobro_det.secuencial AS Secuencial_cbr, cxc_cobro.IdCobro_tipo, cxc_cobro.cr_fechaCobro, ISNULL(SUM(cxc_cobro_det.dc_ValorPago), 0) AS Pago, 
                         fa_notaCreDeb.IdEmpresa AS IdEmpresa_fact, fa_notaCreDeb.IdSucursal AS IdSucursal_fact, fa_notaCreDeb.IdBodega AS IdBodega_fact, 
                         fa_notaCreDeb.IdNota AS IdCbteVta_fact, fa_notaCreDeb.IdVendedor, fa_Vendedor.Ve_Vendedor, ISNULL(Grafinpren.fa_notaCreDeb_graf.porc_comision, 0) 
                         AS porc_comision, fa_notaCreDeb.no_fecha AS fecha_fact, fa_notaCreDeb.no_fecha_venc AS fecha_vcto_fact, tb_persona.pe_nombreCompleto AS nom_Cliente, 
                         isnull(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, 0), CASE WHEN ISNULL(DATEDIFF(day, dbo.fa_notaCreDeb.no_fecha_venc, dbo.cxc_cobro.cr_fechaCobro), 
                         0) < 0 THEN 0 ELSE ISNULL(DATEDIFF(day, dbo.fa_notaCreDeb.no_fecha_venc, dbo.cxc_cobro.cr_fechaCobro), 0) END AS Dias_atraso, 0 AS Porc_pagado, 
                         CAST(0 AS float) AS Expr1, fa_cliente.IdCliente, CASE WHEN AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva) > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 
                         0) / ((AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva) / 100) + 1)) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) END AS Base_com, CAST(0 AS bit) 
                         AS Esta_en_base, fa_notaCreDeb.CodNota, 0 AS Expr2, CASE WHEN AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva) 
                         > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) / ((AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva) / 100) + 1)) 
                         * (Grafinpren.fa_notaCreDeb_graf.porc_comision / 100) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) * (Grafinpren.fa_notaCreDeb_graf.porc_comision / 100) 
                         END AS Expr3, Grafinpren.fa_notaCreDeb_graf.num_op, Grafinpren.fa_notaCreDeb_graf.num_cotizacion, fa_notaCreDeb.CodDocumentoTipo
FROM            Grafinpren.fa_notaCreDeb_graf INNER JOIN
                         fa_notaCreDeb INNER JOIN
                         fa_Vendedor ON fa_notaCreDeb.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_notaCreDeb.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON Grafinpren.fa_notaCreDeb_graf.IdEmpresa = fa_notaCreDeb.IdEmpresa AND 
                         Grafinpren.fa_notaCreDeb_graf.IdSucursal = fa_notaCreDeb.IdSucursal AND Grafinpren.fa_notaCreDeb_graf.IdBodega = fa_notaCreDeb.IdBodega AND 
                         Grafinpren.fa_notaCreDeb_graf.IdNota = fa_notaCreDeb.IdNota AND Grafinpren.fa_notaCreDeb_graf.IdEmpresa = fa_notaCreDeb.IdEmpresa AND 
                         Grafinpren.fa_notaCreDeb_graf.IdSucursal = fa_notaCreDeb.IdSucursal AND Grafinpren.fa_notaCreDeb_graf.IdBodega = fa_notaCreDeb.IdBodega AND 
                         Grafinpren.fa_notaCreDeb_graf.IdNota = fa_notaCreDeb.IdNota INNER JOIN
                         cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND 
                         cxc_cobro_det.IdCobro = cxc_cobro.IdCobro ON fa_notaCreDeb.IdEmpresa = cxc_cobro_det.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = cxc_cobro_det.IdSucursal AND fa_notaCreDeb.IdBodega = cxc_cobro_det.IdBodega_Cbte AND 
                         fa_notaCreDeb.IdNota = cxc_cobro_det.IdCbte_vta_nota AND fa_notaCreDeb.CodDocumentoTipo = cxc_cobro_det.dc_TipoDocumento INNER JOIN
                         vwfa_notaCreDeb_det_Subtotal_Iva_total ON fa_notaCreDeb.IdEmpresa = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega AND fa_notaCreDeb.IdNota = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota
WHERE        (NOT EXISTS
                             (SELECT        cxc_cobro_det.IdEmpresa
                               FROM            cxc_cobro_det AS D INNER JOIN
                                                         Grafinpren.cxc_Comisiones_x_vendedor AS COM ON D .IdEmpresa = COM.IdEmpresa AND D .IdSucursal = COM.IdSucursal AND 
                                                         D .IdCobro = COM.IdCobro AND D .secuencial = COM.Secuencia AND COM.IdEmpresa = cxc_cobro_det.IdEmpresa AND 
                                                         COM.IdSucursal = cxc_cobro_det.IdSucursal AND COM.IdCobro = cxc_cobro_det.IdCobro AND COM.Secuencia = cxc_cobro_det.secuencial))
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro.IdCobro_tipo, cxc_cobro.cr_fechaCobro, cxc_cobro_det.secuencial, 
                         fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.IdSucursal, fa_notaCreDeb.IdBodega, fa_notaCreDeb.IdNota, fa_notaCreDeb.IdVendedor, fa_Vendedor.Ve_Vendedor, 
                         Grafinpren.fa_notaCreDeb_graf.porc_comision, fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc, tb_persona.pe_nombreCompleto, 
                         vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, fa_Vendedor.IdVendedor, fa_cliente.IdCliente, cxc_cobro_det.dc_ValorPago, fa_notaCreDeb.CodNota, 
                         Grafinpren.fa_notaCreDeb_graf.num_op, Grafinpren.fa_notaCreDeb_graf.num_cotizacion, fa_notaCreDeb.CodDocumentoTipo
UNION
SELECT        com.IdEmpresa AS IdEmpresa_cbr, com.IdSucursal AS IdSucursal_cbr, com.IdCobro AS IdCobro_cbr, com.Secuencia AS Secuencial_cbr, cxc_cobro.IdCobro_tipo, 
                         cxc_cobro.cr_fechaCobro, ISNULL(SUM(cxc_cobro_det.dc_ValorPago), 0) AS Pago, fa_notaCreDeb.IdEmpresa AS IdEmpresa_fact, 
                         fa_notaCreDeb.IdSucursal AS IdSucursal_fact, fa_notaCreDeb.IdBodega AS IdBodega_fact, fa_notaCreDeb.IdNota AS IdCbteVta_fact, fa_notaCreDeb.IdVendedor, 
                         fa_Vendedor.Ve_Vendedor, Grafinpren.fa_notaCreDeb_graf.porc_comision, fa_notaCreDeb.no_fecha AS fecha_fact, fa_notaCreDeb.no_fecha_venc AS fecha_vcto_fact,
                          tb_persona.pe_nombreCompleto AS nom_Cliente, isnull(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, 0), CASE WHEN ISNULL(DATEDIFF(day, 
                         dbo.fa_notaCreDeb.no_fecha_venc, dbo.cxc_cobro.cr_fechaCobro), 0) < 0 THEN 0 ELSE ISNULL(DATEDIFF(day, dbo.fa_notaCreDeb.no_fecha_venc, 
                         dbo.cxc_cobro.cr_fechaCobro), 0) END AS Dias_atraso, com.Porc_pagado, com.Valor_pagado, fa_cliente.IdCliente, 
                         CASE WHEN AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva) > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) 
                         / ((AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva) / 100) + 1)) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) END AS Base_com, CAST(1 AS bit) 
                         AS Esta_en_base, fa_notaCreDeb.CodNota, 0 AS Dias_Vct, CASE WHEN AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_iva) 
                         > 0 THEN (ISNULL(cxc_cobro_det.dc_ValorPago, 0) / ((AVG(vwfa_notaCreDeb_det_Subtotal_Iva_total.vt_por_iva) / 100) + 1)) 
                         * (Grafinpren.fa_notaCreDeb_graf.porc_comision / 100) ELSE (ISNULL(cxc_cobro_det.dc_ValorPago, 0)) * (Grafinpren.fa_notaCreDeb_graf.porc_comision / 100) 
                         END AS Expr1, Grafinpren.fa_notaCreDeb_graf.num_op, Grafinpren.fa_notaCreDeb_graf.num_cotizacion, fa_notaCreDeb.CodDocumentoTipo
FROM            Grafinpren.fa_notaCreDeb_graf INNER JOIN
                         fa_notaCreDeb INNER JOIN
                         fa_Vendedor ON fa_notaCreDeb.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_notaCreDeb.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON Grafinpren.fa_notaCreDeb_graf.IdEmpresa = fa_notaCreDeb.IdEmpresa AND 
                         Grafinpren.fa_notaCreDeb_graf.IdSucursal = fa_notaCreDeb.IdSucursal AND Grafinpren.fa_notaCreDeb_graf.IdBodega = fa_notaCreDeb.IdBodega AND 
                         Grafinpren.fa_notaCreDeb_graf.IdNota = fa_notaCreDeb.IdNota AND Grafinpren.fa_notaCreDeb_graf.IdEmpresa = fa_notaCreDeb.IdEmpresa AND 
                         Grafinpren.fa_notaCreDeb_graf.IdSucursal = fa_notaCreDeb.IdSucursal AND Grafinpren.fa_notaCreDeb_graf.IdBodega = fa_notaCreDeb.IdBodega AND 
                         Grafinpren.fa_notaCreDeb_graf.IdNota = fa_notaCreDeb.IdNota INNER JOIN
                         cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND 
                         cxc_cobro_det.IdCobro = cxc_cobro.IdCobro ON fa_notaCreDeb.IdEmpresa = cxc_cobro_det.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = cxc_cobro_det.IdSucursal AND fa_notaCreDeb.IdBodega = cxc_cobro_det.IdBodega_Cbte AND 
                         fa_notaCreDeb.IdNota = cxc_cobro_det.IdCbte_vta_nota AND fa_notaCreDeb.CodDocumentoTipo = cxc_cobro_det.dc_TipoDocumento INNER JOIN
                         Grafinpren.cxc_Comisiones_x_vendedor AS com ON cxc_cobro_det.IdEmpresa = com.IdEmpresa AND cxc_cobro_det.IdSucursal = com.IdSucursal AND 
                         cxc_cobro_det.IdCobro = com.IdCobro AND cxc_cobro_det.secuencial = com.Secuencia INNER JOIN
                         vwfa_notaCreDeb_det_Subtotal_Iva_total ON fa_notaCreDeb.IdEmpresa = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa AND 
                         fa_notaCreDeb.IdSucursal = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega AND fa_notaCreDeb.IdNota = vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota
GROUP BY com.IdEmpresa, com.IdSucursal, com.IdCobro, cxc_cobro.IdCobro_tipo, cxc_cobro.cr_fechaCobro, com.Secuencia, fa_notaCreDeb.IdEmpresa, 
                         fa_notaCreDeb.IdSucursal, fa_notaCreDeb.IdBodega, fa_notaCreDeb.IdNota, fa_notaCreDeb.IdVendedor, fa_Vendedor.Ve_Vendedor, com.Porc_pagado, 
                         Grafinpren.fa_notaCreDeb_graf.porc_comision, com.Valor_pagado, fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc, tb_persona.pe_nombreCompleto, 
                         vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total, fa_Vendedor.IdVendedor, fa_cliente.IdCliente, cxc_cobro_det.dc_ValorPago, fa_notaCreDeb.CodNota, 
                         Grafinpren.fa_notaCreDeb_graf.num_op, Grafinpren.fa_notaCreDeb_graf.num_cotizacion, fa_notaCreDeb.CodDocumentoTipo
UNION
SELECT        dbo.cxc_cobro.IdEmpresa AS IdEmpresa_cbr, dbo.cxc_cobro.IdSucursal AS IdSucursal_cbr, dbo.cxc_cobro.IdCobro AS IdCobro_cbr, 
                         isnull(dbo.cxc_cobro_det.secuencial, 0) AS Secuencial_cbr, dbo.cxc_cobro.IdCobro_tipo, dbo.cxc_cobro.cr_fechaCobro, cxc_cobro.cr_TotalCobro AS Pago, NULL 
                         AS IdEmpresa_fact, NULL AS IdSucursal_fact, NULL AS IdBodega_fact, NULL AS IdCbteVta_fact, NULL, NULL, 0 AS porc_comision, NULL AS fecha_fact, NULL 
                         AS fecha_vcto_fact, dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, 0 AS Fa_total, 0 AS Dias_atraso, 0 AS Porc_pagado, CAST(0 AS float) AS Valor_pagado, 
                         dbo.fa_cliente.IdCliente, 0 AS Base_com, CAST(0 AS bit) AS Esta_en_base, NULL, 0, 0, '', '', 'SIN CBTE'
FROM            cxc_cobro INNER JOIN
                         fa_cliente ON cxc_cobro.IdEmpresa = fa_cliente.IdEmpresa AND cxc_cobro.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona LEFT OUTER JOIN
                         cxc_cobro_det ON cxc_cobro.IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro.IdSucursal = cxc_cobro_det.IdSucursal AND 
                         cxc_cobro.IdCobro = cxc_cobro_det.IdCobro
WHERE        (cxc_cobro_det.IdCbte_vta_nota IS NULL)
UNION
SELECT        COM.IdEmpresa AS IdEmpresa_cbr, COM.IdSucursal AS IdSucursal_cbr, COM.IdCobro AS IdCobro_cbr, COM.Secuencia AS Secuencial_cbr, cxc_cobro.IdCobro_tipo, 
                         cxc_cobro.cr_fechaCobro, cxc_cobro.cr_TotalCobro AS Pago, NULL AS IdEmpresa_fact, NULL AS IdSucursal_fact, NULL AS IdBodega_fact, NULL 
                         AS IdCbteVta_fact, NULL AS Expr1, NULL AS Expr2, 0 AS porc_comision, NULL AS fecha_fact, NULL AS fecha_vcto_fact, 
                         tb_persona.pe_nombreCompleto AS nom_Cliente, 0 AS Fa_total, 0 AS Dias_atraso, COM.Porc_pagado AS Porc_pagado, COM.Valor_pagado AS Valor_pagado, 
                         fa_cliente.IdCliente, 0 AS Base_com, CAST(0 AS bit) AS Esta_en_base, NULL AS Expr3, 0 AS Expr4, 0, '', '', 'SIN CBTE'
FROM            cxc_cobro INNER JOIN
                         fa_cliente ON cxc_cobro.IdEmpresa = fa_cliente.IdEmpresa AND cxc_cobro.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona INNER JOIN
                         Grafinpren.cxc_Comisiones_x_vendedor COM ON cxc_cobro.IdEmpresa = COM.IdEmpresa AND cxc_cobro.IdSucursal = COM.IdSucursal AND 
                         cxc_cobro.IdCobro = COM.IdCobro LEFT OUTER JOIN
                         cxc_cobro_det ON cxc_cobro.IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro.IdSucursal = cxc_cobro_det.IdSucursal AND 
                         cxc_cobro.IdCobro = cxc_cobro_det.IdCobro
WHERE        (cxc_cobro_det.IdCbte_vta_nota IS NULL) AND (NOT EXISTS
                             (SELECT        dbo.cxc_cobro_det.IdEmpresa
                               FROM            dbo.cxc_cobro_det AS D INNER JOIN
                                                         Grafinpren.cxc_Comisiones_x_vendedor AS COM ON D .IdEmpresa = COM.IdEmpresa AND D .IdSucursal = COM.IdSucursal AND 
                                                         D .IdCobro = COM.IdCobro AND D .secuencial = COM.Secuencia AND COM.IdEmpresa = dbo.cxc_cobro_det.IdEmpresa AND 
                                                         COM.IdSucursal = dbo.cxc_cobro_det.IdSucursal AND COM.IdCobro = dbo.cxc_cobro_det.IdCobro AND COM.Secuencia = 0))