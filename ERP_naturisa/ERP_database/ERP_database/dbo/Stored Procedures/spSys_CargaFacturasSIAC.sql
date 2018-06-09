CREATE proc [dbo].[spSys_CargaFacturasSIAC]
as



delete fa_factura 

update xxxtbcab_pos
set vt_Observacion=''
where vt_Observacion is null


---============================== cliente  =====================================
update xxxtbcab_pos
set vt_cliente=10
where vt_cliente between 1377 and 2000


update xxxtbcab_pos
set vt_cliente=11
where vt_cliente between 2000 and 3000


update xxxtbcab_pos
set vt_cliente=15
where vt_cliente between 3000 and 4000



update xxxtbcab_pos
set vt_cliente=20
where vt_cliente between 4000 and 5000


update xxxtbcab_pos
set vt_cliente=30
where vt_cliente between 5000 and 6000


select vt_cliente
from xxxtbcab_pos
where vt_compania=1
and vt_cliente not in
(
select IdCliente
from fa_cliente where IdEmpresa =1
)
order by 1



---============================== cliente  =====================================



---============================== VENDEDOR  =====================================
update xxxtbcab_pos
set vt_vendedor=30
where vt_vendedor>=35


select vt_vendedor
from xxxtbcab_pos
where vt_compania=1
and vt_vendedor not in
(
select IdVendedor 
from fa_vendedor where IdEmpresa =1
)
order by 1


---============================== FIN VENDEDOR  =================================


INSERT INTO fa_factura
(IdEmpresa			, IdSucursal		, IdBodega		, IdCbteVta			, CodCbteVta
, vt_tipoDoc		, vt_autorizacion	, vt_serie1		, vt_serie2			, vt_NumFactura
, IdCliente			, IdVendedor		, vt_fecha		, vt_plazo			, vt_fech_venc
, vt_tipo_venta		, vt_Observacion	, IdPeriodo		, vt_anio			, vt_mes
, vt_flete			, vt_interes		, vt_OtroValor1	, vt_OtroValor2		, IdUsuario
, Fecha_Transaccion	, IdUsuarioUltModi	, Fecha_UltMod	, IdUsuarioUltAnu	, Fecha_UltAnu
, MotivoAnulacion	, nom_pc			, ip			, Estado
)

SELECT      
vt_compania			, vt_codigo_sucursal,1,vt_numero		,vt_numero		
,vt_tipo			,'000000000'		,'001'			,'001'				,vt_numeroext
,vt_cliente			,vt_vendedor		,vt_fecha		,vt_plazo			,vt_fech_venc
,vt_tipo_venta		,vt_Observacion		,(YEAR(vt_fecha)*100)+MONTH(vt_fecha),vt_anio,vt_mes
,vt_flete			,vt_interes			,0				,0					 ,	vt_usuario
,vt_FechaHoraReg	,vt_UltimoUserModi	,vt_fechaUltModi	,vt_UsuarioAnulacion	,vt_fechaHoraAnu
,''					,''					,''					,'A'
FROM         xxxtbcab_pos
where vt_compania=1
and vt_codigo_sucursal in(1,2)



update fa_factura 
set vt_fecha=DATEADD(	year,2,vt_fecha)


update fa_factura 
set vt_fech_venc =DATEADD(	DAY,vt_plazo ,vt_fecha)


--select * from fa_factura 





--=======================================================================================

delete fa_factura_det

update xxxtbdet_pos  
set vt_codigo_producto = cast(vt_codigo_producto  as numeric) -1000
where vt_compania=1
and (cast(vt_codigo_producto  as numeric) -1000)>0
and vt_codigo_producto in (

			select vt_codigo_producto 
			from xxxtbdet_pos where vt_compania=1
			and vt_codigo_producto  not in
			(
			select IdProducto  from in_producto where IdEmpresa=1
			)
)

			select vt_codigo_producto 
			from xxxtbdet_pos where vt_compania=1
			and vt_codigo_producto  not in
			(
			select IdProducto  from in_producto where IdEmpresa=1
			)

update xxxtbdet_pos
set vt_DescUnitario=0
where vt_DescUnitario =null

INSERT INTO fa_factura_det
(IdEmpresa		, IdSucursal	, IdBodega			, IdCbteVta			, Secuencia			, IdProducto
, vt_cantidad	, vt_Precio		, vt_PorDescUnitario, vt_DescUnitario	, vt_PrecioFinal	, vt_Subtotal
, vt_iva		, vt_total					, vt_estado					, vt_detallexItems
, vt_Peso
)

SELECT     
vt_compania		, vt_sucursal	, 1					,vt_numero			, vt_secuencia		, vt_codigo_producto
, vt_cantidad	, vt_valor		,vt_descuento		,vt_PorDescU		,vt_PrecioFinal		,vt_Subtotal
,vt_iva			,vt_total			,'A'			,vt_detallexItems
,0
FROM         xxxtbdet_pos
where vt_compania=1


---======================================================================================