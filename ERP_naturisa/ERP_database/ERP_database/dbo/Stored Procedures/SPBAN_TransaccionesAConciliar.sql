--exec SPBAN_TransaccionesAConciliar 3,'1010101020010001', '31/03/2019',0

CREATE PROCEDURE SPBAN_TransaccionesAConciliar
(
@IdEmpresa int,
@IdCtaCble varchar(50),
@FechaCorte date,
@IdConciliacion numeric(18,0)
)
AS
SELECT ISNULL(ROW_NUMBER() OVER (ORDER BY A.IdEmpresa), 0) AS IdRow, A.*
FROM     (

SELECT dbo.ba_Conciliacion.IdEmpresa, dbo.ba_Conciliacion.IdConciliacion, dbo.ba_Conciliacion.IdBanco, dbo.ba_Banco_Cuenta.IdCtaCble, dbo.ba_Banco_Cuenta.ba_descripcion, dbo.ct_cbtecble_det.dc_Observacion, dbo.ct_cbtecble.cb_Fecha, 
                  dbo.ct_cbtecble_tipo.tc_TipoCbte AS nom_IdTipoCbte, ABS(dbo.ct_cbtecble_det.dc_Valor) dc_Valor, dbo.ba_Conciliacion.co_Fecha AS fechaConciliacion, dbo.ba_Conciliacion.IdEstado_Concil_Cat, CAST(dbo.ba_Conciliacion_det_IngEgr.checked AS bit) Seleccionado, 
                  isnull(dbo.ct_cbtecble_det.IdTipoCbte,0) IdTipoCbte, dbo.ct_cbtecble_det.IdCbteCble, dbo.ct_cbtecble_det.secuencia, dbo.ba_Cbte_Ban.cb_Cheque, dbo.ba_Conciliacion.co_SaldoBanco_anterior,
				  CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN '+' ELSE '-' END AS Tipo
FROM     dbo.ba_Banco_Cuenta INNER JOIN
                  dbo.ba_Conciliacion ON dbo.ba_Banco_Cuenta.IdEmpresa = dbo.ba_Conciliacion.IdEmpresa AND dbo.ba_Banco_Cuenta.IdBanco = dbo.ba_Conciliacion.IdBanco INNER JOIN
                  dbo.ba_Conciliacion_det_IngEgr ON dbo.ba_Conciliacion.IdEmpresa = dbo.ba_Conciliacion_det_IngEgr.IdEmpresa AND dbo.ba_Conciliacion.IdConciliacion = dbo.ba_Conciliacion_det_IngEgr.IdConciliacion INNER JOIN
                  dbo.ct_cbtecble_det INNER JOIN
                  dbo.ct_cbtecble ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_cbtecble.IdEmpresa AND dbo.ct_cbtecble_det.IdTipoCbte = dbo.ct_cbtecble.IdTipoCbte AND dbo.ct_cbtecble_det.IdCbteCble = dbo.ct_cbtecble.IdCbteCble ON 
                  dbo.ba_Conciliacion_det_IngEgr.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.ba_Conciliacion_det_IngEgr.IdTipocbte = dbo.ct_cbtecble_det.IdTipoCbte AND 
                  dbo.ba_Conciliacion_det_IngEgr.IdCbteCble = dbo.ct_cbtecble_det.IdCbteCble AND dbo.ba_Conciliacion_det_IngEgr.SecuenciaCbteCble = dbo.ct_cbtecble_det.secuencia INNER JOIN
                  ct_cbtecble_tipo ON  ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte LEFT OUTER JOIN
                  dbo.ba_Cbte_Ban ON dbo.ct_cbtecble.IdEmpresa = dbo.ba_Cbte_Ban.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ba_Cbte_Ban.IdTipocbte AND dbo.ct_cbtecble.IdCbteCble = dbo.ba_Cbte_Ban.IdCbteCble
WHERE  dbo.ba_Conciliacion_det_IngEgr.IdEmpresa = @IdEmpresa and dbo.ba_Conciliacion_det_IngEgr.IdConciliacion = @IdConciliacion and (dbo.ba_Conciliacion_det_IngEgr.checked = 1) AND dbo.ct_cbtecble.cb_Estado = 'A'


                  UNION
                  SELECT dbo.ct_cbtecble.IdEmpresa, 0 AS Expr1, dbo.ba_Banco_Cuenta.IdBanco, dbo.ba_Banco_Cuenta.IdCtaCble, dbo.ba_Banco_Cuenta.ba_descripcion, dbo.ct_cbtecble_det.dc_Observacion, dbo.ct_cbtecble.cb_Fecha, 
                  dbo.ct_cbtecble_tipo.tc_TipoCbte, ABS(dbo.ct_cbtecble_det.dc_Valor) AS Expr2, NULL AS Expr3, 'X_CONCILIAR' AS Expr4, CAST(0 AS bit) AS Expr5, ISNULL(dbo.ct_cbtecble_det.IdTipoCbte, 0) AS Expr6, dbo.ct_cbtecble_det.IdCbteCble, 
                  dbo.ct_cbtecble_det.secuencia, dbo.ba_Cbte_Ban.cb_Cheque, 0 AS Expr7, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN '+' ELSE '-' END AS Tipo
FROM     dbo.ct_cbtecble_det INNER JOIN
                  dbo.ct_cbtecble ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_cbtecble.IdEmpresa AND dbo.ct_cbtecble_det.IdTipoCbte = dbo.ct_cbtecble.IdTipoCbte AND dbo.ct_cbtecble_det.IdCbteCble = dbo.ct_cbtecble.IdCbteCble INNER JOIN
                  dbo.ct_cbtecble_tipo ON dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_tipo.IdTipoCbte AND dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_tipo.IdEmpresa INNER JOIN
                  dbo.ba_Banco_Cuenta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ba_Banco_Cuenta.IdCtaCble LEFT OUTER JOIN
                  dbo.ba_Cbte_Ban ON dbo.ct_cbtecble.IdEmpresa = dbo.ba_Cbte_Ban.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ba_Cbte_Ban.IdTipocbte AND dbo.ct_cbtecble.IdCbteCble = dbo.ba_Cbte_Ban.IdCbteCble
                  WHERE  
				  ct_cbtecble_det.IdEmpresa = @IdEmpresa and ct_cbtecble_det.IdCtaCble = @IdCtaCble and ct_cbtecble.cb_Fecha <= @FechaCorte and dbo.ba_Cbte_Ban.estado = 'A' --and ct_cbtecble_det.dc_para_conciliar = 1
				  and (NOT EXISTS
				                 (SELECT A.IdEmpresa
                                         FROM      ba_Conciliacion_det_IngEgr AS A, ba_Conciliacion B, ct_cbtecble_Reversado AS R
                                         WHERE   A.IdEmpresa = B.IdEmpresa AND A.IdConciliacion = B.IdConciliacion AND (A.IdEmpresa = ct_cbtecble.IdEmpresa) AND (A.IdTipocbte = ct_cbtecble.IdTipoCbte) AND (A.IdCbteCble = ct_cbtecble.IdCbteCble) AND 
                                                           B.Estado = 'A' AND R.IdEmpresa = ct_cbtecble_det.IdEmpresa AND R.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND r.IdCbteCble = ct_cbtecble_det.IdCbteCble)) AND NOT EXISTS
														   
                                        (SELECT A.IdEmpresa
                                         FROM      ba_Conciliacion_det_IngEgr A
                                         WHERE   A.IdEmpresa = @IdEmpresa and
										 A.IdEmpresa = ct_cbtecble_det.IdEmpresa 
										 AND A.IdTipocbte = ct_cbtecble_det.IdTipoCbte AND A.IdCbteCble = ct_cbtecble_det.IdCbteCble AND a.SecuenciaCbteCble = ct_cbtecble_det.secuencia AND a.checked = 1) 
										 
                                    AND NOT EXISTS
                                        (SELECT A.IdEmpresa
                                         FROM      ct_cbtecble_Reversado A
                                         WHERE   A.IdEmpresa_Anu = ct_cbtecble_det.IdEmpresa AND A.IdTipoCbte_Anu = ct_cbtecble_det.IdTipoCbte AND A.IdCbteCble_Anu = ct_cbtecble_det.IdCbteCble) AND isnull(ct_cbtecble_det.dc_para_conciliar, 0) = 1
                     
									) A