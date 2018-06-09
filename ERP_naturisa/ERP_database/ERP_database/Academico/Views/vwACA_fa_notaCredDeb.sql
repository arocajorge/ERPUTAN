CREATE VIEW Academico.vwACA_fa_notaCredDeb
AS
SELECT dbo.fa_notaCreDeb.IdEmpresa, dbo.fa_notaCreDeb.IdSucursal, dbo.fa_notaCreDeb.IdBodega, dbo.fa_notaCreDeb.IdNota, dbo.fa_notaCreDeb.CodNota, dbo.fa_notaCreDeb.CreDeb, 
                  dbo.fa_notaCreDeb.CodDocumentoTipo, dbo.fa_notaCreDeb.Serie1, dbo.fa_notaCreDeb.Serie2, dbo.fa_notaCreDeb.NumNota_Impresa, dbo.fa_notaCreDeb.NumAutorizacion, dbo.fa_notaCreDeb.Fecha_Autorizacion, 
                  dbo.fa_notaCreDeb.IdCliente, dbo.fa_notaCreDeb.IdVendedor, dbo.fa_notaCreDeb.no_fecha, dbo.fa_notaCreDeb.no_fecha_venc, dbo.fa_notaCreDeb.fecha_Ctble, dbo.fa_notaCreDeb.no_dev_venta, 
                  dbo.fa_notaCreDeb.IdTipoNota, dbo.fa_notaCreDeb.sc_observacion, dbo.fa_notaCreDeb.IdUsuario, dbo.fa_notaCreDeb.IdDevolucion, dbo.fa_notaCreDeb.IdUsuarioUltMod, dbo.fa_notaCreDeb.Fecha_UltMod, 
                  dbo.fa_notaCreDeb.IdUsuarioUltAnu, dbo.fa_notaCreDeb.Fecha_UltAnu, dbo.fa_notaCreDeb.nom_pc, dbo.fa_notaCreDeb.MotiAnula, dbo.fa_notaCreDeb.ip, dbo.fa_notaCreDeb.Estado, dbo.fa_notaCreDeb.IdDpto, 
                  dbo.fa_notaCreDeb.IdSolicitante, dbo.fa_notaCreDeb.flete, dbo.fa_notaCreDeb.interes, dbo.fa_notaCreDeb.valor1, dbo.fa_notaCreDeb.valor2, dbo.fa_notaCreDeb.NaturalezaNota, dbo.fa_notaCreDeb.seguro, 
                  dbo.fa_notaCreDeb.IdCaja, dbo.fa_notaCreDeb.IdCtaCble_TipoNota, dbo.fa_notaCreDeb.IdEmpresa_fac_doc_mod, dbo.fa_notaCreDeb.IdSucursal_fac_doc_mod, dbo.fa_notaCreDeb.IdBodega_fac_doc_mod, 
                  dbo.fa_notaCreDeb.IdCbteVta_fac_doc_mod, dbo.fa_notaCreDeb.IdPuntoVta, dbo.Aca_estudiante.IdInstitucion, dbo.Aca_estudiante.IdEstudiante, Academico.fa_notaCredDeb_aca.Observaciones
FROM     Academico.fa_notaCredDeb_aca INNER JOIN
                  dbo.Aca_estudiante ON Academico.fa_notaCredDeb_aca.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND Academico.fa_notaCredDeb_aca.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.fa_notaCreDeb ON Academico.fa_notaCredDeb_aca.IdEmpresa = dbo.fa_notaCreDeb.IdEmpresa AND Academico.fa_notaCredDeb_aca.IdSucursal = dbo.fa_notaCreDeb.IdSucursal AND 
                  Academico.fa_notaCredDeb_aca.IdBodega = dbo.fa_notaCreDeb.IdBodega AND Academico.fa_notaCredDeb_aca.IdNotaCredDeb = dbo.fa_notaCreDeb.IdNota
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwACA_fa_notaCredDeb';


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
         Begin Table = "fa_notaCredDeb_aca (Academico)"
            Begin Extent = 
               Top = 18
               Left = 344
               Bottom = 300
               Right = 588
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 0
               Left = 743
               Bottom = 274
               Right = 987
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_notaCreDeb"
            Begin Extent = 
               Top = 19
               Left = 12
               Bottom = 302
               Right = 271
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
', @level0type = N'SCHEMA', @level0name = N'Academico', @level1type = N'VIEW', @level1name = N'vwACA_fa_notaCredDeb';

