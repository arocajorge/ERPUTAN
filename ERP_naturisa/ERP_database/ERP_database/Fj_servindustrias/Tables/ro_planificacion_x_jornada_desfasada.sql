CREATE TABLE [Fj_servindustrias].[ro_planificacion_x_jornada_desfasada] (
    [IdEmpresa]       INT           NOT NULL,
    [IdPeriodo]       INT           NOT NULL,
    [IdNomina_Tipo]   INT           NOT NULL,
    [Observación]     VARCHAR (250) NULL,
    [Esta_Proceso]    VARCHAR (25)  NOT NULL,
    [IdUsuario]       VARCHAR (20)  NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioUltMod] VARCHAR (20)  NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [IdUsuarioUltAnu] VARCHAR (20)  NULL,
    [Fecha_UltAnu]    DATETIME      NULL,
    [nom_pc]          VARCHAR (50)  NULL,
    [ip]              VARCHAR (25)  NULL,
    [Estado]          CHAR (1)      NULL,
    [MotiAnula]       VARCHAR (200) NULL,
    CONSTRAINT [PK_ro_planificacion_x_jornada_desfasada] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [IdNomina_Tipo] ASC),
    CONSTRAINT [FK_ro_planificacion_x_jornada_desfasada_ro_periodo] FOREIGN KEY ([IdEmpresa], [IdPeriodo]) REFERENCES [dbo].[ro_periodo] ([IdEmpresa], [IdPeriodo]),
    CONSTRAINT [FK_ro_planificacion_x_jornada_desfasada_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

