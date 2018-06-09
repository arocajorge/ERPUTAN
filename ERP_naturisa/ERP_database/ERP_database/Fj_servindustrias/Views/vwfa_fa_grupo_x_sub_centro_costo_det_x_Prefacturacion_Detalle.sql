/*select *  from Fj_servindustrias.fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle
select * from Fj_servindustrias.fa_grupo_x_sub_centro_costo_det*/
CREATE VIEW Fj_servindustrias.vwfa_fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle
AS
SELECT        Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdEmpresa, Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdGrupo, 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto, 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.Estado, Fj_servindustrias.fa_grupo_x_sub_centro_costo.nom_Grupo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion.IdPeriodo
FROM            Fj_servindustrias.fa_grupo_x_sub_centro_costo INNER JOIN
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo_det ON 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdEmpresa AND 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.IdGrupo = Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdGrupo INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc INNER JOIN
                         Fj_servindustrias.vwfa_Prefacturacion_x_detalle_x_centro_subCentro ON 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto = Fj_servindustrias.vwfa_Prefacturacion_x_detalle_x_centro_subCentro.IdCentro_Costo AND 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto_sub_centro_costo = Fj_servindustrias.vwfa_Prefacturacion_x_detalle_x_centro_subCentro.IdCentroCosto_sub_centro_costo
                          INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion ON 
                         Fj_servindustrias.vwfa_Prefacturacion_x_detalle_x_centro_subCentro.IdEmpresa = Fj_servindustrias.fa_pre_facturacion.IdEmpresa AND 
                         Fj_servindustrias.vwfa_Prefacturacion_x_detalle_x_centro_subCentro.IdPreFacturacion = Fj_servindustrias.fa_pre_facturacion.IdPreFacturacion
GROUP BY Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdEmpresa, Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdGrupo, 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_grupo_x_sub_centro_costo_det.IdCentroCosto, 
                         Fj_servindustrias.fa_grupo_x_sub_centro_costo.Estado, Fj_servindustrias.fa_grupo_x_sub_centro_costo.nom_Grupo, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, Fj_servindustrias.fa_pre_facturacion.IdPeriodo
HAVING        (Fj_servindustrias.fa_grupo_x_sub_centro_costo.Estado = 1)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'  Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[5] 4[43] 2[25] 3) )"
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
         Begin Table = "fa_grupo_x_sub_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_grupo_x_sub_centro_costo_det (Fj_servindustrias)"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwfa_Prefacturacion_x_detalle_x_centro_subCentro (Fj_servindustrias)"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_pre_facturacion (Fj_servindustrias)"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 3495
         Width = 1500
       ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle';

