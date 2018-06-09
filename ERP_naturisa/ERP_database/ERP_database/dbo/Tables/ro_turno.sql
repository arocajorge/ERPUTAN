CREATE TABLE [dbo].[ro_turno] (
    [IdEmpresa]            INT           NOT NULL,
    [IdTurno]              NUMERIC (18)  NOT NULL,
    [tu_descripcion]       VARCHAR (50)  NOT NULL,
    [Estado]               CHAR (1)      NOT NULL,
    [IdUsuario]            VARCHAR (20)  NULL,
    [Fecha_Transac]        DATETIME      NULL,
    [IdUsuarioUltMod]      VARCHAR (20)  NULL,
    [Fecha_UltMod]         DATETIME      NULL,
    [IdUsuarioUltAnu]      VARCHAR (20)  NULL,
    [Fecha_UltAnu]         DATETIME      NULL,
    [nom_pc]               VARCHAR (50)  NULL,
    [ip]                   VARCHAR (25)  NULL,
    [MotiAnula]            VARCHAR (200) NULL,
    [es_jornada_desfasada] BIT           NULL,
    CONSTRAINT [PK_ro_turno_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTurno] ASC)
);

