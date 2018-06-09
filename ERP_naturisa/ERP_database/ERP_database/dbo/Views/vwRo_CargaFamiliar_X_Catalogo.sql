Create view [dbo].[vwRo_CargaFamiliar_X_Catalogo]
as
select A.IdEmpresa,A.IdCargaFamiliar,A.IdEmpleado,A.Cedula,A.Sexo,A.TipoFamiliar,B.ca_descripcion,A.Nombres,A.FechaNacimiento,A.Estado 
from ro_CargaFamiliar A inner join ro_Catalogo B on A.TipoFamiliar = B.CodCatalogo where B.IdTipoCatalogo = 3 ;