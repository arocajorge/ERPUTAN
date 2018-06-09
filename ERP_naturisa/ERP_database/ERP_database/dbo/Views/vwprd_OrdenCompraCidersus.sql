CREATE VIEW dbo.vwprd_OrdenCompraCidersus
AS
SELECT     dbo.com_ordencompra_local.IdEmpresa, dbo.com_ordencompra_local.IdSucursal, dbo.com_ordencompra_local.IdOrdenCompra, 
                      dbo.com_ordencompra_local.IdProveedor, dbo.in_Producto.IdProducto, dbo.tb_empresa.em_nombre, dbo.cp_proveedor.pr_nombre, 
                      dbo.com_ordencompra_local.oc_plazo, dbo.com_ordencompra_local.oc_fecha, dbo.in_Producto.pr_codigo, dbo.com_ordencompra_local_det.do_Cantidad, 
                      dbo.in_Producto.IdUnidadMedida, dbo.in_Producto.pr_descripcion, dbo.com_ordencompra_local_det.do_precioCompra, dbo.com_ordencompra_local_det.do_subtotal, 
                      dbo.com_ordencompra_local_det.do_iva, dbo.com_ordencompra_local_det.do_total, dbo.com_ordencompra_local_det.do_descuento, 
                      dbo.com_ordencompra_local_det.do_porc_des, dbo.cp_proveedor.pr_contribuyenteEspecial, dbo.com_ordencompra_local.oc_NumDocumento, 
                      usu_aprueba.Nombre AS Usuario_Aprueba, dbo.seg_usuario.Nombre AS Usuario_Solicitante, dbo.com_TerminoPago.Descripcion AS TerminoPago, 
                      dbo.com_TerminoPago.Dias AS DiasTerminoPago, dbo.in_UnidadMedida.Descripcion AS UnidadMedidaConsumo
FROM         dbo.com_ordencompra_local INNER JOIN
                      dbo.com_ordencompra_local_det ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND 
                      dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND 
                      dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra INNER JOIN
                      dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                      dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                      dbo.in_Producto ON dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.com_ordencompra_local_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.tb_empresa ON dbo.com_ordencompra_local.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                      dbo.seg_usuario AS usu_aprueba ON dbo.com_ordencompra_local.IdUsuario_Aprueba = usu_aprueba.IdUsuario INNER JOIN
                      dbo.seg_usuario ON dbo.com_ordencompra_local.IdUsuario = dbo.seg_usuario.IdUsuario INNER JOIN
                      dbo.com_TerminoPago ON dbo.com_ordencompra_local.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago INNER JOIN
                      dbo.in_UnidadMedida ON dbo.in_Producto.IdUnidadMedida_Consumo = dbo.in_UnidadMedida.IdUnidadMedida
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenCompraCidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ght = 857
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 390
               Left = 973
               Bottom = 498
               Right = 1162
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 266
               Left = 1402
               Bottom = 495
               Right = 1591
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
      Begin ColumnWidths = 27
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1920
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenCompraCidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[8] 2[17] 3) )"
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
         Top = -192
         Left = -422
      End
      Begin Tables = 
         Begin Table = "com_ordencompra_local"
            Begin Extent = 
               Top = 98
               Left = 290
               Bottom = 576
               Right = 499
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ordencompra_local_det"
            Begin Extent = 
               Top = 3
               Left = 577
               Bottom = 371
               Right = 840
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 272
               Left = 23
               Bottom = 582
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 22
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 103
               Left = 941
               Bottom = 389
               Right = 1170
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 0
               Left = 13
               Bottom = 268
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "usu_aprueba"
            Begin Extent = 
               Top = 363
               Left = 711
               Bottom = 528
               Right = 935
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "seg_usuario"
            Begin Extent = 
               Top = 528
               Left = 633
               Bottom = 734
               Ri', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_OrdenCompraCidersus';

