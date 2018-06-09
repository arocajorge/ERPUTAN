CREATE view vwRo_Conf_Rubros_Acumulados as 

SELECT        dbo.ro_Config_Rubros_Acumulado.IdEmpresa, dbo.ro_Config_Rubros_Acumulado.IdRubro, dbo.ro_rubro_tipo.ru_descripcion AS Descripcion, 
                         dbo.ro_Config_Rubros_Acumulado.Configurable, dbo.ro_empleado_x_rubro_acumulado.Fec_Inicio_Acumulacion, 
                         dbo.ro_empleado_x_rubro_acumulado.Fec_Fin_Acumulacion, dbo.ro_empleado_x_rubro_acumulado.IdEmpleado, dbo.ro_Config_Rubros_Acumulado.FechaInicio, 
                         dbo.ro_Config_Rubros_Acumulado.FechaFin
FROM            dbo.ro_Config_Rubros_Acumulado INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_Config_Rubros_Acumulado.IdRubro = dbo.ro_rubro_tipo.IdRubro AND 
                         dbo.ro_Config_Rubros_Acumulado.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa INNER JOIN
                         dbo.ro_empleado_x_rubro_acumulado ON dbo.ro_Config_Rubros_Acumulado.IdEmpresa = dbo.ro_empleado_x_rubro_acumulado.IdEmpresa AND 
                         dbo.ro_Config_Rubros_Acumulado.IdRubro = dbo.ro_empleado_x_rubro_acumulado.IdRubro