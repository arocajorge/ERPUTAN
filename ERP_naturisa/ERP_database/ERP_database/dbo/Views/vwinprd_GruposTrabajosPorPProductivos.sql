CREATE VIEW [dbo].[vwinprd_GruposTrabajosPorPProductivos]
AS
SELECT        dbo.prd_EtapaProduccion.IdEmpresa, dbo.prd_EtapaProduccion.IdProcesoProductivo, dbo.prd_EtapaProduccion.IdEtapa, 
                         dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo, dbo.prd_GruposTrabajo_PorPP.IdSubgrupo, dbo.prd_ProcesoProductivo.Nombre AS ProcesoProductivo, 
                         dbo.prd_EtapaProduccion.NombreEtapa, dbo.prd_GrupoTrabajo.Descripcion AS NombreSubgrupo, dbo.prd_GruposTrabajo.Descripcion AS GrupoTrabajo
FROM            dbo.prd_GrupoTrabajo INNER JOIN
                         dbo.prd_GruposTrabajo_PorPP ON dbo.prd_GrupoTrabajo.IdGrupoTrabajo = dbo.prd_GruposTrabajo_PorPP.IdSubgrupo AND 
                         dbo.prd_GrupoTrabajo.IdGrupo = dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo INNER JOIN
                         dbo.prd_ProcesoProductivo INNER JOIN
                         dbo.prd_EtapaProduccion ON dbo.prd_ProcesoProductivo.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa AND 
                         dbo.prd_ProcesoProductivo.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo ON 
                         dbo.prd_GruposTrabajo_PorPP.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo AND 
                         dbo.prd_GruposTrabajo_PorPP.IdEtapa = dbo.prd_EtapaProduccion.IdEtapa INNER JOIN
                         dbo.prd_GruposTrabajo ON dbo.prd_GrupoTrabajo.IdEmpresa = dbo.prd_GruposTrabajo.IdEmpresa AND 
                         dbo.prd_GrupoTrabajo.IdSucursal = dbo.prd_GruposTrabajo.IdSucursal AND dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo = dbo.prd_GruposTrabajo.IdGrupoTrabajo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwinprd_GruposTrabajosPorPProductivos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Begin ColumnWidths = 11
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwinprd_GruposTrabajosPorPProductivos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[4] 2[32] 3) )"
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
         Begin Table = "prd_ProcesoProductivo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 235
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 11
               Left = 273
               Bottom = 247
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 0
               Left = 843
               Bottom = 242
               Right = 1052
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GruposTrabajo_PorPP"
            Begin Extent = 
               Top = 15
               Left = 508
               Bottom = 199
               Right = 717
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GruposTrabajo"
            Begin Extent = 
               Top = 208
               Left = 615
               Bottom = 362
               Right = 824
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
      Begin ColumnWidths = 10
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
      End
   End
   Begin CriteriaPane = 
 ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwinprd_GruposTrabajosPorPProductivos';

