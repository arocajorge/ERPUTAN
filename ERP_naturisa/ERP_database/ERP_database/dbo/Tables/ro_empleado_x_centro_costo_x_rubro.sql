CREATE TABLE [dbo].[ro_empleado_x_centro_costo_x_rubro] (
    [IdEmpresa]       INT          NOT NULL,
    [IdEmpleado]      NUMERIC (18) NOT NULL,
    [IdCentroCosto]   VARCHAR (20) NOT NULL,
    [IdRubro]         VARCHAR (50) NOT NULL,
    [Valor]           FLOAT (53)   NOT NULL,
    [FechaIngresa]    DATETIME     NOT NULL,
    [UsuarioIngresa]  VARCHAR (25) NOT NULL,
    [FechaModifica]   DATETIME     NULL,
    [UsuarioModifica] VARCHAR (25) NULL,
    CONSTRAINT [PK_ro_empleado_x_centro_costo_x_rubro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCentroCosto] ASC, [IdEmpleado] ASC, [IdRubro] ASC)
);

