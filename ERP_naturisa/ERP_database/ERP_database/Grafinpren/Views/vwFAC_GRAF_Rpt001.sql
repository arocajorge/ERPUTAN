CREATE VIEW Grafinpren.vwFAC_GRAF_Rpt001
AS
SELECT        dbo.fa_guia_remision.IdEmpresa, dbo.fa_guia_remision.IdBodega, dbo.fa_guia_remision.IdSucursal, dbo.fa_guia_remision.IdGuiaRemision, 
                         dbo.fa_guia_remision.CodGuiaRemision, dbo.fa_guia_remision.IdCliente, dbo.vwfa_cliente.pe_razonSocial, dbo.fa_guia_remision.gi_Observacion, 
                         dbo.fa_guia_remision_det.Secuencia, dbo.fa_guia_remision_det.gi_cantidad, dbo.fa_guia_remision_det.gi_Precio, dbo.fa_guia_remision_det.gi_PorDescUnitario, 
                         dbo.fa_guia_remision_det.gi_DescUnitario, dbo.fa_guia_remision_det.gi_PrecioFinal, dbo.fa_guia_remision_det.gi_Subtotal, dbo.fa_guia_remision_det.gi_iva, 
                         dbo.fa_guia_remision_det.gi_total, dbo.fa_guia_remision_det.gi_detallexItems, dbo.tb_transportista.Nombre AS Nombre_Transportista, 
                         dbo.vwin_in_Producto_x_tb_bodega_x_UnidadMedida.pr_descripcion AS Nombre_Producto, Grafinpren.fa_guia_remision_graf.Num_OP AS Numero_OP, 
                         Grafinpren.fa_Equipo_graf.nom_Equipo AS Nom_Maquina, Grafinpren.fa_guia_remision_graf.Num_Cotizacion, dbo.fa_guia_remision.Direccion_Destino, 
                         dbo.fa_guia_remision.Direccion_Origen, dbo.fa_guia_remision.ruta, dbo.fa_guia_remision.placa, dbo.fa_guia_remision.gi_FechaFinTraslado, 
                         dbo.fa_guia_remision.gi_FechaIniTraslado, dbo.fa_guia_remision.gi_fecha
FROM            dbo.fa_guia_remision INNER JOIN
                         dbo.fa_guia_remision_det ON dbo.fa_guia_remision.IdEmpresa = dbo.fa_guia_remision_det.IdEmpresa AND 
                         dbo.fa_guia_remision.IdSucursal = dbo.fa_guia_remision_det.IdSucursal AND dbo.fa_guia_remision.IdBodega = dbo.fa_guia_remision_det.IdBodega AND 
                         dbo.fa_guia_remision.IdGuiaRemision = dbo.fa_guia_remision_det.IdGuiaRemision INNER JOIN
                         dbo.tb_bodega ON dbo.fa_guia_remision.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_guia_remision.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.fa_guia_remision.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                         dbo.vwfa_cliente ON dbo.fa_guia_remision.IdCliente = dbo.vwfa_cliente.IdCliente AND dbo.fa_guia_remision.IdEmpresa = dbo.vwfa_cliente.IdEmpresa AND 
                         dbo.fa_guia_remision.IdSucursal = dbo.vwfa_cliente.IdSucursal INNER JOIN
                         dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.tb_transportista ON dbo.fa_guia_remision.IdTransportista = dbo.tb_transportista.IdTransportista AND 
                         dbo.fa_guia_remision.IdEmpresa = dbo.tb_transportista.IdEmpresa INNER JOIN
                         dbo.vwin_in_Producto_x_tb_bodega_x_UnidadMedida ON 
                         dbo.fa_guia_remision_det.IdProducto = dbo.vwin_in_Producto_x_tb_bodega_x_UnidadMedida.IdProducto INNER JOIN
                         Grafinpren.fa_guia_remision_graf ON dbo.fa_guia_remision.IdEmpresa = Grafinpren.fa_guia_remision_graf.IdEmpresa AND 
                         dbo.fa_guia_remision.IdSucursal = Grafinpren.fa_guia_remision_graf.IdSucursal AND 
                         dbo.fa_guia_remision.IdBodega = Grafinpren.fa_guia_remision_graf.IdBodega AND 
                         dbo.fa_guia_remision.IdGuiaRemision = Grafinpren.fa_guia_remision_graf.IdGuiaRemision INNER JOIN
                         Grafinpren.fa_Equipo_graf ON Grafinpren.fa_guia_remision_graf.IdEquipo = Grafinpren.fa_Equipo_graf.IdEquipo AND 
                         Grafinpren.fa_guia_remision_graf.IdEmpresa = Grafinpren.fa_Equipo_graf.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwFAC_GRAF_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
               Right = 328
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_guia_remision_graf (Grafinpren)"
            Begin Extent = 
               Top = 12
               Left = 791
               Bottom = 141
               Right = 1000
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "fa_Equipo_graf (Grafinpren)"
            Begin Extent = 
               Top = 178
               Left = 1007
               Bottom = 307
               Right = 1216
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4320
         Alias = 3855
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
', @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwFAC_GRAF_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[20] 4[67] 2[5] 3) )"
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
         Begin Table = "fa_guia_remision"
            Begin Extent = 
               Top = 16
               Left = 461
               Bottom = 404
               Right = 670
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_guia_remision_det"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 299
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwfa_cliente"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_transportista"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwin_in_Producto_x_tb_bodega_x_UnidadMedida"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927', @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwFAC_GRAF_Rpt001';

