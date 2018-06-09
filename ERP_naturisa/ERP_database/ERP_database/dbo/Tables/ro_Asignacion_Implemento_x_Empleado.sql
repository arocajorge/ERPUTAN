CREATE TABLE [dbo].[ro_Asignacion_Implemento_x_Empleado] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [IdAsignacion_Impl] NUMERIC (18)  NOT NULL,
    [Tipo_Movimiento]   VARCHAR (5)   NOT NULL,
    [Fecha_Entrega]     DATE          NOT NULL,
    [Observacion]       VARCHAR (250) NOT NULL,
    [Estado]            CHAR (1)      NULL,
    [IdUsuario]         VARCHAR (20)  NULL,
    [Fecha_Transac]     DATETIME      NULL,
    [IdUsuarioUltMod]   VARCHAR (20)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (20)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [nom_pc]            VARCHAR (50)  NULL,
    [ip]                VARCHAR (25)  NULL,
    [MotivoAnulacion]   VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_Asignacion_Implemento_x_Empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdAsignacion_Impl] ASC)
);

