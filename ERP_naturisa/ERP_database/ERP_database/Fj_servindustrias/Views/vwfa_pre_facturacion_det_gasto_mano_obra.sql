create view Fj_servindustrias.vwfa_pre_facturacion_det_gasto_mano_obra as 
SELECT					 Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo, dbo.ro_empleado.IdEmpleado, dbo.ro_cargo.IdCargo, 
                         dbo.ro_empleado_x_centro_costo.IdCentroCosto, dbo.ro_empleado_x_centro_costo.IdCentroCosto_sub_centro_costo, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ro_cargo.ca_descripcion,
						 (select Valor from ro_rol_detalle where Idempresa=Fj_servindustrias.fa_pre_facturacion.IdEmpresa
						 and Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo=IdNomina_Tipo
						 and dbo.ro_empleado.IdEmpleado=IdEmpleado
						 and  Fj_servindustrias.fa_pre_facturacion.IdPeriodo=IdPeriodo and IdRubro=103 ) as SALARIO,
						 (select Valor from ro_rol_detalle where Idempresa=Fj_servindustrias.fa_pre_facturacion.IdEmpresa
						 and Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo=IdNomina_Tipo
						 and dbo.ro_empleado.IdEmpleado=IdEmpleado
						 and  Fj_servindustrias.fa_pre_facturacion.IdPeriodo=IdPeriodo and IdRubro=966 ) as [H.EXTRAS],
						 (select Valor from ro_rol_detalle where Idempresa=Fj_servindustrias.fa_pre_facturacion.IdEmpresa
						 and Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo=IdNomina_Tipo
						 and dbo.ro_empleado.IdEmpleado=IdEmpleado
						 and  Fj_servindustrias.fa_pre_facturacion.IdPeriodo=IdPeriodo and IdRubro=74 ) as ALIMENTACION

						

FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.Idempresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdPreFacturacion INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.Idempresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_empleado_x_centro_costo ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND
                          dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado