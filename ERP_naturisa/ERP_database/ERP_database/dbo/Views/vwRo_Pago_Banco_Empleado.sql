CREATE view [dbo].[vwRo_Pago_Banco_Empleado]
as
select a.IdEmpresa,a.IdEmpleado,a.IdNomina_Tipo,a.IdNomina_TipoLiqui,a.IdPeriodo,a.neto_pagar,b.pe_cedulaRuc,b.pe_nombreCompleto from 
(select IdEmpresa,IdEmpleado,IdNomina_Tipo,IdNomina_TipoLiqui,idperiodo,SUM(Valor)as neto_pagar from ro_ing_egre_X_empleado 
group by IdEmpresa,IdEmpleado,IdNomina_Tipo,IdNomina_TipoLiqui,idperiodo)a
inner join
(select IdEmpresa,IdEmpleado,pe_nombreCompleto,pe_cedulaRuc from vwro_empleado)b
on a.IdEmpleado=b.IdEmpleado and a.IdEmpresa=b.IdEmpresa
where a.neto_pagar >0