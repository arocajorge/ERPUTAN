CREATE VIEW XXXCUENTASDENOMOVIMIENTO
AS
SELECT IdEmpresa, IdCtaCble, pc_Cuenta, pc_EsMovimiento, pc_clave_corta, pc_Estado FROM ct_plancta
WHERE NOT EXISTS(
SELECT * FROM XXXCUENTASDEMOVIMIENTO AS P
where ct_plancta.IdEmpresa = p.IdEmpresa
and ct_plancta.IdCtaCble = p.IdCtaCble
)