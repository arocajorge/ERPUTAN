CREATE VIEW [dbo].[vw_WSProduccionCidersus_Etapa_ProceP]
AS
SELECT        dbo.prd_ProcesoProductivo.IdEmpresa, dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo, dbo.prd_GruposTrabajo_PorPP.IdSubgrupo, 
                         dbo.prd_GruposTrabajo_PorPP.IdProcesoProductivo, dbo.prd_GruposTrabajo_PorPP.IdEtapa, dbo.prd_EtapaProduccion.NombreEtapa, 
                         dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo.Cant_Pieza_Pendie_Por_Procesar_PorSubgrupo, dbo.prd_GrupoTrabajo.Descripcion
FROM            dbo.prd_ProcesoProductivo INNER JOIN
                         dbo.prd_EtapaProduccion ON dbo.prd_ProcesoProductivo.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa AND 
                         dbo.prd_ProcesoProductivo.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo INNER JOIN
                         dbo.prd_GruposTrabajo_PorPP ON dbo.prd_EtapaProduccion.IdProcesoProductivo = dbo.prd_GruposTrabajo_PorPP.IdProcesoProductivo AND 
                         dbo.prd_EtapaProduccion.IdEtapa = dbo.prd_GruposTrabajo_PorPP.IdEtapa INNER JOIN
                         dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo ON 
                         dbo.prd_GruposTrabajo_PorPP.IdProcesoProductivo = dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo.IdProcesoProductivo AND 
                         dbo.prd_GruposTrabajo_PorPP.IdEtapa = dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo.IdEtapa AND 
                         dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo = dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo.IdGrupo AND 
                         dbo.prd_GruposTrabajo_PorPP.IdSubgrupo = dbo.prd_PiezasEnEspera_Pendiente_PorSubgrupo.IdSubGrupo INNER JOIN
                         dbo.prd_GrupoTrabajo ON dbo.prd_GruposTrabajo_PorPP.IdSubgrupo = dbo.prd_GrupoTrabajo.IdGrupoTrabajo AND 
                         dbo.prd_GruposTrabajo_PorPP.IdGrupoTrabajo = dbo.prd_GrupoTrabajo.IdGrupo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_Etapa_ProceP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_Etapa_ProceP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[65] 4[4] 2[8] 3) )"
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
               Top = 8
               Left = 3
               Bottom = 230
               Right = 187
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 4
               Left = 222
               Bottom = 229
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_PiezasEnEspera_Pendiente_PorSubgrupo"
            Begin Extent = 
               Top = 7
               Left = 828
               Bottom = 195
               Right = 979
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GruposTrabajo_PorPP"
            Begin Extent = 
               Top = 0
               Left = 532
               Bottom = 240
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 11
               Left = 781
               Bottom = 270
               Right = 990
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
      Begin ColumnWidths = 13
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
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_Etapa_ProceP';

