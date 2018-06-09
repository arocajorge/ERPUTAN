CREATE view [dbo].[vwAca_admision]
as
SELECT        a.IdInstitucion, a.IdAdmision, a.cod_Admision, p.IdPersona, s.IdAspirante, p.IdTipoDocumento, p.pe_cedulaRuc, p.pe_nombre, p.pe_apellido, p.pe_fechaNacimiento, 
                         p.pe_sexo, s.lugar, s.IdPais_Nacionalidad, p.pe_direccion, s.barrio, p.pe_telefonoCasa, p.pe_telfono_Contacto, p.pe_correo, a.Estado, a.IdAnioLectivo, a.IdCurso, 
                         c.IdSeccion, sec.IdJornada, j.IdSede, a.IdCatalogo_Grupo_Fami_convivencia, a.IdCatalogo_Idioma_Nati, a.IdCatalogo_Tipo_Religion, a.IdCatalogo_Tipo_Sangre, 
                         a.Telefono_Emer, 'A' AS Base, p.pe_estado, a.Posee_Discapacidad, a.Tiene_Her_nuestro_cole, a.Tiene_Her_otros_cole, a.UsuarioAnulacion, a.UsuarioCreacion, 
                         a.UsuarioModificacion, a.FechaAnulacion, a.FechaCreacion, a.FechaModificacion, a.Actu_Asis_Estable_Edu, a.Hijo_de_prof_del_coleg, a.Hijo_unico, 
                         a.En_q_grado_tiene_her, a.Estable_Edu_donde_asis
FROM            Aca_Admision a INNER JOIN
                         Aca_Aspirante s ON a.IdInstitucion = s.IdInstitucion AND s.IdAspirante = a.IdAspirante LEFT JOIN
                         tb_persona p ON p.IdPersona = s.IdPersona INNER JOIN
                         Aca_curso c ON C.IdCurso = A.IdCurso INNER JOIN
                         Aca_Seccion sec ON sec.IdSeccion = c.IdSeccion INNER JOIN
                         Aca_Jornada j ON j.IdJornada = sec.IdJornada
UNION
(SELECT        0 AS IdInstitucion, 0 AS IdAdmision, '' AS cod_Admision, pe.IdPersona, 0 AS IdAspirante, pe.IdTipoDocumento, pe.pe_cedulaRuc, pe.pe_nombre, pe.pe_apellido, 
                          pe.pe_fechaNacimiento, pe.pe_sexo, '' AS lugar, '' AS IdPais_Nacionalidad, pe.pe_direccion, '' AS barrio, pe.pe_telefonoCasa, pe.pe_telfono_Contacto, pe.pe_correo,
                           '' AS Estado, '' AS IdPeriodoLectivo, 0 AS IdCurso, 0 AS IdSeccion, 0 AS IdJornada, 0 AS IdSede, '' AS IdCatalogo_Grupo_Fami_convivencia, 
                          '' AS IdCatalogo_Idioma_Nati, '' AS IdCatalogo_Tipo_Religion, '' AS IdCatalogo_Tipo_Sangre, '' AS Telefono_Emer, 'P' AS Base, pe.pe_estado, 
                          0 AS Posee_Discapacidad, 0 AS Tiene_Her_nuestro_cole, 0 AS Tiene_Her_otros_cole, '' AS UsuarioAnulacion, '' AS UsuarioCreacion, '' AS UsuarioModificacion, 
                          GETDATE() AS FechaAnulacion, GETDATE() AS FechaCreacion, GETDATE() AS FechaModificacion, 0 AS Actu_Asis_Estable_Edu, 0 AS Hijo_de_prof_del_coleg, 
                          0 AS Hijo_unico, '' AS En_q_grado_tiene_her, '' AS Estable_Edu_donde_asis
 FROM            tb_persona pe
 WHERE        NOT EXISTS
                              (SELECT        a.*
                                FROM            Aca_Admision a INNER JOIN
                                                          Aca_Aspirante s ON a.IdInstitucion = s.IdInstitucion AND s.IdAspirante = a.IdAspirante LEFT JOIN
                                                          tb_persona p ON p.IdPersona = s.IdPersona
                                WHERE        p.IdPersona = pe.IdPersona))
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_admision';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[2] 2[50] 3) )"
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
      Begin ColumnWidths = 52
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_admision';

