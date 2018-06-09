CREATE  proc [CAH].[spMg_Anio_Lectivo]
(
 @i_Operacion	varchar(20)
,@i_id	numeric	
,@i_descripcion	nvarchar(500)
,@i_fecha_inicio	datetime
,@i_fecha_fin	datetime
,@i_estado	nvarchar(20)
,@i_archivo_untis_gpn	nvarchar(400)
,@i_isAdmision	numeric	
,@i_id_anio_lectivo_promover	numeric	
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	
)
as 
begin 


--sp_help Aca_Anio_Lectivo


declare @w_IdInstitucion	int	
declare @w_IdAnioLectivo	int
declare @w_Descripcion	varchar	(50)
declare @w_Estado	nchar(2)



if (@i_estado='A')
begin
	set @w_Estado='A'
end 
else
begin
	set @w_Estado='I'
end

set @w_IdAnioLectivo=@i_id
set @w_Descripcion	=@i_descripcion


select @w_IdInstitucion=
Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

	
	if (@i_Operacion='INSERT')
	begin
		
		if not exists( SELECT id_anio_lectivo_aca FROM CAH.Aca_Anio_Lectivo_x_mg_anio_lectivo estu where estu.id_anio_lectivo_aca =@i_id )
		begin


					INSERT INTO [dbo].Aca_Anio_Lectivo
					(
						IdInstitucion		,IdAnioLectivo			,Descripcion			,FechaInicio	,FechaFin		,Estado
						,UsuarioCreacion	,FechaCreacion			,FechaModificacion
					)
					values
					(
					 @w_IdInstitucion		,@w_IdAnioLectivo			,@i_descripcion			,@i_fecha_inicio	,@i_fecha_fin	,@w_Estado
						,'sys_migrado'		,@i_fecha_transaccion	,@i_fecha_modificacion
					)
	

					INSERT INTO [CAH].Aca_Anio_Lectivo_x_mg_anio_lectivo
					(IdInstitucion	,IdAnioLectivo		,id_anio_lectivo_aca	
					,nota1)
					 values
					 (
					 @w_IdInstitucion ,@w_IdAnioLectivo	,@i_id			
					 ,'INSERT - if (@i_Operacion=INSERT)'	
					 )

					 
		end 

	end

	
	if (@i_Operacion='UPDATE')
	begin


		SELECT @w_IdAnioLectivo=IdAnioLectivo
		FROM [CAH].Aca_Anio_Lectivo_x_mg_anio_lectivo
		WHERE id_anio_lectivo_aca =@i_id



		UPDATE [dbo].Aca_Anio_Lectivo
		SET 
			Estado=@w_Estado
			,FechaModificacion=@i_fecha_modificacion	
		WHERE 		
			IdInstitucion=@w_IdInstitucion
		AND IdAnioLectivo=@w_IdAnioLectivo


		

		update [CAH].Aca_Anio_Lectivo_x_mg_anio_lectivo
		set 
		   nota1='UDPATE - if (@i_Operacion=UPDATE)'
		where 
			id_anio_lectivo_aca =@i_id

	end 

	


		
end