CREATE VIEW Fj_servindustrias.vwROLES_Rpt008
AS
SELECT        perio.IdEmpresa, em_x_nom.IdTipoNomina, perio.IdPeriodo, em_x_nom.IdEmpleado, perio.pe_anio, perio.pe_mes, person.pe_cedulaRuc, zona.zo_descripcion, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, disco.Disco, placa.Placa, ruta.ru_descripcion, emp.em_fechaIngaRol, person.pe_nombreCompleto, 
                         cargo.ca_descripcion, dbo.ro_rubro_tipo.ru_descripcion AS rubro, param_repo.Orden, param_repo.Id_Catalogo, perio.pe_FechaIni, perio.pe_FechaFin, 
                         dbo.ro_catalogo.ca_descripcion AS Estado, ISNULL
                             ((SELECT        Valor
                                 FROM            dbo.vwRo_Rol_Detalle AS R_det
                                 WHERE        (IdNominaTipo = param_repo.IdNomina_Tipo) AND (IdNominaTipoLiqui = param_repo.IdNomina_tipo_Liq) AND (IdRubro = param_repo.IdRubro) AND 
                                                          (IdEmpleado = em_x_nom.IdEmpleado) AND (pe_anio = perio.pe_anio) AND (pe_mes = perio.pe_mes)), 0) AS Valor, param_repo.Descripcion, 
                         ro_catalogo_1.ca_descripcion AS Grupo
FROM            dbo.ro_periodo AS perio INNER JOIN
                         Fj_servindustrias.ro_placa AS placa INNER JOIN
                         Fj_servindustrias.ro_disco AS disco INNER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS plan_x_ruta INNER JOIN
                         Fj_servindustrias.ro_zona AS zona ON plan_x_ruta.IdEmpresa = zona.IdEmpresa AND plan_x_ruta.IdZona = zona.IdZona AND 
                         plan_x_ruta.IdEmpresa = zona.IdEmpresa AND plan_x_ruta.IdZona = zona.IdZona AND plan_x_ruta.IdEmpresa = zona.IdEmpresa AND 
                         plan_x_ruta.IdZona = zona.IdZona AND plan_x_ruta.IdEmpresa = zona.IdEmpresa AND plan_x_ruta.IdZona = zona.IdZona AND 
                         plan_x_ruta.IdEmpresa = zona.IdEmpresa AND plan_x_ruta.IdZona = zona.IdZona AND plan_x_ruta.IdEmpresa = zona.IdEmpresa AND 
                         plan_x_ruta.IdZona = zona.IdZona AND plan_x_ruta.IdEmpresa = zona.IdEmpresa AND plan_x_ruta.IdZona = zona.IdZona ON 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = plan_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = plan_x_ruta.IdFuerza ON 
                         disco.IdEmpresa = plan_x_ruta.IdEmpresa AND disco.IdDisco = plan_x_ruta.IdDisco AND disco.IdEmpresa = plan_x_ruta.IdEmpresa AND 
                         disco.IdDisco = plan_x_ruta.IdDisco AND disco.IdEmpresa = plan_x_ruta.IdEmpresa AND disco.IdDisco = plan_x_ruta.IdDisco AND 
                         disco.IdEmpresa = plan_x_ruta.IdEmpresa AND disco.IdDisco = plan_x_ruta.IdDisco AND disco.IdEmpresa = plan_x_ruta.IdEmpresa AND 
                         disco.IdDisco = plan_x_ruta.IdDisco AND disco.IdEmpresa = plan_x_ruta.IdEmpresa AND disco.IdDisco = plan_x_ruta.IdDisco AND 
                         disco.IdEmpresa = plan_x_ruta.IdEmpresa AND disco.IdDisco = plan_x_ruta.IdDisco ON placa.IdEmpresa = plan_x_ruta.IdEmpresa AND 
                         placa.IdPlaca = plan_x_ruta.IdPlaca AND placa.IdEmpresa = plan_x_ruta.IdEmpresa AND placa.IdPlaca = plan_x_ruta.IdPlaca AND 
                         placa.IdEmpresa = plan_x_ruta.IdEmpresa AND placa.IdPlaca = plan_x_ruta.IdPlaca AND placa.IdEmpresa = plan_x_ruta.IdEmpresa AND 
                         placa.IdPlaca = plan_x_ruta.IdPlaca AND placa.IdEmpresa = plan_x_ruta.IdEmpresa AND placa.IdPlaca = plan_x_ruta.IdPlaca AND 
                         placa.IdEmpresa = plan_x_ruta.IdEmpresa AND placa.IdPlaca = plan_x_ruta.IdPlaca AND placa.IdEmpresa = plan_x_ruta.IdEmpresa AND 
                         placa.IdPlaca = plan_x_ruta.IdPlaca INNER JOIN
                         Fj_servindustrias.ro_ruta AS ruta ON plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND plan_x_ruta.IdRuta = ruta.IdRuta AND 
                         plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND plan_x_ruta.IdRuta = ruta.IdRuta AND plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND 
                         plan_x_ruta.IdRuta = ruta.IdRuta AND plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND plan_x_ruta.IdRuta = ruta.IdRuta AND 
                         plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND plan_x_ruta.IdRuta = ruta.IdRuta AND plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND 
                         plan_x_ruta.IdRuta = ruta.IdRuta AND plan_x_ruta.IdEmpresa = ruta.IdEmpresa AND plan_x_ruta.IdRuta = ruta.IdRuta INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina AS em_x_nom INNER JOIN
                         dbo.ro_empleado AS emp ON em_x_nom.IdEmpresa = emp.IdEmpresa AND em_x_nom.IdEmpleado = emp.IdEmpleado INNER JOIN
                         dbo.ro_cargo AS cargo ON emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo ON plan_x_ruta.IdEmpresa = em_x_nom.IdEmpresa AND plan_x_ruta.IdNomina_Tipo = em_x_nom.IdTipoNomina AND 
                         plan_x_ruta.IdEmpleado = em_x_nom.IdEmpleado ON perio.IdPeriodo = plan_x_ruta.IdPeriodo INNER JOIN
                         dbo.tb_persona AS person ON emp.IdPersona = person.IdPersona INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui ON perio.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         perio.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo AND perio.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         perio.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo AND perio.IdEmpresa = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa AND 
                         perio.IdPeriodo = dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo INNER JOIN
                         Fj_servindustrias.ro_parametros_reporte AS param_repo ON dbo.ro_rubro_tipo.IdRubro = param_repo.IdRubro ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = param_repo.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = param_repo.IdNomina_Tipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = param_repo.IdNomina_tipo_Liq INNER JOIN
                         dbo.ro_catalogo ON emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_catalogo AS ro_catalogo_1 ON param_repo.Id_Catalogo = ro_catalogo_1.CodCatalogo