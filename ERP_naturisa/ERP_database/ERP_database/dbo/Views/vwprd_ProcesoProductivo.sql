
CREATE VIEW [dbo].[vwprd_ProcesoProductivo]
AS
SELECT     PP.Estado AS pp_Estado, PPxOBRA.IdEmpresa_Pr, PPxOBRA.IdProcesoProductivo, PPxOBRA.CodObra, OB.Descripcion AS ob_descripcion, PP.Nombre, OB.Fecha, 
                      OB.Estado AS ob_Estado
FROM         dbo.prd_ProcesoProductivo AS PP INNER JOIN
                      dbo.prd_ProcesoProductivo_x_prd_obra AS PPxOBRA ON PP.IdEmpresa = PPxOBRA.IdEmpresa_Pr AND 
                      PP.IdProcesoProductivo = PPxOBRA.IdProcesoProductivo INNER JOIN
                      dbo.prd_Obra AS OB ON PPxOBRA.CodObra = OB.CodObra AND PPxOBRA.IdEmpresa_obra = OB.IdEmpresa