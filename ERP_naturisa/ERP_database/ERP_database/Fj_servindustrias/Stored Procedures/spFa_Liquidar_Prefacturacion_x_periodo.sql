
CREATE PROCEDURE [Fj_servindustrias].[spFa_Liquidar_Prefacturacion_x_periodo] 
 @IdEmpresa int,
 @IdPeriodo int,
 @Fecha_Inicio date,
 @Fecha_Fin date

AS

BEGIN

/*
declare @IdPeriodo numeric
DECLARE @IdEmpresa AS numeric
declare @fecha_inicio date 
 set @IdPeriodo =201701
set  @IdEmpresa =1
set  @fecha_inicio ='01/01/2017' 
*/
declare @IdLiquidacion int
DECLARE @IdCliente int
declare @IdProducto_Liqui_x_defecto int 
declare @se_Agrupa_x_regio  bit
declare @margen_ganacia  float
declare @porcentajeGanancia  int
declare @idSubcentro_costo varchar(20)
declare @IdGrupo int
declare @NomCentro_Costo varchar(200)
set @se_Agrupa_x_regio= (select Liquidar_x_grupo from Fj_servindustrias.fa_pre_facturacion_Parametro where IdEmpresa=@IdEmpresa)



-- elimino los detalles de la tabla fa_liquidacion_gastos_det solo los que fueron creados por el proceso automatico

delete Fj_servindustrias.fa_liquidacion_gastos_det
from Fj_servindustrias.fa_liquidacion_gastos 
where 
    Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa=Fj_servindustrias.fa_liquidacion_gastos_det.IdEmpresa
and Fj_servindustrias.fa_liquidacion_gastos.idliquidacion=Fj_servindustrias.fa_liquidacion_gastos_det.idliquidacion
and Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo=@IdPeriodo 
and Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa=@IdEmpresa 
and Fj_servindustrias.fa_liquidacion_gastos_det.Se_Genero_por_un_proceso=1

-- elimino el detalle del historico de la tabla 
delete Fj_servindustrias.fa_liquidacion_gastos_det_Historico
from Fj_servindustrias.fa_liquidacion_gastos 
where 
    Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa=Fj_servindustrias.fa_liquidacion_gastos_det_Historico.IdEmpresa
and Fj_servindustrias.fa_liquidacion_gastos.idliquidacion=Fj_servindustrias.fa_liquidacion_gastos_det_Historico.idliquidacion
and Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo=@IdPeriodo 
and Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa=@IdEmpresa 

-- elimino los registro de la tabla fa_liquidacion_gastos solo los que fueron creados por el proceso automatico

delete Fj_servindustrias.fa_liquidacion_gastos 
where Fj_servindustrias.fa_liquidacion_gastos.IdEmpresa=@IdEmpresa
and Fj_servindustrias.fa_liquidacion_gastos.IdPeriodo=@IdPeriodo


if(@se_Agrupa_x_regio=1)--  SI SE AGRUPA LA PREFACTURACION
begin
--******************************************************************** cursor para recorrer los clientes********************************************************************
--*************************************************************************************************************************************************************************
DECLARE Cursor_Cliente CURSOR FOR 
	SELECT IdCliente_cli
	FROM Fj_servindustrias.vwfa_cliente_x_SubCentro_costo
	where IdEmpresa_cli=@IdEmpresa
	group by IdEmpresa_cc,IdCentroCosto_cc,IdCliente_cli
OPEN Cursor_Cliente

