CREATE TABLE [dbo].[ro_empleado_x_Proyeccion_Gastos_Personales] (
    [IdEmpresa]       INT          NOT NULL,
    [IdEmpleado]      NUMERIC (18) NOT NULL,
    [IdTipoGasto]     VARCHAR (10) NOT NULL,
    [AnioFiscal]      INT          NOT NULL,
    [Valor]           FLOAT (53)   NOT NULL,
    [FechaIngresa]    DATETIME     NOT NULL,
    [UsuarioIngresa]  VARCHAR (25) NULL,
    [FechaModifica]   DATETIME     NULL,
    [UsuarioModifica] VARCHAR (25) NULL,
    CONSTRAINT [PK_ro_empleado_x_Proyeccion_Gastos_Personales] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdTipoGasto] ASC, [AnioFiscal] ASC),
    CONSTRAINT [FK_ro_empleado_x_Proyeccion_Gastos_Personales_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_x_Proyeccion_Gastos_Personales_ro_tipo_gastos_personales] FOREIGN KEY ([IdTipoGasto]) REFERENCES [dbo].[ro_tipo_gastos_personales] ([IdTipoGasto])
);

