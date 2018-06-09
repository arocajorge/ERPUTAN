CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos_producto_x_tipo_proceso] (
    [IdEmpresa_prod_liqui] INT          NOT NULL,
    [IdProducto_Liqui]     INT          NOT NULL,
    [IdTipo_Proceso]       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos_producto_x_tipo_proceso] PRIMARY KEY CLUSTERED ([IdEmpresa_prod_liqui] ASC, [IdProducto_Liqui] ASC, [IdTipo_Proceso] ASC)
);

