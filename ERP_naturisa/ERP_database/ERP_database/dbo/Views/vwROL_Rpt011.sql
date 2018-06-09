
CREATE view vwROL_Rpt011 as
SELECT        dbo.ro_archivos_bancos_generacion_x_empleado.IdEmpresa, dbo.ro_archivos_bancos_generacion_x_empleado.IdEmpleado, 
                         dbo.ro_archivos_bancos_generacion_x_empleado.IdArchivo, dbo.ro_archivos_bancos_generacion_x_empleado.Valor, 
                         dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS Cedula, 
                         dbo.vwro_empleadoXdepXcargo.em_NumCta AS NoCuenta, dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.em_tipoCta AS TipoCuenta, dbo.vwro_empleadoXdepXcargo.em_SeAcreditaBanco, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.IdBanco AS IdBancoEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.IdDivision AS IdDivisionEmpleado, dbo.vwro_empleadoXdepXcargo.IdArea, 
                         dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, dbo.ro_archivos_bancos_generacion.IdNomina, dbo.ro_archivos_bancos_generacion.IdNominaTipo,
                          dbo.ro_archivos_bancos_generacion.IdPeriodo, dbo.ro_Nomina_Tipo.Descripcion AS DescripcionNominaTipo, 
                         dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina AS DescripcionNominaTipoLiqui, dbo.ro_archivos_bancos_generacion.IdBanco AS IdBancoArchivo, 
                         dbo.ro_archivos_bancos_generacion.IdDivision AS IdDivisionArchivo, dbo.tb_banco.ba_descripcion AS DescripcionBancoEmpleado, 
                         dbo.ro_periodo.pe_FechaIni AS FechaInicial, dbo.ro_periodo.pe_FechaFin AS FechaFinal, dbo.vwro_empleadoXdepXcargo.Apellido, 
                         dbo.vwro_empleadoXdepXcargo.Nombre, dbo.ro_archivos_bancos_generacion_x_empleado.pagacheque
FROM            dbo.ro_archivos_bancos_generacion_x_empleado INNER JOIN
                         dbo.ro_archivos_bancos_generacion ON dbo.ro_archivos_bancos_generacion_x_empleado.IdEmpresa = dbo.ro_archivos_bancos_generacion.IdEmpresa AND 
                         dbo.ro_archivos_bancos_generacion_x_empleado.IdArchivo = dbo.ro_archivos_bancos_generacion.IdArchivo INNER JOIN
                         dbo.vwro_empleadoXdepXcargo ON dbo.ro_archivos_bancos_generacion_x_empleado.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND 
                         dbo.ro_archivos_bancos_generacion_x_empleado.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado INNER JOIN
                         dbo.ro_Nomina_Tipoliqui ON dbo.ro_archivos_bancos_generacion.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND 
                         dbo.ro_archivos_bancos_generacion.IdNomina = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo AND 
                         dbo.ro_archivos_bancos_generacion.IdNominaTipo = dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND 
                         dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_periodo ON dbo.ro_archivos_bancos_generacion.IdEmpresa = dbo.ro_periodo.IdEmpresa AND 
                         dbo.ro_archivos_bancos_generacion.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.tb_banco ON dbo.vwro_empleadoXdepXcargo.IdBanco = dbo.tb_banco.IdBanco