FETCH  Cursor_Cliente 
INTO @IdCliente
WHILE @@fetch_status = 0
BEGIN
   






					DECLARE Cursor_Grupos_x_SubCentros CURSOR FOR -- cursor para recorrer los grupos por subcentros
					SELECT IdGrupo
					FROM Fj_servindustrias.vwfa_fa_grupo_x_sub_centro_costo_det_x_Prefacturacion_Detalle
					where IdEmpresa=@IdEmpresa
					and IdCliente_cli=@IdCliente
					and IdPeriodo=@IdPeriodo
					group by IdEmpresa,IdGrupo,IdCliente_cli
					OPEN Cursor_Grupos_x_SubCentros

				   FETCH  Cursor_Grupos_x_SubCentros 
				   INTO  @IdGrupo
				   WHILE @@fetch_status = 0
				   begin
				  



					-- CREAR LA CABECERA DE LA LIQUIDACIONES  EN BASE A POLIZAS
							set @idLiquidacion =(select isnull(MAX( Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion),1)+1 from Fj_servindustrias.fa_liquidacion_gastos where IdEmpresa=@IdEmpresa)
							set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_SEGURO')
							set @NomCentro_Costo=(select Centro_costo from  ct_centro_costo_sub_centro_costo where IdCentroCosto_sub_centro_costo= @idSubcentro_costo)


							insert into Fj_servindustrias.fa_liquidacion_gastos(
							 IdEmpresa,				IdLiquidacion,				IdPeriodo,				cod_liquidacion,							IdCliente,			   	fecha_liqui,				Observacion,				                                                     estado,IdUsuario,Fecha_Transaccion,IdUsuarioUltModi,Fecha_UltMod,IdUsuarioUltAnu,Fecha_UltAnu,MotivoAnulacion, nom_pc,ip)								
							values( 
							 @IdEmpresa,             @idLiquidacion,             @IdPeriodo,             @idLiquidacion,							@IdCliente,              @Fecha_Inicio,             '"LIQUIDACIÓN DE GASTOS AGENCIA "', 'A',   'NULL',   null            ,null,         null,      null,         null,      null,        null,null)

--**************************************************************************************************-- crear el detalle de la liquidacion por poliza de seguros CON IVA
--****************************************************************************************************************************************************************************
						   insert into Fj_servindustrias.fa_liquidacion_gastos_Det 
						   (Idempresa				,IdLiquidacion			,secuencia		,IdProducto_Liqui				,Detalle_x_producto		,Cantidad
						   ,precio					,subtotal				,Aplica_iva		,por_iva						,valor_iva				,total_liq,Se_Genero_por_un_proceso
						   )
						   select   
						   PD.idempresa				,@idLiquidacion			,1				,@IdProducto_Liqui_x_defecto	,'Amortizacion /Seguro Con Iva'	,1
						   ,isnull(Subtotal_iva ,0)		,isnull( Subtotal_iva,0)	,1		,por_iva						,valor_iva				,Subtotal_iva+valor_iva,1
						   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza AS PD, 
						   Fj_servindustrias.fa_pre_facturacion AS PC,
						   Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where PD.idempresa=@idempresa
						    and PD.IdCentro_Costo=CC.IdCentroCosto_cc 
							and PD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
							and  @IdCliente= CC.IdCliente_cli
							and PC.IdPeriodo= @IdPeriodo 
							and Grup.IdEmpresa=@IdEmpresa
							and Grup.IdGrupo=@IdGrupo
							and Grup.IdEmpresa=Grup_Detall.IdEmpresa
							and Grup_Detall.IdCentroCosto_sub_centro_costo=PD.IdCentroCosto_sub_centro_costo							
							--and PD.Facturar=1
						    AND Subtotal_iva>0 



--********************************crear el detalle de la liquidacion por poliza de seguros SIN IVA******************************************************************************
--******************************************************************************************************************************************************************************
						   insert into Fj_servindustrias.fa_liquidacion_gastos_Det 
						   (Idempresa				,IdLiquidacion			,secuencia		,IdProducto_Liqui				,Detalle_x_producto		,Cantidad
						   ,precio					,subtotal				,Aplica_iva		,por_iva						,valor_iva				,total_liq,		Se_Genero_por_un_proceso
						   )
						   select   
						   PD.idempresa				,@idLiquidacion			,2				,@IdProducto_Liqui_x_defecto	,'Amortizacion /Seguro sin Iva'	,1
						   ,isnull(Subtotal_0,0)	,isnull( Subtotal_0,0)	,0				,por_iva						,0						,Subtotal_0,1
						   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza AS PD,
						   Fj_servindustrias.fa_pre_facturacion AS PC,
						   Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where PD.idempresa=@idempresa 						   
						   and  @IdCliente= CC.IdCliente_cli 
						   and PD.IdCentro_Costo=CC.IdCentroCosto_cc 
						   and PD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
						   and PC.IdPeriodo= @IdPeriodo 
						   and Grup.IdEmpresa=@IdEmpresa
						   and Grup.IdGrupo=@IdGrupo
						   and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						   and Grup_Detall.IdCentroCosto_sub_centro_costo=PD.IdCentroCosto_sub_centro_costo	
						  -- and PD.Facturar=1
						   AND Subtotal_0>0 
						



