
CREATE VIEW [dbo].[vwROL_Rpt009]
AS
SELECT        dbo.ro_salario_digno.IdEmpresa, dbo.ro_salario_digno.IdNominaTipo, dbo.ro_salario_digno.IdPeriodo, dbo.ro_salario_digno.SueldoDigno, 
                         dbo.ro_salario_digno.Observacion, dbo.ro_salario_digno.UtilidadRepartir, dbo.ro_salario_digno_empleado.IdEmpleado, dbo.ro_salario_digno_empleado.Valor, 
                         dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.IdDivision, dbo.vwro_empleadoXdepXcargo.pe_estado AS EstadoEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado
FROM            dbo.ro_salario_digno_empleado INNER JOIN
                         dbo.ro_salario_digno ON dbo.ro_salario_digno_empleado.IdEmpresa = dbo.ro_salario_digno.IdEmpresa AND 
                         dbo.ro_salario_digno_empleado.IdNominaTipo = dbo.ro_salario_digno.IdNominaTipo AND 
                         dbo.ro_salario_digno_empleado.IdPeriodo = dbo.ro_salario_digno.IdPeriodo INNER JOIN
                         dbo.vwro_empleadoXdepXcargo ON dbo.ro_salario_digno_empleado.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_salario_digno_empleado.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt009';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[59] 4[16] 2[7] 3) )"
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
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 248
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 52
         End
         Begin Table = "ro_salario_digno"
            Begin Extent = 
               Top = 5
               Left = 878
               Bottom = 255
               Right = 1087
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_salario_digno_empleado"
            Begin Extent = 
               Top = 27
               Left = 498
               Bottom = 264
               Right = 707
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
      Begin ColumnWidths = 16
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2220
         Alias = 3195
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt009';

