	CREATE  view Fj_servindustrias.vwaf_x_fuerza_x_Periodo_x_Empleado as 
	select Query1.*,querey2.* from 
	-- UNION DE EMPLEADO POR ACTIVO X PERIODO
	   (select A.*,B.IdFuerza from 
	   ( select MAX(idempleado)idempleado ,IdActivo_fijo,IdEmpresa,IdNomina_tipo, IdPeriodo
	   from Fj_servindustrias.ro_empleado_x_Activo_Fijo_Historico	   
	   group by IdEmpresa,IdNomina_tipo, IdPeriodo,IdActivo_fijo ) as A
	   inner join 
	   (select E.IdEmpresa, E.IdPeriodo,E.IdEmpleado, F.IdFuerza from Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det E, Fj_servindustrias.ro_fuerza F
	   where E.IdEmpresa=F.IdEmpresa
	   and E.IdFuerza=F.IdFuerza
	   ) as B
	   on 
	   B.IdEmpresa= A.IdEmpresa
	   and B.IdPeriodo=A.IdPeriodo
	   and B.IdEmpleado=A.idempleado
	   ) Query1
	   --( UNION DE EMPLEADO POR ACTIVO X PERIODO) X (UNION DE EMPLEADO POR PUNTODE CARGO)
	   inner join
	   (select IdActivoFijo_AF,IdPunto_cargo_PC,IdEmpresa_AF from Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo
	   ) as querey2
	   on 
	   Query1.IdEmpresa=querey2.IdEmpresa_AF
	   and Query1.IdActivo_fijo=querey2.IdActivoFijo_AF