--**************************crear el detalle de la liquidacion por poliza de seguros******************************************************************************************
--*****************************************************************************************************************************************************************************
						   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_DEPRECIACION')
						  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
									Idempresa,			IdLiquidacion,			secuencia,			IdProducto_Liqui,			Detalle_x_producto,			Cantidad,							precio,																				subtotal,												Aplica_iva,				por_iva,			valor_iva,						total_liq,Se_Genero_por_un_proceso)
						   select   DD.idempresa,		@idLiquidacion,			3,					@IdProducto_Liqui_x_defecto,'Depreciacion de AF',		1,									isnull(	SUM(DD.Total_depreciado_x_cobrar),0),										isnull(SUM(DD.Total_depreciado_x_cobrar),0),				0,			        0,			        0,						SUM(DD.Total_depreciado_x_cobrar),1
						   from Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion AS DD,
						   Fj_servindustrias.fa_pre_facturacion AS PC,
						   Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where DD.idempresa=@idempresa 
						   and  @IdCliente= CC.IdCliente_cli 
						   and DD.IdCentro_Costo=CC.IdCentroCosto_cc 
						   and DD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
						   and PC.IdPeriodo= @IdPeriodo 
						   and Grup.IdEmpresa=@IdEmpresa
						   and Grup.IdGrupo=@IdGrupo
						   and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						  -- and Grup_Detall.IdCentroCosto_sub_centro_costo=DD.IdCentroCosto_sub_centro_costo	
						   and DD.Facturar=1
						   group by DD.idempresa,DD.IdCentro_Costo,Grup_Detall.IdGrupo




--************************************************crear el detalle de la liquidacion por horometro de equipos*********************************************************************
--*******************************************************************************************************************************************************************************
						   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_REGISTO_X__HORA')
						  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
									Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,Cantidad		,precio,					subtotal,					Aplica_iva,					por_iva			,valor_iva					,total_liq,			Se_Genero_por_un_proceso)
						   select   HD.idempresa		,@idLiquidacion				,4			,@IdProducto_Liqui_x_defecto	,'Registro / Horas'	,1				,isnull(SUM(HD.Subtotal),0),isnull(SUM(HD.Subtotal),0)	, 0,						0				,sum(HD.valor_iva)			,SUM(HD.Total),		1
						   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas AS HD,
						   Fj_servindustrias.fa_pre_facturacion AS PC,
						   Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where HD.idempresa=@idempresa 
						   and  @IdCliente= CC.IdCliente_cli 
						   and HD.IdCentroCosto=CC.IdCentroCosto_cc 
						   and HD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
						   and PC.IdPeriodo= @IdPeriodo
						    and Grup.IdEmpresa=@IdEmpresa
						   and Grup.IdGrupo=@IdGrupo
						   and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						   and Grup_Detall.IdCentroCosto_sub_centro_costo=HD.IdCentroCosto_sub_centro_costo	 
						  -- and HD.Facturar=1
						
						   group by HD.idempresa,HD.IdCentroCosto,HD.IdCentroCosto_sub_centro_costo


   


--***********************crear el detalle de egreso a bodegas*******************************************************************************************************************
--******************************************************************************************************************************************************************************
						   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_EGRESOS_X_BOD')
						  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
									Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,Cantidad		,precio,					subtotal					,Aplica_iva
									,por_iva			,valor_iva					,total_liq,				Se_Genero_por_un_proceso)
						   select   ED.idempresa		,@idLiquidacion				,5			,@IdProducto_Liqui_x_defecto	,'Egresos por Bodega'	,1				,isnull(SUM(ED.Subtotal),0)	,isnull(SUM(ED.Subtotal),0), 0
									, 0					,sum(ED.valor_iva)			,SUM(ED.Total),			1
						   from  Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod AS ED,
						   Fj_servindustrias.fa_pre_facturacion AS PC,
						   Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						   Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where ED.idempresa=@idempresa
						   and  @IdCliente= CC.IdCliente_cli 
						   and ED.IdCentro_Costo=CC.IdCentroCosto_cc 
						   and ED.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
						   and PC.IdPeriodo= @IdPeriodo
						   and Grup.IdEmpresa=@IdEmpresa
						   and Grup.IdGrupo=@IdGrupo
						   and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						   and Grup_Detall.IdCentroCosto_sub_centro_costo=ED.IdCentroCosto_sub_centro_costo	 
						  -- and ED.Facturar=1
						   group by ED.idempresa,ED.IdCentro_Costo,Grup.IdGrupo



