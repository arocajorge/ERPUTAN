CREATE VIEW [dbo].[vwprd_ControlProduccion_Obrero_Cab]
AS
SELECT        dbo.prd_Movimiento_PteGrua.IdEmpresa, dbo.prd_GrupoTrabajo.IdSucursal, dbo.prd_Movimiento_PteGrua.IdPuenteGrua, dbo.prd_Movimiento_PteGrua.IdOperador, 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo, dbo.prd_Movimiento_PteGrua.IdMovimiento, dbo.prd_GrupoTrabajo.IdGrupoTrabajo, 
                         dbo.prd_Movimiento_PteGrua.CodigoBarra, dbo.prd_Movimiento_PteGrua.DescripcionPieza, dbo.prd_Movimiento_PteGrua.IdEtapaInicio, 
                         dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente, dbo.prd_Movimiento_PteGrua.ToneladasMover, dbo.prd_Movimiento_PteGrua.Observacion, 
                         dbo.prd_Movimiento_PteGrua.FechaTransaccion, dbo.prd_Movimiento_PteGrua.IdUsuario, dbo.prd_Movimiento_PteGrua.Estado, 
                         dbo.prd_ProcesoProductivo.Nombre, dbo.prd_EtapaProduccion.NombreEtapa, dbo.prd_GrupoTrabajo.Descripcion, dbo.prd_Movimiento_PteGrua.FechaFinProceso, 
                         dbo.prd_GrupoTrabajo.IdEtapa
FROM            dbo.prd_GrupoTrabajo INNER JOIN
                         dbo.prd_EtapaProduccion ON dbo.prd_GrupoTrabajo.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa AND 
                         dbo.prd_GrupoTrabajo.IdEtapa = dbo.prd_EtapaProduccion.IdEtapa INNER JOIN
                         dbo.prd_Movimiento_PteGrua ON dbo.prd_EtapaProduccion.IdEmpresa = dbo.prd_Movimiento_PteGrua.IdEmpresa AND 
                         dbo.prd_EtapaProduccion.IdEtapa = dbo.prd_Movimiento_PteGrua.IdEtapaInicio AND 
                         dbo.prd_GrupoTrabajo.IdSucursal = dbo.prd_Movimiento_PteGrua.IdSucursal INNER JOIN
                         dbo.prd_ProcesoProductivo ON dbo.prd_EtapaProduccion.IdEmpresa = dbo.prd_ProcesoProductivo.IdEmpresa AND 
                         dbo.prd_EtapaProduccion.IdProcesoProductivo = dbo.prd_ProcesoProductivo.IdProcesoProductivo AND 
                         dbo.prd_GrupoTrabajo.IdProcesoProductivo = dbo.prd_ProcesoProductivo.IdProcesoProductivo AND 
                         dbo.prd_GrupoTrabajo.IdEmpresa = dbo.prd_ProcesoProductivo.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = dbo.prd_ProcesoProductivo.IdProcesoProductivo
GROUP BY dbo.prd_Movimiento_PteGrua.IdEmpresa, dbo.prd_Movimiento_PteGrua.IdPuenteGrua, dbo.prd_Movimiento_PteGrua.IdOperador, 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo, dbo.prd_Movimiento_PteGrua.IdMovimiento, dbo.prd_GrupoTrabajo.IdGrupoTrabajo, 
                         dbo.prd_Movimiento_PteGrua.CodigoBarra, dbo.prd_Movimiento_PteGrua.DescripcionPieza, dbo.prd_Movimiento_PteGrua.IdEtapaInicio, 
                         dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente, dbo.prd_Movimiento_PteGrua.ToneladasMover, dbo.prd_Movimiento_PteGrua.Observacion, 
                         dbo.prd_Movimiento_PteGrua.FechaTransaccion, dbo.prd_Movimiento_PteGrua.IdUsuario, dbo.prd_Movimiento_PteGrua.Estado, 
                         dbo.prd_ProcesoProductivo.Nombre, dbo.prd_EtapaProduccion.NombreEtapa, dbo.prd_GrupoTrabajo.Descripcion, dbo.prd_Movimiento_PteGrua.FechaFinProceso, 
                         dbo.prd_GrupoTrabajo.IdEtapa, dbo.prd_GrupoTrabajo.IdSucursal
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccion_Obrero_Cab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccion_Obrero_Cab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[8] 2[24] 3) )"
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
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 8
               Left = 618
               Bottom = 137
               Right = 843
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Movimiento_PteGrua"
            Begin Extent = 
               Top = 79
               Left = 316
               Bottom = 208
               Right = 541
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_ProcesoProductivo"
            Begin Extent = 
               Top = 238
               Left = 356
               Bottom = 367
               Right = 581
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
      Begin ColumnWidths = 22
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
      End
   End
   Begin CriteriaPane = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_ControlProduccion_Obrero_Cab';

