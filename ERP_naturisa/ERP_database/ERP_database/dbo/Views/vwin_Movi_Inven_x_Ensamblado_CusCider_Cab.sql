CREATE VIEW [dbo].[vwin_Movi_Inven_x_Ensamblado_CusCider_Cab]
AS
SELECT     CabMov.IdEmpresa, CabMov.IdMovi_inven_tipo, CabMov.IdBodega, CabMov.IdSucursal, CabMov.CodMoviInven, CabMov.cm_tipo, CabMov.cm_observacion, 
                      CabMov.cm_fecha, CabMov.IdNumMovi, CabMov.IdProvedor, CabMov.Fecha_Transac, CabMov.Su_Descripcion, CabMov.bo_Descripcion, CabMov.Codigo, 
                      CabMov.tm_descripcion, CabMov.pr_nombre, TI.en_IdEnsamblado, TI.en_IdSucursal, TI.en_IdEmpresa
FROM         dbo.vwIn_Movi_Inven_CusCider_Cab AS CabMov INNER JOIN
                      dbo.prd_ensamblado_cusCider_x_in_movi_inven AS TI ON CabMov.IdSucursal = TI.IdSucursal AND CabMov.IdEmpresa = TI.IdEmpresa AND 
                      CabMov.IdBodega = TI.IdBodega AND CabMov.IdMovi_inven_tipo = TI.IdMovi_inven_tipo AND CabMov.IdNumMovi = TI.IdNumMovi
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_Ensamblado_CusCider_Cab';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[23] 2[26] 3) )"
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
         Begin Table = "CabMov"
            Begin Extent = 
               Top = 63
               Left = 61
               Bottom = 182
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "TI"
            Begin Extent = 
               Top = 40
               Left = 446
               Bottom = 159
               Right = 623
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
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_Ensamblado_CusCider_Cab';

