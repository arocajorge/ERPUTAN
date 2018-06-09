

create view  Fj_servindustrias.vwROLES_Rpt001 as 
SELECT        dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdEmpleado, dbo.ro_nomina_x_horas_extras.IdNominaTipo, 
                         dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, dbo.ro_nomina_x_horas_extras.IdPeriodo, dbo.ro_nomina_x_horas_extras.IdCalendario, 
                         dbo.ro_nomina_x_horas_extras.IdTurno, dbo.ro_nomina_x_horas_extras.IdHorario, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, dbo.ro_nomina_x_horas_extras.FechaRegistro, dbo.ro_nomina_x_horas_extras.time_entrada1, 
                         dbo.ro_nomina_x_horas_extras.time_salida1, dbo.ro_nomina_x_horas_extras.time_entrada2, dbo.ro_nomina_x_horas_extras.time_salida2, 
                         dbo.ro_nomina_x_horas_extras.hora_trabajada, dbo.ro_nomina_x_horas_extras.hora_extra25, dbo.ro_nomina_x_horas_extras.hora_extra50, 
                         dbo.ro_nomina_x_horas_extras.hora_extra100
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_nomina_x_horas_extras ON dbo.ro_empleado.IdEmpresa = dbo.ro_nomina_x_horas_extras.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_nomina_x_horas_extras.IdEmpleado INNER JOIN
                         dbo.ro_periodo ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         dbo.ro_nomina_x_horas_extras.IdPeriodo = dbo.ro_periodo.IdPeriodo