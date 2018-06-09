CREATE VIEW dbo.vwAca_Contrato_x_Estudiante_x_Rubro
AS
SELECT dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion, dbo.Aca_matricula.IdAnioLectivo, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.Aca_Contrato_x_Estudiante.IdMatricula, dbo.Aca_matricula.IdEstudiante, 
                  dbo.Aca_matricula.IdParalelo, dbo.Aca_Rubro.Descripcion_rubro, dbo.Aca_Contrato_x_Estudiante_det.IdRubro, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.Valor, dbo.Aca_matricula.Fecha_matricula, 
                  dbo.Aca_periodo.est_apertura AS est_apertura_periodo, dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per, dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per, 
                  dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per, dbo.Aca_Rubro.IdGrupoFE, dbo.Aca_Rubro.deb_cred, dbo.Aca_Contrato_x_Estudiante.estado AS estado_rubro, 
                  dbo.Aca_Contrato_x_Estudiante_det.FechaCreacion, dbo.Aca_Contrato_x_Estudiante_det.FechaModificacion, dbo.Aca_Contrato_x_Estudiante_det.FechaAnulacion, 
                  dbo.Aca_Contrato_x_Estudiante_det.UsuarioCreacion, dbo.Aca_Contrato_x_Estudiante_det.UsuarioModificacion, dbo.Aca_Contrato_x_Estudiante_det.UsuarioAnulacion, 
                  dbo.Aca_Contrato_x_Estudiante_det.MotivoAnulacion, dbo.Aca_Contrato_x_Estudiante_det.estado AS estado_rubro_contrato
FROM     dbo.Aca_periodo INNER JOIN
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo ON dbo.Aca_periodo.IdInstitucion = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per AND 
                  dbo.Aca_periodo.IdAnioLectivo = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo AND dbo.Aca_periodo.IdPeriodo = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo RIGHT OUTER JOIN
                  dbo.Aca_Contrato_x_Estudiante INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante_det ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion AND 
                  dbo.Aca_Contrato_x_Estudiante.IdContrato = dbo.Aca_Contrato_x_Estudiante_det.IdContrato INNER JOIN
                  dbo.Aca_matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = dbo.Aca_matricula.IdMatricula INNER JOIN
                  dbo.Aca_Rubro ON dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = dbo.Aca_Rubro.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante_det.IdRubro = dbo.Aca_Rubro.IdRubro ON 
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_rub = dbo.Aca_Rubro.IdInstitucion AND dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro = dbo.Aca_Rubro.IdRubro AND 
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per = dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per AND 
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo = dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per AND 
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo = dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_x_Rubro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'hs = 18
         Width = 284
         Width = 1785
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2295
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2370
         Width = 1620
         Width = 1710
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1590
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_x_Rubro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[16] 2[18] 3) )"
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
         Left = -919
      End
      Begin Tables = 
         Begin Table = "Aca_periodo"
            Begin Extent = 
               Top = 0
               Left = 35
               Bottom = 385
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Aca_Rubro_x_Aca_Periodo_Lectivo"
            Begin Extent = 
               Top = 0
               Left = 357
               Bottom = 244
               Right = 668
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 38
               Left = 1261
               Bottom = 347
               Right = 1500
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Aca_Contrato_x_Estudiante_det"
            Begin Extent = 
               Top = 30
               Left = 1017
               Bottom = 317
               Right = 1221
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Aca_matricula"
            Begin Extent = 
               Top = 29
               Left = 1569
               Bottom = 392
               Right = 1811
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro"
            Begin Extent = 
               Top = 4
               Left = 732
               Bottom = 416
               Right = 971
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
      Begin ColumnWidt', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_x_Rubro';

