CREATE VIEW [dbo].[vwRo_HorasExtrasXEmpleado]
AS
SELECT        dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdEmpleado, dbo.ro_nomina_x_horas_extras.IdNominaTipo, 
                         dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, dbo.ro_nomina_x_horas_extras.IdPeriodo, dbo.ro_nomina_x_horas_extras.IdCalendario, 
                         dbo.ro_nomina_x_horas_extras.IdTurno, dbo.ro_nomina_x_horas_extras.IdHorario, dbo.ro_nomina_x_horas_extras.FechaRegistro, 
                         dbo.ro_nomina_x_horas_extras.time_entrada1, dbo.ro_nomina_x_horas_extras.time_entrada2, dbo.ro_nomina_x_horas_extras.time_salida1, 
                         dbo.ro_nomina_x_horas_extras.time_salida2, dbo.ro_nomina_x_horas_extras.hora_extra25, dbo.ro_nomina_x_horas_extras.hora_extra50, 
                         dbo.ro_nomina_x_horas_extras.hora_extra100, dbo.ro_nomina_x_horas_extras.hora_atraso, dbo.ro_nomina_x_horas_extras.hora_temprano, 
                         dbo.ro_nomina_x_horas_extras.hora_trabajada, dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, dbo.vwro_empleadoXdepXcargo.IdDivision, dbo.vwro_empleadoXdepXcargo.Apellido, 
                         dbo.vwro_empleadoXdepXcargo.Nombre, dbo.vwro_empleadoXdepXcargo.Sucursal, dbo.vwro_empleadoXdepXcargo.IdSucursal, 
                         dbo.ro_horario.Descripcion AS DescripcionHorario, dbo.ro_nomina_x_horas_extras.es_HorasExtrasAutorizadas
FROM            dbo.vwro_empleadoXdepXcargo INNER JOIN
                         dbo.ro_nomina_x_horas_extras ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_nomina_x_horas_extras.IdEmpresa AND 
                         dbo.vwro_empleadoXdepXcargo.IdEmpleado = dbo.ro_nomina_x_horas_extras.IdEmpleado INNER JOIN
                         dbo.ro_horario ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_horario.IdEmpresa AND dbo.ro_nomina_x_horas_extras.IdHorario = dbo.ro_horario.IdHorario
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_HorasExtrasXEmpleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'olumn = 2340
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_HorasExtrasXEmpleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[36] 2[4] 3) )"
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
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 7
               Left = 74
               Bottom = 274
               Right = 363
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_nomina_x_horas_extras"
            Begin Extent = 
               Top = 10
               Left = 361
               Bottom = 281
               Right = 570
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "ro_horario"
            Begin Extent = 
               Top = 31
               Left = 638
               Bottom = 234
               Right = 847
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 32
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
         C', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_HorasExtrasXEmpleado';

