CREATE VIEW [dbo].[vwro_Parametros]
	AS 
	SELECT        dbo.ro_Parametros.IdEmpresa, dbo.ro_Parametros.IdTipoCbte_AsientoSueldoXPagar, dbo.ro_Parametros.IdTipoCbte_AsientoProvision, 
                         dbo.ro_Parametros.IdTipo_mov_Ingreso, dbo.ro_Parametros.IdTipo_mov_Egreso, dbo.ro_Parametros.Dias_considerado_ultimo_pago_quincela_Liq, 
                         dbo.ro_Parametros.IdNomina_Tipo_Para_Desc_Automat, dbo.ro_Parametros.IdNominatipoLiq_Para_Desc_Automat, dbo.ro_Parametros.GeneraraOP_PagoTerceros, 
                         dbo.ro_Parametros.IdTipoOP_PagoTerceros, dbo.ro_Parametros.IdTipoFlujoOP_PagoTerceros, dbo.ro_Parametros.IdFormaOP_PagoTerceros, 
                         dbo.ro_Parametros.IdBancoOP_PagoTerceros, dbo.ro_Parametros.GeneraOP_PagoPrestamos, dbo.ro_Parametros.IdTipoOP_PagoPrestamos, 
                         dbo.ro_Parametros.IdTipoFlujoOP_PagoPrestamos, dbo.ro_Parametros.IdFormaOP_PagoPrestamos, dbo.ro_Parametros.IdBancoOP_PagoPrestamos, 
                         dbo.cp_orden_pago_tipo_x_empresa.IdCtaCble, dbo.cp_orden_pago_tipo_x_empresa.IdCtaCble_Credito
FROM            dbo.ro_Parametros LEFT OUTER JOIN
                         dbo.cp_orden_pago_tipo_x_empresa ON dbo.ro_Parametros.IdEmpresa = dbo.cp_orden_pago_tipo_x_empresa.IdEmpresa AND 
                         dbo.ro_Parametros.IdTipoOP_PagoTerceros = dbo.cp_orden_pago_tipo_x_empresa.IdTipo_op