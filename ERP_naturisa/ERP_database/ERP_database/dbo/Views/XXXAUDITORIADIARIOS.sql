
CREATE VIEW [dbo].[XXXAUDITORIADIARIOS]
AS
SELECT ct_cbtecble.IdEmpresa, ct_cbtecble_tipo.tc_TipoCbte TIPOCOMPROBANTE, ct_cbtecble.IdCbteCble NUMERO, CASE WHEN ct_cbtecble.cb_Estado = 'A' THEN 'ACTIVO' ELSE 'INACTIVO' END AS ESTADO,
ct_cbtecble_det.IdCtaCble CODIGOCUENTA, ct_plancta.pc_Cuenta NOMCUENTA,REPLACE(REPLACE(LTRIM(RTRIM(ct_cbtecble.cb_Observacion)), CHAR(10), ''), CHAR(13), '') GLOSA, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN 'DB' ELSE 'CR' END AS SENTIDO,
 ABS(ct_cbtecble_det.dc_Valor) AS MONTO, ct_cbtecble.cb_Fecha AS FECHACONTABILIZACION, ct_cbtecble.IdUsuario USAURIOCREACION, ct_cbtecble.cb_FechaTransac FECHACREACION, ct_cbtecble.IdUsuarioUltModi USUARIOMODIFICACION, ct_cbtecble.cb_FechaUltModi FECHAMODIFICACION,
 ct_cbtecble.IdUsuarioAnu USUARIOANULACION, ct_cbtecble.cb_FechaAnu FECHAANULACION, ct_cbtecble.cb_MotivoAnu MOTIVOANULACION
FROM     ct_cbtecble INNER JOIN
                  ct_cbtecble_det ON ct_cbtecble.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND ct_cbtecble.IdCbteCble = ct_cbtecble_det.IdCbteCble INNER JOIN
                  ct_cbtecble_tipo ON ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte INNER JOIN
                  ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble