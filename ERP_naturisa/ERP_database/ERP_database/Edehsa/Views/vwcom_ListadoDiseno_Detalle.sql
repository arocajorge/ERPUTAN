CREATE VIEW Edehsa.vwcom_ListadoDiseno_Detalle
AS
SELECT     Edehsa.com_ListadoDiseno_Det.IdEmpresa, Edehsa.com_ListadoDiseno_Det.IdListadoDiseno, Edehsa.com_ListadoDiseno_Det.CodObra, 
                      Edehsa.com_ListadoDiseno_Det.IdOrdenTaller, Edehsa.com_ListadoDiseno_Det.IdDetalle, Edehsa.com_ListadoDiseno_Det.IdProducto, 
                      Edehsa.com_ListadoDiseno_Det.Unidades, Edehsa.com_ListadoDiseno_Det.Det_Kg, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, 
                      Edehsa.com_ListadoDiseno_Det.IdEstadoAprob, Edehsa.vwcom_ListadoDiseno.FechaReg, Edehsa.vwcom_ListadoDiseno.Estado, 
                      Edehsa.vwcom_ListadoDiseno.lm_Observacion, Edehsa.vwcom_ListadoDiseno.IdSucursal, Edehsa.vwcom_ListadoDiseno.Su_Descripcion, 
                      dbo.in_Producto.IdCategoria, Edehsa.vwcom_ListadoDiseno.tipo_listado
FROM         Edehsa.com_ListadoDiseno_Det INNER JOIN
                      dbo.in_Producto ON Edehsa.com_ListadoDiseno_Det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      Edehsa.com_ListadoDiseno_Det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      Edehsa.vwcom_ListadoDiseno ON Edehsa.com_ListadoDiseno_Det.IdEmpresa = Edehsa.vwcom_ListadoDiseno.IdEmpresa AND 
                      Edehsa.com_ListadoDiseno_Det.IdListadoDiseno = Edehsa.vwcom_ListadoDiseno.IdListadoDiseno AND 
                      Edehsa.com_ListadoDiseno_Det.CodObra = Edehsa.vwcom_ListadoDiseno.CodObra
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[25] 2[22] 3) )"
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
         Begin Table = "com_ListadoDiseno_Det (Edehsa)"
            Begin Extent = 
               Top = 3
               Left = 299
               Bottom = 209
               Right = 547
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 6
               Left = 16
               Bottom = 114
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcom_ListadoDiseno (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 714
               Bottom = 228
               Right = 934
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
      Begin ColumnWidths = 19
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3645
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
         Or = 1350', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoDiseno_Detalle';

