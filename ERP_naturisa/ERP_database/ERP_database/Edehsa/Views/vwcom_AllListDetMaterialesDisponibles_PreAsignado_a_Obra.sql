CREATE VIEW Edehsa.vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra
AS
SELECT Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi, Det.IdProducto, Det.CodigoBarra, Det.dm_cantidad, Det.dm_observacion, Det.CodObra_preasignada, Det.Det_Kg, Det.pr_largo, 
                  Det.largo_total, Det.largo_restante, Det.largo_pieza_entera, Det.cantidad_pieza_entera, Det.largo_pieza_complementaria, Det.cantidad_pieza_complementaria, Det.cantidad_total_pieza_complementaria, 
                  Det.largo_despunte1, Det.cantidad_despunte1, Det.es_despunte_usable1, Det.largo_despunte2, Det.cantidad_despunte2, Det.es_despunte_usable2, Det.IdEstadoAprob, Det.pr_codigo, Det.pr_descripcion, 
                  Det.IdCategoria, Det.longitud, Det.espesor, Det.ancho, Mot.descripcion AS mr_descripcion, APRO_.descripcion AS ea_descripcion, dbo.prd_Obra.Descripcion AS Obra
FROM     Edehsa.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle AS Det INNER JOIN
                  dbo.vwcom_MotivoRequerimiento AS Mot ON 'xAPRO' = Mot.Codigo INNER JOIN
                  dbo.vwcom_EstadoAprob_List_Req AS APRO_ ON Det.IdEstadoAprob = APRO_.Id INNER JOIN
                  dbo.prd_Obra ON Det.IdEmpresa = dbo.prd_Obra.IdEmpresa AND Det.CodObra_preasignada = dbo.prd_Obra.CodObra
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Width = 1200
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
      Begin ColumnWidths = 11
         Column = 3720
         Alias = 2388
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1356
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[35] 2[21] 3) )"
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
         Begin Table = "Det"
            Begin Extent = 
               Top = 0
               Left = 579
               Bottom = 293
               Right = 913
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mot"
            Begin Extent = 
               Top = 25
               Left = 1053
               Bottom = 345
               Right = 1242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "APRO_"
            Begin Extent = 
               Top = 226
               Left = 13
               Bottom = 393
               Right = 254
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 351
               Left = 1028
               Bottom = 514
               Right = 1272
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
      Begin ColumnWidths = 40
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
    ', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra';

