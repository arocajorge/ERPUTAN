CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos_det] (
    [IdEmpresa]                INT           NOT NULL,
    [IdLiquidacion]            NUMERIC (18)  NOT NULL,
    [secuencia]                INT           NOT NULL,
    [IdProducto_Liqui]         INT           NOT NULL,
    [detalle_x_producto]       VARCHAR (450) NOT NULL,
    [cantidad]                 FLOAT (53)    NOT NULL,
    [precio]                   FLOAT (53)    NOT NULL,
    [subtotal]                 FLOAT (53)    NOT NULL,
    [aplica_iva]               BIT           NOT NULL,
    [por_iva]                  FLOAT (53)    NOT NULL,
    [valor_iva]                FLOAT (53)    NOT NULL,
    [Total_liq]                FLOAT (53)    NOT NULL,
    [Se_Genero_por_un_proceso] BIT           NOT NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC, [secuencia] ASC),
    CONSTRAINT [FK_fa_liquidacion_gastos_det_fa_liquidacion_gastos] FOREIGN KEY ([IdEmpresa], [IdLiquidacion]) REFERENCES [Fj_servindustrias].[fa_liquidacion_gastos] ([IdEmpresa], [IdLiquidacion]),
    CONSTRAINT [FK_fa_liquidacion_gastos_det_fa_liquidacion_gastos_producto] FOREIGN KEY ([IdEmpresa], [IdProducto_Liqui]) REFERENCES [Fj_servindustrias].[fa_liquidacion_gastos_producto] ([IdEmpresa], [IdProducto_Liqui])
);

