CREATE VIEW dbo.vwprd_DespachoSaldo
AS
SELECT dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdSucursal, dbo.prd_Ensamblado_CusCider.IdBodega, dbo.prd_Ensamblado_CusCider.IdEnsamblado, 
                  dbo.prd_Ensamblado_CusCider.CodObra, dbo.prd_Ensamblado_CusCider.IdOrdenTaller, dbo.prd_Ensamblado_CusCider.IdGrupoTrabajo, dbo.prd_Ensamblado_CusCider.IdProducto, 
                  dbo.prd_Ensamblado_CusCider.CodigoBarra, dbo.prd_Ensamblado_CusCider.IdUsuario, dbo.prd_Ensamblado_CusCider.IdUsuarioAnu, dbo.prd_Ensamblado_CusCider.MotivoAnu, 
                  dbo.prd_Ensamblado_CusCider.IdUsuarioUltModi, dbo.prd_Ensamblado_CusCider.FechaAnu, dbo.prd_Ensamblado_CusCider.FechaTransac, dbo.prd_Ensamblado_CusCider.FechaUltModi, 
                  dbo.prd_Ensamblado_CusCider.Estado, dbo.prd_Ensamblado_CusCider.Observacion, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, dbo.in_Producto.pr_precio_publico, 
                  dbo.in_Producto.pr_precio_mayor, dbo.in_Producto.pr_precio_minimo, dbo.in_Producto.pr_precio_puerta, 0 AS pr_stock, dbo.in_Producto.pr_descripcion_2
FROM     dbo.prd_Ensamblado_CusCider INNER JOIN
                  dbo.in_Producto ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.prd_Ensamblado_CusCider.IdProducto = dbo.in_Producto.IdProducto
GROUP BY dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdSucursal, dbo.prd_Ensamblado_CusCider.IdBodega, dbo.prd_Ensamblado_CusCider.IdEnsamblado, 
                  dbo.prd_Ensamblado_CusCider.CodObra, dbo.prd_Ensamblado_CusCider.IdOrdenTaller, dbo.prd_Ensamblado_CusCider.IdGrupoTrabajo, dbo.prd_Ensamblado_CusCider.IdProducto, 
                  dbo.prd_Ensamblado_CusCider.CodigoBarra, dbo.prd_Ensamblado_CusCider.IdUsuario, dbo.prd_Ensamblado_CusCider.IdUsuarioAnu, dbo.prd_Ensamblado_CusCider.MotivoAnu, 
                  dbo.prd_Ensamblado_CusCider.IdUsuarioUltModi, dbo.prd_Ensamblado_CusCider.FechaAnu, dbo.prd_Ensamblado_CusCider.FechaTransac, dbo.prd_Ensamblado_CusCider.FechaUltModi, 
                  dbo.prd_Ensamblado_CusCider.Estado, dbo.prd_Ensamblado_CusCider.Observacion, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, dbo.in_Producto.pr_precio_publico, 
                  dbo.in_Producto.pr_precio_mayor, dbo.in_Producto.pr_precio_minimo, dbo.in_Producto.pr_precio_puerta, dbo.in_Producto.pr_descripcion_2
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_DespachoSaldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[32] 2[13] 3) )"
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
         Begin Table = "prd_Ensamblado_CusCider"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 17
               Left = 483
               Bottom = 224
               Right = 774
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
      Begin ColumnWidths = 12
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1848
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_DespachoSaldo';

