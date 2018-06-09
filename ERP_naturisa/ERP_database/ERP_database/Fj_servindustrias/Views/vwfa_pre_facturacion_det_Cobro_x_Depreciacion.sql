CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_Cobro_x_Depreciacion
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.secuencia, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPunto_cargo, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa_dep, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdDepreciacion_dep, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdTarifario, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.secuencia_dep, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdActivoFijo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.concepto, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Total_depreciado_x_cobrar, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Costo_unitario, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Valor_salvamento, Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Facturar, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, dbo.Af_Activo_fijo.Af_Nombre, dbo.ct_punto_cargo.nom_punto_cargo, 
                         dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.Porc_ganancia, Fj_servindustrias.fa_pre_facturacion.IdPeriodo
FROM            dbo.ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON dbo.ct_centro_costo.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc AND 
                         dbo.ct_centro_costo.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona RIGHT OUTER JOIN
                         Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPreFacturacion ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentroCosto_sub_centro_costo
                          LEFT OUTER JOIN
                         dbo.Af_Activo_fijo INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
                         dbo.ct_punto_cargo ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = dbo.ct_punto_cargo.IdEmpresa AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = dbo.ct_punto_cargo.IdPunto_cargo ON 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC