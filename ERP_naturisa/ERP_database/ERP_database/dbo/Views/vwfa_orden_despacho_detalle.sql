CREATE VIEW [dbo].[vwfa_orden_despacho_detalle]
AS
SELECT     dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.fa_orden_Desp_det.Secuencia, 
                      dbo.fa_orden_Desp_det.IdProducto, dbo.fa_orden_Desp_det.od_Precio, dbo.fa_orden_Desp_det.od_cantidad, dbo.fa_orden_Desp_det.od_PorDescUnitario, 
                      dbo.fa_orden_Desp_det.od_DescUnitario, dbo.fa_orden_Desp_det.od_PrecioFinal, dbo.fa_orden_Desp_det.od_Subtotal, dbo.fa_orden_Desp_det.od_iva, 
                      dbo.fa_orden_Desp_det.od_total, dbo.fa_orden_Desp_det.od_costo, dbo.fa_orden_Desp_det.od_tieneIVA, dbo.fa_orden_Desp_det.od_detallexItems, 
                      dbo.tb_bodega.bo_Descripcion, dbo.tb_sucursal.Su_Descripcion, dbo.fa_orden_Desp.IdBodega, dbo.fa_orden_Desp.IdSucursal, dbo.fa_orden_Desp.IdEmpresa, 
                      dbo.fa_orden_Desp.IdOrdenDespacho, dbo.fa_orden_Desp.IdCliente, dbo.fa_orden_Desp.IdVendedor, dbo.fa_orden_Desp.IdTransportista, 
                      dbo.fa_orden_Desp.od_fecha, dbo.fa_orden_Desp.od_plazo, dbo.fa_orden_Desp.od_fech_venc, dbo.fa_orden_Desp.od_Observacion, 
                      dbo.fa_orden_Desp.od_TotalKilos, dbo.fa_orden_Desp.od_TotalQuintales, dbo.fa_orden_Desp.IdUsuario, dbo.fa_orden_Desp.Fecha_Transac, 
                      dbo.fa_orden_Desp.Estado, dbo.fa_Vendedor.Ve_Vendedor, dbo.fa_orden_Desp.IdTransportista AS Expr1, dbo.tb_empresa.em_nombre, 
                      dbo.tb_empresa.em_telefonos, dbo.tb_empresa.em_direccion, dbo.tb_empresa.em_logo, dbo.fa_orden_Desp.CodOrdenDespacho, 
                      dbo.fa_orden_Desp.od_DespAbierto
FROM         dbo.fa_orden_Desp INNER JOIN
                      dbo.fa_orden_Desp_det ON dbo.fa_orden_Desp.IdEmpresa = dbo.fa_orden_Desp_det.IdEmpresa AND 
                      dbo.fa_orden_Desp.IdSucursal = dbo.fa_orden_Desp_det.IdSucursal AND dbo.fa_orden_Desp.IdBodega = dbo.fa_orden_Desp_det.IdBodega AND 
                      dbo.fa_orden_Desp.IdOrdenDespacho = dbo.fa_orden_Desp_det.IdOrdenDespacho INNER JOIN
                      dbo.fa_Vendedor ON dbo.fa_orden_Desp.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND dbo.fa_orden_Desp.IdVendedor = dbo.fa_Vendedor.IdVendedor INNER JOIN
                      dbo.tb_bodega ON dbo.fa_orden_Desp.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_orden_Desp.IdBodega = dbo.tb_bodega.IdBodega AND 
                      dbo.fa_orden_Desp.IdSucursal = dbo.tb_bodega.IdSucursal INNER JOIN
                      dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.fa_cliente ON dbo.fa_orden_Desp.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_orden_Desp.IdCliente = dbo.fa_cliente.IdCliente AND 
                      dbo.fa_orden_Desp.IdSucursal = dbo.fa_cliente.IdSucursal INNER JOIN
                      dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                      dbo.tb_empresa ON dbo.fa_Vendedor.IdEmpresa = dbo.tb_empresa.IdEmpresa AND dbo.tb_sucursal.IdEmpresa = dbo.tb_empresa.IdEmpresa AND 
                      dbo.tb_bodega.IdEmpresa = dbo.tb_empresa.IdEmpresa AND dbo.fa_cliente.IdEmpresa = dbo.tb_empresa.IdEmpresa AND 
                      dbo.fa_orden_Desp.IdEmpresa = dbo.tb_empresa.IdEmpresa AND dbo.fa_orden_Desp_det.IdEmpresa = dbo.tb_empresa.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_despacho_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 176
               Left = 546
               Bottom = 420
               Right = 735
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 42
         Width = 284
         Width = 4365
         Width = 1845
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
         Width = 2955
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_despacho_detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[82] 4[5] 2[5] 3) )"
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
         Begin Table = "fa_orden_Desp"
            Begin Extent = 
               Top = 22
               Left = 316
               Bottom = 378
               Right = 498
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "fa_orden_Desp_det"
            Begin Extent = 
               Top = 2
               Left = 18
               Bottom = 192
               Right = 199
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_Vendedor"
            Begin Extent = 
               Top = 207
               Left = 29
               Bottom = 326
               Right = 197
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 132
               Left = 798
               Bottom = 313
               Right = 996
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 124
               Left = 1054
               Bottom = 243
               Right = 1268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 6
               Left = 787
               Bottom = 125
               Right = 997
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 7
               Left = 1057
               Bottom = 126
               Right = 1249
            End', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_despacho_detalle';