--**********************************crear el detalle de gastos*********************************************************************************************************************
--********************************************************************************************************************************************************************************
						   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_CXP_PROVE')
						  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
									Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)
						   select   GD.idempresa		,@idLiquidacion				,6			,@IdProducto_Liqui_x_defecto	,'Fact & cxp por proveedor(OG) Gastos'	,1				,isnull(SUM(GD.Subtotal),0),isnull(SUM(GD.Subtotal),0)	, 0,					 0				,sum(GD.valor_iva)			,SUM(GD.Total),		1
						   from  Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos AS GD,
						    Fj_servindustrias.fa_pre_facturacion AS PC, 
							Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC,
							Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						    Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
						   where GD.idempresa=@idempresa 
						    and  @IdCliente= CC.IdCliente_cli 
						    and GD.IdCentro_Costo=CC.IdCentroCosto_cc 
						    and GD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
						    and PC.IdPeriodo= @IdPeriodo
							and Grup.IdEmpresa=@IdEmpresa
						   and Grup.IdGrupo=@IdGrupo
						   and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						   and Grup_Detall.IdCentroCosto_sub_centro_costo=GD.IdCentroCosto_sub_centro_costo	 
						    --and GD.Facturar=1
						 
						   group by GD.idempresa,GD.IdCentro_Costo,GD.IdCentroCosto_sub_centro_costo
   
   
   
--***************************CREO EL MARGEN DE GANACIA****************************************************************************************************************************
--********************************************************************************************************************************************************************************

					    	 set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_MARGEN_RENTA')
						    ---- obtengo el margen de ganacia
							 set @margen_ganacia=( select  isnull( sum(Margen_ganancia),0)    
							 from Fj_servindustrias.vwfa_Margen_Ganacia_x_centro_subCentro as Marg,
							  Fj_servindustrias.fa_grupo_x_sub_centro_costo as Grup,
						     Fj_servindustrias.fa_grupo_x_sub_centro_costo_det as Grup_Detall
							 where Marg.IdEmpresa=@IdEmpresa 
							 and IdCliente_cli=@IdCliente
							 and Marg.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
							 and Grup.IdEmpresa=@IdEmpresa
						     and Grup.IdGrupo=@IdGrupo
						     and Grup.IdEmpresa=Grup_Detall.IdEmpresa
						    -- and Grup_Detall.IdCentroCosto_sub_centro_costo=Marg.IdCentroCosto_sub_centro_costo	 
							 and IdPeriodo=@IdPeriodo
							 group by Marg.IdEmpresa,IdCliente_cli,Grup.IdGrupo)

							insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
											 Idempresa			,IdLiquidacion				,secuencia		,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)          
									values( @IdEmpresa,			@idLiquidacion,				6,				@IdProducto_Liqui_x_defecto,	'Margen de Utilidad (fee)',					1,			 0,			                 0,			                0						,0				 ,0						     ,0			         ,1)			
                  


				  																		
	--**************************-- crear el detalle de mano de obra***********************************************************************************************************************
	--*********************************************************************************************************************************************************************************
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_GASTOS_EMPLE')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)
															   
															   SELECT   pre_fac_det.Idempresa,@IdLiquidacion,           7,			@IdProducto_Liqui_x_defecto,	'Gastos Empleados',						1,				sum( Ro_det.Valor),			sum( Ro_det.Valor),			0,						0,				0,							sum( Ro_det.Valor),				1				 
																 
									FROM                     dbo.ro_rol_detalle AS Ro_det INNER JOIN
																 Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra AS pre_fac_det ON Ro_det.IdEmpresa = pre_fac_det.Idempresa AND 
																 Ro_det.IdEmpleado = pre_fac_det.IdEmpleado INNER JOIN
																 Fj_servindustrias.fa_pre_facturacion AS fa_pre_fact ON Ro_det.IdEmpresa = fa_pre_fact.IdEmpresa AND Ro_det.IdPeriodo = fa_pre_fact.IdPeriodo
										GROUP                   BY pre_fac_det.Idempresa, pre_fac_det.IdPreFacturacion, pre_fac_det.IdNomina_Tipo, pre_fac_det.Observacion, 
																 Ro_det.IdRubro
										HAVING                 (Ro_det.IdRubro = '950')
						 





				  
				  
				   FETCH NEXT FROM Cursor_Grupos_x_SubCentros 
				   INTO @IDGrupo 
		  -- fin del cursor de los subcentro de costo
		  END
		CLOSE Cursor_Grupos_x_SubCentros
		DEALLOCATE Cursor_Grupos_x_SubCentros 



 FETCH NEXT FROM Cursor_Cliente 
	INTO @IdCliente
