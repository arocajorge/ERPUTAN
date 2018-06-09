CREATE TABLE [Fj_servindustrias].[ro_empleado_x_rutas_asignadas_Det] (
    [IdEmpresa]     INT          NOT NULL,
    [IdNomina_Tipo] INT          NOT NULL,
    [IdEmpleado]    NUMERIC (18) NOT NULL,
    [IdRuta]        INT          NOT NULL,
    [secuencia]     INT          NOT NULL,
    CONSTRAINT [PK_ro_empleado_x_rutas_asignadas_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdRuta] ASC),
    CONSTRAINT [FK_ro_empleado_x_rutas_asignadas_Det_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_x_rutas_asignadas_Det_ro_empleado_x_rutas_asignadas] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado]) REFERENCES [Fj_servindustrias].[ro_empleado_x_rutas_asignadas] ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_x_rutas_asignadas_Det_ro_ruta] FOREIGN KEY ([IdEmpresa], [IdRuta]) REFERENCES [Fj_servindustrias].[ro_ruta] ([IdEmpresa], [IdRuta])
);

