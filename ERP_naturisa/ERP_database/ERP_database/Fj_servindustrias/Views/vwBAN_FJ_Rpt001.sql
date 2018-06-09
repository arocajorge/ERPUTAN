CREATE VIEW [Fj_servindustrias].[vwBAN_FJ_Rpt001]
	AS 
	SELECT        dbo.ba_Cbte_Ban.IdEmpresa, dbo.ba_Cbte_Ban.IdCbteCble, dbo.ba_Cbte_Ban.IdTipocbte, dbo.ba_Cbte_Ban.cb_FechaCheque, dbo.ba_Cbte_Ban.cb_Cheque, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ba_Cbte_Ban.cb_Valor, dbo.ba_Catalogo.ca_descripcion, dbo.ba_Cbte_Ban.cb_Fecha, dbo.seg_usuario.Nombre, 
                         dbo.ba_Cbte_Ban.cb_Observacion
FROM            dbo.ba_Cbte_Ban INNER JOIN
                         dbo.tb_persona ON dbo.ba_Cbte_Ban.IdPersona_Girado_a = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ba_Catalogo ON dbo.ba_Cbte_Ban.IdEstado_cheque_cat = dbo.ba_Catalogo.IdCatalogo LEFT OUTER JOIN
                         dbo.seg_usuario ON dbo.ba_Cbte_Ban.IdUsuario = dbo.seg_usuario.IdUsuario