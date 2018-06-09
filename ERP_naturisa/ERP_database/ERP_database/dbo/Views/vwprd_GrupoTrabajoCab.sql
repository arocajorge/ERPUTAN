CREATE VIEW dbo.vwprd_GrupoTrabajoCab
AS
SELECT GT.IdEmpresa, GT.IdSucursal, GT.Descripcion AS gt_Descripcion, GT.FechaCreacion, GT.IdLider, GT.IdProcesoProductivo, GT.IdEtapa, GT.Estado, dbo.tb_sucursal.Su_Descripcion, PP.Nombre AS DescripModelo, 
                  ET.NombreEtapa, VWEmp.pe_nombreCompleto, GT.IdGrupo, GT.IdGrupoTrabajo
FROM     dbo.tb_sucursal INNER JOIN
                  dbo.prd_ProcesoProductivo AS PP INNER JOIN
                  dbo.prd_EtapaProduccion AS ET ON PP.IdEmpresa = ET.IdEmpresa AND PP.IdProcesoProductivo = ET.IdProcesoProductivo INNER JOIN
                  dbo.prd_GrupoTrabajo AS GT ON ET.IdEtapa = GT.IdEtapa AND ET.IdProcesoProductivo = GT.IdProcesoProductivo AND PP.IdEmpresa = GT.IdEmpresa INNER JOIN
                  dbo.VWRO_empleado AS VWEmp ON GT.IdLider = VWEmp.IdEmpleado AND GT.IdEmpresa = VWEmp.IdEmpresa ON dbo.tb_sucursal.IdSucursal = GT.IdSucursal AND dbo.tb_sucursal.IdEmpresa = GT.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajoCab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'0
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajoCab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[15] 2[39] 3) )"
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
         Top = -360
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 488
               Left = 611
               Bottom = 629
               Right = 856
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PP"
            Begin Extent = 
               Top = 256
               Left = 266
               Bottom = 397
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ET"
            Begin Extent = 
               Top = 344
               Left = 509
               Bottom = 485
               Right = 719
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GT"
            Begin Extent = 
               Top = 393
               Left = 54
               Bottom = 592
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VWEmp"
            Begin Extent = 
               Top = 29
               Left = 261
               Bottom = 163
               Right = 505
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
      Begin ColumnWidths = 15
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 120', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajoCab';

