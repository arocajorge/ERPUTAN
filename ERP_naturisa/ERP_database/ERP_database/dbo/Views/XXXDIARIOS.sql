CREATE VIEW XXXDIARIOS
AS
select d.idempresa, c.cb_fecha,t.tc_TipoCbte, c.IdCbteCble, d.IdCtaCble, pc.pc_cuenta,
round(isnull(i.SaldoInicial,0),2) SaldoInicial,d.dc_Valor,
case when d.dc_Valor > 0 then d.dc_Valor else 0 end as Debe,
case when d.dc_Valor < 0 then ABS(d.dc_Valor) else 0 end as Haber,
round(isnull(i.SaldoInicial,0) + sum(d.dc_valor) over(partition by d.IdEmpresa, d.IdCtaCble order by d.IdEmpresa,d.IdCtaCble, c.cb_Fecha, d.IdTipoCbte, d.IdCbteCble, d.Secuencia),2) as Saldo,
isnull(c.cb_observacion,'') + ' || ' + isnull(d.dc_observacion,'') as Observacion
from ct_cbtecble_det as d inner join 
ct_cbtecble as c on c.IdEmpresa = d.IdEmpresa and c.IdTipoCbte = d.IdTipoCbte and c.IdCbteCble = d.IdCbteCble inner join 
ct_plancta as pc on pc.IdEmpresa = d.IdEmpresa and pc.IdCtaCble = d.IdCtaCble inner join 
ct_cbtecble_tipo as t on t.idempresa = c.idempresa and t.idtipocbte = c.idtipocbte LEFT JOIN
(
select c2.IdEmpresa, c2.IdCtaCble, sum(c2.dc_Valor) SaldoInicial 
from ct_cbtecble as c1 inner join ct_cbtecble_det as c2 on c1.IdEmpresa = c2.IdEmpresa
and c1.IdTipoCbte = c2.IdTipoCbte and c1.IdCbteCble = c2.IdCbteCble
where c1.cb_fecha < Datefromparts(2018,1,1)
group by c2.IdEmpresa, c2.IdCtaCble
) as i on d.IdEmpresa = i.IdEmpresa and d.IdCtaCble= i.IdCtaCble
WHERE c.IdEmpresa = 1 and C.cb_Fecha BETWEEN DATEFROMPARTS(2018,1,1) AND DATEFROMPARTS(2018,12,31)
--order by d.IdEmpresa, d.IdCtaCble,c.cb_Fecha, d.IdTipoCbte, d.IdCbteCble, d.Secuencia