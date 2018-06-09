CREATE VIEW [Grafinpren].[vwFAC_GRAF_Rpt002]
AS
SELECT        dbo.fa_factura.IdEmpresa, dbo.fa_factura.IdSucursal, dbo.fa_factura.IdBodega, dbo.fa_factura.vt_tipoDoc AS IdTipoDocumento, 
                         CASE WHEN dbo.fa_factura.vt_NumFactura IS NULL THEN dbo.fa_factura.vt_tipoDoc + '#' + CAST(dbo.fa_factura.IdCbteVta AS varchar(20)) 
                         ELSE dbo.fa_factura.vt_tipoDoc + '-' + isnull(dbo.fa_factura.vt_serie1, '') + '-' + isnull(dbo.fa_factura.vt_serie2, '') + '-' + isnull(dbo.fa_factura.vt_NumFactura, '') 
                         + '/' + CAST(dbo.fa_factura.IdCbteVta AS varchar(20)) END AS numDocumento, dbo.fa_factura.IdCbteVta, dbo.fa_factura.IdCliente, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_cliente, dbo.fa_factura.vt_fecha, dbo.tb_Calendario.IdCalendario, dbo.tb_Calendario.AnioFiscal, 
                         dbo.tb_Calendario.NombreMes, dbo.tb_Calendario.NombreCortoFecha, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion AS nom_producto, 
                         dbo.fa_factura_det.vt_cantidad, dbo.fa_factura_det.vt_PrecioFinal, dbo.fa_factura_det.vt_Subtotal, dbo.fa_factura_det.vt_iva, dbo.fa_factura_det.vt_total, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, dbo.vwin_Cate_Lin_Grup_SubGrup.IdCategoria, dbo.vwin_Cate_Lin_Grup_SubGrup.IdLinea, 
                         dbo.vwin_Cate_Lin_Grup_SubGrup.IdGrupo, dbo.vwin_Cate_Lin_Grup_SubGrup.IdSubgrupo, dbo.vwin_Cate_Lin_Grup_SubGrup.ca_Categoria AS nom_categoria, 
                         dbo.vwin_Cate_Lin_Grup_SubGrup.nom_linea, dbo.vwin_Cate_Lin_Grup_SubGrup.nom_grupo, dbo.vwin_Cate_Lin_Grup_SubGrup.nom_subgrupo, 
                         dbo.fa_cliente_tipo.Idtipo_cliente, dbo.fa_cliente_tipo.Descripcion_tip_cliente AS nom_tipo_cliente, dbo.fa_factura.vt_Observacion, dbo.fa_Vendedor.IdVendedor, 
                         dbo.fa_Vendedor.Ve_Vendedor AS nom_vendedor, Grafinpren.fa_factura_graf.num_op, Grafinpren.fa_factura_graf.fecha_op, 
                         Grafinpren.fa_factura_graf.num_cotizacion, Grafinpren.fa_factura_graf.fecha_cotizacion, Grafinpren.fa_factura_graf.porc_comision, 
                         Grafinpren.fa_factura_graf.IdEquipo, Grafinpren.fa_Equipo_graf.nom_Equipo, dbo.tb_Calendario.IdMes, dbo.fa_factura.Estado,
						 fa_factura_det.Secuencia
