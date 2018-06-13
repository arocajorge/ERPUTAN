CREATE TABLE [mobileSCI].[tbl_sincronizacion_turno] (
    [IdSincronizacion] INT      IDENTITY (1, 1) NOT NULL,
    [EnUso]            BIT      NOT NULL,
    [FechaInicio]      DATETIME NOT NULL,
    CONSTRAINT [PK_tbl_sincronizacion_turno] PRIMARY KEY CLUSTERED ([IdSincronizacion] ASC)
);

