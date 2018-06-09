CREATE VIEW dbo.vwin_ReimpresionCodigoBarraProductoTerminado_CusCider
AS
SELECT     dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdEnsamblado, dbo.prd_Ensamblado_CusCider.IdSucursal, 
                      dbo.prd_Ensamblado_CusCider.CodigoBarra, dbo.prd_Obra.Descripcion AS Obra, dbo.prd_Orden_Taller.Observacion AS OrdenTaller, 
                      dbo.tb_persona.pe_nombreCompleto AS Cliente, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion, dbo.tb_empresa.em_logo, dbo.prd_Obra.CodObra
FROM         dbo.prd_Ensamblado_CusCider INNER JOIN
                      dbo.prd_Obra ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                      dbo.prd_Ensamblado_CusCider.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                      dbo.fa_cliente ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.prd_Obra.IdCliente = dbo.fa_cliente.IdCliente AND 
                      dbo.prd_Obra.IdEmpresa = dbo.fa_cliente.IdEmpresa INNER JOIN
                      dbo.prd_Orden_Taller ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                      dbo.prd_Obra.CodObra = dbo.prd_Orden_Taller.CodObra AND dbo.prd_Ensamblado_CusCider.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller INNER JOIN
                      dbo.in_Producto ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.prd_Ensamblado_CusCider.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.tb_empresa ON dbo.prd_Obra.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                      dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_ReimpresionCodigoBarraProductoTerminado_CusCider';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'    End
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
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1920
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3450
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_ReimpresionCodigoBarraProductoTerminado_CusCider';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[14] 3) )"
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
         Begin Table = "prd_Ensamblado_CusCider"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 81
               Left = 424
               Bottom = 189
               Right = 613
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 16
               Left = 715
               Bottom = 276
               Right = 933
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 143
               Left = 21
               Bottom = 251
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 201
               Left = 423
               Bottom = 309
               Right = 631
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 330
               Left = 38
               Bottom = 438
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 114
               Left = 972
               Bottom = 281
               Right = 1184
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_ReimpresionCodigoBarraProductoTerminado_CusCider';

