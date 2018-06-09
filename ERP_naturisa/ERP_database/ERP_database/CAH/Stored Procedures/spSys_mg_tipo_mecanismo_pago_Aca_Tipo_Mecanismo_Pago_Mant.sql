CREATE PROCEDURE  [CAH].[spSys_mg_tipo_mecanismo_pago_Aca_Tipo_Mecanismo_Pago_Mant]
(
@i_Operacion varchar(20),
@i_Id int ,
@i_id_banco int ,
@i_nombre	varchar(250),
@i_isActive nchar,
@i_tipo_cuenta varchar(50),
@i_forma_pago varchar(50),
@i_code varchar(50),
@i_fecha_transaccion datetime,
@i_fecha_modificacion datetime
)
as
begin

declare @a_Id_tipo_meca_pago int
declare @a_Id_tb_banco_x_mgbanco	int
declare @a_nombre	varchar	(250)
declare @a_estado	nchar	(1)
declare @a_tipo_cuenta	varchar	(50)
declare @a_forma_pago	varchar(50)
declare @a_codigo varchar	(50)
declare @a_FechaCreacion	datetime
declare @a_FechaModificacion	datetime	
declare @a_UsuarioCreacion	varchar	(25)
declare @a_UsuarioModificacion	varchar	(25)



set @a_Id_tipo_meca_pago =@i_Id
if(@i_id_banco is null)
set @i_id_banco = 6

select @a_Id_tb_banco_x_mgbanco = Id_tb_banco_x_mgbanco from CAH.tb_banco_x_mg_banco where IdBanco_Academico = @i_id_banco


set @a_nombre = @i_nombre
if (@i_isActive = '1')
set @a_estado= 'A'
else
set @a_estado= 'I'
set @a_tipo_cuenta =@i_tipo_cuenta
set @a_forma_pago = @i_forma_pago
set @a_codigo = @i_code

set @a_FechaCreacion =@i_fecha_transaccion
set @a_FechaModificacion =@i_fecha_modificacion	
set @a_UsuarioCreacion='sys_aca_mig'
set @a_UsuarioModificacion='sys_aca_mig'


if (@i_Operacion='INSERT')
	begin
		
		INSERT INTO dbo.Aca_Tipo_Mecanismo_Pago
					(
					 [Id_tipo_meca_pago]	,[Id_tb_banco_x_mgbanco]		,[Nombre]              ,[Estado]
					,[Tipo_cuenta]			,[Forma_pago]                   ,[Codigo]              ,[IdUsuarioCreacion]
					,[FechaCreacion]	    ,[IdUsuarioModificacion]        ,[FechaModificacion]   
					  	    		
					
					)
					values
					(
					 @a_Id_tipo_meca_pago	    ,@a_Id_tb_banco_x_mgbanco  ,@a_nombre              ,@a_estado
					,@a_tipo_cuenta			    ,@a_forma_pago			   ,@a_codigo              ,@a_UsuarioCreacion	
					,@a_FechaCreacion           ,@a_UsuarioModificacion    ,@a_FechaModificacion
						    	  	
										
					)


	end


if (@i_Operacion='UPDATE')
	begin

		update Aca_Tipo_Mecanismo_Pago
			set 
			
			
			nombre = @a_nombre,
			estado = @a_estado,	
			Tipo_cuenta = @a_tipo_cuenta,
			Forma_pago= @a_forma_pago,
			Codigo = @a_codigo,
			FechaModificacion=@a_FechaModificacion,
			IdUsuarioModificacion=@a_UsuarioModificacion
			where Id_tipo_meca_pago =@a_Id_tipo_meca_pago and Id_tb_banco_x_mgbanco=@a_Id_tb_banco_x_mgbanco

	end

			

end