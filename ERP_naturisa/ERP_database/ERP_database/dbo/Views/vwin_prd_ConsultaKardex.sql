CREATE VIEW [dbo].[vwin_prd_ConsultaKardex]
AS
SELECT        dbo.in_movi_inve_detalle.IdEmpresa, dbo.in_movi_inve_detalle.IdSucursal, dbo.in_movi_inve_detalle.IdBodega, 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo AS IdTipoMovimiento, dbo.in_movi_inve_detalle.IdNumMovi AS IdMovimiento, dbo.in_movi_inve_detalle.Secuencia, 
                         dbo.in_movi_inve_detalle.mv_tipo_movi, dbo.in_movi_inve_detalle.IdProducto, dbo.in_movi_inve_detalle.dm_cantidad, dbo.in_movi_inve_detalle.dm_stock_ante, 
                         dbo.in_movi_inve_detalle.dm_stock_actu, dbo.in_movi_inve_detalle.dm_observacion, dbo.in_movi_inve_detalle.dm_peso, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, dbo.in_Producto.pr_descripcion, dbo.tb_bodega.bo_Descripcion, dbo.tb_sucursal.Su_Descripcion, 
                         dbo.in_movi_inve.cm_fecha, dbo.in_movi_inve.Fecha_Transac
FROM            dbo.tb_sucursal INNER JOIN
                         dbo.in_movi_inve_detalle INNER JOIN
                         dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia INNER JOIN
                         dbo.in_movi_inve ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.in_movi_inve.IdSucursal AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega = dbo.in_movi_inve.IdBodega AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo = dbo.in_movi_inve.IdMovi_inven_tipo AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi = dbo.in_movi_inve.IdNumMovi INNER JOIN
                         dbo.tb_bodega ON dbo.in_movi_inve.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_movi_inve.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.in_movi_inve.IdBodega = dbo.tb_bodega.IdBodega ON dbo.tb_sucursal.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND 
                         dbo.tb_sucursal.IdSucursal = dbo.in_movi_inve.IdSucursal INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto = dbo.in_Producto.IdProducto
WHERE        (dbo.in_movi_inve.IdEmpresa = 6)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaKardex';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 284
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaKardex';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[4] 2[22] 3) )"
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
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 0
               Left = 1132
               Bottom = 377
               Right = 1311
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle"
            Begin Extent = 
               Top = 0
               Left = 70
               Bottom = 408
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 0
               Left = 373
               Bottom = 362
               Right = 549
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "in_movi_inve"
            Begin Extent = 
               Top = 0
               Left = 713
               Bottom = 461
               Right = 961
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 0
               Left = 939
               Bottom = 364
               Right = 1148
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 69
               Left = 633
               Bottom = 341
               Right = 826
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
      Begin ColumnWidths = 24
         Width ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaKardex';

