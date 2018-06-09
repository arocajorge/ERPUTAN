CREATE VIEW [Fj_servindustrias].[vwFAC_FJ_Rpt006]
	AS
	
	SELECT        Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.observacion_det, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Costo_Uni, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Aplica_Iva, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Valor_Iva, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Total, 
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.cm_fecha, Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.oc_NumDocumento, 
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdProveedor, Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdProducto, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, ct_punto_cargo_1.nom_punto_cargo, dbo.in_Producto.pr_descripcion AS nom_Producto, 
                         tb_persona_1.pe_nombreCompleto AS nom_Proveedor, dbo.cp_orden_giro.co_serie, dbo.cp_orden_giro.co_factura, Fj_servindustrias.fa_pre_facturacion.IdPeriodo, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdNumMovi_mov_inv
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
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
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod ON 
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdEmpresa_egr = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdPrefacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion AND 
                         Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.Secuencia = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.secuencia ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo ON
                          dbo.cp_proveedor.IdEmpresa = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdEmpresa_egr AND 
                         dbo.cp_proveedor.IdProveedor = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdProveedor ON 
                         dbo.in_Producto.IdEmpresa = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdEmpresa_egr AND 
                         dbo.in_Producto.IdProducto = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdProducto ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion AND 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion AND 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion AND 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion INNER JOIN
                         dbo.cp_orden_giro_x_com_ordencompra_local_det ON 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdEmpresa_OC = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdEmpresa_Oc AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdSucursal_OC = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdSucursal_Oc AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdOrdenCompra = Fj_servindustrias.in_movi_inve_detalle_egreso_x_item.IdOrdenCompra_Oc INNER JOIN
                         dbo.cp_orden_giro ON dbo.cp_orden_giro_x_com_ordencompra_local_det.IdEmpresa_Ogiro = dbo.cp_orden_giro.IdEmpresa AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro AND 
                         dbo.cp_orden_giro_x_com_ordencompra_local_det.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro LEFT OUTER JOIN
                         dbo.ct_punto_cargo AS ct_punto_cargo_1 ON Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = ct_punto_cargo_1.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo = ct_punto_cargo_1.IdPunto_cargo