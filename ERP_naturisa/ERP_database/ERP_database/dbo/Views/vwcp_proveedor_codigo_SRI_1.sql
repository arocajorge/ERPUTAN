CREATE VIEW vwcp_proveedor_codigo_SRI
AS
SELECT c.IdEmpresa, c.IdProveedor, per.pe_cedulaRuc, 
CASE WHEN co.IdTipoSRI = 'COD_RET_IVA' THEN 'IVA' ELSE 'FTE' END AS re_tipo,
c.IdCodigo_SRI,co.codigoSRI as re_Codigo_impuesto, co.co_porRetencion as re_Porcen_retencion
FROM cp_proveedor AS PRO inner join tb_persona as per
on pro.IdPersona = per.IdPersona inner join cp_proveedor_codigo_SRI as c
on c.IdEmpresa = pro.IdEmpresa and c.IdProveedor = pro.IdProveedor inner join
cp_codigo_SRI as co on c.IdCodigo_SRI = co.IdCodigo_SRI