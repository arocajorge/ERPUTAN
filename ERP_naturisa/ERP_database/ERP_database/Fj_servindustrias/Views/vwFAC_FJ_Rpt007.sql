CREATE VIEW [Fj_servindustrias].[vwFAC_FJ_Rpt007]
	AS 

	SELECT        Fj_servindustrias.fa_pre_facturacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo, dbo.ro_empleado.IdEmpleado, dbo.ro_cargo.IdCargo, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ro_cargo.ca_descripcion,
                             (SELECT        Valor
                               FROM            dbo.ro_rol_detalle
                               WHERE        (IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa) AND 
                                                         (Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo)
                                                          AND (dbo.ro_empleado.IdEmpleado = IdEmpleado) AND (Fj_servindustrias.fa_pre_facturacion.IdPeriodo = IdPeriodo) AND (IdRubro = 103)) 
                         AS SALARIO,
                             (SELECT        Valor
                               FROM            dbo.ro_rol_detalle AS ro_rol_detalle_2
                               WHERE        (IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa) AND 
                                                         (Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo)
                                                          AND (dbo.ro_empleado.IdEmpleado = IdEmpleado) AND (Fj_servindustrias.fa_pre_facturacion.IdPeriodo = IdPeriodo) AND (IdRubro = 966)) 
                         AS [H.EXTRAS],
                             (SELECT        Valor
                               FROM            dbo.ro_rol_detalle AS ro_rol_detalle_1
                               WHERE        (IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa) AND 
                                                         (Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdNomina_Tipo)
                                                          AND (dbo.ro_empleado.IdEmpleado = IdEmpleado) AND (Fj_servindustrias.fa_pre_facturacion.IdPeriodo = IdPeriodo) AND (IdRubro = 74)) 
                         AS ALIMENTACION, dbo.ct_centro_costo_sub_centro_costo.Centro_costo, dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo, 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.Idempresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdPreFacturacion INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.Idempresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.Idempresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdCentro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra.IdSubCentroCosoto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo