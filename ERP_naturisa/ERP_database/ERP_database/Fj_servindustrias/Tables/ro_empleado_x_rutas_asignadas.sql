CREATE TABLE [Fj_servindustrias].[ro_empleado_x_rutas_asignadas] (
    [IdEmpresa]         INT          NOT NULL,
    [IdNomina_Tipo]     INT          NOT NULL,
    [IdEmpleado]        NUMERIC (18) NOT NULL,
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
    CONSTRAINT [PK_ro_empleado_x_rutas_asignadas] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_empleado_x_rutas_asignadas_ro_empleado_x_ro_tipoNomina] FOREIGN KEY ([IdEmpresa], [IdEmpleado], [IdNomina_Tipo]) REFERENCES [dbo].[ro_empleado_x_ro_tipoNomina] ([IdEmpresa], [IdEmpleado], [IdTipoNomina])
);

