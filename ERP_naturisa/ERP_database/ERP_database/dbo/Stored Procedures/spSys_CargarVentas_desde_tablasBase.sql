CREATE  proc [dbo].[spSys_CargarVentas_desde_tablasBase] as

delete fa_factura_det
delete fa_factura


--select * from fa_Vendedor

select distinct vt_compania, vt_vendedor from xxxtbcab_pos

update xxxtbcab_pos
set vt_vendedor =2
where vt_vendedor>15


select distinct IDCliente
from xxxtbcab_pos
where --vt_compania=2
--and  
IDCliente not in
(
select IdCliente
from fa_cliente
)



INSERT INTO fa_factura
(IdEmpresa		, IdSucursal	, IdBodega			, IdCbteVta		, vt_tipoDoc
, vt_serie1		, vt_serie2		, vt_NumFactura		, IdCliente		, IdVendedor
, vt_fecha		, vt_plazo		, vt_fech_venc		, estado		, vt_tipo_venta
, vt_Observacion, IdUsuario		, MotivoAnulacion
, IdPeriodo		, vt_anio		, vt_mes
,vt_seguro		,vt_flete		,vt_interes
,vt_OtroValor1	,vt_OtroValor2
,IdUsuarioUltAnu,Fecha_UltAnu,Fecha_Transaccion
,IdUsuarioUltModi,Fecha_UltMod
)


SELECT    
vt_compania			, vt_codigo_sucursal,1					, vt_numero		,vt_tipo 
,'001'				,'001'				,vt_numeroext		, IDCliente		, vt_vendedor
, vt_fecha			,vt_plazo			,vt_fech_venc		,vt_estado		,vt_tipo_venta
,isnull(vt_Observacion,'')		,vt_usuario			, substring(vt_MotivoAnulacion,1,100)
,vt_codperiodoAux	,vt_anio			, vt_mes
,vt_seguro			, vt_flete			,vt_interes 
,0					,0					
,vt_UsuarioAnulacion, vt_fechaHoraAnu	, vt_FechaHoraReg
,vt_UltimoUserModi, vt_fechaUltModi		
from         xxxtbcab_pos


--//============================================================================================




INSERT INTO fa_factura_det
(IdEmpresa			, IdSucursal		, IdBodega		, IdCbteVta
, Secuencia			, IdProducto		, vt_cantidad	, vt_Precio
, vt_PorDescUnitario, vt_DescUnitario	, vt_PrecioFinal, vt_Subtotal
, vt_iva			, vt_total					, vt_estado
,  vt_detallexItems
)

SELECT     
vt_compania			, vt_sucursal		,1				, vt_numero
, vt_secuencia		, vt_codigo_producto, vt_cantidad	, vt_valor
,isnull(vt_PorDescU,0)		,vt_DescUnitario	,vt_PrecioFinal	,vt_Subtotal
,vt_iva				,vt_total			,vt_estado
,vt_detallexItems
FROM         xxxtbdet_pos