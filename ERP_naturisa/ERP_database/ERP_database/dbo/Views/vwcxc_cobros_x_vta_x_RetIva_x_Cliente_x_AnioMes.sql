CREATE view vwcxc_cobros_x_vta_x_RetIva_x_Cliente_x_AnioMes as

SELECT   vwcxc_cobros_x_vta_nota_x_RetIVA.IdEmpresa, tb_persona.pe_cedulaRuc , sum(vwcxc_cobros_x_vta_nota_x_RetIVA.dc_ValorPago) Valor_ret
, year(vwcxc_cobros_x_vta_nota_x_RetIVA.cr_fechaDocu) as IdAnioRT,month(vwcxc_cobros_x_vta_nota_x_RetIVA.cr_fechaDocu) as IdMes
FROM            vwcxc_cobros_x_vta_nota_x_RetIVA INNER JOIN
                         fa_factura ON vwcxc_cobros_x_vta_nota_x_RetIVA.IdEmpresa = fa_factura.IdEmpresa AND vwcxc_cobros_x_vta_nota_x_RetIVA.IdSucursal = fa_factura.IdSucursal AND 
                         vwcxc_cobros_x_vta_nota_x_RetIVA.IdBodega_Cbte = fa_factura.IdBodega AND vwcxc_cobros_x_vta_nota_x_RetIVA.IdCbte_vta_nota = fa_factura.IdCbteVta INNER JOIN
                         fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona
WHERE        (vwcxc_cobros_x_vta_nota_x_RetIVA.dc_TipoDocumento = 'FACT')
group by
vwcxc_cobros_x_vta_nota_x_RetIVA.IdEmpresa, tb_persona.pe_cedulaRuc 
, year(vwcxc_cobros_x_vta_nota_x_RetIVA.cr_fechaDocu) ,month(vwcxc_cobros_x_vta_nota_x_RetIVA.cr_fechaDocu)