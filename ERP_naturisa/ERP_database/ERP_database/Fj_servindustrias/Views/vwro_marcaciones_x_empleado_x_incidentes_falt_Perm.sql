CREATE view Fj_servindustrias.vwro_marcaciones_x_empleado_x_incidentes_falt_Perm as 
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.tb_persona.IdPersona, dbo.ro_cargo.IdCargo, dbo.ro_Departamento.IdDepartamento, 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdRegistro, 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat, dbo.ro_marcaciones_x_empleado.IdTipoMarcaciones, 
                         dbo.ro_marcaciones_x_empleado.es_Hora, dbo.ro_marcaciones_x_empleado.es_fechaRegistro, dbo.ro_marcaciones_x_empleado.es_anio, 
                         dbo.ro_marcaciones_x_empleado.es_mes, dbo.ro_marcaciones_x_empleado.es_semana, dbo.ro_marcaciones_x_empleado.es_dia, 
                         dbo.ro_marcaciones_x_empleado.es_sdia, dbo.ro_marcaciones_x_empleado.es_idDia, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion
FROM            dbo.ro_empleado INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm ON 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpleado INNER JOIN
                         dbo.ro_marcaciones_x_empleado ON 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa = dbo.ro_marcaciones_x_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdRegistro = dbo.ro_marcaciones_x_empleado.IdRegistro INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo