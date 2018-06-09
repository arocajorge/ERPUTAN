CREATE VIEW [dbo].[vwImp_GastosImportacion_X_Proveedor]
AS
SELECT     TOP (200) dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdRegistroGasto, 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdSucusal AS IdSucursal, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdOrdenCompraExt, 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdTipoCbte, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdCbteCble, 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdTipoCbte_Anu, dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdCbteCble_Anu, 
                      dbo.imp_gastosxImport.ga_decripcion AS ga_descripcion, dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.Valor, 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport.Observacion, dbo.imp_ordencompra_ext_x_imp_gastosxImport.CodDocu_Pago, 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdGastoImp
FROM         dbo.imp_gastosxImport INNER JOIN
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det ON 
                      dbo.imp_gastosxImport.IdGastoImp = dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdGastoImp INNER JOIN
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport ON 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdEmpresa = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdEmpresa AND 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdRegistroGasto = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdRegistroGasto AND 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdSucursal = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdSucusal AND 
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport_det.IdOrdenCompraExt = dbo.imp_ordencompra_ext_x_imp_gastosxImport.IdOrdenCompraExt
WHERE     (dbo.imp_ordencompra_ext_x_imp_gastosxImport.CodDocu_Pago = 'FACPROV')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_GastosImportacion_X_Proveedor';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[11] 2[20] 3) )"
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
         Begin Table = "imp_gastosxImport"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 383
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_ordencompra_ext_x_imp_gastosxImport_det"
            Begin Extent = 
               Top = 33
               Left = 461
               Bottom = 250
               Right = 873
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_ordencompra_ext_x_imp_gastosxImport"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 245
               Right = 422
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_GastosImportacion_X_Proveedor';

