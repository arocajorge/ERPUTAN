CREATE VIEW Fj_servindustrias.vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla
AS
SELECT        Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado, Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, Fj_servindustrias.ro_placa.Placa, Fj_servindustrias.ro_zona.zo_descripcion, Fj_servindustrias.ro_disco.Disco, 
                         Fj_servindustrias.ro_ruta.ru_descripcion, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, Fj_servindustrias.ro_ruta.IdRuta, 
                         Fj_servindustrias.ro_fuerza.IdFuerza, Fj_servindustrias.ro_zona.IdZona, Fj_servindustrias.ro_disco.IdDisco, Fj_servindustrias.ro_placa.IdPlaca
FROM            Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_placa ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona INNER JOIN
                         Fj_servindustrias.ro_disco ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco INNER JOIN
                         Fj_servindustrias.ro_ruta ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta INNER JOIN
                         dbo.ro_periodo ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo = dbo.ro_periodo.IdPeriodo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'              Top = 137
               Left = 245
               Bottom = 435
               Right = 454
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[84] 4[5] 2[5] 3) )"
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
         Top = -36
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ro_planificacion_x_ruta_x_empleado_det (Fj_servindustrias)"
            Begin Extent = 
               Top = 3
               Left = 9
               Bottom = 376
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fuerza (Fj_servindustrias)"
            Begin Extent = 
               Top = 3
               Left = 336
               Bottom = 132
               Right = 545
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_placa (Fj_servindustrias)"
            Begin Extent = 
               Top = 114
               Left = 325
               Bottom = 243
               Right = 534
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_zona (Fj_servindustrias)"
            Begin Extent = 
               Top = 222
               Left = 332
               Bottom = 351
               Right = 541
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_disco (Fj_servindustrias)"
            Begin Extent = 
               Top = 240
               Left = 554
               Bottom = 382
               Right = 763
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_ruta (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 583
               Bottom = 135
               Right = 792
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_periodo"
            Begin Extent = 
 ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla';

