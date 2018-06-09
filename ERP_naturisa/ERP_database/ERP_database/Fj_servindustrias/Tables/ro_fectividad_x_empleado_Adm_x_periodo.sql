CREATE TABLE [Fj_servindustrias].[ro_fectividad_x_empleado_Adm_x_periodo] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdNomina_Tipo_Liq] INT           NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [Observacion]       VARCHAR (200) NOT NULL,
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
    CONSTRAINT [PK_ro_fectividad_x_empleado_Adm_x_periodo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_Tipo_Liq] ASC, [IdPeriodo] ASC)
);

