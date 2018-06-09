CREATE view vwROL_Rpt019 as
SELECT        dbo.ro_rol.IdEmpresa, dbo.ro_rol.IdNominaTipo, dbo.ro_rol.IdNominaTipoLiqui, dbo.ro_rol.Descripcion, dbo.ro_rol.Observacion, dbo.ro_rol.Cerrado, 
                         dbo.ro_Departamento.de_descripcion, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rol_detalle.IdRubro, dbo.ro_rol_detalle.Orden, dbo.ro_rol_detalle.rub_visible_reporte, 
                         dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, dbo.ro_empleado.em_codigo, 
                         dbo.ro_Departamento.IdDepartamento, dbo.ro_area.IdArea, dbo.ro_Division.IdDivision, dbo.ro_area.Descripcion AS Area, dbo.ro_Division.Descripcion AS Division, 
                         dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, dbo.ro_periodo.pe_estado, dbo.ro_Nomina_Tipo.Descripcion AS Nomina, dbo.ro_rol.IdPeriodo, 
                         dbo.ro_rubro_tipo.ru_codRolGen, dbo.tb_persona.pe_apellido, dbo.tb_empresa.codigo, dbo.tb_empresa.em_nombre, dbo.tb_empresa.RazonSocial, 
                         dbo.tb_empresa.NombreComercial, dbo.tb_empresa.ContribuyenteEspecial, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_rubro_tipo.NombreCorto, 
                         dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina, dbo.ro_rol_detalle.Valor, dbo.tb_sucursal.Su_Descripcion
FROM            dbo.ro_rol INNER JOIN
                         dbo.ro_rol_detalle ON dbo.ro_rol.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_rol.IdNominaTipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND dbo.ro_rol.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_Division ON dbo.ro_rol.IdEmpresa = dbo.ro_Division.IdEmpresa INNER JOIN
                         dbo.ro_area ON dbo.ro_Division.IdEmpresa = dbo.ro_area.IdEmpresa AND dbo.ro_Division.IdDivision = dbo.ro_area.IdDivision INNER JOIN
                         dbo.ro_periodo ON dbo.ro_rol.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_rol.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_rol.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND dbo.ro_rol_detalle.IdNominaTipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo AND 
                         dbo.ro_rol.IdNominaTipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro AND dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa INNER JOIN
                         dbo.tb_empresa ON dbo.ro_Departamento.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.ro_Nomina_Tipoliqui ON dbo.ro_rol.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND 
                         dbo.ro_rol.IdNominaTipo = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo AND dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui AND 
                         dbo.ro_Nomina_Tipo.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND 
                         dbo.ro_Nomina_Tipo.IdNomina_Tipo = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo INNER JOIN
                         dbo.tb_sucursal ON dbo.ro_empleado.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.ro_empleado.IdSucursal = dbo.tb_sucursal.IdSucursal AND 
                         dbo.tb_empresa.IdEmpresa = dbo.tb_sucursal.IdEmpresa