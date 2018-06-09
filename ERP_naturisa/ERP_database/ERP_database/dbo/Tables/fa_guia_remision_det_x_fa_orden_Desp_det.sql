CREATE TABLE [dbo].[fa_guia_remision_det_x_fa_orden_Desp_det] (
    [gi_IdEmpresa]       INT          NOT NULL,
    [gi_IdSucursal]      INT          NOT NULL,
    [gi_IdBodega]        INT          NOT NULL,
    [gi_IdGuiaRemision]  NUMERIC (18) NOT NULL,
    [gi_Secuencia]       INT          NOT NULL,
    [gi_IdProducto]      NUMERIC (10) NOT NULL,
    [gi_cantidad]        FLOAT (53)   NOT NULL,
    [od_IdEmpresa]       INT          NOT NULL,
    [od_IdSucursal]      INT          NOT NULL,
    [od_IdBodega]        INT          NOT NULL,
    [od_IdOrdenDespacho] NUMERIC (18) NOT NULL,
    [od_Secuencia]       INT          NOT NULL,
    [od_IdProducto]      NUMERIC (10) NOT NULL,
    CONSTRAINT [PK_fa_guia_remision_det_x_fa_orden_Desp_det] PRIMARY KEY CLUSTERED ([gi_IdEmpresa] ASC, [gi_IdSucursal] ASC, [gi_IdBodega] ASC, [gi_IdGuiaRemision] ASC, [gi_Secuencia] ASC, [gi_IdProducto] ASC, [od_IdEmpresa] ASC, [od_IdSucursal] ASC, [od_IdBodega] ASC, [od_IdOrdenDespacho] ASC, [od_Secuencia] ASC, [od_IdProducto] ASC),
    CONSTRAINT [FK_fa_guia_remision_det_x_fa_orden_Desp_det_fa_guia_remision_det] FOREIGN KEY ([gi_IdEmpresa], [gi_IdSucursal], [gi_IdBodega], [gi_IdGuiaRemision], [gi_Secuencia]) REFERENCES [dbo].[fa_guia_remision_det] ([IdEmpresa], [IdSucursal], [IdBodega], [IdGuiaRemision], [Secuencia]),
    CONSTRAINT [FK_fa_guia_remision_det_x_fa_orden_Desp_det_fa_orden_Desp_det] FOREIGN KEY ([od_IdEmpresa], [od_IdSucursal], [od_IdBodega], [od_IdOrdenDespacho], [od_Secuencia]) REFERENCES [dbo].[fa_orden_Desp_det] ([IdEmpresa], [IdSucursal], [IdBodega], [IdOrdenDespacho], [Secuencia])
);

