


CREATE PROCEDURE  [Fj_servindustrias].[spro_empleados_con_jornadas_desfasada]  
	@Idempres int,
	@IdNomina int,
	@IdPeriodo int,
	@mes int,
	@anio int
AS


BEGIN
	/*
	declare 
	@Idempres int,
	@IdNomina int,
	@IdPeriodo int,
	@mes int,
	@anio int

	set @Idempres=1
	set @IdNomina=1
	set @IdPeriodo=2016001
	set @mes =05
	set @anio =2016
	*/

SELECT                   dbo.tb_persona.IdPersona, dbo.ro_empleado.IdEmpresa,dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.ro_empleado.IdEmpleado, dbo.ro_cargo.IdCargo, dbo.ro_Departamento.IdDepartamento, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.ro_Departamento.de_descripcion, dbo.ro_cargo.ca_descripcion,
						 (select COUNT(JD.idempleado) from Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado as JD, ro_turno as T
						  where JD.IdEmpresa=@Idempres
						  and JD.IdNomina_Tipo=@IdNomina
						  and JD.IdEmpleado=dbo.ro_empleado.IdEmpleado
						  and JD.idmes=@mes
						  and JD.idanio=@anio
						  and JD.IdTurno=T.idTurno
						  And JD.IDempresa=T.IdEmpresa
						  And T.es_jornada_desfasada=1) as Num_jornada_desfasada,
						  dbo.ro_empleado.IdDivision
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_Division ON dbo.ro_empleado.IdEmpresa = dbo.ro_Division.IdEmpresa AND dbo.ro_empleado.IdDivision = dbo.ro_Division.IdDivision
						 where  dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa=@Idempres 
						 and  dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina=@IdNomina
						 and (dbo.ro_empleado.em_status!='EST_LIQ'						      
						 )
						 and dbo.ro_empleado.em_estado='A'

END

-- select * from ro_Solicitud_Vacaciones_x_empleado