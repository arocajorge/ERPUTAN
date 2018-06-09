CREATE TABLE [dbo].[ro_empleado_x_ro_rubro] (
    [IdEmpresa]          INT          NOT NULL,
    [IdNomina_Tipo]      INT          NOT NULL,
    [IdNomina_TipoLiqui] INT          NOT NULL,
    [IdEmpleado]         NUMERIC (18) NOT NULL,
    [IdRubro]            VARCHAR (10) NOT NULL,
    [Valor]              MONEY        NOT NULL,
    [IdCentroCosto]      VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_ro_empleado_x_ro_rubro_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_TipoLiqui] ASC, [IdEmpleado] ASC, [IdRubro] ASC, [IdCentroCosto] ASC),
    CONSTRAINT [FK_ro_empleado_x_ro_rubro_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);

