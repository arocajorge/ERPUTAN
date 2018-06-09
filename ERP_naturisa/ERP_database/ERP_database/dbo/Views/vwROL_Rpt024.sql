CREATE VIEW [dbo].[vwROL_Rpt024]
	AS 

SELECT        dbo.tb_persona.pe_cedulaRuc AS CedulaRuc, dbo.tb_persona.pe_nombreCompleto AS NombreCompleto, dbo.ro_empleado.IdEmpleado, 
                         dbo.ro_prestamo.IdPrestamo, dbo.ro_prestamo.IdEmpresa, dbo.ro_prestamo.IdNomina_Tipo, dbo.ro_Nomina_Tipo.Descripcion AS NominaDescripcion, 
                         dbo.ro_prestamo.Estado AS EstadoPrestamo, dbo.ro_prestamo.Fecha, dbo.ro_prestamo.MontoSol, dbo.ro_prestamo.TasaInteres, dbo.ro_prestamo.TotalPrestamo, 
                         dbo.ro_prestamo.NumCuotas, dbo.ro_prestamo.Observacion, dbo.ro_prestamo_detalle.NumCuota, dbo.ro_prestamo_detalle.SaldoInicial, 
                         dbo.ro_prestamo_detalle.Interes, dbo.ro_prestamo_detalle.AbonoCapital, dbo.ro_prestamo_detalle.TotalCuota, dbo.ro_prestamo_detalle.Saldo, 
                         dbo.ro_prestamo_detalle.FechaPago, dbo.ro_prestamo_detalle.EstadoPago, dbo.ro_prestamo_detalle.Observacion_det AS ObservacionCuota, 
                         dbo.ro_rubro_tipo.ru_descripcion AS RubroDescripcion, dbo.ro_empleado.em_codigo AS CodigoEmpleado, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.ro_catalogo.ca_descripcion, ro_catalogo_1.ca_descripcion AS EstadoCuota, iif(dbo.ro_prestamo_detalle.EstadoPago = 'CAN', 
                         dbo.ro_prestamo_detalle.TotalCuota, 0) AS Canceladas, iif(dbo.ro_prestamo_detalle.EstadoPago = 'PEN', dbo.ro_prestamo_detalle.TotalCuota, 0) 
                         AS Pendientes
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_prestamo ON dbo.ro_empleado.IdEmpresa = dbo.ro_prestamo.IdEmpresa AND dbo.ro_empleado.IdEmpresa = dbo.ro_prestamo.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_prestamo.IdEmpleado INNER JOIN
                         dbo.ro_prestamo_detalle ON dbo.ro_prestamo.IdEmpresa = dbo.ro_prestamo_detalle.IdEmpresa AND 
                         dbo.ro_prestamo.IdPrestamo = dbo.ro_prestamo_detalle.IdPrestamo INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_prestamo.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND 
                         dbo.ro_prestamo.IdNomina_Tipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_prestamo.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_catalogo ON dbo.ro_prestamo.IdMotivo_Prestamo = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_catalogo AS ro_catalogo_1 ON dbo.ro_prestamo_detalle.EstadoPago = ro_catalogo_1.CodCatalogo
						 and  dbo.ro_rubro_tipo.IdEmpresa=dbo.ro_prestamo.IdEmpresa