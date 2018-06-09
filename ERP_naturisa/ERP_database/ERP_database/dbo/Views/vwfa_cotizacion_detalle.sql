CREATE VIEW [dbo].[vwfa_cotizacion_detalle]
AS
SELECT     dbo.tb_bodega.bo_Descripcion, dbo.tb_sucursal.Su_Descripcion, dbo.fa_Vendedor.Ve_Vendedor, dbo.fa_cotizacion.IdEmpresa, dbo.fa_cotizacion.IdSucursal, 
                      dbo.fa_cotizacion.IdBodega, dbo.fa_cotizacion.IdCotizacion, dbo.fa_cotizacion.IdCliente, dbo.fa_cotizacion.IdVendedor, dbo.fa_cotizacion.cc_fecha, 
                      dbo.fa_cotizacion.cc_diasPlazo, dbo.fa_cotizacion.cc_observacion, dbo.fa_cotizacion.cc_tipopago, dbo.fa_cotizacion.cc_fechaVencimiento, 
                      dbo.fa_cotizacion.cc_estado, dbo.fa_cotizacion.cc_dirigidoA, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                      dbo.fa_cotizacion_det.Secuencial, dbo.fa_cotizacion_det.IdProducto, dbo.fa_cotizacion_det.dc_cantidad, dbo.fa_cotizacion_det.dc_precio, 
                      dbo.fa_cotizacion_det.dc_por_desUni, dbo.fa_cotizacion_det.dc_desUni, dbo.fa_cotizacion_det.dc_precioFinal, dbo.fa_cotizacion_det.dc_subtotal, 
                      dbo.fa_cotizacion_det.dc_iva, dbo.fa_cotizacion_det.dc_total, dbo.fa_cotizacion_det.dc_pagaIva, dbo.fa_cotizacion_det.dc_detallexItems, 
                      dbo.fa_cotizacion.CodCotizacion
FROM         dbo.fa_cotizacion INNER JOIN
                      dbo.fa_cliente ON dbo.fa_cotizacion.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_cotizacion.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                      dbo.fa_Vendedor ON dbo.fa_cotizacion.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_cotizacion.IdVendedor = dbo.fa_Vendedor.IdVendedor INNER JOIN
                      dbo.tb_bodega ON dbo.fa_cotizacion.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_cotizacion.IdBodega = dbo.tb_bodega.IdBodega AND 
                      dbo.fa_cotizacion.IdSucursal = dbo.tb_bodega.IdSucursal INNER JOIN
                      dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                      dbo.fa_cotizacion_det ON dbo.fa_cotizacion.IdEmpresa = dbo.fa_cotizacion_det.IdEmpresa AND dbo.fa_cotizacion.IdSucursal = dbo.fa_cotizacion_det.IdSucursal AND 
                      dbo.fa_cotizacion.IdBodega = dbo.fa_cotizacion_det.IdBodega AND dbo.fa_cotizacion.IdCotizacion = dbo.fa_cotizacion_det.IdCotizacion
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cotizacion_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
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
      Begin ColumnWidths = 40
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cotizacion_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[4] 2[4] 3) )"
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
         Begin Table = "fa_cotizacion"
            Begin Extent = 
               Top = 29
               Left = 46
               Bottom = 268
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 207
               Left = 693
               Bottom = 399
               Right = 903
            End
            DisplayFlags = 280
            TopColumn = 29
         End
         Begin Table = "fa_Vendedor"
            Begin Extent = 
               Top = 258
               Left = 385
               Bottom = 429
               Right = 553
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 0
               Left = 401
               Bottom = 207
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 74
               Left = 1013
               Bottom = 288
               Right = 1227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 89
               Left = 778
               Bottom = 270
               Right = 970
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cotizacion_det"
            Begin Extent = 
               Top = 5
               Left = 813
               Bottom = 321
               Right = 984
            End', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cotizacion_detalle';

