CREATE VIEW dbo.VWRO_empleado
AS
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.ro_empleado.IdPersona, dbo.ro_empleado.IdSucursal, dbo.ro_empleado.em_codigo, 
                         dbo.ro_empleado.em_lugarNacimiento, dbo.ro_empleado.em_CarnetIees, dbo.ro_empleado.em_cedulaMil, dbo.ro_empleado.IdTipoEmpleado, 
                         dbo.ro_empleado.em_fecha_ingreso, dbo.ro_empleado.em_fechaSalida, dbo.ro_empleado.em_fechaTerminoContra, dbo.ro_empleado.em_fechaIngaRol, 
                         dbo.ro_empleado.IdTipoSangre, dbo.ro_empleado.em_SeAcreditaBanco, dbo.ro_empleado.em_tipoCta, dbo.ro_empleado.em_NumCta, 
                         dbo.ro_empleado.em_SepagaBeneficios, dbo.ro_empleado.em_SePagaConTablaSec, dbo.ro_empleado.em_estado, dbo.ro_empleado.em_sueldoBasicoMen, 
                         dbo.ro_empleado.em_SueldoExtraMen, dbo.ro_empleado.em_MovilizacionQuincenal, dbo.ro_empleado.IdCodSectorial, dbo.ro_empleado.IdDepartamento, 
                         dbo.ro_empleado.IdCargo, dbo.ro_empleado.em_foto, dbo.ro_empleado.IdTipoLicencia, dbo.ro_empleado.em_empEspecial, dbo.ro_empleado.em_pagoFdoRsv, 
                         dbo.ro_empleado.em_huella, dbo.ro_empleado.IdCtaCble_Emplea, dbo.ro_empleado.em_mail, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.IdTipoPersona, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion, 
                         dbo.tb_persona.pe_telefonoCasa, dbo.tb_persona.pe_telefonoOfic, dbo.tb_persona.pe_telefonoInter, dbo.tb_persona.pe_telfono_Contacto, 
                         dbo.tb_persona.pe_celular, dbo.tb_persona.pe_correo, dbo.tb_persona.pe_fax, dbo.tb_persona.pe_casilla, dbo.tb_persona.pe_sexo, dbo.vw_EstadoCivil.Codigo, 
                         dbo.vw_EstadoCivil.descripcion, dbo.tb_persona.pe_fechaNacimiento, sucursal.Su_Descripcion, dbo.ro_TablaSectorial.Actividad AS CodSectorial, 
                         dbo.ro_Departamento.de_descripcion AS Departamento, dbo.vwtb_Ciudad.Descripcion_Ciudad, dbo.vwtb_Ciudad.IdCiudad, dbo.tb_persona.IdTipoDocumento, 
                         dbo.vw_TipoDocumento.Id, dbo.ro_empleado.IdEmpleado_Supervisor, dbo.ro_empleado.IdCentroCosto, dbo.ro_empleado.IdBanco, dbo.ro_empleado.Archivo, 
                         dbo.ro_empleado.NombreArchivo, dbo.ro_empleado.IdArea, dbo.ro_empleado.IdDivision, dbo.ro_empleado.IdCentroCosto_sub_centro_costo, 
                         dbo.ro_empleado.Codigo_Biometrico, dbo.ro_empleado.por_discapacidad, dbo.ro_empleado.carnet_conadis, dbo.ro_empleado.recibi_uniforme, 
                         dbo.ro_empleado.talla_pant, dbo.ro_empleado.talla_zapato, dbo.ro_empleado.talla_camisa, dbo.ro_empleado.em_status, dbo.vwtb_Ciudad.IdProvincia, 
                         dbo.vwtb_Ciudad.IdPais, dbo.ro_cargo.ca_descripcion, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, ISNULL(dbo.ro_empleado.es_AcreditaHorasExtras, 0) 
                         AS es_AcreditaHorasExtras, ISNULL(dbo.ro_empleado.IdGrupo, 0) AS IdGrupo, dbo.ro_empleado.ValorAnticipo, dbo.ro_empleado.IdTipoAnticipo, 
                         dbo.ro_empleado.es_TruncarDecimalAnticipo, dbo.ro_empleado.CodigoSectorial, dbo.ro_empleado.em_AnticipoSueldo, 
                         dbo.ro_empleado.IdTipoSistemaSalarioNetoSRI, dbo.ro_empleado.IdTipoResidenciaSRI, dbo.ro_empleado.IdAplicaConvenioDobleImposicionSRI, 
                         dbo.ro_empleado.IdentDiscapacitadoSustitutoSRI, dbo.ro_empleado.IdTipoIdentDiscapacitadoSustitutoSRI, dbo.ro_empleado.IdCondicionDiscapacidadSRI, 
                         dbo.ro_empleado.Marca_Biometrico, dbo.ro_empleado.em_motivo_salisa, dbo.ro_catalogo.ca_descripcion AS EstadoEmpleado, 
                         dbo.ro_Nomina_Tipo.Descripcion AS Nomina
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.vw_EstadoCivil ON dbo.tb_persona.IdEstadoCivil = dbo.vw_EstadoCivil.Codigo INNER JOIN
                         dbo.tb_sucursal AS sucursal ON dbo.ro_empleado.IdSucursal = sucursal.IdSucursal AND dbo.ro_empleado.IdEmpresa = sucursal.IdEmpresa LEFT OUTER JOIN
                         dbo.ro_TablaSectorial ON dbo.ro_empleado.IdCodSectorial = dbo.ro_TablaSectorial.IdCodSectorial LEFT OUTER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.vwtb_Ciudad ON dbo.vwtb_Ciudad.IdCiudad = dbo.ro_empleado.IdCiudad INNER JOIN
                         dbo.vw_TipoDocumento ON dbo.tb_persona.IdTipoDocumento = dbo.vw_TipoDocumento.Codigo INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_catalogo ON dbo.ro_empleado.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = dbo.ro_Nomina_Tipo.IdNomina_Tipo LEFT OUTER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo LEFT OUTER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VWRO_empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N'      Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2610
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VWRO_empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_TipoDocumento"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1059
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1191
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Grupo_empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1323
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1455
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_catalogo"
            Begin Extent = 
               Top = 104
               Left = 669
               Bottom = 359
               Right = 878
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
      Begin ColumnWidths = 95
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VWRO_empleado';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[39] 2[7] 3) )"
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
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 414
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 55
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 427
               Left = 164
               Bottom = 523
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_EstadoCivil"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 399
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sucursal"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 531
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_TablaSectorial"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 663
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 795
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwtb_Ciudad"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 927
               Right = 247
            ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VWRO_empleado';

