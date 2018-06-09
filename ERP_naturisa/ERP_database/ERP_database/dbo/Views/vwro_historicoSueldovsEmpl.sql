CREATE view [dbo].[vwro_historicoSueldovsEmpl]  
as  
SELECT     dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc,   
                      dbo.ro_empleado_historial_Sueldo.Secuencia, dbo.ro_empleado_historial_Sueldo.SueldoAnterior, dbo.ro_empleado_historial_Sueldo.SueldoActual,   
                      dbo.ro_empleado_historial_Sueldo.PorIncrementoSueldo, dbo.ro_empleado_historial_Sueldo.ValorIncrementoSueldo, dbo.ro_empleado_historial_Sueldo.Motivo,   
                      dbo.ro_empleado_historial_Sueldo.Fecha,ISNULL( dbo.ro_empleado_historial_Sueldo.de_descripcion,'') as de_descripcion, dbo.ro_empleado_historial_Sueldo.ca_descripcion,   
                      dbo.ro_empleado_historial_Sueldo.IdEmpresa, dbo.ro_empleado_historial_Sueldo.IdEmpleado  
FROM         dbo.ro_empleado INNER JOIN  
                      dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN  
                      dbo.ro_empleado_historial_Sueldo ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_historial_Sueldo.IdEmpresa AND   
                      dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_historial_Sueldo.IdEmpleado