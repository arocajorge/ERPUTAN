CREATE TABLE [dbo].[ro_empleado_x_centro_costo] (
    [IdEmpresa]                      INT          NOT NULL,
    [IdEmpleado]                     NUMERIC (18) NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NULL,
    [FechaIngresa]                   DATETIME     NOT NULL,
    [UsuarioIngresa]                 VARCHAR (25) NOT NULL,
    [FechaModifica]                  DATETIME     NULL,
    [UsuarioModifica]                VARCHAR (25) NULL,
    CONSTRAINT [PK_ro_empleado_x_centro_costo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_empleado_x_centro_costo_ct_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_ro_empleado_x_centro_costo_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);

