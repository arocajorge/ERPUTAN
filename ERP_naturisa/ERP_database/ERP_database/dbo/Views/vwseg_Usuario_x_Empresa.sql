create view [dbo].[vwseg_Usuario_x_Empresa]
as
SELECT       seg_Usuario_x_Empresa.IdUsuario, seg_Usuario_x_Empresa.IdEmpresa, seg_Usuario_x_Empresa.Observacion, tb_empresa.em_nombre, 
                         tb_empresa.em_ruc
FROM            seg_Usuario_x_Empresa INNER JOIN
                         tb_empresa ON seg_Usuario_x_Empresa.IdEmpresa = tb_empresa.IdEmpresa