/*WHERE     (A.IdOrdenDespacho = 8) AND (A.IdEmpresa = 1) AND (A.IdSucursal = 2) AND (A.IdBodega = 1)                   */
CREATE VIEW [dbo].[vwfa_orden_Desp_det_x_Pedido_det]
AS
SELECT     A.IdEmpresa, A.IdSucursal, A.IdBodega, A.IdOrdenDespacho, A.Secuencia, A.IdProducto, A.od_cantidad, A.od_Precio, A.od_PorDescUnitario, A.od_DescUnitario, 
                      A.od_PrecioFinal, A.od_Subtotal, A.od_iva, A.od_total, A.od_costo, A.od_tieneIVA, A.od_detallexItems, B.pe_IdEmpresa, B.pe_IdSucursal, B.pe_IdBodega, 
                      B.pe_IdPedido, B.pe_Secuencia, A.od_peso, c.pr_descripcion, CASE WHEN dbo.fa_guia_remision_det_x_fa_orden_Desp_det.gi_IdEmpresa IS NULL 
                      THEN 'N' ELSE 'S' END AS Tiene_guia
FROM         dbo.fa_orden_Desp_det AS A LEFT OUTER JOIN
                      dbo.fa_orden_Desp_det_x_fa_pedido_det AS B ON A.IdEmpresa = B.od_IdEmpresa AND A.IdSucursal = B.od_IdSucursal AND A.IdBodega = B.od_IdBodega AND 
                      A.IdOrdenDespacho = B.od_IdOrdenDespacho AND A.Secuencia = B.od_Secuencia INNER JOIN
                      dbo.in_Producto AS c ON A.IdEmpresa = c.IdEmpresa AND A.IdProducto = c.IdProducto LEFT OUTER JOIN
                      dbo.fa_guia_remision_det_x_fa_orden_Desp_det ON A.IdProducto = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_IdProducto AND 
                      A.IdBodega = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_IdBodega AND A.IdSucursal = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_IdSucursal AND
                       A.IdEmpresa = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_IdEmpresa AND 
                      A.IdOrdenDespacho = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_IdOrdenDespacho AND 
                      A.Secuencia = dbo.fa_guia_remision_det_x_fa_orden_Desp_det.od_Secuencia
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_Desp_det_x_Pedido_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[67] 4[4] 2[10] 3) )"
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
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 240
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 0
               Left = 849
               Bottom = 236
               Right = 1034
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 262
               Left = 0
               Bottom = 370
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_guia_remision_det_x_fa_orden_Desp_det"
            Begin Extent = 
               Top = 97
               Left = 649
               Bottom = 397
               Right = 834
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_orden_Desp_det_x_Pedido_det';

