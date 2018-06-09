CREATE proc [CAH].[spMg_tb_provincia_Mant]
(
 @i_Operacion	varchar(20)
,@i_IdProvincia_Academico	int	
,@i_IdPais_Academico	int	
,@i_nombre_provincia	varchar(255)

--,@i_fecha_ingreso	datetime	
--,@i_fecha_transaccion	datetime	
--,@i_fecha_modificacion	datetime	
--,@o_w_IdEstudiante varchar(250) output

)
as 
begin 

declare @w_IdProvincia_Academico int
declare @w_IdPais_Academico	int
declare @w_nombre_provincia	varchar	(255)
declare @w_IdProvincia_Erp	varchar	(10)
declare @w_IdPais_Erp	varchar	(10)

declare @w_FechaModificacion	datetime	
declare @w_FechaCreacion	datetime	
declare @w_UsuarioModificacion	varchar	(25)
declare @w_UsuarioCreacion	varchar	(25)
declare @w_estado char(1)
declare @w_CodProvincia varchar(25)


set @w_FechaModificacion	= GETDATE()
set @w_FechaCreacion	= GETDATE()
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'
set @w_nombre_provincia = upper(@i_nombre_provincia)
set @w_estado = 'A'
--set @w_CodProvincia = @i_ISO3

--select @w_IdPais_Nacionalidad=IdPais from tb_pais where Nombre like '%ECUADOR%'

--select @w_IdPersona = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@i_id_persona


--select @w_IdInstitucion=
--Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

	--set @o_w_IdEstudiante = @i_Operacion;
	if (@i_Operacion='INSERT')
	begin
		--set @o_w_IdEstudiante = 'HOLA';
		--return 'INSERT';
		--set @o_w_IdEstudiante = 'SELECT id_alumno_academico FROM CAH.mg_alumno_x_Aca_estudiante estu where estu.id_alumno_academico = ' + Convert(varchar(10),@i_id);
		
		--if not exists( select IdProvincia from tb_provincia where Descripcion_Prov like '%'+@w_nombre_provincia+'%' )
		--begin
		--	set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		--end
		--set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		
		--begin
			--print 'NO EXISTE PAIS EN ERP, por nombre';
			if not exists (Select IdProvincia_Erp from CAH.tb_provincia_x_mg_provincia where IdProvincia_Academico = @i_IdProvincia_Academico)
			begin
				--print 'NO EXISTE PAIS EN TABLA INTERMEDIA'
				print 'IdPaisAcademico:' + Convert(varchar(10),@i_IdPais_Academico);
				

				select  @w_IdProvincia_Erp = ISNULL(MAX(Convert(int,p.IdProvincia)),0)+1 from tb_provincia p --where p.IdInstitucion=@w_IdInstitucion
				select  @w_IdPais_Erp = pa.IdPais_Erp from CAH.tb_pais_x_mg_pais pa where pa.IdPais_Academico = @i_IdPais_Academico
				set @w_CodProvincia = @w_IdProvincia_Erp;

				print ' IdPais ERP:' + @w_IdPais_Erp;

				--print @w_CodPais

					INSERT INTO [dbo].tb_provincia
					(
					 [IdProvincia]					,[Cod_Provincia]			,[Descripcion_Prov]			,[estado]						
					 ,[IdPais]						,[IdUsuario]				,[Fecha_Transac]			,[IdUsuarioUltMod]
					,[Fecha_UltMod]					
					)
					values
					(
					 @w_IdProvincia_Erp				,@w_CodProvincia			,@w_nombre_provincia		,@w_estado	
					,@w_IdPais_Erp					,@w_UsuarioCreacion			,@w_FechaCreacion			,@w_UsuarioModificacion	
					,@w_FechaModificacion				
					)
		


					INSERT INTO [CAH].[tb_provincia_x_mg_provincia]
					   ([IdProvincia_Erp]				,[IdProvincia_Academico]			
					   ,[nota1]								,[nota2]
					   )
					 values
					 (@w_IdProvincia_Erp				,@i_IdProvincia_Academico	
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