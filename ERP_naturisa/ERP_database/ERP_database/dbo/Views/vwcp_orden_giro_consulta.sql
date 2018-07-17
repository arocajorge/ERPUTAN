CREATE VIEW vwcp_orden_giro_consulta
AS
SELECT cp_orden_giro.IdEmpresa, cp_orden_giro.IdTipoCbte_Ogiro, cp_orden_giro.IdCbteCble_Ogiro, cp_orden_giro.IdProveedor, tb_persona.pe_nombreCompleto, cp_orden_giro.co_fechaOg, cp_orden_giro.co_factura, 
                  cp_orden_giro.co_FechaFactura, cp_orden_giro.co_observacion, cp_orden_giro.co_total, cp_orden_giro.IdTipoFlujo, ret.NumRetencion, cp_orden_giro.co_subtotal_iva, cp_orden_giro.co_subtotal_siniva, cp_orden_giro.co_baseImponible, 
                  cp_orden_giro.co_valoriva, ISNULL(ret.re_valor_retencion, 0) AS re_valor_retencion, ISNULL(canc.MontoAplicado, 0) AS MontoAplicado, ROUND(cp_orden_giro.co_total - ISNULL(ret.re_valor_retencion, 0) - ISNULL(canc.MontoAplicado, 0), 
                  2) AS saldo, cp_proveedor.IdClaseProveedor, cp_proveedor_clase.descripcion_clas_prove, cp_orden_giro.Estado
FROM     cp_orden_giro INNER JOIN
                  cp_proveedor ON cp_orden_giro.IdEmpresa = cp_proveedor.IdEmpresa AND cp_orden_giro.IdProveedor = cp_proveedor.IdProveedor INNER JOIN
                  tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona INNER JOIN
                  cp_proveedor_clase ON cp_proveedor.IdEmpresa = cp_proveedor_clase.IdEmpresa AND cp_proveedor.IdClaseProveedor = cp_proveedor_clase.IdClaseProveedor LEFT OUTER JOIN
                      (SELECT cab.IdEmpresa_Ogiro, cab.IdTipoCbte_Ogiro, cab.IdCbteCble_Ogiro, cab.NumRetencion, SUM(det.re_valor_retencion) AS re_valor_retencion
                       FROM      cp_retencion AS cab INNER JOIN
                                         cp_retencion_det AS det ON cab.IdEmpresa = det.IdEmpresa AND cab.IdRetencion = det.IdRetencion
                       GROUP BY cab.IdEmpresa_Ogiro, cab.IdTipoCbte_Ogiro, cab.IdCbteCble_Ogiro, cab.NumRetencion) AS ret ON ret.IdEmpresa_Ogiro = cp_orden_giro.IdEmpresa AND ret.IdTipoCbte_Ogiro = cp_orden_giro.IdTipoCbte_Ogiro AND 
                  ret.IdCbteCble_Ogiro = cp_orden_giro.IdCbteCble_Ogiro LEFT OUTER JOIN
                      (SELECT IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, SUM(MontoAplicado) AS MontoAplicado
                       FROM      cp_orden_pago_cancelaciones AS f
                       GROUP BY IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp) AS canc ON canc.IdEmpresa_cxp = cp_orden_giro.IdEmpresa AND canc.IdTipoCbte_cxp = cp_orden_giro.IdTipoCbte_Ogiro AND 
                  canc.IdCbteCble_cxp = cp_orden_giro.IdCbteCble_Ogiro