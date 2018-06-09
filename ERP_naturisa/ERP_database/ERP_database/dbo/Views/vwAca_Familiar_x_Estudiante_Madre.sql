

CREATE VIEW [dbo].[vwAca_Familiar_x_Estudiante_Madre]
AS
SELECT        dbo.Aca_Familiar_x_Estudiante.IdEstudiante, dbo.Aca_Familiar_x_Estudiante.IdFamiliar, dbo.tb_persona.pe_apellido AS Apellido, dbo.tb_persona.pe_nombre AS Nombre, 
                         dbo.tb_persona.pe_cedulaRuc AS Cedula, dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat, dbo.Aca_Familiar.IdPersona, dbo.Aca_Familiar.Titulo, dbo.Aca_Familiar.empresa_telefono, 
                         dbo.Aca_Familiar.empresa_donde_trabaja, dbo.Aca_Familiar.empresa_direccion, dbo.Aca_Familiar.IdNivelEducativo_cat AS IdNivelEducativocat, dbo.Aca_Familiar.IdInstitucion
FROM            dbo.Aca_Familiar_x_Estudiante INNER JOIN
                         dbo.Aca_Familiar ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                         dbo.tb_persona ON dbo.Aca_Familiar.IdPersona = dbo.tb_persona.IdPersona
WHERE        (dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = 'MADR')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_x_Estudiante_Madre';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[8] 2[20] 3) )"
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
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 359
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 3
               Left = 676
               Bottom = 166
               Right = 936
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 178
               Left = 67
               Bottom = 341
               Right = 341
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_x_Estudiante_Madre';

