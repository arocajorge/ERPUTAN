CREATE VIEW [dbo].[vwpre_PedidoXPresupuesto_det]
AS
SELECT     P.IdEmpresa, P.IdPedidoXPre, P.IdDepartamento, P.Fecha, P.Observacion, P.IdProveedor1, P.IdProveedor2, P.IdProveedor3, P.IdUsuario, PD.Secuencia_reg, 
                      PD.IdPresupuesto_pre, PD.IdAnio_pre, PD.Secuencia_pre, PD.Producto, PD.Cant, PD.CodEstadoAprobacion, PD.Cotizado, ISNULL(CT.pc_clave_corta, '') 
                      + '[' + RTRIM(LTRIM(ISNULL(CT.IdCtaCble, ''))) + '] - ' + RTRIM(LTRIM(ISNULL(CT.pc_Cuenta, ''))) + '/' + '[' + ISNULL(CC.IdCentroCosto, '') 
                      + '] - ' + RTRIM(LTRIM(ISNULL(CC.Centro_costo, ''))) + ' / [' + ISNULL(PR.CodRubro, '') + ']' + RTRIM(LTRIM(ISNULL(PR.NombreRubro, ''))) AS NPresupuesto_pre
FROM         dbo.pre_PedidoXPresupuesto AS P INNER JOIN
                      dbo.pre_PedidoXPresupuesto_det AS PD ON P.IdEmpresa = PD.IdEmpresa AND P.IdPedidoXPre = PD.IdPedidoXPre INNER JOIN
                      dbo.pre_presupuesto AS PR ON PR.IdEmpresa = P.IdEmpresa AND PD.IdPresupuesto_pre = PR.IdPresupuesto AND PD.IdAnio_pre = PR.IdAnio AND 
                      PD.Secuencia_pre = PR.Secuencia LEFT OUTER JOIN
                      dbo.vwct_plancta AS CT ON PR.IdEmpresa = CT.IdEmpresa AND PR.IdCtaCble = CT.IdCtaCble LEFT OUTER JOIN
                      dbo.vwct_centro_costo AS CC ON PR.IdCentroCosto = CC.IdCentroCosto AND CC.IdEmpresa = PR.IdEmpresa
WHERE     (P.Estado = 'A')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwpre_PedidoXPresupuesto_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwpre_PedidoXPresupuesto_det';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[44] 4[3] 2[35] 3) )"
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
         Begin Table = "P"
            Begin Extent = 
               Top = 8
               Left = 0
               Bottom = 175
               Right = 156
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "PD"
            Begin Extent = 
               Top = 12
               Left = 235
               Bottom = 192
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PR"
            Begin Extent = 
               Top = 0
               Left = 599
               Bottom = 155
               Right = 781
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "CT"
            Begin Extent = 
               Top = 6
               Left = 817
               Bottom = 125
               Right = 1008
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CC"
            Begin Extent = 
               Top = 53
               Left = 443
               Bottom = 172
               Right = 601
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
      Begin ColumnWidths = 16
         Width = 284
         Width = 1020
         Width = 1065
         Width = 870
         Width = 1455
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
         Width = 1500', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwpre_PedidoXPresupuesto_det';

