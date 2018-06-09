CREATE view [Fj_servindustrias].[vwro_ro_empleado_x_Activo_Fijo_Historico] as 
SELECT        Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.IdEmpresa, Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.IdActivo_fijo, Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.IdEmpleado, 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.Fecha_Asignacion, Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.Fecha_Hasta, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_Departamento.de_descripcion, dbo.ro_area.Descripcion
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_area ON dbo.ro_empleado.IdEmpresa = dbo.ro_area.IdEmpresa AND dbo.ro_empleado.IdDivision = dbo.ro_area.IdDivision AND dbo.ro_empleado.IdArea = dbo.ro_area.IdArea INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico.IdEmpleado