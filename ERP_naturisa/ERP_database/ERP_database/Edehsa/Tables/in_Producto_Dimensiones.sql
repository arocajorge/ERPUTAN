CREATE TABLE [Edehsa].[in_Producto_Dimensiones] (
    [IdEmpresa]  INT          NOT NULL,
    [IdProducto] NUMERIC (18) NOT NULL,
    [longitud]   FLOAT (53)   NOT NULL,
    [espesor]    FLOAT (53)   NOT NULL,
    [ancho]      FLOAT (53)   NOT NULL,
    [alto]       FLOAT (53)   NOT NULL,
    [ceja]       FLOAT (53)   NOT NULL,
    [diametro]   FLOAT (53)   NOT NULL,
    [estado]     BIT          NOT NULL,
    CONSTRAINT [PK_in_Producto_Dimensiones] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto] ASC)
);

