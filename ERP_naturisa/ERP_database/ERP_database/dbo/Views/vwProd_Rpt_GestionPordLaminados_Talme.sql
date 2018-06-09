CREATE VIEW [dbo].[vwProd_Rpt_GestionPordLaminados_Talme]
AS
SELECT     dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa, dbo.vwProd_GestionProductivaTalmeLaminado.IdGestionProductiva, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdTurno, dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpleado_JefeTurno, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_MateriaPrima, dbo.vwProd_GestionProductivaTalmeLaminado.Id_Bobina, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Num_Orden, dbo.vwProd_GestionProductivaTalmeLaminado.kg_Cargados, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.kg_producidos, dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_Producido1, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.unidades_prd_1, dbo.vwProd_GestionProductivaTalmeLaminado.pesokg_prd_1, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_Producido2, dbo.vwProd_GestionProductivaTalmeLaminado.unidades_prd_2, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.pesokg_prd_2, dbo.vwProd_GestionProductivaTalmeLaminado.kg_retazo_porcen, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.kg_retazo_valor, dbo.vwProd_GestionProductivaTalmeLaminado.kg_chatarra_porcen, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.kg_chatarra_valor, dbo.vwProd_GestionProductivaTalmeLaminado.kg_oxidacion_porcen, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.kg_oxidacion_valor, dbo.vwProd_GestionProductivaTalmeLaminado.rendi_metal_historico, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.rendi_metal_real, dbo.vwProd_GestionProductivaTalmeLaminado.rendi_metal_Diferencia, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.consumo_kilowatios, dbo.vwProd_GestionProductivaTalmeLaminado.consumo_galones, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.cambio_prue_programado, dbo.vwProd_GestionProductivaTalmeLaminado.cambio_prue_real, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.cambio_prue_porcentaje, dbo.vwProd_GestionProductivaTalmeLaminado.hora_turno_ini, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.hora_turno_fin, dbo.vwProd_GestionProductivaTalmeLaminado.hora_jornada, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.hora_productiva, dbo.vwProd_GestionProductivaTalmeLaminado.hora_Paros, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.hora_Neta, dbo.vwProd_GestionProductivaTalmeLaminado.hora_Hrs_Maquina, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Ton_Programada, dbo.vwProd_GestionProductivaTalmeLaminado.Ton_real, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Ton_Eficiencia, dbo.vwProd_GestionProductivaTalmeLaminado.Ton_TnHrNeta, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Ton_kwTon, dbo.vwProd_GestionProductivaTalmeLaminado.Ton_GlsTon, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.EficienciaProduccion, dbo.vwProd_GestionProductivaTalmeLaminado.Estado, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Fecha, dbo.vwProd_GestionProductivaTalmeLaminado.Descripcion, 
                      dbo.vwProd_GestionProductivaTalmeLaminado.Nombre_JefeTurno, dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.IdTipoParada, 
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.Secuencia, dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.HoraIni, 
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.HoraFin, dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.Descripcion AS Descripcion_Det, 
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.causa, dbo.in_Producto.pr_descripcion AS Materia_Prima, in_Producto_1.pr_descripcion AS Producto_1, 
                      in_Producto_2.pr_descripcion AS Producto_2, dbo.prod_Turno.Descripcion AS Descripcion_Turno, 
                      dbo.prod_TipoParada_CusTalme.Descripcion AS DescripcionTipoParada
FROM         dbo.prod_TipoParada_CusTalme INNER JOIN
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme ON 
                      dbo.prod_TipoParada_CusTalme.IdTipoParada = dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.IdTipoParada RIGHT OUTER JOIN
                      dbo.vwProd_GestionProductivaTalmeLaminado INNER JOIN
                      dbo.in_Producto ON dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_MateriaPrima = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.in_Producto AS in_Producto_1 ON dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa = in_Producto_1.IdEmpresa AND 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_Producido1 = in_Producto_1.IdProducto INNER JOIN
                      dbo.in_Producto AS in_Producto_2 ON dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa = in_Producto_2.IdEmpresa AND 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdProducto_Producido2 = in_Producto_2.IdProducto INNER JOIN
                      dbo.prod_Turno ON dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa = dbo.prod_Turno.IdEmpresa AND 
                      dbo.vwProd_GestionProductivaTalmeLaminado.IdTurno = dbo.prod_Turno.IdTurno ON 
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.IdEmpresa = dbo.vwProd_GestionProductivaTalmeLaminado.IdEmpresa AND 
                      dbo.prod_GestionProductivaLaminado_x_paradas_CusTalme.IdGestionProductiva = dbo.vwProd_GestionProductivaTalmeLaminado.IdGestionProductiva
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_Rpt_GestionPordLaminados_Talme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 249
               Bottom = 336
               Right = 409
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
      Begin ColumnWidths = 59
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1755
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_Rpt_GestionPordLaminados_Talme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[8] 2[25] 3) )"
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
         Top = -384
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vwProd_GestionProductivaTalmeLaminado"
            Begin Extent = 
               Top = 0
               Left = 330
               Bottom = 247
               Right = 544
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_GestionProductivaLaminado_x_paradas_CusTalme"
            Begin Extent = 
               Top = 0
               Left = 1136
               Bottom = 278
               Right = 1305
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 5
               Left = 45
               Bottom = 265
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_1"
            Begin Extent = 
               Top = 266
               Left = 954
               Bottom = 385
               Right = 1154
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "in_Producto_2"
            Begin Extent = 
               Top = 260
               Left = 560
               Bottom = 379
               Right = 760
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "prod_Turno"
            Begin Extent = 
               Top = 190
               Left = 737
               Bottom = 309
               Right = 897
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "prod_TipoParada_CusTalme"
            Begin Extent = 
               Top = 232
               Left', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_Rpt_GestionPordLaminados_Talme';

