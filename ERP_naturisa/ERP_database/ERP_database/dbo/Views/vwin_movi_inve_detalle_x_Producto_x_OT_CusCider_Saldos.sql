CREATE VIEW dbo.vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos
AS
SELECT dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_precio, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_costo, dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEmpresa, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdProcesoProductivo, dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEtapa, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdEmpresa, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto, dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.ocd_IdOrdenCompra
FROM     dbo.in_Producto INNER JOIN
                  dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_Producto.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  dbo.in_Producto.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto
WHERE  (dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi = '-') AND (dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra NOT IN
                      (SELECT CodigoBarra
                       FROM      dbo.prd_Ensamblado_Det_CusCider))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[4] 2[41] 3) )"
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
         Top = -120
         Left = 0
      End
      Begin Tables = 
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 14
               Left = 840
               Bottom = 276
               Right = 1040
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 349
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 16
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
         Width = 284
         Width = 1128
         Width = 1020
         Width = 1032
         Width = 1380
         Width = 1320
         Width = 1140
         Width = 1500
         Width = 1500
         Width = 1260
         Width = 1668
         Width = 1500
         Width = 1092
         Width = 1188
         Width = 1236
         Width = 1248
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos';

