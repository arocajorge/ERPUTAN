CREATE VIEW [dbo].[vwba_Archivo_Transferencia_Det]
AS
SELECT        dbo.ba_Archivo_Transferencia_Det.IdEmpresa, dbo.ba_Archivo_Transferencia_Det.IdArchivo, dbo.ba_Archivo_Transferencia_Det.Secuencia, 
                         dbo.ba_Archivo_Transferencia_Det.IdProceso_bancario, dbo.ba_Archivo_Transferencia.Origen_Archivo, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.pe_cedulaRuc 
                          END AS pe_cedulaRuc, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.num_cta_acreditacion END AS
                          num_cta_acreditacion, 
                         CASE WHEN ba_Archivo_Transferencia.Origen_Archivo = 'CXP' THEN per_op.pe_nombreCompleto 
                         END AS pe_nombreCompleto, 
                         dbo.ba_Archivo_Transferencia_Det.Valor, dbo.ba_Archivo_Transferencia_Det.Valor_cobrado, 
                         ISNULL(dbo.ba_Archivo_Transferencia_Det.Valor - dbo.ba_Archivo_Transferencia_Det.Valor_cobrado, 0) AS Saldo, 
                         dbo.ba_Archivo_Transferencia_Det.IdEstadoRegistro_cat, dbo.ba_Catalogo.ca_descripcion AS nom_EstadoRegistro_cat, dbo.ba_Archivo_Transferencia_Det.Id_Item, 
                         dbo.ba_Archivo_Transferencia.IdOrden_Bancaria, dbo.ba_Archivo_Transferencia.Fecha, dbo.ba_Archivo_Transferencia.IdBanco, 
                         dbo.ba_Archivo_Transferencia_Det.Secuencial_reg_x_proceso, dbo.ba_Archivo_Transferencia_Det.IdEmpresa_pago, 
                         dbo.ba_Archivo_Transferencia_Det.IdTipoCbte_pago, dbo.ba_Archivo_Transferencia_Det.IdCbteCble_pago, dbo.ct_cbtecble.cb_Estado
FROM            dbo.ba_Catalogo INNER JOIN
                         dbo.ba_Archivo_Transferencia_Det INNER JOIN
                         dbo.ba_Archivo_Transferencia ON dbo.ba_Archivo_Transferencia_Det.IdEmpresa = dbo.ba_Archivo_Transferencia.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdArchivo = dbo.ba_Archivo_Transferencia.IdArchivo ON 
                         dbo.ba_Catalogo.IdCatalogo = dbo.ba_Archivo_Transferencia_Det.IdEstadoRegistro_cat 
                         LEFT OUTER JOIN
                         dbo.tb_persona AS per_op INNER JOIN
                         dbo.cp_orden_pago INNER JOIN
                         dbo.cp_orden_pago_det ON dbo.cp_orden_pago.IdEmpresa = dbo.cp_orden_pago_det.IdEmpresa AND 
                         dbo.cp_orden_pago.IdOrdenPago = dbo.cp_orden_pago_det.IdOrdenPago ON per_op.IdPersona = dbo.cp_orden_pago.IdPersona ON 
                         dbo.ba_Archivo_Transferencia_Det.IdEmpresa_OP = dbo.cp_orden_pago_det.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdOrdenPago = dbo.cp_orden_pago_det.IdOrdenPago AND 
                         dbo.ba_Archivo_Transferencia_Det.Secuencia_OP = dbo.cp_orden_pago_det.Secuencia LEFT OUTER JOIN
                         dbo.ct_cbtecble ON dbo.ba_Archivo_Transferencia_Det.IdEmpresa_pago = dbo.ct_cbtecble.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia_Det.IdTipoCbte_pago = dbo.ct_cbtecble.IdTipoCbte AND 
                         dbo.ba_Archivo_Transferencia_Det.IdCbteCble_pago = dbo.ct_cbtecble.IdCbteCble
						 