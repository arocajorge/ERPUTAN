
creATE VIEW [dbo].[vwROL_Rpt013] AS 
select IdEmpresa, IdEmpleado,  pe_nombreCompleto, pe_apellido, pe_nombre, pe_cedulaRuc ,sum(ingreso) as Ingreso,pe_mes,pe_anio,pe_FechaIni, pe_FechaFin
from vwRo_Liquidacion_Vacaciones 
where ingreso>0
group by IdEmpresa,pe_anio,pe_mes,IdEmpleado,pe_nombreCompleto, pe_apellido, pe_nombre, pe_cedulaRuc,pe_FechaIni, pe_FechaFin