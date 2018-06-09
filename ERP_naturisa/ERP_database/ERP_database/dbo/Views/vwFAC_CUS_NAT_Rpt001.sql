create view [dbo].[vwFAC_CUS_NAT_Rpt001]
as
SELECT     tb_empresa.IdEmpresa, tb_empresa.em_nombre AS nom_empresa, tb_sucursal.IdSucursal, tb_sucursal.Su_Descripcion, fa_cliente.IdCliente, fa_cliente.IdPersona, 
                      tb_persona.pe_Naturaleza, tb_persona.pe_nombreCompleto, tb_persona.pe_razonSocial, fa_cliente.cl_observacion, fa_factura.vt_serie1, fa_factura.vt_serie2, 
                      fa_factura.vt_NumFactura, fa_factura.vt_tipoDoc, fa_factura.vt_fecha, fa_factura.vt_plazo, fa_factura.vt_fech_venc, fa_factura.vt_Observacion, 
                      fa_factura_det.vt_Subtotal, fa_factura_det.vt_iva, fa_factura_det.vt_total
FROM         fa_cliente INNER JOIN
                      fa_factura ON fa_cliente.IdEmpresa = fa_factura.IdEmpresa AND fa_cliente.IdCliente = fa_factura.IdCliente INNER JOIN
                      tb_sucursal ON fa_cliente.IdEmpresa = tb_sucursal.IdEmpresa AND fa_cliente.IdSucursal = tb_sucursal.IdSucursal INNER JOIN
                      fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND 
                      fa_factura.IdBodega = fa_factura_det.IdBodega AND fa_factura.IdCbteVta = fa_factura_det.IdCbteVta INNER JOIN
                      tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona INNER JOIN
                      tb_empresa ON tb_sucursal.IdEmpresa = tb_empresa.IdEmpresa