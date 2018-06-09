create view [Fj_servindustrias].[vwROLES_Rpt004] as 
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.ro_Departamento.IdDepartamento, dbo.ro_cargo.IdCargo, 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo, dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui, 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, Fj_servindustrias.vwROLES_Rpt003.hora_extra25, 
                         Fj_servindustrias.vwROLES_Rpt003.hora_extra50, Fj_servindustrias.vwROLES_Rpt003.hora_extra100, Fj_servindustrias.vwROLES_Rpt003.TotalHorasExtras, 
                         Fj_servindustrias.vwROLES_Rpt003.hora_trabajada, Fj_servindustrias.vwROLES_Rpt003.Dias_Efectivos,
						 (select Valor from ro_rol_detalle where dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa=IdEmpresa and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo=ro_rol_detalle.IdNominaTipo and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui=ro_rol_detalle.IdNominaTipoLiqui and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo=ro_rol_detalle.IdPeriodo and dbo.ro_empleado.IdEmpleado=IdEmpleado and IdRubro=103 ) as Sueldo,
						 (select Valor from ro_rol_detalle where dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa=IdEmpresa and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo=ro_rol_detalle.IdNominaTipo and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui=ro_rol_detalle.IdNominaTipoLiqui and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo=ro_rol_detalle.IdPeriodo and dbo.ro_empleado.IdEmpleado=IdEmpleado and IdRubro=7 ) as Valor_Hora_25,
						 (select Valor from ro_rol_detalle where dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa=IdEmpresa and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo=ro_rol_detalle.IdNominaTipo and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui=ro_rol_detalle.IdNominaTipoLiqui and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo=ro_rol_detalle.IdPeriodo and dbo.ro_empleado.IdEmpleado=IdEmpleado and IdRubro=8 ) as Valor_Hora_250,
						 (select Valor from ro_rol_detalle where dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa=IdEmpresa and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo=ro_rol_detalle.IdNominaTipo and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui=ro_rol_detalle.IdNominaTipoLiqui and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo=ro_rol_detalle.IdPeriodo and dbo.ro_empleado.IdEmpleado=IdEmpleado and IdRubro=9 ) as Valor_Hora_100
FROM                     dbo.ro_empleado INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_empleado.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui ON dbo.ro_Nomina_Tipo.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         dbo.ro_Nomina_Tipo.IdNomina_Tipo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo LEFT OUTER JOIN
                         Fj_servindustrias.vwROLES_Rpt003 ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = Fj_servindustrias.vwROLES_Rpt003.IdNominaTipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = Fj_servindustrias.vwROLES_Rpt003.IdNominaTipoLiqui AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = Fj_servindustrias.vwROLES_Rpt003.IdPeriodo AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.vwROLES_Rpt003.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.vwROLES_Rpt003.IdEmpleado
                  -- WHERE  (dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = 201605)