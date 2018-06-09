/*select * from vwro_Ing_Egre_x_Empleado where IdEmpleado=1*/
CREATE VIEW [dbo].[vwRo_Total_IngEgr_x_Empleado]
AS
SELECT     ing.IdEmpresa, ing.IdEmpleado, ing.IdNomina_Tipo, ing.IdNomina_TipoLiqui, ing.IdPeriodo, ing.totIng, egr.totEgr, ing.totIng + egr.totEgr AS totNeto, 
                      dbo.vwro_empleadoXdepXcargo.NomCompleto, dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, 
                      dbo.vwro_empleadoXdepXcargo.em_codigo, dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc
FROM         (SELECT     IdEmpresa, IdEmpleado, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo, SUM(Valor) AS totIng
                       FROM          dbo.ro_Ing_Egre_x_Empleado
                       WHERE      (Unid_Medida = '$$$') AND (IngEgr = 'I')
                       GROUP BY IdEmpresa, IdEmpleado, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo) AS ing INNER JOIN
                          (SELECT     IdEmpresa, IdEmpleado, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo, SUM(Valor) AS totEgr
                            FROM          dbo.ro_Ing_Egre_x_Empleado AS ro_Ing_Egre_x_Empleado_1
                            WHERE      (Unid_Medida = '$$$') AND (IngEgr = 'E')
                            GROUP BY IdEmpresa, IdEmpleado, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo) AS egr ON ing.IdEmpleado = egr.IdEmpleado AND 
                      ing.IdEmpresa = egr.IdEmpresa AND ing.IdNomina_Tipo = egr.IdNomina_Tipo AND ing.IdNomina_TipoLiqui = egr.IdNomina_TipoLiqui AND 
                      ing.IdPeriodo = egr.IdPeriodo INNER JOIN
                      dbo.vwro_empleadoXdepXcargo ON ing.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND ing.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Total_IngEgr_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[16] 2[7] 3) )"
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
         Begin Table = "ing"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 195
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "egr"
            Begin Extent = 
               Top = 195
               Left = 391
               Bottom = 359
               Right = 572
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 0
               Left = 733
               Bottom = 304
               Right = 985
            End
            DisplayFlags = 280
            TopColumn = 30
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Total_IngEgr_x_Empleado';

