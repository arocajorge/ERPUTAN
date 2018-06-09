CREATE VIEW [dbo].[vwin_Movi_Inven_x_CodBarra_CusCider]
AS
SELECT        MoviInve.IdEmpresa, MoviInve.IdSucursal, MoviInve.IdBodega, MoviInve.IdMovi_inven_tipo, MoviInve.IdNumMovi, MoviInve.CodMoviInven, MoviInve.cm_tipo, 
                         MoviInve.cm_observacion, MoviInve.cm_fecha, MoviInve_D.IdProducto, MoviInve_D.dm_cantidad, MoviInve_D.dm_stock_ante, MoviInve_D.dm_stock_actu, 
                         0 dm_precio, MoviInve_D.mv_costo, MoviInve_CBarra.dm_cantidad AS dm_cantidadCodBarra, MoviInve_CBarra.dm_observacion, 
                         MoviInve_CBarra.et_IdEmpresa, MoviInve_CBarra.et_IdProcesoProductivo, MoviInve_CBarra.et_IdEtapa, MoviInve_CBarra.ot_IdEmpresa, 
                         MoviInve_CBarra.ot_IdSucursal, MoviInve_CBarra.ot_CodObra, MoviInve_CBarra.ot_IdOrdenTaller, MoviInve_CBarra.CodigoBarra, 
                         MoviInve_D.dm_observacion AS Expr1, dbo.in_Producto.pr_observacion, dbo.in_Producto.pr_descripcion
FROM            dbo.in_Producto INNER JOIN
                         dbo.in_movi_inve_detalle_x_Producto_CusCider AS MoviInve_CBarra ON dbo.in_Producto.IdProducto = MoviInve_CBarra.IdProducto AND 
                         dbo.in_Producto.IdEmpresa = MoviInve_CBarra.IdEmpresa RIGHT OUTER JOIN
                         dbo.in_movi_inve_detalle AS MoviInve_D INNER JOIN
                         dbo.in_movi_inve AS MoviInve ON MoviInve_D.IdEmpresa = MoviInve.IdEmpresa AND MoviInve_D.IdSucursal = MoviInve.IdSucursal AND 
                         MoviInve_D.IdBodega = MoviInve.IdBodega AND MoviInve_D.IdMovi_inven_tipo = MoviInve.IdMovi_inven_tipo AND 
                         MoviInve_D.IdNumMovi = MoviInve.IdNumMovi ON MoviInve_CBarra.IdEmpresa = MoviInve_D.IdEmpresa AND 
                         MoviInve_CBarra.IdSucursal = MoviInve_D.IdSucursal AND MoviInve_CBarra.IdBodega = MoviInve_D.IdBodega AND 
                         MoviInve_CBarra.IdMovi_inven_tipo = MoviInve_D.IdMovi_inven_tipo AND MoviInve_CBarra.IdNumMovi = MoviInve_D.IdNumMovi AND 
                         MoviInve_CBarra.mv_Secuencia = MoviInve_D.Secuencia
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_CodBarra_CusCider';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'th = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_CodBarra_CusCider';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[72] 4[5] 2[5] 3) )"
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
         Begin Table = "MoviInve_D"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 374
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MoviInve"
            Begin Extent = 
               Top = 0
               Left = 633
               Bottom = 371
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MoviInve_CBarra"
            Begin Extent = 
               Top = 5
               Left = 396
               Bottom = 267
               Right = 610
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 86
               Left = 650
               Bottom = 328
               Right = 879
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
      Begin ColumnWidths = 26
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
         Wid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_CodBarra_CusCider';