FROM            dbo.vwin_Cate_Lin_Grup_SubGrup RIGHT OUTER JOIN
                         dbo.fa_factura INNER JOIN
                         dbo.tb_bodega ON dbo.fa_factura.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.fa_factura.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                         dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.fa_cliente ON dbo.fa_factura.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_factura.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.fa_cliente_tipo ON dbo.fa_cliente_tipo.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_cliente_tipo.Idtipo_cliente = dbo.fa_cliente.Idtipo_cliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.tb_Calendario ON dbo.fa_factura.vt_fecha = dbo.tb_Calendario.fecha INNER JOIN
                         dbo.fa_factura_det ON dbo.fa_factura.IdEmpresa = dbo.fa_factura_det.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.fa_factura_det.IdSucursal AND 
                         dbo.fa_factura.IdBodega = dbo.fa_factura_det.IdBodega AND dbo.fa_factura.IdCbteVta = dbo.fa_factura_det.IdCbteVta INNER JOIN
                         dbo.in_Producto ON dbo.fa_factura_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.fa_factura_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.fa_Vendedor ON dbo.fa_factura.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_factura.IdVendedor = dbo.fa_Vendedor.IdVendedor AND 
                         dbo.fa_factura.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_factura.IdVendedor = dbo.fa_Vendedor.IdVendedor ON 
                         dbo.vwin_Cate_Lin_Grup_SubGrup.IdGrupo = dbo.in_Producto.IdGrupo AND dbo.vwin_Cate_Lin_Grup_SubGrup.IdLinea = dbo.in_Producto.IdLinea AND 
                         dbo.vwin_Cate_Lin_Grup_SubGrup.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.vwin_Cate_Lin_Grup_SubGrup.IdCategoria = dbo.in_Producto.IdCategoria AND 
                         dbo.vwin_Cate_Lin_Grup_SubGrup.IdSubgrupo = dbo.in_Producto.IdSubGrupo LEFT OUTER JOIN
                         Grafinpren.fa_Equipo_graf INNER JOIN
                         Grafinpren.fa_factura_graf ON Grafinpren.fa_Equipo_graf.IdEmpresa = Grafinpren.fa_factura_graf.IdEmpresa AND 
                         Grafinpren.fa_Equipo_graf.IdEquipo = Grafinpren.fa_factura_graf.IdEquipo ON dbo.fa_factura.IdEmpresa = Grafinpren.fa_factura_graf.IdEmpresa AND 
                         dbo.fa_factura.IdSucursal = Grafinpren.fa_factura_graf.IdSucursal AND dbo.fa_factura.IdBodega = Grafinpren.fa_factura_graf.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = Grafinpren.fa_factura_graf.IdCbteVta
UNION
SELECT        fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.IdSucursal, fa_notaCreDeb.IdBodega, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN 'NTCR' ELSE 'NTDB' END) 
                         AS IdTipoDocumento, CASE WHEN dbo.fa_notaCreDeb.NumNota_Impresa IS NULL THEN SUBSTRING(dbo.fa_TipoNota.CodTipoNota, 1, 2) 
                         + '#' + CAST(dbo.fa_notaCreDeb.IdNota AS varchar(20)) ELSE SUBSTRING(dbo.fa_TipoNota.CodTipoNota, 1, 2) + '-' + isnull(dbo.fa_notaCreDeb.Serie1, '') 
                         + '-' + isnull(dbo.fa_notaCreDeb.Serie2, '') + '-' + isnull(dbo.fa_notaCreDeb.NumNota_Impresa, '') + '/' + CAST(dbo.fa_notaCreDeb.IdNota AS varchar(20)) 
                         END AS numDocumento, fa_notaCreDeb.IdNota, fa_notaCreDeb.IdCliente, tb_persona.pe_nombreCompleto AS nombreCliente, fa_notaCreDeb.no_fecha, 
                         tb_Calendario.IdCalendario, tb_Calendario.AnioFiscal, tb_Calendario.NombreMes, tb_Calendario.NombreCortoFecha, in_Producto.IdProducto, 
                         in_Producto.pr_descripcion AS nombreProducto, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN (dbo.fa_notaCreDeb_det.sc_cantidad * - 1) 
                         ELSE dbo.fa_notaCreDeb_det.sc_cantidad END) AS vt_cantidad, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN (dbo.fa_notaCreDeb_det.sc_precioFinal * - 1) 
                         ELSE dbo.fa_notaCreDeb_det.sc_precioFinal END) AS vt_PrecioFinal, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN (dbo.fa_notaCreDeb_det.sc_subtotal * - 1) 
                         ELSE dbo.fa_notaCreDeb_det.sc_subtotal END) AS vt_Subtotal, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN (dbo.fa_notaCreDeb_det.sc_iva * - 1) 
                         ELSE dbo.fa_notaCreDeb_det.sc_iva END) AS vt_iva, (CASE dbo.fa_TipoNota.Tipo WHEN 'C' THEN (dbo.fa_notaCreDeb_det.sc_total * - 1) 
                         ELSE dbo.fa_notaCreDeb_det.sc_total END) AS vt_total, tb_sucursal.Su_Descripcion, vwin_Cate_Lin_Grup_SubGrup.IdCategoria, 
                         vwin_Cate_Lin_Grup_SubGrup.IdLinea, vwin_Cate_Lin_Grup_SubGrup.IdGrupo, vwin_Cate_Lin_Grup_SubGrup.IdSubgrupo, 
                         vwin_Cate_Lin_Grup_SubGrup.ca_Categoria, vwin_Cate_Lin_Grup_SubGrup.nom_linea, vwin_Cate_Lin_Grup_SubGrup.nom_grupo, 
                         vwin_Cate_Lin_Grup_SubGrup.nom_subgrupo, fa_cliente_tipo.Idtipo_cliente, fa_cliente_tipo.Descripcion_tip_cliente, fa_notaCreDeb.sc_observacion, 
                         fa_Vendedor.IdVendedor, fa_Vendedor.Ve_Vendedor AS Vendedor, Grafinpren.fa_notaCreDeb_graf.num_op, Grafinpren.fa_notaCreDeb_graf.fecha_op, 
                         Grafinpren.fa_notaCreDeb_graf.num_cotizacion, Grafinpren.fa_notaCreDeb_graf.fecha_cotizacion, Grafinpren.fa_notaCreDeb_graf.IdEquipo, 
                         Grafinpren.fa_notaCreDeb_graf.porc_comision, Grafinpren.fa_Equipo_graf.nom_Equipo, tb_Calendario.IdMes, fa_notaCreDeb.Estado,
						 fa_notaCreDeb_det.Secuencia
