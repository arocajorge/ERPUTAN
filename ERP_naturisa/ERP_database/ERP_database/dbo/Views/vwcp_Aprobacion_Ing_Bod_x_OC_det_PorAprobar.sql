CREATE VIEW [dbo].[vwcp_Aprobacion_Ing_Bod_x_OC_det_PorAprobar]
AS
SELECT d.IdEmpresa, d.IdSucursal, d.IdMovi_inven_tipo, d.IdNumMovi, d.Secuencia, d.IdBodega, d.IdProducto, p.pr_descripcion, d.dm_cantidad_sinConversion, d.mv_costo_sinConversion, doc.do_porc_des, c.cm_fecha, p.IdCategoria, p.IdLinea, 
                  p.IdGrupo, p.IdSubGrupo, s.Su_Descripcion, b.bo_Descripcion, doc.IdSucursal AS IdSucursal_oc, doc.IdOrdenCompra, doc.Secuencia AS Secuencia_oc, d.IdCentroCosto, d.IdCentroCosto_sub_centro_costo, d.IdPunto_cargo, 
                  d.IdPunto_cargo_grupo, doc.Por_Iva, d.IdUnidadMedida_sinConversion, coc.IdProveedor, coc.oc_plazo, per.pe_nombreCompleto, mot.es_Inven_o_Consumo, 
                  CASE WHEN mot.es_Inven_o_Consumo = 'TIC_CONSU' THEN cc.IdCtaCble ELSE b.IdCtaCtble_Inve END AS IdCtaCble_Gasto, d.dm_cantidad_sinConversion * d.mv_costo_sinConversion AS Subtotal, 
                  (d.dm_cantidad_sinConversion * d.mv_costo_sinConversion) * (doc.Por_Iva / 100) AS ValorIVA, d.dm_cantidad_sinConversion * d.mv_costo_sinConversion + (d.dm_cantidad_sinConversion * d.mv_costo_sinConversion) * (doc.Por_Iva / 100) 
                  AS Total
FROM     dbo.in_Ing_Egr_Inven_det AS d INNER JOIN
                  dbo.in_Producto AS p ON d.IdEmpresa = p.IdEmpresa AND d.IdProducto = p.IdProducto INNER JOIN
                  dbo.com_ordencompra_local_det AS doc ON doc.IdEmpresa = d.IdEmpresa_oc AND doc.IdSucursal = d.IdSucursal_oc AND doc.IdOrdenCompra = d.IdOrdenCompra AND doc.Secuencia = d.Secuencia_oc INNER JOIN
                  dbo.in_Ing_Egr_Inven AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdMovi_inven_tipo = d.IdMovi_inven_tipo AND c.IdNumMovi = d.IdNumMovi INNER JOIN
                  dbo.tb_bodega AS b ON b.IdEmpresa = d.IdEmpresa AND b.IdSucursal = d.IdSucursal AND b.IdBodega = d.IdBodega INNER JOIN
                  dbo.tb_sucursal AS s ON s.IdEmpresa = b.IdEmpresa AND s.IdSucursal = b.IdSucursal INNER JOIN
                  dbo.com_ordencompra_local AS coc ON coc.IdEmpresa = doc.IdEmpresa AND coc.IdSucursal = doc.IdSucursal AND coc.IdOrdenCompra = doc.IdOrdenCompra INNER JOIN
                  dbo.cp_proveedor AS pro ON pro.IdEmpresa = coc.IdEmpresa AND pro.IdProveedor = coc.IdProveedor INNER JOIN
                  dbo.tb_persona AS per ON pro.IdPersona = per.IdPersona INNER JOIN
                  dbo.in_Motivo_Inven AS mot ON mot.IdEmpresa = c.IdEmpresa AND mot.IdMotivo_Inv = c.IdMotivo_Inv LEFT OUTER JOIN
                  dbo.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble AS cc ON cc.IdEmpresa = p.IdEmpresa AND cc.IdCategoria = p.IdCategoria AND cc.IdLinea = p.IdLinea AND cc.IdGrupo = p.IdGrupo AND cc.IdSubgrupo = p.IdSubGrupo AND 
                  d.IdCentroCosto = cc.IdCentroCosto AND d.IdCentroCosto_sub_centro_costo = cc.IdSub_centro_costo LEFT OUTER JOIN
                  dbo.cp_Aprobacion_Ing_Bod_x_OC_det AS apro ON apro.IdEmpresa_Ing_Egr_Inv = d.IdEmpresa AND apro.IdSucursal_Ing_Egr_Inv = d.IdSucursal AND apro.IdMovi_inven_tipo_Ing_Egr_Inv = d.IdMovi_inven_tipo AND 
                  apro.IdNumMovi_Ing_Egr_Inv = d.IdNumMovi AND apro.Secuencia_Ing_Egr_Inv = d.Secuencia 
				  where apro.IdAprobacion IS NULL