CREATE VIEW Academico.vwCOL_Rpt002
AS
SELECT dbo.Aca_matricula.IdInstitucion, dbo.Aca_matricula.IdSede, dbo.Aca_matricula.IdParalelo, dbo.Aca_curso.IdCurso, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_Anio_Lectivo.IdAnioLectivo, 
                  dbo.Aca_matricula.IdMatricula, dbo.Aca_estudiante.IdEstudiante, dbo.Aca_Institucion.Nombre AS Institucion, dbo.Aca_Sede.Descripcion_sede AS Sede, dbo.Aca_Jornada.Descripcion_Jor AS Jornada, 
                  dbo.Aca_Seccion.Descripcion_secc AS Seccion, dbo.Aca_curso.Descripcion_cur AS Curso, dbo.Aca_Paralelo.Descripcion_paralelo AS Paralelo, dbo.tb_persona.pe_nombre AS nombre_estudiante, 
                  dbo.tb_persona.pe_apellido AS apellido_estudiante, dbo.tb_persona.pe_cedulaRuc AS cedula_estudiante, dbo.tb_persona.pe_direccion AS direccion_estudiante, 
                  dbo.tb_persona.pe_telefonoCasa AS telefono_casa_estudiante, dbo.tb_persona.pe_telefonoOfic AS telefono_oficina_estudiante, dbo.Aca_estudiante.cod_estudiante, 
                  dbo.Aca_matricula.FechaCreacion AS FechaMatricula, dbo.Aca_estudiante.FechaCreacion AS Fecha_Ingreso_estudiante, dbo.tb_persona.pe_sexo AS sexo_estudiante, 
                  dbo.tb_persona.pe_fechaNacimiento AS fecha_nacimiento_estudiante, dbo.tb_persona.pe_correo AS correo_estudiante, dbo.Aca_curso.CodCurso, dbo.Aca_matricula.estado AS estado_matricula, 
                  pais_estudiante.Nacionalidad AS nacionalidad_estudiante, dbo.Aca_estudiante.lugar AS lugar_estudiante, dbo.Aca_estudiante.barrio AS sector, dbo.Aca_matricula.Si_estoy_deacuerdo_foto, 
                  dbo.Aca_matricula.No_estoy_deacuerdo_foto, dbo.Aca_matricula.Cod_convivencia_doy_fe, Personafamiliar.pe_nombre AS nombre_familiar, Personafamiliar.pe_apellido AS apellido_familiar, 
                  Personafamiliar.pe_cedulaRuc AS cedula_familiar, Personafamiliar.pe_direccion AS direccion_familiar, Personafamiliar.pe_telefonoCasa AS telefonoCasa_familiar, 
                  Personafamiliar.pe_telefonoOfic AS telefonoOficina_familiar, Personafamiliar.pe_celular AS celular_familiar, Personafamiliar.pe_correo AS correo_familiar, Familiar.Titulo AS profesion_familiar, 
                  Familiar.OcupacionLaboral AS ocupacion_laboral_familiar, Familiar.empresa_donde_trabaja AS empresa_familiar, Familiar.empresa_direccion AS direccion_empresa_familiar, 
                  Paisfamiliar.Nacionalidad AS nacionalidad_familiar, FamiliarEstudiante.IdParentesco_cat, FamiliarEstudiante.activo
