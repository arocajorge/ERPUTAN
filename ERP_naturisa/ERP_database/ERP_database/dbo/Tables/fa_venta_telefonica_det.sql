CREATE TABLE [dbo].[fa_venta_telefonica_det] (
    [IdEmpresa]   INT           NOT NULL,
    [IdSucursal]  INT           NOT NULL,
    [IdVenta_tel] NUMERIC (18)  NOT NULL,
    [Secuencia]   INT           NOT NULL,
    [IdProducto]  NUMERIC (18)  NOT NULL,
    [Observacion] VARCHAR (250) NOT NULL,
    [Cantidad]    FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_venta_telefonica_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdVenta_tel] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_fa_venta_telefonica_det_fa_venta_telefonica] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdVenta_tel]) REFERENCES [dbo].[fa_venta_telefonica] ([IdEmpresa], [IdSucursal], [IdVenta_tel]),
    CONSTRAINT [FK_fa_venta_telefonica_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

