CREATE VIEW [dbo].[vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab]
AS
SELECT     CabMov.tm_descripcion, CabMov.bo_Descripcion, CabMov.Su_Descripcion, CabMov.IdNumMovi, CabMov.IdProvedor, CabMov.Fecha_Transac, CabMov.cm_fecha, 
                      CabMov.cm_observacion, CabMov.cm_tipo, CabMov.CodMoviInven, CabMov.IdSucursal, CabMov.IdBodega, CabMov.IdMovi_inven_tipo, CabMov.IdEmpresa, 
                      CabMov.Codigo, TI.cp_IdEmpresa, TI.cp_IdSucursal, TI.cp_IdControlProduccionObrero, CabMov.pr_nombre
FROM         dbo.prd_ControlProduccion_Obrero_x_in_movi_inve AS TI INNER JOIN
                      dbo.vwIn_Movi_Inven_CusCider_Cab AS CabMov ON TI.mv_IdEmpresa = CabMov.IdEmpresa AND TI.mv_IdSucursal = CabMov.IdSucursal AND 
                      TI.mv_IdBodega = CabMov.IdBodega AND TI.mv_IdMovi_inven_tipo = CabMov.IdMovi_inven_tipo AND TI.mv_IdNumMovi = CabMov.IdNumMovi
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[14] 2[20] 3) )"
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
         Begin Table = "TI"
            Begin Extent = 
               Top = 5
               Left = 351
               Bottom = 245
               Right = 588
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CabMov"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 245
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 4
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab';

