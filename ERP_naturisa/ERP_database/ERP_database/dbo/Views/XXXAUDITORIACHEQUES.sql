CREATE VIEW XXXAUDITORIACHEQUES
AS
select IdEmpresa, IdCbteCble NUMERO, cb_Fecha FECHA, cb_Cheque NUMEROCHEQUE, ba_descripcion BANCOEMISOR, cb_Observacion as GLOSA,
pe_cedulaRuc RUC, Beneficiario BENEFICIARIO, cb_Valor TOTAL, case when Estado = 'A' THEN 'ACTIVO' ELSE 'INACTIVO' END AS ESTADO, tc_TipoCbte TIPODOCUMENTO
from vwba_Cbte_Ban
WHERE RTRIM(tc_TipoCbte) IN ('NOTA DEBITO BANCARIA','CHEQUE')