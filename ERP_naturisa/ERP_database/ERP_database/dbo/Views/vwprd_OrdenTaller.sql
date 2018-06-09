CREATE VIEW dbo.vwprd_OrdenTaller
AS
SELECT     A.IdEmpresa, A.IdSucursal, A.IdOrdenTaller, A.CodObra, A.NumeroOT, A.IdProducto, A.CantidadPieza, A.TotalPeso, A.Estado, SUC.Su_Descripcion, A.Observacion, 
                      A.Codigo, A.PesoUnitaro, A.FechaReg AS ot_FechaReg, P.pr_descripcion, dbo.prd_Obra.Descripcion AS ob_descripcion, dbo.in_categorias.ca_Categoria, A.IdCliente, 
                      A.IdListadoDiseno, Edehsa.in_Producto_Dimensiones.longitud AS longitudProducto, A.LongitudUnitaria, A.TotalLongitud, 
                      Edehsa.com_ListadoDiseno.lm_Observacion
FROM         dbo.prd_Orden_Taller AS A INNER JOIN
                      dbo.tb_sucursal AS SUC ON SUC.IdEmpresa = A.IdEmpresa AND SUC.IdSucursal = A.IdSucursal INNER JOIN
                      dbo.prd_Obra ON A.IdEmpresa = dbo.prd_Obra.IdEmpresa AND A.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.in_Producto AS P ON A.IdProducto = P.IdProducto AND A.IdEmpresa = P.IdEmpresa INNER JOIN
                      dbo.in_categorias ON P.IdEmpresa = dbo.in_categorias.IdEmpresa AND P.IdCategoria = dbo.in_categorias.IdCategoria INNER JOIN
                      Edehsa.com_ListadoDiseno ON A.IdEmpresa = Edehsa.com_ListadoDiseno.IdEmpresa AND A.IdListadoDiseno = Edehsa.com_ListadoDiseno.IdListadoDiseno AND 
                      A.CodObra = Edehsa.com_ListadoDiseno.CodObra LEFT OUTER JOIN
                      Edehsa.in_Producto_Dimensiones ON P.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND P.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenTaller';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
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
         Width = 1200
         Width = 1710
         Width = 1545
         Width = 1200
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
         GroupBy = 1356
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenTaller';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[68] 4[4] 2[4] 3) )"
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
         Left = -289
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 52
               Left = 289
               Bottom = 397
               Right = 490
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "SUC"
            Begin Extent = 
               Top = 0
               Left = 10
               Bottom = 242
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 15
               Left = 529
               Bottom = 363
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "P"
            Begin Extent = 
               Top = 4
               Left = 725
               Bottom = 317
               Right = 947
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_categorias"
            Begin Extent = 
               Top = 3
               Left = 1037
               Bottom = 122
               Right = 1259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 154
               Left = 1070
               Bottom = 340
               Right = 1314
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ListadoDiseno (Edehsa)"
            Begin Extent = 
               Top = 246
               Left = 25
               Bottom = 378
               Right = 214
           ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenTaller';

