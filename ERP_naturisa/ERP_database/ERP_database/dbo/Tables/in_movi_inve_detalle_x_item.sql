CREATE TABLE [dbo].[in_movi_inve_detalle_x_item] (
    [IdEmpresa]         INT           NOT NULL,
    [IdSucursal]        INT           NOT NULL,
    [IdBodega]          INT           NOT NULL,
    [IdMovi_inven_tipo] INT           NOT NULL,
    [IdNumMovi]         NUMERIC (18)  NOT NULL,
    [Secuencia]         INT           NOT NULL,
    [Secuencia_reg]     NUMERIC (18)  NOT NULL,
    [codigo_reg]        VARCHAR (100) NOT NULL,
    [cantidad]          FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_in_movi_inve_detalle_x_item] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [Secuencia] ASC, [Secuencia_reg] ASC),
    CONSTRAINT [FK_in_movi_inve_detalle_x_item_in_movi_inve_detalle] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega], [IdMovi_inven_tipo], [IdNumMovi], [Secuencia]) REFERENCES [dbo].[in_movi_inve_detalle] ([IdEmpresa], [IdSucursal], [IdBodega], [IdMovi_inven_tipo], [IdNumMovi], [Secuencia])
);

