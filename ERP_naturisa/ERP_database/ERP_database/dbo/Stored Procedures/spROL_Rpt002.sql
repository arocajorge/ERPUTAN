--delete tbROL_Rpt002 
--exec spROL_Rpt002 1,275,3,1,1,1,'E','5555','OK'

CREATE PROCEDURE [dbo].[spROL_Rpt002]  
(@IdEmpresa Int, 
@IdEmpleado numeric(18,0),
@IdPeriodo Int,
@IdNomina_Tipo int,
@IdNomina_TipoLiqui int,

@IdDepartamento int,
@tipoConsulta char(1),

@i_IdUsuario varchar(20),
@i_nom_pc varchar(50) 

,@secuencia int
,@OrgCopy varchar(20)
 ) 
 AS 
 BEGIN 
 delete from tbROL_Rpt002 where IdUsuario = @i_IdUsuario and nom_pc = @i_nom_pc --and secuencia=@secuencia and OrgCopy=@OrgCopy
 --Consulta por Empleado
 if (@tipoConsulta = 'E')
 begin

---Inserccion Rol original por Empleado

/* insert de prestamos*/
Insert into tbROL_Rpt002
( 
 IdEmpresa			         ,IdEmpleado		      ,IdPeriodo			,IdRubro			             ,IdNomina_Tipo 
,IdNomina_TipoLiqui          ,IdNovedad		          ,SecuenciaNovedad   	,IdPrestamo			             ,NunCouta                                
,IdDepartamento		         ,Valor			          ,IdUsuario			,pe_nombreCompleto	             ,Departamento                                                 
,pe_FechaFin		         ,Fecha_Transac	          ,em_nombre			,nom_pc				             ,ru_descripcion
,ru_tipo			         ,dias_trabajo	          ,dias_vacaciones	    ,dias_maternidad	             ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			     , liq.IdEmpleado          , liq.IdPeriodo		 , liq.IdRubro		               , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui     , 0			           , 0					 , liq.IdPrestamo	               , liq.NunCouta
, emp.IdDepartamento	     , liq.Valor		       , @i_IdUsuario		 , emp.pe_nombreCompleto           , emp.Departamento
, pe.pe_FechaFin		     , GETDATE()		       , empr.em_nombre		 , @i_nom_pc			           , ru.ru_descripcion
, ru.ru_tipo			     , 0 AS dias_trabajo       , 0 AS dias_vacaciones       , 0 AS dias_maternidad	   , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			        ,IdEmpleado		      ,IdPeriodo			    ,IdRubro			      ,IdNomina_Tipo 
,IdNomina_TipoLiqui         ,IdNovedad		      ,SecuenciaNovedad	        ,IdPrestamo			      ,NunCouta                                
,IdDepartamento		        ,Valor			      ,IdUsuario			    ,pe_nombreCompleto        ,Departamento                                                 
,pe_FechaFin		        ,Fecha_Transac	      ,em_nombre			    ,nom_pc				      ,ru_descripcion
,ru_tipo			        ,dias_trabajo	      ,dias_vacaciones	        ,dias_maternidad	      ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	     , liq.IdPeriodo		    , liq.IdRubro		      , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad        , liq.SecuenciaNovedad     , 0			              ,0
, emp.IdDepartamento       , liq.Valor			 , @i_IdUsuario          	, emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			 ,empr.em_nombre            , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 0 AS dias_trabajo   , 0 AS dias_vacaciones     , 0 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,0 AS dias_trabajo     ,0 AS dias_vacaciones     ,0 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,1 
,'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)
--==============================================================================================================================================================
---Inserccion Rol copia por Empleado
--==============================================================================================================================================================      
/* insert de prestamos*/
Insert into tbROL_Rpt002
(
 IdEmpresa			            ,IdEmpleado		        ,IdPeriodo			          ,IdRubro			         ,IdNomina_Tipo 
,IdNomina_TipoLiqui             ,IdNovedad		        ,SecuenciaNovedad	          ,IdPrestamo		         ,NunCouta                                
,IdDepartamento		            ,Valor			        ,IdUsuario			          ,pe_nombreCompleto         ,Departamento                                                 
,pe_FechaFin		            ,Fecha_Transac	        ,em_nombre			          ,nom_pc			    	 ,ru_descripcion
,ru_tipo			            ,dias_trabajo	        ,dias_vacaciones	          ,dias_maternidad	         ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			       , liq.IdEmpleado         , liq.IdPeriodo				 , liq.IdRubro		          , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui       , 0			            , 0						     , liq.IdPrestamo	          , liq.NunCouta
, emp.IdDepartamento	       , liq.Valor		        , @i_IdUsuario				 , emp.pe_nombreCompleto      , emp.Departamento
, pe.pe_FechaFin		       , GETDATE()		        , empr.em_nombre			 , @i_nom_pc			      , ru.ru_descripcion
, ru.ru_tipo			       , 0 AS dias_trabajo      , 0 AS dias_vacaciones       , 0 AS dias_maternidad	      , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
,2 
,'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			       ,IdEmpleado		      ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui        ,IdNovedad		      ,SecuenciaNovedad	         ,IdPrestamo		    	,NunCouta                                
,IdDepartamento		       ,Valor			      ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		       ,Fecha_Transac	      ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			       ,dias_trabajo	      ,dias_vacaciones	         ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	      , liq.IdPeriodo		          , liq.IdRubro		        , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    , liq.IdNovedad        , liq.SecuenciaNovedad          , 0			            ,0
, emp.IdDepartamento       , liq.Valor			  , @i_IdUsuario	              , emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			  , empr.em_nombre                , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 0 AS dias_trabajo    , 0 AS dias_vacaciones          , 0 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr, 
ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,2 
,'Copia'  
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,0 AS dias_trabajo     ,0 AS dias_vacaciones     ,0 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,2 
,'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdEmpleado = @IdEmpleado) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)
---Fin tipo Consulta E
 end
 
--==============================================================================================================================================================
  --Consulta por Departamento 
--==============================================================================================================================================================

if(@tipoConsulta = 'D')
begin

---Inserccion Rol Original por Departamento
/* insert de prestamos*/
Insert into tbROL_Rpt002
(
 IdEmpresa			          ,IdEmpleado		       ,IdPeriodo			        ,IdRubro			       ,IdNomina_Tipo 
,IdNomina_TipoLiqui           ,IdNovedad		       ,SecuenciaNovedad	        ,IdPrestamo			       ,NunCouta                                
,IdDepartamento		          ,Valor			       ,IdUsuario			        ,pe_nombreCompleto         ,Departamento                                                 
,pe_FechaFin		          ,Fecha_Transac	       ,em_nombre			        ,nom_pc				       ,ru_descripcion
,ru_tipo			          ,dias_trabajo	           ,dias_vacaciones	            ,dias_maternidad	       ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			      , liq.IdEmpleado        , liq.IdPeriodo				, liq.IdRubro		        , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui      , 0			          , 0							, liq.IdPrestamo	        , liq.NunCouta
, emp.IdDepartamento	      , liq.Valor		      , @i_IdUsuario				, emp.pe_nombreCompleto     , emp.Departamento
, pe.pe_FechaFin		      , GETDATE()		      , empr.em_nombre			    , @i_nom_pc			        , ru.ru_descripcion
, ru.ru_tipo			      , 1 AS dias_trabajo     , 1 AS dias_vacaciones        , 1 AS dias_maternidad	    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			        ,IdEmpleado		      ,IdPeriodo			    ,IdRubro			      ,IdNomina_Tipo 
,IdNomina_TipoLiqui         ,IdNovedad		      ,SecuenciaNovedad	        ,IdPrestamo			      ,NunCouta                                
,IdDepartamento		        ,Valor			      ,IdUsuario			    ,pe_nombreCompleto        ,Departamento                                                 
,pe_FechaFin		        ,Fecha_Transac	      ,em_nombre			    ,nom_pc				      ,ru_descripcion
,ru_tipo			        ,dias_trabajo	      ,dias_vacaciones	        ,dias_maternidad	      ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	     , liq.IdPeriodo		    , liq.IdRubro		      , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad        , liq.SecuenciaNovedad     , 0			              ,0
, emp.IdDepartamento       , liq.Valor			 , @i_IdUsuario          	, emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			 ,empr.em_nombre            , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 1 AS dias_trabajo   , 1 AS dias_vacaciones     , 1 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,1 AS dias_trabajo     ,1 AS dias_vacaciones     ,1 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,1 
,'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)
                       
---Inserccion Rol Copia por Departamento

/* insert de prestamos*/
Insert into tbROL_Rpt002
(
 IdEmpresa			             ,IdEmpleado	       	,IdPeriodo			           ,IdRubro			           ,IdNomina_Tipo 
,IdNomina_TipoLiqui              ,IdNovedad		        ,SecuenciaNovedad	           ,IdPrestamo			       ,NunCouta                                
,IdDepartamento		             ,Valor			        ,IdUsuario			           ,pe_nombreCompleto	       ,Departamento                                                 
,pe_FechaFin		             ,Fecha_Transac      	,em_nombre			           ,nom_pc				       ,ru_descripcion
,ru_tipo			             ,dias_trabajo	        ,dias_vacaciones	           ,dias_maternidad	           ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			       , liq.IdEmpleado           , liq.IdPeriodo				, liq.IdRubro		        , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui       , 0			              , 0							, liq.IdPrestamo	        , liq.NunCouta
, emp.IdDepartamento	       , liq.Valor		          , @i_IdUsuario				, emp.pe_nombreCompleto     , emp.Departamento
, pe.pe_FechaFin		       , GETDATE()	              , empr.em_nombre			    , @i_nom_pc			        , ru.ru_descripcion
, ru.ru_tipo			       , 1 AS dias_trabajo        , 1 AS dias_vacaciones        , 1 AS dias_maternidad	    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
, 2 
, 'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			        ,IdEmpleado		      ,IdPeriodo			    ,IdRubro			      ,IdNomina_Tipo 
,IdNomina_TipoLiqui         ,IdNovedad		      ,SecuenciaNovedad	        ,IdPrestamo			      ,NunCouta                                
,IdDepartamento		        ,Valor			      ,IdUsuario			    ,pe_nombreCompleto        ,Departamento                                                 
,pe_FechaFin		        ,Fecha_Transac	      ,em_nombre			    ,nom_pc				      ,ru_descripcion
,ru_tipo			        ,dias_trabajo	      ,dias_vacaciones	        ,dias_maternidad	      ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	     , liq.IdPeriodo		    , liq.IdRubro		      , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad        , liq.SecuenciaNovedad     , 0			              ,0
, emp.IdDepartamento       , liq.Valor			 , @i_IdUsuario          	, emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			 ,empr.em_nombre            , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 1 AS dias_trabajo   , 1 AS dias_vacaciones     , 1 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
, 2 
, 'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,1 AS dias_trabajo     ,1 AS dias_vacaciones     ,1 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,2 
,'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (emp.IdDepartamento=@IdDepartamento) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)                      
---Fin tipo Consulta D
end

--==============================================================================================================================================================
--Consulta en Lote por todos los empleados
--==============================================================================================================================================================
if(@tipoConsulta = 'L')
begin

---Inserccion Rol Original por Lote

/* insert de prestamos*/
Insert into tbROL_Rpt002
(
 IdEmpresa			         ,IdEmpleado		     ,IdPeriodo			       ,IdRubro			              ,IdNomina_Tipo 
,IdNomina_TipoLiqui          ,IdNovedad		         ,SecuenciaNovedad         ,IdPrestamo			          ,NunCouta                                
,IdDepartamento		         ,Valor			         ,IdUsuario			       ,pe_nombreCompleto	          ,Departamento                                                 
,pe_FechaFin		         ,Fecha_Transac	         ,em_nombre			       ,nom_pc				          ,ru_descripcion
,ru_tipo			         ,dias_trabajo	         ,dias_vacaciones	       ,dias_maternidad	              ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			    , liq.IdEmpleado         , liq.IdPeriodo	     	, liq.IdRubro		          , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui    , 0			             , 0					    , liq.IdPrestamo	          , liq.NunCouta
, emp.IdDepartamento	    , liq.Valor		         , @i_IdUsuario				, emp.pe_nombreCompleto       , emp.Departamento
, pe.pe_FechaFin		    , GETDATE()		         , empr.em_nombre			, @i_nom_pc			          , ru.ru_descripcion
, ru.ru_tipo			    , 2 AS dias_trabajo      , 2 AS dias_vacaciones     , 2 AS dias_maternidad	      , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			        ,IdEmpleado		      ,IdPeriodo			    ,IdRubro			      ,IdNomina_Tipo 
,IdNomina_TipoLiqui         ,IdNovedad		      ,SecuenciaNovedad	        ,IdPrestamo			      ,NunCouta                                
,IdDepartamento		        ,Valor			      ,IdUsuario			    ,pe_nombreCompleto        ,Departamento                                                 
,pe_FechaFin		        ,Fecha_Transac	      ,em_nombre			    ,nom_pc				      ,ru_descripcion
,ru_tipo			        ,dias_trabajo	      ,dias_vacaciones	        ,dias_maternidad	      ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	     , liq.IdPeriodo		    , liq.IdRubro		      , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad        , liq.SecuenciaNovedad     , 0			              ,0
, emp.IdDepartamento       , liq.Valor			 , @i_IdUsuario          	, emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			 ,empr.em_nombre            , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 2 AS dias_trabajo   , 2 AS dias_vacaciones     , 2 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
, 1 
, 'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,2 AS dias_trabajo     ,2 AS dias_vacaciones     ,2 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,1 
,'Original' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)
---Inserccion Rol Copia por Lote

/* insert de prestamos*/
Insert into tbROL_Rpt002
(
 IdEmpresa			         ,IdEmpleado		    ,IdPeriodo			      ,IdRubro			       ,IdNomina_Tipo 
,IdNomina_TipoLiqui          ,IdNovedad		        ,SecuenciaNovedad	      ,IdPrestamo			   ,NunCouta                                
,IdDepartamento		         ,Valor			        ,IdUsuario			      ,pe_nombreCompleto	   ,Departamento                                                 
,pe_FechaFin		         ,Fecha_Transac      	,em_nombre			      ,nom_pc				   ,ru_descripcion
,ru_tipo			         ,dias_trabajo	        ,dias_vacaciones	      ,dias_maternidad	       ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa			    , liq.IdEmpleado         , liq.IdPeriodo		  , liq.IdRubro		          , liq.IdNomina_Tipo
, liq.IdNomina_TipoLiqui    , 0			             , 0					  , liq.IdPrestamo	          , liq.NunCouta
, emp.IdDepartamento	    , liq.Valor		         , @i_IdUsuario			  , emp.pe_nombreCompleto     , emp.Departamento
, pe.pe_FechaFin		    , GETDATE()		         , empr.em_nombre		  , @i_nom_pc			      , ru.ru_descripcion
, ru.ru_tipo			    , 2 AS dias_trabajo      , 2 AS dias_vacaciones   , 2 AS dias_maternidad	  , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - abs(egr.Total_Egr) AS totalNeto
, 2 
, 'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      
                      ro_prestamo_detalle AS pre ON liq.IdEmpresa = pre.IdEmpresa AND liq.IdPrestamo = pre.IdPrestamo AND liq.NunCouta = pre.NumCuota
                      
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo) 

---=======================================================================================================================================================                     
/* insert novedad */ 

Insert into tbROL_Rpt002
(
 IdEmpresa			        ,IdEmpleado		      ,IdPeriodo			    ,IdRubro			      ,IdNomina_Tipo 
,IdNomina_TipoLiqui         ,IdNovedad		      ,SecuenciaNovedad	        ,IdPrestamo			      ,NunCouta                                
,IdDepartamento		        ,Valor			      ,IdUsuario			    ,pe_nombreCompleto        ,Departamento                                                 
,pe_FechaFin		        ,Fecha_Transac	      ,em_nombre			    ,nom_pc				      ,ru_descripcion
,ru_tipo			        ,dias_trabajo	      ,dias_vacaciones	        ,dias_maternidad	      ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa	           , liq.IdEmpleado	     , liq.IdPeriodo		    , liq.IdRubro		      , liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad        , liq.SecuenciaNovedad     , 0			              ,0
, emp.IdDepartamento       , liq.Valor			 , @i_IdUsuario          	, emp.pe_nombreCompleto   , emp.Departamento
, pe.pe_FechaFin           , GETDATE()			 ,empr.em_nombre            , @i_nom_pc               , ru.ru_descripcion
, ru.ru_tipo               , 2 AS dias_trabajo   , 2 AS dias_vacaciones     , 2 AS dias_maternidad    , ing.Total_Ing
, egr.Total_Egr
, ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
, 2 
, 'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo INNER JOIN
                      ro_empleado_novedad_det AS Nov ON liq.IdEmpresa = Nov.IdEmpresa AND liq.IdNovedad = Nov.IdNovedad AND liq.IdEmpleado = Nov.IdEmpleado AND 
                      liq.SecuenciaNovedad = Nov.Secuencia
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)

--==============================================================================================================================================================
/*insert  sin novedad ni prestamos */
Insert into tbROL_Rpt002
(
 IdEmpresa			     ,IdEmpleado		    ,IdPeriodo			     ,IdRubro			        ,IdNomina_Tipo 
,IdNomina_TipoLiqui      ,IdNovedad		        ,SecuenciaNovedad	     ,IdPrestamo			    ,NunCouta                                
,IdDepartamento		     ,Valor			        ,IdUsuario			     ,pe_nombreCompleto	        ,Departamento                                                 
,pe_FechaFin		     ,Fecha_Transac	        ,em_nombre			     ,nom_pc				    ,ru_descripcion
,ru_tipo			     ,dias_trabajo	        ,dias_vacaciones	     ,dias_maternidad	        ,totIng                 
,totEgr				
,totalNeto		
,secuencia			
,OrgCopy
)

SELECT     
liq.IdEmpresa              ,liq.IdEmpleado        ,liq.IdPeriodo            ,liq.IdRubro                 ,liq.IdNomina_Tipo
,liq.IdNomina_TipoLiqui    ,liq.IdNovedad         , liq.SecuenciaNovedad    , liq.IdPrestamo             ,liq.NunCouta
,emp.IdDepartamento        ,liq.Valor             ,@i_IdUsuario             ,emp.pe_nombreCompleto       ,emp.Departamento
,pe.pe_FechaFin            ,GETDATE()             ,empr.em_nombre           ,@i_nom_pc                   ,ru.ru_descripcion
,ru.ru_tipo                ,2 AS dias_trabajo     ,2 AS dias_vacaciones     ,2 AS dias_maternidad        ,ing.Total_Ing
,egr.Total_Egr
,ing.Total_Ing - egr.Total_Egr * - 1 AS totalNeto
,2 
,'Copia' 
FROM         ro_Ing_Egre_x_Empleado AS liq INNER JOIN
                      VWRO_empleado AS emp ON liq.IdEmpleado = emp.IdEmpleado AND liq.IdEmpresa = emp.IdEmpresa INNER JOIN
                      ro_rubro_tipo AS ru ON ru.IdRubro = liq.IdRubro INNER JOIN
                      tb_empresa AS empr ON liq.IdEmpresa = empr.IdEmpresa INNER JOIN
                      ro_periodo AS pe ON liq.IdPeriodo = pe.IdPeriodo AND pe.IdEmpresa = liq.IdEmpresa INNER JOIN
                      vwRO_Ingreso_x_Empleado AS ing ON ing.IdEmpresa = liq.IdEmpresa AND ing.IdEmpleado = liq.IdEmpleado AND ing.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      ing.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND ing.IdPeriodo = liq.IdPeriodo INNER JOIN
                      vwRO_Egreso_x_Empleado AS egr ON egr.IdEmpresa = liq.IdEmpresa AND egr.IdEmpleado = liq.IdEmpleado AND egr.IdNomina_Tipo = liq.IdNomina_Tipo AND 
                      egr.IdNomina_TipoLiqui = liq.IdNomina_TipoLiqui AND egr.IdPeriodo = liq.IdPeriodo
WHERE     (emp.IdEmpresa = @IdEmpresa) AND (liq.IdNomina_Tipo = @IdNomina_Tipo) AND 
                      (liq.IdNomina_TipoLiqui = @IdNomina_TipoLiqui) AND (liq.IdPeriodo = @IdPeriodo)
                       AND (liq.IdNovedad = 0 AND liq.SecuenciaNovedad = 0) AND (liq.IdPrestamo = 0   AND liq.NunCouta = 0)
end

select * from tbROL_Rpt002 
 END