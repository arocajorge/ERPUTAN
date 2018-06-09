CREATE VIEW [dbo].[vwprd_GrupoTrabajo_x_Etapa]
AS
SELECT     dbo.prd_EtapaProduccion.NombreEtapa, dbo.prd_GrupoTrabajo.Descripcion AS gt_descripcion, dbo.prd_GrupoTrabajo.IdGrupoTrabajo, 
                      dbo.prd_GrupoTrabajo.IdSucursal, dbo.prd_GrupoTrabajo.IdEmpresa, dbo.prd_GrupoTrabajo.IdLider, dbo.prd_EtapaProduccion.IdEtapa, 
                      dbo.prd_ProcesoProductivo_x_prd_obra.CodObra
FROM         dbo.prd_ProcesoProductivo_x_prd_obra INNER JOIN
                      dbo.prd_ProcesoProductivo ON dbo.prd_ProcesoProductivo_x_prd_obra.IdEmpresa_Pr = dbo.prd_ProcesoProductivo.IdEmpresa AND 
                      dbo.prd_ProcesoProductivo_x_prd_obra.IdProcesoProductivo = dbo.prd_ProcesoProductivo.IdProcesoProductivo INNER JOIN
                      dbo.prd_EtapaProduccion ON dbo.prd_ProcesoProductivo.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo AND 
                      dbo.prd_ProcesoProductivo.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa INNER JOIN
                      dbo.prd_GrupoTrabajo ON dbo.prd_EtapaProduccion.IdEtapa = dbo.prd_GrupoTrabajo.IdEtapa AND 
                      dbo.prd_EtapaProduccion.IdEmpresa = dbo.prd_GrupoTrabajo.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajo_x_Etapa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'11
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajo_x_Etapa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[49] 2[9] 3) )"
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
         Left = -611
      End
      Begin Tables = 
         Begin Table = "prd_ProcesoProductivo_x_prd_obra"
            Begin Extent = 
               Top = 64
               Left = 317
               Bottom = 214
               Right = 583
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_ProcesoProductivo"
            Begin Extent = 
               Top = 21
               Left = 681
               Bottom = 162
               Right = 891
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 141
               Left = 948
               Bottom = 328
               Right = 1158
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 187
               Left = 641
               Bottom = 468
               Right = 851
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
      Begin ColumnWidths = 20
         Width = 284
         Width = 2145
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_GrupoTrabajo_x_Etapa';

