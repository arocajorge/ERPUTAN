CREATE VIEW [dbo].[vwRo_Cargo_Empleado_X_Periodo]
AS
SELECT        IngEgr.Id_Empresa, IngEgr.Id_Empleado, IngEgr.Id_Periodo, cargo.cargo, cargo.departamento, cargo.IdEmpresa, cargo.IdEmpleado, cargo.IdEmpleado_Supervisor, 
                         cargo.IdPersona, cargo.IdTipoEmpleado, cargo.em_codigo, cargo.em_lugarNacimiento, cargo.em_CarnetIees, cargo.em_cedulaMil, cargo.em_fecha_ingreso, 
                         cargo.em_fechaSalida, cargo.em_fechaTerminoContra, cargo.em_fechaIngaRol, cargo.em_SeAcreditaBanco, cargo.em_tipoCta, cargo.em_NumCta, 
                         cargo.em_SepagaBeneficios, cargo.em_SePagaConTablaSec, cargo.em_estado, cargo.em_sueldoBasicoMen, cargo.em_SueldoExtraMen, 
                         cargo.em_MovilizacionQuincenal, cargo.em_foto, cargo.em_empEspecial, cargo.em_pagoFdoRsv, cargo.em_huella, cargo.IdCodSectorial, cargo.IdDepartamento, 
                         cargo.IdTipoSangre, cargo.IdCargo, cargo.IdCtaCble_Emplea, cargo.IdUbicacion, cargo.em_mail, cargo.CodPersona, cargo.pe_Naturaleza, cargo.NomCompleto, 
                         cargo.pe_razonSocial, cargo.Apellido, cargo.Nombre, cargo.IdTipoPersona, cargo.IdTipoDocumento, cargo.pe_cedulaRuc, cargo.pe_direccion, 
                         cargo.pe_telefonoCasa, cargo.pe_telefonoOfic, cargo.pe_telefonoInter, cargo.pe_telfono_Contacto, cargo.pe_celular, cargo.pe_correo, cargo.pe_fax, cargo.pe_casilla, 
                         cargo.pe_sexo, cargo.IdEstadoCivil, cargo.pe_fechaNacimiento, cargo.pe_estado, cargo.pe_fechaCreacion, cargo.pe_fechaModificacion, cargo.Sucursal, 
                         cargo.IdSucursal, cargo.IdTipoLicencia, cargo.IdCentroCosto, cargo.IdBanco, cargo.Archivo, cargo.NombreArchivo, cargo.Codigo_Biometrico, 
                         cargo.IdArea, cargo.IdDivision, cargo.IdCentroCosto_sub_centro_costo, cargo.por_discapacidad, cargo.carnet_conadis, cargo.recibi_uniforme, cargo.talla_pant, 
                         cargo.talla_camisa, cargo.talla_zapato
FROM            (SELECT        IdEmpresa AS Id_Empresa, IdEmpleado AS Id_Empleado, IdPeriodo AS Id_Periodo
                          FROM            dbo.ro_Ing_Egre_x_Empleado
                          GROUP BY IdEmpresa, IdEmpleado, IdPeriodo) AS IngEgr INNER JOIN
                             (SELECT        cargo, departamento, IdEmpresa, IdEmpleado, IdEmpleado_Supervisor, IdPersona, IdTipoEmpleado, em_codigo, em_lugarNacimiento, 
                                                         em_CarnetIees, em_cedulaMil, em_fecha_ingreso, em_fechaSalida, em_fechaTerminoContra, em_fechaIngaRol, em_SeAcreditaBanco, em_tipoCta, 
                                                         em_NumCta, em_SepagaBeneficios, em_SePagaConTablaSec, em_estado, em_sueldoBasicoMen, em_SueldoExtraMen, em_MovilizacionQuincenal, 
                                                         em_foto, em_empEspecial, em_pagoFdoRsv, em_huella, IdCodSectorial, IdDepartamento, IdTipoSangre, IdCargo, IdCtaCble_Emplea, IdUbicacion, 
                                                         em_mail, CodPersona, pe_Naturaleza, NomCompleto, pe_razonSocial, Apellido, Nombre, IdTipoPersona, IdTipoDocumento, pe_cedulaRuc, 
                                                         pe_direccion, pe_telefonoCasa, pe_telefonoOfic, pe_telefonoInter, pe_telfono_Contacto, pe_celular, pe_correo, pe_fax, pe_casilla, pe_sexo, 
                                                         IdEstadoCivil, pe_fechaNacimiento, pe_estado, pe_fechaCreacion, pe_fechaModificacion, Sucursal, IdSucursal, IdTipoLicencia, IdCentroCosto, 
                                                         IdBanco, Archivo, NombreArchivo, Codigo_Biometrico, IdArea, IdDivision, IdCentroCosto_sub_centro_costo, por_discapacidad, carnet_conadis, 
                                                         recibi_uniforme, talla_pant, talla_camisa, talla_zapato
                               FROM            dbo.vwro_empleadoXdepXcargo) AS cargo ON IngEgr.Id_Empresa = cargo.IdEmpresa AND IngEgr.Id_Empleado = cargo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Cargo_Empleado_X_Periodo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[75] 4[8] 2[4] 3) )"
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
         Begin Table = "IngEgr"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 131
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cargo"
            Begin Extent = 
               Top = 18
               Left = 425
               Bottom = 387
               Right = 759
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Cargo_Empleado_X_Periodo';

