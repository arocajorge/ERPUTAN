CREATE VIEW dbo.vwin_devolucion_inven
AS
SELECT        dbo.in_devolucion_inven.IdEmpresa, dbo.in_devolucion_inven.IdDev_Inven, dbo.in_devolucion_inven.cod_Dev_Inven, dbo.in_devolucion_inven.Fecha, dbo.in_devolucion_inven.Devuelve_toda_tran, 
                         dbo.in_devolucion_inven.estado, dbo.in_devolucion_inven.IdSucursal_movi_inven, dbo.in_devolucion_inven.IdMovi_inven_tipo, dbo.in_devolucion_inven.IdNumMovi, dbo.in_devolucion_inven.IdUsuario, 
                         dbo.in_devolucion_inven.Fecha_Transac, dbo.in_devolucion_inven.IdUsuarioUltModi, dbo.in_devolucion_inven.Fecha_UltMod, dbo.in_devolucion_inven.IdusuarioUltAnu, dbo.in_devolucion_inven.Fecha_UltAnu, 
                         dbo.in_devolucion_inven.nom_pc, dbo.in_devolucion_inven.ip, dbo.in_devolucion_inven.observacion, dbo.in_devolucion_inven.MotivoAnulacion, dbo.tb_sucursal.Su_Descripcion AS nom_sucursal
FROM            dbo.tb_sucursal INNER JOIN
                         dbo.in_devolucion_inven ON dbo.tb_sucursal.IdEmpresa = dbo.in_devolucion_inven.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.in_devolucion_inven.IdSucursal_movi_inven
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_devolucion_inven';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[3] 2[50] 3) )"
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
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 37
               Left = 390
               Bottom = 167
               Right = 620
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_devolucion_inven"
            Begin Extent = 
               Top = 31
               Left = 666
               Bottom = 346
               Right = 875
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
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwin_devolucion_inven';

