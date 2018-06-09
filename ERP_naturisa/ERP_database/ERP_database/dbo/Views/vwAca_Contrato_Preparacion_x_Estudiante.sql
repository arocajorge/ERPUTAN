CREATE VIEW dbo.vwAca_Contrato_Preparacion_x_Estudiante
AS
SELECT        dbo.vwAca_Matricula_x_Estudiante.IdInstitucion, dbo.vwAca_Matricula_x_Estudiante.IdSede, dbo.vwAca_Matricula_x_Estudiante.IdParalelo, dbo.vwAca_Matricula_x_Estudiante.IdCurso, 
                         dbo.vwAca_Matricula_x_Estudiante.IdSeccion, dbo.vwAca_Matricula_x_Estudiante.IdJornada, dbo.vwAca_Matricula_x_Estudiante.cod_estudiante, dbo.vwAca_Matricula_x_Estudiante.IdAnioLectivo, 
                         dbo.vwAca_Matricula_x_Estudiante.IdMatricula, dbo.vwAca_Matricula_x_Estudiante.IdEstudiante, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.vwAca_Matricula_x_Estudiante.Institucion, 
                         dbo.vwAca_Matricula_x_Estudiante.Sede, dbo.vwAca_Matricula_x_Estudiante.Jornada, dbo.vwAca_Matricula_x_Estudiante.Seccion, dbo.vwAca_Matricula_x_Estudiante.Curso, 
                         dbo.vwAca_Matricula_x_Estudiante.Paralelo, dbo.vwAca_Matricula_x_Estudiante.pe_nombre, dbo.vwAca_Matricula_x_Estudiante.pe_apellido, dbo.vwAca_Matricula_x_Estudiante.pe_cedulaRuc, 
                         dbo.vwAca_Matricula_x_Estudiante.pe_direccion, dbo.vwAca_Matricula_x_Estudiante.pe_telefonoCasa, dbo.vwAca_Matricula_x_Estudiante.pe_telefonoOfic, 
                         dbo.Aca_estudiante.FechaCreacion AS FechaCreacionEstudiante, dbo.vwAca_Matricula_x_Estudiante.FechaMatricula, dbo.Aca_Contrato_x_Estudiante.estado_contrato_pago_garantizado, 
                         dbo.Aca_Contrato_x_Estudiante.estado
FROM            dbo.vwAca_Matricula_x_Estudiante INNER JOIN
                         dbo.Aca_estudiante ON dbo.vwAca_Matricula_x_Estudiante.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.vwAca_Matricula_x_Estudiante.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante ON dbo.vwAca_Matricula_x_Estudiante.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND 
                         dbo.vwAca_Matricula_x_Estudiante.IdMatricula = dbo.Aca_Contrato_x_Estudiante.IdMatricula
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_Preparacion_x_Estudiante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Begin ColumnWidths = 11
         Column = 2130
         Alias = 2685
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_Preparacion_x_Estudiante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Top = -96
         Left = -400
      End
      Begin Tables = 
         Begin Table = "vwAca_Matricula_x_Estudiante"
            Begin Extent = 
               Top = 0
               Left = 390
               Bottom = 266
               Right = 759
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 9
               Left = 9
               Bottom = 309
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 0
               Left = 855
               Bottom = 244
               Right = 1184
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 33
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1650
         Width = 1920
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_Preparacion_x_Estudiante';

