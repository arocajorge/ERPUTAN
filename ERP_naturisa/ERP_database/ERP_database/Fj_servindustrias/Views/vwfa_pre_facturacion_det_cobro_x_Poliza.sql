CREATE VIEW Fj_servindustrias.vwfa_pre_facturacion_det_cobro_x_Poliza
AS
SELECT        Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo, 
                         dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPunto_cargo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Tipo_Cobro_Poliza_X, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdActivoFijo_pol_det, dbo.Af_Activo_fijo.Af_Nombre, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_cuota, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.cod_cuota_pol_cuota, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Cantidad, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Costo_Uni, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Aplica_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Por_Iva, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Valor_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Total, dbo.fa_cliente.IdCliente, dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, 
                         Fj_servindustrias.Af_Poliza_x_AF_det_cuota.IdEstadoFacturacion_cat, dbo.fa_catalogo.Nombre AS nom_EstadoFacturacion_cat, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Facturar, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_0, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdTarifario, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Porc_ganancia
FROM            Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza LEFT OUTER JOIN
                         dbo.fa_catalogo INNER JOIN
                         Fj_servindustrias.Af_Poliza_x_AF_det_cuota ON dbo.fa_catalogo.IdCatalogo = Fj_servindustrias.Af_Poliza_x_AF_det_cuota.IdEstadoFacturacion_cat ON 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_cuota = Fj_servindustrias.Af_Poliza_x_AF_det_cuota.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota = Fj_servindustrias.Af_Poliza_x_AF_det_cuota.IdPoliza AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.cod_cuota_pol_cuota = Fj_servindustrias.Af_Poliza_x_AF_det_cuota.cod_couta LEFT OUTER JOIN
                         dbo.Af_Activo_fijo ON Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_det = dbo.Af_Activo_fijo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdActivoFijo_pol_det = dbo.Af_Activo_fijo.IdActivoFijo LEFT OUTER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto ON 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = dbo.ct_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona ON 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Poliza';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'gin Extent = 
               Top = 22
               Left = 739
               Bottom = 151
               Right = 1002
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 142
               Left = 1029
               Bottom = 271
               Right = 1267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 246
               Left = 1023
               Bottom = 422
               Right = 1255
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Poliza';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[58] 4[5] 2[5] 3) )"
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
         Begin Table = "fa_catalogo"
            Begin Extent = 
               Top = 34
               Left = 19
               Bottom = 163
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pre_facturacion_det_cobro_x_Poliza (Fj_servindustrias)"
            Begin Extent = 
               Top = 10
               Left = 633
               Bottom = 429
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Poliza_x_AF_det_cuota (Fj_servindustrias)"
            Begin Extent = 
               Top = 9
               Left = 255
               Bottom = 259
               Right = 475
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 172
               Left = 696
               Bottom = 301
               Right = 959
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 65
               Left = 1115
               Bottom = 194
               Right = 1324
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 10
               Left = 894
               Bottom = 139
               Right = 1103
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Be', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_cobro_x_Poliza';

