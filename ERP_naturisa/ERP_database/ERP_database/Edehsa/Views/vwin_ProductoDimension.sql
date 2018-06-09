CREATE VIEW Edehsa.vwin_ProductoDimension
AS
SELECT dbo.in_Producto.IdEmpresa, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_descripcion_2, dbo.in_Producto.IdProductoTipo, dbo.in_Producto.IdMarca, 
                  dbo.in_Producto.IdPresentacion, dbo.in_Producto.IdCategoria, dbo.in_Producto.IdLinea, dbo.in_Producto.IdGrupo, dbo.in_Producto.IdSubGrupo, dbo.in_Producto.IdUnidadMedida, 
                  dbo.in_Producto.IdUnidadMedida_Consumo, dbo.in_Producto.IdMotivo_Vta, dbo.in_Producto.IdNaturaleza, dbo.in_Producto.pr_codigo_barra, dbo.in_Producto.pr_precio_publico, dbo.in_Producto.pr_observacion, 
                  dbo.in_Producto.pr_precio_mayor, dbo.in_Producto.pr_precio_minimo, dbo.in_Producto.pr_precio_puerta, dbo.in_Producto.pr_ManejaIva, dbo.in_Producto.pr_ManejaSeries, dbo.in_Producto.pr_costo_fob, 
                  dbo.in_Producto.pr_costo_CIF, dbo.in_Producto.pr_costo_promedio, dbo.in_Producto.pr_DiasMaritimo, dbo.in_Producto.pr_DiasAereo, dbo.in_Producto.pr_DiasTerrestre, dbo.in_Producto.pr_largo, 
                  dbo.in_Producto.pr_profundidad, dbo.in_Producto.pr_alto, dbo.in_Producto.pr_peso, dbo.in_Producto.pr_imagenPeque, dbo.in_Producto.pr_imagen_Grande, dbo.in_Producto.pr_partidaArancel, 
                  dbo.in_Producto.pr_porcentajeArancel, dbo.in_Producto.pr_Por_descuento, dbo.in_Producto.pr_stock_maximo, dbo.in_Producto.pr_stock_minimo, dbo.in_Producto.IdUsuario, dbo.in_Producto.Fecha_Transac, 
                  dbo.in_Producto.IdUsuarioUltMod, dbo.in_Producto.Fecha_UltMod, dbo.in_Producto.IdUsuarioUltAnu, dbo.in_Producto.Fecha_UltAnu, dbo.in_Producto.pr_motivoAnulacion, dbo.in_Producto.nom_pc, dbo.in_Producto.ip, 
                  dbo.in_Producto.Estado, dbo.in_Producto.AnchoEspecifico, dbo.in_Producto.PesoEspecifico, dbo.in_Producto.ManejaKardex, dbo.in_Producto.IdCod_Impuesto_Iva, dbo.in_Producto.IdCod_Impuesto_Ice, 
                  dbo.in_Producto.Aparece_modu_Ventas, dbo.in_Producto.Aparece_modu_Compras, dbo.in_Producto.Aparece_modu_Inventario, dbo.in_Producto.Aparece_modu_Activo_F, Edehsa.in_Producto_Dimensiones.longitud, 
                  Edehsa.in_Producto_Dimensiones.espesor, Edehsa.in_Producto_Dimensiones.ancho, Edehsa.in_Producto_Dimensiones.alto, Edehsa.in_Producto_Dimensiones.ceja, Edehsa.in_Producto_Dimensiones.diametro, 
                  dbo.in_ProductoTipo.EsMateriaPrima, dbo.in_ProductoTipo.EsProductoTerminado
FROM     dbo.in_Producto INNER JOIN
                  Edehsa.in_Producto_Dimensiones ON dbo.in_Producto.IdEmpresa = Edehsa.in_Producto_Dimensiones.IdEmpresa AND dbo.in_Producto.IdProducto = Edehsa.in_Producto_Dimensiones.IdProducto INNER JOIN
                  dbo.in_ProductoTipo ON dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo AND 
                  dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_ProductoDimension';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'200
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3540
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_ProductoDimension';


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
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 28
               Left = 385
               Bottom = 338
               Right = 660
            End
            DisplayFlags = 280
            TopColumn = 50
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 35
               Left = 14
               Bottom = 328
               Right = 295
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_ProductoTipo"
            Begin Extent = 
               Top = 7
               Left = 700
               Bottom = 294
               Right = 944
            End
            DisplayFlags = 280
            TopColumn = 8
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 76
         Width = 284
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
         Width = 1', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwin_ProductoDimension';

