CREATE VIEW [dbo].[vwin_DespachoMateriales]
AS
SELECT        dbo.prd_Despacho.IdEmpresa, dbo.prd_Despacho.IdSucursal, dbo.prd_Despacho.IdDespacho, dbo.prd_Despacho.IdBodega, dbo.prd_Despacho.CodObra, 
                         dbo.prd_Despacho.IdCliente, dbo.prd_Despacho.NumDespacho, dbo.prd_Despacho.NumGuiaRemision, dbo.prd_Despacho.NumFactura, 
                         dbo.prd_Despacho.FechaIniTras, dbo.prd_Despacho.FechaFinTras, dbo.prd_Despacho.FechaReg, dbo.prd_Despacho.PuntoPartida, 
                         dbo.prd_Despacho.PuntoLLegada, dbo.prd_Despacho.TipoTransporte, dbo.prd_Despacho.Chofer, dbo.prd_Despacho.Placa, dbo.prd_Despacho.Observacion, 
                         dbo.prd_Despacho.Estado, dbo.prd_Despacho.IdUsuario, dbo.tb_sucursal.Su_Descripcion, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.prd_DespachoDet.precio, dbo.prd_DespachoDet.peso, dbo.prd_Obra.Descripcion, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, 
                         dbo.prd_DespachoDet.CodigoBarra, dbo.prd_DespachoDet.Cantidad, dbo.in_Producto.pr_codigo_barra
FROM            dbo.prd_Despacho INNER JOIN
                         dbo.prd_DespachoDet ON dbo.prd_Despacho.IdEmpresa = dbo.prd_DespachoDet.IdEmpresa AND 
                         dbo.prd_Despacho.IdSucursal = dbo.prd_DespachoDet.IdSucursal AND dbo.prd_Despacho.IdDespacho = dbo.prd_DespachoDet.IdDespacho INNER JOIN
                         dbo.prd_Obra ON dbo.prd_Despacho.IdEmpresa = dbo.prd_Obra.IdEmpresa AND dbo.prd_Despacho.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                         dbo.tb_sucursal ON dbo.prd_Despacho.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.prd_Despacho.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.in_Producto ON dbo.prd_DespachoDet.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.prd_DespachoDet.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.fa_cliente ON dbo.prd_Despacho.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.prd_Despacho.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_DespachoMateriales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'          DisplayFlags = 280
            TopColumn = 11
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 32
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_DespachoMateriales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[65] 4[4] 2[4] 3) )"
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
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 26
               Left = 1068
               Bottom = 334
               Right = 1248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Despacho"
            Begin Extent = 
               Top = 13
               Left = 242
               Bottom = 272
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_DespachoDet"
            Begin Extent = 
               Top = 0
               Left = 623
               Bottom = 290
               Right = 787
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 41
               Left = 17
               Bottom = 367
               Right = 178
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 26
               Left = 844
               Bottom = 386
               Right = 1053
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 92
               Left = 838
               Bottom = 367
               Right = 1057
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 131
               Left = 265
               Bottom = 282
               Right = 474
            End
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_DespachoMateriales';

