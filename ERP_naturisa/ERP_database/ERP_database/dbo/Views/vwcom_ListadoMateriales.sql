CREATE VIEW dbo.vwcom_ListadoMateriales
AS
SELECT     dbo.com_ListadoMateriales.IdEmpresa, dbo.com_ListadoMateriales.CodObra, dbo.com_ListadoMateriales.IdOrdenTaller, 
                      dbo.com_ListadoMateriales.IdListadoMateriales, dbo.com_ListadoMateriales.FechaReg, dbo.com_ListadoMateriales.Estado, 
                      dbo.prd_Obra.Descripcion AS ob_descripcion, dbo.com_ListadoMateriales.Usuario, dbo.com_ListadoMateriales.Motivo, dbo.com_ListadoMateriales.lm_Observacion, 
                      dbo.tb_sucursal.Su_Descripcion, dbo.tb_sucursal.IdSucursal
FROM         dbo.com_ListadoMateriales INNER JOIN
                      dbo.prd_Obra ON dbo.com_ListadoMateriales.IdEmpresa = dbo.prd_Obra.IdEmpresa AND dbo.com_ListadoMateriales.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.tb_sucursal ON dbo.com_ListadoMateriales.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      dbo.com_ListadoMateriales.ot_IdSucursal = dbo.tb_sucursal.IdSucursal
GROUP BY dbo.com_ListadoMateriales.IdEmpresa, dbo.com_ListadoMateriales.CodObra, dbo.com_ListadoMateriales.IdOrdenTaller, 
                      dbo.com_ListadoMateriales.IdListadoMateriales, dbo.com_ListadoMateriales.FechaReg, dbo.com_ListadoMateriales.Estado, dbo.prd_Obra.Descripcion, 
                      dbo.com_ListadoMateriales.Usuario, dbo.com_ListadoMateriales.Motivo, dbo.com_ListadoMateriales.lm_Observacion, dbo.tb_sucursal.Su_Descripcion, 
                      dbo.tb_sucursal.IdSucursal
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[20] 2[24] 3) )"
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
         Begin Table = "com_ListadoMateriales"
            Begin Extent = 
               Top = 0
               Left = 262
               Bottom = 230
               Right = 467
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 4
               Left = 550
               Bottom = 237
               Right = 755
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 3
               Left = 8
               Bottom = 111
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 0
               Left = 792
               Bottom = 235
               Right = 980
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
   End
   Begin CriteriaPane = 
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales';

