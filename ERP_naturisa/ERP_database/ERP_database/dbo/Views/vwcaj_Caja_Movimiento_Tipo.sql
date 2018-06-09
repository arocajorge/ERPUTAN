create view vwcaj_Caja_Movimiento_Tipo
as
SELECT        caj_Caja_Movimiento_Tipo.IdEmpresa,caj_Caja_Movimiento_Tipo.IdTipoMovi, caj_Caja_Movimiento_Tipo.tm_descripcion, caj_Caja_Movimiento_Tipo.Estado, caj_Caja_Movimiento_Tipo.tm_Signo,
                          caj_Caja_Movimiento_Tipo.SeDeposita, 
                         caj_Caja_Movimiento_Tipo_x_CtaCble.IdCtaCble, ct_plancta.pc_Cuenta, ct_plancta.pc_clave_corta
FROM            ct_plancta INNER JOIN
                         caj_Caja_Movimiento_Tipo_x_CtaCble ON ct_plancta.IdEmpresa = caj_Caja_Movimiento_Tipo_x_CtaCble.IdEmpresa AND 
                         ct_plancta.IdCtaCble = caj_Caja_Movimiento_Tipo_x_CtaCble.IdCtaCble RIGHT OUTER JOIN
                         caj_Caja_Movimiento_Tipo ON caj_Caja_Movimiento_Tipo_x_CtaCble.IdTipoMovi = caj_Caja_Movimiento_Tipo.IdTipoMovi AND 
                         caj_Caja_Movimiento_Tipo_x_CtaCble.IdEmpresa = caj_Caja_Movimiento_Tipo.IdEmpresa