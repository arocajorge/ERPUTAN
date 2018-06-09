
CREATE view [Academico].[vwACA_fa_factura_aca_Det] as 
SELECT        Academico.fa_factura_aca.IdEmpresa, Academico.fa_factura_aca.IdSucursal, Academico.fa_factura_aca.IdBodega, Academico.fa_factura_aca.IdCbteVta, Academico.fa_factura_aca.IdInstitucion, 
                         Academico.fa_factura_aca.IdEstudiante, Academico.fa_factura_aca.IdFamiliar, Academico.fa_factura_aca.IdParentesco_cat, dbo.fa_factura.CodCbteVta, dbo.fa_factura.vt_tipoDoc, dbo.fa_factura.vt_serie1, 
                         dbo.fa_factura.vt_serie2, dbo.fa_factura.vt_NumFactura, dbo.fa_factura.vt_Observacion, dbo.fa_factura.vt_fecha, dbo.fa_factura.vt_fech_venc,sum( fa_det.vt_cantidad)as vt_cantidad,sum( fa_det.vt_Precio) as vt_Precio,sum( fa_det.vt_PorDescUnitario) as vt_PorDescUnitario, 
                        sum( fa_det.vt_DescUnitario)as vt_DescUnitario,sum( fa_det.vt_PrecioFinal) as vt_PrecioFinal,sum( fa_det.vt_Subtotal) as vt_Subtotal,sum( fa_det.vt_iva) as vt_iva, sum(fa_det.vt_total) as vt_total, Persona_estud.pe_apellido AS Apell_Estu, Persona_estud.pe_nombre AS Nom_Estud, 
                         persona_clien.pe_apellido AS Apellido_Fam, persona_clien.pe_nombre AS Nombre_Fam, seccion.Descripcion_secc, paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, contrato.IdContrato, 
                         contrato.IdAnioLectivo
FROM            dbo.fa_cliente AS clie INNER JOIN
                         dbo.fa_factura ON clie.IdEmpresa = dbo.fa_factura.IdEmpresa AND clie.IdCliente = dbo.fa_factura.IdCliente INNER JOIN
                         dbo.fa_factura_det AS fa_det ON dbo.fa_factura.IdEmpresa = fa_det.IdEmpresa AND dbo.fa_factura.IdSucursal = fa_det.IdSucursal AND dbo.fa_factura.IdBodega = fa_det.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = fa_det.IdCbteVta AND dbo.fa_factura.IdEmpresa = fa_det.IdEmpresa AND dbo.fa_factura.IdSucursal = fa_det.IdSucursal AND dbo.fa_factura.IdBodega = fa_det.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = fa_det.IdCbteVta INNER JOIN
                         Academico.fa_factura_aca ON dbo.fa_factura.IdEmpresa = Academico.fa_factura_aca.IdEmpresa AND dbo.fa_factura.IdSucursal = Academico.fa_factura_aca.IdSucursal AND 
                         dbo.fa_factura.IdBodega = Academico.fa_factura_aca.IdBodega AND dbo.fa_factura.IdCbteVta = Academico.fa_factura_aca.IdCbteVta AND dbo.fa_factura.IdEmpresa = Academico.fa_factura_aca.IdEmpresa AND 
                         dbo.fa_factura.IdSucursal = Academico.fa_factura_aca.IdSucursal AND dbo.fa_factura.IdBodega = Academico.fa_factura_aca.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = Academico.fa_factura_aca.IdCbteVta INNER JOIN
                         dbo.Aca_estudiante AS estudiante ON Academico.fa_factura_aca.IdInstitucion = estudiante.IdInstitucion AND Academico.fa_factura_aca.IdEstudiante = estudiante.IdEstudiante AND 
                         Academico.fa_factura_aca.IdInstitucion = estudiante.IdInstitucion AND Academico.fa_factura_aca.IdEstudiante = estudiante.IdEstudiante AND Academico.fa_factura_aca.IdInstitucion = estudiante.IdInstitucion AND 
                         Academico.fa_factura_aca.IdEstudiante = estudiante.IdEstudiante INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante AS contrato ON estudiante.IdInstitucion = contrato.IdInstitucion AND estudiante.IdEstudiante = contrato.IdEstudiante INNER JOIN
                         dbo.Aca_matricula AS matricula ON contrato.IdInstitucion = matricula.IdInstitucion AND contrato.IdMatricula = matricula.IdMatricula INNER JOIN
                         dbo.Aca_Paralelo AS paralelo ON matricula.IdParalelo = paralelo.IdParalelo AND matricula.IdParalelo = paralelo.IdParalelo INNER JOIN
                         dbo.Aca_curso ON paralelo.IdCurso = dbo.Aca_curso.IdCurso AND paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                         dbo.Aca_Seccion AS seccion ON dbo.Aca_curso.IdSeccion = seccion.IdSeccion AND dbo.Aca_curso.IdSeccion = seccion.IdSeccion INNER JOIN
                         dbo.tb_persona AS persona_clien ON clie.IdPersona = persona_clien.IdPersona AND clie.IdPersona = persona_clien.IdPersona INNER JOIN
                         dbo.tb_persona AS Persona_estud ON estudiante.IdPersona = Persona_estud.IdPersona AND estudiante.IdPersona = Persona_estud.IdPersona

						 group by

						 Academico.fa_factura_aca.IdEmpresa, Academico.fa_factura_aca.IdSucursal, Academico.fa_factura_aca.IdBodega, Academico.fa_factura_aca.IdCbteVta, Academico.fa_factura_aca.IdInstitucion, 
                         Academico.fa_factura_aca.IdEstudiante, Academico.fa_factura_aca.IdFamiliar, Academico.fa_factura_aca.IdParentesco_cat, dbo.fa_factura.CodCbteVta, dbo.fa_factura.vt_tipoDoc, dbo.fa_factura.vt_serie1, 
                         dbo.fa_factura.vt_serie2, dbo.fa_factura.vt_NumFactura, dbo.fa_factura.vt_Observacion, dbo.fa_factura.vt_fecha, dbo.fa_factura.vt_fech_venc,  Persona_estud.pe_apellido , Persona_estud.pe_nombre , 
                         persona_clien.pe_apellido, persona_clien.pe_nombre , seccion.Descripcion_secc, paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, contrato.IdContrato, 
                         contrato.IdAnioLectivo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwACA_fa_factura_aca_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1192
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "seccion"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1324
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "persona_clien"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1456
               Right = 286
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Persona_estud"
            Begin Extent = 
               Top = 1458
               Left = 38
               Bottom = 1588
               Right = 286
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "contrato"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 34
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwACA_fa_factura_aca_Det';


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
         Top = -576
         Left = 0
      End
      Begin Tables = 
         Begin Table = "clie"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_factura"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_det"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_factura_aca (Academico)"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "estudiante"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "matricula"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 280
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "paralelo"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 263
            End
     ', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwACA_fa_factura_aca_Det';

