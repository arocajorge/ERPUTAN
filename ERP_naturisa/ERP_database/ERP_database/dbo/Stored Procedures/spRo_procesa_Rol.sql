
--  exec [dbo].[spRo_procesa_Rol] 1,1,9000,1,1,201303


CREATE  proc [dbo].[spRo_procesa_Rol]
(
 @i_empresa int
,@i_empleadoIni numeric
,@i_empleadoFin numeric
,@i_tipoNomina numeric
,@i_procesoRol numeric
,@i_periodo numeric

)

as



--select * from ro_periodo 
/*
declare @i_empresa int
declare @i_empleadoIni numeric
declare @i_empleadoFin numeric
declare @i_tipoNomina numeric
declare @i_procesoRol numeric
declare @i_periodo numeric


set @i_empresa =1
set @i_empleadoIni =1
set @i_empleadoFin =90000
set @i_tipoNomina =1
set @i_procesoRol =1
set @i_periodo =3

*/


delete ro_Ing_Egre_x_Empleado 
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol




declare @w_fechaPeriodoIni datetime
declare @w_fechaPeriodoFin datetime

---------------------------------------------------------
--------------cargando los rubros desde configuracioens 
---------------------------------------------------------
insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa	,IdEmpleado			,IdNomina_Tipo	,IdNomina_TipoLiqui		,IdPeriodo   
,IdRubro    ,IdNovedad			,SecuenciaNovedad	,IdPrestamo		,NunCouta
,IngEgr		,Valor			,iAnio				,iMes        
,cerrado	,Unid_Medida
)

SELECT     
 A.IdEmpresa	,B.IdEmpleado	,@i_tipoNomina	,@i_procesoRol			,@i_periodo 
,A.IdRubro		,0				,0					,0				,0
,C.ru_tipo		,0				,D.pe_anio			,D.pe_mes 
,'N'			,'$$$'
FROM         ro_Config_Rubros_x_empleado A,ro_empleado B,ro_rubro_tipo C
,ro_periodo D
where A.IdEmpresa =@i_empresa 
and A.IdEmpresa=B.IdEmpresa
and A.IdRubro=C.IdRubro 
and A.IdEmpresa=D.IdEmpresa 
and D.IdPeriodo=@i_periodo 
and B.IdEmpleado between @i_empleadoIni and @i_empleadoFin

--- -FIN-------------cargando los rubros desde configuracioens 



----------------------------------------------------------------------
--------------------------opteniendo fecha ini y fin de periodo
select @w_fechaPeriodoIni=A.pe_FechaIni,@w_fechaPeriodoFin=A.pe_FechaFin
from ro_periodo A
where A.IdEmpresa =@i_empresa
and A.IdPeriodo =@i_periodo 
----------------------------------------------------------------------
----------------------------------------------------------------------


----// insertando las novedades que no esten ro_Ing_Egre_x_Empleado
------------ opteniedo el id de rubro q no esten en la tabla 
insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa		,IdEmpleado		,IdNomina_Tipo		,IdNomina_TipoLiqui	,IdPeriodo   
,IdRubro		,IdNovedad		,SecuenciaNovedad	,IdPrestamo		,NunCouta
,IngEgr			,Valor			,iAnio				,iMes        
,cerrado		,TipoRegistro	,Unid_Medida
)
-- select * from ro_empleado_novedad_det
SELECT      
B.IdEmpresa		, B.IdEmpleado	,@i_tipoNomina	,@i_procesoRol		,@i_periodo
,B.IdRubro		,B.IdNovedad	,B.Secuencia		, 0				,0
,''				,0				,YEAR(FechaPago)	,MONTH(FechaPago)
,'N'			,'NOV'			,'$$$'
FROM         ro_empleado_novedad_det AS B 
where 
	B.IdEmpresa =@i_empresa
and B.FechaPago  between @w_fechaPeriodoIni and @w_fechaPeriodoFin 
and B.IdEmpleado between @i_empleadoIni and @i_empleadoFin
and B.IdRubro not in
(
	select distinct IdRubro  from 
	ro_Ing_Egre_x_Empleado 
	where IdEmpresa=@i_empresa
	and IdPeriodo			=@i_periodo 
	and IdNomina_Tipo		=@i_tipoNomina
	and IdNomina_TipoLiqui	=@i_procesoRol
	and IdEmpleado between @i_empleadoIni and @i_empleadoFin
	and IdNovedad>0
	
)


	
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------
------------------------- actualizando los valores de las novedades -----------------
--------------------------------------------------------------------------------------

