CREATE VIEW [dbo].[vwRo_Empleado_Nuevo_Sueldo]
AS
SELECT        dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, dbo.vwro_empleadoXdepXcargo.IdEmpresa, 
                         dbo.vwro_empleadoXdepXcargo.IdEmpleado, dbo.vwro_empleadoXdepXcargo.IdEmpleado_Supervisor, dbo.vwro_empleadoXdepXcargo.IdPersona, 
                         dbo.vwro_empleadoXdepXcargo.IdTipoEmpleado, dbo.vwro_empleadoXdepXcargo.em_codigo, dbo.vwro_empleadoXdepXcargo.em_lugarNacimiento, 
                         dbo.vwro_empleadoXdepXcargo.em_CarnetIees, dbo.vwro_empleadoXdepXcargo.em_cedulaMil, dbo.vwro_empleadoXdepXcargo.em_fecha_ingreso, 
                         dbo.vwro_empleadoXdepXcargo.em_fechaSalida, dbo.vwro_empleadoXdepXcargo.em_fechaTerminoContra, dbo.vwro_empleadoXdepXcargo.em_fechaIngaRol, 
                         dbo.vwro_empleadoXdepXcargo.em_SeAcreditaBanco, dbo.vwro_empleadoXdepXcargo.em_tipoCta, dbo.vwro_empleadoXdepXcargo.em_NumCta, 
                         dbo.vwro_empleadoXdepXcargo.em_SepagaBeneficios, dbo.vwro_empleadoXdepXcargo.em_SePagaConTablaSec, dbo.vwro_empleadoXdepXcargo.em_estado, 
                         dbo.vwro_empleadoXdepXcargo.em_sueldoBasicoMen, dbo.vwro_empleadoXdepXcargo.em_SueldoExtraMen, 
                         dbo.vwro_empleadoXdepXcargo.em_MovilizacionQuincenal, dbo.vwro_empleadoXdepXcargo.em_foto, dbo.vwro_empleadoXdepXcargo.em_empEspecial, 
                         dbo.vwro_empleadoXdepXcargo.em_pagoFdoRsv, dbo.vwro_empleadoXdepXcargo.em_huella, dbo.vwro_empleadoXdepXcargo.IdCodSectorial, 
                         dbo.vwro_empleadoXdepXcargo.IdDepartamento, dbo.vwro_empleadoXdepXcargo.IdTipoSangre, dbo.vwro_empleadoXdepXcargo.IdCargo, 
                         dbo.vwro_empleadoXdepXcargo.IdCtaCble_Emplea, dbo.vwro_empleadoXdepXcargo.IdUbicacion, dbo.vwro_empleadoXdepXcargo.em_mail, 
                         dbo.vwro_empleadoXdepXcargo.CodPersona, dbo.vwro_empleadoXdepXcargo.pe_Naturaleza, dbo.vwro_empleadoXdepXcargo.NomCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_razonSocial, dbo.vwro_empleadoXdepXcargo.Apellido, dbo.vwro_empleadoXdepXcargo.Nombre, 
                         dbo.vwro_empleadoXdepXcargo.IdTipoPersona, dbo.vwro_empleadoXdepXcargo.IdTipoDocumento, dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc, 
                         dbo.vwro_empleadoXdepXcargo.pe_direccion, dbo.vwro_empleadoXdepXcargo.pe_telefonoCasa, dbo.vwro_empleadoXdepXcargo.pe_telefonoOfic, 
                         dbo.vwro_empleadoXdepXcargo.pe_telefonoInter, dbo.vwro_empleadoXdepXcargo.pe_telfono_Contacto, dbo.vwro_empleadoXdepXcargo.pe_celular, 
                         dbo.vwro_empleadoXdepXcargo.pe_correo, dbo.vwro_empleadoXdepXcargo.pe_fax, dbo.vwro_empleadoXdepXcargo.pe_casilla, 
                         dbo.vwro_empleadoXdepXcargo.pe_sexo, dbo.vwro_empleadoXdepXcargo.IdEstadoCivil, dbo.vwro_empleadoXdepXcargo.pe_fechaNacimiento, 
                         dbo.vwro_empleadoXdepXcargo.pe_estado, dbo.vwro_empleadoXdepXcargo.pe_fechaCreacion, dbo.vwro_empleadoXdepXcargo.pe_fechaModificacion, 
                         dbo.vwro_empleadoXdepXcargo.Sucursal, dbo.vwro_empleadoXdepXcargo.IdSucursal, dbo.vwro_empleadoXdepXcargo.IdCentroCosto, 
                         dbo.vwro_empleadoXdepXcargo.IdBanco, dbo.vwro_empleadoXdepXcargo.IdTipoLicencia, dbo.vwro_empleadoXdepXcargo.IdArea, 
                         dbo.vwro_empleadoXdepXcargo.IdDivision, dbo.vwro_empleadoXdepXcargo.por_discapacidad, dbo.vwro_empleadoXdepXcargo.carnet_conadis, 
                         dbo.vwro_empleadoXdepXcargo.recibi_uniforme, dbo.vwro_empleadoXdepXcargo.talla_pant, dbo.vwro_empleadoXdepXcargo.talla_camisa, 
                         dbo.vwro_empleadoXdepXcargo.talla_zapato, dbo.vwro_empleadoXdepXcargo.em_status, dbo.vwro_empleadoXdepXcargo.IdCondicionDiscapacidadSRI, 
                         dbo.vwro_empleadoXdepXcargo.IdTipoIdentDiscapacitadoSustitutoSRI, dbo.vwro_empleadoXdepXcargo.IdentDiscapacitadoSustitutoSRI, 
                         dbo.vwro_empleadoXdepXcargo.IdAplicaConvenioDobleImposicionSRI, dbo.vwro_empleadoXdepXcargo.IdTipoResidenciaSRI, 
                         dbo.vwro_empleadoXdepXcargo.IdTipoSistemaSalarioNetoSRI, dbo.vwro_empleadoXdepXcargo.es_AcreditaHorasExtras, 
                         dbo.vwro_empleadoXdepXcargo.CodigoSectorialIESS, dbo.ro_empleado_historial_Sueldo.SueldoAnterior, dbo.ro_empleado_historial_Sueldo.SueldoActual, 
                         dbo.ro_empleado_historial_Sueldo.PorIncrementoSueldo, dbo.ro_empleado_historial_Sueldo.ValorIncrementoSueldo, dbo.ro_empleado_historial_Sueldo.Motivo, 
                         dbo.ro_empleado_historial_Sueldo.Fecha AS FechaNuevoSueldo, dbo.ro_empleado_historial_Sueldo.Secuencia
FROM            dbo.vwro_empleadoXdepXcargo INNER JOIN
                         dbo.ro_empleado_historial_Sueldo ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_empleado_historial_Sueldo.IdEmpresa AND 
                         dbo.vwro_empleadoXdepXcargo.IdEmpleado = dbo.ro_empleado_historial_Sueldo.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Empleado_Nuevo_Sueldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   Width = 1500
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
         Column = 2595
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Empleado_Nuevo_Sueldo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[34] 2[9] 3) )"
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
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 198
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "ro_empleado_historial_Sueldo"
            Begin Extent = 
               Top = 15
               Left = 461
               Bottom = 200
               Right = 674
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
      Begin ColumnWidths = 90
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
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Empleado_Nuevo_Sueldo';

