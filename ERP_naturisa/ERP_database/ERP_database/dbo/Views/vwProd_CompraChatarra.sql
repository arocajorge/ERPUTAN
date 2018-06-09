CREATE VIEW [dbo].[vwProd_CompraChatarra]
AS
SELECT     dbo.prod_ChatarraTipo_CusTalme.Descripcion AS TipoChatarra, dbo.cp_proveedor.pr_nombre AS Proveedor, cp_proveedor_1.pr_nombre AS Presupuesto, 
                      dbo.prod_CompraChatarra_CusTalme.*
FROM         dbo.prod_CompraChatarra_CusTalme INNER JOIN
                      dbo.prod_ChatarraTipo_CusTalme ON dbo.prod_CompraChatarra_CusTalme.IdEmpresa = dbo.prod_ChatarraTipo_CusTalme.IdEmpresa AND 
                      dbo.prod_CompraChatarra_CusTalme.IdTipoChatarra = dbo.prod_ChatarraTipo_CusTalme.IdTipoChatarra INNER JOIN
                      dbo.cp_proveedor ON dbo.prod_CompraChatarra_CusTalme.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                      dbo.prod_CompraChatarra_CusTalme.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                      dbo.cp_proveedor AS cp_proveedor_1 ON dbo.prod_CompraChatarra_CusTalme.IdEmpresa = cp_proveedor_1.IdEmpresa AND 
                      dbo.prod_CompraChatarra_CusTalme.IdProveedor_Presu = cp_proveedor_1.IdProveedor
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_CompraChatarra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'lumn = 1440
         Alias = 1965
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_CompraChatarra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[23] 2[5] 3) )"
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
         Begin Table = "prod_ChatarraTipo_CusTalme"
            Begin Extent = 
               Top = 15
               Left = 46
               Bottom = 194
               Right = 196
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 0
               Left = 949
               Bottom = 182
               Right = 1159
            End
            DisplayFlags = 280
            TopColumn = 20
         End
         Begin Table = "cp_proveedor_1"
            Begin Extent = 
               Top = 84
               Left = 719
               Bottom = 203
               Right = 929
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "prod_CompraChatarra_CusTalme"
            Begin Extent = 
               Top = 5
               Left = 357
               Bottom = 156
               Right = 543
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
      Begin ColumnWidths = 20
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
         Co', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_CompraChatarra';

