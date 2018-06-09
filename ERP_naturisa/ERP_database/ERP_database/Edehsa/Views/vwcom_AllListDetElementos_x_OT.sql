CREATE VIEW Edehsa.vwcom_AllListDetElementos_x_OT
AS
SELECT Mot.descripcion AS mr_descripcion, Det.IdEmpresa, Det.CodObra, Det.IdOrdenTaller, Det.IdListadoElementos_x_OT, Det.IdDetalle, Det.IdProducto, Det.Unidades, Det.Det_Kg, Det.pr_codigo, Det.pr_descripcion, 
                  Det.IdEstadoAprob, LM.ot_descripcion, LM.ob_descripcion, LM.Motivo, LM.FechaReg, LM.IdSucursal, LM.Usuario, Det.pr_largo, Det.largo_total, Det.largo_restante, Det.largo_pieza_entera, Det.cantidad_pieza_entera, 
                  Det.largo_pieza_complementaria, Det.cantidad_pieza_complementaria, Det.cantidad_total_pieza_complementaria, Det.largo_despunte1, Det.es_despunte_usable1, Det.cantidad_despunte1, Det.largo_despunte2, 
                  Det.cantidad_despunte2, Det.es_despunte_usable2
FROM     Edehsa.vwcom_ListadoElementos_x_OT_Detalle AS Det INNER JOIN
                  Edehsa.vwcom_ListadoElementos_x_OT AS LM ON Det.IdEmpresa = LM.IdEmpresa AND Det.IdListadoElementos_x_OT = LM.IdListadoElementos_x_OT INNER JOIN
                  dbo.vwcom_MotivoRequerimiento AS Mot ON 'xAPRO' = Mot.Codigo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetElementos_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 1440
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetElementos_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[46] 4[15] 2[20] 3) )"
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
               Left = 616
               Bottom = 358
               Right = 877
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LM"
            Begin Extent = 
               Top = 0
               Left = 25
               Bottom = 358
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mot"
            Begin Extent = 
               Top = 0
               Left = 1237
               Bottom = 278
               Right = 1426
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
      Begin ColumnWidths = 34
         Width = 284
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
         Width = 2232
         Width = 1200
         Width = 1200
         Width = 2148
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
      Begin ColumnWidths = 11
         Column ', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_AllListDetElementos_x_OT';

