CREATE VIEW dbo.vwcp_orden_giro_x_Pagos_saldo
AS
SELECT        A.IdEmpresa, A.IdCbteCble_Ogiro, A.IdTipoCbte_Ogiro, A.IdOrden_giro_Tipo, A.IdProveedor, A.co_fechaOg, A.co_serie, A.co_factura, A.co_FechaFactura, A.co_FechaFactura_vct, A.co_plazo, A.co_observacion, A.co_subtotal_iva, 
                         A.co_subtotal_siniva, A.co_baseImponible, A.co_Por_iva, A.co_valoriva, A.IdCod_ICE, A.co_Ice_base, A.co_Ice_por, A.co_Ice_valor, A.co_Serv_por, A.co_Serv_valor, A.co_OtroValor_a_descontar, A.co_OtroValor_a_Sumar, 
                         A.co_BaseSeguro, A.co_total, A.co_valorpagar, A.co_valorpagar - ISNULL(pag.TotalPagado, 0) AS SaldoOG, pag.TotalPagado, A.co_vaCoa, A.IdIden_credito, A.IdCod_101, A.IdTipoServicio, A.IdCtaCble_Gasto, A.IdCtaCble_IVA, 
                         A.IdUsuario, A.Fecha_Transac, A.Estado, A.IdUsuarioUltMod, A.Fecha_UltMod, A.IdUsuarioUltAnu, A.MotivoAnu, A.nom_pc, A.ip, A.Fecha_UltAnu, A.co_retencionManual, A.IdCbteCble_Anulacion, A.IdTipoCbte_Anulacion, 
                         em.em_nombre, A.IdCentroCosto, cbtp.tc_TipoCbte, A.IdSucursal, su.Su_Descripcion AS Sucursal, A.IdTipoFlujo, flu.Descricion AS TipoFlujo, A.PagoLocExt, A.PaisPago, A.PagoSujetoRetencion, A.ConvenioTributacion, 
                         A.co_FechaContabilizacion, A.BseImpNoObjDeIva, A.fecha_autorizacion, A.Num_Autorizacion, A.Num_Autorizacion_Imprenta, dbo.cp_retencion.IdEmpresa AS IdEmpresa_ret, dbo.cp_retencion.IdRetencion, 
                         dbo.cp_retencion.serie1 + '-' + dbo.cp_retencion.serie2 AS re_serie, dbo.cp_retencion.NumRetencion AS re_NumRetencion, dbo.cp_retencion.re_EstaImpresa, A.co_propina, A.co_IRBPNR, 
                         CASE WHEN (A.co_valorpagar - ISNULL(pag.TotalPagado, 0)) <= 0 THEN 'PAGADA' WHEN (A.co_valorpagar - ISNULL(pag.TotalPagado, 0)) > 0 THEN 'PENDIENTE' END AS Estado_Cancelacion, 
                         ISNULL(dbo.vwCP_Retencion_Valor_total.Total_Retencion, 0) AS Total_Retencion, A.cp_es_comprobante_electronico, A.Tipodoc_a_Modificar, A.estable_a_Modificar, A.ptoEmi_a_Modificar, A.num_docu_Modificar, 
                         A.aut_doc_Modificar, CASE WHEN cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa_Ogiro IS NULL THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS Tiene_ingresos, A.IdTipoMovi, CASE WHEN conci_caj.En_conci IS NULL 
                         THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS En_conciliacion
