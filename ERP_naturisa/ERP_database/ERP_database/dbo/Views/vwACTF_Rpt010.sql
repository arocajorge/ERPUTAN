CREATE VIEW [dbo].[vwACTF_Rpt010]
AS
SELECT        cam.IdEmpresa, cam.IdCambioUbicacion, act.IdActivoFijo, act.Af_Nombre, tip.IdActijoFijoTipo, tip.Af_Descripcion, cam.IdSucursal_Actu, 
                         suc_act.Su_Descripcion AS SucActual, cam.IdSucursal_Ant, suc_ant.Su_Descripcion AS SucAnterior, cam.IdDepartamento_Actu, '' AS DepActual, 
                         cam.IdDepartamento_Ant, '' AS DepAnterior, cam.IdTipoCatalogo_Ubicacion_Actu, ubi_act.Descripcion AS UbiActual, 
                         cam.IdTipoCatalogo_Ubicacion_Ant, ubi_ant.Descripcion AS UbiAnterior, cam.MotivoCambio, cam.FechaCambio, cam.IdUsuario
FROM            dbo.Af_CambioUbicacion_Activo AS cam INNER JOIN
                         dbo.Af_Activo_fijo AS act ON cam.IdEmpresa = act.IdEmpresa AND cam.IdActivoFijo = act.IdActivoFijo INNER JOIN
                         dbo.Af_Activo_fijo_tipo AS tip ON tip.IdEmpresa = act.IdEmpresa AND tip.IdActijoFijoTipo = act.IdActijoFijoTipo INNER JOIN
                         dbo.tb_sucursal AS suc_act ON suc_act.IdEmpresa = cam.IdEmpresa AND suc_act.IdSucursal = cam.IdSucursal_Actu INNER JOIN
                         dbo.tb_sucursal AS suc_ant ON suc_ant.IdEmpresa = cam.IdEmpresa AND suc_ant.IdSucursal = cam.IdSucursal_Ant INNER JOIN
                         dbo.Af_Catalogo AS ubi_act ON ubi_act.IdCatalogo = cam.IdTipoCatalogo_Ubicacion_Actu INNER JOIN
                         dbo.Af_Catalogo AS ubi_ant ON ubi_ant.IdCatalogo = cam.IdTipoCatalogo_Ubicacion_Ant 
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwACTF_Rpt010';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'opColumn = 0
         End
         Begin Table = "ubi_act"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ubi_ant"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1191
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwACTF_Rpt010';


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
         Begin Table = "cam"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "act"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tip"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "suc_act"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "suc_ant"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rol_act"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rol_ant"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            End
            DisplayFlags = 280
            T', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwACTF_Rpt010';

