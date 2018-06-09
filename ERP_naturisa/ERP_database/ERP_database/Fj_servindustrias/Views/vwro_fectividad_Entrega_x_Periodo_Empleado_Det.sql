CREATE VIEW Fj_servindustrias.vwro_fectividad_Entrega_x_Periodo_Empleado_Det
AS
SELECT        Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdRuta, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEfectividad, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega_aplica, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen_aplica, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera_aplica, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Observacion, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdPeriodo, Fj_servindustrias.ro_ruta.ru_descripcion
FROM            Fj_servindustrias.ro_ruta RIGHT OUTER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina INNER JOIN
                         dbo.ro_cargo INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona ON dbo.ro_cargo.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_cargo.IdCargo = dbo.ro_empleado.IdCargo AND dbo.ro_cargo.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_cargo.IdCargo = dbo.ro_empleado.IdCargo AND dbo.ro_cargo.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_cargo.IdCargo = dbo.ro_empleado.IdCargo INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado INNER JOIN
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det ON 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdEmpresa = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdNomina_Tipo = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo AND
                          Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado.IdEfectividad = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEfectividad ON 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado ON 
                         Fj_servindustrias.ro_ruta.IdEmpresa = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa AND 
                         Fj_servindustrias.ro_ruta.IdRuta = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdRuta
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_Entrega_x_Periodo_Empleado_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'  Top = 297
               Left = 153
               Bottom = 426
               Right = 362
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_ruta (Fj_servindustrias)"
            Begin Extent = 
               Top = 103
               Left = 597
               Bottom = 297
               Right = 806
            End
            DisplayFlags = 280
            TopColumn = 1
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_Entrega_x_Periodo_Empleado_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[5] 2[5] 3) )"
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
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 18
               Bottom = 315
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 0
               Left = 257
               Bottom = 264
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_Entrega_x_Periodo_Empleado_Det (Fj_servindustrias)"
            Begin Extent = 
               Top = 11
               Left = 1037
               Bottom = 319
               Right = 1367
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_Entrega_x_Periodo_Empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 229
               Left = 582
               Bottom = 423
               Right = 911
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 6
               Left = 473
               Bottom = 164
               Right = 773
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 370
               Left = 137
               Bottom = 499
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
             ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_fectividad_Entrega_x_Periodo_Empleado_Det';

