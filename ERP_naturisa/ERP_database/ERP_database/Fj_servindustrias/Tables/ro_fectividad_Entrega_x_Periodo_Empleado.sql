CREATE TABLE [Fj_servindustrias].[ro_fectividad_Entrega_x_Periodo_Empleado] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdNomina_tipo_Liq] INT           NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [IdEfectividad]     INT           NOT NULL,
    [Observacion]       VARCHAR (250) NOT NULL,
    [Estado]            BIT           NOT NULL,
    [IdUsuario]         VARCHAR (20)  NULL,
    [IdUsuarioAnu]      VARCHAR (20)  NULL,
    [MotivoAnu]         VARCHAR (100) NULL,
    [IdUsuarioUltModi]  VARCHAR (20)  NULL,
    [FechaAnu]          DATETIME      NULL,
    [FechaTransac]      DATETIME      NOT NULL,
    [FechaUltModi]      DATETIME      NULL,
    CONSTRAINT [PK_ro_fectividad_Entrega_x_Periodo_Empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_tipo_Liq] ASC, [IdPeriodo] ASC, [IdEfectividad] ASC)
);

