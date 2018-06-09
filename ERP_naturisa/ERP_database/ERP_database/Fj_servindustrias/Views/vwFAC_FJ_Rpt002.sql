CREATE VIEW Fj_servindustrias.vwFAC_FJ_Rpt002
AS
SELECT        Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa, Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo, 
                         Fj_servindustrias.fa_liquidacion_gastos.cod_liquidacion, Fj_servindustrias.fa_liquidacion_gastos.IdCliente, Fj_servindustrias.fa_liquidacion_gastos.fecha_liqui, 
                         Fj_servindustrias.fa_liquidacion_gastos.Observacion, Fj_servindustrias.fa_liquidacion_gastos.estado, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_apellido, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.secuencia, Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.detalle_x_producto, Fj_servindustrias.fa_liquidacion_gastos_det.cantidad, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.precio, Fj_servindustrias.fa_liquidacion_gastos_det.subtotal, Fj_servindustrias.fa_liquidacion_gastos_det.aplica_iva, 
                         Fj_servindustrias.fa_liquidacion_gastos_det.por_iva, Fj_servindustrias.fa_liquidacion_gastos_det.valor_iva, Fj_servindustrias.fa_liquidacion_gastos_det.Total_liq, 
                         Fj_servindustrias.fa_liquidacion_gastos_producto.nom_producto_Liqui
FROM            Fj_servindustrias.fa_liquidacion_gastos INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos_det ON Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion = Fj_servindustrias.fa_liquidacion_gastos_det.IdLiquidacion INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona AND dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         Fj_servindustrias.fa_liquidacion_gastos_producto ON 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_producto.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui = Fj_servindustrias.fa_liquidacion_gastos_producto.IdProducto_Liqui AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_producto.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui = Fj_servindustrias.fa_liquidacion_gastos_producto.IdProducto_Liqui AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa = Fj_servindustrias.fa_liquidacion_gastos_producto.IdEmpresa AND 
                         Fj_servindustrias.fa_liquidacion_gastos_det.IdProducto_Liqui = Fj_servindustrias.fa_liquidacion_gastos_producto.IdProducto_Liqui
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwFAC_FJ_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'nd
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwFAC_FJ_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[5] 2[6] 3) )"
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
         Begin Table = "fa_liquidacion_gastos (Fj_servindustrias)"
            Begin Extent = 
               Top = 4
               Left = 726
               Bottom = 300
               Right = 935
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_liquidacion_gastos_det (Fj_servindustrias)"
            Begin Extent = 
               Top = 133
               Left = 327
               Bottom = 288
               Right = 536
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 0
               Left = 298
               Bottom = 129
               Right = 536
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 4
               Left = 0
               Bottom = 133
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "fa_liquidacion_gastos_producto (Fj_servindustrias)"
            Begin Extent = 
               Top = 168
               Left = 2
               Bottom = 309
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 1
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
   E', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwFAC_FJ_Rpt002';

