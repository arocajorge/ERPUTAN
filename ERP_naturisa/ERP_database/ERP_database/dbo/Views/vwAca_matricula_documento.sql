
CREATE view [dbo].[vwAca_matricula_documento] as

SELECT        md.IdInstitucion, md.IdSede, md.IdMatricula, td.IdTipoDocumento, td.descripcion, md.Archivo
,CAST(1 AS bit) as Existe_en_Base , md.Estado
FROM            Aca_matricula_Tipo_documento AS td INNER JOIN
                         Aca_matricula_x_documento AS md ON md.IdTipoDocumento = td.IdTipoDocumento
WHERE        (td.Estado = 'A')

UNION

select IdInstitucion, IdSede, IdMatricula, IdTipoDocumento, descripcion, Archivo,Existe_en_Base , p.Estado
from (
SELECT        md.IdInstitucion, md.IdSede, md.IdMatricula, td.IdTipoDocumento, td.descripcion, md.Archivo
,CAST(0 AS bit) as Existe_en_Base , md.Estado
FROM            Aca_matricula_Tipo_documento AS td CROSS JOIN
                         Aca_matricula_x_documento AS md
) as P
WHERE       not exists(

		select IdInstitucion from Aca_matricula_x_documento A
		where A.IdInstitucion=P.IdInstitucion
		and A.IdSede=P.IdSede
		and A.IdMatricula=P.IdMatricula
		and A.IdTipoDocumento=P.IdTipoDocumento
)
UNION

select 0 IdInstitucion, 0 IdSede, 0 IdMatricula, IdTipoDocumento, descripcion, Archivo,CAST(0 AS bit) as Existe_en_Base  , 'A' as Estado
FROM Aca_matricula_Tipo_documento