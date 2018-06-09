

CREATE VIEW [dbo].[vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para]
AS
SELECT        IdInstitucion,isnull(CAST( 'I-' + cast(IdInstitucion AS varchar(5)) as varchar(20)) ,'') AS Id, NULL AS IdPadre, Nombre, Estado, 1 AS Nivel,  NULL IdSede, NULL IdJornada, NULL 
                         IdSeccion, NULL AS IdCurso, NULL AS IdParalelo
FROM            Aca_Institucion
UNION
SELECT        IdInstitucion, isnull(CAST( 'Sed-' + cast(IdSede AS varchar(5)) as varchar(20)) ,'') AS Id, 'I-' + cast(IdInstitucion AS varchar(5)) AS IdPadre, Descripcion_sede, estado, 2 AS Nivel,  IdSede, NULL
                          IdJornada, NULL IdSeccion, NULL AS IdCurso, NULL AS IdParalelo
FROM            Aca_Sede
union
SELECT        s.IdInstitucion, isnull(CAST( 'J-' + cast(a.IdJornada AS varchar(5)) as varchar(20)) ,'') AS  Id, 'Sed-' + cast(a.IdSede AS varchar(5)) AS IdPadre, a.Descripcion_Jor, a.estado, 3 AS Nivel, 
                         a.IdSede, a.IdJornada, NULL IdSeccion, NULL AS IdCurso, NULL AS IdParalelo
FROM            Aca_Jornada a LEFT JOIN
                         Aca_Sede s ON  s.IdSede = a.IdSede
UNION
SELECT        s.IdInstitucion,isnull(CAST(  'Sec-' + cast(a.IdSeccion AS varchar(5)) as varchar(20)) ,'') AS Id, 'J-' + cast(a.IdJornada AS varchar(5)) AS IdPadre, a.Descripcion_secc, a.estado, 4 AS Nivel, 
                       j.IdSede, a.IdJornada, a.IdSeccion, NULL AS IdCurso, NULL AS IdParalelo
FROM            Aca_Seccion a LEFT JOIN
                         Aca_Jornada j ON j.IdJornada = a.IdJornada LEFT JOIN
                         Aca_Sede s ON  s.IdSede = j.IdSede
UNION
SELECT        se.IdInstitucion,isnull(CAST(  'C-' + cast(a.IdCurso AS varchar(5)) as varchar(20)) ,'') AS Id, 'Sec-' + cast(a.IdSeccion AS varchar(5)) AS IdPadre, a.Descripcion_cur, a.estado, 5 AS Nivel, 
                         j.IdSede, sec.IdJornada, a.IdSeccion, a.IdCurso, NULL AS IdParalelo
FROM            Aca_curso a LEFT JOIN
                         Aca_Seccion sec ON sec.IdSeccion = a.IdSeccion LEFT JOIN
                         Aca_Jornada j ON j.IdJornada = sec.IdJornada LEFT JOIN
                         Aca_Sede se ON se.IdSede = j.IdSede
UNION
SELECT        se.IdInstitucion, isnull(CAST(  'P-' + cast(a.IdParalelo AS varchar(5)) as varchar(20)) ,'') AS Id

, 'C-' + cast(a.IdCurso AS varchar(5))    , a.Descripcion_paralelo, a.Estado, 6 AS Nivel, j.IdSede, 
                         sec.IdJornada, c.IdSeccion, a.IdCurso, a.IdParalelo
FROM            Aca_Paralelo a LEFT JOIN
                         Aca_curso c ON c.IdCurso = a.IdCurso LEFT JOIN
                         Aca_Seccion sec ON sec.IdSeccion = c.IdSeccion LEFT JOIN
                         Aca_Jornada j ON j.IdJornada = sec.IdJornada LEFT JOIN
                         Aca_Sede se ON  se.IdSede = j.IdSede
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[5] 2[30] 3) )"
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
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para';