-- bandera 1 :  update ro_Ing_Egre_x_Empleado 
update ro_Ing_Egre_x_Empleado 
set Valor =B.Valor 
,observacionesSys='bandera 1 :  update ro_Ing_Egre_x_Empleado '
FROM         ro_Ing_Egre_x_Empleado AS C ,ro_empleado_novedad_det AS B 
where C.IdEmpresa = B.IdEmpresa 
and B.IdEmpresa =@i_empresa
and C.IdNomina_Tipo =@i_tipoNomina
and C.IdNomina_TipoLiqui=@i_procesoRol 
and B.FechaPago  between @w_fechaPeriodoIni and @w_fechaPeriodoFin 
and B.IdEmpleado between @i_empleadoIni and @i_empleadoFin
and B.IdEmpresa=C.IdEmpresa
and B.IdRubro =C.IdRubro 
and B.IdEmpleado =C.IdEmpleado 

-------------------------------------------------------------------------------------
-------------FIN  actualizando los valores de las novedades -------------------------
-------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------
-------------actualizar el sueldo del empleado 
-------------------------------------------------------------------------------------

--- optener idRubro por elsueldo desde los parametros 
declare @idRubroS int
select @idRubroS=idrubro_relacionado from dbo.ro_Parametros_Varios where pa_codigo='SUELDO'

delete ro_Ing_Egre_x_Empleado
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol
and IdRubro =@idRubroS


insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa	,IdEmpleado	,IdNomina_Tipo ,IdNomina_TipoLiqui	,IdPeriodo   
,IdRubro    ,IdNovedad			,SecuenciaNovedad	,IdPrestamo		,NunCouta
,IngEgr		,Valor			,iAnio				,iMes        
,cerrado	,Unid_Medida
)

select 
IdEmpresa	,IdEmpleado ,@i_tipoNomina	,@i_procesoRol		,@i_periodo
,@idRubroS	,0					,0					,0				,0
,'I'		,em_sueldoBasicoMen,YEAR(@w_fechaPeriodoIni),MONTH(@w_fechaPeriodoIni)
,'N'		,'$$$'
from ro_empleado 
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 

-------------------------------------------------------------------------------------
------------optener idRubro por dias trabajados desde los parametros------------------ 
-------------------------------------------------------------------------------------
declare @idRubroD int
select @idRubroD=IdRubro from dbo.ro_Config_Rubros_ParametrosGenerales where IdTipoParametro='DIASTRA'

delete ro_Ing_Egre_x_Empleado
where 
IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol
and IdRubro =@idRubroD


insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa	,IdEmpleado	,IdNomina_Tipo ,IdNomina_TipoLiqui	,IdPeriodo   
,IdRubro    ,IdNovedad			,SecuenciaNovedad	,IdPrestamo		,NunCouta
,IngEgr		,iAnio				,iMes        
,cerrado	,Valor				,Unid_Medida		
)

select 
IdEmpresa	,IdEmpleado ,@i_tipoNomina	,@i_procesoRol		,@i_periodo
,@idRubroD	,0					,0					,0				,0
,'I'		,YEAR(@w_fechaPeriodoIni),MONTH(@w_fechaPeriodoIni)
,'N',Valor=case
--periodo mensual
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=27 then '30'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=28 then '30'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=29 then '30'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=30 then '30'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=31 then '30'
---periodo quincenal
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=12 then '15'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=13 then '15'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=14 then '15'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=15 then '15'
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)=16 then '15'
---periodo semanal
when DATEDIFF(DAY,@w_fechaPeriodoIni,@w_fechaPeriodoFin)<=7 then '7'
end ,'dias'
from ro_empleado 
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin


-------------------------------------------------------------------------------------
-------------actualizar el sueldo del empleado 
-------------------------------------------------------------------------------------

update ro_Ing_Egre_x_Empleado 
set IngEgr ='I'
where Valor > 0

update ro_Ing_Egre_x_Empleado 
set IngEgr ='E'
where Valor < 0


----------------------------------------------------------------------
------------------- OPTENIENDO DIAS NOVEDADES POR FALTA -----------------

declare @idRubroFalta int
select @idRubroFalta=IdRubro from dbo.ro_Config_Rubros_ParametrosGenerales where IdTipoParametro='DIASFALTA'

delete ro_Ing_Egre_x_Empleado
where 
IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol
and IdRubro =@idRubroFalta

insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa	,IdEmpleado	,IdNomina_Tipo ,IdNomina_TipoLiqui	,IdPeriodo   
,IdRubro    ,IdNovedad			,SecuenciaNovedad	,IdPrestamo		,NunCouta
,IngEgr		,iAnio				,iMes        
,cerrado	,Valor				,Unid_Medida		
)

