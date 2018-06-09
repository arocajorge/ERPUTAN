CREATE VIEW [dbo].[vwfa_pedido_detalle]
AS
SELECT        Sucu.Su_Descripcion, Perso.pe_nombreCompleto, Ped.cp_fecha, Ped.cp_diasPlazo, Ped.cp_fechaVencimiento, Ped.cp_observacion, Ped.cp_tipopago, 
                         Ped.IdEstadoAprobacion, ped_est_apro.Descripcion, Ped.IdEmpresa, Ped.IdSucursal, Ped.IdBodega, Ped.IdCliente, Ped.IdVendedor, Ped.IdPedido, 
                         bod.bo_Descripcion, ped_det.IdProducto, ped_det.dp_cantidad, ped_det.dp_precio, ped_det.dp_PorDescuento, ped_det.cp_PrecioFinal, ped_det.cp_desUni, 
                         ped_det.dp_subtotal, ped_det.dp_total, ped_det.dp_iva, ped_det.dp_pagaIva, ped_det.dp_detallexItems, Ped.Estado, Vend.Ve_Vendedor, Perso.pe_nombre, 
                         Perso.pe_apellido, bod.cod_punto_emision, bod.bo_manejaFacturacion, bod.bo_EsBodega, ped_det.Secuencial, Ped.interes, Ped.transporte, Ped.otro1, Ped.otro2, 
                         Ped.CodPedido, ped_det.dp_peso, Ped.Entregado, Ped.IdEstadoProduccion, CASE WHEN ord_des_ped1.pe_IdEmpresa IS NULL 
                         THEN 'N' ELSE 'S' END AS Tiene_Despacho, 'S' AS Esta_en_Base
FROM            dbo.fa_pedido AS Ped INNER JOIN
                         dbo.fa_pedido_det AS ped_det ON Ped.IdEmpresa = ped_det.IdEmpresa AND Ped.IdSucursal = ped_det.IdSucursal AND Ped.IdBodega = ped_det.IdBodega AND 
                         Ped.IdPedido = ped_det.IdPedido INNER JOIN
                         dbo.fa_pedido_estadoAprobacion AS ped_est_apro ON Ped.IdEstadoAprobacion = ped_est_apro.IdEstadoAprobacion INNER JOIN
                         dbo.tb_bodega AS bod ON Ped.IdEmpresa = bod.IdEmpresa AND Ped.IdBodega = bod.IdBodega AND Ped.IdSucursal = bod.IdSucursal INNER JOIN
                         dbo.tb_sucursal AS Sucu ON bod.IdEmpresa = Sucu.IdEmpresa AND bod.IdSucursal = Sucu.IdSucursal INNER JOIN
                         dbo.fa_Vendedor AS Vend ON Ped.IdEmpresa = Vend.IdEmpresa AND Ped.IdVendedor = Vend.IdVendedor INNER JOIN
                         dbo.fa_cliente AS Cli ON Ped.IdEmpresa = Cli.IdEmpresa AND Ped.IdCliente = Cli.IdCliente INNER JOIN
                         dbo.tb_persona AS Perso ON Cli.IdPersona = Perso.IdPersona LEFT OUTER JOIN
                         dbo.vwfa_orden_Desp_det_x_fa_pedido_det_x_pedido AS ord_des_ped1 ON ped_det.IdEmpresa = ord_des_ped1.pe_IdEmpresa AND 
                         ped_det.IdSucursal = ord_des_ped1.pe_IdSucursal AND ped_det.IdBodega = ord_des_ped1.pe_IdBodega AND ped_det.IdPedido = ord_des_ped1.pe_IdPedido AND 
                         ped_det.Secuencial = ord_des_ped1.pe_Secuencia
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'olumn = 0
         End
         Begin Table = "Perso"
            Begin Extent = 
               Top = 330
               Left = 0
               Bottom = 438
               Right = 183
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ord_des_ped1"
            Begin Extent = 
               Top = 59
               Left = 757
               Bottom = 211
               Right = 908
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
      Begin ColumnWidths = 39
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 4950
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[4] 2[73] 3) )"
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
         Begin Table = "Ped"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ped_det"
            Begin Extent = 
               Top = 32
               Left = 371
               Bottom = 367
               Right = 536
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ped_est_apro"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bod"
            Begin Extent = 
               Top = 279
               Left = 0
               Bottom = 387
               Right = 189
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucu"
            Begin Extent = 
               Top = 222
               Left = 38
               Bottom = 330
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Vend"
            Begin Extent = 
               Top = 345
               Left = 34
               Bottom = 453
               Right = 193
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cli"
            Begin Extent = 
               Top = 330
               Left = 38
               Bottom = 438
               Right = 239
            End
            DisplayFlags = 280
            TopC', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_detalle';

