CREATE VIEW dbo.vwcom_OrdenPedidoDetConvenioPrecios
AS
SELECT D.IdEmpresa, D.IdOrdenPedido, D.Secuencia, D.IdProducto, D.pr_descripcion, D.IdUnidadMedida, D.IdSucursalOrigen, D.IdSucursalDestino, D.IdPunto_cargo, D.opd_Cantidad, D.opd_CantidadApro, D.opd_EstadoProceso, D.opd_Detalle, 
                  C.IdDepartamento, C.op_Observacion, dbo.com_ConvenioPreciosPorProducto.IdProveedor, dbo.com_ConvenioPreciosPorProducto.IdComprador, dbo.com_ConvenioPreciosPorProducto.IdTerminoPago, 
                  dbo.com_ConvenioPreciosPorProducto.IdUnidadMedida AS Expr1, dbo.com_ConvenioPreciosPorProducto.PrecioUnitario, dbo.com_ConvenioPreciosPorProducto.PorDescuento, dbo.com_ConvenioPreciosPorProducto.Descuento, 
                  dbo.com_ConvenioPreciosPorProducto.PrecioFinal, dbo.com_ConvenioPreciosPorProducto.TiempoEntrega, dbo.com_ConvenioPreciosPorProducto.FechaFin, dbo.com_ConvenioPreciosPorProducto.SaltaPaso2, 
                  dbo.com_ConvenioPreciosPorProducto.SaltaPaso3, dbo.com_ConvenioPreciosPorProducto.SaltoPaso4, dbo.com_TerminoPago.Dias, dbo.com_ConvenioPreciosPorProducto.SaltoPaso5
FROM     dbo.com_OrdenPedido AS C INNER JOIN
                  dbo.com_OrdenPedidoDet AS D ON C.IdEmpresa = D.IdEmpresa AND C.IdOrdenPedido = D.IdOrdenPedido INNER JOIN
                  dbo.com_ConvenioPreciosPorProducto ON D.IdEmpresa = dbo.com_ConvenioPreciosPorProducto.IdEmpresa AND D.IdProducto = dbo.com_ConvenioPreciosPorProducto.IdProducto INNER JOIN
                  dbo.com_TerminoPago ON dbo.com_ConvenioPreciosPorProducto.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDetConvenioPrecios';


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
         Top = -240
         Left = 0
      End
      Begin Tables = 
         Begin Table = "C"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "com_ConvenioPreciosPorProducto"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 256
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDetConvenioPrecios';