select 
A.IdEmpresa	,A.IdEmpleado ,@i_tipoNomina	,@i_procesoRol		,@i_periodo
,@idRubroFalta	,0					,0					,0				,0
,'E'		,YEAR(@w_fechaPeriodoIni),MONTH(@w_fechaPeriodoIni)
,'N',COUNT(*) TotalDiasFalt		,'dias'

FROM ro_Empleado_Novedad AS A INNER JOIN
ro_empleado_novedad_det AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdNovedad = B.IdNovedad AND A.IdEmpleado = B.IdEmpleado
WHERE     
	A.IdEmpresa = @i_empresa
AND A.IdNomina_Tipo = @i_tipoNomina
AND A.IdNomina_TipoLiqui = @i_procesoRol
AND A.IdEmpleado between @i_empleadoIni and @i_empleadoFin
AND A.Fecha between @w_fechaPeriodoIni and @w_fechaPeriodoFin 
AND B.Estado = 'A'
AND B.IdRubro = @idRubroFalta
group by A.IdEmpresa, A.IdEmpleado 

------------------- FIN OPTENIENDO DIAS NOVEDADES POR FALTA -----------------
----------------------------------------------------------------------








--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------


--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------
------------------------ proceso de los prestamos ------------------------------------
--------------------------------------------------------------------------------------

----- insertando las cuotas por prestamos 

insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa		,IdEmpleado		,IdNomina_Tipo		,IdNomina_TipoLiqui		,IdPeriodo   
,IdRubro		,IdNovedad		,SecuenciaNovedad	,IdPrestamo			,NunCouta
,IngEgr			,Valor			,iAnio				,iMes        
,cerrado		,TipoRegistro	,Unid_Medida	
)

SELECT    
 A.IdEmpresa	, A.IdEmpleado	, A.IdNomina_Tipo	,@i_procesoRol			,@i_periodo		
, A.IdRubro		, 0				,0					, A.IdPrestamo		,B.NumCuota 
,'E'			, B.TotalCuota * -1	, year(B.FechaPago) ,month(B.FechaPago)
,'N'			,'PRE'			,'$$$'			
FROM         ro_prestamo AS A INNER JOIN
                      ro_prestamo_detalle AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdPrestamo = B.IdPrestamo
where A.IdEmpresa=@i_empresa
and A.IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdNomina_Tipo		=@i_tipoNomina
and B.FechaPago between @w_fechaPeriodoIni and @w_fechaPeriodoFin 
and B.EstadoPago ='PEN'      


    
--------------------------------------------------------------------------------------
------------------------ fin proceso de los prestamos --------------------------------
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------




--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------
------------------------ optengo el Sueldo Basico de la tabla sueldo Basico por anio
--------------------------------------------------------------------------------------

----- insertando sueldo basico para el XIV

declare @idRubroSueldoBasi int
select @idRubroSueldoBasi =IdRubro from dbo.ro_Config_Rubros_ParametrosGenerales where IdTipoParametro='SUELDO_BA'

delete ro_Ing_Egre_x_Empleado 
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol
and IdRubro =@idRubroSueldoBasi


insert into ro_Ing_Egre_x_Empleado 
(IdEmpresa			,IdEmpleado		,IdNomina_Tipo					,IdNomina_TipoLiqui		,IdPeriodo   
,IdRubro			,IdNovedad		,SecuenciaNovedad				,IdPrestamo			,NunCouta
,IngEgr				,Valor			,iAnio							,iMes        
,cerrado			,TipoRegistro	,Unid_Medida	
)
select 
idempresa			,idempleado		,idNomina_tipo				,@i_procesoRol			,@i_periodo		
,@idRubroSueldoBasi ,0				,0							,0					,0
,'R'				,sb_valor		,YEAR(@w_fechaPeriodoIni)	,MONTH(@w_fechaPeriodoIni)
,'N'				,'RUB'			,'$$$'			
from vwRo_Sueldo_Basico_x_Empleado_x_anio
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdNomina_Tipo		=@i_tipoNomina
and sb_anio =YEAR(@w_fechaPeriodoIni)









    
--------------------------------------------------------------------------------------
------------------------ FIN optengo el Sueldo Basico de la tabla sueldo Basico por anio
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------





/*

select * from ro_Ing_Egre_x_Empleado where idrubro=963
where IdEmpresa=@i_empresa
and IdEmpleado between @i_empleadoIni and @i_empleadoFin 
and IdPeriodo			=@i_periodo 
and IdNomina_Tipo		=@i_tipoNomina
and IdNomina_TipoLiqui	=@i_procesoRol

*/