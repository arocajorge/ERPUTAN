
CREATE view [dbo].[vwAca_profesor] as
select p.IdInstitucion , p.IdProfesor, p.CodProfesor,p.IdPersona,pe.pe_cedulaRuc,pe.pe_sexo,pe.pe_nombre,pe.pe_apellido,pe.pe_nombreCompleto,p.estado,'S' as Base
 from Aca_Profesor p inner join tb_persona pe on pe.IdPersona=p.IdPersona
 union
 select 0 as IdInstitucion , 0 as IdProfesor, '' as CodProfesor,per.IdPersona,per.pe_cedulaRuc,per.pe_sexo,per.pe_nombre,per.pe_apellido,per.pe_nombreCompleto,per.pe_estado as estado,'N' as Base
  from tb_persona per
  where not exists(select p.IdInstitucion , p.IdProfesor, p.CodProfesor,p.IdPersona,p.estado
                     from Aca_Profesor p inner join tb_persona pe on pe.IdPersona=p.IdPersona
				     where p.IdPersona=per.IdPersona)