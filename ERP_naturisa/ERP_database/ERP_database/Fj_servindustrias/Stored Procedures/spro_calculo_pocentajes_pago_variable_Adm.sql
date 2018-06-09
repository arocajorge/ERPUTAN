

CREATE PROCEDURE  [Fj_servindustrias].[spro_calculo_pocentajes_pago_variable_Adm]  
	@Idempres int,
	@Fecha_Inicio date,
	@Fecha_fin date,
	@IdNomina_Tipo int,
	@IdPeriodo int
AS

BEGIN
	/*
	declare 
	@Idempres int,
	@Fecha_Inicio date,
	@Fecha_fin date,
    @IdNomina_Tipo int,
	@IdPeriodo int
	set @Idempres=1
	set @Fecha_Inicio='01/10/2016'
	set @Fecha_fin='31/10/2016'
	set @IdNomina_Tipo=1
	set @IdPeriodo=201610
	--set @Estado_em=''
	*/
	
	-- traet todos los empleados que no tienen marcaciones en ese dia

	SELECT               param_pag_va_det.Idempresa,
						 param_pag_va_det.IdNomina_Tipo, 
						 param_pag_va_det.Id_Tipo_Pago_Variable, 
						 param_pag_va_det.Meta, 
                         param_pag_va_det.Variable_porcentaje_prorrateado,
						 rubro_t.ru_descripcion, 
						 grup_em.Valor_bono,
						 dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre, 
						 dbo.tb_persona.pe_cedulaRuc, 
						 emp.IdEmpleado,
						 rubro_t.IdRubro, 
                         pago_var_tipo.nom_Pago_Variable,
						  param_pag_va_det.cod_Pago_Variable,
						 -- subconsultas para pago de variable de jefe de rrhh
						 (select COUNT(IdEmpleado) from dbo.ro_contrato where IdEmpresa=@Idempres and  em_fecha_ingreso between @Fecha_Inicio and @Fecha_fin) as cantidad_empleados_nuevos,
						 (select COUNT(IdEmpleado) from dbo.ro_contrato where IdEmpresa=@Idempres and EstadoContrato='ECT_LIQ' AND  em_fechaSalida between @Fecha_Inicio and @Fecha_fin) as cantidad_empleados_salieron,
						 (select COUNT(IdEmpleado) from dbo.ro_contrato where IdEmpresa=@Idempres and EstadoContrato='ECT_ACT') as cantidad_empleados_activos,
						 (select COUNT(IdEmpleado) from  Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as marcaciones where marcaciones.IdEmpresa=@Idempres and marcaciones.IdNomina_Tipo=@IdNomina_Tipo and  marcaciones.es_fecha_registro  between @Fecha_Inicio and @Fecha_fin and marcaciones.Id_catalogo_Cat='ASIST') as Total_Asistencia,
						 (select COUNT(IdEmpleado) from  Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as marcaciones where marcaciones.IdEmpresa=@Idempres and marcaciones.IdNomina_Tipo=@IdNomina_Tipo and  marcaciones.es_fecha_registro  between @Fecha_Inicio and @Fecha_fin and marcaciones.Id_catalogo_Cat='FAL') as Total_Faltas,


						 (select isnull( sum( isnull( Efectividad.Efectividad_Entrega,0)),0) from Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det as Efectividad where Efectividad.IdEmpresa=@Idempres and Efectividad.IdNomina_Tipo=@IdNomina_Tipo and  Efectividad.IdPeriodo=@IdPeriodo ) as efectividad_entrega,
						 (select isnull( sum( isnull(Efectividad.Efectividad_Volumen,0)),0) from  Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det as Efectividad where Efectividad.IdEmpresa=@Idempres and Efectividad.IdNomina_Tipo=@IdNomina_Tipo and  Efectividad.IdPeriodo=@IdPeriodo) as efectividad_volumen,
						 (select isnull(sum(isnull(Efectividad.Recuperacion_cartera,0)) ,0)from  Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det as Efectividad where Efectividad.IdEmpresa=@Idempres and Efectividad.IdNomina_Tipo=@IdNomina_Tipo and  Efectividad.IdPeriodo=@IdPeriodo) as recuperacion_cartera



FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado AS emp ON dbo.tb_persona.IdPersona = emp.IdPersona AND dbo.tb_persona.IdPersona = emp.IdPersona AND 
                         dbo.tb_persona.IdPersona = emp.IdPersona AND dbo.tb_persona.IdPersona = emp.IdPersona AND dbo.tb_persona.IdPersona = emp.IdPersona AND 
                         dbo.tb_persona.IdPersona = emp.IdPersona INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado AS grup_em ON emp.IdEmpresa = grup_em.IdEmpresa AND emp.IdGrupo = grup_em.IdGrupo INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina AS em_x_nom ON emp.IdEmpresa = em_x_nom.IdEmpresa AND emp.IdEmpleado = em_x_nom.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable_Det AS Em_x_pago_v_d INNER JOIN
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable AS em_x_pago_v ON Em_x_pago_v_d.IdEmpresa = em_x_pago_v.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = em_x_pago_v.IdNomina_Tipo AND Em_x_pago_v_d.IdEmpleado = em_x_pago_v.IdEmpleado AND 
                         Em_x_pago_v_d.IdEmpresa = em_x_pago_v.IdEmpresa AND Em_x_pago_v_d.IdNomina_Tipo = em_x_pago_v.IdNomina_Tipo AND 
                         Em_x_pago_v_d.IdEmpleado = em_x_pago_v.IdEmpleado AND Em_x_pago_v_d.IdEmpresa = em_x_pago_v.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = em_x_pago_v.IdNomina_Tipo AND Em_x_pago_v_d.IdEmpleado = em_x_pago_v.IdEmpleado AND 
                         Em_x_pago_v_d.IdEmpresa = em_x_pago_v.IdEmpresa AND Em_x_pago_v_d.IdNomina_Tipo = em_x_pago_v.IdNomina_Tipo AND 
                         Em_x_pago_v_d.IdEmpleado = em_x_pago_v.IdEmpleado AND Em_x_pago_v_d.IdEmpresa = em_x_pago_v.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = em_x_pago_v.IdNomina_Tipo AND Em_x_pago_v_d.IdEmpleado = em_x_pago_v.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable AS param_pago_var ON Em_x_pago_v_d.IdEmpresa = param_pago_var.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = param_pago_var.IdNomina_Tipo AND Em_x_pago_v_d.Id_Tipo_Pago_Variable = param_pago_var.Id_Tipo_Pago_Variable AND 
                         Em_x_pago_v_d.IdEmpresa = param_pago_var.IdEmpresa AND Em_x_pago_v_d.IdNomina_Tipo = param_pago_var.IdNomina_Tipo AND 
                         Em_x_pago_v_d.Id_Tipo_Pago_Variable = param_pago_var.Id_Tipo_Pago_Variable AND Em_x_pago_v_d.IdEmpresa = param_pago_var.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = param_pago_var.IdNomina_Tipo AND Em_x_pago_v_d.Id_Tipo_Pago_Variable = param_pago_var.Id_Tipo_Pago_Variable AND 
                         Em_x_pago_v_d.IdEmpresa = param_pago_var.IdEmpresa AND Em_x_pago_v_d.IdNomina_Tipo = param_pago_var.IdNomina_Tipo AND 
                         Em_x_pago_v_d.Id_Tipo_Pago_Variable = param_pago_var.Id_Tipo_Pago_Variable AND Em_x_pago_v_d.IdEmpresa = param_pago_var.IdEmpresa AND 
                         Em_x_pago_v_d.IdNomina_Tipo = param_pago_var.IdNomina_Tipo AND 
                         Em_x_pago_v_d.Id_Tipo_Pago_Variable = param_pago_var.Id_Tipo_Pago_Variable INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable_Det AS param_pag_va_det ON param_pago_var.IdEmpresa = param_pag_va_det.Idempresa AND 
                         param_pago_var.IdNomina_Tipo = param_pag_va_det.IdNomina_Tipo AND 
                         param_pago_var.Id_Tipo_Pago_Variable = param_pag_va_det.Id_Tipo_Pago_Variable AND param_pago_var.IdEmpresa = param_pag_va_det.Idempresa AND 
                         param_pago_var.IdNomina_Tipo = param_pag_va_det.IdNomina_Tipo AND 
                         param_pago_var.Id_Tipo_Pago_Variable = param_pag_va_det.Id_Tipo_Pago_Variable AND param_pago_var.IdEmpresa = param_pag_va_det.Idempresa AND 
                         param_pago_var.IdNomina_Tipo = param_pag_va_det.IdNomina_Tipo AND 
                         param_pago_var.Id_Tipo_Pago_Variable = param_pag_va_det.Id_Tipo_Pago_Variable AND param_pago_var.IdEmpresa = param_pag_va_det.Idempresa AND 
                         param_pago_var.IdNomina_Tipo = param_pag_va_det.IdNomina_Tipo AND 
                         param_pago_var.Id_Tipo_Pago_Variable = param_pag_va_det.Id_Tipo_Pago_Variable INNER JOIN
                         dbo.ro_rubro_tipo AS rubro_t INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo AS pago_var_tipo ON rubro_t.IdRubro = pago_var_tipo.IdRubro ON 
                         param_pag_va_det.Idempresa = pago_var_tipo.IdEmpresa AND param_pag_va_det.cod_Pago_Variable = pago_var_tipo.cod_Pago_Variable ON 
                         em_x_nom.IdEmpresa = em_x_pago_v.IdEmpresa AND em_x_nom.IdEmpleado = em_x_pago_v.IdEmpleado AND 
                         em_x_nom.IdTipoNomina = em_x_pago_v.IdNomina_Tipo
						
END

-- select * from ro_Solicitud_Vacaciones_x_empleado
--  select * from Fj_servindustrias.vwro_planificacion_turno_periodo where idempleado=19