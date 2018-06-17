CREATE VIEW [mobileSCI].[vw_movimientos_det]
AS
SELECT        mobileSCI.tbl_movimientos_det.IdSincronizacion, mobileSCI.tbl_movimientos_det.IdSecuencia, mobileSCI.tbl_movimientos.IdUsuarioSCI, mobileSCI.tbl_movimientos_det.IdEmpresa, mobileSCI.tbl_movimientos_det.IdSucursal, 
                         mobileSCI.tbl_movimientos_det.IdBodega, mobileSCI.tbl_movimientos_det.IdProducto, mobileSCI.tbl_movimientos_det.IdUnidadMedida, mobileSCI.tbl_movimientos_det.IdCentroCosto, 
                         mobileSCI.tbl_movimientos_det.IdCentroCosto_sub_centro_costo, mobileSCI.tbl_movimientos_det.Fecha, mobileSCI.tbl_movimientos_det.cantidad, mobileSCI.tbl_movimientos_det.IdEmpresa_oc, 
                         mobileSCI.tbl_movimientos_det.IdSucursal_oc, mobileSCI.tbl_movimientos_det.IdOrdenCompra, mobileSCI.tbl_movimientos_det.secuencia_oc, dbo.in_Producto.pr_descripcion, 
                         dbo.in_UnidadMedida.Descripcion AS nom_unidad_medida, mobileSCI.tbl_movimientos_det.Aprobado, mobileSCI.tbl_movimientos_det.Estado, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, 
                         dbo.ct_centro_costo.Centro_costo AS nom_centro, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_subcentro, mobileSCI.tbl_movimientos.Fecha AS Fecha_sincronizacion, 
                         isnull(dbo.com_ordencompra_local_det.do_precioFinal,0) do_precioFinal
FROM            dbo.ct_centro_costo_sub_centro_costo RIGHT OUTER JOIN
                         dbo.com_ordencompra_local_det RIGHT OUTER JOIN
                         mobileSCI.tbl_movimientos INNER JOIN
                         mobileSCI.tbl_movimientos_det ON mobileSCI.tbl_movimientos.IdSincronizacion = mobileSCI.tbl_movimientos_det.IdSincronizacion INNER JOIN
                         dbo.in_Producto ON mobileSCI.tbl_movimientos_det.IdProducto = dbo.in_Producto.IdProducto AND mobileSCI.tbl_movimientos_det.IdEmpresa = dbo.in_Producto.IdEmpresa INNER JOIN
                         dbo.in_UnidadMedida ON mobileSCI.tbl_movimientos_det.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida INNER JOIN
                         dbo.tb_sucursal ON mobileSCI.tbl_movimientos_det.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND mobileSCI.tbl_movimientos_det.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.tb_bodega ON mobileSCI.tbl_movimientos_det.IdEmpresa = dbo.tb_bodega.IdEmpresa AND mobileSCI.tbl_movimientos_det.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         mobileSCI.tbl_movimientos_det.IdBodega = dbo.tb_bodega.IdBodega ON dbo.com_ordencompra_local_det.IdEmpresa = mobileSCI.tbl_movimientos_det.IdEmpresa_oc AND 
                         dbo.com_ordencompra_local_det.IdSucursal = mobileSCI.tbl_movimientos_det.IdSucursal_oc AND dbo.com_ordencompra_local_det.IdOrdenCompra = mobileSCI.tbl_movimientos_det.IdOrdenCompra AND 
                         dbo.com_ordencompra_local_det.Secuencia = mobileSCI.tbl_movimientos_det.secuencia_oc ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = mobileSCI.tbl_movimientos_det.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = mobileSCI.tbl_movimientos_det.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = mobileSCI.tbl_movimientos_det.IdCentroCosto_sub_centro_costo LEFT OUTER JOIN
                         dbo.ct_centro_costo ON mobileSCI.tbl_movimientos_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND mobileSCI.tbl_movimientos_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto
WHERE        (mobileSCI.tbl_movimientos_det.Aprobado = 0)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ordencompra_local_det"
            Begin Extent = 
               Top = 59
               Left = 635
               Bottom = 531
               Right = 898
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
      Begin ColumnWidths = 9
         Width = 284
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
', @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[59] 4[3] 2[3] 3) )"
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
         Begin Table = "tbl_movimientos (mobileSCI)"
            Begin Extent = 
               Top = 404
               Left = 77
               Bottom = 534
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_movimientos_det (mobileSCI)"
            Begin Extent = 
               Top = 15
               Left = 269
               Bottom = 395
               Right = 532
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 489
               Left = 33
               Bottom = 619
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 299
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
        ', @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_det';

