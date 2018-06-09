CREATE TABLE [Fj_servindustrias].[ro_sala] (
    [IdEmpresa]         INT          NOT NULL,
    [IdSala]            INT          NOT NULL,
    [Sala]              VARCHAR (50) NOT NULL,
    [Estado]            BIT          NOT NULL,
    [IdUsuario]         VARCHAR (50) NULL,
    [Fecha_Transaccion] DATETIME     NULL,
    [IdUsuarioUltModi]  VARCHAR (50) NULL,
    [Fecha_UltMod]      DATETIME     NULL,
    [IdUsuarioUltAnu]   VARCHAR (50) NULL,
    [Fecha_UltAnu]      DATETIME     NULL,
    [MotivoAnulacion]   VARCHAR (50) NULL,
    [nom_pc]            VARCHAR (50) NULL,
    [ip]                VARCHAR (50) NULL,
    CONSTRAINT [PK_ro_sala] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSala] ASC)
);

