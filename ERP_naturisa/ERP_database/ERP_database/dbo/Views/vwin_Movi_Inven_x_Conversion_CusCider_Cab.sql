CREATE VIEW [dbo].[vwin_Movi_Inven_x_Conversion_CusCider_Cab]
AS
SELECT     dbo.vwIn_Movi_Inven_CusCider_Cab.IdEmpresa, dbo.vwIn_Movi_Inven_CusCider_Cab.IdMovi_inven_tipo, dbo.vwIn_Movi_Inven_CusCider_Cab.IdBodega, 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdSucursal, dbo.vwIn_Movi_Inven_CusCider_Cab.CodMoviInven, dbo.vwIn_Movi_Inven_CusCider_Cab.cm_tipo, 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.cm_observacion, dbo.vwIn_Movi_Inven_CusCider_Cab.cm_fecha, dbo.vwIn_Movi_Inven_CusCider_Cab.Fecha_Transac, 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdProvedor, dbo.vwIn_Movi_Inven_CusCider_Cab.IdNumMovi, dbo.vwIn_Movi_Inven_CusCider_Cab.Su_Descripcion, 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.bo_Descripcion, dbo.vwIn_Movi_Inven_CusCider_Cab.Codigo, dbo.vwIn_Movi_Inven_CusCider_Cab.tm_descripcion, 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.pr_nombre, dbo.prd_conversion_cusCidersus_x_in_movi_inven.cv_IdEmpresa, 
                      dbo.prd_conversion_cusCidersus_x_in_movi_inven.cv_IdConversion
FROM         dbo.vwIn_Movi_Inven_CusCider_Cab INNER JOIN
                      dbo.prd_conversion_cusCidersus_x_in_movi_inven ON 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdEmpresa = dbo.prd_conversion_cusCidersus_x_in_movi_inven.IdEmpresa AND 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdSucursal = dbo.prd_conversion_cusCidersus_x_in_movi_inven.IdSucursal AND 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdBodega = dbo.prd_conversion_cusCidersus_x_in_movi_inven.IdBodega AND 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdMovi_inven_tipo = dbo.prd_conversion_cusCidersus_x_in_movi_inven.IdMovi_inven_tipo AND 
                      dbo.vwIn_Movi_Inven_CusCider_Cab.IdNumMovi = dbo.prd_conversion_cusCidersus_x_in_movi_inven.IdNumMovi
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_Conversion_CusCider_Cab';


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
         Begin Table = "vwIn_Movi_Inven_CusCider_Cab"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 245
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "prd_conversion_cusCidersus_x_in_movi_inven"
            Begin Extent = 
               Top = 20
               Left = 402
               Bottom = 245
               Right = 579
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_Movi_Inven_x_Conversion_CusCider_Cab';

