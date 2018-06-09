CREATE VIEW dbo.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
AS
SELECT dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdInstitucion, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdSede, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdParalelo, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdCurso, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdSeccion, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdJornada, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdMatricula, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdEstudiante, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.cod_estudiante, 
                  ISNULL(dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdInstitucion_per, '') AS IdInstitucion_per, ISNULL(dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdAnioLectivo_Rubro_x_Periodo, '') 
                  AS IdAnioLectivo_Rubro_x_Periodo, ISNULL(dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdPeriodo_Per, '') AS IdPeriodo_Per, ISNULL(dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdRubro, '') 
                  AS IdRubro, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Valor, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Institucion, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Sede, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Jornada, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Seccion, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Curso, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.Paralelo, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_nombre, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_apellido, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_cedulaRuc, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_direccion, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_telefonoCasa, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.pe_telefonoOfic, dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdRubro AS Expr3, 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdAnioLectivo_Rubro_x_Periodo AS Expr4
FROM     dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso LEFT OUTER JOIN
                  dbo.vwAca_Contrato_x_Estudiante_Detalle ON dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdInstitucion = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdInstitucion AND 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdMatricula = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdMatricula AND 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdAnioLectivo_Rubro_x_Periodo = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdAnioLectivo AND 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdRubro = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdRubro AND 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdInstitucion_per = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdInstitucion_Per AND 
                  dbo.vwAca_Estudiante_Matricula_x_Rubro_x_Curso.IdPeriodo_Per = dbo.vwAca_Contrato_x_Estudiante_Detalle.IdPeriodo_Per
WHERE  (dbo.vwAca_Contrato_x_Estudiante_Detalle.IdMatricula IS NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Order = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[17] 4[25] 2[30] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
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
         Configuration = "(H (4[50] 3) )"
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
         Configuration = "(V (4) )"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 1
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vwAca_Estudiante_Matricula_x_Rubro_x_Curso"
            Begin Extent = 
               Top = 0
               Left = 34
               Bottom = 427
               Right = 337
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwAca_Contrato_x_Estudiante_Detalle"
            Begin Extent = 
               Top = 5
               Left = 496
               Bottom = 340
               Right = 828
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
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
         Width = 1368
         Width = 2856
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
      Begin ColumnWidths = 11
         Column = 7464
         Alias = 2268
         Table = 3240
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         Sort', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle';

