CREATE PROCEDURE [dbo].[SPINV_GetMovimientosPorContabilizar]
(
@IdEmpresa int,
@FechaIni date, 
@FechaFin date
)
AS

SELECT A.IdEmpresa, A.IdSucursal, A.IdMovi_inven_tipo, A.IdNumMovi, A.Su_Descripcion, A.cm_fecha, A.cm_observacion, A.signo, tm_descripcion, a.TotalInventario, sum(TotalContabilidad) TotalContabilidad, round(a.TotalInventario - isnull(sum(TotalContabilidad),0),2) As Diferencia from (
SELECT d.IdEmpresa, d.IdSucursal, d.IdMovi_inven_tipo, d.IdNumMovi, s.Su_Descripcion, c.cm_fecha, c.cm_observacion, c.signo, tm.tm_descripcion, ROUND(SUM(md.dm_cantidad * md.mv_costo), 2) AS TotalInventario,
rel.dc_Valor as TotalContabilidad 
FROM     tb_bodega AS b INNER JOIN
                  tb_sucursal AS s ON b.IdEmpresa = s.IdEmpresa AND b.IdSucursal = s.IdSucursal INNER JOIN
                  in_Ing_Egr_Inven_det AS d ON b.IdEmpresa = d.IdEmpresa AND b.IdSucursal = d.IdSucursal AND b.IdBodega = d.IdBodega INNER JOIN
                  in_Ing_Egr_Inven AS c ON d.IdEmpresa = c.IdEmpresa AND d.IdSucursal = c.IdSucursal AND d.IdMovi_inven_tipo = c.IdMovi_inven_tipo AND d.IdNumMovi = c.IdNumMovi INNER JOIN
                  in_movi_inve_detalle AS md ON d.IdEmpresa_inv = md.IdEmpresa AND d.IdSucursal_inv = md.IdSucursal AND d.IdBodega_inv = md.IdBodega AND d.IdMovi_inven_tipo_inv = md.IdMovi_inven_tipo AND 
                  d.IdNumMovi_inv = md.IdNumMovi AND d.secuencia_inv = md.Secuencia INNER JOIN
                  in_Motivo_Inven AS m ON c.IdEmpresa = m.IdEmpresa AND c.IdMotivo_Inv = m.IdMotivo_Inv INNER JOIN
                  in_movi_inven_tipo AS tm ON c.IdEmpresa = tm.IdEmpresa AND c.IdMovi_inven_tipo = tm.IdMovi_inven_tipo 
				  left join(
						SELECT in_movi_inve.IdEmpresa, in_movi_inve.IdSucursal, in_movi_inve.IdBodega, in_movi_inve.IdMovi_inven_tipo, in_movi_inve.IdNumMovi, SUM(isnull(ct_cbtecble_det.dc_Valor,0)) AS dc_Valor
						FROM     in_movi_inve_x_ct_cbteCble INNER JOIN
						in_movi_inve ON in_movi_inve_x_ct_cbteCble.IdEmpresa = in_movi_inve.IdEmpresa AND in_movi_inve_x_ct_cbteCble.IdSucursal = in_movi_inve.IdSucursal AND in_movi_inve_x_ct_cbteCble.IdBodega = in_movi_inve.IdBodega AND 
						in_movi_inve_x_ct_cbteCble.IdMovi_inven_tipo = in_movi_inve.IdMovi_inven_tipo AND in_movi_inve_x_ct_cbteCble.IdNumMovi = in_movi_inve.IdNumMovi INNER JOIN
						tb_bodega ON in_movi_inve.IdEmpresa = tb_bodega.IdEmpresa AND in_movi_inve.IdSucursal = tb_bodega.IdSucursal AND in_movi_inve.IdBodega = tb_bodega.IdBodega INNER JOIN
						ct_cbtecble_det ON in_movi_inve_x_ct_cbteCble.IdEmpresa_ct = ct_cbtecble_det.IdEmpresa AND in_movi_inve_x_ct_cbteCble.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND 
						in_movi_inve_x_ct_cbteCble.IdCbteCble = ct_cbtecble_det.IdCbteCble AND tb_bodega.IdCtaCtble_Inve = ct_cbtecble_det.IdCtaCble
						where in_movi_inve.IdEmpresa = @IdEmpresa and (in_movi_inve.cm_fecha BETWEEN @FechaIni AND @FechaFin)
						GROUP BY in_movi_inve.IdEmpresa, in_movi_inve.IdSucursal, in_movi_inve.IdBodega, in_movi_inve.IdMovi_inven_tipo, in_movi_inve.IdNumMovi
				  ) as rel on rel.IdEmpresa = md.IdEmpresa  and rel.IdSucursal = md.IdSucursal and rel.IdBodega = md.IdBodega and rel.IdMovi_inven_tipo = md.IdMovi_inven_tipo and rel.IdNumMovi = md.IdNumMovi
WHERE  c.IdEmpresa = @IdEmpresa and (c.cm_fecha BETWEEN @FechaIni AND @FechaFin) and tm.Genera_Diario_Contable = 1
GROUP BY d.IdEmpresa, d.IdSucursal, d.IdMovi_inven_tipo, d.IdNumMovi, s.Su_Descripcion, c.cm_fecha, c.cm_observacion, c.signo, tm.tm_descripcion,rel.dc_Valor
) A
group by A.IdEmpresa, A.IdSucursal, A.IdMovi_inven_tipo, A.IdNumMovi, A.Su_Descripcion, A.cm_fecha, A.cm_observacion, A.signo, tm_descripcion, a.TotalInventario