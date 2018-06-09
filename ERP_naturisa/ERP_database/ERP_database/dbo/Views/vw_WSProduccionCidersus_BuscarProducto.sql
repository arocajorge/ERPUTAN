CREATE VIEW dbo.vw_WSProduccionCidersus_BuscarProducto
AS
SELECT     dbo.prd_Orden_Taller.IdEmpresa, dbo.prd_Orden_Taller.IdSucursal, dbo.prd_Orden_Taller.IdOrdenTaller, dbo.prd_EtapaProduccion.IdProcesoProductivo, 
                      dbo.prd_EtapaProduccion.IdEtapa, dbo.vwin_ReimpresionCodigoBarra_cusCider.IdNumMovi, dbo.vwin_ReimpresionCodigoBarra_cusCider.CodigoBarra, 
                      dbo.vwin_ReimpresionCodigoBarra_cusCider.pr_descripcion, dbo.vwin_ReimpresionCodigoBarra_cusCider.pr_peso, 
                      dbo.vwin_ReimpresionCodigoBarra_cusCider.mv_tipo_movi
FROM         dbo.prd_Orden_Taller INNER JOIN
                      dbo.prd_ProcesoProductivo ON dbo.prd_Orden_Taller.IdEmpresa = dbo.prd_ProcesoProductivo.IdEmpresa INNER JOIN
                      dbo.prd_EtapaProduccion ON dbo.prd_ProcesoProductivo.IdEmpresa = dbo.prd_EtapaProduccion.IdEmpresa AND 
                      dbo.prd_ProcesoProductivo.IdProcesoProductivo = dbo.prd_EtapaProduccion.IdProcesoProductivo LEFT OUTER JOIN
                      dbo.vwin_ReimpresionCodigoBarra_cusCider ON dbo.prd_Orden_Taller.IdEmpresa = dbo.vwin_ReimpresionCodigoBarra_cusCider.IdEmpresa AND 
                      dbo.prd_Orden_Taller.IdOrdenTaller = dbo.vwin_ReimpresionCodigoBarra_cusCider.ot_IdOrdenTaller AND 
                      dbo.prd_Orden_Taller.CodObra = dbo.vwin_ReimpresionCodigoBarra_cusCider.ot_CodObra
GROUP BY dbo.prd_Orden_Taller.IdEmpresa, dbo.prd_Orden_Taller.IdSucursal, dbo.prd_Orden_Taller.IdOrdenTaller, dbo.prd_EtapaProduccion.IdProcesoProductivo, 
                      dbo.prd_EtapaProduccion.IdEtapa, dbo.vwin_ReimpresionCodigoBarra_cusCider.IdNumMovi, dbo.vwin_ReimpresionCodigoBarra_cusCider.CodigoBarra, 
                      dbo.vwin_ReimpresionCodigoBarra_cusCider.pr_descripcion, dbo.vwin_ReimpresionCodigoBarra_cusCider.pr_peso, 
                      dbo.vwin_ReimpresionCodigoBarra_cusCider.mv_tipo_movi
HAVING      (dbo.vwin_ReimpresionCodigoBarra_cusCider.mv_tipo_movi = N'-')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_BuscarProducto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[12] 2[20] 3) )"
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
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 301
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_ProcesoProductivo"
            Begin Extent = 
               Top = 2
               Left = 399
               Bottom = 110
               Right = 604
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_EtapaProduccion"
            Begin Extent = 
               Top = 21
               Left = 686
               Bottom = 129
               Right = 891
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwin_ReimpresionCodigoBarra_cusCider"
            Begin Extent = 
               Top = 144
               Left = 405
               Bottom = 252
               Right = 616
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
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_WSProduccionCidersus_BuscarProducto';

