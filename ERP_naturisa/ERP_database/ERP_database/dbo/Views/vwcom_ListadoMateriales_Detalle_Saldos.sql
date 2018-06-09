CREATE VIEW dbo.vwcom_ListadoMateriales_Detalle_Saldos
AS
SELECT     dbo.vwcom_ListadoMateriales_Detalle.IdEmpresa, dbo.vwcom_ListadoMateriales_Detalle.CodObra, dbo.vwcom_ListadoMateriales_Detalle.IdOrdenTaller, 
                      dbo.vwcom_ListadoMateriales_Detalle.IdListadoMateriales, dbo.vwcom_ListadoMateriales_Detalle.IdDetalle, dbo.vwcom_ListadoMateriales_Detalle.IdProducto, 
                      dbo.vwcom_ListadoMateriales_Detalle.Unidades, dbo.vwcom_ListadoMateriales_Detalle.Det_Kg, dbo.vwcom_ListadoMateriales_Detalle.pr_codigo, 
                      dbo.vwcom_ListadoMateriales_Detalle.pr_descripcion, dbo.vwcom_ListadoMateriales_Detalle.IdEstadoAprob, dbo.vwcom_ListadoMateriales_Detalle.FechaReg, 
                      dbo.vwcom_ListadoMateriales_Detalle.Estado, dbo.vwcom_ListadoMateriales_Detalle.lm_Observacion, dbo.vwcom_ListadoMateriales_Detalle.IdSucursal, 
                      dbo.vwcom_ListadoMateriales_Detalle.Su_Descripcion, dbo.vwcom_ListadoMateriales_Detalle.IdCategoria, ISNULL(dbo.vwcom_cotizacion_compra_det_activa.saldo, 
                      dbo.vwcom_ListadoMateriales_Detalle.Unidades) AS saldo
FROM         dbo.vwcom_ListadoMateriales_Detalle LEFT OUTER JOIN
                      dbo.vwcom_cotizacion_compra_det_activa ON dbo.vwcom_ListadoMateriales_Detalle.IdSucursal = dbo.vwcom_cotizacion_compra_det_activa.IdSucursal AND 
                      dbo.vwcom_ListadoMateriales_Detalle.IdEmpresa = dbo.vwcom_cotizacion_compra_det_activa.IdEmpresa AND 
                      dbo.vwcom_ListadoMateriales_Detalle.IdProducto = dbo.vwcom_cotizacion_compra_det_activa.Idproducto AND 
                      dbo.vwcom_ListadoMateriales_Detalle.IdListadoMateriales = dbo.vwcom_cotizacion_compra_det_activa.IdListadoMateriales_lq AND 
                      dbo.vwcom_ListadoMateriales_Detalle.IdDetalle = dbo.vwcom_cotizacion_compra_det_activa.IdDetalle_lq
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_Detalle_Saldos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[20] 2[8] 3) )"
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
         Begin Table = "vwcom_ListadoMateriales_Detalle"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 301
               Right = 299
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwcom_cotizacion_compra_det_activa"
            Begin Extent = 
               Top = 63
               Left = 449
               Bottom = 284
               Right = 753
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
      Begin ColumnWidths = 19
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
         Width = 3195
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMateriales_Detalle_Saldos';

