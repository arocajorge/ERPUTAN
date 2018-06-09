CREATE VIEW dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso
AS
SELECT dbo.vwAca_Matricula_x_Estudiante.IdInstitucion, dbo.vwAca_Matricula_x_Estudiante.IdSede, dbo.vwAca_Matricula_x_Estudiante.IdParalelo, dbo.vwAca_Matricula_x_Estudiante.IdCurso, 
                  dbo.vwAca_Matricula_x_Estudiante.IdSeccion, dbo.vwAca_Matricula_x_Estudiante.IdJornada, dbo.vwAca_Matricula_x_Estudiante.IdMatricula, dbo.vwAca_Matricula_x_Estudiante.IdEstudiante, 
                  dbo.vwAca_Matricula_x_Estudiante.cod_estudiante, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo AS IdAnioLectivo_Rubro_x_Periodo, dbo.Aca_curso_x_Aca_Rubro.IdRubro, 
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.Valor, dbo.vwAca_Matricula_x_Estudiante.Institucion, dbo.vwAca_Matricula_x_Estudiante.Sede, dbo.vwAca_Matricula_x_Estudiante.Jornada, 
                  dbo.vwAca_Matricula_x_Estudiante.Seccion, dbo.vwAca_Matricula_x_Estudiante.Curso, dbo.vwAca_Matricula_x_Estudiante.Paralelo, dbo.vwAca_Matricula_x_Estudiante.pe_nombre, 
                  dbo.vwAca_Matricula_x_Estudiante.pe_apellido, dbo.vwAca_Matricula_x_Estudiante.pe_cedulaRuc, dbo.vwAca_Matricula_x_Estudiante.pe_direccion, dbo.vwAca_Matricula_x_Estudiante.pe_telefonoCasa, 
                  dbo.vwAca_Matricula_x_Estudiante.pe_telefonoOfic, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo AS IdPeriodo_Per, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per
FROM     dbo.vwAca_Matricula_x_Estudiante LEFT OUTER JOIN
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo INNER JOIN
                  dbo.Aca_curso_x_Aca_Rubro ON dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro = dbo.Aca_curso_x_Aca_Rubro.IdRubro ON 
                  dbo.vwAca_Matricula_x_Estudiante.IdCurso = dbo.Aca_curso_x_Aca_Rubro.IdCurso
WHERE  (dbo.Aca_curso_x_Aca_Rubro.IdRubro IS NOT NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Estudiante_Matricula_x_Rubro_x_Curso';


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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vwAca_Matricula_x_Estudiante"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro_x_Aca_Periodo_Lectivo"
            Begin Extent = 
               Top = 11
               Left = 837
               Bottom = 174
               Right = 1081
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso_x_Aca_Rubro"
            Begin Extent = 
               Top = 13
               Left = 497
               Bottom = 176
               Right = 741
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Estudiante_Matricula_x_Rubro_x_Curso';

