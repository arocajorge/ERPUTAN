CREATE VIEW dbo.vwcom_cotizacion_compra_det
AS
SELECT     dbo.com_cotizacion_compra.IdEmpresa, dbo.com_cotizacion_compra.IdCotizacion, dbo.com_cotizacion_compra.IdSucursal, 
                      dbo.com_cotizacion_compra_det.Secuencia, dbo.com_cotizacion_compra_det.Idproducto, dbo.com_cotizacion_compra_det.Cant_soli, 
                      dbo.com_cotizacion_compra_det.Cant_a_cotizar, dbo.com_cotizacion_compra_det.IdListadoMateriales_lq, dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, 
                      dbo.vwcom_ListadoMateriales_Detalle.FechaReg, dbo.com_cotizacion_compra_det.IdDetalle_lq, dbo.in_Producto.pr_descripcion, 
                      dbo.com_cotizacion_compra.IdProveedor
FROM         dbo.com_cotizacion_compra INNER JOIN
                      dbo.com_cotizacion_compra_det ON dbo.com_cotizacion_compra.IdEmpresa = dbo.com_cotizacion_compra_det.IdEmpresa AND 
                      dbo.com_cotizacion_compra.IdCotizacion = dbo.com_cotizacion_compra_det.IdCotizacion INNER JOIN
                      dbo.tb_sucursal ON dbo.com_cotizacion_compra.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      dbo.com_cotizacion_compra.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.in_Producto ON dbo.com_cotizacion_compra_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.Idproducto = dbo.in_Producto.IdProducto LEFT OUTER JOIN
                      dbo.vwcom_ListadoMateriales_Detalle ON dbo.com_cotizacion_compra_det.IdDetalle_lq = dbo.vwcom_ListadoMateriales_Detalle.IdDetalle AND 
                      dbo.com_cotizacion_compra_det.Idproducto = dbo.vwcom_ListadoMateriales_Detalle.IdProducto AND 
                      dbo.com_cotizacion_compra_det.IdEmpresa = dbo.vwcom_ListadoMateriales_Detalle.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.IdListadoMateriales_lq = dbo.vwcom_ListadoMateriales_Detalle.IdListadoMateriales
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_cotizacion_compra_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'0
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3570
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_cotizacion_compra_det';


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
         Begin Table = "com_cotizacion_compra"
            Begin Extent = 
               Top = 0
               Left = 280
               Bottom = 108
               Right = 469
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_cotizacion_compra_det"
            Begin Extent = 
               Top = 6
               Left = 618
               Bottom = 207
               Right = 823
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 15
               Left = 15
               Bottom = 123
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 129
               Left = 16
               Bottom = 237
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcom_ListadoMateriales_Detalle"
            Begin Extent = 
               Top = 17
               Left = 935
               Bottom = 125
               Right = 1124
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
      Begin ColumnWidths = 14
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
         Width = 150', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_cotizacion_compra_det';

