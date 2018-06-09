CREATE VIEW [dbo].[vwProd_GestionProductivaAceria_CusTalme]
AS
SELECT     dbo.tb_sucursal.Su_Descripcion, dbo.in_Producto.pr_descripcion, dbo.prod_GestionProductivaAcero_CusTalme.IdEmpresa, 
                      dbo.prod_GestionProductivaAcero_CusTalme.IdSucursal, dbo.prod_GestionProductivaAcero_CusTalme.IdGestionAceria, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Fecha, dbo.prod_GestionProductivaAcero_CusTalme.IdHorno, dbo.prod_GestionProductivaAcero_CusTalme.IdColada, 
                      dbo.prod_GestionProductivaAcero_CusTalme.chat_En_Horno, dbo.prod_GestionProductivaAcero_CusTalme.chat_Cargada, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Vaci_TempC, dbo.prod_GestionProductivaAcero_CusTalme.Vaci_acero, 
                      dbo.prod_GestionProductivaAcero_CusTalme.EnHor_Acero, dbo.prod_GestionProductivaAcero_CusTalme.EnHor_Perdida, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Comps_C, dbo.prod_GestionProductivaAcero_CusTalme.Comps_Si, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Comps_Mn, dbo.prod_GestionProductivaAcero_CusTalme.Comps_P, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Comps_S, dbo.prod_GestionProductivaAcero_CusTalme.Comps_SAE, 
                      dbo.prod_GestionProductivaAcero_CusTalme.AdiMet_Carburante, dbo.prod_GestionProductivaAcero_CusTalme.AdiMet_Cal, 
                      dbo.prod_GestionProductivaAcero_CusTalme.AdiMet_Desercoriante, dbo.prod_GestionProductivaAcero_CusTalme.Tiem_Encendido, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Tiem_Apagado, dbo.prod_GestionProductivaAcero_CusTalme.Tiem_Fundicion, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Tiem_Vaciado, dbo.prod_GestionProductivaAcero_CusTalme.Tiem_Total, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Ener_Ea, dbo.prod_GestionProductivaAcero_CusTalme.Ener_Er, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Ener_Total, dbo.prod_GestionProductivaAcero_CusTalme.Ferroa_FeSi, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Ferroa_FeMn, dbo.prod_GestionProductivaAcero_CusTalme.IndiHor_Rendimiento, 
                      dbo.prod_GestionProductivaAcero_CusTalme.IndiHor_Productividad, dbo.prod_GestionProductivaAcero_CusTalme.Tundish, 
                      dbo.prod_GestionProductivaAcero_CusTalme.InicioCC, dbo.prod_GestionProductivaAcero_CusTalme.FinCC, dbo.prod_GestionProductivaAcero_CusTalme.Tiempo, 
                      dbo.prod_GestionProductivaAcero_CusTalme.AceroCldo, dbo.prod_GestionProductivaAcero_CusTalme.Palanquilla, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Marrano, dbo.prod_GestionProductivaAcero_CusTalme.Escoria, 
                      dbo.prod_GestionProductivaAcero_CusTalme.PerdidaCC, dbo.prod_GestionProductivaAcero_CusTalme.RendtCC, 
                      dbo.prod_GestionProductivaAcero_CusTalme.ProductivCC, dbo.prod_GestionProductivaAcero_CusTalme.IdProducto_TipoPalanquilla, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Unidades, dbo.prod_GestionProductivaAcero_CusTalme.Longitud, 
                      dbo.prod_GestionProductivaAcero_CusTalme.PesoUnitario, dbo.prod_GestionProductivaAcero_CusTalme.PesoMetro, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Perdida, dbo.prod_GestionProductivaAcero_CusTalme.ProdRend, 
                      dbo.prod_GestionProductivaAcero_CusTalme.ProdProduct, dbo.prod_GestionProductivaAcero_CusTalme.Observacion, 
                      dbo.prod_GestionProductivaAcero_CusTalme.IdUsuario, dbo.prod_GestionProductivaAcero_CusTalme.Fecha_Transaccion, 
                      dbo.prod_GestionProductivaAcero_CusTalme.IdUsuarioUltModi, dbo.prod_GestionProductivaAcero_CusTalme.Fecha_UltMod, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Fecha_UltAnu, dbo.prod_GestionProductivaAcero_CusTalme.MotivoAnulacion, 
                      dbo.prod_GestionProductivaAcero_CusTalme.nom_pc, dbo.prod_GestionProductivaAcero_CusTalme.ip, dbo.prod_GestionProductivaAcero_CusTalme.Estado, 
                      dbo.prod_GestionProductivaAcero_CusTalme.Termopares, dbo.prod_GestionProductivaAcero_CusTalme.FeSiMn, 
                      dbo.prod_horno_CusTalme.descripcion AS Horno
FROM         dbo.prod_GestionProductivaAcero_CusTalme INNER JOIN
                      dbo.tb_sucursal ON dbo.prod_GestionProductivaAcero_CusTalme.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                      dbo.prod_GestionProductivaAcero_CusTalme.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                      dbo.in_Producto ON dbo.prod_GestionProductivaAcero_CusTalme.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                      dbo.prod_GestionProductivaAcero_CusTalme.IdProducto_TipoPalanquilla = dbo.in_Producto.IdProducto INNER JOIN
                      dbo.prod_horno_CusTalme ON dbo.prod_GestionProductivaAcero_CusTalme.IdHorno = dbo.prod_horno_CusTalme.IdHorno
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaAceria_CusTalme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'500
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
         Table = 4680
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaAceria_CusTalme';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[38] 2[3] 3) )"
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
         Begin Table = "prod_GestionProductivaAcero_CusTalme"
            Begin Extent = 
               Top = 11
               Left = 526
               Bottom = 207
               Right = 744
            End
            DisplayFlags = 280
            TopColumn = 55
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 134
               Left = 14
               Bottom = 253
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 14
               Left = 36
               Bottom = 133
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "prod_horno_CusTalme"
            Begin Extent = 
               Top = 30
               Left = 1006
               Bottom = 119
               Right = 1166
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
      Begin ColumnWidths = 67
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
         Width = 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwProd_GestionProductivaAceria_CusTalme';

