CREATE VIEW [dbo].[vwCAJ_Rpt006]
AS
select ISNULL(ROW_NUMBER() over(order by a.IdEmpresa),0) AS IdRow, A.* from(
SELECT        dbo.cp_conciliacion_Caja_det.IdEmpresa, dbo.cp_conciliacion_Caja_det.IdConciliacion_Caja, dbo.cp_conciliacion_Caja_det.Secuencia, 
                         dbo.cp_conciliacion_Caja_det.IdEmpresa_OGiro, dbo.cp_conciliacion_Caja_det.IdTipoCbte_Ogiro, dbo.cp_conciliacion_Caja_det.IdCbteCble_Ogiro, 
                         dbo.cp_orden_giro.co_fechaOg, dbo.cp_orden_giro.IdProveedor, dbo.cp_proveedor.pr_codigo, dbo.cp_proveedor.IdPersona, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi, dbo.caj_Caja_Movimiento_Tipo.tm_descripcion AS nom_tipo_movi, dbo.cp_orden_giro.co_factura, 
                         dbo.cp_orden_giro.Num_Autorizacion, dbo.cp_orden_giro.co_subtotal_iva, dbo.cp_orden_giro.co_subtotal_siniva, dbo.cp_orden_giro.co_valoriva, 
                         dbo.cp_orden_giro.co_valorpagar, dbo.cp_conciliacion_Caja_det.Valor_a_aplicar, dbo.caj_Caja.IdCaja, dbo.caj_Caja.ca_Descripcion AS nom_caja, 
                         dbo.cp_conciliacion_Caja.IdPeriodo, dbo.cp_conciliacion_Caja.Fecha_ini, dbo.cp_conciliacion_Caja.Fecha_fin, dbo.cp_conciliacion_Caja.Fecha AS Fecha_conci, 
                         dbo.cp_conciliacion_Caja.IdEstadoCierre, dbo.cp_orden_giro.IdOrden_giro_Tipo, dbo.cp_TipoDocumento.Codigo AS tipo_documento, 
                         MAX(dbo.ct_cbtecble_det.IdPunto_cargo) AS IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo
FROM            dbo.cp_conciliacion_Caja INNER JOIN
                         dbo.cp_conciliacion_Caja_det ON dbo.cp_conciliacion_Caja.IdEmpresa = dbo.cp_conciliacion_Caja_det.IdEmpresa AND 
                         dbo.cp_conciliacion_Caja.IdConciliacion_Caja = dbo.cp_conciliacion_Caja_det.IdConciliacion_Caja INNER JOIN
                         dbo.cp_orden_giro ON dbo.cp_conciliacion_Caja_det.IdEmpresa_OGiro = dbo.cp_orden_giro.IdEmpresa AND 
                         dbo.cp_conciliacion_Caja_det.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro AND 
                         dbo.cp_conciliacion_Caja_det.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro INNER JOIN
                         dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                         dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.caj_Caja_Movimiento_Tipo ON dbo.cp_orden_giro.IdTipoMovi = dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi INNER JOIN
                         dbo.caj_Caja ON dbo.cp_conciliacion_Caja.IdEmpresa = dbo.caj_Caja.IdEmpresa AND dbo.cp_conciliacion_Caja.IdCaja = dbo.caj_Caja.IdCaja INNER JOIN
                         dbo.cp_TipoDocumento ON dbo.cp_orden_giro.IdOrden_giro_Tipo = dbo.cp_TipoDocumento.CodTipoDocumento INNER JOIN
                         dbo.ct_cbtecble_det ON dbo.cp_orden_giro.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND 
                         dbo.cp_orden_giro.IdCbteCble_Ogiro = dbo.ct_cbtecble_det.IdCbteCble AND dbo.cp_orden_giro.IdTipoCbte_Ogiro = dbo.ct_cbtecble_det.IdTipoCbte LEFT OUTER JOIN
                         dbo.ct_punto_cargo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND 
                         dbo.ct_cbtecble_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo
GROUP BY dbo.cp_conciliacion_Caja_det.IdEmpresa, dbo.cp_conciliacion_Caja_det.IdConciliacion_Caja, dbo.cp_conciliacion_Caja_det.Secuencia, 
                         dbo.cp_conciliacion_Caja_det.IdEmpresa_OGiro, dbo.cp_conciliacion_Caja_det.IdTipoCbte_Ogiro, dbo.cp_conciliacion_Caja_det.IdCbteCble_Ogiro, 
                         dbo.cp_orden_giro.co_fechaOg, dbo.cp_orden_giro.IdProveedor, dbo.cp_proveedor.pr_codigo, dbo.cp_proveedor.IdPersona, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi, dbo.caj_Caja_Movimiento_Tipo.tm_descripcion, dbo.cp_orden_giro.co_factura, dbo.cp_orden_giro.Num_Autorizacion, 
                         dbo.cp_orden_giro.co_subtotal_iva, dbo.cp_orden_giro.co_subtotal_siniva, dbo.cp_orden_giro.co_valoriva, dbo.cp_orden_giro.co_valorpagar, 
                         dbo.cp_conciliacion_Caja_det.Valor_a_aplicar, dbo.caj_Caja.IdCaja, dbo.caj_Caja.ca_Descripcion, dbo.cp_conciliacion_Caja.IdPeriodo, 
                         dbo.cp_conciliacion_Caja.Fecha_ini, dbo.cp_conciliacion_Caja.Fecha_fin, dbo.cp_conciliacion_Caja.Fecha, dbo.cp_conciliacion_Caja.IdEstadoCierre, 
                         dbo.cp_orden_giro.IdOrden_giro_Tipo, dbo.cp_TipoDocumento.Codigo, dbo.ct_punto_cargo.nom_punto_cargo
UNION
SELECT        dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa, dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdConciliacion_Caja, 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.Secuencia, dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja, 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja, dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja, 
                         dbo.caj_Caja_Movimiento.cm_fecha, NULL AS Expr1, NULL AS Expr2, dbo.tb_persona.IdPersona, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi, dbo.caj_Caja_Movimiento_Tipo.tm_descripcion AS nom_tipo_movi, NULL AS Expr3, NULL AS Expr4, 0 AS Expr5, 
                         dbo.caj_Caja_Movimiento_det.cr_Valor, 0 AS Expr6, dbo.caj_Caja_Movimiento_det.cr_Valor AS Expr7, dbo.caj_Caja_Movimiento_det.cr_Valor AS Expr8, 
                         dbo.caj_Caja.IdCaja, dbo.caj_Caja.ca_Descripcion AS nom_caja, dbo.cp_conciliacion_Caja.IdPeriodo, dbo.cp_conciliacion_Caja.Fecha_ini, 
                         dbo.cp_conciliacion_Caja.Fecha_fin, dbo.cp_conciliacion_Caja.Fecha AS Fecha_conci, dbo.cp_conciliacion_Caja.IdEstadoCierre, NULL AS Expr9, 'VACAJ' AS Expr10, 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo
FROM            dbo.caj_Caja INNER JOIN
                         dbo.cp_conciliacion_Caja ON dbo.caj_Caja.IdEmpresa = dbo.cp_conciliacion_Caja.IdEmpresa AND dbo.caj_Caja.IdCaja = dbo.cp_conciliacion_Caja.IdCaja INNER JOIN
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja ON dbo.cp_conciliacion_Caja.IdEmpresa = dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa AND 
                         dbo.cp_conciliacion_Caja.IdConciliacion_Caja = dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdConciliacion_Caja INNER JOIN
                         dbo.caj_Caja_Movimiento_Tipo INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.caj_Caja_Movimiento ON dbo.tb_persona.IdPersona = dbo.caj_Caja_Movimiento.IdPersona ON 
                         dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi = dbo.caj_Caja_Movimiento.IdTipoMovi ON 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja = dbo.caj_Caja_Movimiento.IdEmpresa AND 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja = dbo.caj_Caja_Movimiento.IdTipocbte AND 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja = dbo.caj_Caja_Movimiento.IdCbteCble INNER JOIN
                         dbo.caj_Caja_Movimiento_det ON dbo.caj_Caja_Movimiento.IdEmpresa = dbo.caj_Caja_Movimiento_det.IdEmpresa AND 
                         dbo.caj_Caja_Movimiento.IdCbteCble = dbo.caj_Caja_Movimiento_det.IdCbteCble AND 
                         dbo.caj_Caja_Movimiento.IdTipocbte = dbo.caj_Caja_Movimiento_det.IdTipocbte LEFT OUTER JOIN
                         dbo.ct_punto_cargo ON dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND 
                         dbo.cp_conciliacion_Caja_det_x_ValeCaja.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo
) A