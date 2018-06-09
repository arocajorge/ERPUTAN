CREATE VIEW [Fj_servindustrias].[vwro_planificacion_x_jornada_desfasada]
	AS
	
SELECT        Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdEmpresa, Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdPeriodo, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Observación, Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Esta_Proceso, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Estado, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdNomina_Tipo
FROM            dbo.ro_periodo INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada ON dbo.ro_periodo.IdEmpresa = Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdEmpresa AND 
                         dbo.ro_periodo.IdPeriodo = Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdPeriodo
GROUP BY Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdEmpresa, Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdPeriodo, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Observación, Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Esta_Proceso, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.Estado, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, 
                         Fj_servindustrias.ro_planificacion_x_jornada_desfasada.IdNomina_Tipo