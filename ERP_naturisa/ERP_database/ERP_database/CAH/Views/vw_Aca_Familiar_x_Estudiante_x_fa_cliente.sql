CREATE VIEW CAH.vw_Aca_Familiar_x_Estudiante_x_fa_cliente
AS
SELECT dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdInstitucion_fa, dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdFamiliar_fa, dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdParentesco_cat_fa, 
                  dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdCliente_cli, dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdEmpresa_cli, dbo.fa_cliente.IdEmpresa, dbo.fa_cliente.IdCliente
FROM     dbo.Aca_Familiar_x_Estudiante_x_fa_cliente INNER JOIN
                  dbo.fa_cliente ON dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND dbo.Aca_Familiar_x_Estudiante_x_fa_cliente.IdCliente_cli = dbo.fa_cliente.IdCliente
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Familiar_x_Estudiante_x_fa_cliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[6] 2[20] 3) )"
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
         Begin Table = "Aca_Familiar_x_Estudiante_x_fa_cliente"
            Begin Extent = 
               Top = 0
               Left = 36
               Bottom = 212
               Right = 403
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 0
               Left = 570
               Bottom = 359
               Right = 849
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
', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Familiar_x_Estudiante_x_fa_cliente';

