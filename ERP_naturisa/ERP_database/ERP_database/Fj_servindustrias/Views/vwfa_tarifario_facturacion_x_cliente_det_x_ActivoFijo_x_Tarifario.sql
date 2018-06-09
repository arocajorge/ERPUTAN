CREATE VIEW Fj_servindustrias.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario
AS
SELECT        dbo.Af_Activo_fijo.IdEmpresa, dbo.Af_Activo_fijo.IdActivoFijo, dbo.Af_Activo_fijo.CodActivoFijo, dbo.Af_Activo_fijo.Af_Nombre, dbo.Af_Activo_fijo.IdActijoFijoTipo, 
                         dbo.Af_Activo_fijo.IdDepartamento, dbo.ro_Departamento.de_descripcion, Af_Catalogo_2.Descripcion AS Marca, Af_Catalogo_1.Descripcion AS Modelo, 
                         dbo.Af_Activo_fijo.Af_NumSerie, dbo.Af_Activo_fijo.Af_fecha_compra, dbo.Af_Activo_fijo.Af_fecha_ini_depre, dbo.Af_Activo_fijo.Af_fecha_fin_depre, 
                         dbo.Af_Activo_fijo.Af_Costo_historico, dbo.Af_Activo_fijo.Af_costo_compra, dbo.Af_Activo_fijo.Af_Vida_Util, dbo.Af_Activo_fijo.Af_Meses_depreciar, 
                         dbo.Af_Activo_fijo.Af_porcentaje_deprec, dbo.Af_Activo_fijo.Af_NumSerie_Motor, dbo.Af_Activo_fijo.Af_NumSerie_Chasis, dbo.tb_sucursal.IdSucursal, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_Sucursal, dbo.Af_Activo_fijo_Categoria.Descripcion AS nom_Categoria, dbo.Af_Activo_fijo.Estado, 
                         dbo.Af_Encargado.nom_encargado, dbo.Af_Activo_fijo.Af_ValorUnidad_Actu, cat_Color.Descripcion AS nom_Color, dbo.Af_Activo_fijo.IdUnidadFact_cat, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.pe_nombreCompleto AS nom_Cliente, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_punto_cargo, Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_Centro_costo, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_UnidadFact, dbo.Af_Activo_fijo.IdCategoriaAF, dbo.Af_Activo_fijo.IdCentroCosto, 
                         dbo.Af_Activo_fijo.Af_ValorSalvamento, dbo.Af_Activo_fijo.Af_ValorResidual, 
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.nom_Centro_costo_sub_centro_costo, dbo.Af_Activo_fijo.Es_carroceria, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Num_empleado_relacionado, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Valor_x_Unidad, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Unidades_minimas
FROM            dbo.Af_Activo_fijo_Categoria RIGHT OUTER JOIN
                         dbo.tb_sucursal RIGHT OUTER JOIN
                         dbo.Af_Activo_fijo LEFT OUTER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario ON 
                         dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo LEFT OUTER JOIN
                         Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo ON dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.vwAf_Activo_fijo_x_ct_centro_costo.IdActivoFijo LEFT OUTER JOIN
                         dbo.Af_Catalogo AS cat_Color ON dbo.Af_Activo_fijo.IdCatalogo_Color = cat_Color.IdCatalogo LEFT OUTER JOIN
                         dbo.ro_Departamento ON dbo.Af_Activo_fijo.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.Af_Activo_fijo.IdDepartamento = dbo.ro_Departamento.IdDepartamento LEFT OUTER JOIN
                         dbo.Af_Catalogo AS Af_Catalogo_2 ON dbo.Af_Activo_fijo.IdCatalogo_Marca = Af_Catalogo_2.IdCatalogo LEFT OUTER JOIN
                         dbo.Af_Catalogo AS Af_Catalogo_1 ON dbo.Af_Activo_fijo.IdCatalogo_Modelo = Af_Catalogo_1.IdCatalogo ON 
                         dbo.tb_sucursal.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.Af_Activo_fijo.IdSucursal LEFT OUTER JOIN
                         dbo.Af_Encargado ON dbo.Af_Activo_fijo.IdEmpresa = dbo.Af_Encargado.IdEmpresa AND dbo.Af_Activo_fijo.IdEncargado = dbo.Af_Encargado.IdEncargado ON 
                         dbo.Af_Activo_fijo_Categoria.IdCategoriaAF = dbo.Af_Activo_fijo.IdCategoriaAF AND dbo.Af_Activo_fijo_Categoria.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Catalogo_2"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1191
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Catalogo_1"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1323
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Encargado"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1455
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[84] 4[5] 2[5] 3) )"
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
         Top = -349
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Af_Activo_fijo_Categoria"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 267
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 37
               Left = 440
               Bottom = 166
               Right = 703
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 456
               Left = 307
               Bottom = 697
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_tarifario_facturacion_x_cliente (Fj_servindustrias)"
            Begin Extent = 
               Top = 433
               Left = 48
               Bottom = 568
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwAf_Activo_fijo_x_ct_centro_costo (Fj_servindustrias)"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 324
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat_Color"', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario';

