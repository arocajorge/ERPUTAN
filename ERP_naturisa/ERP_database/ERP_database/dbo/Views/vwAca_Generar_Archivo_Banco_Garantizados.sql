CREATE VIEW dbo.vwAca_Generar_Archivo_Banco_Garantizados
AS
SELECT dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion, dbo.Aca_Contrato_x_Estudiante.IdAnioLectivo, dbo.Aca_Contrato_x_Estudiante_det.IdContrato, dbo.Aca_Contrato_x_Estudiante.IdMatricula, 
                  dbo.Aca_Contrato_x_Estudiante.IdEstudiante, dbo.Aca_estudiante.cod_estudiante2 AS codigo_unico_estudiante, dbo.Aca_Contrato_x_Estudiante_det.IdRubro, dbo.Aca_Rubro.Descripcion_rubro, 
                  dbo.Aca_Rubro.IdProducto_inv, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion, imp.nom_impuesto AS impuesto, imp.porcentaje AS iva_porcentaje, dbo.Aca_Rubro_Grupo_FE.IdGrupoFE, 
                  dbo.Aca_Rubro_Grupo_FE.nom_GrupoFe AS concepto_estado_cuenta, 1 AS vt_cantidad, SUM(Rubro_x_Periodo.Valor) AS vt_Precio, 0 AS vt_PorDescUnitario, 0 AS vt_DescUnitario, SUM(Rubro_x_Periodo.Valor) 
                  AS vt_PrecioFinal, SUM(Rubro_x_Periodo.Valor) AS vt_Subtotal, SUM(Rubro_x_Periodo.Valor * imp.porcentaje / 100) AS vt_iva_valor, SUM(Rubro_x_Periodo.Valor) AS vt_total, 'IVA' AS IdCod_Impuesto_Iva, 
                  dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat, dbo.Aca_Familiar_x_Estudiante.activo, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto, 
                  dbo.tb_persona.IdTipoPersona, dbo.tb_persona.IdTipoDocumento, dbo.Aca_Paralelo.IdParalelo, dbo.Aca_curso.IdCurso, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_Sede.IdSede, 
                  dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_Jornada.Descripcion_Jor, dbo.Aca_Familiar_x_Estudiante.IdFamiliar, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdDocumento_Bancario, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Numero_Documento, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdBanco, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tipo_meca_pago, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tb_banco_x_mgbanco, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.idProceso_Bancario_Tipo, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Tipo_documento_cat, dbo.Aca_Contrato_x_Estudiante.estado_contrato_pago_garantizado
FROM     dbo.Aca_Familiar_x_Estudiante INNER JOIN
                  dbo.Aca_estudiante ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.Aca_Familiar_x_Estudiante.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.Aca_Familiar ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                  dbo.tb_persona ON dbo.Aca_Familiar.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.Aca_matricula ON dbo.Aca_estudiante.IdEstudiante = dbo.Aca_matricula.IdEstudiante AND dbo.Aca_estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante_det INNER JOIN
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS Rubro_x_Periodo ON dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = Rubro_x_Periodo.IdInstitucion_rub AND 
                  dbo.Aca_Contrato_x_Estudiante_det.IdRubro = Rubro_x_Periodo.IdRubro AND dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per = Rubro_x_Periodo.IdInstitucion_per AND 
                  dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per = Rubro_x_Periodo.IdAnioLectivo AND dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per = Rubro_x_Periodo.IdPeriodo INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante ON dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND 
                  dbo.Aca_Contrato_x_Estudiante_det.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
                  dbo.Aca_Rubro ON Rubro_x_Periodo.IdInstitucion_rub = dbo.Aca_Rubro.IdInstitucion AND Rubro_x_Periodo.IdRubro = dbo.Aca_Rubro.IdRubro INNER JOIN
                  dbo.Aca_Rubro_Grupo_FE ON dbo.Aca_Rubro.IdGrupoFE = dbo.Aca_Rubro_Grupo_FE.IdGrupoFE AND dbo.Aca_Rubro.IdInstitucion = dbo.Aca_Rubro_Grupo_FE.IdInstitucion ON 
                  dbo.Aca_matricula.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND dbo.Aca_matricula.IdSede = dbo.Aca_Contrato_x_Estudiante.IdSede AND 
                  dbo.Aca_matricula.IdMatricula = dbo.Aca_Contrato_x_Estudiante.IdMatricula INNER JOIN
                  dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                  dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                  dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                  dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                  dbo.in_Producto ON dbo.Aca_Rubro.IdEmpresa_inv = dbo.in_Producto.IdEmpresa AND dbo.Aca_Rubro.IdProducto_inv = dbo.in_Producto.IdProducto INNER JOIN
                  dbo.tb_sis_Impuesto AS imp ON dbo.in_Producto.IdCod_Impuesto_Iva = imp.IdCod_Impuesto INNER JOIN
                  dbo.Aca_Sede ON dbo.Aca_Jornada.IdSede = dbo.Aca_Sede.IdSede LEFT OUTER JOIN
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdInstitucion AND 
                  dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdFamiliar AND 
                  dbo.Aca_Familiar_x_Estudiante.IdEstudiante = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdEstudiante AND 
                  dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdParentesco_cat
