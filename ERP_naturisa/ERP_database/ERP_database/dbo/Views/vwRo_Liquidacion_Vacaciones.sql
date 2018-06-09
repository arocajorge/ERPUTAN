create view  [dbo].[vwRo_Liquidacion_Vacaciones] as 

SELECT        dbo.ro_rol_individual.IdEmpresa, dbo.ro_rol_individual.IdNominaTipo, dbo.ro_rol_individual.IdNominaTipoLiqui, dbo.ro_rol_individual.IdPeriodo, 
                         dbo.ro_rol_individual.IdEmpleado, dbo.ro_rol_individual.IdRubro, dbo.ro_rol_individual.Ingreso, dbo.ro_rol_individual.Egreso, dbo.ro_rol_individual.Orden, 
                         dbo.ro_rol_individual.FechaPago, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_rubro_tipo.rub_aplica_IESS, dbo.ro_rubro_tipo.rub_guarda_rol, 
                         dbo.ro_rubro_tipo.rub_utilid, dbo.ro_rubro_tipo.rub_nocontab, dbo.ro_rubro_tipo.rub_prorrateo, dbo.ro_rubro_tipo.rub_noafecta, dbo.ro_rubro_tipo.rub_provision, 
                         dbo.ro_rubro_tipo.rub_liquida, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, 
                         dbo.ro_periodo.pe_estado, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc
FROM            dbo.ro_rol_individual INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_individual.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_individual.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_rol_individual.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.ro_periodo ON dbo.ro_rol_individual.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_rol_individual.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
WHERE        (dbo.ro_rubro_tipo.rub_aplica_IESS = 1)