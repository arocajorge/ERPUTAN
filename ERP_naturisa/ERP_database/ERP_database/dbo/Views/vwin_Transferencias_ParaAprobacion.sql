CREATE VIEW dbo.vwin_Transferencias_ParaAprobacion
AS
SELECT dbo.in_transferencia.IdEmpresa, dbo.in_transferencia.IdSucursalOrigen, dbo.in_transferencia.IdBodegaOrigen, dbo.in_transferencia.IdTransferencia, dbo.in_transferencia.IdSucursalDest, dbo.in_transferencia.IdBodegaDest, 
                  SO.Su_Descripcion AS SucursalOrigen, BO.bo_Descripcion AS BodegaOrigen, SD.Su_Descripcion AS SucursalDestino, BD.bo_Descripcion AS BodegaDestino, dbo.in_transferencia.tr_Observacion, dbo.in_transferencia.tr_fecha, 
                  dbo.in_transferencia_det.pr_descripcion, dbo.in_transferencia_det.dt_cantidad, dbo.in_transferencia_det.IdUnidadMedida, dbo.in_UnidadMedida.Descripcion AS NomUnidadMedida, dbo.in_transferencia_det.dt_secuencia, 
                  dbo.in_transferencia_det.IdProducto
FROM     dbo.in_UnidadMedida INNER JOIN
                  dbo.in_transferencia INNER JOIN
                  dbo.in_transferencia_det ON dbo.in_transferencia.IdEmpresa = dbo.in_transferencia_det.IdEmpresa AND dbo.in_transferencia.IdSucursalOrigen = dbo.in_transferencia_det.IdSucursalOrigen AND 
                  dbo.in_transferencia.IdBodegaOrigen = dbo.in_transferencia_det.IdBodegaOrigen AND dbo.in_transferencia.IdTransferencia = dbo.in_transferencia_det.IdTransferencia ON 
                  dbo.in_UnidadMedida.IdUnidadMedida = dbo.in_transferencia_det.IdUnidadMedida INNER JOIN
                  dbo.tb_bodega AS BO ON dbo.in_transferencia_det.IdEmpresa = BO.IdEmpresa AND dbo.in_transferencia_det.IdSucursalOrigen = BO.IdSucursal AND dbo.in_transferencia_det.IdBodegaOrigen = BO.IdBodega INNER JOIN
                  dbo.tb_sucursal AS SO ON BO.IdEmpresa = SO.IdEmpresa AND BO.IdSucursal = SO.IdSucursal INNER JOIN
                  dbo.tb_bodega AS BD ON dbo.in_transferencia.IdEmpresa = BD.IdEmpresa AND dbo.in_transferencia.IdSucursalDest = BD.IdSucursal AND dbo.in_transferencia.IdBodegaDest = BD.IdBodega INNER JOIN
                  dbo.tb_sucursal AS SD ON BD.IdEmpresa = SD.IdEmpresa AND BD.IdSucursal = SD.IdSucursal
WHERE  (dbo.in_transferencia.EstadoRevision = 'A') AND (dbo.in_transferencia.Estado = 'A')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencias_ParaAprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'yFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencias_ParaAprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[3] 2[33] 3) )"
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
         Top = -240
         Left = 0
      End
      Begin Tables = 
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_transferencia"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 374
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "in_transferencia_det"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "BO"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SO"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BD"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SD"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 320
            End
            Displa', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Transferencias_ParaAprobacion';

