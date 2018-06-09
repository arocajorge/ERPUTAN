


create view [Grafinpren].[vwfa_NotaCre_graf]
as

SELECT        dbo.fa_notaCreDeb.IdEmpresa, dbo.fa_notaCreDeb.IdSucursal, dbo.fa_notaCreDeb.IdBodega, dbo.fa_notaCreDeb.IdNota, Grafinpren.fa_notaCreDeb_graf.num_op, 
                         Grafinpren.fa_notaCreDeb_graf.fecha_op, Grafinpren.fa_notaCreDeb_graf.num_cotizacion, Grafinpren.fa_notaCreDeb_graf.fecha_cotizacion, 
                         Grafinpren.fa_notaCreDeb_graf.porc_comision, Grafinpren.fa_Equipo_graf.nom_Equipo, dbo.fa_Vendedor.Ve_Vendedor AS Vendedor, 
                         dbo.fa_notaCreDeb.IdCtaCble_TipoNota, dbo.fa_notaCreDeb.IdCaja, dbo.fa_notaCreDeb.NaturalezaNota, dbo.fa_notaCreDeb.sc_observacion, 
                         dbo.fa_notaCreDeb.IdTipoNota, dbo.fa_notaCreDeb.NumNota_Impresa, dbo.fa_notaCreDeb.Serie2, dbo.fa_notaCreDeb.Serie1, dbo.fa_notaCreDeb.CreDeb, 
                         dbo.fa_notaCreDeb.CodNota, dbo.fa_notaCreDeb.no_fecha, dbo.fa_notaCreDeb.no_fecha_venc, dbo.fa_notaCreDeb.Estado, dbo.fa_notaCreDeb.IdCliente, 
                         dbo.fa_notaCreDeb.IdVendedor, dbo.tb_persona.pe_razonSocial AS Cliente, Grafinpren.fa_notaCreDeb_graf.IdEquipo, dbo.tb_persona.pe_direccion, 
                         dbo.tb_persona.pe_correo, dbo.fa_notaCreDeb.IdEmpresa_fac_doc_mod, dbo.fa_notaCreDeb.IdSucursal_fac_doc_mod, dbo.fa_notaCreDeb.IdBodega_fac_doc_mod, 
                         dbo.fa_notaCreDeb.IdCbteVta_fac_doc_mod, dbo.fa_notaCreDeb.fecha_Ctble, dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total.sc_total
						 ,fa_notaCreDeb.CodDocumentoTipo
FROM            dbo.fa_cliente INNER JOIN
                         dbo.fa_notaCreDeb ON dbo.fa_cliente.IdEmpresa = dbo.fa_notaCreDeb.IdEmpresa AND dbo.fa_cliente.IdCliente = dbo.fa_notaCreDeb.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total ON dbo.fa_notaCreDeb.IdEmpresa = dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total.IdEmpresa AND 
                         dbo.fa_notaCreDeb.IdSucursal = dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total.IdSucursal AND 
                         dbo.fa_notaCreDeb.IdBodega = dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total.IdBodega AND 
                         dbo.fa_notaCreDeb.IdNota = dbo.vwfa_notaCreDeb_det_Subtotal_Iva_total.IdNota LEFT OUTER JOIN
                         dbo.fa_Vendedor ON dbo.fa_notaCreDeb.IdVendedor = dbo.fa_Vendedor.IdVendedor AND 
                         dbo.fa_notaCreDeb.IdEmpresa = dbo.fa_Vendedor.IdEmpresa LEFT OUTER JOIN
                         Grafinpren.fa_notaCreDeb_graf LEFT OUTER JOIN
                         Grafinpren.fa_Equipo_graf ON Grafinpren.fa_notaCreDeb_graf.IdEmpresa = Grafinpren.fa_Equipo_graf.IdEmpresa AND 
                         Grafinpren.fa_notaCreDeb_graf.IdEquipo = Grafinpren.fa_Equipo_graf.IdEquipo ON dbo.fa_notaCreDeb.IdEmpresa = Grafinpren.fa_notaCreDeb_graf.IdEmpresa AND 
                         dbo.fa_notaCreDeb.IdSucursal = Grafinpren.fa_notaCreDeb_graf.IdSucursal AND dbo.fa_notaCreDeb.IdBodega = Grafinpren.fa_notaCreDeb_graf.IdBodega AND 
                         dbo.fa_notaCreDeb.IdNota = Grafinpren.fa_notaCreDeb_graf.IdNota