CREATE VIEW [Fj_servindustrias].[vwro_ro_fectividad_Entrega_x_planificacion_x_ruta_x_empleado]
AS
SELECT        Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdPeriodo, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdRuta, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEfectividad, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega_aplica, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen_aplica, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera_aplica
FROM            Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdNomina_Tipo AND
                          Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdPeriodo = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado