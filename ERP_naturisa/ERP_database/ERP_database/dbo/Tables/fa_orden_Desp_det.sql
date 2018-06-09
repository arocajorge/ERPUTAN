CREATE TABLE [dbo].[fa_orden_Desp_det] (
    [IdEmpresa]          INT          NOT NULL,
    [IdSucursal]         INT          NOT NULL,
    [IdBodega]           INT          NOT NULL,
    [IdOrdenDespacho]    NUMERIC (18) NOT NULL,
    [Secuencia]          INT          NOT NULL,
    [IdProducto]         NUMERIC (18) NOT NULL,
    [od_cantidad]        FLOAT (53)   NOT NULL,
    [od_Precio]          FLOAT (53)   NOT NULL,
    [od_PorDescUnitario] FLOAT (53)   NOT NULL,
    [od_DescUnitario]    FLOAT (53)   NOT NULL,
    [od_PrecioFinal]     FLOAT (53)   NOT NULL,
    [od_Subtotal]        FLOAT (53)   NOT NULL,
    [od_iva]             FLOAT (53)   NOT NULL,
    [od_total]           FLOAT (53)   NOT NULL,
    [od_costo]           FLOAT (53)   NOT NULL,
    [od_tieneIVA]        CHAR (1)     NOT NULL,
    [od_detallexItems]   NCHAR (250)  NOT NULL,
    [od_peso]            FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_fa_orden_Desp_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdOrdenDespacho] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_fa_orden_Desp_det_fa_orden_Desp] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdOrdenDespacho]) REFERENCES [dbo].[fa_orden_Desp] ([IdEmpresa], [IdSucursal], [IdBodega], [IdOrdenDespacho]),
    CONSTRAINT [FK_fa_orden_Desp_det_in_Producto] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

