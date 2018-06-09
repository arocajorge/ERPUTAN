CREATE view vwROL_Rpt004 as 
SELECT        dbo.tb_persona.pe_cedulaRuc AS CedulaRuc, dbo.tb_persona.pe_nombreCompleto AS NombreCompleto, dbo.ro_empleado_novedad_det.IdRubro, 
                         dbo.ro_empleado_novedad_det.FechaPago, dbo.ro_empleado_novedad_det.Valor, dbo.ro_empleado_novedad_det.EstadoCobro, 
                         dbo.ro_rubro_tipo.ru_descripcion AS RubroDescripcion, dbo.ro_Division.Descripcion AS Division, dbo.ct_centro_costo.Centro_costo AS CentroCosto, 
                         dbo.ro_Departamento.de_descripcion AS Departamento, dbo.ro_empleado_Novedad.IdEmpresa, dbo.ro_empleado_Novedad.IdEmpleado, 
                         dbo.ro_empleado.IdDivision, dbo.ro_empleado_x_centro_costo.IdCentroCosto, dbo.ro_empleado.em_codigo AS CodigoEmpleado, 
                         dbo.ro_Departamento.IdDepartamento, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_empleado_novedad_det.Num_Horas
FROM            dbo.ro_empleado_novedad_det INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_empleado_novedad_det.IdRubro = dbo.ro_rubro_tipo.IdRubro AND 
                         dbo.ro_empleado_novedad_det.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa INNER JOIN
                         dbo.ro_empleado ON dbo.ro_empleado_novedad_det.IdEmpresa = dbo.ro_empleado.IdEmpresa INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_Novedad ON dbo.ro_empleado_novedad_det.IdEmpresa = dbo.ro_empleado_Novedad.IdEmpresa AND 
                         dbo.ro_empleado_novedad_det.IdNovedad = dbo.ro_empleado_Novedad.IdNovedad AND 
                         dbo.ro_empleado_novedad_det.IdEmpleado = dbo.ro_empleado_Novedad.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_Novedad.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_Novedad.IdEmpleado INNER JOIN
                         dbo.ro_Division ON dbo.ro_empleado.IdDivision = dbo.ro_Division.IdDivision AND dbo.ro_empleado.IdEmpresa = dbo.ro_Division.IdEmpresa INNER JOIN
                         dbo.ro_empleado_x_centro_costo ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado INNER JOIN
                         dbo.ct_centro_costo ON dbo.ro_empleado_x_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.ro_empleado_x_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt004';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'    Right = 615
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 222
               Left = 864
               Bottom = 376
               Right = 1073
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 233
               Left = 29
               Bottom = 362
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2145
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
         Column = 1830
         Alias = 1785
         Table = 2310
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt004';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[62] 4[14] 2[6] 3) )"
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
         Begin Table = "ro_empleado_novedad_det"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 228
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 171
               Left = 249
               Bottom = 334
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 0
               Left = 645
               Bottom = 252
               Right = 908
            End
            DisplayFlags = 280
            TopColumn = 37
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 1097
               Bottom = 223
               Right = 1306
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ro_empleado_Novedad"
            Begin Extent = 
               Top = 12
               Left = 361
               Bottom = 159
               Right = 570
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Division"
            Begin Extent = 
               Top = 98
               Left = 973
               Bottom = 227
               Right = 1182
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_centro_costo"
            Begin Extent = 
               Top = 191
               Left = 352
               Bottom = 320
           ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt004';