FROM            dbo.vwcp_orden_giro_total_pagodo AS pag RIGHT OUTER JOIN
                         dbo.cp_orden_giro AS A INNER JOIN
                         dbo.tb_empresa AS em ON A.IdEmpresa = em.IdEmpresa INNER JOIN
                         dbo.ct_cbtecble_tipo AS cbtp ON A.IdTipoCbte_Ogiro = cbtp.IdTipoCbte LEFT OUTER JOIN
                         dbo.cp_Aprobacion_Ing_Bod_x_OC ON A.IdEmpresa = dbo.cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa_Ogiro AND A.IdCbteCble_Ogiro = dbo.cp_Aprobacion_Ing_Bod_x_OC.IdCbteCble_Ogiro AND 
                         A.IdTipoCbte_Ogiro = dbo.cp_Aprobacion_Ing_Bod_x_OC.IdTipoCbte_Ogiro ON pag.IdEmpresa_cxp = A.IdEmpresa AND pag.IdCbteCble_cxp = A.IdCbteCble_Ogiro AND pag.IdTipoCbte_cxp = A.IdTipoCbte_Ogiro LEFT OUTER JOIN
                         dbo.vwCP_Retencion_Valor_total INNER JOIN
                         dbo.cp_retencion ON dbo.vwCP_Retencion_Valor_total.IdEmpresa = dbo.cp_retencion.IdEmpresa AND dbo.vwCP_Retencion_Valor_total.IdRetencion = dbo.cp_retencion.IdRetencion ON 
                         A.IdEmpresa = dbo.cp_retencion.IdEmpresa_Ogiro AND A.IdCbteCble_Ogiro = dbo.cp_retencion.IdCbteCble_Ogiro AND A.IdTipoCbte_Ogiro = dbo.cp_retencion.IdTipoCbte_Ogiro LEFT OUTER JOIN
                         dbo.ba_TipoFlujo AS flu ON A.IdEmpresa = flu.IdEmpresa AND A.IdTipoFlujo = flu.IdTipoFlujo LEFT OUTER JOIN
                         dbo.tb_sucursal AS su ON A.IdSucursal = su.IdSucursal AND A.IdEmpresa = su.IdEmpresa LEFT OUTER JOIN
                             (SELECT        IdEmpresa_OGiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro, 1 AS En_conci
                               FROM            dbo.cp_conciliacion_Caja_det
                               GROUP BY IdEmpresa_OGiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro) AS conci_caj ON A.IdEmpresa = conci_caj.IdEmpresa_OGiro AND conci_caj.IdTipoCbte_Ogiro = A.IdTipoCbte_Ogiro AND 
                         conci_caj.IdCbteCble_Ogiro = A.IdCbteCble_Ogiro
GROUP BY A.IdEmpresa, A.IdCbteCble_Ogiro, A.IdTipoCbte_Ogiro, A.IdOrden_giro_Tipo, A.IdProveedor, A.co_fechaOg, A.co_serie, A.co_factura, A.co_FechaFactura, A.co_FechaFactura_vct, A.co_plazo, A.co_observacion, A.co_subtotal_iva, 
                         A.co_subtotal_siniva, A.co_baseImponible, A.co_Por_iva, A.co_valoriva, A.IdCod_ICE, A.co_Ice_base, A.co_Ice_por, A.co_Ice_valor, A.co_Serv_por, A.co_Serv_valor, A.co_OtroValor_a_descontar, A.co_OtroValor_a_Sumar, 
                         A.co_BaseSeguro, A.co_total, A.co_valorpagar, A.co_vaCoa, A.IdIden_credito, A.IdCod_101, A.IdTipoServicio, A.IdCtaCble_Gasto, A.IdCtaCble_IVA, A.IdUsuario, A.Fecha_Transac, A.Estado, A.IdUsuarioUltMod, A.Fecha_UltMod, 
                         A.IdUsuarioUltAnu, A.MotivoAnu, A.nom_pc, A.ip, A.Fecha_UltAnu, A.co_retencionManual, A.IdCbteCble_Anulacion, A.IdTipoCbte_Anulacion, em.em_nombre, A.IdCentroCosto, cbtp.tc_TipoCbte, A.IdSucursal, su.Su_Descripcion, 
                         A.IdTipoFlujo, flu.Descricion, A.PagoLocExt, A.PaisPago, A.PagoSujetoRetencion, A.ConvenioTributacion, A.co_FechaContabilizacion, A.BseImpNoObjDeIva, A.fecha_autorizacion, A.Num_Autorizacion, 
                         A.Num_Autorizacion_Imprenta, dbo.cp_retencion.IdEmpresa, dbo.cp_retencion.IdRetencion, dbo.cp_retencion.serie1 + '-' + dbo.cp_retencion.serie2, dbo.cp_retencion.NumRetencion, dbo.cp_retencion.re_EstaImpresa, 
                         A.co_propina, A.co_IRBPNR, pag.TotalPagado, dbo.vwCP_Retencion_Valor_total.Total_Retencion, A.cp_es_comprobante_electronico, A.Tipodoc_a_Modificar, A.estable_a_Modificar, A.ptoEmi_a_Modificar, 
                         A.num_docu_Modificar, A.aut_doc_Modificar, dbo.cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa_Ogiro, A.IdTipoMovi, conci_caj.En_conci
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_orden_giro_x_Pagos_saldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'        DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "flu"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "su"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "conci_caj"
            Begin Extent = 
               Top = 432
               Left = 587
               Bottom = 562
               Right = 812
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_orden_giro_x_Pagos_saldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[33] 2[39] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[49] 4) )"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -384
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pag"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 313
            End
            DisplayFlags = 280
            TopColumn = 59
         End
         Begin Table = "em"
            Begin Extent = 
               Top = 297
               Left = 457
               Bottom = 427
               Right = 692
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cbtp"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_Aprobacion_Ing_Bod_x_OC"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 283
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwCP_Retencion_Valor_total"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_retencion"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 263
            End
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_orden_giro_x_Pagos_saldo';

