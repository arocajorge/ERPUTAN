CREATE VIEW [dbo].[vwRo_DiasFaltados_x_Empleado]
AS
SELECT        dbo.ro_DiasFaltados_x_Empleado.IdFalta, dbo.ro_DiasFaltados_x_Empleado.IdEmpresa, dbo.ro_DiasFaltados_x_Empleado.IdEmpleado, 
                         dbo.ro_DiasFaltados_x_Empleado.FechaFaltaDesde, dbo.ro_DiasFaltados_x_Empleado.FechaFaltaHasta, dbo.ro_DiasFaltados_x_Empleado.DiasFaltados, 
                         dbo.ro_DiasFaltados_x_Empleado.DiasDescuento, dbo.ro_DiasFaltados_x_Empleado.FechaDescuentaRol, dbo.ro_DiasFaltados_x_Empleado.ValorDescuentaRol, 
                         dbo.ro_DiasFaltados_x_Empleado.Observacion, dbo.ro_DiasFaltados_x_Empleado.CatalogoDescripcion, dbo.ro_DiasFaltados_x_Empleado.estado, 
                         dbo.ro_DiasFaltados_x_Empleado.IdUsuario, dbo.ro_DiasFaltados_x_Empleado.Fecha_Transac, dbo.ro_DiasFaltados_x_Empleado.IdUsuarioUltMod, 
                         dbo.ro_DiasFaltados_x_Empleado.Fecha_UltMod, dbo.ro_DiasFaltados_x_Empleado.IdUsuarioUltAnu, dbo.ro_DiasFaltados_x_Empleado.Fecha_UltAnu, 
                         dbo.ro_DiasFaltados_x_Empleado.nom_pc, dbo.ro_DiasFaltados_x_Empleado.ip, dbo.ro_DiasFaltados_x_Empleado.MotiAnula, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_empleado.em_codigo, dbo.ro_DiasFaltados_x_Empleado.IdNovedad, 
                         dbo.ro_DiasFaltados_x_Empleado.IdNominaTipo, dbo.ro_DiasFaltados_x_Empleado.IdNominaTipoLiq, dbo.ro_DiasFaltados_x_Empleado.CodCatalogo
FROM            dbo.ro_DiasFaltados_x_Empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_DiasFaltados_x_Empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_DiasFaltados_x_Empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_DiasFaltados_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_DiasFaltados_x_Empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[4] 2[8] 3) )"
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
         Begin Table = "ro_DiasFaltados_x_Empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 343
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 2
               Left = 271
               Bottom = 350
               Right = 560
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 6
               Left = 612
               Bottom = 315
               Right = 822
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
      Begin ColumnWidths = 27
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_DiasFaltados_x_Empleado';

