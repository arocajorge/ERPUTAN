CREATE VIEW Fj_servindustrias.[vwFAC_FJ_Rpt012]
	AS 
SELECT        dbo.ba_prestamo_detalle.IdEmpresa, dbo.ba_prestamo_detalle.IdPrestamo, dbo.ba_prestamo_detalle.NumCuota, dbo.ba_prestamo_detalle.SaldoInicial, 
                         dbo.ba_prestamo_detalle.Interes, dbo.ba_prestamo_detalle.AbonoCapital, dbo.ba_prestamo_detalle.TotalCuota, dbo.ba_prestamo_detalle.Saldo, 
                         dbo.ba_prestamo_detalle.FechaPago, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc, Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.Valor
FROM            Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc INNER JOIN
                         dbo.ba_prestamo_detalle ON Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdEmpresa = dbo.ba_prestamo_detalle.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdSecuencia_Prestamo = dbo.ba_prestamo_detalle.NumCuota AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdPrestamo = dbo.ba_prestamo_detalle.IdPrestamo INNER JOIN
                         dbo.ba_prestamo ON dbo.ba_prestamo_detalle.IdEmpresa = dbo.ba_prestamo.IdEmpresa AND 
                         dbo.ba_prestamo_detalle.IdPrestamo = dbo.ba_prestamo.IdPrestamo AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdCliente = dbo.ba_prestamo.IdCliente INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion ON 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdCliente = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli