


CREATE VIEW [dbo].[vwfa_cliente]
AS
SELECT        dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_razonSocial, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, 
                         dbo.tb_persona.pe_telefonoOfic, dbo.tb_persona.pe_fax, dbo.tb_persona.pe_sexo, dbo.tb_persona.pe_Naturaleza, dbo.fa_cliente.IdEmpresa, dbo.fa_cliente.IdCliente, dbo.fa_cliente.IdPersona, 
                         dbo.fa_cliente.IdSucursal, dbo.fa_cliente.IdVendedor, dbo.fa_cliente.Idtipo_cliente, dbo.fa_cliente.IdTipoCredito, dbo.fa_cliente.cl_Cat_crediticia, dbo.fa_cliente.cl_plazo, dbo.fa_cliente.cl_porcentaje_descuento, 
                         dbo.fa_cliente.IdCtaCble_cxc, dbo.fa_cliente.cl_Garante, dbo.fa_cliente.cl_Cell_Garante, dbo.fa_cliente.cl_Mail_Garante, dbo.fa_cliente.cl_observacion, dbo.fa_cliente.IdCiudad, dbo.fa_cliente.cl_Cupo, 
                         dbo.fa_cliente.IdClienteRelacionado, dbo.fa_cliente.cl_LocalComercial, dbo.fa_cliente.cl_Rep_Legal, dbo.fa_cliente.cl_Mail_Rep_Legal, dbo.fa_cliente.cl_Cell_Rep_Legal, dbo.fa_cliente.cl_Ger_Gen, 
                         dbo.fa_cliente.cl_Mail_Ger_Gen, dbo.fa_cliente.cl_Cell_Ger_Gen, dbo.fa_cliente.cl_casilla, dbo.fa_cliente.cl_fax, dbo.fa_cliente.IdActividadComercial, dbo.fa_cliente.Estado, dbo.tb_persona.pe_fechaNacimiento, 
                         dbo.vwtb_Ciudad.Descripcion_Ciudad, dbo.tb_sucursal.Su_Descripcion, dbo.fa_cliente.IdCtaCble_Anti, dbo.tb_persona.pe_correo, dbo.tb_persona.pe_casilla, dbo.tb_persona.IdEstadoCivil, 
                         dbo.tb_persona.pe_estado, dbo.tb_persona.CodPersona, dbo.tb_persona.IdTipoDocumento, dbo.fa_cliente.Mail_Principal, dbo.fa_cliente.Mail_Secundario1, dbo.fa_cliente.Mail_Secundario2, 
                         dbo.fa_cliente.IdCentroCosto_CXC, dbo.fa_cliente.IdCentroCosto_Anticipo, dbo.vwtb_Ciudad.IdProvincia, dbo.vwtb_Ciudad.IdPais, dbo.fa_cliente.IdCtaCble_cxc_Credito, dbo.fa_cliente.IdCentroCosto_CXC_Credito, 
                         dbo.tb_persona.IdTipoPersona, dbo.tb_persona.pe_telefonoCasa, dbo.tb_persona.pe_telfono_Contacto, dbo.tb_persona.pe_celular, dbo.tb_persona.pe_telefonoInter, dbo.tb_persona.pe_correo_secundario1, 
                         dbo.tb_persona.pe_correo_secundario2, dbo.tb_persona.pe_celularSecundario, dbo.fa_cliente.Codigo, dbo.fa_cliente.IdParroquia
						 ,dbo.fa_cliente.es_empresa_relacionada
FROM            dbo.fa_cliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.vwtb_Ciudad ON dbo.vwtb_Ciudad.IdCiudad = dbo.fa_cliente.IdCiudad INNER JOIN
                         dbo.tb_sucursal ON dbo.fa_cliente.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.fa_cliente.IdSucursal = dbo.tb_sucursal.IdSucursal
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'50
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[4] 2[4] 3) )"
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
               Bottom = 241
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 37
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 150
               Left = 310
               Bottom = 411
               Right = 563
            End
            DisplayFlags = 280
            TopColumn = 24
         End
         Begin Table = "vwtb_Ciudad"
            Begin Extent = 
               Top = 112
               Left = 592
               Bottom = 241
               Right = 801
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 16
               Left = 853
               Bottom = 135
               Right = 1067
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
         Column = 2265
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
         Or = 13', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_cliente';

