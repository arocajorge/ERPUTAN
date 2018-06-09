CREATE TABLE [Fj_servindustrias].[ro_empleado_x_Activo_Fijo] (
    [IdEmpresa]        INT          NOT NULL,
    [IdNomina_tipo]    INT          NOT NULL,
    [IdPeriodo]        INT          NOT NULL,
    [IdActivo_fijo]    INT          NOT NULL,
    [IdEmpleado]       NUMERIC (18) NOT NULL,
    [Fecha_Asignacion] DATE         NOT NULL,
    [Fecha_Hasta]      DATE         NOT NULL,
    CONSTRAINT [PK_ro_empleado_x_Activo_Fijo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_tipo] ASC, [IdPeriodo] ASC, [IdActivo_fijo] ASC, [IdEmpleado] ASC)
);

