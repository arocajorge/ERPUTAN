CREATE VIEW Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo_x_Registro
AS
SELECT        dbo.Af_Activo_fijo.IdEmpresa, dbo.Af_Activo_fijo.IdActivoFijo, dbo.Af_Activo_fijo.Af_Nombre, dbo.Af_Activo_fijo.IdCentroCosto, 
                         dbo.Af_Activo_fijo.IdCentroCosto_sub_centro_costo, dbo.ct_punto_cargo.nom_punto_cargo, 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.Estado AS Estado_Ubicacion, 
                         dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.Af_Catalogo.Descripcion AS nom_UnidadFact, Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC, 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC, Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdEmpresa_Scc, 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdCentroCosto_Scc, 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo_Scc, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli, 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc, Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdUnidadFact_cat, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdRegistro
FROM            Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af INNER JOIN
                         dbo.Af_Catalogo ON Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdUnidadFact_cat = dbo.Af_Catalogo.IdCatalogo LEFT OUTER JOIN
                         dbo.Af_Activo_fijo ON Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdActivoFijo = dbo.Af_Activo_fijo.IdActivoFijo LEFT OUTER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdEmpresa_Scc = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdCentroCosto_Scc = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo_Scc = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo
                          INNER JOIN
                         dbo.ct_centro_costo ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON dbo.ct_centro_costo.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc AND 
                         dbo.ct_centro_costo.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc INNER JOIN
                         dbo.fa_cliente ON Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = dbo.fa_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona ON 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdEmpresa_AF AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdActivoFijo_AF AND 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdEmpresa_Scc AND 
                         dbo.Af_Activo_fijo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo_Scc LEFT
                          OUTER JOIN
                         dbo.ct_punto_cargo INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON dbo.ct_punto_cargo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                         dbo.ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC ON 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwAf_Activo_fijo_x_ct_centro_costo_x_Registro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'industrias)"
            Begin Extent = 
               Top = 487
               Left = 535
               Bottom = 616
               Right = 744
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 475
               Left = 206
               Bottom = 604
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1191
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1455
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo_x_ct_punto_cargo (Fj_servindustrias)"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1323
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
      Begin ColumnWidths = 24
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 6645
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwAf_Activo_fijo_x_ct_centro_costo_x_Registro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[76] 4[3] 2[15] 3) )"
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
         Begin Table = "fa_registro_unidades_x_equipo_det_ini_x_Af (Fj_servindustrias)"
            Begin Extent = 
               Top = 3
               Left = 262
               Bottom = 149
               Right = 471
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Catalogo"
            Begin Extent = 
               Top = 17
               Left = 17
               Bottom = 146
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 0
               Left = 529
               Bottom = 438
               Right = 758
            End
            DisplayFlags = 280
            TopColumn = 52
         End
         Begin Table = "Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 666
               Bottom = 135
               Right = 952
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 6
               Left = 990
               Bottom = 135
               Right = 1253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 444
               Left = 957
               Bottom = 573
               Right = 1166
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_x_ct_centro_costo (Fj_serv', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwAf_Activo_fijo_x_ct_centro_costo_x_Registro';

