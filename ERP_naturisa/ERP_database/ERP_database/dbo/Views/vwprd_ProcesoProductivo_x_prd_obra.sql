CREATE VIEW [dbo].[vwprd_ProcesoProductivo_x_prd_obra]
AS
SELECT     A.IdEmpresa_Pr, A.IdProcesoProductivo, A.IdEmpresa_obra, A.CodObra, P.Nombre
FROM         dbo.prd_ProcesoProductivo_x_prd_obra AS A INNER JOIN
                      dbo.prd_ProcesoProductivo AS P ON A.IdEmpresa_Pr = P.IdEmpresa AND A.IdProcesoProductivo = P.IdProcesoProductivo