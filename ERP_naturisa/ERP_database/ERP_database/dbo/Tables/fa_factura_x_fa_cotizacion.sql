CREATE TABLE [dbo].[fa_factura_x_fa_cotizacion] (
    [fa_IdEmpresa]    INT          NOT NULL,
    [fa_IdSucursal]   INT          NOT NULL,
    [fa_IdBodega]     INT          NOT NULL,
    [fa_IdCbteVta]    NUMERIC (18) NOT NULL,
    [cc_IdEmpresa]    INT          NOT NULL,
    [cc_IdSucursal]   INT          NOT NULL,
    [cc_IdBodega]     INT          NOT NULL,
    [cc_IdCotizacion] NUMERIC (18) NOT NULL,
    [Observacion]     VARCHAR (50) NULL,
    CONSTRAINT [PK_fa_factura_x_fa_guia_remision] PRIMARY KEY CLUSTERED ([fa_IdEmpresa] ASC, [fa_IdSucursal] ASC, [fa_IdBodega] ASC, [fa_IdCbteVta] ASC, [cc_IdEmpresa] ASC, [cc_IdSucursal] ASC, [cc_IdBodega] ASC, [cc_IdCotizacion] ASC),
    CONSTRAINT [FK_fa_factura_x_fa_cotizacion_fa_cotizacion] FOREIGN KEY ([cc_IdEmpresa], [cc_IdSucursal], [cc_IdBodega], [cc_IdCotizacion]) REFERENCES [dbo].[fa_cotizacion] ([IdEmpresa], [IdSucursal], [IdBodega], [IdCotizacion]),
    CONSTRAINT [FK_fa_factura_x_fa_cotizacion_fa_factura] FOREIGN KEY ([fa_IdEmpresa], [fa_IdSucursal], [fa_IdBodega], [fa_IdCbteVta]) REFERENCES [dbo].[fa_factura] ([IdEmpresa], [IdSucursal], [IdBodega], [IdCbteVta])
);