-- fin del cursor de los clientes 
END
CLOSE Cursor_Cliente
DEALLOCATE Cursor_Cliente

-- grabo los registro en la tabla Fj_servindustrias.fa_liquidacion_gastos_det_Historico
insert into Fj_servindustrias.fa_liquidacion_gastos_det_Historico
select D. IdEmpresa, D.IdLiquidacion, D.secuencia, D.IdProducto_Liqui, D.detalle_x_producto, D.cantidad, D.precio, D.subtotal, D.aplica_iva, D.por_iva, D.valor_iva, D.Total_liq 
from Fj_servindustrias.fa_liquidacion_gastos_det as D, Fj_servindustrias.fa_liquidacion_gastos as C
where D.IdEmpresa=D.IdEmpresa
and D.IdLiquidacion=C.IdLiquidacion
and C.IdPeriodo=@IdPeriodo
and D.Se_Genero_por_un_proceso=1



end 
 


if(@se_Agrupa_x_regio=0)-- si  no se agrupa la prefacturacion
begin   
DECLARE Cursor_Cliente CURSOR FOR  -- cursor para recorrer los clientes
	SELECT IdCliente_cli
	FROM Fj_servindustrias.vwfa_cliente_x_SubCentro_costo
	where IdEmpresa_cli=@IdEmpresa
	group by IdEmpresa_cc,IdCentroCosto_cc,IdCliente_cli
OPEN Cursor_Cliente

FETCH  Cursor_Cliente 
INTO @IdCliente
WHILE @@fetch_status = 0
BEGIN



                            
								DECLARE cursor_subcentro CURSOR FOR -- cursor para recorrer los grupos
								SELECT IdCentroCosto_sub_centro_costo
								FROM Fj_servindustrias.vwfa_cliente_x_SubCentro_costo
								where IdEmpresa_cli=@IdEmpresa
								and IdCliente_cli=@IdCliente
								and IdPeriodo=@IdPeriodo
								group by IdEmpresa_cli,IdCentroCosto_cc,IdCentroCosto_sub_centro_costo,Centro_costo
								OPEN cursor_subcentro
								FETCH  cursor_subcentro 
								INTO @idSubcentro_costo 
								WHILE @@fetch_status = 0
								begin
				  

				   set @NomCentro_Costo=(select Centro_costo from  ct_centro_costo_sub_centro_costo where IdCentroCosto_sub_centro_costo= @idSubcentro_costo)

														-- CREAR LA CABECERA DE LA LIQUIDACIONES  EN BASE A POLIZAS
																set @idLiquidacion =(select isnull(MAX( Fj_servindustrias.fa_liquidacion_gastos.IdLiquidacion),1)+1 from Fj_servindustrias.fa_liquidacion_gastos where IdEmpresa=@IdEmpresa)
																set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_SEGURO')


																insert into Fj_servindustrias.fa_liquidacion_gastos(
																 IdEmpresa,				IdLiquidacion,				IdPeriodo,				cod_liquidacion,							IdCliente,			   	fecha_liqui,				Observacion,				                                                     estado,IdUsuario,Fecha_Transaccion,IdUsuarioUltModi,Fecha_UltMod,IdUsuarioUltAnu,Fecha_UltAnu,MotivoAnulacion, nom_pc,ip)								
																values( 
																 @IdEmpresa,             @idLiquidacion,             @IdPeriodo,             @idLiquidacion,							@IdCliente,              @Fecha_Inicio,             'LIQUIDACIÓN DE GATOS AGENCIA '+@NomCentro_Costo, 'A',   'NULL',   null            ,null,         null,      null,         null,      null,        null,null)

															-- 
																														   
