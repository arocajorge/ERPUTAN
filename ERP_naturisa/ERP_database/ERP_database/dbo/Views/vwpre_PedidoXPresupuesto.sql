create view [dbo].[vwpre_PedidoXPresupuesto]
as
select p.IdEmpresa,p.IdPedidoXPre,d.de_descripcion as Departamento,
p.Fecha,p.Observacion,pr.pr_nombre as Proveedor1,
pr2.pr_nombre as Proveedor2,pr3.pr_nombre as Proveedor3,
p.IdUsuario,p.Estado,p.MotivoAnulacion  
 from dbo.pre_PedidoXPresupuesto p
inner join ro_Departamento d 
	on d.IdDepartamento = p.IdDepartamento and d.IdEmpresa=p.IdEmpresa 
inner join cp_proveedor pr
	on pr.IdEmpresa = p.IdEmpresa and pr.IdProveedor = p.IdProveedor1 
left join cp_proveedor pr2
	on pr2.IdEmpresa = p.IdEmpresa and pr2.IdProveedor = p.IdProveedor2 
left join cp_proveedor pr3
	on pr3.IdEmpresa = p.IdEmpresa and pr3.IdProveedor = p.IdProveedor3

--select * from pre_PedidoXPresupuesto