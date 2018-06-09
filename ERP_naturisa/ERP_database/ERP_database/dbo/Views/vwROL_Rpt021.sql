create view vwROL_Rpt021 as 
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.ro_empleado.IdEmpleado, dbo.ro_Departamento.IdDepartamento, 
                         dbo.ro_DiasFaltados_x_Empleado.IdFalta, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.ro_DiasFaltados_x_Empleado.DiasDescuento, dbo.ro_DiasFaltados_x_Empleado.FechaDescuentaRol, dbo.ro_Nomina_Tipo.Descripcion, 
                         dbo.ro_Departamento.de_descripcion
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_DiasFaltados_x_Empleado ON dbo.ro_empleado.IdEmpresa = dbo.ro_DiasFaltados_x_Empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_DiasFaltados_x_Empleado.IdEmpleado INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_empleado.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado AND 
                         dbo.ro_Nomina_Tipo.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_Nomina_Tipo.IdNomina_Tipo = dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina