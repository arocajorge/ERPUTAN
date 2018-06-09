

CREATE VIEW [dbo].[vwfa_cliente_vista_previa]
AS
SELECT        dbo.fa_cliente.IdEmpresa, dbo.fa_cliente.IdCliente, dbo.fa_cliente.Codigo, dbo.fa_cliente.IdPersona, dbo.fa_cliente.IdSucursal, 
                         dbo.tb_sucursal.Su_Descripcion AS nom_sucursal, dbo.fa_cliente.IdTipoCredito, dbo.fa_cliente.cl_Cat_crediticia, dbo.fa_cliente.cl_plazo, 
                         dbo.fa_cliente.cl_porcentaje_descuento, dbo.fa_cliente.IdCtaCble_cxc, dbo.ct_plancta.pc_Cuenta AS nom_CtaCble_cxc, dbo.fa_cliente.IdCtaCble_Anti, 
                         ct_plancta_1.pc_Cuenta AS nom_CtaCble_Anti, dbo.fa_cliente.cl_Garante, dbo.fa_cliente.cl_Cell_Garante, dbo.fa_cliente.cl_Mail_Garante, 
                         dbo.fa_cliente.cl_observacion, dbo.fa_cliente.IdCiudad, dbo.vwtb_Ciudad.Descripcion_Ciudad, dbo.fa_cliente.cl_Cupo, dbo.fa_cliente.cl_casilla, 
                         dbo.fa_cliente.cl_fax, dbo.fa_cliente.Estado, dbo.fa_cliente.Mail_Principal, dbo.fa_cliente.Mail_Secundario1, dbo.fa_cliente.Mail_Secundario2, 
                         dbo.fa_cliente.IdCentroCosto_CXC, dbo.ct_centro_costo.Centro_costo AS nom_CentroCosto_CXC, dbo.fa_cliente.IdCentroCosto_Anticipo, 
                         ct_centro_costo_1.Centro_costo AS nom_CentroCosto_Anticipo, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_razonSocial, dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, dbo.tb_persona.pe_celular, dbo.tb_persona.pe_correo, 
                         dbo.tb_persona.pe_fax, dbo.tb_persona.pe_casilla, dbo.vwtb_Ciudad.IdProvincia, dbo.vwtb_Ciudad.IdPais, dbo.fa_cliente.IdCtaCble_cxc_Credito
						 ,dbo.fa_cliente.es_empresa_relacionada
FROM            dbo.fa_cliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.tb_sucursal ON dbo.fa_cliente.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.fa_cliente.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                         dbo.ct_plancta ON dbo.fa_cliente.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.fa_cliente.IdEmpresa = dbo.ct_plancta.IdEmpresa AND 
                         dbo.fa_cliente.IdCtaCble_cxc = dbo.ct_plancta.IdCtaCble LEFT OUTER JOIN
                         dbo.ct_plancta AS ct_plancta_1 ON dbo.fa_cliente.IdEmpresa = ct_plancta_1.IdEmpresa AND dbo.fa_cliente.IdEmpresa = ct_plancta_1.IdEmpresa AND 
                         dbo.fa_cliente.IdCtaCble_Anti = ct_plancta_1.IdCtaCble LEFT OUTER JOIN
                         dbo.vwtb_Ciudad ON dbo.fa_cliente.IdCiudad = dbo.vwtb_Ciudad.IdCiudad LEFT OUTER JOIN
                         dbo.ct_centro_costo ON dbo.fa_cliente.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND 
                         dbo.fa_cliente.IdCentroCosto_CXC = dbo.ct_centro_costo.IdCentroCosto LEFT OUTER JOIN
                         dbo.ct_centro_costo AS ct_centro_costo_1 ON dbo.fa_cliente.IdCentroCosto_Anticipo = ct_centro_costo_1.IdCentroCosto AND 
                         dbo.fa_cliente.IdEmpresa = ct_centro_costo_1.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente_vista_previa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'        DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_1"
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente_vista_previa';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[6] 2[35] 3) )"
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
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 25
               Left = 369
               Bottom = 255
               Right = 578
            End
            DisplayFlags = 280
            TopColumn = 19
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta_1"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwtb_Ciudad"
            Begin Extent = 
               Top = 6
               Left = 616
               Bottom = 135
               Right = 825
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            End
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente_vista_previa';

