/*[dbo].[vwin_in_Producto_x_tb_bodega_x_UnidadMedida]*/
CREATE VIEW dbo.vwin_producto
AS
SELECT mar.Descripcion, tip.tp_descripcion, cat.ca_Categoria, pr.IdEmpresa, pr.IdProducto, pr.pr_codigo, pr.pr_codigo_barra, pr.IdProductoTipo, pr.IdPresentacion, pr.IdCategoria, pr.pr_descripcion, pr.pr_observacion, pr.IdUnidadMedida, 
                  pr.pr_precio_publico, pr.pr_precio_mayor, pr.pr_precio_minimo, pr.pr_precio_puerta, CAST(0 AS float) AS pr_stock, 0 AS pr_pedidos, pr.pr_ManejaIva, pr.pr_ManejaSeries, pr.pr_costo_fob, pr.pr_costo_CIF, pr.pr_costo_promedio, 
                  pr.IdMarca, pr.pr_DiasMaritimo, pr.pr_DiasAereo, pr.pr_DiasTerrestre, pr.pr_largo, pr.pr_alto, pr.pr_profundidad, pr.pr_peso, pr.pr_imagenPeque, pr.pr_imagen_Grande, pr.pr_partidaArancel, pr.pr_porcentajeArancel, 
                  pr.pr_Por_descuento, pr.pr_stock_maximo, pr.pr_stock_minimo, pr.IdUsuario, pr.Fecha_Transac, pr.IdUsuarioUltMod, pr.Fecha_UltMod, pr.IdUsuarioUltAnu, pr.Fecha_UltAnu, pr.pr_motivoAnulacion, pr.nom_pc, pr.ip, pr.Estado, 
                  pr.pr_descripcion_2, pr.AnchoEspecifico, pr.PesoEspecifico, pr.IdLinea, pr.IdGrupo, pr.IdSubGrupo, pr.ManejaKardex, pr.IdNaturaleza, pr.IdMotivo_Vta, pr.IdUnidadMedida_Consumo, dbo.in_linea.nom_linea, dbo.in_grupo.nom_grupo, 
                  dbo.in_subgrupo.nom_subgrupo, pr.IdCod_Impuesto_Iva, pr.IdCod_Impuesto_Ice, pr.Aparece_modu_Ventas, pr.Aparece_modu_Compras, pr.Aparece_modu_Inventario, pr.Aparece_modu_Activo_F, tip.tp_ManejaInven, pr.IdFamilia, 
                  pr.mobile_cod_produccion
FROM     dbo.in_subgrupo INNER JOIN
                  dbo.in_categorias AS cat INNER JOIN
                  dbo.in_linea ON cat.IdEmpresa = dbo.in_linea.IdEmpresa AND cat.IdCategoria = dbo.in_linea.IdCategoria INNER JOIN
                  dbo.in_grupo ON dbo.in_linea.IdEmpresa = dbo.in_grupo.IdEmpresa AND dbo.in_linea.IdCategoria = dbo.in_grupo.IdCategoria AND dbo.in_linea.IdLinea = dbo.in_grupo.IdLinea ON 
                  dbo.in_subgrupo.IdEmpresa = dbo.in_grupo.IdEmpresa AND dbo.in_subgrupo.IdCategoria = dbo.in_grupo.IdCategoria AND dbo.in_subgrupo.IdLinea = dbo.in_grupo.IdLinea AND 
                  dbo.in_subgrupo.IdGrupo = dbo.in_grupo.IdGrupo RIGHT OUTER JOIN
                  dbo.in_Producto AS pr INNER JOIN
                  dbo.in_ProductoTipo AS tip ON pr.IdEmpresa = tip.IdEmpresa AND pr.IdProductoTipo = tip.IdProductoTipo ON dbo.in_subgrupo.IdEmpresa = pr.IdEmpresa AND dbo.in_subgrupo.IdCategoria = pr.IdCategoria AND 
                  dbo.in_subgrupo.IdLinea = pr.IdLinea AND dbo.in_subgrupo.IdGrupo = pr.IdGrupo AND dbo.in_subgrupo.IdSubgrupo = pr.IdSubGrupo LEFT OUTER JOIN
                  dbo.in_Marca AS mar ON pr.IdMarca = mar.IdMarca AND pr.IdEmpresa = mar.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 69
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
         Column = 3012
         Alias = 3636
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto';




GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[58] 4[3] 2[30] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[62] 3) )"
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
         Begin Table = "in_subgrupo"
            Begin Extent = 
               Top = 0
               Left = 551
               Bottom = 205
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat"
            Begin Extent = 
               Top = 11
               Left = 1295
               Bottom = 140
               Right = 1524
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_linea"
            Begin Extent = 
               Top = 177
               Left = 1323
               Bottom = 310
               Right = 1532
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "in_grupo"
            Begin Extent = 
               Top = 0
               Left = 968
               Bottom = 185
               Right = 1177
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pr"
            Begin Extent = 
               Top = 1
               Left = 123
               Bottom = 304
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tip"
            Begin Extent = 
               Top = 231
               Left = 967
               Bottom = 417
               Right = 1176
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "mar"
            Begin Extent = 
               Top = 406
               Left = 929
               Bottom = 535
               Right = 1138
            End
            DisplayFlags = 280
     ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_producto';





