CREATE VIEW Fj_servindustrias.vwro_planificacion_x_ruta_entrega_x_empleado
AS
SELECT        dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.ro_periodo.IdPeriodo, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ro_Departamento.de_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc, Fj_servindustrias.ro_ruta.ru_descripcion, 
                         Fj_servindustrias.ro_Grupo_empleado.IdGrupo
FROM            dbo.ro_Departamento INNER JOIN
                         dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona ON dbo.ro_Departamento.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = dbo.ro_empleado.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = dbo.ro_empleado.IdDepartamento AND dbo.ro_Departamento.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Departamento.IdDepartamento = dbo.ro_empleado.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo LEFT OUTER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa LEFT OUTER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina LEFT OUTER JOIN
                         Fj_servindustrias.ro_ruta INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdNomina_Tipo = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdNomina_Tipo AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdPeriodo INNER JOIN
                         dbo.ro_periodo ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado.IdPeriodo = dbo.ro_periodo.IdPeriodo ON Fj_servindustrias.ro_ruta.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND
                          Fj_servindustrias.ro_ruta.IdRuta = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta ON 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdNomina_Tipo ON 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado