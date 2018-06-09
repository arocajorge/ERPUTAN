CREATE VIEW dbo.vwcom_ListadoMateriales_Detalle
AS
SELECT     dbo.com_ListadoMateriales_Det.IdEmpresa, dbo.com_ListadoMateriales_Det.CodObra, dbo.com_ListadoMateriales_Det.IdOrdenTaller, 
                      dbo.com_ListadoMateriales_Det.IdListadoMateriales, dbo.com_ListadoMateriales_Det.IdDetalle, dbo.com_ListadoMateriales_Det.IdProducto, 
                      dbo.com_ListadoMateriales_Det.Unidades, dbo.com_ListadoMateriales_Det.Det_Kg, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, 
                      dbo.com_ListadoMateriales_Det.IdEstadoAprob, dbo.vwcom_ListadoMateriales.FechaReg, dbo.vwcom_ListadoMateriales.Estado, 
                      dbo.vwcom_ListadoMateriales.lm_Observacion, dbo.vwcom_ListadoMateriales.Su_Descripcion, dbo.in_Producto.IdCategoria, 
                      Edehsa.in_Producto_Dimensiones.longitud, dbo.com_ListadoMateriales_Det.pr_largo, dbo.com_ListadoMateriales_Det.largo_total, 
                      dbo.com_ListadoMateriales_Det.largo_restante, dbo.com_ListadoMateriales_Det.largo_pieza_entera, dbo.com_ListadoMateriales_Det.cantidad_pieza_entera, 
                      dbo.com_ListadoMateriales_Det.largo_pieza_complementaria, dbo.com_ListadoMateriales_Det.cantidad_pieza_complementaria, 
                      dbo.com_ListadoMateriales_Det.cantidad_total_pieza_complementaria, dbo.com_ListadoMateriales_Det.largo_despunte1, 
                      dbo.com_ListadoMateriales_Det.es_despunte_usable1, dbo.com_ListadoMateriales_Det.cantidad_despunte1, dbo.com_ListadoMateriales_Det.largo_despunte2, 
                      dbo.com_ListadoMateriales_Det.cantidad_despunte2, dbo.com_ListadoMateriales_Det.es_despunte_usable2, Edehsa.in_Producto_Dimensiones.espesor, 
                      Edehsa.in_Producto_Dimensiones.ancho, dbo.vwcom_ListadoMateriales.IdSucursal, dbo.in_ProductoTipo.IdProductoTipo, dbo.in_ProductoTipo.EsMateriaPrima, 
                      dbo.in_ProductoTipo.tp_descripcion
FROM         dbo.com_ListadoMateriales_Det INNER JOIN
                      dbo.in_Producto ON dbo.com_ListadoMateriales_Det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.com_ListadoMateriales_Det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.vwcom_ListadoMateriales ON dbo.com_ListadoMateriales_Det.IdEmpresa = dbo.vwcom_ListadoMateriales.IdEmpresa AND 
                      dbo.com_ListadoMateriales_Det.IdListadoMateriales = dbo.vwcom_ListadoMateriales.IdListadoMateriales AND 
                      dbo.com_ListadoMateriales_Det.CodObra = dbo.vwcom_ListadoMateriales.CodObra INNER JOIN
                      Edehsa.in_Producto_Dimensiones ON dbo.in_Producto.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND 
                      dbo.in_Producto.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto INNER JOIN
                      dbo.in_ProductoTipo ON dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo AND
                       dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[9] 2[20] 3) )"
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
         Begin Table = "com_ListadoMateriales_Det"
            Begin Extent = 
               Top = 6
               Left = 10
               Bottom = 399
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 0
               Left = 492
               Bottom = 281
               Right = 698
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcom_ListadoMateriales"
            Begin Extent = 
               Top = 283
               Left = 505
               Bottom = 528
               Right = 773
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 4
               Left = 983
               Bottom = 273
               Right = 1333
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_ProductoTipo"
            Begin Extent = 
               Top = 79
               Left = 786
               Bottom = 308
               Right = 975
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
      Begin ColumnWidths = 38
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_Detalle';

