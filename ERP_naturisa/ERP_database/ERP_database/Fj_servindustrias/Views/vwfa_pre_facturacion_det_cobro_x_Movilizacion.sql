CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_cobro_x_Movilizacion
AS
SELECT        dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, dbo.Af_Activo_fijo.Af_Nombre, dbo.ct_punto_cargo.nom_punto_cargo, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPrefacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdActivoFijo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPunto_cargo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Movilizacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.secuencia, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Facturar, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdTarifario, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.Porc_ganancia
FROM            dbo.Af_Activo_fijo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentroCosto_sub_centro_costo
                          INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.fa_cliente ON dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON dbo.fa_cliente.IdCliente = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli AND 
                         dbo.fa_cliente.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli ON 
                         dbo.ct_centro_costo.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc AND 
                         dbo.ct_centro_costo.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc ON 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdActivoFijo INNER JOIN
                         dbo.ct_punto_cargo ON Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Movilizacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Movilizacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[78] 4[5] 2[5] 3) )"
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
         Top = -357
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 6
               Left = 428
               Bottom = 135
               Right = 691
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 58
               Left = 621
               Bottom = 187
               Right = 830
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pre_facturacion_det_cobro_x_Movilizacion (Fj_servindustrias)"
            Begin Extent = 
               Top = 338
               Left = 688
               Bottom = 561
               Right = 951
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Movilizacion';

