--EXEC spCONTA_Rpt023 1,'',7,'31/12/2018','admin','ER',0
CREATE PROCEDURE [dbo].[spCONTA_Rpt023]
(
	@IdEmpresa int,
	@IdCentroCosto varchar(20),
	@Nivel int,
	@FechaFin datetime,
	@IdUsuario varchar(50),
	@Balance varchar(2),
	@MostrarSaldo0 bit
)
AS
DECLARE @i_FechaIni datetime

SET @i_FechaIni = DATEFROMPARTS(YEAR(@FechaFin),1,1)

DELETE [dbo].[ct_spCONTA_Rpt023] WHERE IdUsuario = @IdUsuario

BEGIN --INSERTO DATA INICIAL

	INSERT INTO [dbo].[ct_spCONTA_Rpt023]
           ([IdEmpresa]
           ,[IdCtaCble]
           ,[IdCentroCosto]
           ,[IdUsuario]
		   ,[IdCtaCblePadre]
		   ,[Naturaleza]
           ,[NombreCuenta]
           ,[NombreCentroCosto]
           ,[EsCuentaMovimiento]
           ,[NivelCuenta]
           ,[Saldo]
           ,[SaldoNaturaleza])
	SELECT pc.IdEmpresa, pc.IdCtaCble, cc.IdCentroCosto, @IdUsuario,pc.IdCtaCblePadre, case when g.gc_signo_operacion > 0 then 'D' ELSE 'C' END,
	space(pc.IdNivelCta-1)+pc.pc_Cuenta, cc.Centro_costo, 0, pc.IdNivelCta, 0,0  
	FROM ct_plancta pc cross join ct_centro_costo cc inner join ct_grupocble as g
	on pc.IdGrupoCble = g.IdGrupoCble
	where pc.IdEmpresa = @IdEmpresa and cc.IdEmpresa = @IdEmpresa
	AND cc.IdCentroCosto = @IdCentroCosto and g.gc_estado_financiero = @Balance
	UNION ALL 
	select @IdEmpresa, '9',@IdCentroCosto, @IdUsuario,NULL, 'C', 'Utilidad o Pérdida del ejercicio',cc.Centro_costo,0,1,0,0
	FROM ct_centro_costo AS cc where cc.IdEmpresa = @IdEmpresa and cc.IdCentroCosto = @IdCentroCosto and @Balance = 'ER'
	UNION ALL
	select @IdEmpresa, '9',@IdCentroCosto, @IdUsuario,NULL, 'C', 'Utilidad o Pérdida del ejercicio','Histórico acumulado',0,1,0,0
	where @Balance = 'ER' and @IdCentroCosto = ''
	UNION ALL
	SELECT pc.IdEmpresa, pc.IdCtaCble, '',@IdUsuario,pc.IdCtaCblePadre, case when g.gc_signo_operacion > 0 then 'D' ELSE 'C' END,
	space(pc.IdNivelCta-1)+pc.pc_Cuenta, 'Histórico acumulado', 0, pc.IdNivelCta, 0,0 
	FROM ct_plancta AS PC inner join ct_grupocble as g on pc.IdGrupoCble = g.IdGrupoCble
	where IdEmpresa = @IdEmpresa and g.gc_estado_financiero = @Balance and @IdCentroCosto = ''
	
END

BEGIN --ACTUALIZO VALORES
		UPDATE [dbo].[ct_spCONTA_Rpt023] SET Saldo = A.dc_Valor
		FROM(
			SELECT c.IdEmpresa, d.IdCtaCble, d.IdCentroCosto, SUM(d.dc_Valor) AS dc_Valor
			FROM     ct_cbtecble AS c INNER JOIN
					ct_cbtecble_det AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdTipoCbte = d.IdTipoCbte AND c.IdCbteCble = d.IdCbteCble INNER JOIN
					ct_plancta ON d.IdEmpresa = ct_plancta.IdEmpresa AND d.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
					ct_grupocble ON ct_plancta.IdGrupoCble = ct_grupocble.IdGrupoCble
			WHERE  (c.cb_Fecha BETWEEN @i_FechaIni AND @FechaFin) AND (c.IdEmpresa = @IdEmpresa)
			and ct_grupocble.gc_estado_financiero = 'ER'
			GROUP BY c.IdEmpresa, d.IdCtaCble, d.IdCentroCosto
			UNION ALL
			SELECT c.IdEmpresa, d.IdCtaCble, d.IdCentroCosto, SUM(d.dc_Valor) AS dc_Valor
			FROM     ct_cbtecble AS c INNER JOIN
					ct_cbtecble_det AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdTipoCbte = d.IdTipoCbte AND c.IdCbteCble = d.IdCbteCble INNER JOIN
					ct_plancta ON d.IdEmpresa = ct_plancta.IdEmpresa AND d.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
					ct_grupocble ON ct_plancta.IdGrupoCble = ct_grupocble.IdGrupoCble
			WHERE  (c.cb_Fecha <= @FechaFin) AND (c.IdEmpresa = @IdEmpresa)
			and ct_grupocble.gc_estado_financiero = 'BG'
			GROUP BY c.IdEmpresa, d.IdCtaCble, d.IdCentroCosto
		) A WHERE A.IdEmpresa = [dbo].[ct_spCONTA_Rpt023].IdEmpresa and a.IdCtaCble = [dbo].[ct_spCONTA_Rpt023].IdCtaCble 
		and ISNULL(a.IdCentroCosto,'') = [dbo].[ct_spCONTA_Rpt023].IdCentroCosto and [dbo].[ct_spCONTA_Rpt023].IdUsuario = @IdUsuario
