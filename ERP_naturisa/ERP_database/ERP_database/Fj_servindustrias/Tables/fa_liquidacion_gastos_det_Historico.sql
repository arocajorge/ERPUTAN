CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos_det_Historico] (
    [IdEmpresa]          INT           NOT NULL,
    [IdLiquidacion]      NUMERIC (18)  NOT NULL,
    [secuencia]          INT           NOT NULL,
    [IdProducto_Liqui]   INT           NOT NULL,
    [detalle_x_producto] VARCHAR (450) NOT NULL,
    [cantidad]           FLOAT (53)    NOT NULL,
    [precio]             FLOAT (53)    NOT NULL,
    [subtotal]           FLOAT (53)    NOT NULL,
    [aplica_iva]         BIT           NOT NULL,
    [por_iva]            FLOAT (53)    NOT NULL,
    [valor_iva]          FLOAT (53)    NOT NULL,
    [Total_liq]          FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos_det_Historico] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC, [secuencia] ASC)
);

