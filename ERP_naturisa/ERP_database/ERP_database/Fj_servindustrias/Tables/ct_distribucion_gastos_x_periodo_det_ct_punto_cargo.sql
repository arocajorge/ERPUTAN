CREATE TABLE [Fj_servindustrias].[ct_distribucion_gastos_x_periodo_det_ct_punto_cargo] (
    [IdEmpresa]      INT          NOT NULL,
    [IdDistribucion] NUMERIC (18) NOT NULL,
    [Secuencia]      INT          NOT NULL,
    [IdPunto_cargo]  INT          NOT NULL,
    [Porcentaje]     FLOAT (53)   NOT NULL,
    [Checked]        BIT          NOT NULL,
    CONSTRAINT [PK_ct_distribucion_gastos_x_periodo_det_ct_punto_cargo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDistribucion] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_ct_distribucion_gastos_x_periodo] FOREIGN KEY ([IdEmpresa], [IdDistribucion]) REFERENCES [Fj_servindustrias].[ct_distribucion_gastos_x_periodo] ([IdEmpresa], [IdDistribucion]),
    CONSTRAINT [FK_ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_ct_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[ct_punto_cargo] ([IdEmpresa], [IdPunto_cargo])
);

