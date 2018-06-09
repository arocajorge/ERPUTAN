CREATE VIEW CAH.vw_Aca_Familiar_x_tb_persona_x_mg_persona
AS
SELECT dbo.Aca_Familiar.IdInstitucion, dbo.Aca_Familiar.IdFamiliar, dbo.Aca_Familiar.cod_familiar, dbo.Aca_Familiar.IdPersona, CAH.tb_persona_x_mg_persona.IdPersona_Academico, dbo.Aca_Familiar.IdNivelEducativo_cat, 
                  dbo.Aca_Familiar.Titulo, dbo.Aca_Familiar.OcupacionLaboral, dbo.Aca_Familiar.empresa_donde_trabaja, dbo.Aca_Familiar.empresa_direccion, dbo.Aca_Familiar.empresa_telefono, dbo.Aca_Familiar.empresa_email, 
                  dbo.Aca_Familiar.direccion_domicilio, dbo.Aca_Familiar.Calle_Principal, dbo.Aca_Familiar.Calle_Secundaria, dbo.Aca_Familiar.Sector_Urbanizacion, dbo.Aca_Familiar.IdCiudad, dbo.Aca_Familiar.PoseeDiscapacidad, 
                  dbo.Aca_Familiar.ViveFueraDelPais, dbo.Aca_Familiar.Fallecido, dbo.Aca_Familiar.IdCatalogoIdiomaNativo, dbo.Aca_Familiar.IdCatalogoTipoSangre, dbo.Aca_Familiar.IdCatalogoReligion, 
                  dbo.Aca_Familiar.FueExAlumnoGraduado, dbo.Aca_Familiar.FechaCreacion, dbo.Aca_Familiar.FechaModificacion, dbo.Aca_Familiar.UsuarioCreacion, dbo.Aca_Familiar.UsuarioModificacion
FROM     dbo.Aca_Familiar INNER JOIN
                  CAH.tb_persona_x_mg_persona ON dbo.Aca_Familiar.IdPersona = CAH.tb_persona_x_mg_persona.IdPersona_Erp
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Familiar_x_tb_persona_x_mg_persona';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[16] 2[20] 3) )"
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
         Begin Table = "Aca_Familiar"
            Begin Extent = 
               Top = 0
               Left = 64
               Bottom = 369
               Right = 331
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona_x_mg_persona (CAH)"
            Begin Extent = 
               Top = 4
               Left = 463
               Bottom = 273
               Right = 817
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
      Begin ColumnWidths = 29
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2196
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Familiar_x_tb_persona_x_mg_persona';

