CREATE TABLE [dbo].[fa_orden_Desp_det_x_fa_pedido_det] (
    [od_IdEmpresa]       INT          NOT NULL,
    [od_IdSucursal]      INT          NOT NULL,
    [od_IdBodega]        INT          NOT NULL,
    [od_IdOrdenDespacho] NUMERIC (18) NOT NULL,
    [od_Secuencia]       INT          NOT NULL,
    [od_IdProducto]      NUMERIC (10) NOT NULL,
    [od_cantidad]        FLOAT (53)   NOT NULL,
    [pe_IdEmpresa]       INT          NOT NULL,
    [pe_IdSucursal]      INT          NOT NULL,
    [pe_IdBodega]        INT          NOT NULL,
    [pe_IdPedido]        NUMERIC (18) NOT NULL,
    [pe_Secuencia]       INT          NOT NULL,
    [pe_IdProducto]      NUMERIC (10) NOT NULL,
    CONSTRAINT [PK_fa_orden_Desp_det_x_fa_pedido_det_1] PRIMARY KEY CLUSTERED ([od_IdEmpresa] ASC, [od_IdSucursal] ASC, [od_IdBodega] ASC, [od_IdOrdenDespacho] ASC, [od_Secuencia] ASC, [pe_IdEmpresa] ASC, [pe_IdSucursal] ASC, [pe_IdBodega] ASC, [pe_IdPedido] ASC, [pe_Secuencia] ASC),
    CONSTRAINT [FK_fa_orden_Desp_det_x_fa_pedido_det_fa_orden_Desp_det] FOREIGN KEY ([od_IdEmpresa], [od_IdSucursal], [od_IdBodega], [od_IdOrdenDespacho], [od_Secuencia]) REFERENCES [dbo].[fa_orden_Desp_det] ([IdEmpresa], [IdSucursal], [IdBodega], [IdOrdenDespacho], [Secuencia]),
    CONSTRAINT [FK_fa_orden_Desp_det_x_fa_pedido_det_fa_pedido_det] FOREIGN KEY ([pe_IdEmpresa], [pe_IdSucursal], [pe_IdBodega], [pe_IdPedido], [pe_Secuencia]) REFERENCES [dbo].[fa_pedido_det] ([IdEmpresa], [IdSucursal], [IdBodega], [IdPedido], [Secuencial])
);

