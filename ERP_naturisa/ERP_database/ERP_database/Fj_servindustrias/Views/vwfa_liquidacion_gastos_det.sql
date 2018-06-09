CREATE VIEW Fj_servindustrias.vwfa_liquidacion_gastos_det
AS
SELECT        Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa, Fj_servindustrias.fa_liquidacion_gastos_det.IdLiquidacion, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.secuencia, Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.detalle_x_producto, Fj_servindustrias.fa_liquidacion_gastos_det.cantidad, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.precio, Fj_servindustrias.fa_liquidacion_gastos_det.subtotal, Fj_servindustrias.fa_liquidacion_gastos_det.aplica_iva, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.por_iva, Fj_servindustrias.fa_liquidacion_gastos_det.valor_iva, Fj_servindustrias.fa_liquidacion_gastos_det.Total_liq, 
                         Fj_servindustrias.fa_liquidacion_gastos_producto.nom_producto_Liqui, Fj_servindustrias.fa_liquidacion_gastos_producto.IdProducto
FROM            Fj_servindustrias.fa_liquidacion_gastos_det INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos_producto ON 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_producto.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui = Fj_servindustrias.fa_liquidacion_gastos_producto.IdProducto_Liqui
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_liquidacion_gastos_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[66] 4[4] 2[12] 3) )"
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
         Begin Table = "fa_liquidacion_gastos_det (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 350
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_liquidacion_gastos_producto (Fj_servindustrias)"
            Begin Extent = 
               Top = 88
               Left = 428
               Bottom = 282
               Right = 767
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_liquidacion_gastos_det';

