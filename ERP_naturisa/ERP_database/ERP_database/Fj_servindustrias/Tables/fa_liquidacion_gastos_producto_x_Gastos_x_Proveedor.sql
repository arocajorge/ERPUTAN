CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos_producto_x_Gastos_x_Proveedor] (
    [IdEmpresa]                INT          NOT NULL,
    [IdProducto_Liqui]         INT          NOT NULL,
    [IdTipo_Gasto_x_Proveedor] VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos_producto_x_Gastos_x_Proveedor] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto_Liqui] ASC, [IdTipo_Gasto_x_Proveedor] ASC)
);

