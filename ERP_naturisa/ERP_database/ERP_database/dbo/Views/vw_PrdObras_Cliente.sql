CREATE view   [dbo].[vw_PrdObras_Cliente] as
 SELECT        '' AS cl_RazonSocial, dbo.prd_Obra.IdEmpresa, dbo.prd_Obra.CodObra, dbo.prd_Obra.Descripcion, dbo.prd_Obra.Estado, dbo.prd_Obra.Fecha, 
                         dbo.prd_Obra.IdCentroCosto, dbo.prd_Obra.IdUsuario, dbo.prd_Obra.IdUsuarioAnu, dbo.prd_Obra.MotivoAnu, dbo.prd_Obra.IdUsuarioUltModi, 
                         dbo.prd_Obra.FechaAnu, dbo.prd_Obra.FechaTransac, dbo.prd_Obra.FechaUltModi, dbo.prd_Obra.IdCliente
FROM            dbo.fa_cliente INNER JOIN
                         dbo.prd_Obra ON dbo.fa_cliente.IdCliente = dbo.prd_Obra.IdCliente and fa_cliente.IdEmpresa=prd_Obra.IdEmpresa