CREATE VIEW vwcp_proveedor_combo
AS
select p.IdEmpresa,p.IdProveedor,per.pe_nombrecompleto, per.pe_cedularuc 
from cp_proveedor as p inner join tb_persona as per on p.IdPersona = per.idpersona