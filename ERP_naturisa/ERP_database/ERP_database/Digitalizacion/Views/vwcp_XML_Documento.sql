CREATE VIEW Digitalizacion.vwcp_XML_Documento
AS
select a.IdEmpresa, a.IdDocumento, a.ret_Establecimiento+'-'+a.ret_PuntoEmision serie, a.ret_NumeroDocumento, a.ret_Fecha, a.emi_RazonSocial pe_nombreCompleto, a.emi_RazonSocial, a.emi_Ruc, per.pe_correo, per.pe_direccion, per.pe_telfono_Contacto, pro.IdProveedor,
Establecimiento+'-'+PuntoEmision as co_serie, a.NumeroDocumento, a.FechaEmision, a.CodDocumento, per.IdTipoDocumento, su.IdSucursal, su.Su_Descripcion, Su_Direccion, em.RazonSocial, em.NombreComercial, em.ContribuyenteEspecial, em.ObligadoAllevarConta, em.em_ruc, em_direccion, a.Estado
from Digitalizacion.cp_XML_Documento as a inner join tb_persona as per on a.emi_Ruc = per.pe_cedulaRuc inner join cp_proveedor as pro on per.IdPersona = pro.IdPersona and a.IdEmpresa = pro.IdEmpresa inner join
tb_sucursal as su on su.IdEmpresa = a.IdEmpresa and su.IdSucursal = 1 inner join tb_empresa as em on em.IdEmpresa = a.IdEmpresa
WHERE a.ret_NumeroDocumento is not null and a.Estado = 1 and a.Tipo = 'FACTURA'