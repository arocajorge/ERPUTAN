CREATE VIEW [dbo].[vwprd_Movimiento_PteGrua]
AS
SELECT        dbo.prd_Movimiento_PteGrua.IdEmpresa, dbo.prd_Movimiento_PteGrua.IdSucursal, dbo.prd_Movimiento_PteGrua.IdPuenteGrua, 
                         Etapa_Ant.NombreEtapa AS Etapa_Ant, dbo.prd_Movimiento_PteGrua.IdProcesoProductivo, dbo.prd_Movimiento_PteGrua.IdOperador, 
                         dbo.prd_Movimiento_PteGrua.Estado, dbo.prd_Movimiento_PteGrua.FechaUltModi, dbo.prd_Movimiento_PteGrua.FechaAnu, 
                         dbo.prd_Movimiento_PteGrua.IdUsuarioUltModi, dbo.prd_Movimiento_PteGrua.MotivoAnu, dbo.prd_Movimiento_PteGrua.IdUsuarioAnu, 
                         dbo.prd_Movimiento_PteGrua.IdUsuario, dbo.prd_Movimiento_PteGrua.FechaTransaccion, dbo.prd_Movimiento_PteGrua.Observacion, 
                         dbo.prd_Movimiento_PteGrua.ToneladasMover, dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente, dbo.prd_Movimiento_PteGrua.IdEtapaInicio, 
                         dbo.prd_Movimiento_PteGrua.DescripcionPieza, dbo.prd_Movimiento_PteGrua.CodigoBarra, dbo.prd_Movimiento_PteGrua.IdMovimiento, 
                         Etapa_Sig.NombreEtapa AS Etapa_Sig
FROM            dbo.prd_Movimiento_PteGrua INNER JOIN
                         dbo.prd_EtapaProduccion AS Etapa_Ant ON dbo.prd_Movimiento_PteGrua.IdEmpresa = Etapa_Ant.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = Etapa_Ant.IdProcesoProductivo AND 
                         dbo.prd_Movimiento_PteGrua.IdEtapaInicio = Etapa_Ant.IdEtapa INNER JOIN
                         dbo.prd_EtapaProduccion AS Etapa_Sig ON dbo.prd_Movimiento_PteGrua.IdEmpresa = Etapa_Sig.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = Etapa_Sig.IdProcesoProductivo AND dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente = Etapa_Sig.IdEtapa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Movimiento_PteGrua';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Movimiento_PteGrua';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[4] 2[24] 3) )"
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
         Begin Table = "prd_Movimiento_PteGrua"
            Begin Extent = 
               Top = 5
               Left = 38
               Bottom = 357
               Right = 307
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Etapa_Ant"
            Begin Extent = 
               Top = 21
               Left = 460
               Bottom = 145
               Right = 687
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Etapa_Sig"
            Begin Extent = 
               Top = 183
               Left = 487
               Bottom = 312
               Right = 696
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
      Begin ColumnWidths = 23
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2340
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
         Width = 1935
         Width = 1500
         Width = 1260
         Width = 2205
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
         Filter =', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Movimiento_PteGrua';

