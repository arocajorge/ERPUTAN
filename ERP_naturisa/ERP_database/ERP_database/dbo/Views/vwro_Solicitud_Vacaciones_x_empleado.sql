CREATE VIEW [dbo].[vwro_Solicitud_Vacaciones_x_empleado]
	AS 

SELECT        dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa, dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdSolicitud_Vacaciones, dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas
FROM            dbo.ro_Historico_Liquidacion_Vacaciones INNER JOIN
                         dbo.ro_Solicitud_Vacaciones_x_empleado ON dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo = dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdSolicitud_Vacaciones = dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado