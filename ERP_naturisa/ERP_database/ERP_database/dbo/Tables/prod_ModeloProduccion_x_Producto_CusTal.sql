CREATE TABLE [dbo].[prod_ModeloProduccion_x_Producto_CusTal] (
    [IdEmpresa]    INT          NOT NULL,
    [IdModeloProd] INT          NOT NULL,
    [IdProducto]   NUMERIC (18) NOT NULL,
    [Tipo]         VARCHAR (10) NULL,
    CONSTRAINT [PK_prod_ModeloProduccion_x_Producto_CusTal] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdModeloProd] ASC, [IdProducto] ASC)
);

