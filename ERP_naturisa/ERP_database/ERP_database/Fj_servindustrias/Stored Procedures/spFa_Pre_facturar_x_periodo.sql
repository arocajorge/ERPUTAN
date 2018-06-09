

CREATE PROCEDURE [Fj_servindustrias].[spFa_Pre_facturar_x_periodo]
 @i_IdEmpresa int,
 @i_IdPrefacturacion numeric(18,0),
 @i_IdPeriodo int, 
 @i_IdEstado_Proceso varchar(20),
 @i_fecha date,
 @i_Observacion varchar(200)
AS

BEGIN
/*
declare  @i_IdEmpresa int
declare  @i_IdPrefacturacion numeric(18,0)
declare @i_IdPeriodo int
declare @i_IdEstado_Proceso varchar(20)
declare @i_fecha date
declare @i_Observacion varchar(200)


set @i_IdEmpresa =1
set @i_IdPrefacturacion =1
set @i_IdPeriodo =201705
set @i_IdEstado_Proceso ='EST_FAC_PENDI'
set @i_fecha =GETDATE()
set @i_Observacion =''
*/
declare @Unidades_Minima int
declare @w_FechaIni datetime 
declare @w_FechaFin datetime 

declare @W_Porce_Iva float
declare @W_Se_Cobra_Iva bit

select @W_Porce_Iva =Tipo_Imp.porcentaje from tb_parametro as Parame, tb_sis_Impuesto as Tipo_Imp where Parame.Valor=Tipo_Imp.IdCod_Impuesto
select @W_Se_Cobra_Iva =Se_Cobra_Iva  from Fj_servindustrias.fa_pre_facturacion_Parametro where IdEmpresa=@i_IdEmpresa
declare @w_Tipo_Cobro_Poliza_X  varchar(50)

select @w_FechaIni=pe_FechaIni,@w_FechaFin=pe_FechaFin  
from ct_periodo where IdEmpresa=@i_IdEmpresa
and IdPeriodo=@i_IdPeriodo

BEGIN /*===================== INSERT O UPDATE CABECERA =====================*/

IF (@i_IdPrefacturacion=0)
BEGIN --INSERT CABECERA
		SELECT @i_IdPrefacturacion = isnull(max(ID.IdPreFacturacion)+1,1) 
		from [Fj_servindustrias].fa_pre_facturacion as ID 
		where ID.IdEmpresa = @i_IdEmpresa and IdPeriodo=@i_IdPeriodo
		
		INSERT INTO [Fj_servindustrias].[fa_pre_facturacion]
		([IdEmpresa]			,[IdPreFacturacion]			,[IdPeriodo]			,[Observacion]			,[IdEstado_Proceso]			,[fecha]
		,[estado]	
		)
		values
		(@i_IdEmpresa			,@i_IdPrefacturacion		,@i_IdPeriodo			,@i_Observacion			,@i_IdEstado_Proceso		,@i_fecha
		,'A')

		--select @i_IdPeriodo  where @i_IdPeriodo not in (select @i_IdPeriodo from [Fj_servindustrias].fa_pre_facturacion where IdPeriodo=@i_IdPeriodo)
END
ELSE
BEGIN --UPDATE CABECERA
			--SET @w_IdPreFacturacion = @i_IdPrefacturacion


			UPDATE [Fj_servindustrias].[fa_pre_facturacion]
			   SET [Observacion] = @i_Observacion
				  ,[IdEstado_Proceso] = @i_IdEstado_Proceso
				  ,[fecha] = @i_fecha
			 WHERE IdEmpresa = @i_IdEmpresa and 
			 @i_IdPrefacturacion = IdPreFacturacion
END		

END

