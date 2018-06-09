CREATE TABLE [Fj_servindustrias].[fa_liquidaciones_det] (
    [IdEmpresa]                  INT          NOT NULL,
    [IdLiquidaciones]            NUMERIC (18) NOT NULL,
    [Secuencia]                  INT          NOT NULL,
    [IdEmpresa_liqui_gastos]     INT          NULL,
    [IdLiquidacion_liqui_gastos] NUMERIC (18) NULL,
    CONSTRAINT [PK_fa_liquidaciones_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidaciones] ASC, [Secuencia] ASC)
);

