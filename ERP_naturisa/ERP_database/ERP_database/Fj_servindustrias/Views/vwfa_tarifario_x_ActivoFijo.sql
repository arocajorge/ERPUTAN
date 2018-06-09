create view [Fj_servindustrias].[vwfa_tarifario_x_ActivoFijo] as
select IdCliente,IdActivoFijo,F.Unidades_minimas,C.IdCentroCosto_cc from Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo 
F, Fj_servindustrias.fa_tarifario_facturacion_x_cliente as T, Fj_servindustrias.fa_cliente_x_ct_centro_costo C
where F.IdEmpresa=T.IdEmpresa
And F.IdTarifario=t.IdTarifario
And T.IdEstadoVigencia_cat='EST_VIG_VIGENTE'
and C.IdCliente_cli=T.IdCliente