CREATE VIEW dbo.vwAca_Contrato_x_Estudiante_det_Beca
AS
SELECT        dbo.Aca_Contrato_x_Estudiante.IdInstitucion, dbo.Aca_Contrato_x_Estudiante.IdEstudiante, dbo.Aca_Contrato_x_Estudiante.IdContrato, dbo.Aca_Contrato_x_Estudiante_det.IdRubro, 
                         dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per, dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per, dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per, dbo.Aca_Rubro.Descripcion_rubro, 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.Valor, dbo.Aca_Anio_Lectivo.Descripcion, dbo.Aca_periodo.pe_FechaIni, dbo.Aca_periodo.pe_FechaFin, dbo.Aca_Contrato_x_Estudiante_det_Beca.valor_beca, 
                         dbo.Aca_Contrato_x_Estudiante_det_Beca.porc_beca AS Porcentaje_beca, CASE WHEN dbo.Aca_Contrato_x_Estudiante_det_Beca.IdBeca IS NULL THEN 0 ELSE 1 END AS TieneBeca, 
                         CASE WHEN dbo.Aca_Contrato_x_Estudiante_det_Beca.IdBeca IS NULL THEN NULL ELSE dbo.Aca_Beca.nom_beca END AS nom_beca, dbo.Aca_Contrato_x_Estudiante_det_Beca.IdBeca
FROM            dbo.Aca_Rubro_x_Aca_Periodo_Lectivo INNER JOIN
                         dbo.Aca_periodo ON dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per = dbo.Aca_periodo.IdInstitucion AND dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo = dbo.Aca_periodo.IdAnioLectivo AND 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo = dbo.Aca_periodo.IdPeriodo INNER JOIN
                         dbo.Aca_Anio_Lectivo INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante ON dbo.Aca_Anio_Lectivo.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND 
                         dbo.Aca_Anio_Lectivo.IdAnioLectivo = dbo.Aca_Contrato_x_Estudiante.IdAnioLectivo INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante_det ON dbo.Aca_Contrato_x_Estudiante.IdContrato = dbo.Aca_Contrato_x_Estudiante_det.IdContrato AND 
                         dbo.Aca_Contrato_x_Estudiante.IdInstitucion = dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion ON 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_rub = dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion AND 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro = dbo.Aca_Contrato_x_Estudiante_det.IdRubro AND 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per = dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per AND 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo = dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per AND 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo = dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per INNER JOIN
                         dbo.Aca_Rubro ON dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro = dbo.Aca_Rubro.IdRubro AND dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_rub = dbo.Aca_Rubro.IdInstitucion INNER JOIN
                         dbo.Aca_Beca ON dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro = dbo.Aca_Beca.IdRubro LEFT OUTER JOIN
                         dbo.Aca_Contrato_x_Estudiante_det_Beca ON dbo.Aca_Beca.IdBeca = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdBeca AND 
                         dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdInstitucion AND 
                         dbo.Aca_Contrato_x_Estudiante_det.IdContrato = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdContrato AND dbo.Aca_Contrato_x_Estudiante_det.IdRubro = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdRubro AND 
                         dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion_Per = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdInstitucion_Per AND 
                         dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdAnioLectivo_Per AND 
                         dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per = dbo.Aca_Contrato_x_Estudiante_det_Beca.IdPeriodo_Per
WHERE        (dbo.Aca_Contrato_x_Estudiante_det.IdContrato NOT IN
                             (SELECT        IdContrato
                               FROM            dbo.Aca_Contrato_x_Estudiante_det_Beca AS Bec
                               WHERE        (dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = IdContrato) AND (dbo.Aca_Contrato_x_Estudiante_det.IdInstitucion = IdInstitucion) AND (dbo.Aca_Contrato_x_Estudiante_det.IdRubro = IdRubro) 
                                                         AND (dbo.Aca_Contrato_x_Estudiante_det.IdAnioLectivo_Per = IdAnioLectivo_Per) AND (dbo.Aca_Contrato_x_Estudiante_det.IdPeriodo_Per = IdPeriodo_Per)))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_det_Beca';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'om = 561
               Right = 619
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante_det_Beca"
            Begin Extent = 
               Top = 331
               Left = 102
               Bottom = 568
               Right = 380
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
      Begin ColumnWidths = 20
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1950
         Width = 1995
         Width = 1500
         Width = 1815
         Width = 1500
         Width = 1500
         Width = 1965
         Width = 1680
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_det_Beca';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[46] 4[14] 2[10] 3) )"
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
         Top = -316
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Aca_Rubro_x_Aca_Periodo_Lectivo"
            Begin Extent = 
               Top = 16
               Left = 900
               Bottom = 182
               Right = 1109
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_periodo"
            Begin Extent = 
               Top = 223
               Left = 883
               Bottom = 428
               Right = 1092
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Anio_Lectivo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 331
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 337
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Contrato_x_Estudiante_det"
            Begin Extent = 
               Top = 331
               Left = 708
               Bottom = 648
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro"
            Begin Extent = 
               Top = 0
               Left = 1139
               Bottom = 388
               Right = 1348
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Beca"
            Begin Extent = 
               Top = 341
               Left = 410
               Bott', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Contrato_x_Estudiante_det_Beca';

