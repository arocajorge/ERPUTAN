CREATE VIEW [dbo].[vvProd_Rpt_GestionProductivoTechos_CusTalme]
AS
SELECT     dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdGestionProductiva, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdProducto_MateriaPrima, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdModeloProd, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha, dbo.prod_GestionProductivaTechos_CusTalme_Cab.HrsTurno, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Tprep, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Despacho, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Factor, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Num_Personas, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Consumo, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Chatarra, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdTurno, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdUsuario, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_Transac, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdUsuarioUltModi, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_UltMod, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdusuarioUltAnu, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_UltAnu, dbo.prod_GestionProductivaTechos_CusTalme_Cab.nom_pc, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.ip, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Estado, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Secuencia, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_IdProducto, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_Largo, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_Ancho, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_PsoEsp, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_Espesor, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_PsoUnd, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prducc_Unidades, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prducc_Kg, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Segunda_IdProducto, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Segunda_Unidades, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Segunda_Kg, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Chatarra_Kg, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Peso, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Kg_Desp, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Rend_Metalico, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.KW, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Tiempo_Preparacion, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Tiempo_Produccion, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Tiempo_Total, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Parada_Mecanica, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Parada_Electrico, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Parada_Logistica, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Parada_Otros, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.TotalParos, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Indicadores_TnHrs, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Indicadores_TimeParda, dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Indicadores_UndsHrs, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Indicadores_Calidad, dbo.prod_ModeloProduccion_CusTalme.Descripcion, 
                      in_Producto_1.pr_descripcion AS MateriaPrima, dbo.prod_Turno.Descripcion AS Turno, dbo.in_Producto.pr_descripcion AS Producto, 
                      in_Producto_2.pr_descripcion AS ProductoDeSegunda
FROM         dbo.prod_ModeloProduccion_CusTalme INNER JOIN
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab ON 
                      dbo.prod_ModeloProduccion_CusTalme.IdModeloProd = dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdModeloProd INNER JOIN
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle ON 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa = dbo.prod_GestionProductivaTechos_CusTalme_Detalle.IdEmpresa AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdGestionProductiva = dbo.prod_GestionProductivaTechos_CusTalme_Detalle.IdGestionProductiva INNER JOIN
                      dbo.in_Producto AS in_Producto_1 ON dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa = in_Producto_1.IdEmpresa AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdProducto_MateriaPrima = in_Producto_1.IdProducto INNER JOIN
                      dbo.prod_Turno ON dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa = dbo.prod_Turno.IdEmpresa AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdTurno = dbo.prod_Turno.IdTurno INNER JOIN
                      dbo.in_Producto ON dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Prod_IdProducto = dbo.in_Producto.IdProducto AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.IdEmpresa = dbo.in_Producto.IdEmpresa INNER JOIN
                      dbo.in_Producto AS in_Producto_2 ON dbo.prod_GestionProductivaTechos_CusTalme_Detalle.IdEmpresa = in_Producto_2.IdEmpresa AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Detalle.Segunda_IdProducto = in_Producto_2.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vvProd_Rpt_GestionProductivoTechos_CusTalme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'eft = 54
               Bottom = 301
               Right = 254
            End
            DisplayFlags = 280
            TopColumn = 5
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vvProd_Rpt_GestionProductivoTechos_CusTalme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[7] 4[63] 2[8] 3) )"
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
         Begin Table = "prod_GestionProductivaTechos_CusTalme_Detalle"
            Begin Extent = 
               Top = 14
               Left = 333
               Bottom = 451
               Right = 534
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_GestionProductivaTechos_CusTalme_Cab"
            Begin Extent = 
               Top = 12
               Left = 564
               Bottom = 402
               Right = 774
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_ModeloProduccion_CusTalme"
            Begin Extent = 
               Top = 0
               Left = 828
               Bottom = 171
               Right = 1132
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_Turno"
            Begin Extent = 
               Top = 130
               Left = 1127
               Bottom = 265
               Right = 1287
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 9
               Left = 11
               Bottom = 106
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "in_Producto_1"
            Begin Extent = 
               Top = 232
               Left = 838
               Bottom = 351
               Right = 1038
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "in_Producto_2"
            Begin Extent = 
               Top = 182
               L', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vvProd_Rpt_GestionProductivoTechos_CusTalme';

