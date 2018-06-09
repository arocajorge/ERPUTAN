CREATE TABLE [dbo].[ro_empleado_historial_Sueldo] (
    [IdEmpresa]             INT           NOT NULL,
    [IdEmpleado]            NUMERIC (18)  NOT NULL,
    [Secuencia]             INT           NOT NULL,
    [SueldoAnterior]        FLOAT (53)    NOT NULL,
    [SueldoActual]          FLOAT (53)    NOT NULL,
    [PorIncrementoSueldo]   FLOAT (53)    NOT NULL,
    [ValorIncrementoSueldo] FLOAT (53)    NOT NULL,
    [Motivo]                VARCHAR (200) NOT NULL,
    [Fecha]                 DATETIME      NOT NULL,
    [idUsuario]             VARCHAR (20)  NULL,
    [Fecha_Transac]         DATETIME      NULL,
    [IdUsuarioUltModi]      VARCHAR (20)  NULL,
    [Fecha_UltMod]          DATETIME      NULL,
    [nom_pc]                VARCHAR (50)  NULL,
    [ip]                    VARCHAR (30)  NULL,
    [de_descripcion]        VARCHAR (50)  NULL,
    [ca_descripcion]        VARCHAR (50)  NULL,
    [IdCentroCosto]         VARCHAR (20)  NULL,
    CONSTRAINT [PK_ro_empleado_historial_Sueldo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_ro_empleado_historial_Sueldo_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);

