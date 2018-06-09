CREATE TABLE [Fj_servindustrias].[fa_orden_trabajo_plataforma] (
    [IdEmpresa]           INT           NOT NULL,
    [IdOrdenTrabajo_Pla]  NUMERIC (18)  NOT NULL,
    [codOrdenTrabajo_Pla] VARCHAR (50)  NOT NULL,
    [IdCliente]           NUMERIC (18)  NOT NULL,
    [Descripcion]         VARCHAR (250) NOT NULL,
    [Equipo]              VARCHAR (150) NOT NULL,
    [serie]               VARCHAR (50)  NOT NULL,
    [Fecha]               DATE          NOT NULL,
    [km_salida]           FLOAT (53)    NOT NULL,
    [km_llegada]          FLOAT (53)    NOT NULL,
    [con_atencion_a]      VARCHAR (150) NOT NULL,
    [IdUsuarioUltMod]     VARCHAR (20)  NULL,
    [Fecha_UltMod]        DATETIME      NULL,
    [IdUsuarioUltAnu]     VARCHAR (20)  NULL,
    [Fecha_UltAnu]        DATETIME      NULL,
    [MotiAnula]           VARCHAR (200) NULL,
    [nom_pc]              VARCHAR (50)  NOT NULL,
    [ip]                  VARCHAR (25)  NOT NULL,
    [Estado]              CHAR (1)      NOT NULL,
    CONSTRAINT [PK_fa_orden_trabajo_plataforma] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdOrdenTrabajo_Pla] ASC)
);

