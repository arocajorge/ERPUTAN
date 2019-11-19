CREATE VIEW [dbo].[vwcom_CotizacionPedidoDetAprobacion]
AS
SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, c.IdProducto, ISNULL(p.pr_descripcion, d.pr_descripcion) AS pr_descripcion, c.IdCotizacion, ISNULL(c.cd_Cantidad, d.opd_CantidadApro) AS cd_cantidad, c.cd_precioCompra, c.cd_porc_des, 
                  c.cd_descuento, c.cd_precioFinal, c.cd_subtotal, c.IdCod_Impuesto, c.Por_Iva, c.cd_iva, c.cd_total, c.IdUnidadMedida, ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) AS IdPunto_cargo, pc.nom_punto_cargo, dc.IdSolicitante, 
                  dc.IdDepartamento, s.IdUsuario, sol.nom_solicitante, u.Descripcion AS nomUnidadMedida, 
                  CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN
                   'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'COMPRADO' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso
                   = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle, d.opd_EstadoProceso, d.IdSucursalDestino, d.IdSucursalOrigen, c.Secuencia AS SecuenciaCot, c.cd_DetallePorItem, dbo.com_CotizacionPedido.cp_Observacion, 
                  dbo.com_CotizacionPedido.cp_ObservacionAdicional, isnull(dbo.com_CotizacionPedido.cp_Fecha, cast(getdate() as date)) cp_Fecha, dbo.com_comprador.Descripcion AS Comprador, d.opd_Detalle
FROM     dbo.com_comprador INNER JOIN
                  dbo.com_CotizacionPedido ON dbo.com_comprador.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_CotizacionPedido.IdComprador RIGHT OUTER JOIN
                  dbo.com_OrdenPedidoDet AS d LEFT OUTER JOIN
                  dbo.com_CotizacionPedidoDet AS c ON d.IdEmpresa = c.opd_IdEmpresa AND d.IdOrdenPedido = c.opd_IdOrdenPedido AND d.Secuencia = c.opd_Secuencia AND c.EstadoJC = 1 LEFT OUTER JOIN
                  dbo.in_Producto AS p ON c.IdEmpresa = p.IdEmpresa AND c.IdProducto = p.IdProducto LEFT OUTER JOIN
                  dbo.ct_punto_cargo AS pc ON d.IdEmpresa = pc.IdEmpresa AND ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) = pc.IdPunto_cargo INNER JOIN
                  dbo.com_OrdenPedido AS dc ON dc.IdEmpresa = d.IdEmpresa AND dc.IdOrdenPedido = d.IdOrdenPedido INNER JOIN
                  dbo.com_solicitante_aprobador AS s ON s.IdEmpresa = dc.IdEmpresa AND s.IdSolicitante = dc.IdSolicitante AND dc.IdDepartamento = s.IdDepartamento INNER JOIN
                  dbo.com_solicitante AS sol ON dc.IdEmpresa = sol.IdEmpresa AND dc.IdSolicitante = sol.IdSolicitante ON dbo.com_CotizacionPedido.IdEmpresa = c.IdEmpresa AND 
                  dbo.com_CotizacionPedido.IdCotizacion = c.IdCotizacion LEFT OUTER JOIN
                  dbo.in_UnidadMedida AS u ON d.IdUnidadMedida = u.IdUnidadMedida
WHERE  (d.opd_EstadoProceso NOT IN ('RA', 'RC', 'RGA', 'C'))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDetAprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'End
         Begin Table = "u"
            Begin Extent = 
               Top = 1183
               Left = 48
               Bottom = 1346
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 7
               Left = 651
               Bottom = 170
               Right = 859
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_CotizacionPedido"
            Begin Extent = 
               Top = 7
               Left = 907
               Bottom = 170
               Right = 1169
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
      Begin ColumnWidths = 36
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1464
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDetAprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[7] 2[19] 3) )"
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
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 10
               Left = 374
               Bottom = 300
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 323
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "pc"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dc"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sol"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_CotizacionPedidoDetAprobacion';

