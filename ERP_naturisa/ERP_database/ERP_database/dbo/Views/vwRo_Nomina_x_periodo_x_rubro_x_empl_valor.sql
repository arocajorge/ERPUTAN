CREATE view [dbo].[vwRo_Nomina_x_periodo_x_rubro_x_empl_valor] as
SELECT      dbo.ro_Ing_Egre_x_Empleado.IdEmpresa, dbo.ro_Ing_Egre_x_Empleado.IdNomina_Tipo, dbo.ro_Ing_Egre_x_Empleado.IdNomina_TipoLiqui, 
                      dbo.ro_Ing_Egre_x_Empleado.IdPeriodo, dbo.ro_Ing_Egre_x_Empleado.IdRubro, dbo.ro_Ing_Egre_x_Empleado.IdEmpleado, dbo.ro_empleado.IdDivision, 
                      dbo.ro_Ing_Egre_x_Empleado.Valor
FROM         dbo.ro_Ing_Egre_x_Empleado INNER JOIN
                      dbo.ro_empleado ON dbo.ro_Ing_Egre_x_Empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                      dbo.ro_Ing_Egre_x_Empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado

union 

SELECT     A.IdEmpresa, A.IdNomina_Tipo, B.IdNomina_TipoLiqui, C.IdPeriodo, E.IdRubro, D.IdEmpleado, D.IdDivision, 0 AS valor
FROM         ro_Nomina_Tipo AS A INNER JOIN
                      ro_Nomina_Tipoliqui AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdNomina_Tipo = B.IdNomina_Tipo INNER JOIN
                      ro_periodo AS C ON A.IdEmpresa = C.IdEmpresa INNER JOIN
                      ro_empleado AS D ON A.IdEmpresa = D.IdEmpresa CROSS JOIN
                      ro_rubro_tipo AS E
where	cast(A.IdEmpresa as varchar(20))	+ cast(A.IdNomina_Tipo as varchar(20)) + cast(B.IdNomina_TipoLiqui as varchar(20)) 
		+ cast(C.IdPeriodo as varchar(20)) + cast(E.IdRubro as varchar(20)) + cast(D.IdEmpleado as varchar(20))
not in 
(
	select 
		CAST(IdEmpresa   as varchar(20)) + cast(IdNomina_Tipo as varchar(20)) + cast(IdNomina_TipoLiqui  as varchar(20)) 
	+cast(IdPeriodo		as varchar(20)) + cast(IdRubro	as varchar(20)) + cast(IdEmpleado as varchar(20))
	from ro_Ing_Egre_x_Empleado 
)