BEGIN /*===================== INSERT DETALLE EGRESOS =======================*/

		
		DELETE Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod 
		WHERE IdEmpresa = @i_IdEmpresa
		and IdPreFacturacion = @i_IdPrefacturacion



		INSERT INTO Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
		( 
		 IdEmpresa								, IdPreFacturacion,	secuencia					, IdCentro_Costo						, IdCentroCosto_sub_centro_costo, 						IdPunto_cargo
		,IdEmpresa_mov_inv						, IdSucursal_mov_inv							, IdBodega_mov_inv						, IdMovi_inven_tipo_mov_inv		
		,IdNumMovi_mov_inv, Secuencia_det		, observacion_det,								 Aplica_Iva, Por_Iva					,Cantidad							
		,Costo_Uni								,Subtotal										,Valor_Iva								,Total,
		Facturar,								IdTarifario										,Porc_ganancia
		)

		SELECT			
		in_Ing_Egr_Inven_det.IdEmpresa,			 @i_IdPrefacturacion,ROW_NUMBER() OVER (ORDER BY in_Ing_Egr_Inven_det.IdEmpresa) AS IdFila,in_Ing_Egr_Inven_det.IdCentroCosto,in_Ing_Egr_Inven_det.IdCentroCosto_sub_centro_costo, 
								 in_Ing_Egr_Inven_det.IdPunto_cargo, 
								 
	in_Ing_Egr_Inven_det.IdEmpresa , in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdBodega,  in_Ing_Egr_Inven_det.IdMovi_inven_tipo, 
	in_Ing_Egr_Inven_det.IdNumMovi, in_Ing_Egr_Inven_det.Secuencia,
	
	 in_Ing_Egr_Inven_det.dm_observacion, 0 , 
								 0 , in_Ing_Egr_Inven_det.dm_cantidad * - 1 , in_Ing_Egr_Inven_det.mv_costo, 0, 0, 0, 0, NULL, 0
		FROM            dbo.in_Ing_Egr_Inven INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND dbo.in_Ing_Egr_Inven.IdBodega = dbo.in_Ing_Egr_Inven_det.IdBodega AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND 
                         dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                         dbo.in_movi_inven_tipo ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                         dbo.tb_bodega ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                         dbo.tb_sucursal ON dbo.tb_bodega.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.tb_bodega.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli AND 
                         dbo.in_Ing_Egr_Inven_det.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc

		WHERE        (in_movi_inven_tipo.cm_tipo_movi = '-') 
			AND		(in_movi_inven_tipo.IdEmpresa = @i_IdEmpresa)
			and (in_Ing_Egr_Inven.cm_fecha between CAST( @w_FechaIni as date) and CAST( @w_FechaFin as date))
	
		update Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
		set Aplica_Iva=@W_Se_Cobra_Iva 
		,Por_Iva=@W_Porce_Iva
		where Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = @i_IdEmpresa and
		Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPrefacturacion = @i_IdPrefacturacion

		update Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
		set Subtotal=Cantidad*Costo_Uni
		,Valor_Iva=(Cantidad*Costo_Uni)*@W_Porce_Iva/100
		,Total=(Cantidad*Costo_Uni)+(Cantidad*Costo_Uni)*@W_Porce_Iva/100
		where Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Aplica_Iva=1 
		and	Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = @i_IdEmpresa and
		Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPrefacturacion = @i_IdPrefacturacion
		
		update Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
		set Subtotal=Cantidad*Costo_Uni
		,Valor_Iva=0
		,Total=(Cantidad*Costo_Uni)
		where Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.Aplica_Iva=0 and
		Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = @i_IdEmpresa and
		Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPrefacturacion = @i_IdPrefacturacion

		update Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
		set Facturar = A.se_fact_egreso_bodega
		,IdTarifario = A.IdTarifario
		,Porc_ganancia = A.porcentaje
		FROM(
				SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo, 
											Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo, 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_egreso_bodega, 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
				FROM            Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod INNER JOIN
											Fj_servindustrias.fa_cliente_x_ct_centro_costo ON 
											Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc AND 
											Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc INNER JOIN
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
											Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
											Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
											Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF AND 
											Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
											Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC INNER JOIN
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
											Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario
				WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
											and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
											AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
											AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
											) as A
		WHERE Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdEmpresa = @i_IdEmpresa
		and Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPreFacturacion = @i_IdPrefacturacion
		and a.IdCentro_Costo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentro_Costo
		and a.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdCentroCosto_sub_centro_costo
		and a.IdPunto_cargo = Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod.IdPunto_cargo
		
END

BEGIN /*===================== INSERT DETALLE GASTOS ========================*/


BEGIN /*===================== BORRANDO DETALLES GASTOS ============================*/

		DELETE [Fj_servindustrias].[fa_pre_facturacion_det_Fact_x_Gastos]
		WHERE	IdEmpresa = @i_IdEmpresa
		and IdPreFacturacion = @i_IdPrefacturacion
