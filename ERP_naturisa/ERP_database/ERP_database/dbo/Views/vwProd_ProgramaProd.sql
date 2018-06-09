CREATE VIEW [dbo].[vwProd_ProgramaProd]
AS
SELECT     dbo.prod_ProgramaProd.IdEmpresa, dbo.prod_ProgramaProd.IdProgramaProd, dbo.prod_ProgramaProd.IdTurno, dbo.prod_ProgramaProd.Fecha, 
                      dbo.prod_ProgramaProd.IdProducto, dbo.prod_ProgramaProd.IdCategoria, dbo.prod_ProgramaProd.Unidad, dbo.prod_ProgramaProd.Peso, 
                      dbo.prod_ProgramaProd.Toneladas, dbo.prod_ProgramaProd.Pedidos, dbo.prod_ProgramaProd.Estado, dbo.prod_Turno.Descripcion, dbo.in_Producto.pr_codigo, 
                      dbo.in_Producto.pr_descripcion
FROM         dbo.prod_ProgramaProd INNER JOIN
                      dbo.in_Producto ON dbo.prod_ProgramaProd.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.prod_ProgramaProd.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.prod_Turno ON dbo.prod_ProgramaProd.IdTurno = dbo.prod_Turno.IdTurno AND dbo.prod_ProgramaProd.IdEmpresa = dbo.prod_Turno.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_ProgramaProd';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "prod_ProgramaProd"
            Begin Extent = 
               Top = 16
               Left = 19
               Bottom = 135
               Right = 186
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 46
               Left = 450
               Bottom = 165
               Right = 650
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "prod_Turno"
            Begin Extent = 
               Top = 0
               Left = 262
               Bottom = 119
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_ProgramaProd';

