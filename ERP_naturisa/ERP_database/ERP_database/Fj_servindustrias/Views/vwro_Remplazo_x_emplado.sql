CREATE view Fj_servindustrias.vwro_Remplazo_x_emplado as 
SELECT        Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa, Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Id_remplazo, Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado_Remplazo, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Fecha, Fj_servindustrias.ro_Remplazo_x_emplado.Id_Motivo_Ausencia_Cat, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Id_Tipo_tipo_Remplazo_Cat, Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_Salida, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_Entrada, Fj_servindustrias.ro_Remplazo_x_emplado.Hora_salida, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Hora_regreso, Fj_servindustrias.ro_Remplazo_x_emplado.Observacion, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.IdUsuario, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.IdRubro, Fj_servindustrias.ro_Remplazo_x_emplado.Valor_descuento_empleado, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_descuenta_rol, Fj_servindustrias.ro_Remplazo_x_emplado.valor_x_dia_remplazo, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Total_pagar_remplazo, Fj_servindustrias.ro_Remplazo_x_emplado.Descuenta_rol, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.IdNomina_Tipo, Fj_servindustrias.ro_Remplazo_x_emplado.IdNomina_TipoLiqui, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.IdPeriodo, Fj_servindustrias.ro_Remplazo_x_emplado.IdNovedad, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Estado
FROM            Fj_servindustrias.ro_Remplazo_x_emplado INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona