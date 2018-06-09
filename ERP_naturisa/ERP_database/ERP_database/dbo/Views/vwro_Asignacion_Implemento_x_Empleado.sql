create VIEW [dbo].[vwro_Asignacion_Implemento_x_Empleado]
AS
SELECT        dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa, dbo.ro_Asignacion_Implemento_x_Empleado.IdAsignacion_Impl, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.Tipo_Movimiento, dbo.ro_Asignacion_Implemento_x_Empleado.Fecha_Entrega, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpleado, dbo.ro_Asignacion_Implemento_x_Empleado.Observacion, 
                         dbo.ro_Asignacion_Implemento_x_Empleado.Estado, dbo.ro_Asignacion_Implemento_x_Empleado.Fecha_Transac, dbo.tb_persona.pe_nombreCompleto
FROM            dbo.ro_Asignacion_Implemento_x_Empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Asignacion_Implemento_x_Empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona