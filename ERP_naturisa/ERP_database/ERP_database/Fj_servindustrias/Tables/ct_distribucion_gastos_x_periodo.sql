CREATE TABLE [Fj_servindustrias].[ct_distribucion_gastos_x_periodo] (
    [IdEmpresa]      INT            NOT NULL,
    [IdDistribucion] NUMERIC (18)   NOT NULL,
    [IdPeriodo]      INT            NOT NULL,
    [Fecha]          DATETIME       NOT NULL,
    [Observacion]    VARCHAR (1000) NOT NULL,
    [Estado]         BIT            NOT NULL,
    [IdEmpresa_ct]   INT            NULL,
    [IdTipoCbte_ct]  INT            NULL,
    [IdCbteCble_ct]  NUMERIC (18)   NULL,
    CONSTRAINT [PK_ct_distribucion_gastos_x_periodo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDistribucion] ASC)
);

