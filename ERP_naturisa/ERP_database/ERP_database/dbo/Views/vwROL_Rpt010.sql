
CREATE view vwROL_Rpt010 as 

SELECT        dbo.ro_marcaciones_x_empleado.IdEmpresa, dbo.ro_marcaciones_x_empleado.IdRegistro, dbo.ro_marcaciones_x_empleado.IdEmpleado, 
                         dbo.ro_marcaciones_x_empleado.IdTipoMarcaciones, dbo.ro_marcaciones_x_empleado.secuencia, dbo.ro_marcaciones_x_empleado.es_Hora, 
                         dbo.ro_marcaciones_x_empleado.es_fechaRegistro, dbo.ro_marcaciones_x_empleado.es_anio, dbo.ro_marcaciones_x_empleado.es_mes, 
                         dbo.ro_marcaciones_x_empleado.es_semana, dbo.ro_marcaciones_x_empleado.es_dia, dbo.ro_marcaciones_x_empleado.es_sdia, 
                         dbo.ro_marcaciones_x_empleado.es_idDia, dbo.ro_marcaciones_x_empleado.es_EsActualizacion, 
                         dbo.ro_marcaciones_x_empleado.IdTipoMarcaciones_Biometrico, dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, 
                         dbo.ro_Division.Descripcion AS DescripcionDivision, dbo.vwro_empleadoXdepXcargo.IdDivision, dbo.vwro_empleadoXdepXcargo.IdSucursal, 
                         dbo.vwro_empleadoXdepXcargo.Sucursal, dbo.ct_centro_costo.Centro_costo, dbo.ro_empleado_x_centro_costo.IdCentroCosto, 
                         dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado, dbo.vwro_empleadoXdepXcargo.Apellido, dbo.vwro_empleadoXdepXcargo.Nombre, 
                         dbo.vwro_empleadoXdepXcargo.IdDepartamento
FROM            dbo.ct_centro_costo INNER JOIN
                         dbo.ro_empleado_x_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ro_empleado_x_centro_costo.IdCentroCosto INNER JOIN
                         dbo.ro_marcaciones_x_empleado INNER JOIN
                         dbo.vwro_empleadoXdepXcargo ON dbo.ro_marcaciones_x_empleado.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_marcaciones_x_empleado.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado INNER JOIN
                         dbo.ro_Division ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_Division.IdEmpresa AND 
                         dbo.vwro_empleadoXdepXcargo.IdDivision = dbo.ro_Division.IdDivision ON 
                         dbo.ro_empleado_x_centro_costo.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_empleado_x_centro_costo.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt010';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'00
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
         Column = 3240
         Alias = 3555
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt010';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[21] 2[8] 3) )"
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
         Begin Table = "ro_marcaciones_x_empleado"
            Begin Extent = 
               Top = 6
               Left = 912
               Bottom = 261
               Right = 1165
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 8
               Left = 278
               Bottom = 286
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Division"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_centro_costo"
            Begin Extent = 
               Top = 125
               Left = 603
               Bottom = 287
               Right = 866
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 87
               Left = 889
               Bottom = 264
               Right = 1098
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
      Begin ColumnWidths = 28
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
         Width = 15', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt010';

