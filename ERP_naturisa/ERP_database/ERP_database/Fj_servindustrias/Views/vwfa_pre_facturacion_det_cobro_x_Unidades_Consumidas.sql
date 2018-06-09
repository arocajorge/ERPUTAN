CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_cobro_x_Unidades_Consumidas
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.secuencia, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPeriodo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPunto_cargo_PC, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdActivoFijo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Costo_Uni, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Aplica_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Valor_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Total, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Estado, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdTarifario, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Facturar, dbo.Af_Activo_fijo.Af_Nombre, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, dbo.ct_punto_cargo.nom_punto_cargo, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Porc_ganancia
FROM            dbo.ct_punto_cargo INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo INNER JOIN
                         dbo.Af_Activo_fijo ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF = dbo.Af_Activo_fijo.IdEmpresa AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF = dbo.Af_Activo_fijo.IdActivoFijo ON 
                         dbo.ct_punto_cargo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                         dbo.ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC RIGHT OUTER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto ON 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = dbo.ct_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona RIGHT OUTER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto_sub_centro_costo
                          ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdActivoFijo AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPunto_cargo_PC
                          AND Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Unidades_Consumidas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'8
               Left = 38
               Bottom = 927
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pre_facturacion_det_cobro_x_Unidades_Consumidas (Fj_servindustrias)"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1344
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 6
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Unidades_Consumidas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[85] 4[5] 2[5] 3) )"
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
         Top = -905
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo_x_ct_punto_cargo (Fj_servindustrias)"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 79', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Unidades_Consumidas';

