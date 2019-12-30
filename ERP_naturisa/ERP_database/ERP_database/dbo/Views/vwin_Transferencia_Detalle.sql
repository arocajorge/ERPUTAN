CREATE VIEW [dbo].[vwin_Transferencia_Detalle]
AS

SELECT        dbo.in_transferencia_det.IdEmpresa, dbo.in_transferencia_det.IdSucursalOrigen, dbo.in_transferencia_det.IdBodegaOrigen, 
                         dbo.in_transferencia_det.IdTransferencia, dbo.in_transferencia_det.dt_secuencia, dbo.in_transferencia_det.IdProducto, dbo.in_transferencia_det.dt_cantidad, 
                         dbo.in_transferencia_det.tr_Observacion, dbo.in_transferencia_det.IdCentroCosto, dbo.in_transferencia_det.IdCentroCosto_sub_centro_costo, 
                         dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_codigo, dbo.in_transferencia_det.IdUnidadMedida, dbo.in_transferencia_det.IdPunto_cargo_grupo, 
                         dbo.in_transferencia_det.IdPunto_cargo, dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdEmpresa_guia, 
                         dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdGuia_guia, dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.Secuencia_guia
FROM            dbo.in_transferencia_det INNER JOIN
                         dbo.in_Producto ON dbo.in_transferencia_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.in_transferencia_det.IdProducto = dbo.in_Producto.IdProducto LEFT OUTER JOIN
                         dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det ON 
                         dbo.in_transferencia_det.IdEmpresa = dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdEmpresa_trans AND 
                         dbo.in_transferencia_det.IdSucursalOrigen = dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdSucursalOrigen_trans AND 
                         dbo.in_transferencia_det.IdBodegaOrigen = dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdBodegaOrigen_trans AND 
                         dbo.in_transferencia_det.IdTransferencia = dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.IdTransferencia_trans AND 
                         dbo.in_transferencia_det.dt_secuencia = dbo.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det.Secuencia_trans
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencia_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'      Width = 1500
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
         Column = 4896
         Alias = 2700
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencia_Detalle';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[62] 4[3] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[64] 4[17] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[88] 2[4] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[78] 3) )"
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
         Begin Table = "in_transferencia_det"
            Begin Extent = 
               Top = 0
               Left = 63
               Bottom = 393
               Right = 372
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_transferencia"
            Begin Extent = 
               Top = 0
               Left = 486
               Bottom = 508
               Right = 812
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "in_Ing_Egr_Inven_det"
            Begin Extent = 
               Top = 0
               Left = 927
               Bottom = 508
               Right = 1236
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
      Begin ColumnWidths = 45
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1776
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2808
         Width = 2796
         Width = 2940
         Width = 2868
         Width = 2856
         Width = 3000
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2496
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1656
         Width = 2532
         Width = 2448
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencia_Detalle';



