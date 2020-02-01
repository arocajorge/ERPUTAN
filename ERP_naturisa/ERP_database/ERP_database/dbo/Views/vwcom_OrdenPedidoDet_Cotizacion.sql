CREATE VIEW [dbo].[vwcom_OrdenPedidoDet_Cotizacion]
AS
SELECT        d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, isnull(p.pr_descripcion, d.pr_descripcion) pr_descripcion, d.IdUnidadMedida, d.IdSucursalOrigen, d.IdSucursalDestino, ISNULL(d.IdPunto_cargo, Cod.IdPunto_cargo) AS IdPunto_cargo, d.opd_Cantidad, d.opd_CantidadApro, 
                         d.opd_EstadoProceso, d.opd_Detalle, p.IdUnidadMedida_Consumo, CAST(0 AS float) AS Stock, s.nom_solicitante, d.IdProducto, dbo.com_comprador.IdUsuario_com, ISNULL(Cod.IdCod_Impuesto, p.IdCod_Impuesto_Iva) 
                         AS IdCod_Impuesto_Iva, c.IdSolicitante, c.IdDepartamento, dbo.com_comprador_familia.IdComprador, c.EsCompraUrgente, d.Adjunto, c.op_Fecha, c.op_Observacion, d.NombreArchivo, 
                         CASE WHEN d .opd_EstadoProceso = 'AC' OR
                         d .opd_EstadoProceso = 'AJC' OR
                         d .opd_EstadoProceso = 'C' OR
                         d .opd_EstadoProceso = 'T' OR
                         d .opd_EstadoProceso IN ('RGA', 'I') THEN '4. APROBADOS' WHEN d .opd_EstadoProceso = 'RC' THEN '5. RECHAZADO' WHEN c.EsCompraUrgente = 1 THEN '1. URGENTE' WHEN d .IdProducto IS NULL 
                         THEN '3. NO CREADOS' ELSE '2. NORMALES' END AS Grupo, d.FechaCantidad, coc.IdProveedor, Cod.cd_precioCompra, Cod.cd_porc_des, Cod.cd_descuento, Cod.cd_precioFinal, Cod.cd_subtotal, Cod.Por_Iva, Cod.cd_iva, 
                         Cod.cd_total, Cod.cd_DetallePorItem, 
                         CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso =
                          'AJC' THEN 'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'OC GENERADA' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN
                          d .opd_EstadoProceso = 'RGA' THEN 'COTIZACION RECHAZADA' WHEN d .opd_EstadoProceso = 'I' THEN 'INGRESADO A BODEGA' WHEN d .opd_EstadoProceso = 'T' THEN 'TRANSFERIDO' END AS EstadoDetalle, 
                         c.ObservacionGA, su.Su_Descripcion, su.codigo + '-' + CAST(coc.oc_IdOrdenCompra AS varchar(20)) AS CodigoOC
FROM            dbo.com_comprador INNER JOIN
                         dbo.com_comprador_familia ON dbo.com_comprador.IdEmpresa = dbo.com_comprador_familia.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_comprador_familia.IdComprador INNER JOIN
                         dbo.in_Producto AS p ON dbo.com_comprador_familia.IdEmpresa = p.IdEmpresa AND dbo.com_comprador_familia.IdFamilia = p.IdFamilia RIGHT OUTER JOIN
                         dbo.com_OrdenPedidoDet AS d INNER JOIN
                         dbo.com_OrdenPedido AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdOrdenPedido = d.IdOrdenPedido INNER JOIN
                         dbo.com_solicitante AS s ON s.IdEmpresa = c.IdEmpresa AND s.IdSolicitante = c.IdSolicitante ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto LEFT OUTER JOIN
                         dbo.com_CotizacionPedidoDet AS Cod ON d.IdEmpresa = Cod.opd_IdEmpresa AND d.IdOrdenPedido = Cod.opd_IdOrdenPedido AND d.Secuencia = Cod.opd_Secuencia AND Cod.EstadoJC = 1 LEFT OUTER JOIN
                         dbo.com_CotizacionPedido AS coc ON coc.IdEmpresa = Cod.IdEmpresa AND coc.IdCotizacion = Cod.IdCotizacion AND coc.EstadoJC <> 'R' LEFT OUTER JOIN
                         dbo.tb_sucursal AS su ON coc.IdEmpresa = su.IdEmpresa AND coc.IdSucursal = su.IdSucursal
WHERE        (c.Estado = 1) AND (d.opd_EstadoProceso NOT IN ('RA', 'P'))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Cotizacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ias = 900
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Cotizacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[65] 4[3] 2[14] 3) )"
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
         Top = -600
         Left = 0
      End
      Begin Tables = 
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador_familia"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 339
            End
            DisplayFlags = 280
            TopColumn = 52
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 14
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 280
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 272
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
         Al', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcom_OrdenPedidoDet_Cotizacion';

