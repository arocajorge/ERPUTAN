CREATE VIEW [dbo].[vwcp_orden_giro_consulta]
AS
SELECT dbo.cp_orden_giro.IdEmpresa, dbo.cp_orden_giro.IdTipoCbte_Ogiro, dbo.cp_orden_giro.IdCbteCble_Ogiro, dbo.cp_orden_giro.IdProveedor, dbo.tb_persona.pe_nombreCompleto, dbo.cp_orden_giro.co_fechaOg, 
                  dbo.cp_orden_giro.co_factura, dbo.cp_orden_giro.co_FechaFactura, dbo.cp_orden_giro.co_observacion, dbo.cp_orden_giro.co_total, dbo.cp_orden_giro.IdTipoFlujo, ret.NumRetencion, dbo.cp_orden_giro.co_subtotal_iva, 
                  dbo.cp_orden_giro.co_subtotal_siniva, dbo.cp_orden_giro.co_baseImponible, dbo.cp_orden_giro.co_valoriva, ISNULL(ret.re_valor_retencion, 0) AS re_valor_retencion, ISNULL(canc.MontoAplicado, 0) AS MontoAplicado, 
                  ROUND(dbo.cp_orden_giro.co_total - ISNULL(ret.re_valor_retencion, 0) - ISNULL(canc.MontoAplicado, 0),2) AS saldo, dbo.cp_proveedor.IdClaseProveedor, dbo.cp_proveedor_clase.descripcion_clas_prove, 
                  dbo.cp_orden_giro.Estado
FROM     dbo.cp_orden_giro INNER JOIN
                  dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor LEFT OUTER JOIN
                      (SELECT cab.IdEmpresa_Ogiro, cab.IdTipoCbte_Ogiro, cab.IdCbteCble_Ogiro, cab.NumRetencion, SUM(det.re_valor_retencion) AS re_valor_retencion
                       FROM      dbo.cp_retencion AS cab INNER JOIN
                                         dbo.cp_retencion_det AS det ON cab.IdEmpresa = det.IdEmpresa AND cab.IdRetencion = det.IdRetencion
                       GROUP BY cab.IdEmpresa_Ogiro, cab.IdTipoCbte_Ogiro, cab.IdCbteCble_Ogiro, cab.NumRetencion) AS ret ON ret.IdEmpresa_Ogiro = dbo.cp_orden_giro.IdEmpresa AND 
                  ret.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro AND ret.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro LEFT OUTER JOIN
                      (SELECT IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, SUM(MontoAplicado) AS MontoAplicado
                       FROM      dbo.cp_orden_pago_cancelaciones AS f
                       GROUP BY IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp) AS canc ON canc.IdEmpresa_cxp = dbo.cp_orden_giro.IdEmpresa AND canc.IdTipoCbte_cxp = dbo.cp_orden_giro.IdTipoCbte_Ogiro AND 
                  canc.IdCbteCble_cxp = dbo.cp_orden_giro.IdCbteCble_Ogiro