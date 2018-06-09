CREATE VIEW [Fj_servindustrias].[vwfa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH] as
	SELECT        IdEmpresa, IdFuerza, Fecha_Inicio, Fecha_Fin
FROM            Fj_servindustrias.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH
GROUP BY IdEmpresa, IdFuerza, Fecha_Inicio, Fecha_Fin