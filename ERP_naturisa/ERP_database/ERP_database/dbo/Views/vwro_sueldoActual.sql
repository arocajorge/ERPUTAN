create view vwro_sueldoActual as
select IdEmpresa,IdEmpleado ,MAX( SueldoActual)SueldoActual from ro_empleado_historial_Sueldo
group by
IdEmpresa,IdEmpleado