--********************************************crear el detalle de la liquidacion por poliza de seguros CON IVA**********************************************************************************
--*****************************************************************************************************************************************************************************************
	
	
															   insert into Fj_servindustrias.fa_liquidacion_gastos_Det 
															   (Idempresa				,IdLiquidacion			,secuencia		,IdProducto_Liqui				,Detalle_x_producto		,Cantidad
															   ,precio					,subtotal				,Aplica_iva		,por_iva						,valor_iva				,total_liq,Se_Genero_por_un_proceso
															   )
															   select   
															   PD.idempresa				,@idLiquidacion			,1				,@IdProducto_Liqui_x_defecto	,'Amortizacion /Seguro Con Iva'	,1
															   ,isnull(sum(Subtotal_iva) ,0)		,isnull(sum( Subtotal_iva),0)	,1		,por_iva						,sum(valor_iva)				,sum(Subtotal_iva)+sum(valor_iva),1
															   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza AS PD, Fj_servindustrias.fa_pre_facturacion AS PC, Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where PD.idempresa=@idempresa
																and PD.IdCentro_Costo=CC.IdCentroCosto_cc 
																and PD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
																and @IdCliente= CC.IdCliente_cli 
																and PC.IdPeriodo= @IdPeriodo 
																--and PD.Facturar=1
																AND Subtotal_iva>0 
																group by  PD.idempresa,por_iva



															   
															   
--********************************************-- --crear el detalle de la liquidacion por poliza de seguros SIN IVA**********************************************************************************
--*****************************************************************************************************************************************************************************************
	
	
															   insert into Fj_servindustrias.fa_liquidacion_gastos_Det 
															   (Idempresa				,IdLiquidacion			,secuencia		,IdProducto_Liqui				,Detalle_x_producto		,Cantidad
															   ,precio					,subtotal				,Aplica_iva		,por_iva						,valor_iva				,total_liq,		Se_Genero_por_un_proceso
															   )
															   select   
															   PD.idempresa				,@idLiquidacion			,2				,@IdProducto_Liqui_x_defecto	,'Amortizacion /Seguro sin Iva'	,1
															   ,isnull(sum(Subtotal_0),0)	,isnull(sum(Subtotal_0),0)	,0				,por_iva						,0						,sum(Subtotal_0),1
															   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza AS PD, Fj_servindustrias.fa_pre_facturacion AS PC, Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where PD.idempresa=@idempresa 						   
															   and  @IdCliente= CC.IdCliente_cli 
															   and PD.IdCentro_Costo=CC.IdCentroCosto_cc 
															   and PD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
															   and PC.IdPeriodo= @IdPeriodo 
															   --and PD.Facturar=1
															   AND Subtotal_0>0 
						
						                                     group by  PD.idempresa	,por_iva


--********************************************-- crear el detalle de la liquidacion por poliza de seguros**********************************************************************************
--*****************************************************************************************************************************************************************************************
	
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_DEPRECIACION')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa,			IdLiquidacion,			secuencia,			IdProducto_Liqui,			Detalle_x_producto,			Cantidad,							precio,																				subtotal,												Aplica_iva,				por_iva,			valor_iva,						total_liq,Se_Genero_por_un_proceso)
															   select   DD.idempresa,		@idLiquidacion,			3,					@IdProducto_Liqui_x_defecto,'Depreciacion de AF',		1,									isnull(	SUM(DD.Total_depreciado_x_cobrar),0),										isnull(SUM(DD.Total_depreciado_x_cobrar),0),				0,			        0,			        0,						SUM(DD.Total_depreciado_x_cobrar),1
															   from Fj_servindustrias.fa_pre_facturacion_det_Cobro_x_Depreciacion AS DD, Fj_servindustrias.fa_pre_facturacion AS PC, Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where DD.idempresa=@idempresa 
															   and  @IdCliente= CC.IdCliente_cli 
															   and DD.IdCentro_Costo=CC.IdCentroCosto_cc 
															   and DD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
															   and PC.IdPeriodo= @IdPeriodo 
															   and DD.Facturar=1
															   group by DD.idempresa,DD.IdCentro_Costo,DD.IdCentroCosto_sub_centro_costo




