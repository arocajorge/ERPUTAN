CREATE VIEW dbo.vwAca_Matricula_x_Estudiante
AS
SELECT dbo.Aca_matricula.IdInstitucion, dbo.Aca_matricula.IdSede, dbo.Aca_matricula.IdParalelo, dbo.Aca_curso.IdCurso, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_Anio_Lectivo.IdAnioLectivo, 
                  dbo.Aca_matricula.IdMatricula, dbo.Aca_estudiante.IdEstudiante, dbo.Aca_Institucion.Nombre AS Institucion, dbo.Aca_Sede.Descripcion_sede AS Sede, dbo.Aca_Jornada.Descripcion_Jor AS Jornada, 
                  dbo.Aca_Seccion.Descripcion_secc AS Seccion, dbo.Aca_curso.Descripcion_cur AS Curso, dbo.Aca_Paralelo.Descripcion_paralelo AS Paralelo, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_apellido, 
                  dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, dbo.tb_persona.pe_telefonoCasa, dbo.tb_persona.pe_telefonoOfic, dbo.Aca_estudiante.cod_estudiante, 
                  dbo.Aca_matricula.FechaCreacion AS FechaMatricula, dbo.Aca_estudiante.FechaCreacion
FROM     dbo.Aca_matricula INNER JOIN
                  dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                  dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                  dbo.Aca_estudiante ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.Aca_matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                  dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                  dbo.Aca_Sede ON dbo.Aca_Jornada.IdSede = dbo.Aca_Sede.IdSede AND dbo.Aca_matricula.IdSede = dbo.Aca_Sede.IdSede INNER JOIN
                  dbo.Aca_Institucion ON dbo.Aca_Sede.IdInstitucion = dbo.Aca_Institucion.IdInstitucion INNER JOIN
                  dbo.tb_persona ON dbo.Aca_estudiante.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.Aca_Anio_Lectivo ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_Anio_Lectivo.IdInstitucion AND dbo.Aca_matricula.IdAnioLectivo = dbo.Aca_Anio_Lectivo.IdAnioLectivo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Matricula_x_Estudiante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Institucion"
            Begin Extent = 
               Top = 274
               Left = 2043
               Bottom = 491
               Right = 2288
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 33
               Left = 1113
               Bottom = 256
               Right = 1387
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Aca_Anio_Lectivo"
            Begin Extent = 
               Top = 21
               Left = 0
               Bottom = 388
               Right = 244
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
      Begin ColumnWidths = 25
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1392
         Width = 1200
         Width = 1200
         Width = 960
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2232
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3336
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Matricula_x_Estudiante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[9] 2[23] 3) )"
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
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 2
               Left = 287
               Bottom = 434
               Right = 611
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 284
               Left = 656
               Bottom = 529
               Right = 900
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 284
               Left = 965
               Bottom = 547
               Right = 1209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 5
               Left = 757
               Bottom = 277
               Right = 1039
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 275
               Left = 1262
               Bottom = 493
               Right = 1506
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 273
               Left = 1398
               Bottom = 436
               Right = 1642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 13
               Left = 1813
               Bottom = 229
               Right = 2057
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Matricula_x_Estudiante';

