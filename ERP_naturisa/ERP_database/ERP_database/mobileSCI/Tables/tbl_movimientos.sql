CREATE TABLE [mobileSCI].[tbl_movimientos] (
    [IdSincronizacion] NUMERIC (18) NOT NULL,
    [IdUsuarioSCI]     VARCHAR (50) NOT NULL,
    [IdFecha]          INT          NOT NULL,
    [Fecha]            DATETIME     NOT NULL,
    CONSTRAINT [PK_tbl_movimientos] PRIMARY KEY CLUSTERED ([IdSincronizacion] ASC)
);

