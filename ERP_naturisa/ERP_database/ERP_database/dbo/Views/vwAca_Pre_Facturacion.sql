CREATE VIEW [dbo].[vwAca_Pre_Facturacion]
	AS 
	SELECT        dbo.Aca_Pre_Facturacion.IdInstitucion, dbo.Aca_Pre_Facturacion.IdPreFacturacion, dbo.Aca_Pre_Facturacion.IdInstitucion_contrato, dbo.Aca_Pre_Facturacion.IdPeriodo, 
                         dbo.Aca_Pre_Facturacion.fecha_prefacturacion, dbo.Aca_Pre_Facturacion.IdEmpresa_fact, dbo.Aca_Pre_Facturacion.IdSucursal_fact, dbo.Aca_Pre_Facturacion.IdBodega_fact, dbo.Aca_Pre_Facturacion.IdCbteVta, 
                         dbo.Aca_Pre_Facturacion.IdPtoVta_fact, dbo.Aca_Pre_Facturacion.IdCaja_fact, dbo.Aca_Pre_Facturacion.vt_fecha_fact, dbo.Aca_Pre_Facturacion.vt_plazo_fact, dbo.Aca_Pre_Facturacion.vt_fech_venc, 
                         dbo.Aca_Pre_Facturacion.observacion_fact, dbo.Aca_Pre_Facturacion.Estado_Pre_factutacion_Cat, dbo.Aca_Anio_Lectivo.Descripcion, dbo.Aca_periodo.pe_FechaIni, dbo.Aca_periodo.pe_FechaFin, 
                         dbo.Aca_periodo.pe_estado, dbo.Aca_Anio_Lectivo.IdAnioLectivo, dbo.Aca_Institucion.Ruc, dbo.Aca_Institucion.codInstitucion, dbo.Aca_Institucion.Nombre
FROM            dbo.Aca_Pre_Facturacion INNER JOIN
                         dbo.Aca_Institucion ON dbo.Aca_Pre_Facturacion.IdInstitucion = dbo.Aca_Institucion.IdInstitucion INNER JOIN
                         dbo.Aca_periodo ON dbo.Aca_Pre_Facturacion.IdInstitucion = dbo.Aca_periodo.IdInstitucion AND dbo.Aca_Pre_Facturacion.IdPeriodo = dbo.Aca_periodo.IdPeriodo INNER JOIN
                         dbo.Aca_Anio_Lectivo ON dbo.Aca_periodo.IdInstitucion = dbo.Aca_Anio_Lectivo.IdInstitucion AND dbo.Aca_periodo.IdAnioLectivo = dbo.Aca_Anio_Lectivo.IdAnioLectivo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'0
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion';


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
         Top = -288
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Aca_Pre_Facturacion"
            Begin Extent = 
               Top = 0
               Left = 31
               Bottom = 141
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Institucion"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_periodo"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_Anio_Lectivo"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 247
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
         Or = 135', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwAca_Pre_Facturacion';

