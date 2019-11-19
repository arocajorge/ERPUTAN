CREATE VIEW dbo.vwcom_CotizacionPedidoDet
AS
SELECT dbo.com_CotizacionPedidoDet.IdEmpresa, dbo.com_CotizacionPedidoDet.IdCotizacion, dbo.com_CotizacionPedidoDet.Secuencia, dbo.com_CotizacionPedidoDet.opd_IdEmpresa, dbo.com_CotizacionPedidoDet.opd_IdOrdenPedido, 
                  dbo.com_CotizacionPedidoDet.opd_Secuencia, dbo.com_CotizacionPedidoDet.IdProducto, dbo.com_CotizacionPedidoDet.cd_Cantidad, dbo.com_CotizacionPedidoDet.cd_precioCompra, dbo.com_CotizacionPedidoDet.cd_porc_des, 
                  dbo.com_CotizacionPedidoDet.cd_descuento, dbo.com_CotizacionPedidoDet.cd_precioFinal, dbo.com_CotizacionPedidoDet.cd_subtotal, dbo.com_CotizacionPedidoDet.IdCod_Impuesto, dbo.com_CotizacionPedidoDet.Por_Iva, 
                  dbo.com_CotizacionPedidoDet.cd_iva, dbo.com_CotizacionPedidoDet.cd_total, dbo.com_CotizacionPedidoDet.IdUnidadMedida, dbo.com_CotizacionPedidoDet.IdPunto_cargo, dbo.com_CotizacionPedidoDet.EstadoJC, 
                  dbo.com_CotizacionPedidoDet.EstadoGA, dbo.in_Producto.pr_descripcion, dbo.in_UnidadMedida.Descripcion AS NomUnidadMedida, dbo.tb_sis_Impuesto.nom_impuesto, dbo.ct_punto_cargo.nom_punto_cargo, 
                  dbo.com_CotizacionPedidoDet.cd_DetallePorItem, d.opd_Detalle, c.op_Observacion, d.FechaCantidad, d.Adjunto, d.NombreArchivo
FROM     dbo.com_CotizacionPedidoDet LEFT OUTER JOIN
                  dbo.tb_sis_Impuesto ON dbo.com_CotizacionPedidoDet.IdCod_Impuesto = dbo.tb_sis_Impuesto.IdCod_Impuesto LEFT OUTER JOIN
                  dbo.in_Producto ON dbo.com_CotizacionPedidoDet.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.com_CotizacionPedidoDet.IdProducto = dbo.in_Producto.IdProducto LEFT OUTER JOIN
                  dbo.in_UnidadMedida ON dbo.com_CotizacionPedidoDet.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON dbo.com_CotizacionPedidoDet.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.com_CotizacionPedidoDet.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  dbo.com_OrdenPedidoDet AS d ON dbo.com_CotizacionPedidoDet.IdEmpresa = d.IdEmpresa AND dbo.com_CotizacionPedidoDet.opd_IdOrdenPedido = d.IdOrdenPedido AND 
                  dbo.com_CotizacionPedidoDet.opd_Secuencia = d.Secuencia LEFT OUTER JOIN
                  dbo.com_OrdenPedido AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdOrdenPedido = d.IdOrdenPedido
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDet';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' End
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
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDet';


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
         Top = -840
         Left = 0
      End
      Begin Tables = 
         Begin Table = "com_CotizacionPedidoDet"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 277
            End
            DisplayFlags = 280
            TopColumn = 18
         End
         Begin Table = "tb_sis_Impuesto"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 323
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 284
           ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDet';

