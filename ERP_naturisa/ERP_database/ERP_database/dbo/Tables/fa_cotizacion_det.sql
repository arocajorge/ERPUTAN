CREATE TABLE [dbo].[fa_cotizacion_det] (
    [IdEmpresa]        INT           NOT NULL,
    [IdSucursal]       INT           NOT NULL,
    [IdBodega]         INT           NOT NULL,
    [IdCotizacion]     NUMERIC (18)  NOT NULL,
    [Secuencial]       INT           NOT NULL,
    [IdProducto]       NUMERIC (18)  NOT NULL,
    [dc_cantidad]      FLOAT (53)    NOT NULL,
    [dc_precio]        FLOAT (53)    NOT NULL,
    [dc_por_desUni]    FLOAT (53)    NOT NULL,
    [dc_desUni]        FLOAT (53)    NOT NULL,
    [dc_precioFinal]   FLOAT (53)    NOT NULL,
    [dc_subtotal]      FLOAT (53)    NOT NULL,
    [dc_iva]           FLOAT (53)    NOT NULL,
    [dc_total]         FLOAT (53)    NOT NULL,
    [dc_pagaIva]       CHAR (1)      NOT NULL,
    [dc_detallexItems] VARCHAR (500) NOT NULL,
    [dc_peso]          FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_fa_cotizacion_detalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdCotizacion] ASC, [Secuencial] ASC),
    CONSTRAINT [FK_fa_cotizacion_det_fa_cotizacion] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdCotizacion]) REFERENCES [dbo].[fa_cotizacion] ([IdEmpresa], [IdSucursal], [IdBodega], [IdCotizacion]),
    CONSTRAINT [FK_fa_cotizacion_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

