CREATE VIEW [dbo].[vw_WSProduccionCidersus_TrazabilidadPro]
AS
SELECT        dbo.prd_Movimiento_PteGrua.IdEmpresa, dbo.prd_Movimiento_PteGrua.IdSucursal, dbo.prd_Movimiento_PteGrua.IdPuenteGrua, 
                         dbo.prd_Movimiento_PteGrua.IdOperador, dbo.prd_Movimiento_PteGrua.IdProcesoProductivo, dbo.prd_Movimiento_PteGrua.IdMovimiento, 
                         dbo.prd_Movimiento_PteGrua.CodigoBarra, dbo.prd_EtapaProduccion.NombreEtapa, dbo.prd_ProcesoProductivo.Nombre, 
                         dbo.prd_Movimiento_PteGrua.FechaTransaccion, dbo.prd_Movimiento_PteGrua.DescripcionPieza, dbo.prd_Movimiento_PteGrua.IdEtapaInicio, 
                         dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente
FROM            dbo.prd_Movimiento_PteGrua INNER JOIN
                         dbo.prd_EtapaProduccion ON dbo.prd_Movimiento_PteGrua.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdEtapaInicio = dbo.prd_EtapaProduccion.IdEtapa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo INNER JOIN
                         dbo.prd_ProcesoProductivo ON dbo.prd_EtapaProduccion.IdEmpresa = dbo.prd_ProcesoProductivo.IdEmpresa AND 
                         dbo.prd_EtapaProduccion.IdProcesoProductivo = dbo.prd_ProcesoProductivo.IdProcesoProductivo INNER JOIN
                         dbo.prd_EtapaProduccion AS prd_EtapaProduccion_1 ON dbo.prd_ProcesoProductivo.IdEmpresa = prd_EtapaProduccion_1.IdEmpresa AND 
                         dbo.prd_ProcesoProductivo.IdProcesoProductivo = prd_EtapaProduccion_1.IdProcesoProductivo AND 
                         dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente = prd_EtapaProduccion_1.IdEtapa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = prd_EtapaProduccion_1.IdProcesoProductivo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_TrazabilidadPro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_TrazabilidadPro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[59] 4[4] 2[7] 3) )"
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
               Top = 6
               Left = 38
               Bottom = 279
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 0
               Left = 303
               Bottom = 228
               Right = 512
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_ProcesoProductivo"
            Begin Extent = 
               Top = 4
               Left = 658
               Bottom = 133
               Right = 867
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion_1"
            Begin Extent = 
               Top = 99
               Left = 726
               Bottom = 307
               Right = 935
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
      Begin ColumnWidths = 14
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
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_TrazabilidadPro';

