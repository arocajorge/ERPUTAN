

CREATE  PROCEDURE  [Fj_servindustrias].[spFa_ReporteTransgandia]
	@IdEmpresa int,
	@IdPeriodo int 

AS
/*
declare 
	@IdEmpresa int,
	@IdPeriodo int
	set @IdEmpresa=1
	set @IdPeriodo=201610	

	*/
	
BEGIN -- PREPARANDO DATOS PARA REPORTE DE EGRESO DE BODEGA 
-- ELEIMINADO GASTOS POR FACTURA DE PROVEEDOR
	delete Fj_servindustrias.GatosTransgandia_Rpt where IdEmpresa=@IdEmpresa
	and IdPeriodo=@IdPeriodo
	-- INSERTO LAS FACTURAS POR PROVEEDOR POR MONTACARGA SEGUN SU GRUPO (FUERZA)
	insert into Fj_servindustrias.GatosTransgandia_Rpt
	(IdEmpresa,							IdPeriodo,							IdProveedor,									 secuencia,									
	 fecha,								Proveedor,							Cantidad ,										 Factura,
	 Descripcion,						Costounitario,						Total,											 Fuerza,
	 NombreServicio	)
	select 
	@IdEmpresa,							@IdPeriodo,							G.IdProveedor,									ROW_NUMBER() OVER (ORDER BY G.IdEmpresa)
	,G.co_FechaFactura,					G.nom_Proveedor,					G.Cantidad,										G.co_factura,
	G.Descripcion,						G.Costo_Uni,						G.Total,										ISNULL( F.IdFuerza,0),
	G.nom_Gasto
	FROM            Fj_servindustrias.vwfa_pre_facturacion_det_Fact_x_Gastos AS G LEFT OUTER JOIN
                         Fj_servindustrias.vwaf_x_fuerza_x_Periodo_x_Empleado AS F ON G.IdPunto_cargo = F.IdPunto_cargo_PC AND G.IdEmpresa = F.IdEmpresa AND 
                         G.IdPeriodo = F.IdPeriodo
						 and G.IdEmpresa=@IdEmpresa
						 and F.IdPeriodo=@IdPeriodo


end 

BEGIN -- PREPARANDO DATOS PARA DEPRECIACION
-- ELEIMINADO GASTOS POR FACTURA DE PROVEEDOR
	delete Fj_servindustrias.DepreciacionTransgandia_Rpt where IdEmpresa=@IdEmpresa
	and IdPeriodo=@IdPeriodo
	-- INSERTO LAS FACTURAS POR PROVEEDOR POR MONTACARGA SEGUN SU GRUPO (FUERZA)
	insert into Fj_servindustrias.DepreciacionTransgandia_Rpt
	(
	IdEmpresa,										IdPeriodo,											IdActivofijo,								   	 secuencia,
	Fecha_adquisicion,								Proveedor,											Factura ,										 Cantidad,
	Af_nombre,										Costo_Unitario_Camion,								Costo_unitario_carroceria,						 ValorSalvamento,
	TotalDepreciar,									DepreciacionMensual)	
	
	select
	 G.IdEmpresa,									@IdPeriodo,										G.IdActivoFijo,									ROW_NUMBER() OVER (ORDER BY G.IdEmpresa),
	 F.Af_fecha_compra_Cabezal,						F.Proveedor,										F.co_factura,									1,
	 F.Af_Nombre_Cabezal,							F.Af_costo_compra_Cabezal,							F.Af_costo_compra_Carroseria,					F.Af_ValorSalvamento_Cab+F.Af_ValorSalvamento_Carroseria,
	 (F.Af_costo_compra_Cabezal+F.Af_costo_compra_Carroseria)-(F.Af_ValorSalvamento_Cab+F.Af_ValorSalvamento_Carroseria), G.Total_depreciado_x_cobrar								
	FROM				  Fj_servindustrias.vwfa_pre_facturacion_det_Cobro_x_Depreciacion AS G inner join
                         Fj_servindustrias.vwaf_Activo_fijo_x_Af_Activo_fijo AS F ON G.IdActivoFijo = F.IdActivoFijo_Cabezal 
						 or G.IdActivoFijo=F.IdActivoFijo_Carroceria
						 and G.IdPeriodo=@IdPeriodo
						 and G.IdEmpresa=@IdPeriodo

						 
						 
						 

END


--select * from Fj_servindustrias.DepreciacionTransgandia_Rpt

--select * from Fj_servindustrias.vwFAC_FJ_Rpt008