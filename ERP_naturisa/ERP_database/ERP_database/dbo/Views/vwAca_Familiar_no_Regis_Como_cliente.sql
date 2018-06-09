CREATE VIEW dbo.vwAca_Familiar_no_Regis_Como_cliente
AS
SELECT P.IdPersona, P.CodPersona, P.pe_Naturaleza, P.pe_nombreCompleto, P.pe_razonSocial, P.pe_apellido, P.pe_nombre, P.IdTipoPersona, P.IdTipoDocumento, P.pe_cedulaRuc, P.pe_direccion, P.pe_telefonoCasa, 
                  P.pe_telefonoOfic, P.pe_telefonoInter, P.pe_telfono_Contacto, P.pe_celular, P.pe_correo, P.pe_fax, P.pe_casilla, P.pe_sexo, P.IdEstadoCivil, P.pe_fechaNacimiento, P.pe_estado, P.pe_fechaCreacion, 
                  P.pe_fechaModificacion, P.pe_UltUsuarioModi, P.pe_celularSecundario, P.IdUsuarioUltAnu, P.Fecha_UltAnu, P.MotivoAnulacion, P.pe_correo_secundario1, P.pe_correo_secundario2, P.IdTipoCta_acreditacion_cat, 
                  P.num_cta_acreditacion, P.IdBanco_acreditacion, F.IdCiudad
FROM     dbo.tb_persona AS P INNER JOIN
                  dbo.Aca_Familiar AS F ON P.IdPersona = F.IdPersona INNER JOIN
                  dbo.Aca_Familiar_x_Estudiante ON F.IdInstitucion = dbo.Aca_Familiar_x_Estudiante.IdInstitucion AND F.IdFamiliar = dbo.Aca_Familiar_x_Estudiante.IdFamiliar
WHERE  (P.IdPersona NOT IN
                      (SELECT IdPersona
                       FROM      dbo.fa_cliente)) AND (dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = 'REP_ECO')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_no_Regis_Como_cliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'      Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_no_Regis_Como_cliente';


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
         Begin Table = "P"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 320
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F"
            Begin Extent = 
               Top = 28
               Left = 462
               Bottom = 326
               Right = 722
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 16
               Left = 886
               Bottom = 320
               Right = 1197
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
      Begin ColumnWidths = 38
         Width = 284
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2448
         Width = 1200
         Width = 1200
         Width = 1200
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Familiar_no_Regis_Como_cliente';