--*****************************************************crear el detalle de la liquidacion por horometro de equipos***************************************************************
--*****************************************************************************************************************************************************************************
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_REGISTO_X__HORA')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,Cantidad		,precio,					subtotal,					Aplica_iva,					por_iva			,valor_iva					,total_liq,			Se_Genero_por_un_proceso)
															   select   HD.idempresa		,@idLiquidacion				,4			,@IdProducto_Liqui_x_defecto	,'Registro / Horas'	,1				,isnull(SUM(HD.Subtotal),0),isnull(SUM(HD.Subtotal),0)	, 0,						0				,sum(HD.valor_iva)			,SUM(HD.Total),		1
															   from Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas AS HD, Fj_servindustrias.fa_pre_facturacion AS PC, Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where HD.idempresa=@idempresa 
															   and  @IdCliente= CC.IdCliente_cli 
															   and HD.IdCentroCosto=CC.IdCentroCosto_cc 
															   and HD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
															   and PC.IdPeriodo= @IdPeriodo 
															   --and HD.Facturar=1
						
															   group by HD.idempresa,HD.IdCentroCosto,HD.IdCentroCosto_sub_centro_costo


   


--********************************************** -- crear el detalle de egreso a bodegas*************************************************************************************
--*****************************************************************************************************************************************************************************
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_EGRESOS_X_BOD')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,Cantidad		,precio,					subtotal					,Aplica_iva
																		,por_iva			,valor_iva					,total_liq,				Se_Genero_por_un_proceso)
															   select   ED.idempresa		,@idLiquidacion				,5			,@IdProducto_Liqui_x_defecto	,'Egresos por Bodega'	,1				,isnull(SUM(ED.Subtotal),0)	,isnull(SUM(ED.Subtotal),0), 0
																		, 0					,sum(ED.valor_iva)			,SUM(ED.Total),			1
															   from  Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod AS ED, Fj_servindustrias.fa_pre_facturacion AS PC, Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where ED.idempresa=@idempresa
															   and  @IdCliente= CC.IdCliente_cli 
															   and ED.IdCentro_Costo=CC.IdCentroCosto_cc 
															   and ED.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
															   and PC.IdPeriodo= @IdPeriodo 
															  -- and ED.Facturar=1
															   group by ED.idempresa,ED.IdCentro_Costo,ED.IdCentroCosto_sub_centro_costo

															  --  select *  from  Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod

	--**************************-- crear el detalle de gastos***********************************************************************************************************************
	--*********************************************************************************************************************************************************************************
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_CXP_PROVE')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)
															   select   GD.idempresa		,@idLiquidacion				,6			,@IdProducto_Liqui_x_defecto	,'Fact & cxp por proveedor(OG) Gastos'	,1				,isnull(SUM(GD.Subtotal),0),isnull(SUM(GD.Subtotal),0)	, 0,					 0				,sum(GD.valor_iva)			,SUM(GD.Total),		1
															   from  Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos AS GD,
															    Fj_servindustrias.fa_pre_facturacion AS PC,
																 Fj_servindustrias.fa_cliente_x_ct_centro_costo as CC
															   where GD.idempresa=@idempresa 
																and  @IdCliente= CC.IdCliente_cli 
																and GD.IdCentro_Costo=CC.IdCentroCosto_cc 
																and GD.IdCentroCosto_sub_centro_costo=@idSubcentro_costo
																and PC.IdPeriodo= @IdPeriodo
																--and GD.Facturar=1
						 
															   group by GD.idempresa,GD.IdCentro_Costo,GD.IdCentroCosto_sub_centro_costo
   
   
   
