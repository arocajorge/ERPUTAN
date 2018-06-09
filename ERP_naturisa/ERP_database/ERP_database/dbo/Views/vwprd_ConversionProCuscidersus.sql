CREATE VIEW [dbo].[vwprd_ConversionProCuscidersus]
AS
SELECT        dbo.in_movi_inve.IdEmpresa, dbo.in_movi_inve.IdSucursal, dbo.in_movi_inve.IdBodega, dbo.in_movi_inve.IdMovi_inven_tipo, dbo.in_movi_inve.IdNumMovi, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, dbo.in_Producto.pr_descripcion, 
                         dbo.in_Producto.pr_observacion, dbo.prd_Obra.Descripcion, dbo.in_movi_inve.cm_fecha, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, dbo.in_movi_inve.Estado
FROM            dbo.in_Producto INNER JOIN
                         dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_Producto.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                         dbo.in_Producto.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto INNER JOIN
                         dbo.prd_Orden_Taller ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.prd_Orden_Taller.IdSucursal INNER JOIN
                         dbo.in_movi_inve ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.in_movi_inve.IdSucursal AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega = dbo.in_movi_inve.IdBodega AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo = dbo.in_movi_inve.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi = dbo.in_movi_inve.IdNumMovi LEFT OUTER JOIN
                         dbo.prd_Obra ON dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra = dbo.prd_Obra.CodObra
WHERE        (dbo.in_movi_inve.IdMovi_inven_tipo = 3)
GROUP BY dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, dbo.prd_Obra.Descripcion, 
                         dbo.in_movi_inve.cm_fecha, dbo.in_movi_inve.Estado, dbo.in_movi_inve.IdEmpresa, dbo.in_movi_inve.IdSucursal, dbo.in_movi_inve.IdBodega, 
                         dbo.in_movi_inve.IdMovi_inven_tipo, dbo.in_movi_inve.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ConversionProCuscidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'dth = 3420
         Width = 1500
         Width = 1500
         Width = 2130
         Width = 2880
         Width = 1500
         Width = 2145
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1995
         Alias = 900
         Table = 4440
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ConversionProCuscidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[34] 2[28] 3) )"
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
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 0
               Left = 933
               Bottom = 244
               Right = 1162
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 0
               Left = 329
               Bottom = 424
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 0
               Left = 687
               Bottom = 147
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 372
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 134
               Left = 754
               Bottom = 314
               Right = 963
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
      Begin ColumnWidths = 23
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1950
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 3600
         Width = 2910
         Width = 1500
         Width = 1500
         Wi', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ConversionProCuscidersus';

