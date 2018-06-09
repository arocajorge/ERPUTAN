CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_Fact_x_Gastos
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.secuencia, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPunto_cargo, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa_og, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdTipoCbte_Ogiro, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCbteCble_Ogiro, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Costo_Uni, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Aplica_Iva, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Valor_Iva, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Total, dbo.cp_proveedor.IdProveedor, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Proveedor, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, dbo.ct_punto_cargo.nom_punto_cargo, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, tb_persona_1.pe_nombreCompleto AS nom_Cliente, dbo.cp_orden_giro.co_factura, 
                         dbo.cp_orden_giro.co_FechaFactura, dbo.cp_orden_giro.co_observacion AS Descripcion, dbo.cp_proveedor.IdTipoGasto, dbo.cp_catalogo.Nombre AS nom_Gasto, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Facturar, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.SubTotal_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.SubTotal_0, Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.Porc_ganancia, 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdTarifario, Fj_servindustrias.fa_pre_facturacion.IdPeriodo
FROM            Fj_servindustrias.fa_pre_facturacion INNER JOIN
                         dbo.cp_catalogo INNER JOIN
                         dbo.tb_persona INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos INNER JOIN
                         dbo.cp_orden_giro ON Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa_og = dbo.cp_orden_giro.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro INNER JOIN
                         dbo.cp_proveedor ON dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor AND 
                         dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa ON dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona ON 
                         dbo.cp_catalogo.IdCatalogo = dbo.cp_proveedor.IdTipoGasto ON 
                         Fj_servindustrias.fa_pre_facturacion.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPreFacturacion LEFT OUTER JOIN
                         dbo.ct_punto_cargo ON Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto ON 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = dbo.ct_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona AS tb_persona_1 ON dbo.fa_cliente.IdPersona = tb_persona_1.IdPersona ON 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_Fact_x_Gastos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1191
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1323
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona_1"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1455
               Right = 270
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
      Begin ColumnWidths = 36
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
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_Fact_x_Gastos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[81] 4[4] 2[11] 3) )"
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
         Top = -477
         Left = 0
      End
      Begin Tables = 
         Begin Table = "fa_pre_facturacion (Fj_servindustrias)"
            Begin Extent = 
               Top = 224
               Left = 922
               Bottom = 353
               Right = 1131
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_catalogo"
            Begin Extent = 
               Top = 104
               Left = 81
               Bottom = 233
               Right = 290
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 130
               Left = 308
               Bottom = 259
               Right = 540
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pre_facturacion_det_Fact_x_Gastos (Fj_servindustrias)"
            Begin Extent = 
               Top = 24
               Left = 182
               Bottom = 399
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_giro"
            Begin Extent = 
               Top = 642
               Left = 733
               Bottom = 901
               Right = 974
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 660
               Left = 325
               Bottom = 898
               Right = 557
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 6
               Left =', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_Fact_x_Gastos';

