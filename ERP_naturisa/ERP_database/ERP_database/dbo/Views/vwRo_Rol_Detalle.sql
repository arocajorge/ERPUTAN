CREATE VIEW dbo.vwRo_Rol_Detalle
AS
SELECT        dbo.ro_empleado.IdEmpleado, dbo.tb_persona.pe_cedulaRuc AS Ruc, dbo.tb_persona.pe_nombreCompleto AS Empleado, dbo.ro_rol_detalle.IdRubro, 
                         dbo.ro_rubro_tipo.ru_codRolGen AS Tag, dbo.ro_rubro_tipo.ru_descripcion AS DescRubroLargo, dbo.ro_rubro_tipo.NombreCorto AS DescNombreRubroCorto, 
                         dbo.ro_rol_detalle.Orden, dbo.ro_rol_detalle.Valor, dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina AS NominaLiqui, 
                         dbo.ro_Nomina_Tipo.Descripcion AS Nomina, dbo.tb_empresa.em_nombre AS Empresa, dbo.tb_empresa.IdEmpresa, 
                         dbo.ro_Departamento.de_descripcion AS Departamento, dbo.ro_rol.IdNominaTipo, dbo.ro_rol.IdNominaTipoLiqui, dbo.ro_rol.FechaIngresa, 
                         dbo.ro_rol_detalle.rub_visible_reporte, dbo.ro_rol_detalle.Observacion, dbo.ro_rol_detalle.TipoMovimiento, dbo.ro_rol.Cerrado AS EstadoRol, 
                         dbo.ro_rol.IdCentroCosto, dbo.ro_periodo.IdPeriodo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.ro_periodo.pe_FechaIni AS FechaIni, 
                         dbo.ro_periodo.pe_FechaFin AS FechaFin, dbo.ro_periodo_x_ro_Nomina_TipoLiqui.Cerrado, dbo.ro_periodo_x_ro_Nomina_TipoLiqui.Procesado, 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.Contabilizado, dbo.ro_rubro_tipo.rub_grupo, dbo.ro_empleado.IdSucursal, dbo.ro_empleado.IdDepartamento, 
                         dbo.ro_empleado.IdDivision, dbo.ro_empleado.IdArea, dbo.ro_empleado.em_status AS StatusEmpleado, dbo.ro_empleado.em_estado AS EstadoEmpleado, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_rubro_tipo.ru_tipo, dbo.ro_rubro_tipo.rub_aplica_IESS, dbo.ro_rubro_tipo.rub_nocontab, 
                         dbo.ro_rubro_tipo.rub_acumula, dbo.ro_rubro_tipo.rub_provision, dbo.ro_rubro_tipo.rub_antici, dbo.ro_rubro_tipo.rub_gencon, dbo.ro_rubro_tipo.rub_foract, 
                         dbo.ro_rubro_tipo.rub_tipcal
FROM            dbo.ro_rubro_tipo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_Nomina_Tipoliqui INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND 
                         dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_rol ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = dbo.ro_rol.IdEmpresa AND dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = dbo.ro_rol.IdNominaTipo AND 
                         dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui = dbo.ro_rol.IdNominaTipoLiqui ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rol.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdNominaTipo = dbo.ro_rol.IdNominaTipo AND dbo.ro_rol_detalle.IdNominaTipoLiqui = dbo.ro_rol.IdNominaTipoLiqui AND 
                         dbo.ro_rol_detalle.IdPeriodo = dbo.ro_rol.IdPeriodo INNER JOIN
                         dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona ON dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa ON dbo.ro_rubro_tipo.IdRubro = dbo.ro_rol_detalle.IdRubro AND 
                         dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.tb_empresa ON dbo.ro_Departamento.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui ON dbo.ro_rol.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         dbo.ro_rol.IdNominaTipo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo AND 
                         dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui AND 
                         dbo.ro_rol.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa