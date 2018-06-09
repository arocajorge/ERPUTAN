create view  [dbo].[vwRo_Novedades_Batch] as

SELECT        dbo.ro_Novedad_Subida_Bach.IdEmpresa, dbo.ro_Novedad_Subida_Bach.IdCalendario, dbo.ro_Novedad_Subida_Bach.IdRubro, 
                         dbo.ro_Novedad_Subida_Bach.Fecha, dbo.ro_Novedad_Subida_Bach.Estado, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_rubro_tipo.NombreCorto, 
                         dbo.ro_Novedad_Subida_Bach.IdCarga
FROM            dbo.ro_Novedad_Subida_Bach INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_Novedad_Subida_Bach.IdRubro = dbo.ro_rubro_tipo.IdRubro