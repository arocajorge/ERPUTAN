CREATE VIEW [dbo].[vwin_Movi_Inven_Asig_Saldo_x_OT_CusCider]
AS
SELECT     dbo.in_movi_inve_detalle.IdEmpresa, dbo.in_movi_inve_detalle.IdSucursal, dbo.in_movi_inve_detalle.IdBodega, dbo.in_movi_inve_detalle.IdMovi_inven_tipo, 
                      dbo.in_movi_inve_detalle.IdNumMovi, dbo.in_movi_inve_detalle.Secuencia, dbo.in_movi_inve_detalle.mv_tipo_movi, dbo.in_movi_inve_detalle.IdProducto, 
                      dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdSucursal, 
                      dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, 
                      dbo.in_movi_inve_detalle.dm_cantidad * - 1 AS cantidad
FROM         dbo.in_movi_inve_detalle INNER JOIN
                      dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                      dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal AND 
                      dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega AND 
                      dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo AND 
                      dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi AND 
                      dbo.in_movi_inve_detalle.Secuencia = dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia INNER JOIN
                      dbo.prd_parametros_CusCidersus ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.prd_parametros_CusCidersus.IdEmpresa AND 
                      dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.prd_parametros_CusCidersus.IdMovi_inven_tipo_ing_consumoprod
WHERE     (dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEmpresa IS NULL) AND (dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdProcesoProductivo IS NULL) AND
                       (dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdEtapa IS NULL) AND (dbo.in_movi_inve_detalle.mv_tipo_movi = N'+') AND 
                      (dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdEmpresa IS NOT NULL) AND (dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdSucursal IS NOT NULL) AND
                       (dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra IS NOT NULL) AND (dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller IS NOT NULL) 
                      AND (dbo.in_movi_inve_detalle.dm_cantidad > 0)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_Asig_Saldo_x_OT_CusCider';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[4] 2[34] 3) )"
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
         Begin Table = "in_movi_inve_detalle"
            Begin Extent = 
               Top = 32
               Left = 421
               Bottom = 151
               Right = 598
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 6
               Left = 734
               Bottom = 125
               Right = 938
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_parametros_CusCidersus"
            Begin Extent = 
               Top = 38
               Left = 31
               Bottom = 157
               Right = 317
            End
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
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2250
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_Asig_Saldo_x_OT_CusCider';

