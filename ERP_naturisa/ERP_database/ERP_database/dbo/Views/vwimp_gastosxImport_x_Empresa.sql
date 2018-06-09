create view [dbo].[vwimp_gastosxImport_x_Empresa]
as
select B.IdEmpresa ,A.IdGastoImp,A.CodGastoImp,A.ga_decripcion,A.ga_estado  
from dbo.imp_gastosxImport A ,tb_empresa B