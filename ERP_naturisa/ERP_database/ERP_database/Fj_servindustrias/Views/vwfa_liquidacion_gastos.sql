CREATE VIEW [Fj_servindustrias].[vwfa_liquidacion_gastos]
	AS 
	SELECT         Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa, Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion, 
                         Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo, Fj_servindustrias.fa_liquidacion_gastos.cod_liquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdCliente, 
                         Fj_servindustrias.fa_liquidacion_gastos.fecha_liqui, Fj_servindustrias.fa_liquidacion_gastos.Observacion, Fj_servindustrias.fa_liquidacion_gastos.estado, 
                         Fj_servindustrias.fa_liquidacion_gastos.IdUsuario, tb_persona.pe_apellido, tb_persona.pe_razonSocial, tb_persona.pe_nombre, tb_persona.pe_cedulaRuc, 
                         tb_persona.pe_direccion, tb_persona.pe_telefonoCasa
	FROM            Fj_servindustrias.fa_liquidacion_gastos INNER JOIN
                         fa_cliente ON Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona