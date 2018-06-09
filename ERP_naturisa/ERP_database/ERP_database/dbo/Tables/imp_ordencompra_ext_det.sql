CREATE TABLE [dbo].[imp_ordencompra_ext_det] (
    [IdEmpresa]        INT          NOT NULL,
    [IdSucursal]       INT          NOT NULL,
    [IdOrdenCompraExt] NUMERIC (18) NOT NULL,
    [Secuencia]        INT          NOT NULL,
    [IdProducto]       NUMERIC (18) NULL,
    [di_cantidad]      FLOAT (53)   NULL,
    [di_costo]         FLOAT (53)   NULL,
    [di_pordesc]       FLOAT (53)   NULL,
    [di_desc]          FLOAT (53)   NULL,
    [di_subtotal]      FLOAT (53)   NULL,
    [di_costoPromedio] FLOAT (53)   NULL,
    [di_cambio]        FLOAT (53)   NULL,
    [di_prec_cam]      FLOAT (53)   NULL,
    [IdCategoria]      VARCHAR (25) NULL,
    CONSTRAINT [PK_imp_ordencompra_ext_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdOrdenCompraExt] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_imp_ordencompra_ext_det_imp_ordencompra_ext] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdOrdenCompraExt]) REFERENCES [dbo].[imp_ordencompra_ext] ([IdEmpresa], [IdSucusal], [IdOrdenCompraExt]),
    CONSTRAINT [FK_imp_ordencompra_ext_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

