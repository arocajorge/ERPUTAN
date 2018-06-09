CREATE view vwROL_Rpt001 as 
SELECT        dbo.vwro_empleadoXdepXcargo.IdEmpresa, dbo.vwro_empleadoXdepXcargo.IdEmpleado, dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, 
                         dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, 
                         dbo.vwro_empleadoXdepXcargo.CodigoSectorialIESS, dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, dbo.vwro_empleadoXdepXcargo.IdDivision, 
                         dbo.vwro_empleadoXdepXcargo.IdSucursal, dbo.vwro_empleadoXdepXcargo.Sucursal, dbo.ro_Division.Descripcion AS Division, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.em_fecha_ingreso, 
                         dbo.vwro_empleadoXdepXcargo.em_fechaIngaRol, dbo.vwro_empleadoXdepXcargo.em_foto, dbo.vwro_empleadoXdepXcargo.es_AcreditaHorasExtras, 
                         dbo.vwro_empleadoXdepXcargo.por_discapacidad, dbo.vwro_empleadoXdepXcargo.carnet_conadis, dbo.vwro_empleadoXdepXcargo.pe_sexo, 
                         dbo.vwro_empleadoXdepXcargo.em_empEspecial, dbo.vwro_empleadoXdepXcargo.pe_direccion, dbo.vwro_empleadoXdepXcargo.pe_telefonoCasa, 
                         dbo.vwro_empleadoXdepXcargo.pe_celular, dbo.vwro_empleadoXdepXcargo.IdEstadoCivil, dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.Apellido, dbo.vwro_empleadoXdepXcargo.Nombre,
                             (SELECT        MAX(SueldoActual) AS Expr1
                               FROM            dbo.ro_empleado_historial_Sueldo
                               WHERE        (IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa) AND (IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado)) AS Sueldo_Actual, 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.vwro_empleadoXdepXcargo.IdDepartamento, dbo.vwro_empleadoXdepXcargo.IdCargo
FROM            dbo.vwro_empleadoXdepXcargo INNER JOIN
                         dbo.ro_Division ON dbo.vwro_empleadoXdepXcargo.IdDivision = dbo.ro_Division.IdDivision AND 
                         dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_Division.IdEmpresa INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.vwro_empleadoXdepXcargo.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado