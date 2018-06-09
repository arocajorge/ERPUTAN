create view CAH.vwmg_alumno_x_Aca_estudiante
as
SELECT        CAH.mg_alumno_x_Aca_estudiante.id_alumno_academico, CAH.mg_alumno_x_Aca_estudiante.IdInstitucion, CAH.mg_alumno_x_Aca_estudiante.IdEstudiante, Aca_estudiante.FechaModificacion, 
                         Aca_estudiante.FechaCreacion
FROM            Aca_estudiante INNER JOIN
                         CAH.mg_alumno_x_Aca_estudiante ON Aca_estudiante.IdInstitucion = CAH.mg_alumno_x_Aca_estudiante.IdInstitucion AND Aca_estudiante.IdEstudiante = CAH.mg_alumno_x_Aca_estudiante.IdEstudiante