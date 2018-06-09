/*ORDER BY cb_producto_elemento, dbo.prd_Movimiento_PteGrua.IdEtapaInicio*/
CREATE VIEW dbo.vwPRO_CUS_CID_Rpt012
AS
SELECT dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdSucursal, dbo.prd_Ensamblado_CusCider.CodObra, dbo.prd_Orden_Taller.Codigo AS orden_taller, 
                  producto_final.pr_descripcion AS producto_final, dbo.prd_Ensamblado_CusCider.CodigoBarra AS cb_producto_final, dbo.prd_Movimiento_PteGrua.IdEtapaInicio, dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente, 
                  dbo.prd_Ensamblado_Det_CusCider.CodigoBarra AS cb_producto_elemento, dbo.cp_proveedor.pr_nombre AS proveedor, dbo.prd_GrupoTrabajo.Descripcion AS subgrupo, 
                  dbo.prd_Movimiento_PteGrua.FechaFinProceso AS fecha_movi_inicio, dbo.prd_Movimiento_PteGrua.FechaTransaccion AS fecha_movi_fin, dbo.in_categorias.ca_Categoria, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.Alto, Edehsa.in_Producto_Dimensiones.ancho, Edehsa.in_Producto_Dimensiones.diametro, Edehsa.in_Producto_Dimensiones.ceja, 
                  Edehsa.in_Producto_Dimensiones.espesor, dbo.in_movi_inve_detalle_x_Producto_CusCider.Largo, persona_lider.pe_nombreCompleto AS lider, dbo.prd_Despacho.Chofer, dbo.prd_Despacho.Placa, 
                  dbo.prd_Despacho.TipoTransporte, dbo.prd_Despacho.FechaTransac AS fecha_despacho, producto_elemento.IdCategoria, dbo.prd_Ensamblado_CusCider.IdEnsamblado, 
                  dbo.in_movi_inve_detalle_x_Producto_CusCider.NumDocumentoRelacionadoProveedor, dbo.in_movi_inve_detalle_x_Producto_CusCider.NumFacturaProveedor
FROM     dbo.in_Producto AS producto_final INNER JOIN
                  dbo.prd_Despacho INNER JOIN
                  dbo.prd_Ensamblado_CusCider INNER JOIN
                  dbo.prd_Ensamblado_Det_CusCider ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Ensamblado_Det_CusCider.IdEmpresa AND 
                  dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Ensamblado_Det_CusCider.IdSucursal AND dbo.prd_Ensamblado_CusCider.IdEnsamblado = dbo.prd_Ensamblado_Det_CusCider.IdEnsamblado AND 
                  dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Ensamblado_Det_CusCider.IdEmpresa AND dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Ensamblado_Det_CusCider.IdSucursal AND 
                  dbo.prd_Ensamblado_CusCider.IdEnsamblado = dbo.prd_Ensamblado_Det_CusCider.IdEnsamblado ON dbo.prd_Despacho.IdEmpresa = dbo.prd_Ensamblado_CusCider.IdEmpresa AND 
                  dbo.prd_Despacho.IdSucursal = dbo.prd_Ensamblado_CusCider.IdSucursal AND dbo.prd_Despacho.IdDespacho = dbo.prd_Ensamblado_CusCider.IdDespacho ON 
                  producto_final.IdEmpresa = dbo.prd_Ensamblado_CusCider.IdEmpresa AND producto_final.IdProducto = dbo.prd_Ensamblado_CusCider.IdProducto INNER JOIN
                  dbo.prd_Orden_Taller ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                  dbo.prd_Ensamblado_CusCider.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller INNER JOIN
                  dbo.prd_Movimiento_PteGrua INNER JOIN
                  dbo.prd_GrupoTrabajo ON dbo.prd_Movimiento_PteGrua.IdEmpresa = dbo.prd_GrupoTrabajo.IdEmpresa AND dbo.prd_Movimiento_PteGrua.IdSucursal = dbo.prd_GrupoTrabajo.IdSucursal AND 
                  dbo.prd_Movimiento_PteGrua.IdSubgrupoAnt = dbo.prd_GrupoTrabajo.IdGrupoTrabajo AND dbo.prd_Movimiento_PteGrua.IdEmpresa = dbo.prd_GrupoTrabajo.IdEmpresa AND 
                  dbo.prd_Movimiento_PteGrua.IdSucursal = dbo.prd_GrupoTrabajo.IdSucursal AND dbo.prd_Movimiento_PteGrua.IdSubgrupoAnt = dbo.prd_GrupoTrabajo.IdGrupoTrabajo INNER JOIN
                  dbo.tb_persona AS persona_lider ON dbo.prd_GrupoTrabajo.IdLider = persona_lider.IdPersona ON dbo.prd_Ensamblado_Det_CusCider.IdEmpresa = dbo.prd_Movimiento_PteGrua.IdEmpresa AND 
                  dbo.prd_Ensamblado_Det_CusCider.IdSucursal = dbo.prd_Movimiento_PteGrua.IdSucursal AND dbo.prd_Ensamblado_Det_CusCider.CodigoBarra = dbo.prd_Movimiento_PteGrua.CodigoBarra LEFT OUTER JOIN
                  dbo.com_ordencompra_local INNER JOIN
                  dbo.in_categorias INNER JOIN
                  Edehsa.in_Producto_Dimensiones INNER JOIN
                  dbo.in_movi_inve_detalle_x_Producto_CusCider ON Edehsa.in_Producto_Dimensiones.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  Edehsa.in_Producto_Dimensiones.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto INNER JOIN
                  dbo.in_Producto AS producto_elemento ON Edehsa.in_Producto_Dimensiones.IdProducto = producto_elemento.IdProducto ON dbo.in_categorias.IdEmpresa = producto_elemento.IdEmpresa AND 
                  dbo.in_categorias.IdCategoria = producto_elemento.IdCategoria ON dbo.com_ordencompra_local.IdOrdenCompra = dbo.in_movi_inve_detalle_x_Producto_CusCider.ocd_IdOrdenCompra AND 
                  dbo.com_ordencompra_local.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  dbo.com_ordencompra_local.IdSucursal = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal INNER JOIN
                  dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor AND 
                  dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor ON 
                  dbo.prd_Ensamblado_Det_CusCider.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                  dbo.prd_Ensamblado_Det_CusCider.CodigoBarra = dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra AND 
                  dbo.prd_Ensamblado_Det_CusCider.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto
