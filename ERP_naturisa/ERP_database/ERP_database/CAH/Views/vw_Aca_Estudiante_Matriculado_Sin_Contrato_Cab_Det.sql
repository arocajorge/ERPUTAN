CREATE VIEW CAH.vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det
AS
SELECT        me.IdInstitucion, me.IdSede, me.IdParalelo, me.IdCurso, me.IdSeccion, me.IdJornada, me.IdMatricula, me.cod_estudiante, contres.IdContrato, me.Institucion, me.Sede, me.Jornada, me.Seccion, me.Curso, 
                         me.Paralelo, me.pe_nombre, me.pe_apellido, me.pe_cedulaRuc, me.pe_direccion, me.pe_telefonoCasa, me.pe_telefonoOfic, rp.IdAnioLectivo AS IdAnioLectivo_Rubro_x_Periodo, me.IdEstudiante, rp.IdRubro, 
                         rp.Valor, rp.IdPeriodo AS IdPeriodo_Per, rp.IdInstitucion_per
FROM            dbo.vwAca_Matricula_x_Estudiante AS me INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante AS contres ON me.IdMatricula = contres.IdMatricula LEFT OUTER JOIN
                         dbo.Aca_Contrato_x_Estudiante_det AS contresdet ON contres.IdContrato = contresdet.IdContrato LEFT OUTER JOIN
                         dbo.Aca_curso_x_Aca_Rubro AS curubr ON me.IdCurso = curubr.IdCurso LEFT OUTER JOIN
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS rp ON curubr.IdRubro = rp.IdRubro
WHERE        (rp.IdRubro IS NOT NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'        Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1845
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[14] 2[21] 3) )"
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
         Begin Table = "me"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "contres"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 136
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "contresdet"
            Begin Extent = 
               Top = 6
               Left = 596
               Bottom = 136
               Right = 805
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "curubr"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rp"
            Begin Extent = 
               Top = 138
               Left = 285
               Bottom = 268
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 28
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
 ', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Estudiante_Matriculado_Sin_Contrato_Cab_Det';

