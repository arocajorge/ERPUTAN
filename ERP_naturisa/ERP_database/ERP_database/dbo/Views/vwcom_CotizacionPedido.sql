CREATE VIEW dbo.vwcom_CotizacionPedido
AS
SELECT dbo.com_CotizacionPedido.IdEmpresa, dbo.com_CotizacionPedido.IdCotizacion, dbo.com_CotizacionPedido.IdSucursal, dbo.com_CotizacionPedido.IdProveedor, dbo.com_CotizacionPedido.IdTerminoPago, 
                  dbo.com_CotizacionPedido.cp_Fecha, dbo.com_CotizacionPedido.cp_Plazo, dbo.com_CotizacionPedido.cp_Observacion, dbo.com_CotizacionPedido.IdComprador, dbo.com_CotizacionPedido.IdSolicitante, 
                  dbo.com_CotizacionPedido.IdDepartamento, dbo.com_CotizacionPedido.EstadoJC, dbo.com_CotizacionPedido.EstadoGA, dbo.tb_sucursal.Su_Descripcion, dbo.tb_persona.pe_nombreCompleto, 
                  dbo.com_TerminoPago.Descripcion AS TerminoPago, dbo.com_comprador.Descripcion AS Comprador, dbo.com_solicitante.nom_solicitante, dbo.com_departamento.nom_departamento, 
                  CASE WHEN dbo.com_CotizacionPedidoSaltar.IdEmpresa IS NULL THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS Pasado, dbo.com_CotizacionPedido.cp_PlazoEntrega, d.opd_IdOrdenPedido, 
                  dbo.com_CotizacionPedido.cp_ObservacionAdicional, dbo.com_OrdenPedido.EsCompraUrgente
FROM     dbo.com_OrdenPedido RIGHT OUTER JOIN
                      (SELECT IdEmpresa, IdCotizacion, MAX(opd_IdOrdenPedido) AS opd_IdOrdenPedido
                       FROM      dbo.com_CotizacionPedidoDet
                       GROUP BY IdEmpresa, IdCotizacion) AS d ON dbo.com_OrdenPedido.IdEmpresa = d.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = d.opd_IdOrdenPedido RIGHT OUTER JOIN
                  dbo.com_departamento INNER JOIN
                  dbo.tb_persona INNER JOIN
                  dbo.tb_sucursal INNER JOIN
                  dbo.com_CotizacionPedido ON dbo.tb_sucursal.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.com_CotizacionPedido.IdSucursal INNER JOIN
                  dbo.cp_proveedor ON dbo.com_CotizacionPedido.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_CotizacionPedido.IdProveedor = dbo.cp_proveedor.IdProveedor ON 
                  dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona INNER JOIN
                  dbo.com_TerminoPago ON dbo.com_CotizacionPedido.IdTerminoPago = dbo.com_TerminoPago.IdTerminoPago INNER JOIN
                  dbo.com_comprador ON dbo.com_CotizacionPedido.IdEmpresa = dbo.com_comprador.IdEmpresa AND dbo.com_CotizacionPedido.IdComprador = dbo.com_comprador.IdComprador INNER JOIN
                  dbo.com_solicitante ON dbo.com_CotizacionPedido.IdSolicitante = dbo.com_solicitante.IdSolicitante AND dbo.com_CotizacionPedido.IdEmpresa = dbo.com_solicitante.IdEmpresa ON 
                  dbo.com_departamento.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND dbo.com_departamento.IdDepartamento = dbo.com_CotizacionPedido.IdDepartamento LEFT OUTER JOIN
                  dbo.com_CotizacionPedidoSaltar ON dbo.com_CotizacionPedido.IdEmpresa = dbo.com_CotizacionPedidoSaltar.IdEmpresa AND dbo.com_CotizacionPedido.IdCotizacion = dbo.com_CotizacionPedidoSaltar.IdCotizacion ON 
                  d.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND d.IdCotizacion = dbo.com_CotizacionPedido.IdCotizacion
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedido';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'6
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_solicitante"
            Begin Extent = 
               Top = 1183
               Left = 48
               Bottom = 1346
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_CotizacionPedidoSaltar"
            Begin Extent = 
               Top = 1519
               Left = 48
               Bottom = 1791
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 1346
               Left = 48
               Bottom = 1498
               Right = 277
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_OrdenPedido"
            Begin Extent = 
               Top = 1372
               Left = 574
               Bottom = 1581
               Right = 810
            End
            DisplayFlags = 280
            TopColumn = 14
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedido';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[30] 2[3] 3) )"
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
         Top = -1200
         Left = 0
      End
      Begin Tables = 
         Begin Table = "com_departamento"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 274
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_CotizacionPedido"
            Begin Extent = 
               Top = 0
               Left = 756
               Bottom = 469
               Right = 961
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_TerminoPago"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 25', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedido';

