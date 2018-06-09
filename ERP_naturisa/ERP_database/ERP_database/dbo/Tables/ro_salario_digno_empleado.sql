CREATE TABLE [dbo].[ro_salario_digno_empleado] (
    [IdEmpresa]      INT          NOT NULL,
    [IdNominaTipo]   INT          NOT NULL,
    [IdPeriodo]      INT          NOT NULL,
    [IdEmpleado]     NUMERIC (18) NOT NULL,
    [Valor]          FLOAT (53)   NOT NULL,
    [FechaIngresa]   DATETIME     NOT NULL,
    [UsuarioIngresa] VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_ro_salario_digno_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNominaTipo] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_salario_digno_empleado_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_salario_digno_empleado_ro_salario_digno] FOREIGN KEY ([IdEmpresa], [IdNominaTipo], [IdPeriodo]) REFERENCES [dbo].[ro_salario_digno] ([IdEmpresa], [IdNominaTipo], [IdPeriodo])
);

