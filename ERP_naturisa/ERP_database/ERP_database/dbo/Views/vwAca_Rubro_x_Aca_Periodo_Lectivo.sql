/*
SELECT        Per.IdInstitucion,Per.IdAnioLectivo, Per.IdPeriodo as IdPeriodoLectivo, rub.IdRubro, 0 Valor, 'A' AS Estado, 'N' Existe_en_Base,Per.pe_FechaIni FechaInicio,Per.pe_FechaFin FechaFin
FROM            Aca_Rubro rub, Aca_Periodo Per
WHERE        NOT EXISTS
                             ( SELECT        *
                               FROM            Aca_Rubro_x_Aca_Periodo_Lectivo rub_x_per
                               WHERE        rub_x_per.IdInstitucion = Per.IdInstitucion 
							   AND rub_x_per.IdPeriodo = Per.IdPeriodo
							   AND rub_x_per.IdRubro = rub.IdRubro
							   and rub_x_per.IdAnioLectivo=Per.IdAnioLectivo
							   )
*/
CREATE VIEW dbo.vwAca_Rubro_x_Aca_Periodo_Lectivo
AS
SELECT        Per.IdInstitucion, Per.IdAnioLectivo, Per.IdPeriodo AS IdPeriodoLectivo, 'A' AS Estado, 'N' AS Existe_en_Base, Per.pe_FechaIni, Per.pe_FechaFin, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro, 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.Valor, Per.est_apertura, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.UsuarioCreacion, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.FechaCreacion, 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.UsuarioModificacion, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.FechaModificacion, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.UsuarioAnulacion, 
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.FechaAnulacion, dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.MotivoAnulacion
FROM            dbo.Aca_periodo AS Per INNER JOIN
                         dbo.Aca_Rubro ON Per.IdInstitucion = dbo.Aca_Rubro.IdInstitucion INNER JOIN
                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo ON Per.IdAnioLectivo = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdAnioLectivo AND dbo.Aca_Rubro.IdRubro = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdRubro AND 
                         dbo.Aca_Rubro.IdInstitucion = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_rub AND Per.IdPeriodo = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdPeriodo AND 
                         Per.IdInstitucion = dbo.Aca_Rubro_x_Aca_Periodo_Lectivo.IdInstitucion_per
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Rubro_x_Aca_Periodo_Lectivo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[13] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Per"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 272
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro"
            Begin Extent = 
               Top = 9
               Left = 761
               Bottom = 325
               Right = 1094
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Rubro_x_Aca_Periodo_Lectivo"
            Begin Extent = 
               Top = 97
               Left = 367
               Bottom = 325
               Right = 672
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
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
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Rubro_x_Aca_Periodo_Lectivo';

