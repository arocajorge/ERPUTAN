CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos_producto] (
    [IdEmpresa]          INT           NOT NULL,
    [IdProducto_Liqui]   INT           NOT NULL,
    [nom_producto_Liqui] VARCHAR (250) NOT NULL,
    [estado]             CHAR (1)      NOT NULL,
    [IdProducto]         NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos_producto] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto_Liqui] ASC)
);

