
CREATE VIEW [dbo].[vwAca_Familiar_x_Estudiante_Padre]
AS
SELECT        dbo.Aca_Familiar_x_Estudiante.IdEstudiante, dbo.Aca_Familiar_x_Estudiante.IdFamiliar, dbo.tb_persona.pe_apellido AS Apellido, dbo.tb_persona.pe_nombre AS Nombre, 
                         dbo.tb_persona.pe_cedulaRuc AS Cedula, dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat, dbo.Aca_Familiar.IdPersona, dbo.Aca_Familiar.Titulo, dbo.Aca_Familiar.empresa_telefono, 
                         dbo.Aca_Familiar.empresa_donde_trabaja, dbo.Aca_Familiar.empresa_direccion, dbo.Aca_Familiar.IdNivelEducativo_cat, dbo.Aca_Familiar_x_Estudiante.IdInstitucion
FROM            dbo.Aca_Familiar_x_Estudiante INNER JOIN
                         dbo.Aca_Familiar ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Familiar.IdInstitucion AND dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Familiar.IdFamiliar INNER JOIN
                         dbo.tb_persona ON dbo.Aca_Familiar.IdPersona = dbo.tb_persona.IdPersona
WHERE        (dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = 'PADR')