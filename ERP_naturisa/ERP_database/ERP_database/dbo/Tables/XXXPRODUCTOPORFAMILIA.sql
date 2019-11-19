CREATE TABLE [dbo].[XXXPRODUCTOPORFAMILIA] (
    [IdEmpresa]  INT           NOT NULL,
    [IdFamilia]  INT           NOT NULL,
    [Familia]    VARCHAR (500) NOT NULL,
    [IdProducto] NUMERIC (18)  NOT NULL,
    [Producto]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_XXXPRODUCTOPORFAMILIA] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto] ASC)
);

