CREATE VIEW [dbo].[vwprd_MovPteGrua]
AS
SELECT        OB.Descripcion AS ob_descripcion, C.Nombre AS pp_descripcion, ETPOR.NombreEtapa AS EtapaOrigen, ETPDes.NombreEtapa AS EtapaDestino, 
                         ETPOR.Posicion AS etOriPosicion, ETPDes.Posicion AS etDestPosicion, ETPDes.PorcentajeEtapa AS EtDestPorc, ETPOR.PorcentajeEtapa AS EtOriPorc, 
                         OT.IdProducto, OT.CantidadPieza, OT.TotalPeso, OT.Codigo AS ot_desc, OT.pr_descripcion, OT.CodObra
FROM            dbo.prd_PteGrua CROSS JOIN
                         dbo.prd_EtapaProduccion AS ETPOR CROSS JOIN
                         dbo.prd_Obra AS OB INNER JOIN
                         dbo.vwprd_OrdenTaller AS OT ON OB.IdEmpresa = OT.IdEmpresa AND OB.CodObra = OT.CodObra CROSS JOIN
                         dbo.prd_EtapaProduccion AS ETPDes CROSS JOIN
                         dbo.prd_ProcesoProductivo AS C
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_MovPteGrua';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'0
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2310
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_MovPteGrua';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[4] 2[18] 3) )"
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
         Begin Table = "ETPOR"
            Begin Extent = 
               Top = 88
               Left = 388
               Bottom = 207
               Right = 576
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 124
               Left = 25
               Bottom = 243
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ETPDes"
            Begin Extent = 
               Top = 0
               Left = 48
               Bottom = 119
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OT"
            Begin Extent = 
               Top = 19
               Left = 727
               Bottom = 138
               Right = 888
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OB"
            Begin Extent = 
               Top = 39
               Left = 1115
               Bottom = 158
               Right = 1275
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_PteGrua"
            Begin Extent = 
               Top = 78
               Left = 511
               Bottom = 333
               Right = 681
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
      Begin ColumnWidths = 37
         Width = 284
         Width = 1500
         Width = 1500
         Width = 150', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_MovPteGrua';

