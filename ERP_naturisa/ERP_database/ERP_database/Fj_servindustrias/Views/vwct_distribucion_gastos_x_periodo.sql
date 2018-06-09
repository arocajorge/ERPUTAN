CREATE VIEW [Fj_servindustrias].[vwct_distribucion_gastos_x_periodo]
AS
SELECT        Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdEmpresa, Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdDistribucion, 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdPeriodo, Fj_servindustrias.ct_distribucion_gastos_x_periodo.Fecha, 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.Observacion, Fj_servindustrias.ct_distribucion_gastos_x_periodo.Estado, 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdEmpresa_ct, Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdTipoCbte_ct, 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdCbteCble_ct, ct_cbtecble_tipo.tc_TipoCbte, ct_periodo.pe_mes, tb_mes.smes, ct_periodo.IdanioFiscal
FROM            Fj_servindustrias.ct_distribucion_gastos_x_periodo INNER JOIN
                         ct_periodo ON Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdEmpresa = ct_periodo.IdEmpresa AND 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdPeriodo = ct_periodo.IdPeriodo INNER JOIN
                         tb_mes ON ct_periodo.pe_mes = tb_mes.idMes LEFT OUTER JOIN
                         ct_cbtecble_tipo ON Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdEmpresa_ct = ct_cbtecble_tipo.IdEmpresa AND 
                         Fj_servindustrias.ct_distribucion_gastos_x_periodo.IdTipoCbte_ct = ct_cbtecble_tipo.IdTipoCbte