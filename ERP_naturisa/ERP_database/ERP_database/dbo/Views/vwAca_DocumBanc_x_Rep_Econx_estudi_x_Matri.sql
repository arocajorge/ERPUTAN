CREATE VIEW dbo.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri
AS
SELECT dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.IdDocumento_Bancario, dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.Numero_Documento, dbo.Aca_Documento_Bancario_x_Rep_Economico.Fecha_Expiracion, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdEstudiante, dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdMatricula, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.Observacion, dbo.Aca_Documento_Bancario_x_Rep_Economico.IdBanco, 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.Id_tipo_meca_pago, dbo.Aca_Documento_Bancario_x_Rep_Economico.Id_tb_banco_x_mgbanco, dbo.Aca_Tipo_Mecanismo_Pago.idProceso_Bancario_Tipo
FROM     dbo.Aca_Documento_Bancario_x_Rep_Economico INNER JOIN
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula ON 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdInstitucion AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdFamiliar AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdParentesco_cat AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico.IdDocumento_Bancario = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdDocumento_Bancario INNER JOIN
                  dbo.Aca_Tipo_Mecanismo_Pago ON dbo.Aca_Documento_Bancario_x_Rep_Economico.Id_tipo_meca_pago = dbo.Aca_Tipo_Mecanismo_Pago.Id_tipo_meca_pago AND 
                  dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.Id_tipo_meca_pago = dbo.Aca_Tipo_Mecanismo_Pago.Id_tipo_meca_pago
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[27] 2[21] 3) )"
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
         Begin Table = "Aca_Tipo_Mecanismo_Pago"
            Begin Extent = 
               Top = 54
               Left = 614
               Bottom = 310
               Right = 993
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 411
               Right = 488
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula"
            Begin Extent = 
               Top = 0
               Left = 1112
               Bottom = 320
               Right = 1331
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
      Begin ColumnWidths = 14
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
         Width = 1764
         Width = 1704
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2064
         Alias = 900
         Table = 6696
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri';

