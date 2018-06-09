CREATE view [dbo].[vwRo_Nomina_x_Liqui_x_Rubro_x_Empleado] as
SELECT     A.IdEmpresa, A.IdNomina_Tipo, A.Descripcion, A.IdNomina_TipoLiqui, A.DescripcionProcesoNomina, A.IdRubro, A.rub_codigo, A.ru_descripcion, B.IdEmpleado
,0 as Valor
FROM         vwRo_Rubro_x_Empleado_x_nomina_x_TipoLiqui AS A INNER JOIN
                  ro_empleado AS B ON A.IdEmpresa = B.IdEmpresa
where                   
cast(A.IdEmpresa as varchar(20))+cast(A.IdNomina_Tipo as varchar(20))+cast(A.IdNomina_TipoLiqui as varchar(20))
+cast(A.IdRubro as varchar(20))+cast(B.IdEmpleado as varchar(20))
not in(                  
		select 
		cast(IdEmpresa as varchar(20))+cast(IdNomina_Tipo as varchar(20))+cast(IdNomina_TipoLiqui as varchar(20))
		+cast(IdRubro as varchar(20))+cast(IdEmpleado as varchar(20))
		from dbo.ro_empleado_x_ro_rubro                      
		)
union 

SELECT     A.IdEmpresa, A.IdNomina_Tipo, A.Descripcion, B.IdNomina_TipoLiqui, B.DescripcionProcesoNomina, E.IdRubro, E.rub_codigo, E.ru_descripcion, D.IdEmpleado, 
                      C.Valor
FROM         ro_Nomina_Tipoliqui AS B INNER JOIN
                      ro_Nomina_Tipo AS A ON B.IdEmpresa = A.IdEmpresa AND B.IdNomina_Tipo = A.IdNomina_Tipo INNER JOIN
                      ro_empleado_x_ro_rubro AS C ON B.IdEmpresa = C.IdEmpresa AND B.IdNomina_Tipo = C.IdNomina_Tipo AND 
                      B.IdNomina_TipoLiqui = C.IdNomina_TipoLiqui INNER JOIN
                      ro_rubro_tipo AS E ON C.IdRubro = E.IdRubro INNER JOIN
                      ro_empleado AS D ON C.IdEmpresa = D.IdEmpresa AND C.IdEmpleado = D.IdEmpleado