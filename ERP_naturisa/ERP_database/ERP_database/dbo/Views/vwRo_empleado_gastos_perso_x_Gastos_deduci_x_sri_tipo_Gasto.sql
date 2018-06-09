create view [dbo].[vwRo_empleado_gastos_perso_x_Gastos_deduci_x_sri_tipo_Gasto]
as
select A.IdEmpresa,A.IdEmpleado,A.Anio_fiscal,A.Secuencia,A.Ruc,A.Num_CbteVta,A.Base_Imponible,A.IdTipoGastos,
B.Descripcion
from ro_empleado_gastos_perso_x_Gastos_deduci A
inner join sri_tipo_Gasto B on A.IdTipoGastos = B.IdTipoGasto