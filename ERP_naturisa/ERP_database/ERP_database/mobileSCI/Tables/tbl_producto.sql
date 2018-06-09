CREATE TABLE [mobileSCI].[tbl_producto] (
    [IdEmpresaSCI] INT          NOT NULL,
    [IdSCI]        NUMERIC (18) NOT NULL,
    [IdEmpresa]    INT          NOT NULL,
    [IdProducto]   NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_tbl_producto] PRIMARY KEY CLUSTERED ([IdEmpresaSCI] ASC, [IdSCI] ASC),
    CONSTRAINT [FK_tbl_producto_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

