CREATE VIEW [dbo].[vwCXP_NATU_Rpt008]
AS
SELECT ROW_NUMBER() OVER (ORDER BY A.IdEmpresa) AS fila, *
FROM     (SELECT og.IdEmpresa, og.IdCbteCble_Ogiro, og.IdTipoCbte_Ogiro, og.IdOrden_giro_Tipo, og.IdProveedor, og.co_fechaOg, og.co_serie, dbo.cp_TipoDocumento.Codigo + ' #' + CAST(CAST(og.co_factura AS numeric(28, 0)) AS varchar(20)) 
                  AS co_factura, og.co_FechaFactura, og.co_observacion, og.co_subtotal_iva, og.co_subtotal_siniva, og.co_baseImponible, og.co_Por_iva, og.co_total, og.co_valorpagar, ISNULL(ret.Total_Retencion, 0) AS Total_Retencion, 
                  ISNULL(can.Total_Pagos, 0) AS Total_Pagos, ISNULL(NC.total_NC, 0) AS Total_NC, ROUND(ISNULL(og.co_total, 0) - ISNULL(ret.Total_Retencion, 0) - ISNULL(can.Total_Pagos, 0) - ISNULL(NC.total_NC, 0), 2) AS Saldo, og.IdTipoFlujo, 
                  og.IdTipoServicio, og.IdSucursal, dbo.cp_proveedor.pr_nombre AS nom_proveedor, dbo.cp_TipoDocumento.Codigo AS cod_TipoDocumento, dbo.cp_TipoDocumento.Descripcion AS nom_TipoDocumento, 
                  dbo.ba_TipoFlujo.Descricion AS nom_TipoFlujo, dbo.tb_sucursal.Su_Descripcion AS nom_Sucursal, dbo.cp_proveedor.IdClaseProveedor, dbo.cp_proveedor_clase.descripcion_clas_prove AS nom_claseProveedor
FROM     dbo.cp_orden_giro AS og INNER JOIN
                  dbo.cp_proveedor ON og.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND og.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.cp_TipoDocumento ON og.IdOrden_giro_Tipo = dbo.cp_TipoDocumento.CodTipoDocumento INNER JOIN
                  dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor LEFT OUTER JOIN
                  dbo.tb_sucursal ON og.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND og.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                  dbo.ba_TipoFlujo ON og.IdEmpresa = dbo.ba_TipoFlujo.IdEmpresa AND og.IdTipoFlujo = dbo.ba_TipoFlujo.IdTipoFlujo LEFT OUTER JOIN
                      (SELECT IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, SUM(MontoAplicado) AS Total_Pagos
                       FROM      dbo.cp_orden_pago_cancelaciones
                       WHERE   (NOT EXISTS
                                             (SELECT dbo.cp_nota_DebCre.IdEmpresa
                                              FROM      dbo.cp_nota_DebCre INNER JOIN
                                                                dbo.cp_orden_pago_cancelaciones AS A ON dbo.cp_nota_DebCre.IdEmpresa = A.IdEmpresa_pago AND dbo.cp_nota_DebCre.IdCbteCble_Nota = A.IdCbteCble_pago AND 
                                                                dbo.cp_nota_DebCre.IdTipoCbte_Nota = A.IdTipoCbte_pago AND A.IdEmpresa = dbo.cp_orden_pago_cancelaciones.IdEmpresa AND A.Idcancelacion = dbo.cp_orden_pago_cancelaciones.Idcancelacion))
                       GROUP BY IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp) AS can ON og.IdEmpresa = can.IdEmpresa_cxp AND og.IdTipoCbte_Ogiro = can.IdTipoCbte_cxp AND og.IdCbteCble_Ogiro = can.IdCbteCble_cxp LEFT OUTER JOIN
                      (SELECT IdEmpresa, IdRetencion, Total_Retencion, IdEmpresa_Ogiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro
                       FROM      dbo.vwcp_Retencion_valor_total_x_cbte_cxp) AS ret ON ret.IdEmpresa_Ogiro = og.IdEmpresa AND ret.IdTipoCbte_Ogiro = og.IdTipoCbte_Ogiro AND ret.IdCbteCble_Ogiro = og.IdCbteCble_Ogiro LEFT OUTER JOIN
                      (SELECT b.IdEmpresa_cxp, b.IdTipoCbte_cxp, b.IdCbteCble_cxp, SUM(b.MontoAplicado) AS total_NC
                       FROM      dbo.cp_nota_DebCre AS a INNER JOIN
                                         dbo.cp_orden_pago_cancelaciones AS b ON a.IdEmpresa = b.IdEmpresa_pago AND a.IdTipoCbte_Nota = b.IdTipoCbte_pago AND a.IdCbteCble_Nota = b.IdCbteCble_pago
                       GROUP BY b.IdEmpresa_cxp, b.IdTipoCbte_cxp, b.IdCbteCble_cxp) AS NC ON og.IdEmpresa = NC.IdEmpresa_cxp AND og.IdTipoCbte_Ogiro = NC.IdTipoCbte_cxp AND og.IdCbteCble_Ogiro = NC.IdCbteCble_cxp
                  
WHERE  (og.Estado = 'A')
                  UNION
                  SELECT og.IdEmpresa, og.IdCbteCble_Nota, og.IdTipoCbte_Nota, '05', og.IdProveedor, og.cn_fecha, og.cn_serie1, CASE WHEN og.cn_Nota = '' THEN dbo.cp_TipoDocumento.Codigo + ' #' + cast(og.IdCbteCble_Nota AS varchar(20)) 
                                    ELSE dbo.cp_TipoDocumento.Codigo + ' #' + cast(cast(og.cn_Nota AS decimal) AS varchar(20)) END AS cn_Nota, og.cn_fecha AS a, og.cn_observacion, og.cn_subtotal_iva, og.cn_subtotal_siniva, og.cn_baseImponible, 
                                    og.cn_Por_iva, og.cn_total, og.cn_total AS b, ISNULL(ret.Total_Retencion, 0) AS Total_Retencion, ISNULL(can.Total_Pagos, 0) AS Total_Pagos, ISNULL(NC.total_NC, 0) AS Total_NC, round(ISNULL(og.cn_total, 0) 
                                    - ISNULL(ret.Total_Retencion, 0) - ISNULL(can.Total_Pagos, 0) - ISNULL(NC.total_NC, 0), 2) AS Saldo, og.IdTipoFlujo, og.IdTipoServicio, og.IdSucursal, dbo.cp_proveedor.pr_nombre AS nom_proveedor, 
                                    dbo.cp_TipoDocumento.Codigo AS cod_TipoDocumento, dbo.cp_TipoDocumento.Descripcion AS nom_TipoDocumento, dbo.ba_TipoFlujo.Descricion AS nom_TipoFlujo, dbo.tb_sucursal.Su_Descripcion AS nom_Sucursal, 
                                    dbo.cp_proveedor.IdClaseProveedor, dbo.cp_proveedor_clase.descripcion_clas_prove AS nom_claseProveedor
                  FROM     dbo.cp_nota_DebCre AS og INNER JOIN
                                    dbo.cp_proveedor ON og.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND og.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                                    dbo.cp_TipoDocumento ON dbo.cp_TipoDocumento.CodTipoDocumento = '05' INNER JOIN
                                    dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor LEFT OUTER JOIN
                                    dbo.tb_sucursal ON og.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND og.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                                    dbo.ba_TipoFlujo ON og.IdEmpresa = dbo.ba_TipoFlujo.IdEmpresa AND og.IdTipoFlujo = dbo.ba_TipoFlujo.IdTipoFlujo LEFT OUTER JOIN
                                        (SELECT IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, SUM(MontoAplicado) AS Total_Pagos
                                         FROM      dbo.cp_orden_pago_cancelaciones
                                         WHERE   (NOT EXISTS
                                                               (SELECT dbo.cp_nota_DebCre.IdEmpresa
                                                                FROM      dbo.cp_nota_DebCre INNER JOIN
                                                                                  dbo.cp_orden_pago_cancelaciones AS A ON dbo.cp_nota_DebCre.IdEmpresa = A.IdEmpresa_pago AND dbo.cp_nota_DebCre.IdCbteCble_Nota = A.IdCbteCble_pago AND 
                                                                                  dbo.cp_nota_DebCre.IdTipoCbte_Nota = A.IdTipoCbte_pago AND A.IdEmpresa = dbo.cp_orden_pago_cancelaciones.IdEmpresa AND A.Idcancelacion = dbo.cp_orden_pago_cancelaciones.Idcancelacion))
                                         GROUP BY IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp) AS can ON og.IdEmpresa = can.IdEmpresa_cxp AND og.IdTipoCbte_Nota = can.IdTipoCbte_cxp AND og.IdCbteCble_Nota = can.IdCbteCble_cxp LEFT OUTER JOIN
                                        (SELECT IdEmpresa, IdRetencion, Total_Retencion, IdEmpresa_Ogiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro
                                         FROM      dbo.vwcp_Retencion_valor_total_x_cbte_cxp) AS ret ON ret.IdEmpresa_Ogiro = og.IdEmpresa AND ret.IdTipoCbte_Ogiro = og.IdTipoCbte_Nota AND ret.IdCbteCble_Ogiro = og.IdCbteCble_Nota LEFT OUTER JOIN
                                        (SELECT b.IdEmpresa_cxp, b.IdTipoCbte_cxp, b.IdCbteCble_cxp, sum(b.MontoAplicado) total_NC
                                         FROM      cp_nota_debcre AS a INNER JOIN
                                                           cp_orden_pago_cancelaciones AS b ON a.IdEmpresa = b.IdEmpresa_pago AND a.IdTipoCbte_Nota = b.IdTipoCbte_pago AND a.IdCbteCble_Nota = b.IdCbteCble_pago
                                         GROUP BY b.IdEmpresa_cxp, b.IdTipoCbte_cxp, b.IdCbteCble_cxp) AS NC ON og.IdEmpresa = NC.IdEmpresa_cxp AND og.IdTipoCbte_Nota = NC.IdTipoCbte_cxp AND og.IdCbteCble_Nota = NC.IdCbteCble_cxp
                  WHERE  og.DebCre = 'D' AND  OG.Estado = 'A') A
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCXP_NATU_Rpt008';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ret"
            Begin Extent = 
               Top = 270
               Left = 285
               Bottom = 399
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NC"
            Begin Extent = 
               Top = 270
               Left = 532
               Bottom = 399
               Right = 741
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
      Begin ColumnWidths = 31
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3315
         Alias = 2565
         Table = 2310
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCXP_NATU_Rpt008';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[27] 4[6] 2[19] 3) )"
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
         Begin Table = "og"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 6
               Left = 317
               Bottom = 135
               Right = 538
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_TipoDocumento"
            Begin Extent = 
               Top = 6
               Left = 576
               Bottom = 135
               Right = 845
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor_clase"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 138
               Left = 339
               Bottom = 267
               Right = 569
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_TipoFlujo"
            Begin Extent = 
               Top = 138
               Left = 607
               Bottom = 267
               Right = 816
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "can"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 247
            End
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCXP_NATU_Rpt008';

