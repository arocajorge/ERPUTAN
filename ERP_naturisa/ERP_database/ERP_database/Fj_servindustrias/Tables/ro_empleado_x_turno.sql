CREATE TABLE [Fj_servindustrias].[ro_empleado_x_turno] (
    [IdEmpresa]       INT           NOT NULL,
    [IdNomina_Tipo]   INT           NOT NULL,
    [IdEmpleado]      DECIMAL (9)   NOT NULL,
    [IdPeriodo]       INT           NOT NULL,
    [IdTurno]         INT           NOT NULL,
    [Observacion]     VARCHAR (500) NULL,
    [Estado]          CHAR (1)      NOT NULL,
    [IdUsuario]       CHAR (20)     NULL,
    [Fecha_Transac]   DATETIME      NULL,
    [IdUsuarioModif]  CHAR (20)     NULL,
    [Fecha_UltMod]    DATETIME      NULL,
    [FechaHoraAnul]   DATETIME      NULL,
    [IdUsuarioUltAnu] CHAR (20)     NULL,
    [MotivoAnulacion] VARCHAR (500) NULL,
    CONSTRAINT [PK_ro_empleado_x_turno] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdPeriodo] ASC, [IdTurno] ASC)
);

