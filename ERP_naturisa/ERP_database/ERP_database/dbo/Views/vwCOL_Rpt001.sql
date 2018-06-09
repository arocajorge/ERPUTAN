CREATE VIEW dbo.vwCOL_Rpt001
AS
SELECT dbo.Aca_estudiante.IdInstitucion, dbo.Aca_Sede.IdSede, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_curso.IdCurso, dbo.Aca_Paralelo.IdParalelo, dbo.Aca_estudiante.IdEstudiante, 
                  dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_matricula.CodMatricula, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.Aca_matricula.IdAnioLectivo, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdBanco, dbo.Aca_Pre_Facturacion_det.vt_total
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
GROUP BY dbo.Aca_estudiante.IdInstitucion, dbo.Aca_estudiante.IdEstudiante, dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_matricula.CodMatricula, dbo.Aca_Contrato_x_Estudiante.IdContrato, 
                  dbo.Aca_matricula.IdAnioLectivo, dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdBanco, dbo.Aca_Pre_Facturacion_det.vt_total, 
                  dbo.Aca_Paralelo.IdParalelo, dbo.Aca_curso.IdCurso, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_Sede.IdSede
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'      Top = 0
               Left = 1255
               Bottom = 423
               Right = 1654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Pre_Facturacion_det"
            Begin Extent = 
               Top = 65
               Left = 1885
               Bottom = 464
               Right = 2213
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 395
               Left = 1037
               Bottom = 596
               Right = 1281
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 441
               Left = 1305
               Bottom = 604
               Right = 1549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 447
               Left = 1598
               Bottom = 610
               Right = 1842
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 470
               Left = 1891
               Bottom = 633
               Right = 2135
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 469
               Left = 2200
               Bottom = 632
               Right = 2444
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2100
         Width = 1200
         Width = 2076
         Width = 2028
         Width = 1836
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
         Column = 2208
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1128
         SortOrder = 1416
         GroupBy = 1356
         Filter = 1356
         Or = 1350
         Or = 1200
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[15] 4[49] 2[9] 3) )"
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
         Top = -240
         Left = -600
      End
      Begin Tables = 
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 0
               Left = 391
               Bottom = 409
               Right = 635
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 22
               Left = 689
               Bottom = 431
               Right = 956
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 10
               Left = 18
               Bottom = 286
               Right = 329
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 487
               Left = 88
               Bottom = 886
               Right = 397
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico"
            Begin Extent = 
               Top = 609
               Left = 489
               Bottom = 849
               Right = 873
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula"
            Begin Extent = 
               Top = 604
               Left = 1001
               Bottom = 872
               Right = 1251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt001';

