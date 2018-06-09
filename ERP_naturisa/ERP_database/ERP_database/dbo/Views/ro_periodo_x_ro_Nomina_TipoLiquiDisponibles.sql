create view [dbo].[ro_periodo_x_ro_Nomina_TipoLiquiDisponibles] as 
SELECT  * 
from ro_periodo ro
where  IdPeriodo NOT in (select Idperiodo from ro_periodo_x_ro_Nomina_TipoLiqui where IdEmpresa=ro.IdEmpresa)