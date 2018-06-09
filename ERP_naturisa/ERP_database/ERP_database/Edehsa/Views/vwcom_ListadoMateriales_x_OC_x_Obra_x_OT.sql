CREATE VIEW Edehsa.vwcom_ListadoMateriales_x_OC_x_Obra_x_OT
AS
SELECT     TOP (100) PERCENT Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdEmpresa, Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdSucursal, 
                      Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdOrdenCompra, dbo.com_cotizacion_compra_det.Idproducto, dbo.com_ListadoMateriales_Det.CodObra, 
                      dbo.com_ListadoMateriales_Det.IdOrdenTaller
FROM         Edehsa.com_Registro_OrdenCompra_x_Cotizacion INNER JOIN
                      dbo.com_cotizacion_compra_det ON Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdCotizacion = dbo.com_cotizacion_compra_det.IdCotizacion AND 
                      Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdEmpresa = dbo.com_cotizacion_compra_det.IdEmpresa INNER JOIN
                      dbo.com_ListadoMateriales_Det ON dbo.com_cotizacion_compra_det.IdEmpresa_lq = dbo.com_ListadoMateriales_Det.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.IdListadoMateriales_lq = dbo.com_ListadoMateriales_Det.IdListadoMateriales AND 
                      dbo.com_cotizacion_compra_det.IdDetalle_lq = dbo.com_ListadoMateriales_Det.IdDetalle AND 
                      dbo.com_cotizacion_compra_det.IdEmpresa_lq = dbo.com_ListadoMateriales_Det.IdEmpresa AND 
                      dbo.com_cotizacion_compra_det.IdListadoMateriales_lq = dbo.com_ListadoMateriales_Det.IdListadoMateriales AND 
                      dbo.com_cotizacion_compra_det.IdDetalle_lq = dbo.com_ListadoMateriales_Det.IdDetalle AND 
                      dbo.com_cotizacion_compra_det.Idproducto = dbo.com_ListadoMateriales_Det.IdProducto
ORDER BY Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdEmpresa, Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdSucursal, 
                      Edehsa.com_Registro_OrdenCompra_x_Cotizacion.IdOrdenCompra, dbo.com_cotizacion_compra_det.Idproducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_x_OC_x_Obra_x_OT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[32] 2[15] 3) )"
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
         Begin Table = "com_Registro_OrdenCompra_x_Cotizacion (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 8
               Bottom = 164
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_cotizacion_compra_det"
            Begin Extent = 
               Top = 4
               Left = 284
               Bottom = 265
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ListadoMateriales_Det"
            Begin Extent = 
               Top = 0
               Left = 713
               Bottom = 239
               Right = 902
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_x_OC_x_Obra_x_OT';

