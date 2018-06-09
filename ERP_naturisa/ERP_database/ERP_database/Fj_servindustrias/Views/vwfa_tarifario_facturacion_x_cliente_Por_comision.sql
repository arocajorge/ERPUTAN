CREATE VIEW [Fj_servindustrias].[vwfa_tarifario_facturacion_x_cliente_Por_comision]
	AS SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdAnio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje
FROM            Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario