CREATE proc [dbo].[spSys_Carga_NotasDebCre_SIAC] as
delete fa_notaCreDeb_det
delete fa_notaCreDeb


delete xxx_tbdet_NotaDC where nt_compania>1
delete xxx_tbdet_NotaDC_detalle where nt_compania>1
delete from xxx_tbdet_NotaDC where Nt_Motivo =0

delete xxx_tbdet_NotaDC where nt_numero=0

delete xxx_tbdet_NotaDC_detalle
from xxx_tbdet_NotaDC_detalle A,
(
	SELECT   
	 Nt_compania		, Nt_Sucursal		,Nt_Numero	
	FROM         xxx_tbdet_NotaDC
	group by Nt_compania		, Nt_Sucursal		,Nt_Numero			
	having COUNT(*)	>1
)B
where A.nt_compania=B.nt_compania
and A.nt_sucursal=B.nt_sucursal
and A.nt_numero=B.nt_numero



delete xxx_tbdet_NotaDC
from xxx_tbdet_NotaDC A,
(
	SELECT   
	 Nt_compania		, Nt_Sucursal		,Nt_Numero	
	FROM         xxx_tbdet_NotaDC
	group by Nt_compania		, Nt_Sucursal		,Nt_Numero			
	having COUNT(*)	>1
)B
where A.nt_compania=B.nt_compania
and A.nt_sucursal=B.nt_sucursal
and A.nt_numero=B.nt_numero




delete xxx_tbdet_NotaDC_detalle where nt_numero=0

update xxx_tbdet_NotaDC
set Nt_Cliente=Nt_Cliente-1000
where Nt_Cliente>1372


----=============================================================================================
----=============================================================================================
----=============================================================================================

INSERT INTO fa_notaCreDeb
(IdEmpresa		, IdSucursal		, IdBodega		, IdNota			, CodNota
, CreDeb		, Serie1			, Serie2		, NumNota_Impresa	, NumAutorizacion
, IdCliente		, IdVendedor		, no_fecha		, no_fecha_venc		, no_dev_venta
, IdTipoNota		, sc_observacion, IdUsuario			, Estado
, IdDevolucion	, IdUsuarioUltMod	, Fecha_UltMod	, IdUsuarioUltAnu	, Fecha_UltAnu
, MotiAnula		, nom_pc			, ip			, Estado			, IdDpto	
, IdSolicitante	, flete				, interes		, valor1			, valor2
, NaturalezaNota, seguro
)
SELECT   
 Nt_compania		, Nt_Sucursal		,1				,Nt_Numero			,''
,Nt_Tipo			,'001'				,'001'			,Nt_PreimpresoNC	,''
,Nt_Cliente			,1					,Nt_Fecha		,Nt_fechaVenci		,null
,Nt_Motivo			,isnull(Nt_Concepto,'')	,'sys'				,'A'
,null				,'sys'				,null			,''					,null
,''					,'pc'				,''				,'A'				,1
,1					,0					,0				,0					,0
,''					,0
FROM         xxx_tbdet_NotaDC
where Nt_Cliente in
(
select idcliente from fa_cliente
)


---=================================================================================



update xxx_tbdet_NotaDC_detalle 
set nt_producto=1
where nt_producto<=0

INSERT INTO fa_notaCreDeb_det
(IdEmpresa		, IdSucursal	, IdBodega	, IdNota	, Secuencia	
, IdProducto	, sc_cantidad	, sc_Precio	, sc_descUni, sc_PordescUni
, sc_precioFinal, sc_subtotal	, sc_iva	, sc_total	, sc_costo
, sc_observacion, sc_estado		
)
SELECT      
nt_compania		, nt_sucursal	,1			, nt_numero		, nt_secuencia
, nt_producto	, nt_cantidad	, nt_pvp	, nt_descUni	,nt_por_des
,nt_precioFinal	, nt_subtotal	,nt_iva		,nt_total		,nt_costo
,nt_observacion	,nt_estado		
FROM         xxx_tbdet_NotaDC_detalle
where 
cast(nt_compania		as varchar(20))+CAST( nt_sucursal	as varchar(20))
+cast(nt_numero  as varchar(20))
in
(
	select cast(nt_compania		as varchar(20))+CAST( nt_sucursal	as varchar(20))
	+cast(nt_numero  as varchar(20))
	from xxx_tbdet_NotaDC 
)
and cast(nt_compania as varchar(20)) + cast(nt_producto  as varchar(20)) in
(
	select cast(IdEmpresa as varchar(20))+CAST(IdProducto  as varchar(20)) from in_producto
)







select * from fa_notaCreDeb
select * from fa_notaCreDeb_det
--select * from in_producto