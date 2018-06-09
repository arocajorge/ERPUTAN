CREATE VIEW Fj_servindustrias.vwro_empleado_x_rutas_asignadas_Det
AS
SELECT        Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpresa, Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpleado, Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdRuta, 
                         Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.secuencia, Fj_servindustrias.ro_ruta.ru_descripcion
FROM            Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det INNER JOIN
                         Fj_servindustrias.ro_ruta ON Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta