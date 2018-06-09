CREATE VIEW dbo.vwcom_cotizacion_compra_det_Saldos
AS
SELECT     dbo.vwcom_cotizacion_compra_det.IdEmpresa, dbo.vwcom_cotizacion_compra_det.IdCotizacion, dbo.vwcom_cotizacion_compra_det.IdSucursal, 
                      dbo.vwcom_cotizacion_compra_det.Secuencia, dbo.vwcom_cotizacion_compra_det.Idproducto, dbo.vwcom_cotizacion_compra_det.Cant_soli, 
                      dbo.vwcom_cotizacion_compra_det.Cant_a_cotizar, dbo.vwcom_cotizacion_compra_det.IdListadoMateriales_lq, dbo.vwcom_cotizacion_compra_det.nom_sucursal, 
                      dbo.vwcom_cotizacion_compra_det.FechaReg, dbo.vwcom_cotizacion_compra_det.IdDetalle_lq, dbo.vwcom_cotizacion_compra_det.pr_descripcion, 
                      dbo.vwcom_ListadoMateriales_Detalle_Saldos.saldo, dbo.vwcom_cotizacion_compra_det.IdProveedor
FROM         dbo.vwcom_cotizacion_compra_det INNER JOIN
                      dbo.vwcom_ListadoMateriales_Detalle_Saldos ON dbo.vwcom_cotizacion_compra_det.IdEmpresa = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdEmpresa AND 
                      dbo.vwcom_cotizacion_compra_det.IdListadoMateriales_lq = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdListadoMateriales AND 
                      dbo.vwcom_cotizacion_compra_det.IdDetalle_lq = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdDetalle AND 
                      dbo.vwcom_cotizacion_compra_det.Idproducto = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdProducto AND 
                      dbo.vwcom_cotizacion_compra_det.IdSucursal = dbo.vwcom_ListadoMateriales_Detalle_Saldos.IdSucursal
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_cotizacion_compra_det_Saldos';


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
         Begin Table = "vwcom_ListadoMateriales_Detalle_Saldos"
            Begin Extent = 
               Top = 11
               Left = 534
               Bottom = 282
               Right = 903
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcom_cotizacion_compra_det"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 255
               Right = 339
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_cotizacion_compra_det_Saldos';

