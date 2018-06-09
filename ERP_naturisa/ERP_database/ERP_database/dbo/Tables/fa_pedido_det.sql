CREATE TABLE [dbo].[fa_pedido_det] (
    [IdEmpresa]        INT           NOT NULL,
    [IdSucursal]       INT           NOT NULL,
    [IdBodega]         INT           NOT NULL,
    [IdPedido]         NUMERIC (18)  NOT NULL,
    [Secuencial]       INT           NOT NULL,
    [IdProducto]       NUMERIC (18)  NOT NULL,
    [dp_cantidad]      FLOAT (53)    NOT NULL,
    [dp_precio]        FLOAT (53)    NOT NULL,
    [dp_PorDescuento]  FLOAT (53)    NOT NULL,
    [cp_desUni]        FLOAT (53)    NOT NULL,
    [cp_PrecioFinal]   FLOAT (53)    NOT NULL,
    [dp_subtotal]      FLOAT (53)    NOT NULL,
    [dp_iva]           FLOAT (53)    NOT NULL,
    [dp_total]         FLOAT (53)    NOT NULL,
    [dp_pagaIva]       CHAR (1)      NOT NULL,
    [dp_detallexItems] VARCHAR (250) NOT NULL,
    [dp_peso]          FLOAT (53)    NULL,
    CONSTRAINT [PK_fa_pedido_detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdPedido] ASC, [Secuencial] ASC),
    CONSTRAINT [FK_fa_pedido_det_fa_pedido] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdPedido]) REFERENCES [dbo].[fa_pedido] ([IdEmpresa], [IdSucursal], [IdBodega], [IdPedido]),
    CONSTRAINT [FK_fa_pedido_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

