CREATE view vwROL_Rpt014 as
SELECT        dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, 
                         dbo.ro_Departamento.IdDepartamento, dbo.ro_Departamento.de_descripcion, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre,						 						 
						   (SELECT  D.RUBRO FROM  dbo.vwro_rubros_acumulados_x_empleados AS D
                            WHERE( D.Idempleado=dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado) and D.idrubro=289) AS Decimo_Cuarto,
							(SELECT  D.RUBRO FROM  dbo.vwro_rubros_acumulados_x_empleados AS D
                            WHERE( D.Idempleado=dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado) and D.idrubro=290) AS Decimo_Tercero,
							(SELECT  D.RUBRO FROM  dbo.vwro_rubros_acumulados_x_empleados AS D
                             WHERE( D.Idempleado=dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado) and D.idrubro=296) AS Fondos_Reservas


FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento