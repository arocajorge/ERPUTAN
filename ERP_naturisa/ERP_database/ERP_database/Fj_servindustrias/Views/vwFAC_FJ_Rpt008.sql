CREATE VIEW Fj_servindustrias.[vwFAC_FJ_Rpt008]
	AS 
	SELECT        Emp.IdEmpresa, Emp.IdEmpleado, R_Det.IdPeriodo, Pers.pe_cedulaRuc, Pers.pe_apellido + ' ' + Pers.pe_nombre AS Nombres, dbo.ro_cargo.ca_descripcion, 
                         zona.zo_descripcion, Rub.ru_descripcion, R_Det.Valor, R_Det.rub_visible_reporte, dbo.ct_periodo.IdanioFiscal, dbo.ct_periodo.pe_mes, dbo.ct_periodo.pe_FechaIni, 
                         dbo.ct_periodo.pe_FechaFin, Emp.em_fecha_ingreso, Emp.em_fechaSalida, dbo.ro_Departamento.de_descripcion, Sul_Hist.SueldoActual, 
                         Rub.rub_mustra_liquidacion_cliente, Fj_servindustrias.ro_parametros_reporte.Descripcion, Fj_servindustrias.ro_parametros_reporte.Orden
FROM            dbo.ro_Departamento INNER JOIN
                         dbo.ro_rubro_tipo AS Rub INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS Planif_x_rut_det INNER JOIN
                         Fj_servindustrias.ro_zona AS zona ON Planif_x_rut_det.IdEmpresa = zona.IdEmpresa AND Planif_x_rut_det.IdZona = zona.IdZona INNER JOIN
                         dbo.tb_persona AS Pers INNER JOIN
                         dbo.ro_empleado AS Emp ON Pers.IdPersona = Emp.IdPersona INNER JOIN
                         dbo.ro_cargo ON Emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND Emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_empleado_historial_Sueldo AS Sul_Hist ON Emp.IdEmpresa = Sul_Hist.IdEmpresa AND Emp.IdEmpleado = Sul_Hist.IdEmpleado INNER JOIN
                         dbo.ro_rol_detalle AS R_Det ON Emp.IdEmpresa = R_Det.IdEmpresa AND Emp.IdEmpleado = R_Det.IdEmpleado INNER JOIN
                         dbo.ro_rol ON R_Det.IdEmpresa = dbo.ro_rol.IdEmpresa AND R_Det.IdNominaTipo = dbo.ro_rol.IdNominaTipo AND 
                         R_Det.IdNominaTipoLiqui = dbo.ro_rol.IdNominaTipoLiqui AND R_Det.IdPeriodo = dbo.ro_rol.IdPeriodo ON Planif_x_rut_det.IdEmpresa = Emp.IdEmpresa AND 
                         Planif_x_rut_det.IdEmpleado = Emp.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado AS Planif_x_rut ON Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo AND Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo AND Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo AND Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo AND Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo AND Planif_x_rut_det.IdEmpresa = Planif_x_rut.IdEmpresa AND 
                         Planif_x_rut_det.IdNomina_Tipo = Planif_x_rut.IdNomina_Tipo AND Planif_x_rut_det.IdNomina_Tipo_Liq = Planif_x_rut.IdNomina_tipo_Liq AND 
                         Planif_x_rut_det.IdPeriodo = Planif_x_rut.IdPeriodo ON Rub.IdRubro = R_Det.IdRubro ON dbo.ro_Departamento.IdEmpresa = Emp.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = Emp.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = Emp.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = Emp.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = Emp.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = Emp.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = Emp.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = Emp.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = Emp.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = Emp.IdDepartamento INNER JOIN
                         Fj_servindustrias.ro_parametros_reporte ON R_Det.IdEmpresa = Fj_servindustrias.ro_parametros_reporte.IdEmpresa AND 
                         R_Det.IdNominaTipo = Fj_servindustrias.ro_parametros_reporte.IdNomina_Tipo AND 
                         R_Det.IdNominaTipoLiqui = Fj_servindustrias.ro_parametros_reporte.IdNomina_tipo_Liq AND 
                         R_Det.IdRubro = Fj_servindustrias.ro_parametros_reporte.IdRubro LEFT OUTER JOIN
                         dbo.ct_periodo INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra AS Pre_fa_det INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion AS Pre_fa ON Pre_fa_det.Idempresa = Pre_fa.IdEmpresa AND Pre_fa_det.IdPreFacturacion = Pre_fa.IdPreFacturacion ON 
                         dbo.ct_periodo.IdEmpresa = Pre_fa.IdEmpresa AND dbo.ct_periodo.IdPeriodo = Pre_fa.IdPeriodo ON Planif_x_rut_det.IdEmpresa = Pre_fa.IdEmpresa AND 
                         Planif_x_rut_det.IdPeriodo = Pre_fa.IdPeriodo
WHERE        (Rub.rub_mustra_liquidacion_cliente = 1)