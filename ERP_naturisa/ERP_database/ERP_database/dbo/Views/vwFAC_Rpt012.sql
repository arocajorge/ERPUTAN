
-- select * from vwFAC_Rpt012

CREATE view [dbo].[vwFAC_Rpt012]
as

SELECT        fa.IdEmpresa, emp.em_nombre AS nom_empresa, fa.IdSucursal, suc.Su_Descripcion AS nom_sucursal, fa.vt_tipoDoc + '#:' + fa.vt_NumFactura AS Documento, 
                         fa.IdCliente, per.pe_apellido + ' ' + per.pe_nombre AS nom_cliente, per.pe_cedulaRuc AS ced_ruc_cliente, fa.vt_fecha AS Fecha, fa.vt_Observacion AS Observacion, 
                         SUM(fa_d.vt_total) AS Debito, 0 AS Credito, 0 AS Saldo
FROM            fa_factura AS fa INNER JOIN
                         fa_factura_det AS fa_d ON fa.IdEmpresa = fa_d.IdEmpresa AND fa.IdSucursal = fa_d.IdSucursal AND fa.IdBodega = fa_d.IdBodega AND 
                         fa.IdCbteVta = fa_d.IdCbteVta INNER JOIN
                         tb_empresa AS emp ON fa.IdEmpresa = emp.IdEmpresa INNER JOIN
                         tb_sucursal AS suc ON fa.IdEmpresa = suc.IdEmpresa AND fa.IdSucursal = suc.IdSucursal INNER JOIN
                         fa_cliente AS cli ON fa.IdEmpresa = cli.IdEmpresa AND fa.IdCliente = cli.IdCliente INNER JOIN
                         tb_persona AS per ON cli.IdPersona = per.IdPersona
GROUP BY fa.IdEmpresa, fa.IdSucursal, suc.Su_Descripcion, fa.vt_tipoDoc, fa.vt_NumFactura, fa.IdCliente, per.pe_apellido, per.pe_nombre, per.pe_cedulaRuc, fa.vt_fecha, 
                         fa.vt_Observacion, emp.em_nombre

union

SELECT        emp.IdEmpresa, emp.em_nombre,suc.IdSucursal, suc.Su_Descripcion AS nom_sucursal,'N/D#:' +cast(fa_notaCreDeb.IdNota as varchar(20)) Documento,fa_notaCreDeb.IdCliente,  per.pe_apellido +' '+ per.pe_nombre nom_cliente
, per.pe_cedulaRuc, fa_notaCreDeb.no_fecha,fa_notaCreDeb.sc_observacion , SUM(fa_notaCreDeb_det.sc_total) AS Debito,0 credito,0 saldo
FROM            fa_cliente AS cli INNER JOIN
                         tb_persona AS per ON cli.IdPersona = per.IdPersona INNER JOIN
                         fa_notaCreDeb ON cli.IdEmpresa = fa_notaCreDeb.IdEmpresa AND cli.IdCliente = fa_notaCreDeb.IdCliente INNER JOIN
                         fa_notaCreDeb_det ON fa_notaCreDeb.IdEmpresa = fa_notaCreDeb_det.IdEmpresa AND fa_notaCreDeb.IdSucursal = fa_notaCreDeb_det.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = fa_notaCreDeb_det.IdBodega AND fa_notaCreDeb.IdNota = fa_notaCreDeb_det.IdNota INNER JOIN
                         tb_empresa AS emp ON fa_notaCreDeb.IdEmpresa = emp.IdEmpresa INNER JOIN
                         tb_sucursal AS suc ON fa_notaCreDeb.IdEmpresa = suc.IdEmpresa AND fa_notaCreDeb.IdSucursal = suc.IdSucursal
where fa_notaCreDeb.CreDeb='D'
GROUP BY suc.Su_Descripcion, per.pe_apellido, per.pe_nombre, per.pe_cedulaRuc, emp.em_nombre, fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.IdNota, 
                         fa_notaCreDeb.IdCliente, fa_notaCreDeb.no_fecha, fa_notaCreDeb.sc_observacion
						 ,suc.IdSucursal,emp.IdEmpresa



union
SELECT        emp.IdEmpresa, emp.em_nombre,suc.IdSucursal,  suc.Su_Descripcion AS nom_sucursal
,'COBRO X ' + cxc_cobro.IdCobro_tipo +' #:' +  CAST(cxc_cobro.IdCobro AS varchar(20))+'/'+isnull(cxc_cobro.cr_NumDocumento,'')
,cxc_cobro.IdCliente
, per.pe_apellido +' '+ per.pe_nombre nom_cliente, per.pe_cedulaRuc,  
                         cxc_cobro.cr_fecha, cxc_cobro.cr_observacion, 0 as Debito,cxc_cobro.cr_TotalCobro as Credito ,0 Saldo
FROM            tb_empresa AS emp INNER JOIN
                         cxc_cobro ON emp.IdEmpresa = cxc_cobro.IdEmpresa INNER JOIN
                         tb_sucursal AS suc ON cxc_cobro.IdEmpresa = suc.IdEmpresa AND cxc_cobro.IdSucursal = suc.IdSucursal INNER JOIN
                         fa_cliente AS cli INNER JOIN
                         tb_persona AS per ON cli.IdPersona = per.IdPersona ON cxc_cobro.IdEmpresa = cli.IdEmpresa AND cxc_cobro.IdCliente = cli.IdCliente


-- select * from fa_notaCreDeb