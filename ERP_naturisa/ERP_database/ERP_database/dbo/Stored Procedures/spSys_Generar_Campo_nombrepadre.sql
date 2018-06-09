--use DBERP

-- exec spSIS_Generar_Campo_nombrepadre 
CREATE   proc [dbo].[spSys_Generar_Campo_nombrepadre] 
as
begin

declare @idPadre varchar(50)
declare @NomPadre varchar(5000)
declare @C_IdCategoria varchar(50)



update in_categorias
set rutapadre=''



    
    DECLARE cursor_categoria CURSOR FOR 
		select idcategoria 
		from in_categorias
		
    OPEN cursor_categoria
    
    FETCH NEXT FROM cursor_categoria 
    INTO @C_IdCategoria

    --IF @@FETCH_STATUS <> 0 
    WHILE @@FETCH_STATUS = 0
    BEGIN

       
       
       
			set @idPadre =@C_IdCategoria

			select @NomPadre= isnull(rutapadre,'') + '\' + ca_Categoria  from in_categorias where IdCategoria like @idPadre
			update in_categorias
			set rutapadre=@NomPadre 
			where IdCategoriaPadre like @idPadre


        FETCH NEXT FROM cursor_categoria 
        INTO @C_IdCategoria
        END;

    CLOSE cursor_categoria
    DEALLOCATE cursor_categoria
   
   
   
update in_categorias
set rutapadre=''
where rutapadre is null

   
    




end 



/*
update in_categorias
set rutapadre=null
*/