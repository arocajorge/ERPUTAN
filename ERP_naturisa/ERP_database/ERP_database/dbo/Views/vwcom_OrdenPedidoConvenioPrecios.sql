CREATE VIEW dbo.vwcom_OrdenPedidoConvenioPrecios
AS
SELECT dbo.com_OrdenPedidoDet.IdEmpresa, dbo.com_OrdenPedidoDet.IdOrdenPedido, dbo.com_OrdenPedidoDet.Secuencia, dbo.com_OrdenPedidoDet.IdProducto, dbo.com_OrdenPedidoDet.pr_descripcion, 
                  dbo.com_OrdenPedidoDet.IdUnidadMedida, dbo.com_OrdenPedidoDet.IdSucursalOrigen, dbo.com_OrdenPedidoDet.IdSucursalDestino, dbo.com_OrdenPedidoDet.IdPunto_cargo, dbo.com_OrdenPedidoDet.opd_Cantidad, 
                  dbo.com_OrdenPedidoDet.opd_CantidadApro, dbo.com_OrdenPedidoDet.opd_EstadoProceso, dbo.com_OrdenPedidoDet.opd_Detalle, dbo.com_OrdenPedidoDet.Adjunto, dbo.com_OrdenPedidoDet.NombreArchivo, 
                  dbo.com_OrdenPedidoDet.IdUsuarioCantidad, dbo.com_OrdenPedidoDet.FechaCantidad, dbo.com_OrdenPedidoDet.IdUsuarioCotizacion, dbo.com_OrdenPedidoDet.FechaCotizacion, dbo.com_OrdenPedido.op_Fecha, 
                  dbo.com_OrdenPedido.op_Observacion, dbo.com_OrdenPedido.IdDepartamento, dbo.com_OrdenPedido.IdSolicitante, dbo.com_OrdenPedido.IdCatalogoEstado, dbo.com_OrdenPedido.Estado, 
                  dbo.com_ConvenioPreciosPorProducto.IdProveedor, dbo.com_ConvenioPreciosPorProducto.IdComprador, dbo.com_ConvenioPreciosPorProducto.IdTerminoPago, dbo.com_ConvenioPreciosPorProducto.PrecioUnitario, 
                  dbo.com_ConvenioPreciosPorProducto.PorDescuento, dbo.com_ConvenioPreciosPorProducto.Descuento, dbo.com_ConvenioPreciosPorProducto.PrecioFinal, dbo.com_ConvenioPreciosPorProducto.TiempoEntrega, 
                  dbo.com_ConvenioPreciosPorProducto.FechaFin, dbo.com_ConvenioPreciosPorProducto.SaltaPaso2, dbo.com_ConvenioPreciosPorProducto.SaltaPaso3, dbo.com_ConvenioPreciosPorProducto.SaltoPaso4, 
                  dbo.com_ConvenioPreciosPorProducto.SaltoPaso5, dbo.com_OrdenPedido.IdUsuarioCreacion, dbo.in_Producto.IdCod_Impuesto_Iva, dbo.tb_sis_Impuesto.porcentaje, 
                  dbo.com_OrdenPedidoDet.opd_CantidadApro * dbo.com_ConvenioPreciosPorProducto.PrecioFinal AS Subtotal, (dbo.com_OrdenPedidoDet.opd_CantidadApro * dbo.com_ConvenioPreciosPorProducto.PrecioFinal) 
                  * (dbo.tb_sis_Impuesto.porcentaje / 100) AS Iva, 
                  dbo.com_OrdenPedidoDet.opd_CantidadApro * dbo.com_ConvenioPreciosPorProducto.PrecioFinal + (dbo.com_OrdenPedidoDet.opd_CantidadApro * dbo.com_ConvenioPreciosPorProducto.PrecioFinal) 
                  * (dbo.tb_sis_Impuesto.porcentaje / 100) AS Total, dbo.com_TerminoPago.Dias
FROM     dbo.com_OrdenPedido INNER JOIN
                  dbo.com_OrdenPedidoDet ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_OrdenPedidoDet.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = dbo.com_OrdenPedidoDet.IdOrdenPedido INNER JOIN
                  dbo.com_ConvenioPreciosPorProducto ON dbo.com_OrdenPedidoDet.IdProducto = dbo.com_ConvenioPreciosPorProducto.IdProducto AND dbo.com_OrdenPedidoDet.IdEmpresa = dbo.com_ConvenioPreciosPorProducto.IdEmpresa AND 
                  dbo.com_OrdenPedidoDet.IdUnidadMedida = dbo.com_ConvenioPreciosPorProducto.IdUnidadMedida INNER JOIN
                  dbo.in_Producto ON dbo.com_OrdenPedidoDet.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_OrdenPedidoDet.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                  dbo.tb_sis_Impuesto ON dbo.in_Producto.IdCod_Impuesto_Iva = dbo.tb_sis_Impuesto.IdCod_Impuesto INNER JOIN
                  dbo.com_TerminoPago ON dbo.com_ConvenioPreciosPorProducto.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago
WHERE  (dbo.com_ConvenioPreciosPorProducto.FechaFin >= CAST(GETDATE() AS date))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoConvenioPrecios';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoConvenioPrecios';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[18] 4[40] 2[7] 3) )"
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
         Begin Table = "com_OrdenPedido"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_OrdenPedidoDet"
            Begin Extent = 
               Top = 140
               Left = 416
               Bottom = 557
               Right = 644
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ConvenioPreciosPorProducto"
            Begin Extent = 
               Top = 96
               Left = 63
               Bottom = 360
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 118
               Left = 758
               Bottom = 597
               Right = 1033
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sis_Impuesto"
            Begin Extent = 
               Top = 92
               Left = 1199
               Bottom = 344
               Right = 1423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 62
               Left = 1537
               Bottom = 382
               Right = 1745
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
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoConvenioPrecios';

