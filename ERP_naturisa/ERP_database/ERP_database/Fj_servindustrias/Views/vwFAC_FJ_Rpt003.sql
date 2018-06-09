CREATE VIEW Fj_servindustrias.vwFAC_FJ_Rpt003
AS
SELECT        Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion, dbo.ct_periodo.IdEmpresa, dbo.ct_periodo.IdPeriodo, 
                         Fj_servindustrias.fa_liquidacion_gastos.Observacion AS Observacion_x_liqui, Fj_servindustrias.fa_liquidacion_gastos_det.detalle_x_producto, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.cantidad, Fj_servindustrias.fa_liquidacion_gastos_det.precio, Fj_servindustrias.fa_liquidacion_gastos_det.subtotal, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.valor_iva, Fj_servindustrias.fa_liquidacion_gastos_det.Total_liq, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.tb_persona.pe_razonSocial, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre
FROM            dbo.ct_periodo INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos_det INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos ON Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdLiquidacion = Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.fa_cliente ON dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona AND dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona AND dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona ON 
                         Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = dbo.fa_cliente.IdEmpresa AND Fj_servindustrias.fa_liquidacion_gastos.IdCliente = dbo.fa_cliente.IdCliente ON 
                         dbo.ct_periodo.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa AND dbo.ct_periodo.IdPeriodo = Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo