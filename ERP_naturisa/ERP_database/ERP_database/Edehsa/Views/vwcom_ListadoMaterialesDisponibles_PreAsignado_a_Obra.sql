CREATE VIEW Edehsa.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra
AS
SELECT Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdEmpresa, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdSucursal, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdBodega, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdMovi_inven_tipo, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdNumMovi, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.CodObra_preasignada, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.FechaReg, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Estado, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Usuario, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Motivo, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.lm_Observacion, dbo.tb_sucursal.Su_Descripcion, dbo.prd_Obra.Descripcion AS ob_descripcion
FROM     Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra INNER JOIN
                  dbo.prd_Obra ON Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.CodObra_preasignada = dbo.prd_Obra.CodObra INNER JOIN
                  dbo.tb_sucursal ON Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdSucursal = dbo.tb_sucursal.IdSucursal
GROUP BY dbo.tb_sucursal.Su_Descripcion, dbo.prd_Obra.Descripcion, dbo.tb_sucursal.IdSucursal, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdEmpresa, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdSucursal, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdBodega, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdMovi_inven_tipo, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.IdNumMovi, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.FechaReg, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Estado, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Usuario, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Motivo, 
                  Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.lm_Observacion, Edehsa.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.CodObra_preasignada
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[31] 2[20] 3) )"
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
         Begin Table = "com_ListadoMaterialesDisponibles_PreAsignado_a_Obra (Edehsa)"
            Begin Extent = 
               Top = 0
               Left = 287
               Bottom = 204
               Right = 882
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 0
               Left = 12
               Bottom = 229
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 6
               Left = 1027
               Bottom = 196
               Right = 1302
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
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 4344
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
', @level0type = N'SCHEMA', @level0name = N'Edehsa', @level1type = N'VIEW', @level1name = N'vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra';

