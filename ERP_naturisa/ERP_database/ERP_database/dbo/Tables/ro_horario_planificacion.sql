CREATE TABLE [dbo].[ro_horario_planificacion] (
    [IdEmpresa]    INT           NOT NULL,
    [IdCalendario] INT           NOT NULL,
    [IdEmpleado]   NUMERIC (18)  NOT NULL,
    [IdRegistro]   NUMERIC (18)  NOT NULL,
    [IdHorario]    NUMERIC (18)  NOT NULL,
    [Estado]       CHAR (1)      NULL,
    [Observacion]  VARCHAR (200) NULL,
    CONSTRAINT [PK_ro_horario_planificacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCalendario] ASC, [IdEmpleado] ASC, [IdRegistro] ASC),
    CONSTRAINT [FK_ro_horario_planificacion_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_horario_planificacion_ro_horario] FOREIGN KEY ([IdEmpresa], [IdHorario]) REFERENCES [dbo].[ro_horario] ([IdEmpresa], [IdHorario])
);

