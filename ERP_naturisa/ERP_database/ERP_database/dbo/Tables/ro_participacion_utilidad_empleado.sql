CREATE TABLE [dbo].[ro_participacion_utilidad_empleado] (
    [IdEmpresa]          INT          NOT NULL,
    [IdPeriodo]          INT          NOT NULL,
    [IdEmpleado]         NUMERIC (18) NOT NULL,
    [DiasTrabajados]     FLOAT (53)   NOT NULL,
    [CargasFamiliares]   FLOAT (53)   NOT NULL,
    [ValorIndividual]    FLOAT (53)   NOT NULL,
    [ValorCargaFamiliar] FLOAT (53)   NOT NULL,
    [ValorExedenteIESS]  FLOAT (53)   NOT NULL,
    [ValorTotal]         FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_participacion_utilidad_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_participacion_utilidad_empleado_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_participacion_utilidad_empleado_ro_participacion_utilidad] FOREIGN KEY ([IdEmpresa], [IdPeriodo]) REFERENCES [dbo].[ro_participacion_utilidad] ([IdEmpresa], [IdPeriodo])
);