END				

		INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_Fact_x_Gastos]
		([secuencia]			  
		,[IdEmpresa]					,[IdPreFacturacion]					
		,[IdCentro_Costo]			,[IdCentroCosto_sub_centro_costo]   ,[IdPunto_cargo]
		,[IdEmpresa_og]				,[IdTipoCbte_Ogiro]		            ,[IdCbteCble_Ogiro]
		,[Cantidad]					,[Costo_Uni]				        ,[Subtotal]
		,[Aplica_Iva]				,[Por_Iva]				            ,[Valor_Iva]
		,[Total]					,[Facturar]
		,SubTotal_Iva				,SubTotal_0
		,[IdTarifario]				,[Porc_ganancia]			
		)

		SELECT  ROW_NUMBER() OVER (ORDER BY IdEmpresa) AS IdFila
				,IdEmpresa					,@i_IdPrefacturacion	
				,IdCentroCosto				,IdCentroCosto_sub_centro_costo		,0
				,IdEmpresa_Ogiro			,IdTipoCbte_Ogiro					,IdCbteCble_Ogiro	
				,Cantidad					,Subtotal_Iva						,Total	
				,@W_Se_Cobra_Iva			,Por_Iva							,Valor_Iva			
				,Total						,0
				,Subtotal_Iva				,Subtotal_SinIva	    
				,NULL						,0
		from (
SELECT                  cp_aprov_ing_bod.IdEmpresa ,/* ROW_NUMBER() OVER (ORDER BY cp_aprov_ing_bod.idempresa) AS IdFila,*/ com_orden_com_loc.IdCentroCosto, com_orden_com_loc.IdCentroCosto_sub_centro_costo, /*com_orden_com_loc.IdPunto_cargo, */
                         cp_aprov_ing_bod.IdEmpresa_Ogiro, cp_aprov_ing_bod.IdTipoCbte_Ogiro, cp_aprov_ing_bod.IdCbteCble_Ogiro, 1 Cantidad, 
                        SUM( com_orden_com_loc.do_precioCompra) csto_Uni,sum( com_orden_com_loc.do_subtotal)Subtotal, com_orden_com_loc.do_ManejaIva AplicaIva, com_orden_com_loc.Por_Iva,sum( com_orden_com_loc.do_iva)Valor_Iva, 
                        SUM( com_orden_com_loc.do_total) Total,
					ISNULL(	case when com_orden_com_loc.Por_Iva>0 then
						 sum( com_orden_com_loc.do_subtotal)						
						end ,0)Subtotal_Iva,
					ISNULL(	case when com_orden_com_loc.Por_Iva=0 then
						 sum( com_orden_com_loc.do_subtotal)						
						end,0) Subtotal_SinIva

FROM            dbo.cp_Aprobacion_Ing_Bod_x_OC_det AS cp_aprov_ing_bod_det INNER JOIN
                         dbo.ct_cbtecble_det AS ct_cbte_det INNER JOIN
                         dbo.ct_cbtecble AS ct_cbte ON ct_cbte_det.IdEmpresa = ct_cbte.IdEmpresa AND ct_cbte_det.IdTipoCbte = ct_cbte.IdTipoCbte AND 
                         ct_cbte_det.IdCbteCble = ct_cbte.IdCbteCble INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON ct_cbte_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         ct_cbte_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         ct_cbte_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo AND 
                         ct_cbte_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         ct_cbte_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         ct_cbte_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo AS fa_clie_x_cc ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = fa_clie_x_cc.IdEmpresa_cc AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = fa_clie_x_cc.IdCentroCosto_cc ON 
                         cp_aprov_ing_bod_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         cp_aprov_ing_bod_det.IdCentro_Costo_x_Gasto_x_cxp = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         cp_aprov_ing_bod_det.IdCentroCosto_sub_centro_costo_cxp = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                         dbo.cp_Aprobacion_Ing_Bod_x_OC AS cp_aprov_ing_bod INNER JOIN
                         dbo.cp_proveedor AS cp_prov ON cp_aprov_ing_bod.IdEmpresa = cp_prov.IdEmpresa AND cp_aprov_ing_bod.IdProveedor = cp_prov.IdProveedor ON 
                         cp_aprov_ing_bod_det.IdEmpresa = cp_aprov_ing_bod.IdEmpresa AND cp_aprov_ing_bod_det.IdAprobacion = cp_aprov_ing_bod.IdAprobacion AND 
                         cp_aprov_ing_bod_det.IdEmpresa = cp_aprov_ing_bod.IdEmpresa AND cp_aprov_ing_bod_det.IdAprobacion = cp_aprov_ing_bod.IdAprobacion INNER JOIN
                         dbo.com_ordencompra_local_det AS com_orden_com_loc ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = com_orden_com_loc.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = com_orden_com_loc.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = com_orden_com_loc.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = com_orden_com_loc.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = com_orden_com_loc.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = com_orden_com_loc.IdCentroCosto_sub_centro_costo INNER JOIN
                         dbo.in_Producto ON com_orden_com_loc.IdEmpresa = dbo.in_Producto.IdEmpresa AND com_orden_com_loc.IdProducto = dbo.in_Producto.IdProducto AND 
                         com_orden_com_loc.IdEmpresa = dbo.in_Producto.IdEmpresa AND com_orden_com_loc.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.in_ProductoTipo ON dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND 
                         dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo AND dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND 
                         dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo
                    WHERE        (dbo.in_ProductoTipo.tp_descripcion = 'Bien')
						and 	(cp_aprov_ing_bod.Fecha_Factura between @w_FechaIni and @w_FechaFin) 
						and     cp_aprov_ing_bod.IdEmpresa = @i_IdEmpresa	
						and   IdEmpresa_Ogiro>0
						  

group by                cp_aprov_ing_bod.IdEmpresa,
                        com_orden_com_loc.IdCentroCosto,
					    com_orden_com_loc.IdCentroCosto_sub_centro_costo,
					  --  com_orden_com_loc.IdPunto_cargo, 
                        cp_aprov_ing_bod.IdEmpresa_Ogiro,
						cp_aprov_ing_bod.IdTipoCbte_Ogiro,
					    cp_aprov_ing_bod.IdCbteCble_Ogiro,
					     com_orden_com_loc.do_ManejaIva,
						 com_orden_com_loc.Por_Iva




						 union






						 SELECT        dbo.cp_orden_giro.IdEmpresa,/* ROW_NUMBER() OVER (ORDER BY dbo.cp_orden_giro.idempresa) AS Secuencia,*/ ct_cbte_det.IdCentroCosto, ct_cbte_det.IdCentroCosto_sub_centro_costo, 
                         ct_cbte.IdEmpresa AS IdEmpreOG, dbo.cp_orden_giro.IdTipoCbte_Ogiro, dbo.cp_orden_giro.IdCbteCble_Ogiro, 1 AS Secuencia,
						 dbo.cp_orden_giro.co_subtotal_iva + dbo.cp_orden_giro.co_subtotal_siniva AS Costo_Uni, 
                         dbo.cp_orden_giro.co_subtotal_iva + dbo.cp_orden_giro.co_subtotal_siniva AS SubTotal,
						
						 case when  dbo.cp_orden_giro.co_valoriva >0 then
						 1
						 else
						 0 end Aplica_Iva,
						  dbo.cp_orden_giro.co_Por_iva,
						 dbo.cp_orden_giro.co_valoriva, 
						  dbo.cp_orden_giro.co_total,
					                 
						  dbo.cp_orden_giro.co_subtotal_iva,
						  dbo.cp_orden_giro.co_subtotal_siniva
						--  ,NULL		
						 -- ,0
FROM            dbo.ct_cbtecble_det AS ct_cbte_det INNER JOIN
                         dbo.ct_cbtecble AS ct_cbte ON ct_cbte_det.IdEmpresa = ct_cbte.IdEmpresa AND ct_cbte_det.IdTipoCbte = ct_cbte.IdTipoCbte AND 
                         ct_cbte_det.IdCbteCble = ct_cbte.IdCbteCble INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON ct_cbte_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         ct_cbte_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         ct_cbte_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo AND 
                         ct_cbte_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         ct_cbte_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         ct_cbte_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                         Fj_servindustrias.fa_cliente_x_ct_centro_costo AS fa_clie_x_cc ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = fa_clie_x_cc.IdEmpresa_cc AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = fa_clie_x_cc.IdCentroCosto_cc INNER JOIN
                         dbo.cp_orden_giro ON ct_cbte.IdEmpresa = dbo.cp_orden_giro.IdEmpresa AND ct_cbte.IdEmpresa = dbo.cp_orden_giro.IdEmpresa AND 
                         ct_cbte.IdTipoCbte = dbo.cp_orden_giro.IdTipoCbte_Ogiro AND ct_cbte.IdCbteCble = dbo.cp_orden_giro.IdCbteCble_Ogiro INNER JOIN
                         dbo.cp_proveedor AS cp_prov ON dbo.cp_orden_giro.IdEmpresa = cp_prov.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = cp_prov.IdProveedor AND 
                         dbo.cp_orden_giro.IdEmpresa = cp_prov.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = cp_prov.IdProveedor
						-- where  dbo.cp_orden_giro.IdCbteCble_Ogiro =1
						where
						   (NOT EXISTS
                         ( select * from cp_Aprobacion_Ing_Bod_x_OC IngresoBodega
						  where IngresoBodega.IdEmpresa_Ogiro=dbo.cp_orden_giro.IdEmpresa
						  and IngresoBodega.IdCbteCble_Ogiro=dbo.cp_orden_giro.IdCbteCble_Ogiro
						  and IngresoBodega.IdTipoCbte_Ogiro=dbo.cp_orden_giro.IdTipoCbte_Ogiro
						  and IngresoBodega.IdEmpresa=@i_IdEmpresa
						 ))

						 and dbo.cp_orden_giro.IdEmpresa=cp_orden_giro.IdEmpresa
						 and cp_orden_giro.co_FechaFactura between @w_FechaIni and @w_FechaFin
						 and cp_orden_giro.IdEmpresa=@i_IdEmpresa


					
			) as G



					update [Fj_servindustrias].[fa_pre_facturacion_det_Fact_x_Gastos]
					set 
					Facturar = B.se_fact_gatos,
					IdTarifario = B.IdTarifario,
					Porc_ganancia = B.porcentaje
					FROM
					(
							SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_gatos, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, 
													 Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo, 
													 Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentroCosto_sub_centro_costo, 
													 Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPunto_cargo
							FROM            Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
													 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
													 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
													 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
													 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario INNER JOIN
													 Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos ON 
													 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa AND 
													 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdPunto_cargo AND 
													 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdEmpresa AND 
													 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos.IdCentro_Costo
							WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
											and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
											AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
											AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
							) B
					WHERE Fj_servindustrias.[fa_pre_facturacion_det_Fact_x_Gastos].IdEmpresa = @i_IdEmpresa
					and Fj_servindustrias.[fa_pre_facturacion_det_Fact_x_Gastos].IdPreFacturacion = @i_IdPrefacturacion
					and B.IdCentro_Costo = Fj_servindustrias.[fa_pre_facturacion_det_Fact_x_Gastos].IdCentro_Costo
					and B.IdCentroCosto_sub_centro_costo = Fj_servindustrias.[fa_pre_facturacion_det_Fact_x_Gastos].IdCentroCosto_sub_centro_costo
					and B.IdPunto_cargo = Fj_servindustrias.[fa_pre_facturacion_det_Fact_x_Gastos].IdPunto_cargo
					


