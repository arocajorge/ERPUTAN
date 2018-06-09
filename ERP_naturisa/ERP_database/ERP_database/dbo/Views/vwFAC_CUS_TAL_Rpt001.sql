CREATE VIEW [dbo].[vwFAC_CUS_TAL_Rpt001]
AS
SELECT     dbo.tb_empresa.IdEmpresa, dbo.tb_empresa.em_nombre, dbo.tb_sucursal.IdSucursal, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.IdBodega, 
                      dbo.tb_bodega.bo_Descripcion, dbo.fa_pedido.IdPedido, dbo.fa_cliente.IdCliente, dbo.fa_cliente.IdPersona, dbo.tb_persona.pe_nombreCompleto, 
                      dbo.fa_pedido.cp_fecha, dbo.fa_pedido.cp_diasPlazo, dbo.fa_pedido.cp_fechaVencimiento, dbo.fa_pedido.cp_observacion, dbo.fa_pedido.IdEstadoAprobacion, 
                      dbo.fa_pedido_det.Secuencial, dbo.fa_pedido_det.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.fa_pedido_det.dp_cantidad, 
                      dbo.fa_pedido_det.dp_precio, dbo.fa_pedido_det.dp_PorDescuento, dbo.fa_pedido_det.cp_desUni, dbo.fa_pedido_det.cp_PrecioFinal, dbo.fa_pedido_det.dp_subtotal, 
                      dbo.fa_pedido_det.dp_iva, dbo.fa_pedido_det.dp_total, dbo.fa_pedido_det.dp_peso, dbo.fa_pedido.interes, dbo.fa_pedido.transporte, dbo.fa_pedido.otro1, 
                      dbo.fa_pedido.otro2, dbo.fa_pedido.IdEstadoProduccion, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, dbo.tb_persona.pe_telefonoOfic, 
                      dbo.tb_persona.pe_telefonoCasa, dbo.tb_persona.pe_correo, dbo.tb_persona.pe_razonSocial
FROM         dbo.fa_pedido INNER JOIN
                      dbo.fa_pedido_det ON dbo.fa_pedido.IdEmpresa = dbo.fa_pedido_det.IdEmpresa AND dbo.fa_pedido.IdSucursal = dbo.fa_pedido_det.IdSucursal AND 
                      dbo.fa_pedido.IdBodega = dbo.fa_pedido_det.IdBodega AND dbo.fa_pedido.IdPedido = dbo.fa_pedido_det.IdPedido INNER JOIN
                      dbo.fa_cliente ON dbo.fa_pedido.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_pedido.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                      dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                      dbo.tb_bodega ON dbo.fa_pedido.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_pedido.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                      dbo.fa_pedido.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                      dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.tb_empresa ON dbo.fa_pedido.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                      dbo.in_Producto ON dbo.fa_pedido_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.fa_pedido_det.IdProducto = dbo.in_Producto.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwFAC_CUS_TAL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 606
               Left = 38
               Bottom = 725
               Right = 260
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwFAC_CUS_TAL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[85] 4[4] 2[4] 3) )"
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
         Begin Table = "fa_pedido"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pedido_det"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 125
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 62
               Left = 432
               Bottom = 181
               Right = 642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 34
               Left = 769
               Bottom = 405
               Right = 961
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 246
               Left = 268
               Bottom = 365
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 366
               Left = 38
               Bottom = 485
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 486
               Left = 38
               Bottom = 605
               Right = 242
            End
            ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwFAC_CUS_TAL_Rpt001';

