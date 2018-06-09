CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_egr_x_bod
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.secuencia, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa_mov_inv, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdSucursal_mov_inv, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdBodega_mov_inv, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdMovi_inven_tipo_mov_inv, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdNumMovi_mov_inv, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Secuencia_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.observacion_det, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Costo_Uni, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Aplica_Iva, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Valor_Iva, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Total, 
                       [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].cm_fecha, [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].oc_NumDocumento, 
                       [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdProveedor, [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdProducto, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, dbo.ct_punto_cargo.nom_punto_cargo, dbo.in_Producto.pr_descripcion AS nom_Producto, 
                         tb_persona_1.pe_nombreCompleto AS nom_Proveedor, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdTarifario, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Porc_ganancia
FROM            dbo.ct_punto_cargo RIGHT OUTER JOIN
                         dbo.in_Producto INNER JOIN
                         dbo.tb_persona AS tb_persona_1 INNER JOIN
                         dbo.cp_proveedor ON tb_persona_1.IdPersona = dbo.cp_proveedor.IdPersona INNER JOIN
                         dbo.tb_persona INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto ON 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = dbo.ct_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente ON dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona INNER JOIN
                         [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item] INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod ON 
                         [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                        [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdPrefacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion AND 
                        [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].Secuencia = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.secuencia ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo ON
                          dbo.cp_proveedor.IdEmpresa = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr AND 
                         dbo.cp_proveedor.IdProveedor = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdProveedor ON 
                         dbo.in_Producto.IdEmpresa = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdEmpresa_egr AND 
                         dbo.in_Producto.IdProducto = [Fj_servindustrias].[in_movi_inve_detalle_egreso_x_item].IdProducto ON 
                         dbo.ct_punto_cargo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         dbo.ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo