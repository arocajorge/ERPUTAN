CREATE VIEW [dbo].[vwprod_GestionProductivaTechos_Talme]
AS
SELECT     dbo.in_Producto.pr_descripcion, dbo.prod_Turno.Descripcion, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdGestionProductiva, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdProducto_MateriaPrima, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdModeloProd, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.HrsTurno, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Tprep, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Despacho, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Factor, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Num_Personas, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Consumo, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Chatarra, dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdTurno, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdUsuario, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_Transac, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdUsuarioUltModi, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_UltMod, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdusuarioUltAnu, dbo.prod_GestionProductivaTechos_CusTalme_Cab.Fecha_UltAnu, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.nom_pc, dbo.prod_GestionProductivaTechos_CusTalme_Cab.ip, 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.Estado
FROM         dbo.prod_GestionProductivaTechos_CusTalme_Cab INNER JOIN
                      dbo.prod_Turno ON dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdTurno = dbo.prod_Turno.IdTurno AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa = dbo.prod_Turno.IdEmpresa INNER JOIN
                      dbo.in_Producto ON dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdProducto_MateriaPrima = dbo.in_Producto.IdProducto AND 
                      dbo.prod_GestionProductivaTechos_CusTalme_Cab.IdEmpresa = dbo.in_Producto.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprod_GestionProductivaTechos_Talme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprod_GestionProductivaTechos_Talme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[6] 4[51] 2[14] 3) )"
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
         Begin Table = "prod_GestionProductivaTechos_CusTalme_Cab"
            Begin Extent = 
               Top = 17
               Left = 443
               Bottom = 213
               Right = 653
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prod_Turno"
            Begin Extent = 
               Top = 9
               Left = 25
               Bottom = 128
               Right = 185
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 0
               Left = 883
               Bottom = 199
               Right = 1083
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
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
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprod_GestionProductivaTechos_Talme';

