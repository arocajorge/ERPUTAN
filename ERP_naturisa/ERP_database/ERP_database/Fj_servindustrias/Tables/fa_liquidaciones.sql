CREATE TABLE [Fj_servindustrias].[fa_liquidaciones] (
    [IdEmpresa]         INT           NOT NULL,
    [IdLiquidaciones]   NUMERIC (18)  NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [fecha]             DATETIME      NOT NULL,
    [Observacion]       VARCHAR (150) NOT NULL,
    [Estado_Proceso]    VARCHAR (50)  NOT NULL,
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
    CONSTRAINT [PK_fa_liquidaciones] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidaciones] ASC)
);

