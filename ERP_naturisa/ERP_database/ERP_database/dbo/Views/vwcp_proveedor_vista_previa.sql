
CREATE VIEW [dbo].[vwcp_proveedor_vista_previa]
AS
SELECT        dbo.cp_proveedor.IdEmpresa, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.IdPersona, dbo.cp_proveedor.pr_codigo, dbo.cp_proveedor.pr_nombre, 
                         dbo.cp_proveedor.pr_girar_cheque_a, dbo.cp_proveedor.pr_contribuyenteEspecial, dbo.cp_proveedor.pr_plazo, dbo.cp_proveedor.representante_legal, 
                         dbo.cp_proveedor.pr_estado, dbo.cp_proveedor.IdCiudad, dbo.cp_proveedor.pr_nacionalidad, dbo.cp_proveedor.contacto, dbo.cp_proveedor.responsable, 
                         dbo.tb_persona.pe_Naturaleza, dbo.tb_persona.pe_razonSocial, dbo.tb_persona.IdTipoDocumento, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, 
                         dbo.cp_proveedor.IdCtaCble_CXP, dbo.ct_plancta.pc_Cuenta AS nom_CtaCble_CXP, dbo.cp_proveedor.IdCtaCble_Gasto, 
                         ct_plancta_1.pc_Cuenta AS nom_CtaCble_Gasto, dbo.cp_proveedor.IdCtaCble_Anticipo, ct_plancta_2.pc_Cuenta AS nom_CtaCble_Anticipo, 
                         dbo.cp_proveedor.IdClaseProveedor, dbo.cp_proveedor_clase.descripcion_clas_prove AS nom_ClaseProveedor, dbo.cp_proveedor.IdTipoServicio, 
                         dbo.cp_catalogo.Nombre AS nom_TipoServicio, dbo.cp_proveedor.IdTipoGasto, cp_catalogo_1.Nombre, dbo.vwtb_Ciudad.Descripcion_Ciudad AS nom_ubicacion, 
                         dbo.cp_proveedor.IdCentroCosot, dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, dbo.tb_persona.pe_celular, dbo.tb_persona.pe_correo, 
                         dbo.cp_proveedor.comentario, dbo.cp_proveedor.codigoSRI_ICE_Predeter, dbo.cp_codigo_SRI.co_descripcion AS nom_SRI_ICE_Predeter, 
                         dbo.cp_proveedor.codigoSRI_101_Predeter, cp_codigo_SRI_1.co_descripcion AS nom_SRI_101_Predeter, dbo.cp_proveedor.idCredito_Predeter, 
                         cp_codigo_SRI_2.co_descripcion AS nom_Credito_Predeter, dbo.tb_persona.pe_fax, dbo.tb_persona.pe_casilla, dbo.tb_persona.pe_telefonoCasa, 
                         dbo.tb_persona.pe_telefonoOfic, dbo.tb_persona.IdEstadoCivil, dbo.tb_persona.pe_fechaNacimiento, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.vwtb_Ciudad.IdPais, dbo.vwtb_Ciudad.IdProvincia
						 ,dbo.cp_proveedor.es_empresa_relacionada
FROM            dbo.cp_proveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona LEFT OUTER JOIN
                         dbo.cp_codigo_SRI AS cp_codigo_SRI_2 ON dbo.cp_proveedor.idCredito_Predeter = cp_codigo_SRI_2.IdCodigo_SRI LEFT OUTER JOIN
                         dbo.cp_codigo_SRI AS cp_codigo_SRI_1 ON dbo.cp_proveedor.codigoSRI_101_Predeter = cp_codigo_SRI_1.IdCodigo_SRI LEFT OUTER JOIN
                         dbo.cp_codigo_SRI ON dbo.cp_proveedor.codigoSRI_ICE_Predeter = dbo.cp_codigo_SRI.IdCodigo_SRI LEFT OUTER JOIN
                         dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND 
                         dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor LEFT OUTER JOIN
                         dbo.vwtb_Ciudad ON dbo.vwtb_Ciudad.IdCiudad = dbo.cp_proveedor.IdCiudad LEFT OUTER JOIN
                         dbo.cp_catalogo AS cp_catalogo_1 ON dbo.cp_proveedor.IdTipoGasto = cp_catalogo_1.IdCatalogo LEFT OUTER JOIN
                         dbo.cp_catalogo ON dbo.cp_proveedor.IdTipoServicio = dbo.cp_catalogo.IdCatalogo LEFT OUTER JOIN
                         dbo.ct_plancta AS ct_plancta_2 ON dbo.cp_proveedor.IdEmpresa = ct_plancta_2.IdEmpresa AND 
                         dbo.cp_proveedor.IdCtaCble_Anticipo = ct_plancta_2.IdCtaCble LEFT OUTER JOIN
                         dbo.ct_plancta ON dbo.cp_proveedor.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.cp_proveedor.IdCtaCble_CXP = dbo.ct_plancta.IdCtaCble LEFT OUTER JOIN
                         dbo.ct_plancta AS ct_plancta_1 ON dbo.cp_proveedor.IdEmpresa = ct_plancta_1.IdEmpresa AND 
                         dbo.cp_proveedor.IdCtaCble_Anticipo = ct_plancta_1.IdCtaCble LEFT OUTER JOIN
                         dbo.ct_centro_costo ON dbo.cp_proveedor.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.cp_proveedor.IdCentroCosot = dbo.ct_centro_costo.IdCentroCosto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_proveedor_vista_previa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'2
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_catalogo"
            Begin Extent = 
               Top = 416
               Left = 778
               Bottom = 545
               Right = 987
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta_2"
            Begin Extent = 
               Top = 352
               Left = 20
               Bottom = 481
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 297
               Left = 768
               Bottom = 426
               Right = 977
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta_1"
            Begin Extent = 
               Top = 400
               Left = 293
               Bottom = 529
               Right = 502
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 345
               Left = 599
               Bottom = 474
               Right = 808
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwtb_Ciudad"
            Begin Extent = 
               Top = 6
               Left = 1401
               Bottom = 135
               Right = 1610
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
      Begin ColumnWidths = 44
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
         Column = 7635
         Alias = 2895
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_proveedor_vista_previa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[4] 2[40] 3) )"
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
         Left = -1004
      End
      Begin Tables = 
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 1
               Left = 321
               Bottom = 425
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 1154
               Bottom = 429
               Right = 1363
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_codigo_SRI_2"
            Begin Extent = 
               Top = 223
               Left = 543
               Bottom = 352
               Right = 752
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_codigo_SRI_1"
            Begin Extent = 
               Top = 46
               Left = 722
               Bottom = 175
               Right = 931
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_codigo_SRI"
            Begin Extent = 
               Top = 193
               Left = 758
               Bottom = 322
               Right = 967
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor_clase"
            Begin Extent = 
               Top = 24
               Left = 19
               Bottom = 153
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_catalogo_1"
            Begin Extent = 
               Top = 219
               Left = 13
               Bottom = 348
               Right = 22', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_proveedor_vista_previa';

