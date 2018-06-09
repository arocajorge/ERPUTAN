
creATE PROCEDURE [dbo].[spROL_DecimoTercero]
	(
	@i_IdEmpresa int,	
	@FechaInicio date,
	@fecha_Fin date
	)
	as
BEGIN

	
	SELECT           dbo.ro_rol_detalle.IdEmpresa,dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui, dbo.ro_rol_detalle.IdEmpleado,SUM( dbo.ro_rol_detalle.Valor)Valor
                         
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
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa
						 and dbo.ro_rol_detalle.IdRubro=4
						 group by 



						  dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rol_detalle.Valor, 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui
END