--************************************************************************************************************************************
CREATE  PROCEDURE [dbo].[spROL_Rpt016]
@idempresa int,
@idnomina int,
@fecha_inicio date,
@fecha_fin date
AS
BEGIN
	
	SET NOCOUNT ON;
-- se extrae el total de sueldo
SELECT                   dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rol_detalle.IdNominaTipoLiqui, dbo.ro_rol_detalle.IdPeriodo, 
                         dbo.ro_rol_detalle.IdRubro, dbo.ro_empleado.IdDepartamento, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_rubro_tipo.ru_descripcion,Valor,dbo.Ro_Departamento.de_descripcion,dbo.ro_Nomina_Tipo.Descripcion
						 -- (select Valor from vwRo_Rol_Detalle as D where D.IdEmpresa=@idempresa and D.IdNominaTipo=@idnomina and D.IdPeriodo=dbo.ro_periodo.IdPeriodo and D.IdEmpleado=dbo.ro_rol_detalle.IdEmpleado and D.FechaIni between @fecha_inicio and @fecha_fin   and D.IdRubro=4) as Sueldo,
						--  (select Valor from vwRo_Rol_Detalle as D where D.IdEmpresa=@idempresa and D.IdNominaTipo=@idnomina and D.IdPeriodo=dbo.ro_periodo.IdPeriodo and D.IdEmpleado=dbo.ro_rol_detalle.IdEmpleado and D.FechaIni between @fecha_inicio and @fecha_fin   and D.IdRubro=2) as Dias_Trabajados,
						  --(select Valor from vwRo_Rol_Detalle as D where D.IdEmpresa=@idempresa and D.IdNominaTipo=@idnomina and D.IdPeriodo=dbo.ro_periodo.IdPeriodo and D.IdEmpleado=dbo.ro_rol_detalle.IdEmpleado and D.FechaIni between @fecha_inicio and @fecha_fin   and D.IdRubro=@idrubro) as Valor_Acumulado						 

FROM                     dbo.ro_rubro_tipo INNER JOIN
                         dbo.ro_rol_detalle ON dbo.ro_rubro_tipo.IdRubro = dbo.ro_rol_detalle.IdRubro INNER JOIN
                         dbo.ro_periodo ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_rol_detalle.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
						 dbo.Ro_Departamento ON	dbo.ro_empleado.IdDepartamento=	dbo.Ro_Departamento.IdDepartamento	INNER JOIN
						 dbo.ro_Nomina_Tipo ON dbo.ro_rol_detalle.IdNominaTipo=dbo.ro_Nomina_Tipo.IdNomina_Tipo
			             AND dbo.ro_rol_detalle.Valor>0	
						 And dbo.ro_periodo.pe_FechaIni between @fecha_inicio and @fecha_fin 
						 and  dbo.ro_rol_detalle.IdNominaTipo=@idnomina
						 and  dbo.ro_rol_detalle.IdEmpresa=@idempresa


END