FROM            Grafinpren.fa_Equipo_graf INNER JOIN
                         Grafinpren.fa_notaCreDeb_graf ON Grafinpren.fa_Equipo_graf.IdEmpresa = Grafinpren.fa_notaCreDeb_graf.IdEmpresa AND 
                         Grafinpren.fa_Equipo_graf.IdEquipo = Grafinpren.fa_notaCreDeb_graf.IdEquipo RIGHT OUTER JOIN
                         fa_notaCreDeb INNER JOIN
                         tb_bodega ON fa_notaCreDeb.IdEmpresa = tb_bodega.IdEmpresa AND fa_notaCreDeb.IdSucursal = tb_bodega.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = tb_bodega.IdBodega INNER JOIN
                         tb_sucursal ON tb_bodega.IdEmpresa = tb_sucursal.IdEmpresa AND tb_bodega.IdSucursal = tb_sucursal.IdSucursal INNER JOIN
                         fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente AND 
                         tb_sucursal.IdEmpresa = fa_cliente.IdEmpresa AND tb_sucursal.IdSucursal = fa_cliente.IdSucursal INNER JOIN
                         fa_cliente_tipo ON fa_cliente_tipo.IdEmpresa = fa_cliente.IdEmpresa AND fa_cliente_tipo.Idtipo_cliente = fa_cliente.Idtipo_cliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona INNER JOIN
                         tb_Calendario ON fa_notaCreDeb.no_fecha = tb_Calendario.fecha INNER JOIN
                         fa_notaCreDeb_det ON fa_notaCreDeb.IdEmpresa = fa_notaCreDeb_det.IdEmpresa AND fa_notaCreDeb.IdSucursal = fa_notaCreDeb_det.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = fa_notaCreDeb_det.IdBodega AND fa_notaCreDeb.IdNota = fa_notaCreDeb_det.IdNota INNER JOIN
                         in_Producto ON fa_notaCreDeb_det.IdEmpresa = in_Producto.IdEmpresa AND fa_notaCreDeb_det.IdProducto = in_Producto.IdProducto INNER JOIN
                         fa_TipoNota ON fa_notaCreDeb.IdTipoNota = fa_TipoNota.IdTipoNota INNER JOIN
                         fa_Vendedor ON fa_notaCreDeb.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_notaCreDeb.IdVendedor = fa_Vendedor.IdVendedor AND 
                         fa_notaCreDeb.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_notaCreDeb.IdVendedor = fa_Vendedor.IdVendedor AND 
                         fa_notaCreDeb.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_notaCreDeb.IdVendedor = fa_Vendedor.IdVendedor ON 
                         Grafinpren.fa_notaCreDeb_graf.IdEmpresa = fa_notaCreDeb.IdEmpresa AND Grafinpren.fa_notaCreDeb_graf.IdSucursal = fa_notaCreDeb.IdSucursal AND 
                         Grafinpren.fa_notaCreDeb_graf.IdBodega = fa_notaCreDeb.IdBodega AND Grafinpren.fa_notaCreDeb_graf.IdNota = fa_notaCreDeb.IdNota LEFT OUTER JOIN
                         vwin_Cate_Lin_Grup_SubGrup ON vwin_Cate_Lin_Grup_SubGrup.IdEmpresa = in_Producto.IdEmpresa AND 
                         vwin_Cate_Lin_Grup_SubGrup.IdCategoria = in_Producto.IdCategoria AND vwin_Cate_Lin_Grup_SubGrup.IdSubgrupo = in_Producto.IdSubGrupo