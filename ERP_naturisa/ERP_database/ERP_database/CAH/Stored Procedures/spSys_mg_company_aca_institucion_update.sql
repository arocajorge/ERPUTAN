CREATE PROCEDURE  CAH.[spSys_mg_company_aca_institucion_update]
(
@i_IdInstitucion int ,
@i_IdEmpresa int ,
--@i_Ruc varchar(50),
@i_Nombre varchar(50),
--@i_Direccion varchar(100),
@i_IdPais varchar(10),
@i_IdProvincia varchar(25),
@i_IdCiudad varchar(25),
@i_fecha_modificacion datetime
)
as

			update Aca_Institucion
			set 
			IdEmpresa = @i_IdEmpresa,
			IdInstitucion = @i_IdInstitucion,
			Nombre = @i_Nombre,
		    IdPais = @i_IdPais,
            IdProvincia = @i_IdProvincia,
            IdCiudad = @i_IdCiudad,
			FechaModificacion=@i_fecha_modificacion
			where IdInstitucion=@i_IdInstitucion