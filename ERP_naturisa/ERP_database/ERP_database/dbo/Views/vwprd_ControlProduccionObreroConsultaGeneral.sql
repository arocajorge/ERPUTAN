CREATE VIEW [dbo].[vwprd_ControlProduccionObreroConsultaGeneral]
AS
SELECT     dbo.prd_ControlProduccion_Obrero.*, dbo.tb_sucursal.Su_Descripcion, dbo.prd_Obra.Descripcion AS Descripcion_Obra, 
                      dbo.prd_Orden_Taller.Codigo AS OrdenTaller
FROM         dbo.prd_ControlProduccion_Obrero INNER JOIN
                      dbo.tb_sucursal ON dbo.prd_ControlProduccion_Obrero.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      dbo.prd_ControlProduccion_Obrero.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.prd_Obra ON dbo.prd_ControlProduccion_Obrero.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                      dbo.prd_ControlProduccion_Obrero.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.prd_Orden_Taller ON dbo.prd_ControlProduccion_Obrero.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                      dbo.prd_ControlProduccion_Obrero.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                      dbo.prd_ControlProduccion_Obrero.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccionObreroConsultaGeneral';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     NewValue = 1170
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccionObreroConsultaGeneral';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[9] 2[4] 3) )"
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
         Begin Table = "prd_ControlProduccion_Obrero"
            Begin Extent = 
               Top = 9
               Left = 522
               Bottom = 270
               Right = 768
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 136
               Left = 118
               Bottom = 255
               Right = 332
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 27
               Left = 906
               Bottom = 208
               Right = 1066
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 0
               Left = 105
               Bottom = 119
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
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
         Width = 4290
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1305
         Alias = 900
         Table = 2460
         Output = 720
         Append = 1400
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccionObreroConsultaGeneral';

