CREATE VIEW [dbo].[vwin_producto_x_tb_bodega]
AS
SELECT A.IdEmpresa, A.IdProducto, B.IdBodega, A.pr_codigo, A.pr_descripcion, A.pr_peso, A.pr_ManejaIva, A.pr_ManejaSeries, C.bo_Descripcion, C.IdSucursal, D.Su_Descripcion, A.IdMarca, A.IdProductoTipo, A.IdPresentacion, 
                  A.IdUnidadMedida, B.pr_precio_publico, B.pr_precio_mayor, B.pr_precio_puerta, B.pr_precio_minimo, B.pr_costo_fob, B.pr_costo_CIF, cast(0 as float) AS pr_Pedidos_fact, CAST(0 AS FLOAT) AS pr_Pedidos_inv, CAST(0 AS FLOAT) AS pr_stock, cast(0 as float) AS pr_Disponible, B.IdCtaCble_Inven, B.IdCtaCble_Costo, A.ManejaKardex, A.IdNaturaleza, B.IdCtaCble_Inven AS IdCtaCble_Inventario, B.IdCentro_Costo_Inventario, 
                  B.IdCentro_Costo_Costo, B.IdCtaCble_Gasto_x_cxp, B.IdCentroCosto_x_Gasto_x_cxp, B.IdCentroCosto_sub_centro_costo_inv, B.IdCentroCosto_sub_centro_costo_cost, B.IdCentroCosto_sub_centro_costo_cxp, 
                  B.IdCtaCble_CosBaseIva, B.IdCtaCble_CosBase0, B.IdCtaCble_VenIva, B.IdCtaCble_Ven0, B.IdCtaCble_DesIva, B.IdCtaCble_Des0, B.IdCtaCble_DevIva, B.IdCtaCble_Dev0, B.IdCtaCble_Vta, uni.Descripcion AS Descripcion_UniMedida, 
                  consu.Descripcion AS Descripcion_TipoConsumo, A.IdUnidadMedida_Consumo, CAST(0 AS FLOAT) AS pr_costo_promedio, A.pr_stock_minimo, A.IdCod_Impuesto_Iva, A.IdCod_Impuesto_Ice, A.Aparece_modu_Ventas, 
                  A.Aparece_modu_Compras, A.Aparece_modu_Inventario, A.Aparece_modu_Activo_F, dbo.in_ProductoTipo.tp_descripcion AS nom_Tipo_Producto, dbo.in_categorias.ca_Categoria AS nom_Categoria, dbo.in_linea.nom_linea
FROM     dbo.in_linea INNER JOIN
                  dbo.in_categorias ON dbo.in_linea.IdEmpresa = dbo.in_categorias.IdEmpresa AND dbo.in_linea.IdCategoria = dbo.in_categorias.IdCategoria INNER JOIN
                  dbo.in_Producto AS A INNER JOIN
                  dbo.in_producto_x_tb_bodega AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdProducto = B.IdProducto INNER JOIN
                  dbo.tb_bodega AS C ON B.IdEmpresa = C.IdEmpresa AND B.IdBodega = C.IdBodega AND B.IdSucursal = C.IdSucursal INNER JOIN
                  dbo.tb_sucursal AS D ON C.IdEmpresa = D.IdEmpresa AND C.IdSucursal = D.IdSucursal INNER JOIN
                  dbo.in_UnidadMedida AS uni ON uni.IdUnidadMedida = A.IdUnidadMedida INNER JOIN
                  dbo.in_UnidadMedida AS consu ON A.IdUnidadMedida_Consumo = consu.IdUnidadMedida INNER JOIN
                  dbo.in_ProductoTipo ON A.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND A.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo ON dbo.in_linea.IdEmpresa = A.IdEmpresa AND dbo.in_linea.IdCategoria = A.IdCategoria AND 
                  dbo.in_linea.IdLinea = A.IdLinea
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto_x_tb_bodega';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'lumn = 0
         End
         Begin Table = "consu"
            Begin Extent = 
               Top = 488
               Left = 754
               Bottom = 617
               Right = 964
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_ProductoTipo"
            Begin Extent = 
               Top = 340
               Left = 687
               Bottom = 545
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pe_x_egr"
            Begin Extent = 
               Top = 435
               Left = 1037
               Bottom = 564
               Right = 1246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwin_producto_Ult_Costo_Hist_x_Bod"
            Begin Extent = 
               Top = 503
               Left = 841
               Bottom = 632
               Right = 1050
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "J"
            Begin Extent = 
               Top = 886
               Left = 358
               Bottom = 1015
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "H"
            Begin Extent = 
               Top = 909
               Left = 1090
               Bottom = 1038
               Right = 1299
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
      Begin ColumnWidths = 61
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
         Column = 1815
         Alias = 3795
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto_x_tb_bodega';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[3] 2[5] 3) )"
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
         Begin Table = "in_linea"
            Begin Extent = 
               Top = 0
               Left = 533
               Bottom = 177
               Right = 742
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_categorias"
            Begin Extent = 
               Top = 0
               Left = 806
               Bottom = 172
               Right = 1035
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 244
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 31
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 349
               Left = 168
               Bottom = 478
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 139
               Left = 902
               Bottom = 268
               Right = 1163
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 209
               Left = 1063
               Bottom = 338
               Right = 1293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "uni"
            Begin Extent = 
               Top = 269
               Left = 696
               Bottom = 398
               Right = 906
            End
            DisplayFlags = 280
            TopCo', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto_x_tb_bodega';