--*****************************************************************-- CREO EL MARGEN DE GANACIA****************************************************************************************
--*************************************************************************************************************************************************************************************

					    										 set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_MARGEN_RENTA')
																 set @porcentajeGanancia=(select porcentaje from Fj_servindustrias.vwfa_tarifario_facturacion_x_cliente_Por_comision where IdCliente=@IdCliente and IdAnio=YEAR(@fecha_inicio))
																---- obtengo el margen de ganacia
																 set @margen_ganacia=( select isnull( sum(Valor_Facturar),0)  from Fj_servindustrias.vwfa_Margen_Ganacia_x_centro_subCentro
																 where IdEmpresa=@IdEmpresa 
																 and IdCliente_cli=@IdCliente
																 and IdCentroCosto_sub_centro_costo=@idSubcentro_costo
																 and IdPeriodo=@IdPeriodo
																 group by IdEmpresa,IdCliente_cli,IdCentroCosto_sub_centro_costo)*@porcentajeGanancia/100

																insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																				 Idempresa			,IdLiquidacion				,secuencia		,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)          
																		values( @IdEmpresa,			@idLiquidacion,				6+@idSubcentro_costo,				@IdProducto_Liqui_x_defecto,	'Margen de Utilidad (fee)',					1,			@margen_ganacia,			@margen_ganacia,			0							,0				,0						,@margen_ganacia			,1)		
																		
																		
																		
																		
	--**************************-- crear el detalle de mano de obra***********************************************************************************************************************
	--*********************************************************************************************************************************************************************************
															   set @IdProducto_Liqui_x_defecto=(select IdProducto_Liqui_x_defecto from Fj_servindustrias.fa_liquidaciones_tipo_proceso where IdTipo_Proceso='PRO_GASTOS_EMPLE')
															  insert into Fj_servindustrias.fa_liquidacion_gastos_Det (
																		Idempresa			,IdLiquidacion				,secuencia	,IdProducto_Liqui				,Detalle_x_producto	,					Cantidad		,precio,					subtotal					,Aplica_iva,			por_iva			,valor_iva					,total_liq			,Se_Genero_por_un_proceso)
															   
															   SELECT   pre_fac_det.Idempresa,@IdLiquidacion,           7+@idSubcentro_costo,			@IdProducto_Liqui_x_defecto,	'Gastos Empleados',						1,				sum( Ro_det.Valor),			sum( Ro_det.Valor),			0,						0,				0,							sum( Ro_det.Valor),				1				 
																 
										FROM                     dbo.ro_rol_detalle AS Ro_det INNER JOIN
																 Fj_servindustrias.fa_pre_facturacion_det_gasto_mano_obra AS pre_fac_det ON Ro_det.IdEmpresa = pre_fac_det.Idempresa AND 
																 Ro_det.IdEmpleado = pre_fac_det.IdEmpleado INNER JOIN
																 Fj_servindustrias.fa_pre_facturacion AS fa_pre_fact ON Ro_det.IdEmpresa = fa_pre_fact.IdEmpresa AND Ro_det.IdPeriodo = fa_pre_fact.IdPeriodo
										                        where fa_pre_fact.IdPeriodo=@IdPeriodo
										GROUP                   BY pre_fac_det.Idempresa, pre_fac_det.IdNomina_Tipo, pre_fac_det.Observacion,  Ro_det.IdRubro
										HAVING                 (Ro_det.IdRubro = '950')
						 
															  																		
																		
																		
																			
						FETCH NEXT FROM cursor_subcentro -- muevo el cursor al siguiente registro
						INTO @idSubcentro_costo 
						-- fin del cursor de los subcentro de costo
						END
						CLOSE cursor_subcentro
						DEALLOCATE cursor_subcentro 




 FETCH NEXT FROM Cursor_Cliente -- muevo el cursor al siguiente registro
	INTO @IdCliente
-- fin del cursor de los clientes 
END
CLOSE Cursor_Cliente
DEALLOCATE Cursor_Cliente

-- grabo los registro en la tabla Fj_servindustrias.fa_liquidacion_gastos_det_Historico
insert into Fj_servindustrias.fa_liquidacion_gastos_det_Historico
select D. IdEmpresa, D.IdLiquidacion, D.secuencia, D.IdProducto_Liqui, D.detalle_x_producto, D.cantidad, D.precio, D.subtotal, D.aplica_iva, D.por_iva, D.valor_iva, D.Total_liq 
from Fj_servindustrias.fa_liquidacion_gastos_det as D, Fj_servindustrias.fa_liquidacion_gastos as C
where D.IdEmpresa=D.IdEmpresa
and D.IdLiquidacion=C.IdLiquidacion
and C.IdPeriodo=@IdPeriodo
and D.Se_Genero_por_un_proceso=1



end 
 






















 --      exec Fj_servindustrias.spFa_Liquidar_Prefacturacion_x_periodo 1,201605,'01/05/2016','30/05/2016'
--       select * from Fj_servindustrias.fa_liquidacion_gastos_det 
--		 select * from Fj_servindustrias.fa_liquidacion_gastos
--       select * from Fj_servindustrias.fa_liquidacion_gastos_det_historico

--		delete  Fj_servindustrias.fa_liquidacion_gastos_det
--		delete  Fj_servindustrias.fa_liquidacion_gastos  
end