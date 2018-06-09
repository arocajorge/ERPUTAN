CREATE VIEW Fj_servindustrias.vwro_fectividad_Entrega_x_Periodo_Empleado
AS
SELECT        Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdEmpresa, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdNomina_Tipo, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdNomina_tipo_Liq, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdPeriodo, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdEfectividad, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.Observacion, 
                         dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin
FROM            Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado INNER JOIN
                         dbo.ro_periodo ON Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdPeriodo = dbo.ro_periodo.IdPeriodo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_Entrega_x_Periodo_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[77] 4[5] 2[1] 3) )"
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
         Begin Table = "ro_fectividad_Entrega_x_Periodo_Empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 266
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_periodo"
            Begin Extent = 
               Top = 1
               Left = 362
               Bottom = 314
               Right = 571
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_Entrega_x_Periodo_Empleado';

