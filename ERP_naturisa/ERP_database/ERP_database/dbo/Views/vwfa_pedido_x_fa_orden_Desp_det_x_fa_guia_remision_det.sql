/* select * from vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det
select * from fa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det                      */
CREATE VIEW [dbo].[vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det]
AS
SELECT     A.IdEmpresa, A.IdSucursal, A.IdBodega, A.IdPedido, B.IdProducto, B.dp_cantidad, ISNULL(F.gi_cantidad, 0) AS gi_cantidad_guia, 
                      B.dp_cantidad - ISNULL(F.gi_cantidad, 0) AS saldo_cantidad_pedido
FROM         dbo.fa_orden_Desp_det AS C INNER JOIN
                      dbo.fa_orden_Desp_det_x_fa_pedido_det AS D ON C.IdEmpresa = D.od_IdEmpresa AND C.IdSucursal = D.od_IdSucursal AND C.IdBodega = D.od_IdBodega AND 
                      C.IdOrdenDespacho = D.od_IdOrdenDespacho AND C.Secuencia = D.od_Secuencia INNER JOIN
                      dbo.fa_guia_remision_det_x_fa_orden_Desp_det AS E ON C.IdEmpresa = E.od_IdEmpresa AND C.IdSucursal = E.gi_IdSucursal AND C.IdBodega = E.gi_IdBodega AND 
                      C.IdOrdenDespacho = E.od_IdOrdenDespacho AND C.Secuencia = E.od_Secuencia INNER JOIN
                      dbo.fa_guia_remision_det AS F ON E.gi_IdEmpresa = F.IdEmpresa AND E.gi_IdSucursal = F.IdSucursal AND E.gi_IdBodega = F.IdBodega AND 
                      E.gi_IdGuiaRemision = F.IdGuiaRemision AND E.gi_Secuencia = F.Secuencia INNER JOIN
                      dbo.fa_guia_remision ON F.IdEmpresa = dbo.fa_guia_remision.IdEmpresa AND F.IdSucursal = dbo.fa_guia_remision.IdSucursal AND 
                      F.IdBodega = dbo.fa_guia_remision.IdBodega AND F.IdGuiaRemision = dbo.fa_guia_remision.IdGuiaRemision INNER JOIN
                      dbo.fa_orden_Desp ON C.IdEmpresa = dbo.fa_orden_Desp.IdEmpresa AND C.IdSucursal = dbo.fa_orden_Desp.IdSucursal AND 
                      C.IdBodega = dbo.fa_orden_Desp.IdBodega AND C.IdOrdenDespacho = dbo.fa_orden_Desp.IdOrdenDespacho RIGHT OUTER JOIN
                      dbo.fa_pedido AS A INNER JOIN
                      dbo.fa_pedido_det AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdSucursal = B.IdSucursal AND A.IdBodega = B.IdBodega AND A.IdPedido = B.IdPedido ON 
                      D.pe_IdEmpresa = B.IdEmpresa AND D.pe_IdSucursal = B.IdSucursal AND D.pe_IdBodega = B.IdBodega AND D.pe_IdPedido = B.IdPedido AND 
                      D.pe_Secuencia = B.Secuencial
WHERE     (A.Estado = 'A') AND (dbo.fa_orden_Desp.Estado = 'A' OR
                      dbo.fa_orden_Desp.Estado IS NULL) AND (dbo.fa_guia_remision.Estado = 'A' OR
                      dbo.fa_guia_remision.Estado IS NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   TopColumn = 12
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 233
               Left = 795
               Bottom = 352
               Right = 969
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
      Begin ColumnWidths = 11
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[5] 4[26] 2[4] 3) )"
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
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 185
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 162
               Left = 329
               Bottom = 281
               Right = 523
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 261
               Left = 222
               Bottom = 380
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F"
            Begin Extent = 
               Top = 237
               Left = 292
               Bottom = 356
               Right = 471
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_guia_remision"
            Begin Extent = 
               Top = 304
               Left = 551
               Bottom = 496
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 20
         End
         Begin Table = "fa_orden_Desp"
            Begin Extent = 
               Top = 0
               Left = 539
               Bottom = 179
               Right = 724
            End
            DisplayFlags = 280
            TopColumn = 16
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 39
               Left = 985
               Bottom = 274
               Right = 1175
            End
            DisplayFlags = 280
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det';

