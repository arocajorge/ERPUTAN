CREATE VIEW dbo.vwcom_AllListDetMateriales
AS
SELECT     Mot.descripcion AS mr_descripcion, Det.IdEmpresa, Det.CodObra, Det.IdOrdenTaller, Det.IdListadoMateriales, Det.IdDetalle, Det.IdProducto, Det.Unidades, 
                      Det.Det_Kg, Det.pr_codigo, Det.pr_descripcion, Det.IdEstadoAprob, LM.ob_descripcion, LM.Motivo, LM.FechaReg, LM.IdSucursal, LM.Usuario, 
                      APRO_.descripcion AS ea_descripcion, Det.pr_largo, Det.largo_total, Det.largo_restante, Det.largo_pieza_entera, Det.cantidad_pieza_entera, 
                      Det.largo_pieza_complementaria, Det.cantidad_pieza_complementaria, Det.cantidad_total_pieza_complementaria, Det.largo_despunte1, Det.es_despunte_usable1, 
                      Det.cantidad_despunte1, Det.largo_despunte2, Det.cantidad_despunte2, Det.es_despunte_usable2, Det.espesor, Det.ancho
FROM         dbo.vwcom_ListadoMateriales_Detalle AS Det INNER JOIN
                      dbo.vwcom_ListadoMateriales AS LM ON Det.IdEmpresa = LM.IdEmpresa AND Det.IdListadoMateriales = LM.IdListadoMateriales INNER JOIN
                      dbo.vwcom_MotivoRequerimiento AS Mot ON 'xAPRO' = Mot.Codigo INNER JOIN
                      dbo.vwcom_EstadoAprob_List_Req AS APRO_ ON Det.IdEstadoAprob = APRO_.Id
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'd
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[28] 2[26] 3) )"
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
         Top = -96
         Left = -288
      End
      Begin Tables = 
         Begin Table = "Det"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 262
               Right = 368
            End
            DisplayFlags = 280
            TopColumn = 25
         End
         Begin Table = "LM"
            Begin Extent = 
               Top = 6
               Left = 495
               Bottom = 260
               Right = 739
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Mot"
            Begin Extent = 
               Top = 36
               Left = 988
               Bottom = 199
               Right = 1232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "APRO_"
            Begin Extent = 
               Top = 246
               Left = 497
               Bottom = 463
               Right = 741
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
      Begin ColumnWidths = 9
         Width = 284
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
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
En', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetMateriales';

