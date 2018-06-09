CREATE VIEW [dbo].[vwct_Plancta_UltimoNivel]
AS
SELECT     dbo.ct_plancta.IdEmpresa, dbo.ct_plancta.IdCtaCble, dbo.pre_presupuesto.IdPresupuesto, dbo.pre_presupuesto.IdAnio, dbo.pre_presupuesto.Secuencia, 
                      dbo.pre_presupuesto.CodigoPresupuesto, dbo.pre_presupuesto.IdCentroCosto, dbo.pre_presupuesto.IdTipoRubro, dbo.pre_presupuesto.CodRubro, 
                      dbo.pre_presupuesto.NombreRubro, dbo.pre_presupuesto.Enero, dbo.pre_presupuesto.febrero, dbo.pre_presupuesto.Marzo, dbo.pre_presupuesto.Abril, 
                      dbo.pre_presupuesto.Mayo, dbo.pre_presupuesto.Junio, dbo.pre_presupuesto.Julio, dbo.pre_presupuesto.Agosto, dbo.pre_presupuesto.Septiembre, 
                      dbo.pre_presupuesto.Octubre, dbo.pre_presupuesto.Noviembre, dbo.pre_presupuesto.Diciembre, dbo.pre_presupuesto.Total, dbo.ct_plancta.pc_Cuenta
FROM         dbo.ct_plancta LEFT OUTER JOIN
                      dbo.pre_presupuesto ON dbo.ct_plancta.IdEmpresa = dbo.pre_presupuesto.IdEmpresa AND dbo.ct_plancta.IdCtaCble = dbo.pre_presupuesto.IdCtaCble
WHERE     (dbo.ct_plancta.IdNivelCta =
                          (SELECT     COUNT(*) AS Expr1
                            FROM          dbo.ct_plancta_nivel
                            WHERE      (Estado = 'A') AND (dbo.ct_plancta.IdEmpresa = IdEmpresa)))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwct_Plancta_UltimoNivel';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[18] 4[24] 2[24] 3) )"
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
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "pre_presupuesto"
            Begin Extent = 
               Top = 6
               Left = 265
               Bottom = 125
               Right = 447
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
      Begin ColumnWidths = 24
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwct_Plancta_UltimoNivel';

