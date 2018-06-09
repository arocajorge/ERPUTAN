/*ORDER BY dbo.Aca_estudiante.IdEstudiante*/
CREATE VIEW dbo.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
AS
SELECT        prefac_det.IdInstitucion, prefac_det.IdPreFacturacion, prefac_det.Secuencia_Proce, prefac_det.secuencia, prefac_det.IdRubro, prefac_det.IdInstitucion_contra, prefac_det.IdContrato, prefac_det.IdInstitucion_Per, 
                         prefac_det.IdPeriodo_Per, prefac_det.IdGrupoFE, prefac_det.IdProducto, prefac_det.vt_cantidad, prefac_det.vt_Precio, prefac_det.vt_PorDescUnitario, prefac_det.vt_DescUnitario, prefac_det.vt_PrecioFinal, 
                         prefac_det.vt_Subtotal, prefac_det.vt_iva_valor, prefac_det.vt_total, prefac_det.IdCod_Impuesto_Iva, prefac_det.observacion_det, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto, dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_Jornada.Descripcion_Jor,
                          dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Numero_Documento, dbo.tb_persona.IdTipoPersona, dbo.tb_persona.IdTipoDocumento, 
                         dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Tipo_documento_cat, dbo.Aca_Familiar_x_Estudiante.activo, dbo.Aca_Familiar_x_Estudiante.IdEstudiante, dbo.Aca_curso.IdCurso, 
                         dbo.Aca_Paralelo.IdParalelo, dbo.Aca_Seccion.IdSeccion, dbo.Aca_Jornada.IdJornada, dbo.Aca_Sede.IdSede, dbo.Aca_Sede.Descripcion_sede, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdBanco, 
                         dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdDocumento_Bancario, prefac_det.IdAnioLectivo_Per, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tipo_meca_pago, 
                         dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Id_tb_banco_x_mgbanco, dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.idProceso_Bancario_Tipo, 
                         dbo.Aca_estudiante.cod_estudiante2 AS codigo_unico_estudiante, dbo.Aca_Familiar_x_Estudiante.IdFamiliar, dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat, fa_cobro.dc_ValorPago AS ValorPagado, 
                         ISNULL(fa_cobro.dc_ValorPago, 0) - prefac_det.vt_total AS saldos, (CASE WHEN arch_det.Secuencia IS NULL THEN 0 ELSE 1 END) AS esta_en_archivo, 
                         dbo.Aca_Rubro_Grupo_FE.nom_GrupoFe AS concepto_estado_cuenta, dbo.Aca_Contrato_x_Estudiante.estado_contrato_pago_garantizado
FROM            dbo.Aca_Familiar_x_Estudiante INNER JOIN
                         dbo.Aca_Familiar INNER JOIN
                         dbo.tb_persona ON dbo.Aca_Familiar.IdPersona = dbo.tb_persona.IdPersona ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                         dbo.Aca_Pre_Facturacion_det AS prefac_det INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante ON prefac_det.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND prefac_det.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
                         dbo.Aca_matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = dbo.Aca_matricula.IdMatricula AND 
                         dbo.Aca_Contrato_x_Estudiante.IdEstudiante = dbo.Aca_matricula.IdEstudiante INNER JOIN
                         dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                         dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                         dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                         dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                         dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri ON prefac_det.IdInstitucion = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdInstitucion AND 
                         prefac_det.IdFamiliar = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdFamiliar AND prefac_det.IdParentesco_cat = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdParentesco_cat AND 
                         prefac_det.IdEstudiante = dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.IdEstudiante INNER JOIN
                         dbo.Aca_estudiante ON dbo.Aca_matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante AND dbo.Aca_matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion INNER JOIN
                         dbo.Aca_Sede ON dbo.Aca_Jornada.IdSede = dbo.Aca_Sede.IdSede ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = prefac_det.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdEstudiante = prefac_det.IdEstudiante AND dbo.Aca_Familiar_x_Estudiante.IdFamiliar = prefac_det.IdFamiliar AND 
                         dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = prefac_det.IdParentesco_cat INNER JOIN
                         dbo.Aca_Rubro_Grupo_FE ON prefac_det.IdGrupoFE = dbo.Aca_Rubro_Grupo_FE.IdGrupoFE LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, SUM(dc_ValorPago) AS dc_ValorPago
                               FROM            dbo.cxc_cobro_det
                               WHERE        (dc_TipoDocumento = 'FACT')
                               GROUP BY IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota) AS fa_cobro ON prefac_det.IdCbteVta_fac = fa_cobro.IdCbte_vta_nota AND prefac_det.IdBodega_fac = fa_cobro.IdBodega_Cbte AND 
                         prefac_det.IdSucursal_fac = fa_cobro.IdSucursal AND prefac_det.IdEmpresa_fac = fa_cobro.IdEmpresa LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdArchivo, Secuencia, IdInstitucion_col, IdPreFacturacion_col, Secuencia_Proce_col, secuencia_col, IdEstadoRegistro_cat
                               FROM            dbo.ba_Archivo_Transferencia_Det
                               GROUP BY IdInstitucion_col, IdPreFacturacion_col, Secuencia_Proce_col, secuencia_col, IdEstadoRegistro_cat, IdEmpresa, IdArchivo, Secuencia) AS arch_det ON 
                         arch_det.secuencia_col = prefac_det.secuencia AND arch_det.Secuencia_Proce_col = prefac_det.Secuencia_Proce AND arch_det.IdPreFacturacion_col = prefac_det.IdPreFacturacion AND 
                         prefac_det.IdInstitucion = arch_det.IdInstitucion_col
WHERE        (dbo.Aca_Familiar_x_Estudiante.activo = 1) AND (dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri.Numero_Documento IS NOT NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_Generar_Archivo_Banco';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N' Width = 1500
         Width = 1200
         Width = 1200
         Width = 1350
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 5760
         Alias = 2235
         Table = 7065
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 3930
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_Generar_Archivo_Banco';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ght = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Sede"
            Begin Extent = 
               Top = 719
               Left = 291
               Bottom = 904
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "arch_det"
            Begin Extent = 
               Top = 315
               Left = 0
               Bottom = 478
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro_Grupo_FE"
            Begin Extent = 
               Top = 6
               Left = 611
               Bottom = 271
               Right = 820
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 305
               Left = 1465
               Bottom = 531
               Right = 1674
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 0
               Left = 1151
               Bottom = 269
               Right = 1370
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 0
               Left = 881
               Bottom = 260
               Right = 1141
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 276
               Left = 1169
               Bottom = 680
               Right = 1395
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 264
               Left = 754
               Bottom = 532
               Right = 1027
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "prefac_det"
            Begin Extent = 
               Top = 0
               Left = 298
               Bottom = 365
               Right = 507
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
      Begin ColumnWidths = 55
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2490
         Width = 1500
         Width = 2055
         Width = 2310
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2730
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
        ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_Generar_Archivo_Banco';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[5] 2[22] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[56] 4[25] 3) )"
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
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4[50] 3) )"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3) )"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[75] 4) )"
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
         Top = -288
         Left = -288
      End
      Begin Tables = 
         Begin Table = "fa_cobro"
            Begin Extent = 
               Top = 485
               Left = 0
               Bottom = 648
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 1458
               Bottom = 255
               Right = 1690
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 560
               Left = 864
               Bottom = 690
               Right = 1073
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 570
               Left = 585
               Bottom = 755
               Right = 794
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 571
               Left = 312
               Bottom = 701
               Right = 521
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 686
               Left = 0
               Bottom = 816
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 305
               Ri', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det_Generar_Archivo_Banco';

