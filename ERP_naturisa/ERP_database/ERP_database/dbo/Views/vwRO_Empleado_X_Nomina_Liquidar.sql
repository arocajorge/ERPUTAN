CREATE view [vwRO_Empleado_X_Nomina_Liquidar] as 
SELECT        dbo.vwRo_Empleado_X_Nomina.cargo, dbo.vwRo_Empleado_X_Nomina.departamento, dbo.vwRo_Empleado_X_Nomina.IdEmpresa, 
                         dbo.vwRo_Empleado_X_Nomina.IdEmpleado, dbo.vwRo_Empleado_X_Nomina.IdEmpleado_Supervisor, dbo.vwRo_Empleado_X_Nomina.IdPersona, 
                         dbo.vwRo_Empleado_X_Nomina.IdTipoEmpleado, dbo.vwRo_Empleado_X_Nomina.em_codigo, dbo.vwRo_Empleado_X_Nomina.em_lugarNacimiento, 
                         dbo.vwRo_Empleado_X_Nomina.em_CarnetIees, dbo.vwRo_Empleado_X_Nomina.em_cedulaMil, dbo.vwRo_Empleado_X_Nomina.em_fecha_ingreso, 
                         dbo.vwRo_Empleado_X_Nomina.em_fechaSalida, dbo.vwRo_Empleado_X_Nomina.em_fechaTerminoContra, dbo.vwRo_Empleado_X_Nomina.em_fechaIngaRol, 
                         dbo.vwRo_Empleado_X_Nomina.em_SeAcreditaBanco, dbo.vwRo_Empleado_X_Nomina.em_tipoCta, dbo.vwRo_Empleado_X_Nomina.em_NumCta, 
                         dbo.vwRo_Empleado_X_Nomina.em_SepagaBeneficios, dbo.vwRo_Empleado_X_Nomina.em_SePagaConTablaSec, dbo.vwRo_Empleado_X_Nomina.em_estado, 
                         dbo.vwRo_Empleado_X_Nomina.em_sueldoBasicoMen, dbo.vwRo_Empleado_X_Nomina.em_SueldoExtraMen, 
                         dbo.vwRo_Empleado_X_Nomina.em_MovilizacionQuincenal, dbo.vwRo_Empleado_X_Nomina.em_foto, dbo.vwRo_Empleado_X_Nomina.em_empEspecial, 
                         dbo.vwRo_Empleado_X_Nomina.em_pagoFdoRsv, dbo.vwRo_Empleado_X_Nomina.em_huella, dbo.vwRo_Empleado_X_Nomina.IdDepartamento, 
                         dbo.vwRo_Empleado_X_Nomina.IdTipoSangre, dbo.vwRo_Empleado_X_Nomina.IdCargo, dbo.vwRo_Empleado_X_Nomina.IdCodSectorial, 
                         dbo.vwRo_Empleado_X_Nomina.IdCtaCble_Emplea, dbo.vwRo_Empleado_X_Nomina.IdUbicacion, dbo.vwRo_Empleado_X_Nomina.em_mail, 
                         dbo.vwRo_Empleado_X_Nomina.CodPersona, dbo.vwRo_Empleado_X_Nomina.pe_Naturaleza, dbo.vwRo_Empleado_X_Nomina.NomCompleto, 
                         dbo.vwRo_Empleado_X_Nomina.Apellido, dbo.vwRo_Empleado_X_Nomina.pe_razonSocial, dbo.vwRo_Empleado_X_Nomina.Nombre, 
                         dbo.vwRo_Empleado_X_Nomina.IdTipoPersona, dbo.vwRo_Empleado_X_Nomina.IdTipoDocumento, dbo.vwRo_Empleado_X_Nomina.pe_cedulaRuc, 
                         dbo.vwRo_Empleado_X_Nomina.pe_direccion, dbo.vwRo_Empleado_X_Nomina.pe_telefonoCasa, dbo.vwRo_Empleado_X_Nomina.pe_telefonoOfic, 
                         dbo.vwRo_Empleado_X_Nomina.pe_telefonoInter, dbo.vwRo_Empleado_X_Nomina.pe_telfono_Contacto, dbo.vwRo_Empleado_X_Nomina.pe_celular, 
                         dbo.vwRo_Empleado_X_Nomina.pe_correo, dbo.vwRo_Empleado_X_Nomina.pe_fax, dbo.vwRo_Empleado_X_Nomina.pe_sexo, 
                         dbo.vwRo_Empleado_X_Nomina.pe_casilla, dbo.vwRo_Empleado_X_Nomina.IdEstadoCivil, dbo.vwRo_Empleado_X_Nomina.pe_fechaNacimiento, 
                         dbo.vwRo_Empleado_X_Nomina.pe_estado, dbo.vwRo_Empleado_X_Nomina.pe_fechaCreacion, dbo.vwRo_Empleado_X_Nomina.pe_fechaModificacion, 
                         dbo.vwRo_Empleado_X_Nomina.Sucursal, dbo.vwRo_Empleado_X_Nomina.IdSucursal, dbo.vwRo_Empleado_X_Nomina.IdTipoLicencia, 
                         dbo.vwRo_Empleado_X_Nomina.IdCentroCosto, dbo.vwRo_Empleado_X_Nomina.IdBanco, dbo.vwRo_Empleado_X_Nomina.Archivo, 
                         dbo.vwRo_Empleado_X_Nomina.NombreArchivo, dbo.vwRo_Empleado_X_Nomina.Codigo_Biometrico, dbo.vwRo_Empleado_X_Nomina.IdArea, 
                         dbo.vwRo_Empleado_X_Nomina.IdDivision, dbo.vwRo_Empleado_X_Nomina.IdCentroCosto_sub_centro_costo, dbo.vwRo_Empleado_X_Nomina.por_discapacidad, 
                         dbo.vwRo_Empleado_X_Nomina.carnet_conadis, dbo.vwRo_Empleado_X_Nomina.recibi_uniforme, dbo.vwRo_Empleado_X_Nomina.talla_pant, 
                         dbo.vwRo_Empleado_X_Nomina.talla_camisa, dbo.vwRo_Empleado_X_Nomina.talla_zapato, dbo.vwRo_Empleado_X_Nomina.em_status, 
                         dbo.vwRo_Empleado_X_Nomina.IdCondicionDiscapacidadSRI, dbo.vwRo_Empleado_X_Nomina.IdTipoIdentDiscapacitadoSustitutoSRI, 
                         dbo.vwRo_Empleado_X_Nomina.IdentDiscapacitadoSustitutoSRI, dbo.vwRo_Empleado_X_Nomina.IdAplicaConvenioDobleImposicionSRI, 
                         dbo.vwRo_Empleado_X_Nomina.IdTipoResidenciaSRI, dbo.vwRo_Empleado_X_Nomina.IdTipoSistemaSalarioNetoSRI, 
                         dbo.vwRo_Empleado_X_Nomina.es_AcreditaHorasExtras, dbo.vwRo_Empleado_X_Nomina.IdTipoAnticipo, dbo.vwRo_Empleado_X_Nomina.em_AnticipoSueldo, 
                         dbo.vwRo_Empleado_X_Nomina.CodigoSectorialIESS, dbo.vwRo_Empleado_X_Nomina.es_TruncarDecimalAnticipo, dbo.vwRo_Empleado_X_Nomina.IdTipoNomina, 
                         dbo.vwRo_Empleado_X_Nomina.Nomina, dbo.ro_contrato.FechaInicio, dbo.ro_contrato.FechaFin, dbo.ro_contrato.EstadoContrato,
                             ( 
							   SELECT        MAx(SueldoActual) 
                               FROM            dbo.ro_empleado_historial_Sueldo
                               WHERE        (dbo.vwRo_Empleado_X_Nomina.IdEmpresa = IdEmpresa) 
							   AND (dbo.vwRo_Empleado_X_Nomina.IdEmpleado = dbo.ro_empleado_historial_Sueldo.IdEmpleado)
							   
							   ) AS Sueldo_Actual,


                                                           (SELECT  dbo.ro_empleado_x_ro_rubro.IdEmpleado
                               FROM            dbo.ro_empleado_x_ro_rubro
                               WHERE        (dbo.vwRo_Empleado_X_Nomina.IdEmpresa = IdEmpresa) AND (dbo.vwRo_Empleado_X_Nomina.IdEmpleado = dbo.ro_empleado_x_ro_rubro.IdEmpleado)) AS si_tiene_rubros_fijo


FROM            dbo.vwRo_Empleado_X_Nomina INNER JOIN
                         dbo.ro_contrato ON dbo.vwRo_Empleado_X_Nomina.IdEmpresa = dbo.ro_contrato.IdEmpresa AND 
                         dbo.vwRo_Empleado_X_Nomina.IdEmpleado = dbo.ro_contrato.IdEmpleado
WHERE        (dbo.ro_contrato.EstadoContrato = 'ECT_ACT')