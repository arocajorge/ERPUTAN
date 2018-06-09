create view Fj_servindustrias.vwfa_liquidaciones_group_x_liqui_x_periodo_x_cliente as
SELECT        Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa, Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo, 
                         Fj_servindustrias.fa_liquidacion_gastos.cod_liquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdCliente, Fj_servindustrias.fa_liquidacion_gastos.fecha_liqui, 
                         Fj_servindustrias.fa_liquidacion_gastos.Observacion, SUM(Fj_servindustrias.fa_liquidacion_gastos_det.subtotal) AS Subtotal, 
                         SUM(Fj_servindustrias.fa_liquidacion_gastos_det.valor_iva) AS Iva, SUM(Fj_servindustrias.fa_liquidacion_gastos_det.Total_liq) AS total_liquidacion, 
                         dbo.tb_persona.pe_nombreCompleto
FROM            Fj_servindustrias.fa_liquidacion_gastos INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos_det ON Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion = Fj_servindustrias.fa_liquidacion_gastos_det.IdLiquidacion INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona AND dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
GROUP BY Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa, Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo, 
                         Fj_servindustrias.fa_liquidacion_gastos.cod_liquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdCliente, Fj_servindustrias.fa_liquidacion_gastos.fecha_liqui, 
                         Fj_servindustrias.fa_liquidacion_gastos.Observacion, dbo.tb_persona.pe_nombreCompleto