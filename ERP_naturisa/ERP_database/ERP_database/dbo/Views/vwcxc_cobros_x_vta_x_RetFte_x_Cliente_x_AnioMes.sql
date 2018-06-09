CREATE view vwcxc_cobros_x_vta_x_RetFte_x_Cliente_x_AnioMes as
SELECT        vwcxc_cobros_x_vta_nota_x_RetFuente.IdEmpresa, tb_persona.pe_cedulaRuc, SUM(vwcxc_cobros_x_vta_nota_x_RetFuente.dc_ValorPago) AS Valor_ret, 
                         YEAR(vwcxc_cobros_x_vta_nota_x_RetFuente.cr_fechaDocu) AS IdAnioRT, MONTH(vwcxc_cobros_x_vta_nota_x_RetFuente.cr_fechaDocu) AS IdMes
FROM            vwcxc_cobros_x_vta_nota_x_RetFuente INNER JOIN
                         fa_factura ON vwcxc_cobros_x_vta_nota_x_RetFuente.IdEmpresa = fa_factura.IdEmpresa AND vwcxc_cobros_x_vta_nota_x_RetFuente.IdSucursal = fa_factura.IdSucursal AND 
                         vwcxc_cobros_x_vta_nota_x_RetFuente.IdBodega_Cbte = fa_factura.IdBodega AND vwcxc_cobros_x_vta_nota_x_RetFuente.IdCbte_vta_nota = fa_factura.IdCbteVta INNER JOIN
                         fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona
WHERE        (vwcxc_cobros_x_vta_nota_x_RetFuente.dc_TipoDocumento = 'FACT')
GROUP BY vwcxc_cobros_x_vta_nota_x_RetFuente.IdEmpresa, tb_persona.pe_cedulaRuc, YEAR(vwcxc_cobros_x_vta_nota_x_RetFuente.cr_fechaDocu), MONTH(vwcxc_cobros_x_vta_nota_x_RetFuente.cr_fechaDocu)