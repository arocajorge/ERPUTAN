CREATE VIEW [dbo].[vwRo_Sueldo_Basico_x_Empleado_x_anio]
as
SELECT     a.IdEmpresa, a.IdEmpleado, B.IdNomina_Tipo, C.sb_anio, C.sb_valor
FROM         ro_Nomina_Tipo AS B INNER JOIN
                      ro_empleado AS a ON B.IdEmpresa = a.IdEmpresa CROSS JOIN
                      ro_Config_SueldoBasico_x_anio AS C