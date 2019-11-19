CREATE VIEW [Naturisa].[vwCOMP_NATU_Rpt008]
AS
SELECT d.IdEmpresa, d.IdOrdenPedido, d.Secuencia, c.IdProducto, 

ISNULL(p.pr_descripcion, d.pr_descripcion) 
+
 case when d.IdPunto_cargo is null then '' else ' /Cargo: '+pc.nom_punto_cargo end
AS pr_descripcion, 

c.IdCotizacion, ISNULL(c.cd_Cantidad, d.opd_CantidadApro) AS cd_cantidad, c.cd_precioCompra, c.cd_porc_des, 
                  c.cd_descuento, c.cd_precioFinal, c.cd_subtotal, c.IdCod_Impuesto, c.Por_Iva, c.cd_iva, c.cd_total, c.IdUnidadMedida, ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) AS IdPunto_cargo, pc.nom_punto_cargo, dc.IdSolicitante, 
                  dc.IdDepartamento, sol.nom_solicitante, u.Descripcion AS nomUnidadMedida, 
                  CASE WHEN d .opd_EstadoProceso = 'P' THEN 'PENDIENTE' WHEN d .opd_EstadoProceso = 'A' THEN 'CANTIDAD APROBADA' WHEN d .opd_EstadoProceso = 'RA' THEN 'CANTIDAD RECHAZADA' WHEN d .opd_EstadoProceso = 'AJC' THEN
                   'PRECIO APROBADO' WHEN d .opd_EstadoProceso = 'C' THEN 'COMPRADO' WHEN d .opd_EstadoProceso = 'RC' THEN 'RECHAZADO POR COMPRADOR' WHEN d .opd_EstadoProceso = 'AC' THEN 'COTIZADO' WHEN d .opd_EstadoProceso
                   = 'RGA' THEN 'COTIZACION RECHAZADA' END AS EstadoDetalle, d.opd_EstadoProceso, d.IdSucursalDestino, d.IdSucursalOrigen, c.Secuencia AS SecuenciaCot, 
				   case when d.opd_Detalle is null then '' else ('Sol:'+d.opd_Detalle+' ')end
				   +
				   case when c.cd_DetallePorItem is null then '' else (' Com:'+ c.cd_DetallePorItem) end cd_DetallePorItem, 
				   
				   dbo.com_CotizacionPedido.cp_Observacion, 
                  dbo.com_CotizacionPedido.cp_ObservacionAdicional, ISNULL(dbo.com_CotizacionPedido.cp_Fecha, CAST(GETDATE() AS date)) AS cp_Fecha, dbo.com_comprador.IdUsuario_com AS Comprador, d.opd_Detalle, per.pe_nombreCompleto, 
                  suori.codigo AS SucursalOrigen, sudes.codigo AS SucursalDestino, CASE WHEN c.por_iva > 0 THEN c.cd_subtotal END AS SubtotalIva, CASE WHEN isnull(c.por_iva, 0) = 0 THEN c.cd_subtotal END AS SubtotalSinIva, dc.op_Fecha, 
                  dc.op_Observacion
FROM     dbo.tb_persona AS per INNER JOIN
                  dbo.cp_proveedor AS pro ON per.IdPersona = pro.IdPersona RIGHT OUTER JOIN
                  dbo.com_comprador INNER JOIN
                  dbo.com_CotizacionPedido ON dbo.com_comprador.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_CotizacionPedido.IdComprador RIGHT OUTER JOIN
                  dbo.com_OrdenPedidoDet AS d LEFT OUTER JOIN
                  dbo.com_CotizacionPedidoDet AS c ON d.IdEmpresa = c.opd_IdEmpresa AND d.IdOrdenPedido = c.opd_IdOrdenPedido AND d.Secuencia = c.opd_Secuencia AND c.EstadoJC = 1 LEFT OUTER JOIN
                  dbo.in_Producto AS p ON c.IdEmpresa = p.IdEmpresa AND c.IdProducto = p.IdProducto LEFT OUTER JOIN
                  dbo.ct_punto_cargo AS pc ON d.IdEmpresa = pc.IdEmpresa AND ISNULL(c.IdPunto_cargo, d.IdPunto_cargo) = pc.IdPunto_cargo INNER JOIN
                  dbo.com_OrdenPedido AS dc ON dc.IdEmpresa = d.IdEmpresa AND dc.IdOrdenPedido = d.IdOrdenPedido INNER JOIN
                  dbo.com_solicitante AS sol ON dc.IdEmpresa = sol.IdEmpresa AND dc.IdSolicitante = sol.IdSolicitante ON dbo.com_CotizacionPedido.IdEmpresa = c.IdEmpresa AND 
                  dbo.com_CotizacionPedido.IdCotizacion = c.IdCotizacion LEFT OUTER JOIN
                  dbo.in_UnidadMedida AS u ON d.IdUnidadMedida = u.IdUnidadMedida ON pro.IdEmpresa = dbo.com_CotizacionPedido.IdEmpresa AND pro.IdProveedor = dbo.com_CotizacionPedido.IdProveedor LEFT OUTER JOIN
                  dbo.tb_sucursal AS sudes ON sudes.IdEmpresa = d.IdEmpresa AND sudes.IdSucursal = d.IdSucursalDestino LEFT OUTER JOIN
                  dbo.tb_sucursal AS suori ON suori.IdEmpresa = d.IdEmpresa AND suori.IdSucursal = d.IdSucursalOrigen 
WHERE  (d.opd_EstadoProceso NOT IN ('RA', 'RC', 'RGA'))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt008';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'           TopColumn = 0
         End
         Begin Table = "pc"
            Begin Extent = 
               Top = 1183
               Left = 48
               Bottom = 1346
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dc"
            Begin Extent = 
               Top = 1351
               Left = 48
               Bottom = 1514
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "sol"
            Begin Extent = 
               Top = 1519
               Left = 48
               Bottom = 1682
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "u"
            Begin Extent = 
               Top = 1687
               Left = 48
               Bottom = 1850
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sudes"
            Begin Extent = 
               Top = 1855
               Left = 48
               Bottom = 2018
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "suori"
            Begin Extent = 
               Top = 2023
               Left = 48
               Bottom = 2186
               Right = 320
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
', @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt008';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Top = -1320
         Left = 0
      End
      Begin Tables = 
         Begin Table = "per"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pro"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_CotizacionPedido"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 310
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 277
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = 323
            End
            DisplayFlags = 280
 ', @level0type = N'SCHEMA', @level0name = N'Naturisa', @level1type = N'VIEW', @level1name = N'vwCOMP_NATU_Rpt008';

