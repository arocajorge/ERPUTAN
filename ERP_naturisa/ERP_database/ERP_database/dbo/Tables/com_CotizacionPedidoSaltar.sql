CREATE TABLE [dbo].[com_CotizacionPedidoSaltar] (
    [IdEmpresa]    INT          NOT NULL,
    [IdCotizacion] NUMERIC (18) NOT NULL,
    [IdUsuario]    VARCHAR (50) NOT NULL,
    [Observacion]  VARCHAR (1)  NULL,
    CONSTRAINT [PK_com_CotizacionPedidoSaltar] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCotizacion] ASC, [IdUsuario] ASC)
);

