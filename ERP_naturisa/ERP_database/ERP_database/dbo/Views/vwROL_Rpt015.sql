CREATE VIEW dbo.vwROL_Rpt015
AS
SELECT        dbo.tb_empresa.em_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpleado, dbo.ro_Asignacion_Implemento_x_Empleado.Observacion, 
                         dbo.ro_Asignacion_Implemento_x_Empleado_det.secuencia, dbo.ro_Asignacion_Implemento_x_Empleado_det.Detalle, 
                         dbo.ro_Asignacion_Implemento_x_Empleado_det.Vida_Util, dbo.ro_Asignacion_Implemento_x_Empleado_det.Cantidad, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdAsignacion_Impl, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_descripcion_2, dbo.in_Producto.pr_codigo, 
                         dbo.Af_Activo_fijo.Af_Nombre, dbo.ro_cargo.ca_descripcion, dbo.ro_Asignacion_Implemento_x_Empleado.Fecha_Entrega, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdNomina_Tipo, dbo.tb_persona.pe_cedulaRuc
FROM            dbo.ro_Asignacion_Implemento_x_Empleado INNER JOIN
                         dbo.tb_empresa ON dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.ro_Asignacion_Implemento_x_Empleado_det ON 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdAsignacion_Impl = dbo.ro_Asignacion_Implemento_x_Empleado_det.IdAsignacion_Impl AND 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa = dbo.ro_Asignacion_Implemento_x_Empleado_det.IdEmpresa INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_catalogo ON dbo.ro_Asignacion_Implemento_x_Empleado_det.Estado_implemnto = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.in_Producto ON dbo.ro_Asignacion_Implemento_x_Empleado_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.ro_Asignacion_Implemento_x_Empleado_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo ON 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa AND 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpleado = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado INNER JOIN
                         dbo.Af_Activo_fijo ON Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo