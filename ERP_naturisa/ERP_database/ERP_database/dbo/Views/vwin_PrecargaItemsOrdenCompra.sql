CREATE VIEW [dbo].[vwin_PrecargaItemsOrdenCompra]
AS
SELECT        dbo.in_PrecargaItemsOrdenCompra.IdEmpresa, dbo.in_PrecargaItemsOrdenCompra.IdSucursal, dbo.in_PrecargaItemsOrdenCompra.IdPrecarga, 
                         dbo.in_PrecargaItemsOrdenCompra.IdCentroCosto, dbo.in_PrecargaItemsOrdenCompra.IdOrdenTaller, dbo.in_PrecargaItemsOrdenCompra.IdProveedor, 
                         dbo.in_PrecargaItemsOrdenCompra.pre_fecha, dbo.in_PrecargaItemsOrdenCompra.pre_subtotal, dbo.in_PrecargaItemsOrdenCompra.pre_iva, 
                         dbo.in_PrecargaItemsOrdenCompra.pre_descuento, dbo.in_PrecargaItemsOrdenCompra.pre_pordesc, dbo.in_PrecargaItemsOrdenCompra.pre_total, 
                         dbo.in_PrecargaItemsOrdenCompra.pre_Base_conIva, dbo.in_PrecargaItemsOrdenCompra.pre_Base_sinIva, dbo.in_PrecargaItemsOrdenCompra.pre_observacion, 
                         dbo.in_PrecargaItemsOrdenCompra.Fechreg, dbo.in_PrecargaItemsOrdenCompra.Estado, dbo.in_PrecargaItemsOrdenCompra.pre_NumDocumento, 
                         dbo.in_PrecargaItemsOrdenCompra.pre_PesoTotal, dbo.in_PrecargaItemsOrdenCompra.pre_fecha_emision, dbo.tb_sucursal.Su_Descripcion, 
                         dbo.ct_centro_costo.CodCentroCosto, dbo.ct_centro_costo.Centro_costo, dbo.cp_proveedor.pr_nombre, dbo.prd_Orden_Taller.NumeroOT, 
                         dbo.prd_Orden_Taller.Codigo AS CodOrdenTaller
FROM            dbo.in_PrecargaItemsOrdenCompra INNER JOIN
                         dbo.tb_sucursal ON dbo.in_PrecargaItemsOrdenCompra.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.ct_centro_costo ON dbo.in_PrecargaItemsOrdenCompra.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.cp_proveedor ON dbo.in_PrecargaItemsOrdenCompra.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.prd_Orden_Taller ON dbo.ct_centro_costo.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                         dbo.in_PrecargaItemsOrdenCompra.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_PrecargaItemsOrdenCompra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'th = 1500
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
         Alias = 2700
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_PrecargaItemsOrdenCompra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[16] 4[4] 2[61] 3) )"
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
         Begin Table = "in_PrecargaItemsOrdenCompra"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 102
               Left = 380
               Bottom = 221
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 48
               Left = 687
               Bottom = 167
               Right = 875
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 113
               Left = 693
               Bottom = 232
               Right = 903
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 21
               Left = 1033
               Bottom = 325
               Right = 1193
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
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
         Wid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_PrecargaItemsOrdenCompra';