END

BEGIN --ACTUALIZO CUALES SON CUENTAS DE MOVIMIENTO
	UPDATE ct_spCONTA_Rpt023 SET EsCuentaMovimiento = 1 WHERE Saldo != 0 and IdEmpresa = @IdEmpresa and IdUsuario = @IdUsuario
END

BEGIN --SUMO RECURSIVAMENTE
DECLARE @Contador int
DECLARE @ContadorAsc int
SET @ContadorAsc = 0

select @Contador = max(NivelCuenta) 
from [dbo].[ct_spCONTA_Rpt023]
where IdUsuario = @IdUsuario
and IdEmpresa = @IdEmpresa

	WHILE @Contador > 0
	BEGIN
		UPDATE [dbo].[ct_spCONTA_Rpt023]
		SET Saldo = A.Saldo		
		FROM(
		SELECT        IdEmpresa, IdCtaCblePadre, IdCentroCosto
		   ,SUM(Saldo) as Saldo
		FROM            [dbo].[ct_spCONTA_Rpt023]
		where [dbo].[ct_spCONTA_Rpt023].IdEmpresa = @IdEmpresa
		and [dbo].[ct_spCONTA_Rpt023].IdUsuario = @IdUsuario
		
		GROUP BY IdEmpresa, IdCtaCblePadre, IdCentroCosto
		
		) A where [dbo].[ct_spCONTA_Rpt023].IdEmpresa = a.IdEmpresa
		and [dbo].[ct_spCONTA_Rpt023].IdCtaCble = a.IdCtaCblePadre
		and [dbo].[ct_spCONTA_Rpt023].IdUsuario = @IdUsuario
		and [dbo].[ct_spCONTA_Rpt023].IdEmpresa = @IdEmpresa
		and [dbo].[ct_spCONTA_Rpt023].IdCentroCosto = a.IdCentroCosto
		SET @Contador = @Contador - 1
		SET @ContadorAsc = @ContadorAsc + 1
	END
	
END

BEGIN --ACTUALIZO UTILIDAD
	UPDATE [dbo].[ct_spCONTA_Rpt023] SET Saldo = A.dc_Valor
	FROM(
		SELECT c.IdEmpresa,isnull(IdCentroCosto,'')IdCentroCosto, SUM(d.dc_Valor) AS dc_Valor
			FROM     ct_cbtecble AS c INNER JOIN
					ct_cbtecble_det AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdTipoCbte = d.IdTipoCbte AND c.IdCbteCble = d.IdCbteCble INNER JOIN
					ct_plancta ON d.IdEmpresa = ct_plancta.IdEmpresa AND d.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
					ct_grupocble ON ct_plancta.IdGrupoCble = ct_grupocble.IdGrupoCble
			WHERE  (c.cb_Fecha BETWEEN @i_FechaIni AND @FechaFin) AND (c.IdEmpresa = @IdEmpresa)
			and ct_grupocble.gc_estado_financiero = 'ER'
			GROUP BY c.IdEmpresa,IdCentroCosto
	) A
	WHERE [dbo].[ct_spCONTA_Rpt023].IdCtaCble = '9' AND [dbo].[ct_spCONTA_Rpt023].IdUsuario = @IdUsuario and [dbo].[ct_spCONTA_Rpt023].IdEmpresa = @IdEmpresa
	AND [dbo].[ct_spCONTA_Rpt023].IdCentroCosto = A.IdCentroCosto
END

BEGIN --QUITO SALDO 0
	IF(@MostrarSaldo0 = 0)
	BEGIN
		DELETE [dbo].[ct_spCONTA_Rpt023] 
		where IdEmpresa = @IdEmpresa and IdUsuario = @IdUsuario and Saldo = 0
	END
END

BEGIN --ACTUALIZO SALDO NATURALEZA
	update ct_spCONTA_Rpt023 set SaldoNaturaleza = CASE WHEN Naturaleza = 'C' THEN Saldo*-1 ELSE Saldo END
	WHERE IdEmpresa = @IdEmpresa and IdUsuario = @IdUsuario
END

BEGIN --ELIMINO LOS DEL NIVEL NO SOLICITADO
	DELETE ct_spCONTA_Rpt023 where IdEmpresa = @IdEmpresa and IdUsuario = @IdUsuario and NivelCuenta > @Nivel
	DELETE ct_spCONTA_Rpt023 where IdEmpresa = @IdEmpresa and IdUsuario = @IdUsuario and NivelCuenta between 3 and (@Nivel-1)
END

SELECT * FROM [dbo].[ct_spCONTA_Rpt023] where IdUsuario = @IdUsuario and IdEmpresa = @IdEmpresa