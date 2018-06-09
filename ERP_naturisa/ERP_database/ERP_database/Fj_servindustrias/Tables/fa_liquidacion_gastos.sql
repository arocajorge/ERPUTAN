CREATE TABLE [Fj_servindustrias].[fa_liquidacion_gastos] (
    [IdEmpresa]         INT           NOT NULL,
    [IdLiquidacion]     NUMERIC (18)  NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [cod_liquidacion]   VARCHAR (50)  NOT NULL,
    [IdCliente]         NUMERIC (18)  NOT NULL,
    [fecha_liqui]       DATETIME      NOT NULL,
    [Observacion]       VARCHAR (550) NOT NULL,
    [estado]            CHAR (1)      NOT NULL,
    [IdUsuario]         VARCHAR (50)  NULL,
    [Fecha_Transaccion] DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (50)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (50)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (50)  NULL,
    [nom_pc]            VARCHAR (50)  NULL,
    [ip]                VARCHAR (50)  NULL,
    CONSTRAINT [PK_fa_liquidacion_gastos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC),
    CONSTRAINT [FK_fa_liquidacion_gastos_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

