CREATE TABLE [dbo].[ro_rol_individual] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNominaTipo]      INT           NOT NULL,
    [IdNominaTipoLiqui] INT           NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [IdRubro]           VARCHAR (10)  NOT NULL,
    [Ingreso]           FLOAT (53)    NOT NULL,
    [Egreso]            FLOAT (53)    NOT NULL,
    [Orden]             INT           NOT NULL,
    [FechaPago]         VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_rol_individual] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNominaTipo] ASC, [IdNominaTipoLiqui] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC, [IdRubro] ASC),
    CONSTRAINT [FK_ro_rol_individual_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_rol_individual_ro_rol] FOREIGN KEY ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [IdPeriodo]) REFERENCES [dbo].[ro_rol] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [IdPeriodo])
);