END


BEGIN /*===================== INSERT AMORTIZACION & SEGURO POLIZA ===================*/


BEGIN /*===================== BORRANDO DETALLES POLIZA ============================*/

				DELETE [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
				WHERE	IdEmpresa = @i_IdEmpresa
				and IdPreFacturacion = @i_IdPrefacturacion
		END



SELECT @w_Tipo_Cobro_Poliza_X   = Tipo_Cobro_Poliza_X FROM Fj_servindustrias.fa_pre_facturacion_Parametro where IdEmpresa=@i_IdEmpresa
--set @w_Tipo_Cobro_Poliza_X='X_CUOTA'



					if (@w_Tipo_Cobro_Poliza_X ='X_ACTIVO')
					begin

							--- SOLO POR SE COBRAR POR AF ------------
							INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
							([IdEmpresa]									,[IdPreFacturacion]								,[secuencia]						
							,[IdCentro_Costo]								,[IdCentroCosto_sub_centro_costo]				,[IdPunto_cargo]															
							,[Tipo_Cobro_Poliza_X]				
							,[IdEmpresa_pol_det]							,[IdPoliza_pol_det]									,[IdActivoFijo_pol_det]					
							,[secuencia_pol_det]							
							,[IdEmpresa_pol_cuota]							,[IdPoliza_pol_cuota]								,[cod_cuota_pol_cuota]					
							,[Cantidad]										,[Costo_Uni]							
							,[Subtotal]							
							,[Aplica_Iva]
							,[Por_Iva]										,[Valor_Iva]							,[Total],	[Facturar]
							,[IdTarifario]									,[Porc_ganancia])
							SELECT        
							Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa	,@i_IdPrefacturacion								,ROW_NUMBER() OVER (ORDER BY Fj_servindustrias.Af_Poliza_x_AF_det.idempresa) AS IdFila									
							,Af_Activo_fijo.IdCentroCosto					,Af_Activo_fijo.IdCentroCosto_sub_centro_costo		,Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC
							,@w_Tipo_Cobro_Poliza_X  
							,Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa	,Fj_servindustrias.Af_Poliza_x_AF_det.IdPoliza		,Fj_servindustrias.Af_Poliza_x_AF_det.IdActivoFijo
							,Fj_servindustrias.Af_Poliza_x_AF_det.secuencia	
							,null											,null											,null
							,1												, Fj_servindustrias.Af_Poliza_x_AF_det.Subtotal_0+ Fj_servindustrias.Af_Poliza_x_AF_det.Subtotal_12
							,Fj_servindustrias.Af_Poliza_x_AF_det.Subtotal_0+ Fj_servindustrias.Af_Poliza_x_AF_det.Subtotal_12
							,@W_Se_Cobra_Iva
							,@W_Porce_Iva									,Fj_servindustrias.Af_Poliza_x_AF_det.Iva	,Fj_servindustrias.Af_Poliza_x_AF_det.Prima,0
							,NULL											,0
							FROM            Af_Activo_fijo INNER JOIN
							Fj_servindustrias.Af_Poliza_x_AF_det ON Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa AND 
							Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Poliza_x_AF_det.IdActivoFijo INNER JOIN
							Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
							Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF
							where Fj_servindustrias.Af_Poliza_x_AF_det.IdEstadoFacturacion_cat='EST_FAC_PENDI'
							and Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa=@i_IdEmpresa

							update [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
							set 
							IdTarifario = C.IdTarifario,
							Porc_ganancia = C.porcentaje,
							Facturar = C.se_fact_seguro
							FROM
							(
							SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_seguro, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, 
														Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo, 
														Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo, 
														Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPunto_cargo
							FROM            Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
														Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
														Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
														Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
														Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario INNER JOIN
														Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza ON 
														Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa AND 
														Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPunto_cargo AND 
														Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa AND 
														Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo
							WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
											and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
											AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
											AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
							) C
							WHERE Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Poliza].IdEmpresa = @i_IdEmpresa
							and Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Poliza].IdPreFacturacion = @i_IdPrefacturacion
							and C.IdCentro_Costo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Poliza].IdCentro_Costo
							and C.IdCentroCosto_sub_centro_costo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Poliza].IdCentroCosto_sub_centro_costo
							and C.IdPunto_cargo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Poliza].IdPunto_cargo
							
				     END
					 
					 if (@w_Tipo_Cobro_Poliza_X ='X_CUOTAS')
					 begin
						--- SOLO POR SE COBRAR POR AF ------------
							INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
							([IdEmpresa]									,[IdPreFacturacion]							,[secuencia]						
							,[IdCentro_Costo]								,[IdCentroCosto_sub_centro_costo]			,[IdPunto_cargo]															
							,[Tipo_Cobro_Poliza_X]				
							,[IdEmpresa_pol_det]							,[IdPoliza_pol_det]							,[IdActivoFijo_pol_det]					
							,[secuencia_pol_det]							
							,[IdEmpresa_pol_cuota]							,[IdPoliza_pol_cuota]						,[cod_cuota_pol_cuota]					
							,[Cantidad]										,[Costo_Uni]								
							,[Subtotal_iva]									,[Subtotal_0]								,[Subtotal]
							,[Aplica_Iva]
							,[Por_Iva]										,[Valor_Iva]								,[Total]
							,[Facturar]										,[IdTarifario]								,[Porc_ganancia]
							)
							
				SELECT        pol.IdEmpresa,								@i_IdPrefacturacion,						ROW_NUMBER() OVER (ORDER BY pol_det.idempresa) AS IdFila,
							  pol.IdCentroCosto,							pol.IdCentroCosto_sub_centro_costo,			NULL, 
							  @w_Tipo_Cobro_Poliza_X, 
							  pol_det.IdEmpresa,							pol.IdPoliza,								NULL, 
							  NULL,											
							  pol_det.IdEmpresa,							pol_det.IdPoliza,							pol_det.cod_couta, 
							  1,										    pol_det.Sub_total_12 + pol_det.Sub_total_0, 
							  pol_det.Sub_total_12, 						pol_det.Sub_total_0,						pol_det.Sub_total_12 + pol_det.Sub_total_0, 
							  @W_Se_Cobra_Iva,								
							  @W_Porce_Iva,									pol_det.Iva,			  				    pol_det.valor_prima,
							  0,											NULL,										0
				FROM            ct_centro_costo_sub_centro_costo INNER JOIN
										 Fj_servindustrias.Af_Poliza_x_AF_det_cuota AS pol_det INNER JOIN
										 Fj_servindustrias.Af_Poliza_x_AF AS pol ON pol_det.IdEmpresa = pol.IdEmpresa AND pol_det.IdPoliza = pol.IdPoliza ON 
										 ct_centro_costo_sub_centro_costo.IdEmpresa = pol.IdEmpresa AND ct_centro_costo_sub_centro_costo.IdCentroCosto = pol.IdCentroCosto AND 
										 ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = pol.IdCentroCosto_sub_centro_costo INNER JOIN
										 ct_centro_costo ON ct_centro_costo_sub_centro_costo.IdEmpresa = ct_centro_costo.IdEmpresa AND 
										 ct_centro_costo_sub_centro_costo.IdCentroCosto = ct_centro_costo.IdCentroCosto INNER JOIN
										 Fj_servindustrias.fa_cliente_x_ct_centro_costo ON ct_centro_costo.IdEmpresa = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc AND 
										 ct_centro_costo.IdCentroCosto = Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc
				WHERE        (pol_det.IdEmpresa = 1) 
							 AND (pol_det.Fecha_Pago BETWEEN @w_FechaIni AND @w_FechaFin) 
							 AND (pol_det.IdEstadoFacturacion_cat = 'EST_FAC_PENDI') 
							 AND (pol.IdCentroCosto IS NOT NULL)

			UPDATE [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
			SET IdTarifario = P.IdTarifario,
			Porc_ganancia = P.porcentaje,
			Facturar = P.se_fact_seguro
			FROM
			(
			SELECT        Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPunto_cargo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Tipo_Cobro_Poliza_X, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdActivoFijo_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia_pol_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_cuota, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.cod_cuota_pol_cuota, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Costo_Uni, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Aplica_Iva, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Valor_Iva, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Total, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Facturar, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_0, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat,
						 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_seguro
FROM            Fj_servindustrias.Af_Poliza_x_AF_det INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
                         Fj_servindustrias.Af_Poliza_x_AF_det.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo AND 
                         Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa INNER JOIN
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza ON 
                         Fj_servindustrias.Af_Poliza_x_AF_det.IdEmpresa = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_cuota AND 
                         Fj_servindustrias.Af_Poliza_x_AF_det.IdPoliza = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario
WHERE					 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa = @i_IdEmpresa
						 and @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio and Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
GROUP BY		Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPreFacturacion, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPunto_cargo, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Tipo_Cobro_Poliza_X, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdActivoFijo_pol_det, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.secuencia_pol_det, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa_pol_cuota, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.cod_cuota_pol_cuota, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Costo_Uni, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Aplica_Iva, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Por_Iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Valor_Iva, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Total, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Facturar, Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_iva, 
                         Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.Subtotal_0, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario,Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat,
						 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_seguro
			) P
			WHERE Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdEmpresa = @i_IdEmpresa
					and Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPreFacturacion = @i_IdPrefacturacion
					and P.IdCentro_Costo = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentro_Costo
					and P.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdCentroCosto_sub_centro_costo
					and P.IdPoliza_pol_cuota = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza.IdPoliza_pol_cuota	
					and P.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE'
		
					--X_ACTIVO param para cobrar poliza por activo
end 
BEGIN /*===================== INSERT DEPRECIACION ===================*/


				delete [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion]
				WHERE	IdEmpresa = @i_IdEmpresa
				and IdPreFacturacion = @i_IdPrefacturacion


				INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion]
				([IdEmpresa]				,[IdPreFacturacion]					,[secuencia]	
				,[IdCentro_Costo]			,[IdCentroCosto_sub_centro_costo]	,[IdPunto_cargo]
				,[IdEmpresa_dep]			,[IdDepreciacion_dep]				,[IdTarifario]
				,[secuencia_dep]			,[IdActivoFijo]						,[concepto]
				,[Total_depreciado_x_cobrar],[Facturar]							,[Porc_ganancia]
				)
				
				SELECT        
				fa_tar_depre.IdEmpresa		, @i_IdPrefacturacion		,ROW_NUMBER() OVER (ORDER BY fa_tar_depre.IdEmpresa) AS IdFila									
				,AF.IdCentroCosto			, AF.IdCentroCosto_sub_centro_costo	,AF_x_PuntC.IdPunto_cargo_PC
				,fa_tar_depre.IdEmpresa		,fa_tar_depre.IdDepreciacion		,fa_tar_depre.IdTarifario
				,fa_ta_dep_det.Secuencia	,fa_ta_dep_det.IdActivoFijo			,fa_ta_dep_det.Concepto
				,fa_ta_dep_det.Valor_Depreciacion,0,0
				FROM            Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det AS fa_ta_dep_det INNER JOIN
										 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Af_Depreciacion AS fa_tar_depre ON fa_ta_dep_det.IdEmpresa = fa_tar_depre.IdEmpresa AND 
										 fa_ta_dep_det.IdDepreciacion = fa_tar_depre.IdDepreciacion AND fa_ta_dep_det.IdTarifario = fa_tar_depre.IdTarifario INNER JOIN
										 Af_Activo_fijo AS AF ON fa_ta_dep_det.IdEmpresa = AF.IdEmpresa AND fa_ta_dep_det.IdActivoFijo = AF.IdActivoFijo INNER JOIN
										 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo AS AF_x_PuntC ON AF.IdEmpresa = AF_x_PuntC.IdEmpresa_AF AND 
										 AF.IdActivoFijo = AF_x_PuntC.IdActivoFijo_AF INNER JOIN
										 Fj_servindustrias.fa_tarifario_facturacion_x_cliente AS fa_tarif ON fa_ta_dep_det.IdEmpresa = fa_tarif.IdEmpresa AND 
										 fa_ta_dep_det.IdTarifario = fa_tarif.IdTarifario
				WHERE fa_ta_dep_det.IdEmpresa = @i_IdEmpresa
				and  fa_tar_depre.Fecha_Depreciacion between @w_FechaIni and @w_FechaFin
				and  fa_tarif.IdEstadoVigencia_cat='EST_VIG_VIGENTE'

				update [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion]
				set 
				IdTarifario = D.IdTarifario,
				Porc_ganancia = D.porcentaje,
				Facturar = D.se_fact_depreciacion
				FROM(
								SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_depreciacion, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, 
														 Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo, 
														 Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentroCosto_sub_centro_costo, 
														 Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPunto_cargo
								FROM            Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
														 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
														 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
														 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
														 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario INNER JOIN
														 Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion ON 
														 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa AND 
														 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdPunto_cargo AND 
														 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdEmpresa AND 
														 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion.IdCentro_Costo
								WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
														 and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
														 AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
														 AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
														 ) D
				WHERE Fj_servindustrias.[fa_pre_facturacion_det_Cobro_x_Depreciacion].IdEmpresa = @i_IdEmpresa
				and Fj_servindustrias.[fa_pre_facturacion_det_Cobro_x_Depreciacion].IdPreFacturacion = @i_IdPrefacturacion
				and D.IdCentro_Costo = Fj_servindustrias.[fa_pre_facturacion_det_Cobro_x_Depreciacion].IdCentro_Costo
				and D.IdCentroCosto_sub_centro_costo = Fj_servindustrias.[fa_pre_facturacion_det_Cobro_x_Depreciacion].IdCentroCosto_sub_centro_costo
				and D.IdPunto_cargo = Fj_servindustrias.[fa_pre_facturacion_det_Cobro_x_Depreciacion].IdPunto_cargo
				

