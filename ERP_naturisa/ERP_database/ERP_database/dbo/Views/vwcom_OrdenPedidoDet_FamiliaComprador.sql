CREATE VIEW dbo.vwcom_OrdenPedidoDet_FamiliaComprador
AS
SELECT dbo.com_OrdenPedidoDet.IdEmpresa, dbo.com_OrdenPedidoDet.IdOrdenPedido, dbo.com_OrdenPedidoDet.Secuencia, dbo.in_Familia.fa_Descripcion AS Familia, dbo.com_comprador.Descripcion AS Comprador, 
                  dbo.in_Producto.pr_descripcion AS Producto
FROM     dbo.com_OrdenPedidoDet INNER JOIN
                  dbo.in_Producto ON dbo.com_OrdenPedidoDet.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_OrdenPedidoDet.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                  dbo.in_Familia ON dbo.in_Producto.IdEmpresa = dbo.in_Familia.IdEmpresa AND dbo.in_Producto.IdFamilia = dbo.in_Familia.IdFamilia INNER JOIN
                  dbo.com_comprador_familia ON dbo.in_Producto.IdEmpresa = dbo.com_comprador_familia.IdEmpresa AND dbo.in_Producto.IdFamilia = dbo.com_comprador_familia.IdFamilia INNER JOIN
                  dbo.com_comprador ON dbo.com_comprador_familia.IdEmpresa = dbo.com_comprador.IdEmpresa AND dbo.com_comprador_familia.IdComprador = dbo.com_comprador.IdComprador
WHERE  (dbo.com_OrdenPedidoDet.opd_EstadoProceso <> 'RA')
GROUP BY dbo.com_OrdenPedidoDet.IdEmpresa, dbo.com_OrdenPedidoDet.IdOrdenPedido, dbo.com_OrdenPedidoDet.Secuencia, dbo.in_Familia.fa_Descripcion, dbo.com_comprador.Descripcion, dbo.in_Producto.pr_descripcion
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_FamiliaComprador';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_FamiliaComprador';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[25] 2[3] 3) )"
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
         Begin Table = "com_OrdenPedidoDet"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 73
               Left = 608
               Bottom = 236
               Right = 899
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Familia"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador_familia"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 272
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_FamiliaComprador';

