CREATE VIEW [dbo].[vwBAN_Rpt001]
AS
SELECT        dbo.ba_Cbte_Ban.IdEmpresa, dbo.ba_Cbte_Ban_tipo.CodTipoCbteBan AS Tipo_Cbte, dbo.ba_Cbte_Ban.IdCbteCble AS Num_Cbte, dbo.ba_Banco_Cuenta.IdBanco, 
                         dbo.ba_Banco_Cuenta.ba_descripcion AS Banco, dbo.ba_Cbte_Ban.cb_Fecha AS Fch_Cbte, dbo.ba_Cbte_Ban.cb_Observacion AS Observacion, 
                         dbo.ba_Cbte_Ban.cb_Valor AS Valor, dbo.ba_Cbte_Ban.cb_Cheque AS Cheque, dbo.ba_Cbte_Ban.cb_giradoA AS Chq_Girado_A, dbo.ba_TipoFlujo.IdTipoFlujo, 
                         dbo.ba_TipoFlujo.Descricion AS Tipo_Flujo, dbo.ba_tipo_nota.IdTipoNota, dbo.ba_tipo_nota.Descripcion AS Tipo_Nota, 
                         dbo.ba_Cbte_Ban.PosFechado AS Fch_PostFechado, 
                         CASE dbo.ba_Cbte_Ban.cb_ChequeImpreso WHEN 'S' THEN 'Impreso' ELSE 'No Impreso' END AS Es_Chq_Impreso, 
                         dbo.ba_Cbte_Ban.cb_FechaCheque AS Fch_Chq, dbo.ba_Banco_Cuenta.IdCtaCble AS Cta_Cble_Banco, dbo.tb_Calendario.IdCalendario, 
                         dbo.tb_Calendario.AnioFiscal, '[' + RIGHT(CAST(dbo.tb_Calendario.IdMes AS varchar(6)), 2) + ']-' + LEFT(dbo.tb_Calendario.NombreMes, 3) AS NombreMes, 
                         dbo.tb_Calendario.NombreCortoFecha, dbo.tb_Calendario.IdMes, dbo.ct_plancta.pc_Cuenta, dbo.ba_Cbte_Ban.Estado
FROM            dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo INNER JOIN
                         dbo.ba_Cbte_Ban_tipo ON dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan = dbo.ba_Cbte_Ban_tipo.CodTipoCbteBan INNER JOIN
                         dbo.ba_Cbte_Ban ON dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = dbo.ba_Cbte_Ban.IdEmpresa AND 
                         dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = dbo.ba_Cbte_Ban.IdTipocbte INNER JOIN
                         dbo.ba_Banco_Cuenta ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND 
                         dbo.ba_Cbte_Ban.IdBanco = dbo.ba_Banco_Cuenta.IdBanco INNER JOIN
                         dbo.tb_Calendario ON dbo.ba_Cbte_Ban.cb_Fecha = dbo.tb_Calendario.fecha LEFT OUTER JOIN
                         dbo.ct_plancta ON dbo.ba_Banco_Cuenta.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ba_Banco_Cuenta.IdCtaCble = dbo.ct_plancta.IdCtaCble LEFT OUTER JOIN
                         dbo.ba_tipo_nota ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_tipo_nota.IdEmpresa AND 
                         dbo.ba_Cbte_Ban.IdTipoNota = dbo.ba_tipo_nota.IdTipoNota LEFT OUTER JOIN
                         dbo.ba_TipoFlujo ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_TipoFlujo.IdEmpresa AND dbo.ba_Cbte_Ban.IdTipoFlujo = dbo.ba_TipoFlujo.IdTipoFlujo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBAN_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Cbte_Ban"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 135
               Right = 741
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
      Begin ColumnWidths = 27
         Width = 284
         Width = 1500
         Width = 2745
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1770
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBAN_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[4] 2[34] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
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
         Configuration = "(H (1 [75] 4))"
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Cbte_Ban_tipo"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 135
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Banco_Cuenta"
            Begin Extent = 
               Top = 6
               Left = 779
               Bottom = 135
               Right = 988
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_Calendario"
            Begin Extent = 
               Top = 6
               Left = 1026
               Bottom = 239
               Right = 1235
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_tipo_nota"
            Begin Extent = 
               Top = 138
               Left = 285
               Bottom = 267
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_TipoFlujo"
            Begin Extent = 
               Top = 138
               Left = 532
               Bottom = 267
              ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwBAN_Rpt001';

