CREATE view [dbo].[vwRO_empleado_x_Perido_Nomina] as 
SELECT        dbo.ro_rol_individual.IdEmpresa, dbo.ro_rol_individual.IdNominaTipo, dbo.ro_rol_individual.IdNominaTipoLiqui, dbo.ro_rol_individual.IdPeriodo, 
                         dbo.ro_rol_individual.IdEmpleado, dbo.ro_empleado.IdDepartamento, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre
FROM            dbo.ro_rol_individual INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_individual.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_rol_individual.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
GROUP BY dbo.ro_rol_individual.IdEmpresa, dbo.ro_rol_individual.IdNominaTipo, dbo.ro_rol_individual.IdNominaTipoLiqui, dbo.ro_rol_individual.IdPeriodo, 
                         dbo.ro_rol_individual.IdEmpleado, dbo.ro_empleado.IdDepartamento, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre