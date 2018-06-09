CREATE view [dbo].[vwFAC_CUS_TAL_Rpt006]
as
SELECT     nt.IdEmpresa, nt.IdSucursal, nt.IdBodega, nt.IdNota, nt.CodNota, nt.CreDeb, nt.Serie1, nt.Serie2, nt.NumNota_Impresa, nt.NumAutorizacion, nt.IdCliente, nt.IdVendedor, 
                      nt.no_fecha, nt.no_fecha_venc, nt.sc_observacion, nt.flete, nt.interes, nt.valor1, nt.valor2, nt.seguro, nt.IdCaja, nt_det.Secuencia, nt_det.IdProducto, 
                      nt_det.sc_cantidad, nt_det.sc_Precio, nt_det.sc_descUni, nt_det.sc_PordescUni, nt_det.sc_precioFinal, nt_det.sc_subtotal, nt_det.sc_iva, nt_det.sc_total, 
                      per.pe_nombreCompleto AS nom_cliente, per.pe_razonSocial AS razon_social_cliente, per.pe_cedulaRuc AS cedula_ruc_cliente, 
                      per.pe_direccion AS direccion_cliente, per.pe_telefonoOfic AS telefo_cliente, ven.Ve_Vendedor AS nom_vendedor, emp.em_nombre AS nom_empresa, 
                      emp.em_ruc AS ruc_empresa, emp.em_telefonos AS tel_empresa, emp.em_direccion AS dir_empresa, suc.Su_Descripcion AS nom_sucursal, 
                      bod.bo_Descripcion AS nom_bodega, caj.ca_Descripcion AS nom_caja, in_Producto.pr_codigo AS cod_producto, in_Producto.pr_descripcion AS nom_producto
FROM         tb_bodega AS bod INNER JOIN
                      fa_notaCreDeb AS nt INNER JOIN
                      fa_notaCreDeb_det AS nt_det ON nt.IdEmpresa = nt_det.IdEmpresa AND nt.IdSucursal = nt_det.IdSucursal AND nt.IdBodega = nt_det.IdBodega AND 
                      nt.IdNota = nt_det.IdNota ON bod.IdEmpresa = nt.IdEmpresa AND bod.IdSucursal = nt.IdSucursal AND bod.IdBodega = nt.IdBodega INNER JOIN
                      tb_sucursal AS suc INNER JOIN
                      tb_empresa AS emp ON suc.IdEmpresa = emp.IdEmpresa ON bod.IdEmpresa = suc.IdEmpresa INNER JOIN
                      fa_cliente AS clie ON nt.IdEmpresa = clie.IdEmpresa AND nt.IdCliente = clie.IdCliente INNER JOIN
                      fa_Vendedor AS ven ON nt.IdEmpresa = ven.IdEmpresa AND nt.IdVendedor = ven.IdVendedor INNER JOIN
                      tb_persona AS per ON clie.IdPersona = per.IdPersona INNER JOIN
                      caj_Caja AS caj ON nt.IdEmpresa = caj.IdEmpresa AND nt.IdCaja = caj.IdCaja INNER JOIN
                      in_Producto ON nt_det.IdEmpresa = in_Producto.IdEmpresa AND nt_det.IdProducto = in_Producto.IdProducto