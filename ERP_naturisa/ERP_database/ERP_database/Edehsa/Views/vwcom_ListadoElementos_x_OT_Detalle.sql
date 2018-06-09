CREATE VIEW Edehsa.vwcom_ListadoElementos_x_OT_Detalle
AS
SELECT     Edehsa.com_ListadoElementos_x_OT_Det.IdEmpresa, Edehsa.com_ListadoElementos_x_OT_Det.CodObra, Edehsa.com_ListadoElementos_x_OT_Det.IdOrdenTaller, 
                      Edehsa.com_ListadoElementos_x_OT_Det.IdListadoElementos_x_OT, Edehsa.com_ListadoElementos_x_OT_Det.IdDetalle, 
                      Edehsa.com_ListadoElementos_x_OT_Det.IdProducto, Edehsa.com_ListadoElementos_x_OT_Det.Unidades, Edehsa.com_ListadoElementos_x_OT_Det.Det_Kg, 
                      dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, Edehsa.com_ListadoElementos_x_OT_Det.IdEstadoAprob, 
                      Edehsa.vwcom_ListadoElementos_x_OT.FechaReg, Edehsa.vwcom_ListadoElementos_x_OT.Estado, Edehsa.vwcom_ListadoElementos_x_OT.lm_Observacion, 
                      Edehsa.vwcom_ListadoElementos_x_OT.IdSucursal, Edehsa.vwcom_ListadoElementos_x_OT.Su_Descripcion, dbo.in_Producto.IdCategoria, 
                      Edehsa.in_Producto_Dimensiones.longitud, Edehsa.com_ListadoElementos_x_OT_Det.pr_largo, Edehsa.com_ListadoElementos_x_OT_Det.largo_total, 
                      Edehsa.com_ListadoElementos_x_OT_Det.largo_restante, Edehsa.com_ListadoElementos_x_OT_Det.largo_pieza_entera, 
                      Edehsa.com_ListadoElementos_x_OT_Det.cantidad_pieza_entera, Edehsa.com_ListadoElementos_x_OT_Det.largo_pieza_complementaria, 
                      Edehsa.com_ListadoElementos_x_OT_Det.cantidad_pieza_complementaria, Edehsa.com_ListadoElementos_x_OT_Det.cantidad_total_pieza_complementaria, 
                      Edehsa.com_ListadoElementos_x_OT_Det.largo_despunte1, Edehsa.com_ListadoElementos_x_OT_Det.es_despunte_usable1, 
                      Edehsa.com_ListadoElementos_x_OT_Det.cantidad_despunte1, Edehsa.com_ListadoElementos_x_OT_Det.largo_despunte2, 
                      Edehsa.com_ListadoElementos_x_OT_Det.cantidad_despunte2, Edehsa.com_ListadoElementos_x_OT_Det.es_despunte_usable2
FROM         Edehsa.com_ListadoElementos_x_OT_Det INNER JOIN
                      dbo.in_Producto ON Edehsa.com_ListadoElementos_x_OT_Det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      Edehsa.com_ListadoElementos_x_OT_Det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      Edehsa.vwcom_ListadoElementos_x_OT ON Edehsa.com_ListadoElementos_x_OT_Det.IdEmpresa = Edehsa.vwcom_ListadoElementos_x_OT.IdEmpresa AND 
                      Edehsa.com_ListadoElementos_x_OT_Det.IdListadoElementos_x_OT = Edehsa.vwcom_ListadoElementos_x_OT.IdListadoElementos_x_OT AND 
                      Edehsa.com_ListadoElementos_x_OT_Det.CodObra = Edehsa.vwcom_ListadoElementos_x_OT.CodObra AND 
                      Edehsa.com_ListadoElementos_x_OT_Det.IdOrdenTaller = Edehsa.vwcom_ListadoElementos_x_OT.IdOrdenTaller INNER JOIN
                      Edehsa.in_Producto_Dimensiones ON dbo.in_Producto.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND 
                      dbo.in_Producto.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT_Detalle';


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
         Begin Table = "com_ListadoElementos_x_OT_Det (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 1
               Bottom = 108
               Right = 309
            End
            DisplayFlags = 280
            TopColumn = 19
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 6
               Left = 337
               Bottom = 114
               Right = 545
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 110
               Left = 0
               Bottom = 218
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "vwcom_ListadoElementos_x_OT (Edehsa)"
            Begin Extent = 
               Top = 6
               Left = 583
               Bottom = 207
               Right = 897
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3675
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType =', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT_Detalle';

