CREATE proc [CAH].[spMg_matricula_Aca_matricula]
(
 @i_Operacion	varchar(20)
,@i_id_sede numeric 
,@i_id	numeric
,@i_id_anio_lectivo	numeric	
,@i_id_alumno	numeric	
,@i_id_clase	numeric	
,@i_id_rep_legal	numeric	
,@i_id_rep_economico	numeric	
,@i_id_mecanismo_pago	numeric	
,@i_publicacion_multimedia	int	
,@i_id_user_ingreso	numeric	
,@i_fecha_ingreso	date	
,@i_codigo_convivencia	numeric	
,@i_estado	nvarchar	(50)
,@i_aprobacion	nvarchar	(50)
,@i_fecha_actualizacion	datetime	
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	
,@i_id_persona_rep_economico	numeric	
,@i_id_persona_rep_legal	numeric	

)
as 
begin 


declare @w_IdInstitucion	int
declare @w_IdSede	int	
declare @w_IdMatricula	numeric	
declare @w_CodMatricula	varchar (50)	
declare @w_Fecha_matricula	date
declare @w_IdEstudiante	numeric	
declare @w_IdAnioLectivo	varchar	(25)
declare @w_IdFamiliar_repre_legal	numeric	
declare @w_IdFamiliar_repre_econ	numeric	
declare @w_Observacion	varchar	(250)
declare @w_estado	char	(1)
declare @w_IdParalelo	int	
declare @w_Si_estoy_deacuerdo_foto	bit	
declare @w_Cod_convivencia_doy_fe	bit	
declare @w_No_estoy_deacuerdo_foto	bit	
declare @w_tiene_seguro	bit	
declare @w_FechaCreacion	datetime	
declare @w_FechaModificacion	datetime
declare @w_FechaAnulacion	datetime	
declare @w_UsuarioCreacion	varchar	(50)
declare @w_UsuarioModificacion	varchar	(50)
declare @w_UsuarioAnulacion	varchar	(50)
declare @w_MotivoAnulacion	varchar	(150)
declare @w_id_persona_rep_legal numeric	
declare @w_id_persona_rep_economico numeric	

select @w_IdInstitucion=
Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1


select @w_IdSede=IdSede from Aca_Sede where IdInstitucion=@w_IdInstitucion and IdSede=@i_id_sede
set @w_IdMatricula	=@i_id	
set @w_CodMatricula	=@i_id
set @w_Fecha_matricula	=@i_fecha_ingreso



select @w_IdEstudiante	 = IdEstudiante from cah.mg_alumno_x_Aca_estudiante where IdInstitucion=@w_IdInstitucion and id_alumno_academico=@i_id_alumno


select @w_IdAnioLectivo = IdAnioLectivo from cah.Aca_Anio_Lectivo_x_mg_anio_lectivo where IdInstitucion=@w_IdInstitucion and id_anio_lectivo_aca=@i_id_anio_lectivo


--select * from Aca_Familiar
--por hacer estos id
select @w_id_persona_rep_economico = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico = @i_id_persona_rep_economico
select @w_id_persona_rep_legal = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico = @i_id_persona_rep_legal

select @w_IdFamiliar_repre_legal	= IdFamiliar from dbo.Aca_Familiar where IdPersona = @w_id_persona_rep_legal
select @w_IdFamiliar_repre_econ	= IdFamiliar from dbo.Aca_Familiar where IdPersona = @w_id_persona_rep_economico

set @w_Observacion	='Migrado del Academico WEB'
set @w_estado	='I'



------------ por confirmar
set @w_IdParalelo	=@i_id_clase


set @w_Si_estoy_deacuerdo_foto	=0
set @w_Cod_convivencia_doy_fe	=0
set @w_No_estoy_deacuerdo_foto	=0
set @w_tiene_seguro	=0


set @w_FechaCreacion	 =GETDATE()
set @w_UsuarioCreacion	= 'sys_aca_mig'


set @w_FechaModificacion =null
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_FechaAnulacion	=null
set @w_UsuarioAnulacion	=null
set @w_MotivoAnulacion	=null





	if (@i_Operacion='INSERT')
	begin
		if not exists( select id_matricula_aca from CAH.Aca_matricula_x_mg_matricula where id_matricula_aca=@i_id )
		begin

		   
			print 'Cod '+ cast(@i_id as varchar(20))

			
		    insert into aca_matricula
		    ( IdInstitucion		,IdSede				,IdMatricula				,CodMatricula			,Fecha_matricula
			,IdEstudiante		,IdAnioLectivo		,IdFamiliar_repre_legal		,IdFamiliar_repre_econ	,Observacion
			,estado				,IdParalelo			,Si_estoy_deacuerdo_foto	,Cod_convivencia_doy_fe	,No_estoy_deacuerdo_foto
			,tiene_seguro		,FechaCreacion		,FechaModificacion			,FechaAnulacion			,UsuarioCreacion
			,UsuarioModificacion,UsuarioAnulacion	,MotivoAnulacion
			)
			values
			(
			 @w_IdInstitucion		,@w_IdSede				,@w_IdMatricula					,@w_CodMatricula			,@w_Fecha_matricula
			,@w_IdEstudiante		,@w_IdAnioLectivo		,@w_IdFamiliar_repre_legal		,@w_IdFamiliar_repre_econ	,@w_Observacion
			,@w_estado				,@w_IdParalelo			,@w_Si_estoy_deacuerdo_foto		,@w_Cod_convivencia_doy_fe	,@w_No_estoy_deacuerdo_foto
			,@w_tiene_seguro		,@w_FechaCreacion		,@w_FechaModificacion			,@w_FechaAnulacion			,@w_UsuarioCreacion
			,@w_UsuarioModificacion	,@w_UsuarioAnulacion	,@w_MotivoAnulacion
			)
			
				INSERT INTO CAH.Aca_matricula_x_mg_matricula
						( 
						  IdInstitucion       , IdSede              , IdMatricula        , id_matricula_aca      , nota1
						)
					 values
					    (	
					      @w_IdInstitucion    , @w_IdSede            ,@w_IdMatricula      ,@i_id                  ,'INSERT - if (@i_Operacion=INSERT)'	
							
					    )

		end 

	end

	

	if (@i_Operacion='UPDATE')
	begin

		print 'por realizar'	
	end 
		
end