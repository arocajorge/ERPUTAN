CREATE view [dbo].[vwcom_OrdenPedidoDet]
as
SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, d.pr_descripcion, d.IdUnidadMedida, d.IdSucursalOrigen, d.IdSucursalDestino, d.IdPunto_cargo, d.opd_Cantidad, d.opd_CantidadApro, d.opd_EstadoProceso, d.opd_Detalle, 
                  p.IdUnidadMedida_Consumo, CAST(0 AS FLOAT) AS Stock, s.nom_solicitante, d.IdProducto, d.Adjunto, 
                  CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN
                   'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso
                   = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle, d.NombreArchivo, dbo.com_comprador.Descripcion AS NomComprador
FROM     dbo.com_CotizacionPedido INNER JOIN
                  dbo.com_CotizacionPedidoDet ON dbo.com_CotizacionPedido.IdEmpresa = dbo.com_CotizacionPedidoDet.IdEmpresa AND dbo.com_CotizacionPedido.IdCotizacion = dbo.com_CotizacionPedidoDet.IdCotizacion and dbo.com_CotizacionPedido.EstadoJC IN ('P','A') INNER JOIN
                  dbo.com_comprador ON dbo.com_CotizacionPedido.IdEmpresa = dbo.com_comprador.IdEmpresa AND dbo.com_CotizacionPedido.IdComprador = dbo.com_comprador.IdComprador RIGHT OUTER JOIN
                  dbo.com_OrdenPedidoDet AS d INNER JOIN
                  dbo.com_OrdenPedido AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdOrdenPedido = d.IdOrdenPedido INNER JOIN
                  dbo.com_solicitante AS s ON s.IdEmpresa = c.IdEmpresa AND s.IdSolicitante = c.IdSolicitante ON dbo.com_CotizacionPedidoDet.opd_IdEmpresa = d.IdEmpresa AND 
                  dbo.com_CotizacionPedidoDet.opd_IdOrdenPedido = d.IdOrdenPedido AND dbo.com_CotizacionPedidoDet.opd_Secuencia = d.Secuencia LEFT OUTER JOIN
                  dbo.in_Producto AS p ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto
--WHERE d.Idordenpedido = 1417 and d.secuencia = 14
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[11] 2[20] 3) )"
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
         Begin Table = "d"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 2
               Left = 534
               Bottom = 165
               Right = 825
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet';

