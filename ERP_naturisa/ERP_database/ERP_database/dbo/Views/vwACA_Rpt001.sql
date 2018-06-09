CREATE VIEW [dbo].[vwACA_Rpt001]
AS
SELECT        es.IdEstudiante, es.IdPersona AS IdPersonaEstudiante, es.cod_estudiante, es.IdTipoDocumento,
                             (SELECT        ca_descripcion
                               FROM            dbo.tb_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 3) AND (CodCatalogo = es.IdTipoDocumento)) AS DescTipoDocumento, es.pe_cedulaRuc, es.pe_nombre, es.pe_apellido, 
                         es.IdPais_Nacionalidad, es.Nacionalidad, es.lugar, es.barrio, es.pe_direccion, es.pe_celular, es.pe_telefonoCasa, es.pe_correo, es.pe_fechaNacimiento, 
                         es.pe_sexo,
                             (SELECT        ca_descripcion
                               FROM            dbo.tb_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 1) AND (CodCatalogo = es.pe_sexo)) AS descripcion_sexo, fi.Grupo_Sanguineo_cat AS IDGrupoSanguineo,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'GRUP_SAN') AND (IdCatalogo = fi.Grupo_Sanguineo_cat)) AS DescGrupoSanguineo, fi.Medica_contraIndic, 
                         fi.Otras_Indicaciones_medicas, fi.Seguro_medico, m.IdFamiliar AS IdFamiliarMadre, m.Cedula AS CedulaMadre, m.Apellido AS ApellidoMadre, 
                         m.Nombre AS NombreMadre, m.IdPersona AS IdPersonaMadre, m.IdParentesco_cat AS IDParentescoMadre,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'PAREN_FAMI') AND (IdCatalogo = m.IdParentesco_cat)) AS DescParentescoMadre, 
                         m.empresa_direccion AS empresa_direccionMadre, m.empresa_donde_trabaja AS empresa_donde_trabajaMadre, m.empresa_telefono AS empresa_telefonoMadre, 
                         m.IdNivelEducativocat AS idNivelEducativoMadre,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'NIVEL_EDU') AND (IdCatalogo = m.IdNivelEducativocat)) AS DescNivelEducativoMadre, m.Titulo AS TituloMadre, 
                         p.IdFamiliar AS IdFamiliarPadre, p.Cedula AS CedulaPadre, p.Apellido AS ApellidoPadre, p.Nombre AS NombrePadre, p.IdPersona AS IdPersonaPadre, 
                         p.IdParentesco_cat AS IDParentescoPadre,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'PAREN_FAMI') AND (IdCatalogo = p.IdParentesco_cat)) AS DescParentescoPadre, p.empresa_direccion AS empresa_direccionPadre, 
                         p.empresa_donde_trabaja AS empresa_donde_trabajaPadre, p.empresa_telefono AS empresa_telefonoPadre, p.IdNivelEducativo_cat AS idNivelEducativoPadre,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'NIVEL_EDU') AND (IdCatalogo = p.IdNivelEducativo_cat)) AS DescNivelEducativoPadre, p.Titulo AS TituloPadre, 
                         r.IdFamiliar AS IdFamiliarRepEco, r.Cedula AS CedulaRepEco, r.Apellido AS ApellidoRepEco, r.Nombre AS NombreRepEco, r.IdPersona AS IdPersonaRepEco, 
                         r.IdParentesco_cat AS IDParentescoRepEco,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'PAREN_FAMI') AND (IdCatalogo = r.IdParentesco_cat)) AS DescParentescoRepEco, 
                         r.empresa_direccion AS empresa_direccionRepEco, r.empresa_donde_trabaja AS empresa_donde_trabajaRepEco, r.empresa_telefono AS empresa_telefonoRepEco, 
                         r.IdNivelEducativo_cat AS idNivelEducativoRepEco,
                             (SELECT        Descripcion
                               FROM            dbo.Aca_Catalogo AS c
                               WHERE        (IdTipoCatalogo = 'NIVEL_EDU') AND (IdCatalogo = r.IdNivelEducativo_cat)) AS DescNivelEducativoRepEco, r.Titulo AS TituloRepEco
FROM            dbo.vwAca_estudiante AS es LEFT OUTER JOIN
                         dbo.Aca_ficha_medica AS fi ON fi.IdEstudiante = es.IdEstudiante LEFT OUTER JOIN
                         dbo.vwAca_Familiar_x_Estudiante_Madre AS m ON m.IdEstudiante = es.IdEstudiante LEFT OUTER JOIN
                         dbo.vwAca_Familiar_x_Estudiante_Padre AS p ON p.IdEstudiante = es.IdEstudiante LEFT OUTER JOIN
                         dbo.vwAca_Familiar_x_Estudiante_RepEco AS r ON r.IdEstudiante = es.IdEstudiante
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwACA_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "es"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fi"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "r"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 252
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwACA_Rpt001';

