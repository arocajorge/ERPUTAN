CREATE PROCEDURE  [CAH].[spSys_mg_Clase_Aca_Paralelo_Mant]
(
@i_Operacion varchar(20)
,@i_IdParalelo int
,@i_IdUntis varchar(50)
,@i_IdAnoLectivo varchar(25)
,@i_Descripcion	varchar(50)
,@i_isActive nchar
,@i_fecha_transaccion datetime
,@i_fecha_modificacion datetime
)
as
begin


declare @a_IdParalelo  int
declare @a_IdAnoLectivo	int
declare @a_CodParalelo	varchar	(50)
declare @a_IdCurso	int
declare @a_CodAlterno varchar (50)
declare @a_Descripcion_paralelo	varchar(50)
declare @a_estado	nchar	(1)
declare @a_FechaCreacion	datetime
declare @a_FechaModificacion	datetime	
declare @a_UsuarioCreacion	varchar	(25)
declare @a_UsuarioModificacion	varchar	(25)
declare @i_idcurso int



set @a_IdParalelo =@i_IdParalelo
set @a_IdAnoLectivo =@i_IdAnoLectivo
set @a_CodParalelo =''
set @a_CodAlterno =''
set @a_FechaCreacion =@i_fecha_transaccion
set @a_FechaModificacion =@i_fecha_modificacion	
set @a_UsuarioCreacion='sys_aca_mig'
set @a_UsuarioModificacion='sys_aca_mig'

select @i_idcurso  =  p.id_curso from Academico_SQL.dbo.mg_asignacion_curso_clase as p
where p.id_clase = @a_IdParalelo
if (@i_idcurso is null ) 
set @a_IdCurso = '1'
else 
set @a_IdCurso =@i_idcurso 


if (@i_Descripcion is null )
set @a_Descripcion_paralelo = ''
else 
set @a_Descripcion_paralelo=@i_Descripcion
 
if (@i_isActive = 1)
set @a_estado= 'A'
else
set @a_estado= 'I'



if (@i_Operacion='INSERT')
	begin		
		INSERT INTO [dbo].Aca_Paralelo
					(
					 [IdParalelo]					,[IdAnioLectivo]			,[CodParalelo]          ,[IdCurso]		,[CodUntis] 
					,[CodAlterno]                   ,[Descripcion_paralelo]		,[estado]			    ,[FechaCreacion]	
					,[FechaModificacion]			,[UsuarioCreacion]			,[UsuarioModificacion]		
					
					)
					values
					(
					 @a_IdParalelo				  ,@a_IdAnoLectivo		       ,@a_CodParalelo            ,@a_IdCurso		,@i_IdUntis
					,@a_CodAlterno			      ,@a_Descripcion_paralelo     ,@a_estado		          ,@a_FechaCreacion
					,@a_FechaModificacion	      ,@a_UsuarioCreacion		   ,@a_UsuarioModificacion											
					)
	end

if (@i_Operacion='UPDATE')
	begin
		update Aca_Paralelo
			set 
			CodParalelo = @a_CodParalelo,
			IdCurso = @a_IdCurso,
			CodAlterno = @a_CodAlterno,
			CodUntis = @i_IdUntis,		
			Descripcion_paralelo = @a_Descripcion_paralelo,
			estado = @a_estado,			
			FechaModificacion=@a_FechaModificacion
			where IdParalelo=@a_IdParalelo 

	end			
end