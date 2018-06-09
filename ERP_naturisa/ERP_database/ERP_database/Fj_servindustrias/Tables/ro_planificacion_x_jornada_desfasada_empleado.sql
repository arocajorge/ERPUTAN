CREATE TABLE [Fj_servindustrias].[ro_planificacion_x_jornada_desfasada_empleado] (
    [IdEmpresa]     INT           NOT NULL,
    [IdNomina_Tipo] INT           NOT NULL,
    [IdEmpleado]    NUMERIC (18)  NOT NULL,
    [IdPeriodo]     INT           NOT NULL,
    [IdMes]         INT           NOT NULL,
    [IdAnio]        INT           NOT NULL,
    [IdTurno]       NUMERIC (18)  NOT NULL,
    [Observacion]   VARCHAR (500) NULL,
    [Estado]        CHAR (1)      NOT NULL,
    CONSTRAINT [PK_ro_planificacion_x_jornada_desfasada_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdPeriodo] ASC, [IdMes] ASC, [IdAnio] ASC),
    CONSTRAINT [FK_ro_planificacion_x_jornada_desfasada_empleado_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_planificacion_x_jornada_desfasada_empleado_ro_planificacion_x_jornada_desfasada] FOREIGN KEY ([IdEmpresa], [IdPeriodo], [IdNomina_Tipo]) REFERENCES [Fj_servindustrias].[ro_planificacion_x_jornada_desfasada] ([IdEmpresa], [IdPeriodo], [IdNomina_Tipo]),
    CONSTRAINT [FK_ro_planificacion_x_jornada_desfasada_empleado_ro_turno] FOREIGN KEY ([IdEmpresa], [IdTurno]) REFERENCES [dbo].[ro_turno] ([IdEmpresa], [IdTurno])
);

