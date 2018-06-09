CREATE VIEW [dbo].[vwImp_LiquidacionImportacion]
AS
SELECT     a.IdEmpresa, a.IdRegistroGasto, a.IdSucusal, a.IdOrdenCompraExt, C.ga_decripcion, b.pr_nombre, a.IdTipoCbte, a.IdCbteCble, E.CodCbteCble, a.Estado, 
                      dbo.imp_gastosxImport_x_Empresa.AfectaLiquidacion, 
                      CASE dbo.imp_gastosxImport_x_Empresa.AfectaLiquidacion WHEN 'SI' THEN D .Valor WHEN 'NO' THEN 0 END AS Valor
FROM         dbo.imp_ordencompra_ext_x_imp_gastosxImport_det AS D INNER JOIN
                      dbo.imp_ordencompra_ext_x_imp_gastosxImport AS a ON D.IdEmpresa = a.IdEmpresa AND D.IdRegistroGasto = a.IdRegistroGasto AND 
                      D.IdSucursal = a.IdSucusal AND D.IdOrdenCompraExt = a.IdOrdenCompraExt INNER JOIN
                      dbo.imp_gastosxImport AS C ON D.IdGastoImp = C.IdGastoImp INNER JOIN
                      dbo.imp_gastosxImport_x_Empresa ON D.IdEmpresa = dbo.imp_gastosxImport_x_Empresa.IdEmpresa AND 
                      C.IdGastoImp = dbo.imp_gastosxImport_x_Empresa.IdGastoImp LEFT OUTER JOIN
                      dbo.ct_cbtecble AS E ON a.IdEmpresa = E.IdEmpresa AND a.IdTipoCbte = E.IdTipoCbte AND a.IdCbteCble = E.IdCbteCble LEFT OUTER JOIN
                      dbo.cp_proveedor AS b ON a.IdEmpresa = b.IdEmpresa AND a.IdProveedor = b.IdProveedor
WHERE     (a.Estado = 'A')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_LiquidacionImportacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 1500
         Width = 1500
         Width = 1500
         Width = 1965
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
         Column = 3060
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_LiquidacionImportacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[12] 2[29] 3) )"
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
         Begin Table = "D"
            Begin Extent = 
               Top = 5
               Left = 244
               Bottom = 64
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "a"
            Begin Extent = 
               Top = 3
               Left = 494
               Bottom = 67
               Right = 676
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 120
               Left = 474
               Bottom = 239
               Right = 634
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_gastosxImport_x_Empresa"
            Begin Extent = 
               Top = 136
               Left = 39
               Bottom = 255
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 150
               Left = 917
               Bottom = 269
               Right = 1090
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 887
               Bottom = 125
               Right = 1097
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
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_LiquidacionImportacion';

