CREATE VIEW Edehsa.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle
AS
SELECT     Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdEmpresa, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdSucursal, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdBodega, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdMovi_inven_tipo, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdNumMovi, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdProducto, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.CodigoBarra, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.dm_cantidad, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.dm_observacion, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.CodObra_preasignada, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.Det_Kg, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.pr_largo, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_total, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_restante, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_pieza_entera, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.cantidad_pieza_entera, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_pieza_complementaria, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.cantidad_pieza_complementaria, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.cantidad_total_pieza_complementaria, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_despunte1, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.cantidad_despunte1, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.es_despunte_usable1, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.largo_despunte2, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.cantidad_despunte2, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.es_despunte_usable2, 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdEstadoAprob, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, 
                      dbo.in_Producto.IdCategoria, Edehsa.in_Producto_Dimensiones.longitud, Edehsa.in_Producto_Dimensiones.espesor, Edehsa.in_Producto_Dimensiones.ancho, 
                      Edehsa.in_Producto_Dimensiones.alto
FROM         Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det INNER JOIN
                      dbo.in_Producto INNER JOIN
                      Edehsa.in_Producto_Dimensiones ON dbo.in_Producto.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND 
                      dbo.in_Producto.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto ON 
                      Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.IdProducto = dbo.in_Producto.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4770
         Alias = 900
         Table = 1290
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[1] 2[23] 3) )"
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
         Left = -7
      End
      Begin Tables = 
         Begin Table = "com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 769
               Bottom = 338
               Right = 1084
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 0
               Left = 428
               Bottom = 450
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 11
               Left = 30
               Bottom = 201
               Right = 288
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
      Begin ColumnWidths = 33
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
         Width = 975
         Width = 990
         Width = 1200
      End
   End', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle';

