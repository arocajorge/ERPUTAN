CREATE VIEW [Fj_servindustrias].[vwro_ro_planificacion_x_jornada_desfasada_empleado]
	AS 
	
SELECT        Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdEmpresa, Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdEmpleado, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdNomina_Tipo, Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdPeriodo, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdMes, Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdAnio, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdTurno, Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.Observacion, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.Estado, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado ON 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado.IdNomina_Tipo