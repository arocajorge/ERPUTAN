CREATE proc [CAH].[spMg_tb_ciudad_Mant]
(
 @i_Operacion	varchar(20)
,@i_IdCiudad_Academico	int	
,@i_IdProvincia_Academico	int	
,@i_IdPais_Academico	int	
,@i_nombre_ciudad	varchar(255)

--,@i_fecha_ingreso	datetime	
--,@i_fecha_transaccion	datetime	
--,@i_fecha_modificacion	datetime	
--,@o_w_IdEstudiante varchar(250) output

)
as 
begin 
declare @w_IdCiudad_Academico	int	
declare @w_IdProvincia_Academico int
declare @w_IdPais_Academico	int
declare @w_nombre_ciudad	varchar	(255)
declare @w_IdProvincia_Erp	varchar	(10)
declare @w_IdPais_Erp	varchar	(10)
declare @w_IdCiudad_Erp	varchar	(10)

declare @w_FechaModificacion	datetime	
declare @w_FechaCreacion	datetime	
declare @w_UsuarioModificacion	varchar	(25)
declare @w_UsuarioCreacion	varchar	(25)
declare @w_estado char(1)
declare @w_CodCiudad varchar(25)


set @w_FechaModificacion	= GETDATE()
set @w_FechaCreacion	= GETDATE()
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'
set @w_nombre_ciudad = upper(@i_nombre_ciudad)
set @w_estado = 'A'


	--set @o_w_IdEstudiante = @i_Operacion;
	if (@i_Operacion='INSERT')
	begin
		
			if not exists (Select IdCiudad_Erp from CAH.tb_ciudad_x_mg_ciudad where IdCiudad_Academico = @i_IdCiudad_Academico and IdPais_Academico = @i_IdPais_Academico and IdProvincia_Academico = @i_IdProvincia_Academico
							)
			begin
				--print 'NO EXISTE PAIS EN TABLA INTERMEDIA'
				--print 'IdPaisAcademico:' + Convert(varchar(10),@i_IdPais_Academico);
				

				select  @w_IdCiudad_Erp = ISNULL(MAX(Convert(int,c.IdCiudad)),0)+1 from tb_ciudad c --where p.IdInstitucion=@w_IdInstitucion
				select  @w_IdPais_Erp = pa.IdPais_Erp from CAH.tb_pais_x_mg_pais pa where pa.IdPais_Academico = @i_IdPais_Academico
				select  @w_IdProvincia_Erp = pa.IdProvincia_Erp from CAH.tb_provincia_x_mg_provincia pa where pa.IdProvincia_Academico = @i_IdProvincia_Academico

				set @w_CodCiudad = @w_IdCiudad_Erp;

				print ' IdPais ERP:' + @w_IdPais_Erp;

				--print @w_CodPais

					INSERT INTO [dbo].tb_ciudad
					(
					 [IdCiudad]						,[Cod_Ciudad]				,[Descripcion_Ciudad]		,[Estado]						
					 ,[IdProvincia]					,[IdUsuario]				,[Fecha_Transac]			,[IdUsuarioUltMod]
					,[Fecha_UltMod]					
					)
					values
					(
					 @w_IdCiudad_Erp				,@w_CodCiudad				,@w_nombre_ciudad			,@w_estado	
					,@w_IdProvincia_Erp				,@w_UsuarioCreacion			,@w_FechaCreacion			,@w_UsuarioModificacion	
					,@w_FechaModificacion				
					)
		


					INSERT INTO [CAH].[tb_ciudad_x_mg_ciudad]
						(	[IdCiudad_Erp]				,[IdCiudad_Academico]		,[IdPais_Academico]			,[IdProvincia_Academico]
							,[nota1]								,[nota2]
					   )
					 values
						(	@w_IdCiudad_Erp				,@i_IdCiudad_Academico		,@i_IdPais_Academico		,@i_IdProvincia_Academico	
							,'INSERT - if (@i_Operacion=INSERT)'	,null
						)

				end	 
		--end 

	end

	--if (@i_Operacion='UPDATE')
	--begin


	--	SELECT @w_IdInstitucion=IdInstitucion,@w_IdEstudiante=IdEstudiante 
	--	FROM [CAH].[mg_alumno_x_Aca_estudiante] 
	--	WHERE id_alumno_academico=@i_id


	--	UPDATE [dbo].[Aca_estudiante]
	--	SET 
	--		IdPais_Nacionalidad=@w_IdPais_Nacionalidad
	--		,FechaModificacion=@i_fecha_modificacion	
	--	WHERE 		
	--		IdInstitucion=@w_IdInstitucion
	--	AND IdEstudiante=@w_IdEstudiante


	--	update [CAH].[mg_alumno_x_Aca_estudiante]
	--	set 
	--	   nota2='UDPATE - if (@i_Operacion=UPDATE)'
	--	where 
	--		id_alumno_academico=@i_id
	--	and IdInstitucion=@w_IdInstitucion
	--	and IdEstudiante=@w_IdEstudiante
	--end 
		
end