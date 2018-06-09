CREATE VIEW [dbo].[vwAca_Familiar_x_Estudiante]
AS

SELECT        f.IdInstitucion, f.IdEstudiante, f.IdFamiliar, p.pe_cedulaRuc, p.IdPersona, p.pe_nombre, p.pe_apellido, p.pe_fechaNacimiento, p.IdEstadoCivil, p.pe_direccion, p.pe_telefonoCasa, 
                         dbo.Aca_Familiar.IdNivelEducativo_cat, dbo.Aca_Familiar.Titulo, dbo.Aca_Familiar.OcupacionLaboral, dbo.Aca_Familiar.empresa_donde_trabaja, dbo.Aca_Familiar.empresa_direccion, 
                         dbo.Aca_Familiar.empresa_telefono, dbo.Aca_Familiar.empresa_email, f.esta_autorizado_recibir_not_mail, f.esta_autorizado_ret_alum, dbo.Aca_Familiar.Calle_Principal, dbo.Aca_Familiar.Calle_Secundaria, 
                         dbo.Aca_Familiar.Fallecido, dbo.Aca_Familiar.FueExAlumnoGraduado, dbo.Aca_Familiar.IdCatalogoIdiomaNativo, dbo.Aca_Familiar.IdCatalogoReligion, dbo.Aca_Familiar.IdCatalogoTipoSangre, 
                         dbo.Aca_Familiar.PoseeDiscapacidad, dbo.Aca_Familiar.Sector_Urbanizacion, dbo.Aca_Familiar.ViveFueraDelPais, dbo.Aca_Familiar.IdCiudad, f.Vive_con_el_estudiante, f.IdParentesco_cat, f.activo
FROM            dbo.Aca_Familiar_x_Estudiante AS f INNER JOIN
                         dbo.Aca_Familiar ON f.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND f.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                         dbo.tb_persona AS p ON dbo.Aca_Familiar.IdPersona = p.IdPersona
UNION
SELECT        0 AS IdInstitucion, 0 IdEstudiante, 0 AS IdFamiliar, pe.pe_cedulaRuc, pe.IdPersona, pe.pe_nombre, pe.pe_apellido, pe.pe_fechaNacimiento, pe.IdEstadoCivil, pe.pe_direccion, pe.pe_telefonoCasa, 
                         '' AS IdNivelEducativo_cat, '' AS Titulo, '' AS OcupacionLaboral, '' AS empresa_donde_trabaja, '' AS empresa_direccion, '' AS empresa_telefono, '' AS empresa_email, 0 AS esta_autorizado_recibir_not_mail, 
                         0 AS esta_autorizado_ret_alum, '' AS Calle_Principal, '' AS Calle_Secundaria, 0 AS Fallecido, 0 AS FueExAlumnoGraduado, '' AS IdCatalogoIdiomaNativo, '' AS IdCatalogoReligion, '' AS IdCatalogoTipoSangre, 
                         0 AS PoseeDiscapacidad, '' AS Sector_Urbanizacion, 0 AS ViveFueraDelPais, '' AS IdCiudad, 0 AS Vive_con_el_estudiante, NULL AS IdParentesco_cat, cast(0 as bit) AS activo
FROM            tb_persona pe
WHERE        NOT EXISTS
                             (SELECT        p.pe_cedulaRuc
                               FROM            Aca_Familiar_x_Estudiante AS f INNER JOIN
                                                         Aca_Familiar ON f.IdInstitucion = Aca_Familiar.IdInstitucion AND f.IdFamiliar = Aca_Familiar.IdFamiliar INNER JOIN
                                                         tb_persona AS p ON Aca_Familiar.IdPersona = p.IdPersona
                               WHERE        p.IdPersona = pe.IdPersona)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_x_Estudiante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[7] 4[8] 2[56] 3) )"
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
         Top = -384
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
      Begin ColumnWidths = 35
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_x_Estudiante';

