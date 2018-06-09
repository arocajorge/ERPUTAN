CREATE VIEW Edehsa.vwcom_ListadoElementos_x_OT
AS
SELECT     Edehsa.com_ListadoElementos_x_OT.IdEmpresa, Edehsa.com_ListadoElementos_x_OT.CodObra, Edehsa.com_ListadoElementos_x_OT.IdOrdenTaller, 
                      Edehsa.com_ListadoElementos_x_OT.IdListadoElementos_x_OT, Edehsa.com_ListadoElementos_x_OT.FechaReg, Edehsa.com_ListadoElementos_x_OT.Estado, 
                      dbo.prd_Obra.Descripcion AS ob_descripcion, dbo.prd_Orden_Taller.Codigo AS ot_descripcion, Edehsa.com_ListadoElementos_x_OT.Usuario, 
                      Edehsa.com_ListadoElementos_x_OT.Motivo, Edehsa.com_ListadoElementos_x_OT.lm_Observacion, dbo.prd_Orden_Taller.IdSucursal, 
                      dbo.tb_sucursal.Su_Descripcion
FROM         Edehsa.com_ListadoElementos_x_OT INNER JOIN
                      dbo.prd_Orden_Taller ON Edehsa.com_ListadoElementos_x_OT.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller AND 
                      Edehsa.com_ListadoElementos_x_OT.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                      Edehsa.com_ListadoElementos_x_OT.CodObra = dbo.prd_Orden_Taller.CodObra AND 
                      Edehsa.com_ListadoElementos_x_OT.ot_IdSucursal = dbo.prd_Orden_Taller.IdSucursal INNER JOIN
                      dbo.prd_Obra ON Edehsa.com_ListadoElementos_x_OT.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                      Edehsa.com_ListadoElementos_x_OT.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.tb_sucursal ON dbo.prd_Orden_Taller.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.prd_Orden_Taller.IdSucursal = dbo.tb_sucursal.IdSucursal
GROUP BY Edehsa.com_ListadoElementos_x_OT.IdEmpresa, Edehsa.com_ListadoElementos_x_OT.CodObra, Edehsa.com_ListadoElementos_x_OT.IdOrdenTaller, 
                      Edehsa.com_ListadoElementos_x_OT.IdListadoElementos_x_OT, Edehsa.com_ListadoElementos_x_OT.FechaReg, Edehsa.com_ListadoElementos_x_OT.Estado, 
                      dbo.prd_Obra.Descripcion, dbo.prd_Orden_Taller.Codigo, Edehsa.com_ListadoElementos_x_OT.Usuario, Edehsa.com_ListadoElementos_x_OT.Motivo, 
                      Edehsa.com_ListadoElementos_x_OT.lm_Observacion, dbo.prd_Orden_Taller.IdSucursal, dbo.tb_sucursal.Su_Descripcion
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 2
               Left = 568
               Bottom = 230
               Right = 773
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 1
               Left = 9
               Bottom = 230
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 0
               Left = 805
               Bottom = 217
               Right = 1026
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ListadoElementos_x_OT (Edehsa)"
            Begin Extent = 
               Top = 2
               Left = 275
               Bottom = 218
               Right = 496
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
      Begin ColumnWidths = 12
         Column = 5325
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoElementos_x_OT';

