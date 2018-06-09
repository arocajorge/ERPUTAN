CREATE VIEW dbo.vwAca_Pre_Facturacion_det
AS
SELECT        dbo.Aca_Pre_Facturacion_det.IdInstitucion, dbo.Aca_Pre_Facturacion_det.IdPreFacturacion, dbo.Aca_Pre_Facturacion_det.Secuencia_Proce, dbo.Aca_Pre_Facturacion_det.secuencia, 
                         dbo.Aca_Pre_Facturacion_det.IdRubro, dbo.Aca_Pre_Facturacion_det.IdInstitucion_contra, dbo.Aca_Pre_Facturacion_det.IdContrato, dbo.Aca_Pre_Facturacion_det.IdInstitucion_Per, 
                         dbo.Aca_Pre_Facturacion_det.IdPeriodo_Per, dbo.Aca_Pre_Facturacion_det.IdGrupoFE, dbo.Aca_Pre_Facturacion_det.IdProducto, dbo.Aca_Pre_Facturacion_det.vt_cantidad, 
                         dbo.Aca_Pre_Facturacion_det.vt_Precio, dbo.Aca_Pre_Facturacion_det.vt_PorDescUnitario, dbo.Aca_Pre_Facturacion_det.vt_DescUnitario, dbo.Aca_Pre_Facturacion_det.vt_PrecioFinal, 
                         dbo.Aca_Pre_Facturacion_det.vt_Subtotal, dbo.Aca_Pre_Facturacion_det.vt_iva_valor, dbo.Aca_Pre_Facturacion_det.vt_total, dbo.Aca_Pre_Facturacion_det.IdCod_Impuesto_Iva, 
                         dbo.Aca_Pre_Facturacion_det.observacion_det, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_Jornada.Descripcion_Jor, dbo.Aca_Pre_Facturacion_det.IdAnioLectivo_Per
FROM            dbo.Aca_Pre_Facturacion_det INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante ON dbo.Aca_Pre_Facturacion_det.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND 
                         dbo.Aca_Pre_Facturacion_det.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
                         dbo.Aca_estudiante ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                         dbo.tb_persona ON dbo.Aca_estudiante.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.Aca_matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = dbo.Aca_matricula.IdMatricula INNER JOIN
                         dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                         dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                         dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                         dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Seccion"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Jornada"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1192
               Right = 247
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
      Begin ColumnWidths = 31
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3000
         Alias = 900
         Table = 3195
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[29] 2[21] 3) )"
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
         Begin Table = "Aca_Pre_Facturacion_det"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 137
               Left = 25
               Bottom = 267
               Right = 298
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Paralelo"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_curso"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion_det';