WHERE  (dbo.prd_Movimiento_PteGrua.IdEtapaInicio < dbo.prd_Movimiento_PteGrua.IdEtapaSiguiente)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Rpt012';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 662
               Right = 562
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "persona_lider"
            Begin Extent = 
               Top = 459
               Left = 0
               Bottom = 804
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ordencompra_local"
            Begin Extent = 
               Top = 0
               Left = 1885
               Bottom = 341
               Right = 2142
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_categorias"
            Begin Extent = 
               Top = 351
               Left = 2468
               Bottom = 637
               Right = 2736
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_Dimensiones (Edehsa)"
            Begin Extent = 
               Top = 364
               Left = 1794
               Bottom = 674
               Right = 2054
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle_x_Producto_CusCider"
            Begin Extent = 
               Top = 0
               Left = 1356
               Bottom = 703
               Right = 1630
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "producto_elemento"
            Begin Extent = 
               Top = 357
               Left = 2139
               Bottom = 835
               Right = 2390
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 0
               Left = 2497
               Bottom = 272
               Right = 2771
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
      Begin ColumnWidths = 28
         Width = 284
         Width = 1020
         Width = 984
         Width = 900
         Width = 1296
         Width = 1548
         Width = 3204
         Width = 1224
         Width = 1692
         Width = 3432
         Width = 888
         Width = 828
         Width = 2112
         Width = 2460
         Width = 696
         Width = 960
         Width = 504
         Width = 972
         Width = 996
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2160
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2988
         Alias = 2136
         Table = 2880
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 2172
         SortOrder = 2244
         GroupBy = 1356
         Filter = 4296
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Rpt012';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[8] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[51] 4[24] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[44] 2[32] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
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
         Configuration = "(V (3) )"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[23] 4[51] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[36] 4) )"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[31] 2) )"
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
         Top = -360
         Left = -735
      End
      Begin Tables = 
         Begin Table = "producto_final"
            Begin Extent = 
               Top = 0
               Left = 3
               Bottom = 178
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Despacho"
            Begin Extent = 
               Top = 191
               Left = 0
               Bottom = 464
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Ensamblado_CusCider"
            Begin Extent = 
               Top = 0
               Left = 450
               Bottom = 328
               Right = 676
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Ensamblado_Det_CusCider"
            Begin Extent = 
               Top = 0
               Left = 1008
               Bottom = 268
               Right = 1285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 111
               Left = 713
               Bottom = 335
               Right = 957
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "prd_Movimiento_PteGrua"
            Begin Extent = 
               Top = 331
               Left = 637
               Bottom = 914
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 356
               Left = 319
               Bottom', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwPRO_CUS_CID_Rpt012';

