-- exec spROL_DecimoCuarto 1,'01/08/2016','31/07/2017'
create PROCEDURE [dbo].[spROL_DecimoCuarto]
	(
	@i_IdEmpresa int,	
	@FechaInicio date,
	@fecha_Fin date
	)
	as
BEGIN

	SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui, dbo.ro_rol_detalle.IdEmpleado, SUM(dbo.ro_rol_detalle_x_rubro_acumulado.Valor) AS Valor 

FROM            dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_Nomina_Tipoliqui INNER JOIN
                         dbo.ro_rol ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = dbo.ro_rol.IdEmpresa AND dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = dbo.ro_rol.IdNominaTipo AND 
                         dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui = dbo.ro_rol.IdNominaTipoLiqui ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rol.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdNominaTipo = dbo.ro_rol.IdNominaTipo AND dbo.ro_rol_detalle.IdNominaTipoLiqui = dbo.ro_rol.IdNominaTipoLiqui AND 
                         dbo.ro_rol_detalle.IdPeriodo = dbo.ro_rol.IdPeriodo INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado AND dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui ON dbo.ro_rol.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         dbo.ro_rol.IdNominaTipo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo AND 
                         dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui AND 
                         dbo.ro_rol.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_rol_detalle.IdRubro = 4 INNER JOIN
                         dbo.ro_rol_detalle_x_rubro_acumulado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rol_detalle_x_rubro_acumulado.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdNominaTipo = dbo.ro_rol_detalle_x_rubro_acumulado.IdNominaTipo AND 
                         dbo.ro_rol_detalle.IdNominaTipoLiqui = dbo.ro_rol_detalle_x_rubro_acumulado.IdNominaTipoLiqui AND 
                         dbo.ro_rol_detalle.IdPeriodo = dbo.ro_rol_detalle_x_rubro_acumulado.IdPeriodo AND 
                         dbo.ro_rol_detalle.IdEmpleado = dbo.ro_rol_detalle_x_rubro_acumulado.IdEmpleado                         
						 and dbo.ro_rol_detalle_x_rubro_acumulado.IdRubro=200
						 and dbo.ro_rol_detalle.IdEmpresa=@i_IdEmpresa
						 and ro_periodo.pe_FechaIni between @FechaInicio and @fecha_Fin
GROUP BY dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdEmpleado,  dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui 
                        
END