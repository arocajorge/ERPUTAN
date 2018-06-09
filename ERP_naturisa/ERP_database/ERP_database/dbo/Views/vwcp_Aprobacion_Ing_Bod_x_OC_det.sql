CREATE VIEW [dbo].[vwcp_Aprobacion_Ing_Bod_x_OC_det]
AS
SELECT        dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdAprobacion, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Secuencia, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa_Ing_Egr_Inv, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdSucursal_Ing_Egr_Inv, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdNumMovi_Ing_Egr_Inv, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Secuencia_Ing_Egr_Inv, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Cantidad, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Costo_uni, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Descuento, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.SubTotal, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.PorIva, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.valor_Iva, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.Total, dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdCtaCble_Gasto, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdCtaCble_IVA, dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdCentro_Costo_x_Gasto_x_cxp, 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdCentroCosto_sub_centro_costo_cxp
						 ,dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdMovi_inven_tipo_Ing_Egr_Inv
FROM            dbo.cp_Aprobacion_Ing_Bod_x_OC_det INNER JOIN
                         dbo.tb_sucursal ON dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                         dbo.cp_Aprobacion_Ing_Bod_x_OC_det.IdSucursal_Ing_Egr_Inv = dbo.tb_sucursal.IdSucursal