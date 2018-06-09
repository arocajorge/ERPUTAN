

CREATE VIEW [dbo].[vwFa_Documento_DeclaracionSRI_DATA]
AS
select  
isnull(ROW_NUMBER() OVER (ORDER BY T1.IdEmpresa DESC),0) AS IdFila, 
case when RTRIM(LTRIM(T1.IdTipoDocumento))='RUC' then '04' when RTRIM(LTRIM(T1.IdTipoDocumento))='CED' then'05'  when RTRIM(LTRIM(T1.IdTipoDocumento))='PAS'then '06' else'07'end  tpIdCliente 
, RTRIM(LTRIM(T1.pe_cedulaRuc)) as idCliente 
,  case when RTRIM(LTRIM(T1.vt_tipoDoc))='FACT'then '18'when RTRIM(LTRIM(T1.vt_tipoDoc))='C'then '04'  when RTRIM(LTRIM(T1.vt_tipoDoc))='D'then '05'end as tipoComprobante 
,cast(T2.NumDocXCli as varchar(50))as numeroComprobantes  
,  convert(decimal(18,2),T1.baseNoGraIva)  as baseNoGraIva,  convert(decimal(18,2),T1.baseImponible) as baseImponible 
,  convert(decimal(18,2),T1.baseImpGrav) as baseImpGrav ,  convert(decimal(18,2),T1.montoIva) as montoIva 
,T1.IdEmpresa,T1.anio,T1.mes,T1.Razon_Social
from 
(
			select IdTipoDocumento,pe_cedulaRuc,vt_tipoDoc,  
			SUM(baseNoGraIva)as baseNoGraIva,SUM(baseImpGrav) as baseImpGrav  ,SUM(baseImponible) as baseImponible, 
			 SUM(montoIva)as montoIva,vt_serie1
			 ,idempresa,Year(vt_fecha) anio ,month(vt_fecha) mes,Razon_Social
			from vwFa_Documento_DeclaracionSRI 
			group by pe_cedulaRuc,  IdTipoDocumento,vt_tipoDoc,vt_serie1,idempresa,Year(vt_fecha) ,month(vt_fecha),Razon_Social

)T1  inner join  
(
	select count(T.pe_cedulaRuc) as NumDocXCli,T.pe_cedulaRuc,  T.vt_tipoDoc 
	,anio,mes,IdEmpresa
	from (
				select IdCbteVta,pe_cedulaRuc,vt_tipoDoc ,idempresa,Year(vt_fecha) anio ,month(vt_fecha)  mes
				from vwFa_Documento_DeclaracionSRI  
				group by IdCbteVta,pe_cedulaRuc,vt_tipoDoc,idempresa,Year(vt_fecha) ,month(vt_fecha)
	)
	T  
	group by pe_cedulaRuc,vt_tipoDoc,anio,mes,IdEmpresa

)
T2 on T1.pe_cedulaRuc=T2.pe_cedulaRuc and T1.vt_tipoDoc=T2.vt_tipoDoc and T1.IdEmpresa=T2.IdEmpresa and T1.anio=T2.anio and T1.mes=T2.mes