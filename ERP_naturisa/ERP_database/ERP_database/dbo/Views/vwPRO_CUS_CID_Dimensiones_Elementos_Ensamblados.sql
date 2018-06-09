CREATE VIEW dbo.vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados
AS
SELECT dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdSucursal, dbo.prd_Ensamblado_CusCider.CodObra, dbo.prd_Orden_Taller.IdOrdenTaller, dbo.prd_Ensamblado_CusCider.IdEnsamblado, 
                  dbo.prd_Orden_Taller.Codigo AS orden_taller, dbo.prd_Ensamblado_CusCider.CodigoBarra AS cb_producto_final, dbo.prd_Ensamblado_Det_CusCider.CodigoBarra AS cb_producto_elemento, 
                  producto_elemento.IdCategoria, dbo.in_categorias.ca_Categoria, dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto, Edehsa.in_Producto_Dimensiones.ancho, Edehsa.in_Producto_Dimensiones.diametro, 
                  Edehsa.in_Producto_Dimensiones.ceja, Edehsa.in_Producto_Dimensiones.espesor, dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.NumDocumentoRelacionadoProveedor, dbo.in_movi_inve_detalle_x_Producto_CusCider.NumFacturaProveedor
FROM     dbo.prd_Ensamblado_CusCider INNER JOIN
                  dbo.prd_Ensamblado_Det_CusCider ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Ensamblado_Det_CusCider.IdEmpresa AND 
                  dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Ensamblado_Det_CusCider.IdSucursal AND dbo.prd_Ensamblado_CusCider.IdEnsamblado = dbo.prd_Ensamblado_Det_CusCider.IdEnsamblado AND 
                  dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Ensamblado_Det_CusCider.IdEmpresa AND dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Ensamblado_Det_CusCider.IdSucursal AND 
                  dbo.prd_Ensamblado_CusCider.IdEnsamblado = dbo.prd_Ensamblado_Det_CusCider.IdEnsamblado INNER JOIN
                  dbo.prd_Orden_Taller ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                  dbo.prd_Ensamblado_CusCider.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller LEFT OUTER JOIN
                  dbo.in_categorias INNER JOIN
                  Edehsa.in_Producto_Dimensiones INNER JOIN
                  dbo.in_movi_inve_detalle_x_Producto_CusCider ON Edehsa.in_Producto_Dimensiones.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  Edehsa.in_Producto_Dimensiones.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto INNER JOIN
                  dbo.in_Producto AS producto_elemento ON Edehsa.in_Producto_Dimensiones.IdProducto = producto_elemento.IdProducto ON dbo.in_categorias.IdEmpresa = producto_elemento.IdEmpresa AND 
                  dbo.in_categorias.IdCategoria = producto_elemento.IdCategoria ON dbo.prd_Ensamblado_Det_CusCider.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  dbo.prd_Ensamblado_Det_CusCider.CodigoBarra = dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra AND 
                  dbo.prd_Ensamblado_Det_CusCider.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'  Left = 295
               Bottom = 525
               Right = 536
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
      Begin ColumnWidths = 21
         Width = 284
         Width = 1200
         Width = 1200
         Width = 972
         Width = 1200
         Width = 1476
         Width = 1704
         Width = 2880
         Width = 2652
         Width = 744
         Width = 1020
         Width = 708
         Width = 900
         Width = 792
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
      Begin ColumnWidths = 11
         Column = 1440
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[12] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[36] 2[39] 3) )"
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
         Begin Table = "prd_Ensamblado_CusCider"
            Begin Extent = 
               Top = 0
               Left = 1486
               Bottom = 317
               Right = 1730
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Ensamblado_Det_CusCider"
            Begin Extent = 
               Top = 0
               Left = 1182
               Bottom = 317
               Right = 1426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 0
               Left = 1795
               Bottom = 163
               Right = 2039
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_categorias"
            Begin Extent = 
               Top = 15
               Left = 0
               Bottom = 302
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 566
               Bottom = 283
               Right = 817
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 10
               Left = 869
               Bottom = 407
               Right = 1088
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "producto_elemento"
            Begin Extent = 
               Top = 0
             ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados';

