CREATE VIEW [dbo].[XXXAUDITORIADIARIOS]
AS
SELECT dbo.ct_cbtecble.IdEmpresa, dbo.ct_cbtecble_tipo.tc_TipoCbte AS TIPOCOMPROBANTE, dbo.ct_cbtecble.IdCbteCble AS NUMERO, CASE WHEN ct_cbtecble.cb_Estado = 'A' THEN 'ACTIVO' ELSE 'INACTIVO' END AS ESTADO, 
                  dbo.ct_cbtecble_det.IdCtaCble AS CODIGOCUENTA, REPLACE(REPLACE(dbo.ct_plancta.pc_Cuenta, CHAR(10), ''), CHAR(13), '') AS NOMCUENTA, REPLACE(REPLACE(REPLACE(LTRIM(RTRIM(dbo.ct_cbtecble.cb_Observacion)), CHAR(10), ''), CHAR(13), ''),'  ','') AS GLOSA, 
                  CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN 'DB' ELSE 'CR' END AS SENTIDO, ABS(dbo.ct_cbtecble_det.dc_Valor) AS MONTO, dbo.ct_cbtecble.cb_Fecha AS FECHACONTABILIZACION, 
                  dbo.ct_cbtecble.IdUsuario AS USAURIOCREACION, dbo.ct_cbtecble.cb_FechaTransac AS FECHACREACION, dbo.ct_cbtecble.IdUsuarioUltModi AS USUARIOMODIFICACION, dbo.ct_cbtecble.cb_FechaUltModi AS FECHAMODIFICACION, 
                  dbo.ct_cbtecble.IdUsuarioAnu AS USUARIOANULACION, dbo.ct_cbtecble.cb_FechaAnu AS FECHAANULACION, dbo.ct_cbtecble.cb_MotivoAnu AS MOTIVOANULACION
FROM     dbo.ct_cbtecble INNER JOIN
                  dbo.ct_cbtecble_det ON dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_det.IdTipoCbte AND dbo.ct_cbtecble.IdCbteCble = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                  dbo.ct_cbtecble_tipo ON dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_tipo.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_tipo.IdTipoCbte INNER JOIN
                  dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble