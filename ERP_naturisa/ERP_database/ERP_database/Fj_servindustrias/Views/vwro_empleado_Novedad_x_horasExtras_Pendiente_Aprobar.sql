CREATE VIEW Fj_servindustrias.vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar
AS
SELECT        Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpresa, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpleado, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdRegistro, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdRubro, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.es_fecha_registro, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.Num_horasExtras, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.Observacion, 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.Estado_aprobacion, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, 
                         dbo.ro_Departamento.de_descripcion, Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.pe_apellido, 
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.pe_nombre, 
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.pe_cedulaRuc, 
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.SueldoActual, 
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.Calculo_Horas_extras_Sobre, 
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.Max_num_horas_sab_dom, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina
FROM            Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.ro_rubro_tipo ON Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdRubro = dbo.ro_rubro_tipo.IdRubro AND 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE ON 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpresa = Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.IdEmpresa
                          AND 
                         Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.IdEmpleado = Fj_servindustrias.vwro_empleados_con_sueldo_actual_para_calculo_HE.IdEmpleado
                          INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
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
      Begin ColumnWidths = 10
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[75] 4[4] 2[2] 3) )"
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
         Begin Table = "ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 110
               Left = 645
               Bottom = 239
               Right = 898
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwro_empleados_con_sueldo_actual_para_calculo_HE (Fj_servindustrias)"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar';

