CREATE VIEW [Fj_servindustrias].[vwro_planificacion_x_ruta_emple]
AS
SELECT        Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdEmpresa, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdNomina_Tipo, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdNomina_tipo_Liq, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdPeriodo, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.Observacion, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.Estado
FROM            dbo.ro_periodo INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado ON dbo.ro_periodo.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdEmpresa AND 
                         dbo.ro_periodo.IdPeriodo = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdPeriodo