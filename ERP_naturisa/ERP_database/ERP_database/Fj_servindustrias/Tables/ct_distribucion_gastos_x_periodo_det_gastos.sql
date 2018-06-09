CREATE TABLE [Fj_servindustrias].[ct_distribucion_gastos_x_periodo_det_gastos] (
    [IdEmpresa]      INT          NOT NULL,
    [IdDistribucion] NUMERIC (18) NOT NULL,
    [Secuencia]      INT          NOT NULL,
    [IdCtaCble]      VARCHAR (20) NOT NULL,
    [Saldo]          FLOAT (53)   NOT NULL,
    [Checked]        BIT          NOT NULL,
    CONSTRAINT [PK_ct_distribucion_gastos_x_periodo_det_gastos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDistribucion] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_ct_distribucion_gastos_x_periodo_det_gastos_ct_distribucion_gastos_x_periodo] FOREIGN KEY ([IdEmpresa], [IdDistribucion]) REFERENCES [Fj_servindustrias].[ct_distribucion_gastos_x_periodo] ([IdEmpresa], [IdDistribucion]),
    CONSTRAINT [FK_ct_distribucion_gastos_x_periodo_det_gastos_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble])
);