end 

BEGIN /*===================== INSERT TARIFARIO & REGISTRO DE HORA ===================*/

    
		delete [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas] 
		where IdEmpresa=@i_IdEmpresa
		and IdPreFacturacion = @i_IdPrefacturacion


		INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		(
					 [IdEmpresa]			,[IdPreFacturacion]		,[secuencia]		
					,[IdPeriodo]			,[IdCentroCosto]		,[IdCentroCosto_sub_centro_costo]
					,[IdPunto_cargo_PC]		,[IdActivoFijo]			
					,[Cantidad]				,[Costo_Uni]			,[Subtotal]
					,[Aplica_Iva]			,[Por_Iva]				,[Valor_Iva]
					,[Total]				,[Facturar]				,[IdTarifario]
					,[Porc_ganancia]
		)
SELECT                Fj_servindustrias.fa_registro_unidades_x_equipo.IdEmpresa, 
					  @i_IdPrefacturacion,
					  ROW_NUMBER() OVER (ORDER BY Fj_servindustrias.fa_registro_unidades_x_equipo.IdEmpresa) AS IdFila,
					  Fj_servindustrias.fa_registro_unidades_x_equipo.IdPeriodo, 
					  Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto, 
					  Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto_sub_centro_costo,
                      Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC,
                      Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo, 					  
                     iif(( MAX(Fj_servindustrias.fa_registro_unidades_x_equipo_det.Valor) -isnull( Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.[Af_ValorUnidad_Actu],0)) <  (select F.Unidades_minimas from Fj_servindustrias.vwfa_tarifario_x_ActivoFijo F where F.IdCentroCosto_cc= Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto and F.IdActivoFijo=Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo),
					 (select F.Unidades_minimas from Fj_servindustrias.vwfa_tarifario_x_ActivoFijo F where F.IdCentroCosto_cc= Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto and F.IdActivoFijo=Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo),MAX(Fj_servindustrias.fa_registro_unidades_x_equipo_det.Valor) -isnull( Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.[Af_ValorUnidad_Actu],0)) AS valor_maximo,
					  0,0,isnull( @W_Se_Cobra_Iva,0),@W_Porce_Iva,0,0,0,0,0
