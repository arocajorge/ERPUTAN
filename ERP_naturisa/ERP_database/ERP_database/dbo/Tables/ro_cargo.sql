CREATE TABLE [dbo].[ro_cargo] (
    [IdEmpresa]       INT           NOT NULL,
    [IdCargo]         INT           NOT NULL,
    [ca_descripcion]  VARCHAR (50)  NOT NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [MotivoAnulacion] VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_Cargo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCargo] ASC)
);

