CREATE view [dbo].[vwImp_GastosImportacion]
as
select a.*,b.pr_nombre from (SELECT     A.IdEmpresa, A.IdRegistroGasto, A.IdSucusal, A.IdOrdenCompraExt, A.Fecha, A.Observacion, ISNULL(A.IdProveedor, 0) AS IdProveedor, A.IdBanco, A.CodDocu_Pago,   
                      C.Su_Descripcion, A.Estado, dbo.ba_Banco_Cuenta.ba_descripcion, A.IdCbteCble, A.IdTipoCbte, A.IdCbteCble_Anu, A.IdTipoCbte_Anu,   
                      dbo.imp_ordencompra_ext.CodOrdenCompraExt, dbo.imp_ordencompra_ext.Tipo_Importacion  
FROM         dbo.imp_ordencompra_ext_x_imp_gastosxImport AS A INNER JOIN  
                      dbo.tb_sucursal AS C ON A.IdEmpresa = C.IdEmpresa AND A.IdSucusal = C.IdSucursal INNER JOIN  
                      dbo.ba_Banco_Cuenta ON A.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND A.IdBanco = dbo.ba_Banco_Cuenta.IdBanco INNER JOIN  
                      dbo.imp_ordencompra_ext ON A.IdEmpresa = dbo.imp_ordencompra_ext.IdEmpresa AND A.IdSucusal = dbo.imp_ordencompra_ext.IdSucusal AND   
                      A.IdOrdenCompraExt = dbo.imp_ordencompra_ext.IdOrdenCompraExt left  JOIN  
                      dbo.cp_proveedor ON dbo.imp_ordencompra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor AND   
                      dbo.imp_ordencompra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND A.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND   
                      A.IdProveedor = dbo.cp_proveedor.IdProveedor  ) as a 
                      inner join  cp_proveedor b on a.IdEmpresa = b.IdEmpresa and a.IdProveedor = b.IdProveedor
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_GastosImportacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'      Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_GastosImportacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[9] 2[20] 3) )"
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
         Configuration = "(H (4[30] 2[40] 3) )"
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
               Left = 370
               Bottom = 252
               Right = 552
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ba_Banco_Cuenta"
            Begin Extent = 
               Top = 2
               Left = 789
               Bottom = 121
               Right = 977
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 129
               Left = 778
               Bottom = 248
               Right = 988
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_ordencompra_ext"
            Begin Extent = 
               Top = 0
               Left = 1082
               Bottom = 119
               Right = 1293
            End
            DisplayFlags = 280
            TopColumn = 75
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 20
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
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwImp_GastosImportacion';

