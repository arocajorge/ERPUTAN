CREATE VIEW Academico.vwCOL_Rpt001
AS
SELECT dbo.Aca_estudiante.IdInstitucion, dbo.Aca_Sede.IdSede, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_curso.IdCurso, dbo.Aca_Paralelo.IdParalelo, dbo.Aca_Sede.Descripcion_sede AS Sede, 
                  dbo.Aca_Jornada.Descripcion_Jor AS Jornada, dbo.Aca_Seccion.Descripcion_secc AS Seccion, dbo.Aca_curso.Descripcion_cur AS Curso, dbo.Aca_Paralelo.Descripcion_paralelo AS Paralelo, 
                  dbo.Aca_estudiante.IdEstudiante, dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_matricula.CodMatricula, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.Aca_matricula.IdAnioLectivo, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdBanco, dbo.Aca_Pre_Facturacion_det.vt_total, dbo.Aca_matricula.tiene_seguro, 
                  dbo.Aca_matricula.Cod_convivencia_doy_fe
FROM     dbo.Aca_Contrato_x_Estudiante INNER JOIN
                  dbo.Aca_estudiante INNER JOIN
                  dbo.Aca_matricula ON dbo.Aca_estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = dbo.Aca_matricula.IdEstudiante INNER JOIN
                  dbo.Aca_Familiar_x_Estudiante ON dbo.Aca_estudiante.IdInstitucion = dbo.Aca_Familiar_x_Estudiante.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = dbo.Aca_Familiar_x_Estudiante.IdEstudiante INNER JOIN
                  dbo.Aca_Familiar ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND dbo.Aca_matricula.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND 
                  dbo.Aca_matricula.IdFamiliar_repre_econ = dbo.Aca_Familiar.IdFamiliar AND dbo.Aca_matricula.IdFamiliar_repre_legal = dbo.Aca_Familiar.IdFamiliar AND 
                  dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND 
                  dbo.Aca_Contrato_x_Estudiante.IdMatricula = dbo.Aca_matricula.CodMatricula AND dbo.Aca_Contrato_x_Estudiante.IdAnioLectivo = dbo.Aca_matricula.IdAnioLectivo AND 
                  dbo.Aca_Contrato_x_Estudiante.IdEstudiante = dbo.Aca_matricula.IdEstudiante INNER JOIN
                  dbo.Aca_Pre_Facturacion_det ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_Pre_Facturacion_det.IdInstitucion AND 
                  dbo.Aca_Contrato_x_Estudiante.IdContrato = dbo.Aca_Pre_Facturacion_det.IdContrato AND dbo.Aca_estudiante.IdInstitucion = dbo.Aca_Pre_Facturacion_det.IdInstitucion AND 
                  dbo.Aca_estudiante.IdEstudiante = dbo.Aca_Pre_Facturacion_det.IdEstudiante INNER JOIN
                  dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                  dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                  dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                  dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                  dbo.Aca_Sede ON dbo.Aca_Jornada.IdSede = dbo.Aca_Sede.IdSede LEFT OUTER JOIN
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula INNER JOIN
                  dbo.Aca_Documento_Bancario_x_Rep_Economico ON dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdDocumento_Bancario = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdDocumento_Bancario ON 
                  dbo.Aca_Familiar.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion AND dbo.Aca_Familiar.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar
WHERE  (dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = 'REP_ECO') AND (dbo.Aca_Familiar_x_Estudiante.activo = 1)
GROUP BY dbo.Aca_estudiante.IdInstitucion, dbo.Aca_Sede.IdSede, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_curso.IdCurso, dbo.Aca_Paralelo.IdParalelo, dbo.Aca_Sede.Descripcion_sede, 
                  dbo.Aca_Jornada.Descripcion_Jor, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_curso.Descripcion_cur, dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_estudiante.IdEstudiante, 
                  dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_matricula.CodMatricula, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.Aca_matricula.IdAnioLectivo, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdBanco, dbo.Aca_Pre_Facturacion_det.vt_total, dbo.Aca_matricula.tiene_seguro, 
                  dbo.Aca_matricula.Cod_convivencia_doy_fe
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
               Right = 1315
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 343
               Left = 356
               Bottom = 506
               Right = 616
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 343
               Left = 664
               Bottom = 506
               Right = 924
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 343
               Left = 972
               Bottom = 506
               Right = 1232
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 314
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico"
            Begin Extent = 
               Top = 511
               Left = 362
               Bottom = 674
               Right = 628
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
      Begin ColumnWidths = 22
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1860
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1356
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[16] 2[12] 3) )"
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
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 393
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 7
               Left = 441
               Bottom = 170
               Right = 701
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 7
               Left = 749
               Bottom = 170
               Right = 1032
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 375
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 175
               Left = 423
               Bottom = 338
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Pre_Facturacion_det"
            Begin Extent = 
               Top = 175
               Left = 747
               Bottom = 338
               Right = 1007
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 175
               Left = 1055
               Bottom = 338', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';

