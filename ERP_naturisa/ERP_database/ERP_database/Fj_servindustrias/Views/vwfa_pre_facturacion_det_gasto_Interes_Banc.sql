CREATE VIEW [Fj_servindustrias].[vwfa_pre_facturacion_det_gasto_Interes_Banc]
	AS 
	SELECT        dbo.ba_prestamo_detalle.IdEmpresa, dbo.ba_prestamo_detalle.IdPrestamo, dbo.ba_prestamo_detalle.NumCuota, dbo.ba_prestamo_detalle.SaldoInicial, 
                         dbo.ba_prestamo_detalle.Interes, dbo.ba_prestamo_detalle.AbonoCapital, dbo.ba_prestamo_detalle.TotalCuota, dbo.ba_prestamo_detalle.Saldo, 
                         dbo.ba_prestamo_detalle.FechaPago, dbo.ba_prestamo_detalle.EstadoPago, dbo.ba_prestamo_detalle.Observacion_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.Valor
FROM            dbo.ba_prestamo INNER JOIN
                         dbo.ba_prestamo_detalle ON dbo.ba_prestamo.IdEmpresa = dbo.ba_prestamo_detalle.IdEmpresa AND 
                         dbo.ba_prestamo.IdPrestamo = dbo.ba_prestamo_detalle.IdPrestamo INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc ON 
                         dbo.ba_prestamo_detalle.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdEmpresa AND 
                         dbo.ba_prestamo_detalle.IdPrestamo = Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdPrestamo AND 
                         dbo.ba_prestamo_detalle.NumCuota = Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdSecuencia_Prestamo AND 
                         dbo.ba_prestamo.IdCliente = Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc.IdCliente