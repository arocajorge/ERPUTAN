create view [dbo].[vwRo_Rubro_x_Empleado_x_nomina_x_TipoLiqui]
as
SELECT     A.IdEmpresa, A.IdNomina_Tipo, A.Descripcion, B.IdNomina_TipoLiqui, B.DescripcionProcesoNomina, C.IdRubro, D.rub_codigo, D.ru_descripcion
FROM         ro_Nomina_Tipo AS A INNER JOIN
                      ro_Nomina_Tipoliqui AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdNomina_Tipo = B.IdNomina_Tipo INNER JOIN
                      ro_Config_Rubros_x_empleado AS C ON B.IdEmpresa = C.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS D ON C.IdRubro = D.IdRubro
--ORDER BY A.IdNomina_Tipo, B.IdNomina_TipoLiqui, C.OrdenPres