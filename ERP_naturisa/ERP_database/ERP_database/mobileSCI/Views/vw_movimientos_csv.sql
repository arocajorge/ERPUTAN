CREATE VIEW mobileSCI.vw_movimientos_csv
AS
SELECT        mobileSCI.tbl_movimientos_det.IdSincronizacion, mobileSCI.tbl_movimientos_det.IdSecuencia, dbo.in_movi_inve_detalle.IdEmpresa, dbo.in_movi_inve_detalle.IdSucursal, dbo.in_movi_inve_detalle.IdBodega, 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo, dbo.in_movi_inve_detalle.IdNumMovi, dbo.in_movi_inve_detalle.Secuencia, dbo.in_movi_inve_detalle.IdCentroCosto, dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo, 
                         dbo.ct_centro_costo.Centro_costo AS NomCentroCosto, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS NomSubCentro, dbo.ct_centro_costo_sub_centro_costo.mobile_cod_produccion AS CodProduccionSC, 
                         dbo.in_Producto.pr_descripcion, dbo.in_Producto.mobile_cod_produccion AS CodProduccionPro, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, ISNULL(ABS(dbo.in_movi_inve_detalle.dm_cantidad), 0) 
                         AS Cantidad, dbo.in_movi_inve_detalle.IdProducto, mobileSCI.tbl_movimientos_det.Fecha, dbo.in_movi_inve_detalle.IdUnidadMedida, mobileSCI.tbl_movimientos_det.Peso
FROM            dbo.tb_sucursal INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.in_movi_inve_detalle INNER JOIN
                         mobileSCI.tbl_movimientos_det INNER JOIN
                         mobileSCI.tbl_movimientos_det_apro ON mobileSCI.tbl_movimientos_det.IdSincronizacion = mobileSCI.tbl_movimientos_det_apro.IdSincronizacion AND 
                         mobileSCI.tbl_movimientos_det.IdSecuencia = mobileSCI.tbl_movimientos_det_apro.IdSecuencia INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON mobileSCI.tbl_movimientos_det_apro.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND mobileSCI.tbl_movimientos_det_apro.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         mobileSCI.tbl_movimientos_det_apro.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND mobileSCI.tbl_movimientos_det_apro.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi AND 
                         mobileSCI.tbl_movimientos_det_apro.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv AND 
                         dbo.in_movi_inve_detalle.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_inv AND dbo.in_movi_inve_detalle.IdBodega = dbo.in_Ing_Egr_Inven_det.IdBodega_inv AND 
                         dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv AND dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv AND 
                         dbo.in_movi_inve_detalle.Secuencia = dbo.in_Ing_Egr_Inven_det.secuencia_inv INNER JOIN
                         dbo.tb_bodega ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_movi_inve_detalle.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.in_movi_inve_detalle.IdBodega = dbo.tb_bodega.IdBodega ON dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.in_movi_inve_detalle.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = dbo.in_movi_inve_detalle.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.in_movi_inve_detalle.IdEmpresa INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto ON 
                         dbo.tb_sucursal.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.tb_bodega.IdSucursal INNER JOIN
                         dbo.in_Producto ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_movi_inve_detalle.IdProducto = dbo.in_Producto.IdProducto
WHERE        (mobileSCI.tbl_movimientos_det.Estado = 'A') AND (mobileSCI.tbl_movimientos_det.IdCentroCosto_sub_centro_costo IS NOT NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_csv';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 38
               Bottom = 928
               Right = 299
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 534
               Left = 262
               Bottom = 664
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 272
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
', @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_csv';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[60] 4[3] 2[3] 3) )"
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
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve_detalle"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_movimientos_det (mobileSCI)"
            Begin Extent = 
               Top = 239
               Left = 818
               Bottom = 628
               Right = 1081
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_movimientos_det_apro (mobileSCI)"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Ing_Egr_Inven_det"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 798
               Left ', @level0type = N'SCHEMA', @level0name = N'mobileSCI', @level1type = N'VIEW', @level1name = N'vw_movimientos_csv';

