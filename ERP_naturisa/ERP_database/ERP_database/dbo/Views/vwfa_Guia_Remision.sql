CREATE VIEW dbo.vwfa_Guia_Remision
AS
SELECT        dbo.tb_bodega.bo_Descripcion, dbo.tb_sucursal.Su_Descripcion, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_nombre, dbo.fa_guia_remision.IdCliente, 
                         dbo.fa_guia_remision.IdVendedor, dbo.fa_guia_remision.IdTransportista, dbo.fa_guia_remision.gi_fecha, dbo.fa_guia_remision.gi_plazo, 
                         dbo.fa_guia_remision.gi_fech_venc, dbo.fa_guia_remision.gi_Observacion, dbo.fa_guia_remision.gi_TotalKilos, dbo.fa_guia_remision.gi_TotalQuintales, 
                         dbo.fa_guia_remision_det.Secuencia, dbo.fa_guia_remision.IdGuiaRemision, dbo.fa_guia_remision_det.IdProducto, dbo.fa_guia_remision_det.gi_cantidad, 
                         dbo.fa_guia_remision_det.gi_Precio, dbo.fa_guia_remision_det.gi_PorDescUnitario, dbo.fa_guia_remision_det.gi_DescUnitario, 
                         dbo.fa_guia_remision_det.gi_PrecioFinal, dbo.fa_guia_remision_det.gi_Subtotal, dbo.fa_guia_remision_det.gi_iva, dbo.fa_guia_remision_det.gi_total, 
                         dbo.fa_guia_remision_det.gi_costo, dbo.fa_guia_remision_det.gi_tieneIVA, dbo.fa_guia_remision_det.gi_detallexItems, dbo.fa_Vendedor.Ve_Vendedor, 
                         dbo.fa_guia_remision.IdBodega, dbo.fa_guia_remision.IdSucursal, dbo.fa_guia_remision.IdEmpresa, dbo.tb_persona.pe_apellido, dbo.fa_cliente.IdCliente AS Expr1, 
                         dbo.fa_guia_remision.Estado, dbo.fa_guia_remision.Serie1, dbo.fa_guia_remision.Serie2, dbo.fa_guia_remision.NumGuia_Preimpresa, 
                         dbo.fa_guia_remision.CodGuiaRemision, dbo.fa_guia_remision.Impreso, dbo.fa_guia_remision.IdPeriodo, dbo.fa_guia_remision.gi_flete, 
                         dbo.fa_guia_remision.gi_interes, dbo.fa_guia_remision.gi_seguro, dbo.fa_guia_remision.gi_OtroValor1, dbo.fa_guia_remision.gi_OtroValor2, 
                         dbo.fa_guia_remision.gi_FechaIniTraslado, dbo.fa_guia_remision.gi_FechaFinTraslado, dbo.fa_guia_remision.CodDocumentoTipo, dbo.fa_guia_remision.ruta, 
                         dbo.fa_guia_remision.Direccion_Origen, dbo.fa_guia_remision.Direccion_Destino, dbo.fa_guia_remision.placa
FROM            dbo.fa_guia_remision INNER JOIN
                         dbo.fa_guia_remision_det ON dbo.fa_guia_remision.IdEmpresa = dbo.fa_guia_remision_det.IdEmpresa AND 
                         dbo.fa_guia_remision.IdSucursal = dbo.fa_guia_remision_det.IdSucursal AND dbo.fa_guia_remision.IdBodega = dbo.fa_guia_remision_det.IdBodega AND 
                         dbo.fa_guia_remision.IdGuiaRemision = dbo.fa_guia_remision_det.IdGuiaRemision INNER JOIN
                         dbo.fa_Vendedor ON dbo.fa_guia_remision.IdEmpresa = dbo.fa_Vendedor.IdEmpresa AND 
                         dbo.fa_guia_remision.IdVendedor = dbo.fa_Vendedor.IdVendedor INNER JOIN
                         dbo.tb_bodega ON dbo.fa_guia_remision.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.fa_guia_remision.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.fa_guia_remision.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                         dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.fa_cliente ON dbo.fa_guia_remision.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_guia_remision.IdSucursal = dbo.fa_cliente.IdSucursal AND 
                         dbo.fa_guia_remision.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_Guia_Remision';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'  End
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
      Begin ColumnWidths = 49
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
         Width = 3315
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
         SortType = 1320
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_Guia_Remision';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[85] 4[5] 2[5] 3) )"
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
               Top = 0
               Left = 388
               Bottom = 338
               Right = 610
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_guia_remision_det"
            Begin Extent = 
               Top = 0
               Left = 38
               Bottom = 119
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_Vendedor"
            Begin Extent = 
               Top = 190
               Left = 55
               Bottom = 309
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 144
               Left = 712
               Bottom = 263
               Right = 910
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 161
               Left = 1041
               Bottom = 280
               Right = 1255
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 7
               Left = 732
               Bottom = 126
               Right = 942
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 12
               Left = 1007
               Bottom = 131
               Right = 1199
          ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_Guia_Remision';

