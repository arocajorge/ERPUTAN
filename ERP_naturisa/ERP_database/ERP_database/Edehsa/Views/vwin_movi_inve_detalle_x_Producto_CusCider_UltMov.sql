CREATE VIEW Edehsa.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov
AS
SELECT dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, 
                  SUM(dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad) AS dm_cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, dbo.in_movi_inve.Fecha_Transac, dbo.in_movi_inve.cm_fecha, 
                  dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.tb_bodega.bo_Descripcion AS bodega, dbo.in_Producto.pr_observacion AS observacion, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_precio, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_costo, Edehsa.in_Producto_Dimensiones.longitud, Edehsa.in_Producto_Dimensiones.espesor, Edehsa.in_Producto_Dimensiones.ancho, 
                  Edehsa.in_Producto_Dimensiones.alto, Edehsa.in_Producto_Dimensiones.ceja, Edehsa.in_Producto_Dimensiones.diametro, Edehsa.in_Categoria_x_Formula.descripcion_corta, 
                  Edehsa.in_Categoria_x_Formula.densidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, dbo.in_Producto.pr_peso, dbo.in_Producto.PesoEspecifico, dbo.in_movi_inve_detalle_x_Producto_CusCider.secmax, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo AS largo_conversion, dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto AS alto_conversion, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad AS cantidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.CodObra_preasignada, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdOrdenTaller_preasignada, dbo.in_movi_inve_detalle_x_Producto_CusCider.ocd_IdOrdenCompra, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.NumDocumentoRelacionadoProveedor, dbo.in_movi_inve_detalle_x_Producto_CusCider.NumFacturaProveedor
FROM     dbo.in_movi_inve_detalle_x_Producto_CusCider INNER JOIN
                  dbo.in_movi_inve ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.in_movi_inve.IdSucursal AND 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega = dbo.in_movi_inve.IdBodega AND dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi = dbo.in_movi_inve.IdNumMovi AND 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo = dbo.in_movi_inve.IdMovi_inven_tipo INNER JOIN
                  dbo.in_Producto ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      (SELECT MAX(secmax) AS secmax, CodigoBarra
                       FROM      dbo.in_movi_inve_detalle_x_Producto_CusCider AS in_movi_inve_detalle_x_Producto_CusCider_1
                       GROUP BY CodigoBarra) AS maxmovi ON maxmovi.secmax = dbo.in_movi_inve_detalle_x_Producto_CusCider.secmax AND 
                  maxmovi.CodigoBarra = dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra INNER JOIN
                  Edehsa.in_Categoria_x_Formula ON dbo.in_Producto.IdEmpresa = Edehsa.in_Categoria_x_Formula.IdEmpresa AND dbo.in_Producto.IdCategoria = Edehsa.in_Categoria_x_Formula.IdCategoria INNER JOIN
                  Edehsa.in_Producto_Dimensiones ON dbo.in_Producto.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND dbo.in_Producto.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto INNER JOIN
                  dbo.tb_bodega ON dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega = dbo.tb_bodega.IdBodega
GROUP BY dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto, dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, dbo.in_movi_inve.Fecha_Transac, dbo.in_movi_inve.cm_fecha, dbo.in_Producto.pr_codigo, 
                  dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_precio, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_costo, 
                  Edehsa.in_Producto_Dimensiones.longitud, Edehsa.in_Producto_Dimensiones.espesor, Edehsa.in_Producto_Dimensiones.ancho, Edehsa.in_Producto_Dimensiones.alto, Edehsa.in_Producto_Dimensiones.ceja, 
                  Edehsa.in_Producto_Dimensiones.diametro, Edehsa.in_Categoria_x_Formula.descripcion_corta, Edehsa.in_Categoria_x_Formula.densidad, dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, dbo.in_Producto.pr_peso, 
                  dbo.in_Producto.PesoEspecifico, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, dbo.in_movi_inve_detalle_x_Producto_CusCider.secmax, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, dbo.tb_bodega.bo_Descripcion, dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo, dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.CodObra_preasignada, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdOrdenTaller_preasignada, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.ocd_IdOrdenCompra, dbo.in_movi_inve_detalle_x_Producto_CusCider.NumDocumentoRelacionadoProveedor, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.NumFacturaProveedor
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_movi_inve_detalle_x_Producto_CusCider_UltMov';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Bottom = 280
               Right = 564
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
      Begin ColumnWidths = 39
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1512
         Width = 4800
         Width = 1500
         Width = 1500
         Width = 2148
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
         Width = 1632
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 3360
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_movi_inve_detalle_x_Producto_CusCider_UltMov';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[9] 2[29] 3) )"
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
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 0
               Left = 602
               Bottom = 282
               Right = 835
            End
            DisplayFlags = 280
            TopColumn = 21
         End
         Begin Table = "in_movi_inve"
            Begin Extent = 
               Top = 0
               Left = 895
               Bottom = 214
               Right = 1240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 0
               Left = 352
               Bottom = 219
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "maxmovi"
            Begin Extent = 
               Top = 217
               Left = 893
               Bottom = 307
               Right = 1098
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Categoria_x_Formula (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 5
               Bottom = 131
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 134
               Left = 8
               Bottom = 283
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 172
               Left = 300
               ', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_movi_inve_detalle_x_Producto_CusCider_UltMov';

