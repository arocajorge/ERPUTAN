
create view [dbo].[vwfa_clientes_contactos]
as
SELECT        fa_cliente_contactos.IdEmpresa_cli, fa_cliente_contactos.IdCliente, vwtb_contacto.*
FROM          fa_cliente_contactos INNER JOIN
              vwtb_contacto ON fa_cliente_contactos.IdContacto = vwtb_contacto.IdContacto AND fa_cliente_contactos.IdEmpresa_cont = vwtb_contacto.IdEmpresa