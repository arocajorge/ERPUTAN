CREATE VIEW Edehsa.vwcom_ListadoDiseno
AS
SELECT     Edehsa.com_ListadoDiseno.IdEmpresa, Edehsa.com_ListadoDiseno.IdListadoDiseno, Edehsa.com_ListadoDiseno.CodObra, 
                      Edehsa.com_ListadoDiseno.IdOrdenTaller, Edehsa.com_ListadoDiseno.FechaReg, Edehsa.com_ListadoDiseno.Estado, dbo.prd_Obra.Descripcion AS ob_descripcion, 
                      Edehsa.com_ListadoDiseno.Usuario, Edehsa.com_ListadoDiseno.Motivo, Edehsa.com_ListadoDiseno.lm_Observacion, Edehsa.com_ListadoDiseno.tipo_listado, 
                      dbo.tb_sucursal.Su_Descripcion, Edehsa.com_ListadoDiseno.ot_IdSucursal AS IdSucursal, Edehsa.com_ListadoDisenoTipo.TipoListadoDiseno
FROM         Edehsa.com_ListadoDiseno INNER JOIN
                      dbo.prd_Obra ON Edehsa.com_ListadoDiseno.IdEmpresa = dbo.prd_Obra.IdEmpresa AND Edehsa.com_ListadoDiseno.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.tb_sucursal ON Edehsa.com_ListadoDiseno.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      Edehsa.com_ListadoDiseno.ot_IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      Edehsa.com_ListadoDisenoTipo ON Edehsa.com_ListadoDiseno.IdEmpresa = Edehsa.com_ListadoDisenoTipo.IdEmpresa AND 
                      Edehsa.com_ListadoDiseno.tipo_listado = Edehsa.com_ListadoDisenoTipo.IdTipoListadoDiseno
GROUP BY Edehsa.com_ListadoDiseno.IdEmpresa, Edehsa.com_ListadoDiseno.CodObra, Edehsa.com_ListadoDiseno.IdOrdenTaller, Edehsa.com_ListadoDiseno.FechaReg, 
                      Edehsa.com_ListadoDiseno.Estado, dbo.prd_Obra.Descripcion, Edehsa.com_ListadoDiseno.Usuario, Edehsa.com_ListadoDiseno.Motivo, 
                      Edehsa.com_ListadoDiseno.lm_Observacion, Edehsa.com_ListadoDiseno.tipo_listado, dbo.tb_sucursal.Su_Descripcion, 
                      Edehsa.com_ListadoDiseno.IdListadoDiseno, Edehsa.com_ListadoDiseno.ot_IdSucursal, Edehsa.com_ListadoDisenoTipo.TipoListadoDiseno
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'e = 1170
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno';


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
         Begin Table = "com_ListadoDiseno (Edehsa)"
            Begin Extent = 
               Top = 15
               Left = 327
               Bottom = 218
               Right = 742
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 7
               Left = 10
               Bottom = 115
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 116
               Left = 3
               Bottom = 224
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ListadoDisenoTipo (Edehsa)"
            Begin Extent = 
               Top = 40
               Left = 770
               Bottom = 148
               Right = 975
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
      Begin ColumnWidths = 15
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1980
         Alias = 900
         Table = 2805
         Output = 720
         Append = 1400
         NewValu', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno';

