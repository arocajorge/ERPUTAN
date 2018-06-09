--select * from vwct_cbtecble_con_ctacble_acreedora
CREATE view vwct_cbtecble_con_ctacble_acreedora
as 
SELECT        IdEmpresa, IdTipoCbte, IdCbteCble, MAX(IdCtaCble_Acreedora) AS IdCtaCble_Acreedora
FROM            (SELECT        cbte_d.IdEmpresa, cbte_d.IdTipoCbte, cbte_d.IdCbteCble, cbte_d.IdCtaCble AS IdCtaCble_Acreedora
                          FROM            dbo.ct_cbtecble_det AS cbte_d INNER JOIN
                                                    dbo.cp_orden_giro AS OG ON cbte_d.IdEmpresa = OG.IdEmpresa AND cbte_d.IdTipoCbte = OG.IdTipoCbte_Ogiro AND 
                                                    cbte_d.IdCbteCble = OG.IdCbteCble_Ogiro
                          WHERE        (cbte_d.dc_Valor < 0) AND EXISTS
                                                        (SELECT        IdEmpresa
                                                          FROM            dbo.cp_proveedor_clase AS cl_pr
                                                          WHERE        (IdEmpresa = cbte_d.IdEmpresa) AND (IdCtaCble_CXP = cbte_d.IdCtaCble))
                          UNION ALL
                          SELECT        cbte_d.IdEmpresa, cbte_d.IdTipoCbte, cbte_d.IdCbteCble, cbte_d.IdCtaCble AS IdCtaCble_Acreedora
                          FROM            dbo.cp_nota_DebCre INNER JOIN
                                                   dbo.ct_cbtecble_det AS cbte_d ON dbo.cp_nota_DebCre.IdEmpresa = cbte_d.IdEmpresa AND 
                                                   dbo.cp_nota_DebCre.IdTipoCbte_Nota = cbte_d.IdTipoCbte AND dbo.cp_nota_DebCre.IdCbteCble_Nota = cbte_d.IdCbteCble
                          WHERE        (cbte_d.dc_Valor < 0) AND (dbo.cp_nota_DebCre.DebCre = 'D') AND EXISTS
                                                       (SELECT        IdEmpresa
                                                         FROM            dbo.cp_proveedor_clase AS cl_pr
                                                         WHERE        (IdEmpresa = cbte_d.IdEmpresa) AND (IdCtaCble_CXP = cbte_d.IdCtaCble))
                          UNION ALL
                          SELECT        A.IdEmpresa, A.IdTipoCbte, A.IdCbteCble, A.IdCtaCble AS IdCtaCble_Acreedora
                          FROM            dbo.cp_orden_pago_det INNER JOIN
                                                   dbo.cp_orden_pago ON dbo.cp_orden_pago_det.IdEmpresa = dbo.cp_orden_pago.IdEmpresa AND 
                                                   dbo.cp_orden_pago_det.IdOrdenPago = dbo.cp_orden_pago.IdOrdenPago INNER JOIN
                                                   dbo.ct_cbtecble_det AS A ON dbo.cp_orden_pago_det.IdEmpresa_cxp = A.IdEmpresa AND dbo.cp_orden_pago_det.IdTipoCbte_cxp = A.IdTipoCbte AND 
                                                   dbo.cp_orden_pago_det.IdCbteCble_cxp = A.IdCbteCble INNER JOIN
                                                   dbo.vwtb_persona_beneficiario ON dbo.cp_orden_pago.IdEmpresa = dbo.vwtb_persona_beneficiario.IdEmpresa AND 
                                                   dbo.cp_orden_pago.IdTipo_Persona = dbo.vwtb_persona_beneficiario.IdTipo_Persona AND 
                                                   dbo.cp_orden_pago.IdPersona = dbo.vwtb_persona_beneficiario.IdPersona AND 
                                                   dbo.cp_orden_pago.IdEntidad = dbo.vwtb_persona_beneficiario.IdEntidad AND A.IdCtaCble = dbo.vwtb_persona_beneficiario.IdCtaCble
                          WHERE        (A.dc_Valor < 0) AND (dbo.cp_orden_pago.IdTipo_op <> 'FACT_PROVEE')
						  /*
                          UNION ALL
                          SELECT        IdEmpresa, IdTipoCbte, IdCbteCble, MAX(IdCtaCble_Acreedora) AS IdCtaCble_Acreedora
                          FROM            (SELECT        IdEmpresa, IdTipoCbte, IdCbteCble, IdCtaCble AS IdCtaCble_Acreedora
                                                    FROM            dbo.ct_cbtecble_det AS det_cbte_cble
                                                    WHERE        (dc_Valor < 0) AND (NOT EXISTS
                                                                                  (SELECT        IdEmpresa
                                                                                    FROM            dbo.cp_orden_giro AS OG
                                                                                    WHERE        (IdEmpresa = det_cbte_cble.IdEmpresa) AND (IdTipoCbte_Ogiro = det_cbte_cble.IdTipoCbte) AND 
                                                                                                              (IdCbteCble_Ogiro = det_cbte_cble.IdCbteCble))) AND (NOT EXISTS
                                                                                  (SELECT        IdEmpresa
                                                                                    FROM            dbo.cp_nota_DebCre AS ND
                                                                                    WHERE        (IdEmpresa = det_cbte_cble.IdEmpresa) AND (IdTipoCbte_Nota = det_cbte_cble.IdTipoCbte) AND 
                                                                                                              (IdCbteCble_Nota = det_cbte_cble.IdCbteCble))) AND (NOT EXISTS
                                                                                  (SELECT        IdEmpresa
                                                                                    FROM            (SELECT        dbo.cp_orden_pago_det.IdEmpresa, dbo.cp_orden_pago_det.IdOrdenPago, dbo.cp_orden_pago_det.Secuencia, 
                                                                                                                                        dbo.cp_orden_pago_det.IdEmpresa_cxp, dbo.cp_orden_pago_det.IdCbteCble_cxp, 
                                                                                                                                        dbo.cp_orden_pago_det.IdTipoCbte_cxp, dbo.cp_orden_pago_det.Valor_a_pagar, 
                                                                                                                                        dbo.cp_orden_pago_det.Referencia, dbo.cp_orden_pago_det.IdFormaPago, dbo.cp_orden_pago_det.Fecha_Pago, 
                                                                                                                                        dbo.cp_orden_pago_det.IdEstadoAprobacion, dbo.cp_orden_pago_det.IdBanco, 
                                                                                                                                        dbo.cp_orden_pago_det.IdUsuario_Aprobacion, dbo.cp_orden_pago_det.fecha_hora_Aproba, 
                                                                                                                                        dbo.cp_orden_pago_det.Motivo_aproba
                                                                                                              FROM            dbo.cp_orden_pago_det INNER JOIN
                                                                                                                                        dbo.cp_orden_pago ON dbo.cp_orden_pago_det.IdEmpresa = dbo.cp_orden_pago.IdEmpresa AND 
                                                                                                                                        dbo.cp_orden_pago_det.IdOrdenPago = dbo.cp_orden_pago.IdOrdenPago INNER JOIN
                                                                                                                                        dbo.ct_cbtecble_det AS A ON dbo.cp_orden_pago_det.IdEmpresa_cxp = A.IdEmpresa AND 
                                                                                                                                        dbo.cp_orden_pago_det.IdTipoCbte_cxp = A.IdTipoCbte AND 
                                                                                                                                        dbo.cp_orden_pago_det.IdCbteCble_cxp = A.IdCbteCble INNER JOIN
                                                                                                                                        dbo.vwtb_persona_beneficiario ON 
                                                                                                                                        dbo.cp_orden_pago.IdEmpresa = dbo.vwtb_persona_beneficiario.IdEmpresa AND 
                                                                                                                                        dbo.cp_orden_pago.IdTipo_Persona = dbo.vwtb_persona_beneficiario.IdTipo_Persona AND 
                                                                                                                                        dbo.cp_orden_pago.IdPersona = dbo.vwtb_persona_beneficiario.IdPersona AND 
                                                                                                                                        dbo.cp_orden_pago.IdEntidad = dbo.vwtb_persona_beneficiario.IdEntidad AND 
                                                                                                                                        A.IdCtaCble = dbo.vwtb_persona_beneficiario.IdCtaCble
                                                                                                              WHERE        (A.dc_Valor < 0) AND (dbo.cp_orden_pago.IdTipo_op <> 'FACT_PROVEE')) AS Diarios_x_OP
                                                                                    WHERE        (IdEmpresa = det_cbte_cble.IdEmpresa) AND (IdTipoCbte_cxp = det_cbte_cble.IdTipoCbte) AND 
                                                                                                              (IdCbteCble_cxp = det_cbte_cble.IdCbteCble)))) AS A*/
                          --GROUP BY IdEmpresa, IdTipoCbte, IdCbteCble) 
						  )AS Querry
GROUP BY IdEmpresa, IdTipoCbte, IdCbteCble