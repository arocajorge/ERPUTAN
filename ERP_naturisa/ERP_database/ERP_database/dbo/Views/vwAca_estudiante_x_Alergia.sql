CREATE VIEW [dbo].[vwAca_estudiante_x_Alergia]
AS
SELECT        t .IdInstitucion, t .IdEstudiante, t .activo, c.Descripcion AS Nom_Alergia, t .descripcion AS Comentario, t .IdAlergia_catalogo, c.Orden, 'S' AS Esta_en_Base
FROM            Aca_Catalogo AS c INNER JOIN
                         Aca_estudiante_x_Alergia AS t ON t .IdAlergia_catalogo = c.IdCatalogo
UNION
SELECT        Estu.IdInstitucion, Estu.IdEstudiante, 0 AS activo, c.Descripcion AS Nom_Alergia, '' AS comentario, C.IdCatalogo, c.Orden, 'N' AS Esta_en_Base
FROM            Aca_Catalogo AS c CROSS JOIN
                         Aca_estudiante AS Estu
WHERE        (c.IdTipoCatalogo = 'ALERGIAS') AND NOT EXISTS
                             (SELECT        A.IdInstitucion, A.IdEstudiante, A.IdAlergia_catalogo
                               FROM            Aca_estudiante_x_Alergia A
                               WHERE        A.IdInstitucion = Estu.IdInstitucion AND A.IdEstudiante = Estu.IdEstudiante AND A.IdAlergia_catalogo = C.IdCatalogo)
UNION
SELECT        0 AS IdEmpresa, 0 AS IdEstudiante, 0 AS activo, c.Descripcion AS Nom_Alergia, '' AS comentario, c.IdCatalogo AS IdAlergia_catalogo, c.Orden, 
                         'N' AS Esta_en_Base
FROM            Aca_Catalogo c
WHERE        IdTipoCatalogo = 'ALERGIAS'
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_estudiante_x_Alergia';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[5] 4[4] 2[72] 3) )"
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
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_estudiante_x_Alergia';

