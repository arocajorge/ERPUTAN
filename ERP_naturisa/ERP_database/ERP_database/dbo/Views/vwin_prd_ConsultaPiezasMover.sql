CREATE VIEW [dbo].[vwin_prd_ConsultaPiezasMover]
AS
SELECT        dbo.prd_Movimiento_PteGrua.IdEmpresa, dbo.prd_Movimiento_PteGrua.IdSucursal, dbo.prd_Movimiento_PteGrua.IdPuenteGrua, 
                         dbo.prd_Movimiento_PteGrua.IdOperador, dbo.prd_Movimiento_PteGrua.IdMovimiento, EtapaUbicacion.NombreEtapa AS EtapaUbucacion, 
                         EtapaSiguiente.NombreEtapa AS EtapaSiguiente, dbo.prod_PuenteGrua.nombre, dbo.prd_Movimiento_PteGrua.FechaTransaccion, 
                         dbo.prd_Movimiento_PteGrua.DescripcionPieza, dbo.prd_Movimiento_PteGrua.Estado
FROM            dbo.prd_Movimiento_PteGrua INNER JOIN
                         dbo.prd_EtapaProduccion AS EtapaUbicacion ON dbo.prd_Movimiento_PteGrua.IdEtapaInicio = EtapaUbicacion.IdEtapa AND 
                         dbo.prd_Movimiento_PteGrua.IdEmpresa = EtapaUbicacion.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = EtapaUbicacion.IdProcesoProductivo INNER JOIN
                         dbo.prd_EtapaProduccion AS EtapaSiguiente ON dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente = EtapaSiguiente.IdEtapa AND 
                         dbo.prd_Movimiento_PteGrua.IdEmpresa = EtapaSiguiente.IdEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdProcesoProductivo = EtapaSiguiente.IdProcesoProductivo INNER JOIN
                         dbo.prod_PuenteGrua ON dbo.prd_Movimiento_PteGrua.IdEmpresa = dbo.prod_PuenteGrua.idEmpresa AND 
                         dbo.prd_Movimiento_PteGrua.IdSucursal = dbo.prod_PuenteGrua.Idsucural AND 
                         dbo.prd_Movimiento_PteGrua.IdPuenteGrua = dbo.prod_PuenteGrua.idPuenteGrua
WHERE        (dbo.prd_Movimiento_PteGrua.Estado = 'L')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaPiezasMover';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaPiezasMover';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[4] 2[44] 3) )"
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
               Top = 0
               Left = 392
               Bottom = 325
               Right = 601
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "EtapaUbicacion"
            Begin Extent = 
               Top = 0
               Left = 914
               Bottom = 183
               Right = 1123
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "EtapaSiguiente"
            Begin Extent = 
               Top = 61
               Left = 697
               Bottom = 252
               Right = 906
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_PuenteGrua"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 270
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2535
         Width = 1965
         Width = 1935
         Width = 2370
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
         GroupBy ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_prd_ConsultaPiezasMover';

