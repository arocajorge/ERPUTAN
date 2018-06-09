create view CAH.vwtb_persona_x_mg_persona
as

SELECT        
CAH.tb_persona_x_mg_persona.IdPersona_Erp, CAH.tb_persona_x_mg_persona.IdPersona_Academico, tb_persona.CodPersona, tb_persona.pe_Naturaleza, tb_persona.pe_nombreCompleto, 
                         tb_persona.pe_razonSocial, tb_persona.pe_apellido, tb_persona.pe_nombre, tb_persona.IdTipoPersona, tb_persona.IdTipoDocumento, tb_persona.pe_cedulaRuc, tb_persona.pe_fechaCreacion, 
                         tb_persona.pe_fechaModificacion
FROM            CAH.tb_persona_x_mg_persona INNER JOIN
                         tb_persona ON CAH.tb_persona_x_mg_persona.IdPersona_Erp = tb_persona.IdPersona