FROM                  Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo ON 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdEmpresa = Fj_servindustrias.fa_registro_unidades_x_equipo.IdEmpresa AND 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdRegistro = Fj_servindustrias.fa_registro_unidades_x_equipo.IdRegistro INNER JOIN
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det ON 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdEmpresa = Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdEmpresa AND 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdRegistro = Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdRegistro AND 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.IdActivoFijo = Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF
WHERE					 Fj_servindustrias.fa_registro_unidades_x_equipo.IdEmpresa = @i_IdEmpresa 
					    AND Fj_servindustrias.fa_registro_unidades_x_equipo.IdPeriodo = @i_IdPeriodo
GROUP BY Fj_servindustrias.fa_registro_unidades_x_equipo.IdEmpresa, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo.IdPeriodo, Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_registro_unidades_x_equipo_det.IdActivoFijo, 
                         Fj_servindustrias.fa_registro_unidades_x_equipo_det_ini_x_Af.Af_ValorUnidad_Actu, Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC, 
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC




		update [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Costo_Uni=Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Valor_x_Unidad
		,Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Estado =''
		,Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdTarifario=Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario
		,Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Cantidad = 		
		CASE
		WHEN Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Cantidad < Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Unidades_minimas
				THEN Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Unidades_minimas
			ELSE
				Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Cantidad
				END		
		FROM            Fj_servindustrias.fa_tarifario_facturacion_x_cliente AS C INNER JOIN
								 Fj_servindustrias.fa_cliente_x_ct_centro_costo AS cli ON C.IdEmpresa = cli.IdEmpresa_cli AND C.IdCliente = cli.IdCliente_cli INNER JOIN
								 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas ON 
								 cli.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto AND 
								 cli.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa INNER JOIN
								 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
								 C.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
								 C.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario AND 
								 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo								 
		WHERE        (C.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE') 
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa=@i_IdEmpresa
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPeriodo=@i_IdPeriodo

	
		

		update [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Estado ='SIN TARIFARIO'
		WHERE Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Estado IS NULL
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa=@i_IdEmpresa
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPeriodo=@i_IdPeriodo

		update Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set Aplica_Iva=ISNULL( @W_Se_Cobra_Iva,0) 
		,Por_Iva=@W_Porce_Iva
		where 
		    [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa=@i_IdEmpresa
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPeriodo=@i_IdPeriodo

		update Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set Subtotal=Cantidad*Costo_Uni
		,Valor_Iva=(Cantidad*Costo_Uni)*@W_Porce_Iva/100
		,Total=(Cantidad*Costo_Uni)+(Cantidad*Costo_Uni)*@W_Porce_Iva/100
		where Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].Aplica_Iva=1
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa=@i_IdEmpresa
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPeriodo=@i_IdPeriodo

		update Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set Subtotal=Cantidad*Costo_Uni
		,Valor_Iva=0
		,Total=(Cantidad*Costo_Uni)
		where Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].Aplica_Iva=0
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa=@i_IdEmpresa
		and [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPeriodo=@i_IdPeriodo

		update [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
		set 
		IdTarifario = E.IdTarifario,
		Porc_ganancia = E.porcentaje,
		Facturar = E.se_fact_horometro
		FROM
		(
								SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_horometro, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, 
															Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto, 
															Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto_sub_centro_costo, 
															Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPunto_cargo_PC
								FROM            Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
															Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
															Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
															Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
															Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario INNER JOIN
															Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas ON 
															Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa AND 
															Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdPunto_cargo_PC
															AND Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdEmpresa AND 
															Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.IdCentroCosto
								WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
														 and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
														 AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
														 AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
						 ) E
		WHERE Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdEmpresa = @i_IdEmpresa
		and Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPreFacturacion = @i_IdPrefacturacion
		and E.IdCentroCosto = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdCentroCosto
		and E.IdCentroCosto_sub_centro_costo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdCentroCosto_sub_centro_costo
		and E.IdPunto_cargo_PC = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas].IdPunto_cargo_PC
		

BEGIN /*INSERTO DETALLE DE MOVILIZACION X ACTIVO*/

		DELETE Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Movilizacion 
		WHERE IdEmpresa = @i_IdEmpresa and @i_IdPrefacturacion = IdPrefacturacion 

		INSERT INTO [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Movilizacion]
				   ([IdEmpresa]           ,[IdPrefacturacion]		,[secuencia]
				   ,[IdActivoFijo]        ,[IdCentro_Costo]			,[IdCentroCosto_sub_centro_costo]           
				   ,[IdPunto_cargo]       ,[Movilizacion]			,[Facturar]
				   ,[IdTarifario]		  ,[Porc_ganancia])

		SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa,
					  @i_IdPrefacturacion,
					  ROW_NUMBER() OVER (ORDER BY Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa) AS IdFila,
					  Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo, 
					  dbo.Af_Activo_fijo.IdCentroCosto, 
					  dbo.Af_Activo_fijo.IdCentroCosto_sub_centro_costo,
					  dbo.ct_punto_cargo.IdPunto_cargo,
					  Fj_servindustrias.fa_tarifario_facturacion_x_cliente.Movilizacion,0,
					  NULL,0
		FROM            dbo.Af_Activo_fijo INNER JOIN
								 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
								 dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
								 dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo INNER JOIN
								 Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
								 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
								 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario INNER JOIN
								 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
								 dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
								 dbo.ct_punto_cargo ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = dbo.ct_punto_cargo.IdEmpresa AND 
								 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = dbo.ct_punto_cargo.IdPunto_cargo
								 where Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa 
								 and (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')



			update [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Movilizacion]
			set 
			IdTarifario = E.IdTarifario,
			Porc_ganancia = E.porcentaje,
			Facturar = E.se_fact_horometro
			FROM
			(
						SELECT        Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario, Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat, 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.se_fact_horometro, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.porcentaje, 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio, Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin, 
												 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo, 
												 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentroCosto_sub_centro_costo, 
												 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPunto_cargo
						FROM            Fj_servindustrias.fa_cliente_x_ct_centro_costo INNER JOIN
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente ON 
												 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa AND 
												 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCliente_cli = Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdCliente INNER JOIN
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdTarifario INNER JOIN
												 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF INNER JOIN
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision ON 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdEmpresa AND 
												 Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdTarifario = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.IdTarifario INNER JOIN
												 Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion ON 
												 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa AND 
												 Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdPunto_cargo AND 
												 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdEmpresa_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdEmpresa AND 
												 Fj_servindustrias.fa_cliente_x_ct_centro_costo.IdCentroCosto_cc = Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion.IdCentro_Costo
						WHERE        (Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEstadoVigencia_cat = 'EST_VIG_VIGENTE')
												 and Fj_servindustrias.fa_tarifario_facturacion_x_cliente.IdEmpresa = @i_IdEmpresa
												 AND  @w_FechaIni between Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_inicio 						 
												 AND Fj_servindustrias.fa_tarifario_facturacion_x_cliente_Por_comision.Fecha_Fin
			) E
		WHERE Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Movilizacion].IdEmpresa = @i_IdEmpresa
		and Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Movilizacion].IdPreFacturacion = @i_IdPrefacturacion
		and E.IdCentro_Costo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Movilizacion].IdCentro_Costo
		and E.IdCentroCosto_sub_centro_costo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Movilizacion].IdCentroCosto_sub_centro_costo
		and E.IdPunto_cargo = Fj_servindustrias.[fa_pre_facturacion_det_cobro_x_Movilizacion].IdPunto_cargo
		