GROUP BY dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion, dbo.Aca_Contrato_x_Estudiante_det.IdContrato, dbo.Aca_Contrato_x_Estudiante_det.IdRubro, dbo.Aca_Contrato_x_Estudiante.IdEstudiante, 
                  dbo.Aca_Contrato_x_Estudiante.IdAnioLectivo, dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_Rubro_Grupo_FE.nom_GrupoFe, dbo.Aca_Rubro.IdProducto_inv, 
                  dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.IdTipoPersona, 
                  dbo.tb_persona.IdTipoDocumento, dbo.Aca_Familiar_x_Estudiante.activo, dbo.Aca_Paralelo.IdParalelo, dbo.Aca_curso.IdCurso, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, 
                  dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_Jornada.Descripcion_Jor, dbo.Aca_Familiar_x_Estudiante.IdFamiliar, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdDocumento_Bancario, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Numero_Documento, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdBanco, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tipo_meca_pago, 
                  dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tb_banco_x_mgbanco, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.idProceso_Bancario_Tipo, dbo.in_Producto.IdProducto, 
                  dbo.in_Producto.pr_descripcion, imp.nom_impuesto, imp.porcentaje, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Tipo_documento_cat, dbo.Aca_Contrato_x_Estudiante.estado_contrato_pago_garantizado, 
                  dbo.Aca_Sede.IdSede, dbo.Aca_Rubro.Descripcion_rubro, dbo.Aca_Rubro_Grupo_FE.IdGrupoFE, dbo.Aca_estudiante.cod_estudiante2
HAVING (dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = 'REP_ECO')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Generar_Archivo_Banco_Garantizados';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N'0
         Width = 1200
         Width = 1200
         Width = 1764
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2508
         Width = 1848
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1524
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1908
         Alias = 1920
         Table = 3048
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Generar_Archivo_Banco_Garantizados';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'41
               Right = 1427
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 0
               Left = 359
               Bottom = 360
               Right = 704
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Aca_Rubro"
            Begin Extent = 
               Top = 0
               Left = 1817
               Bottom = 322
               Right = 2077
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro_Grupo_FE"
            Begin Extent = 
               Top = 0
               Left = 2230
               Bottom = 342
               Right = 2493
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 519
               Left = 339
               Bottom = 707
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 624
               Left = 0
               Bottom = 787
               Right = 260
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 708
               Left = 329
               Bottom = 871
               Right = 589
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri"
            Begin Extent = 
               Top = 710
               Left = 1488
               Bottom = 1106
               Right = 1764
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 351
               Left = 2203
               Bottom = 722
               Right = 2494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp"
            Begin Extent = 
               Top = 193
               Left = 2668
               Bottom = 570
               Right = 2928
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 766
               Left = 593
               Bottom = 929
               Right = 853
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 803
               Left = 0
               Bottom = 966
               Right = 260
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
      Begin ColumnWidths = 49
         Width = 284
         Width = 1392
         Width = 1380
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1740
         Width = 1224
         Width = 2112
         Width = 1200
         Width = 1200
         Width = 2340
         Width = 3780
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 120', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Generar_Archivo_Banco_Garantizados';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[32] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[39] 4[38] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[52] 2[18] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
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
         Configuration = "(H (4[60] 2) )"
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
         Top = -600
         Left = -303
      End
      Begin Tables = 
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 594
               Left = 916
               Bottom = 968
               Right = 1243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 382
               Left = 620
               Bottom = 775
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 380
               Left = 1490
               Bottom = 701
               Right = 1766
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 370
               Left = 1821
               Bottom = 708
               Right = 2111
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 344
               Left = 0
               Bottom = 603
               Right = 283
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Aca_Contrato_x_Estudiante_det"
            Begin Extent = 
               Top = 0
               Left = 774
               Bottom = 379
               Right = 1078
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Rubro_x_Periodo"
            Begin Extent = 
               Top = 0
               Left = 1167
               Bottom = 3', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Generar_Archivo_Banco_Garantizados';

