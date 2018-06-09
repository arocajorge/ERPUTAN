CREATE TABLE [Fj_servindustrias].[ro_fuerza] (
    [IdEmpresa]         INT           NOT NULL,
    [IdFuerza]          INT           NOT NULL,
    [fu_descripcion]    VARCHAR (100) NULL,
    [Estado]            BIT           NOT NULL,
    [IdUsuario]         VARCHAR (50)  NULL,
    [Fecha_Transaccion] DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (50)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (50)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (50)  NULL,
    [nom_pc]            VARCHAR (50)  NULL,
    [ip]                VARCHAR (50)  NULL,
    CONSTRAINT [PK_ro_fuerza] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdFuerza] ASC)
);