FROM     dbo.Aca_matricula INNER JOIN
                  dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                  dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                  dbo.Aca_estudiante ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.Aca_matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                  dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                  dbo.Aca_Sede ON dbo.Aca_Jornada.IdSede = dbo.Aca_Sede.IdSede INNER JOIN
                  dbo.Aca_Institucion ON dbo.Aca_Sede.IdInstitucion = dbo.Aca_Institucion.IdInstitucion INNER JOIN
                  dbo.tb_persona ON dbo.Aca_estudiante.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.Aca_Anio_Lectivo ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_Anio_Lectivo.IdInstitucion AND dbo.Aca_matricula.IdAnioLectivo = dbo.Aca_Anio_Lectivo.IdAnioLectivo INNER JOIN
                  dbo.tb_pais AS pais_estudiante ON dbo.Aca_estudiante.IdPais_Nacionalidad = pais_estudiante.IdPais INNER JOIN
                  dbo.Aca_Familiar_x_Estudiante AS FamiliarEstudiante ON dbo.Aca_estudiante.IdInstitucion = FamiliarEstudiante.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = FamiliarEstudiante.IdEstudiante AND 
                  dbo.Aca_estudiante.IdEstudiante = FamiliarEstudiante.IdEstudiante AND dbo.Aca_estudiante.IdInstitucion = FamiliarEstudiante.IdInstitucion INNER JOIN
                  dbo.Aca_Familiar AS Familiar ON FamiliarEstudiante.IdInstitucion = Familiar.IdInstitucion AND FamiliarEstudiante.IdFamiliar = Familiar.IdFamiliar AND FamiliarEstudiante.IdInstitucion = Familiar.IdInstitucion AND 
                  FamiliarEstudiante.IdFamiliar = Familiar.IdFamiliar INNER JOIN
                  dbo.tb_persona AS Personafamiliar ON Familiar.IdPersona = Personafamiliar.IdPersona INNER JOIN
                  dbo.tb_ciudad AS Ciudadfamiliar ON Familiar.IdCiudad = Ciudadfamiliar.IdCiudad INNER JOIN
                  dbo.tb_provincia AS Provinciafamiliar ON Ciudadfamiliar.IdProvincia = Provinciafamiliar.IdProvincia INNER JOIN
                  dbo.tb_pais AS Paisfamiliar ON Provinciafamiliar.IdPais = Paisfamiliar.IdPais
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N' Width = 2544
         Width = 2688
         Width = 2460
         Width = 2976
         Width = 2316
         Width = 2496
         Width = 2388
         Width = 2520
         Width = 2328
         Width = 2556
         Width = 2508
         Width = 2376
         Width = 2424
         Width = 1776
         Width = 2256
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2004
         Alias = 4476
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
', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Institucion"
            Begin Extent = 
               Top = 0
               Left = 45
               Bottom = 315
               Right = 290
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 220
               Left = 1374
               Bottom = 581
               Right = 1648
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Aca_Anio_Lectivo"
            Begin Extent = 
               Top = 366
               Left = 43
               Bottom = 529
               Right = 287
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pais_estudiante"
            Begin Extent = 
               Top = 309
               Left = 899
               Bottom = 511
               Right = 1143
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Familiar"
            Begin Extent = 
               Top = 756
               Left = 320
               Bottom = 1182
               Right = 580
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FamiliarEstudiante"
            Begin Extent = 
               Top = 755
               Left = 646
               Bottom = 1103
               Right = 957
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ciudadfamiliar"
            Begin Extent = 
               Top = 1121
               Left = 671
               Bottom = 1481
               Right = 915
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Provinciafamiliar"
            Begin Extent = 
               Top = 1198
               Left = 321
               Bottom = 1446
               Right = 565
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personafamiliar"
            Begin Extent = 
               Top = 1087
               Left = 1437
               Bottom = 1368
               Right = 1711
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Paisfamiliar"
            Begin Extent = 
               Top = 1087
               Left = 48
               Bottom = 1250
               Right = 292
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
      Begin ColumnWidths = 52
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1596
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1440
         Width = 2340
        ', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt002';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[10] 2[27] 3) )"
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
         Top = -720
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 345
               Left = 415
               Bottom = 743
               Right = 677
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 0
               Left = 911
               Bottom = 254
               Right = 1155
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 170
               Left = 597
               Bottom = 333
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 772
               Left = 1144
               Bottom = 1292
               Right = 1389
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 170
               Left = 322
               Bottom = 333
               Right = 566
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 0
               Left = 589
               Bottom = 163
               Right = 833
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 6
               Left = 325
               Bottom = 169
               Right = 569
           ', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwCOL_Rpt002';

