CREATE VIEW [Fj_servindustrias].[vwROL_Rpt002]
	AS
	 SELECT        NombreCompleto, Ruc, IdCargo, IdDivision, Empresa, RucEmpresa, IdEmpresa, IdNominaTipo, RubroDescripcion, IdNominaTipoLiqui, IdPeriodo, IdEmpleado, 
                         IdRubro, Ingreso, Egreso, Orden, Cargo, Division, IdSucursal, Sucursal, CodigoEmpleado, IdDepartamento, de_descripcion, RazonSocial, pe_apellido, 
                         pe_nombre, FechaPago, pe_FechaIni, pe_FechaFin, ru_tipo, em_status, NombreComercial,
                             (SELECT        Valor
                               FROM            dbo.ro_rol_detalle AS D
                               WHERE        (R.IdNominaTipo = IdNominaTipo) AND (R.IdNominaTipoLiqui = IdNominaTipoLiqui) AND (R.IdPeriodo = IdPeriodo) AND (R.IdEmpleado = IdEmpleado) 
                                                         AND (IdRubro = 2)) AS diastrabajados
FROM            dbo.vwro_Ro_rol_individual AS R