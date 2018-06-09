CREATE VIEW [dbo].[vwRo_Conf_Rubros_Empleado]
as
select tb_a.IdEmpresa, tb_a.IdRubro, 
		tb_a.Estado_RConf, tb_a.OrdenPres, tb_a.ru_descripcion,
		tb_a.NombreCorto, tb_a.ru_tipo, dbo.ro_empleado.IdEmpleado,
		( select isnull(dbo.ro_empleado_x_ro_rubro.Valor,0) valor 
		from  dbo.ro_empleado_x_ro_rubro where 
		dbo.ro_empleado_x_ro_rubro.IdEmpresa = tb_a.IdEmpresa and dbo.ro_empleado_x_ro_rubro.IdEmpleado = dbo.ro_empleado.IdEmpleado
		and dbo.ro_empleado_x_ro_rubro.IdRubro = tb_a.IdRubro) valor,
		( select isnull(dbo.ro_empleado_x_ro_rubro.IdEmpleado, 0) secuencia from  dbo.ro_empleado_x_ro_rubro where 
		dbo.ro_empleado_x_ro_rubro.IdEmpresa = tb_a.IdEmpresa and dbo.ro_empleado_x_ro_rubro.IdEmpleado = dbo.ro_empleado.IdEmpleado
		and dbo.ro_empleado_x_ro_rubro.IdRubro = tb_a.IdRubro) secuencia
		from 
		(SELECT     dbo.ro_Config_Rubros_x_empleado.IdEmpresa, dbo.ro_Config_Rubros_x_empleado.IdRubro, dbo.ro_Config_Rubros_x_empleado.Estado AS Estado_RConf, 
                      dbo.ro_Config_Rubros_x_empleado.OrdenPres, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_rubro_tipo.NombreCorto, dbo.ro_rubro_tipo.ru_tipo
FROM         dbo.ro_Config_Rubros_x_empleado INNER JOIN
                      dbo.ro_rubro_tipo ON dbo.ro_Config_Rubros_x_empleado.IdRubro = dbo.ro_rubro_tipo.IdRubro) tb_a left join
                      dbo.ro_empleado on tb_a.IdEmpresa = dbo.ro_empleado.IdEmpresa