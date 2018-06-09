CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt007]
	@IdEmpresa int,
	@IdNomina_Tipo int,
	@IdNomina_Tipo_Liq int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date
	
AS

/*
declare
    @IdEmpresa int,
	@IdNomina_Tipo int,
	@IdNomina_Tipo_Liq int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	set @IdEmpresa=1
	set @IdNomina_Tipo =1
	set @IdNomina_Tipo_Liq =2
	set @IdPeriodo=201610
	set @Fecha_Inicio='01/10/2016'
	set @Fecha_Fin='31/10/2016'
	*/
BEGIN
	SELECT       
	               Fj_servindustrias.ro_zona.zo_descripcion,
				  Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ro_emp.em_fecha_ingreso, dbo.ro_periodo.pe_FechaIni,
				  dbo.ro_catalogo.ca_descripcion,
				  pers.pe_cedulaRuc, 
                  pers.pe_apellido,
				  pers.pe_nombre, 
				  dbo.ro_cargo.ca_descripcion AS Cargo,
				  suel_hist.SueldoActual,
				  (select isnull( R.Valor,0) from ro_rol_detalle as R where R.IdEmpresa=@IdEmpresa and R.IdNominaTipo=@IdNomina_Tipo and R.IdNominaTipoLiqui=@IdNomina_Tipo_Liq and R.IdEmpleado=ro_emp.IdEmpleado and R.IdPeriodo=@IdPeriodo and IdRubro=2)  as Dias,
				  (select COUNT( M.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as M where M.IdEmpresa=@IdEmpresa and M.IdEmpleado=ro_emp.IdEmpleado and M.Id_catalogo_Cat='FAL' AND m.es_fecha_registro BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Falta,
				  (select ISNULL( sum(ISNULL( V.Dias_a_disfrutar,0)),0) from ro_Solicitud_Vacaciones_x_empleado as V where V.IdEmpresa=@IdEmpresa and V.IdEmpleado=ro_emp.IdEmpleado  AND V.Fecha_Desde BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Vacaciones,
				  (select ISNULL( datediff(day,ISNULL( P.FechaSalida,0),ISNULL( P.FechaEntrada,0)),0) from ro_permiso_x_empleado as P where P.IdEmpresa=@IdEmpresa and P.IdEmpleado=ro_emp.IdEmpleado  AND P.FechaSalida BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Permiso_IESS,
				  (select SUM(  Valor) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=976)  as Dias_Efectivos,
				  (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=24)  as [SUELDO X DIAS TRABAJADOS],

				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=7)  as [HORAS  25%],
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=8)  as [HORAS 50%],
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=9)  as [HORAS 100%],
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=68)  as [TRANSPORTE],
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=74)  as [ALIMENTACION],
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro in(select IdRubro from Fj_servindustrias.ro_parametro_x_pago_variable_tipo))  as [BONIFICACIÓN]
           
FROM            dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS ro_planifi_x_ruta ON Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = ro_planifi_x_ruta.IdNomina_Tipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = ro_planifi_x_ruta.IdNomina_Tipo_Liq AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = ro_planifi_x_ruta.IdPeriodo INNER JOIN
                         dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS ro_emp ON pers.IdPersona = ro_emp.IdPersona INNER JOIN
                         dbo.ro_catalogo ON ro_emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_empleado_historial_Sueldo AS suel_hist ON ro_emp.IdEmpresa = suel_hist.IdEmpresa AND ro_emp.IdEmpleado = suel_hist.IdEmpleado ON 
                         ro_planifi_x_ruta.IdEmpresa = ro_emp.IdEmpresa AND ro_planifi_x_ruta.IdEmpleado = ro_emp.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_zona ON ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona
end

--   select * from ro_rubro_tipo where ru_descripcion like '%alime%'
--   select * from ro_rol_detalle where IdEmpleado=11 and IdRubro=2 and IdPeriodo=201610