END 
	 
	 

	 BEGIN /* INSERT DE ID POR PERIODO POR EMPLEADO*/
	
	delete Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra 
	where IdPreFacturacion=@i_IdPrefacturacion
	and Idempresa=@i_IdEmpresa

	
	insert into Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra 
	select @i_IdEmpresa,@i_IdPrefacturacion, R.IdNominaTipo,R.IdEmpleado, 'Gatos por mano de obra del periodo  ',C.IdCentroCosto,C.IdCentroCosto_sub_centro_costo
  FROM            dbo.ro_rol_detalle AS R INNER JOIN
                         dbo.ro_empleado_x_centro_costo AS C ON R.IdEmpresa = C.IdEmpresa AND R.IdEmpleado = C.IdEmpleado and R.IdEmpresa=@i_IdEmpresa and R.IdPeriodo=@i_IdPeriodo
	group by R.IdEmpresa, R.IdNominaTipo,R.IdEmpleado,C.IdCentroCosto,C.IdCentroCosto_sub_centro_costo
	
	-- select * from Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra 

	delete Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc
	where IdPreFacturacion=@i_IdPrefacturacion
	and Idempresa=@i_IdEmpresa

		insert into Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc 

		select @i_IdEmpresa,
		@i_IdPrefacturacion,
		ROW_NUMBER() OVER (ORDER BY Det.IdEmpresa),
		Det.IdPrestamo,
		Det.NumCuota,
		Det.IdCliente,
		Det.TotalCuota,
		Det.Observacion_det
		FROM Fj_servindustrias.vwba_prestamo_detalle   As Det  
        where Det.FechaPago between @w_FechaIni and @w_FechaFin and Det.IdEmpresa=@i_IdEmpresa and IdCliente>0
	--   select * from Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc

	END

	
END 	
		select IdPreFacturacion 
		from Fj_servindustrias.fa_pre_facturacion 
		where IdPreFacturacion = @i_IdPrefacturacion

END

/*

select * from Fj_servindustrias.vwfa_pre_facturacion_det_egr_x_bod


select * from Fj_servindustrias.fa_pre_facturacion
select * from Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
select * from Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos
SELECT * FROM [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
select * from [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion]
SELECT * FROM [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
select * from [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Movilizacion]
select * from Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra

delete from Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod
delete from Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos
delete FROM [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Poliza]
delete from [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion]
delete FROM [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas]
delete FROM [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Movilizacion]
delete from Fj_servindustrias.fa_pre_facturacion
delete Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra
delete Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc
--END
*/



end