CREATE VIEW dbo.vwin_movi_inve_detalle_x_item_egresos
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa AS IdEmpresa_prefact, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.secuencia AS sec_prefact, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa_mov_inv AS IdEmpresa_mov_inv_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdSucursal_mov_inv AS IdSucursal_mov_inv_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdBodega_mov_inv AS IdBodega_mov_inv_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdMovi_inven_tipo_mov_inv AS IdMovi_inven_tipo_mov_inv_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdNumMovi_mov_inv AS IdNumMovi_mov_inv_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Secuencia_det AS Secuencia_det_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.observacion_det AS observacion_det_egr, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Cantidad AS Cantidad_prefact, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Costo_Uni, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Subtotal, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Aplica_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Por_Iva, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Valor_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Total, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo, 
                         dbo.in_movi_inve_detalle_x_item.codigo_reg, dbo.in_Ing_Egr_Inven_det.IdProducto, dbo.in_Ing_Egr_Inven_det.dm_cantidad, dbo.in_Ing_Egr_Inven_det.dm_precio, 
                         dbo.in_movi_inve_detalle_x_item.cantidad AS cant_item_egr, dbo.in_Ing_Egr_Inven.cm_fecha, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Facturar, 
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdTarifario, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Porc_ganancia
FROM            dbo.in_Ing_Egr_Inven_det INNER JOIN
                         dbo.in_movi_inve_detalle ON dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv = dbo.in_movi_inve_detalle.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven_det.IdSucursal_inv = dbo.in_movi_inve_detalle.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdBodega_inv = dbo.in_movi_inve_detalle.IdBodega AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                         dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv = dbo.in_movi_inve_detalle.IdNumMovi AND 
                         dbo.in_Ing_Egr_Inven_det.secuencia_inv = dbo.in_movi_inve_detalle.Secuencia INNER JOIN
                         dbo.in_movi_inve_detalle_x_item ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve_detalle_x_item.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve_detalle_x_item.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve_detalle_x_item.IdBodega AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve_detalle_x_item.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve_detalle_x_item.IdNumMovi AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_movi_inve_detalle_x_item.Secuencia INNER JOIN
                         dbo.in_Ing_Egr_Inven ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Ing_Egr_Inven.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.in_Ing_Egr_Inven.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo AND 
                         dbo.in_Ing_Egr_Inven_det.IdNumMovi = dbo.in_Ing_Egr_Inven.IdNumMovi INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod ON 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa_mov_inv AND 
                         dbo.in_Ing_Egr_Inven_det.IdSucursal = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdSucursal_mov_inv AND 
                         dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdMovi_inven_tipo_mov_inv AND 
                         dbo.in_Ing_Egr_Inven_det.IdNumMovi = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdNumMovi_mov_inv AND 
                         dbo.in_Ing_Egr_Inven_det.Secuencia = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Secuencia_det AND 
                         dbo.in_Ing_Egr_Inven_det.IdBodega = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdBodega_mov_inv