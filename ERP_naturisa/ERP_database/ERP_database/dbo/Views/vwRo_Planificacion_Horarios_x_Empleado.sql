CREATE VIEW [dbo].[vwRo_Planificacion_Horarios_x_Empleado]
AS
SELECT        dbo.VWRO_empleado.pe_nombreCompleto, dbo.tb_Calendario.NombreCortoFecha, dbo.tb_Calendario.Inicial_del_Dia, dbo.ro_horario_planificacion.IdRegistro, 
                         dbo.ro_horario.Descripcion, dbo.tb_Calendario.fecha, dbo.ro_horario_planificacion.IdHorario, dbo.ro_horario_planificacion.IdEmpleado, 
                         dbo.ro_horario_planificacion.IdEmpresa, dbo.ro_horario_planificacion.Estado, dbo.tb_sucursal.Su_Descripcion, dbo.VWRO_empleado.IdSucursal, 
                         dbo.VWRO_empleado.Departamento, dbo.ro_cargo.ca_descripcion, dbo.ro_horario_planificacion.IdCalendario
FROM            dbo.tb_Calendario INNER JOIN
                         dbo.ro_horario_planificacion ON dbo.tb_Calendario.IdCalendario = dbo.ro_horario_planificacion.IdCalendario INNER JOIN
                         dbo.ro_horario ON dbo.ro_horario_planificacion.IdEmpresa = dbo.ro_horario.IdEmpresa AND 
                         dbo.ro_horario_planificacion.IdHorario = dbo.ro_horario.IdHorario INNER JOIN
                         dbo.VWRO_empleado ON dbo.ro_horario_planificacion.IdEmpresa = dbo.VWRO_empleado.IdEmpresa AND 
                         dbo.ro_horario_planificacion.IdEmpleado = dbo.VWRO_empleado.IdEmpleado INNER JOIN
                         dbo.tb_sucursal ON dbo.ro_horario_planificacion.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.VWRO_empleado.IdSucursal = dbo.tb_sucursal.IdSucursal AND 
                         dbo.VWRO_empleado.IdEmpresa = dbo.tb_sucursal.IdEmpresa INNER JOIN
                         dbo.ro_cargo ON dbo.VWRO_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.VWRO_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Planificacion_Horarios_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Planificacion_Horarios_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[66] 4[5] 2[11] 3) )"
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
         Begin Table = "tb_Calendario"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 149
               Right = 182
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_horario_planificacion"
            Begin Extent = 
               Top = 7
               Left = 275
               Bottom = 126
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_horario"
            Begin Extent = 
               Top = 143
               Left = 415
               Bottom = 399
               Right = 575
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VWRO_empleado"
            Begin Extent = 
               Top = 132
               Left = 582
               Bottom = 480
               Right = 794
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 74
               Left = 931
               Bottom = 297
               Right = 1145
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 171
               Left = 53
               Bottom = 300
               Right = 262
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
      Begin ColumnWidths = 12
         Width = 284
         Width ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Planificacion_Horarios_x_Empleado';

