CREATE TABLE [Fj_servindustrias].[ro_planificacion_x_ruta_x_empleado_det] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdNomina_Tipo_Liq] INT           NOT NULL,
    [IdPeriodo]         INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [IdPlaca]           INT           NULL,
    [IdRuta]            INT           NULL,
    [IdFuerza]          INT           NULL,
    [IdZona]            INT           NULL,
    [IdDisco]           INT           NULL,
    [Observacion]       VARCHAR (200) NULL,
    CONSTRAINT [PK_ro_planificacion_x_ruta_x_empleado_det_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_Tipo_Liq] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_disco] FOREIGN KEY ([IdEmpresa], [IdDisco]) REFERENCES [Fj_servindustrias].[ro_disco] ([IdEmpresa], [IdDisco]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_fuerza] FOREIGN KEY ([IdEmpresa], [IdFuerza]) REFERENCES [Fj_servindustrias].[ro_fuerza] ([IdEmpresa], [IdFuerza]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_placa] FOREIGN KEY ([IdEmpresa], [IdPlaca]) REFERENCES [Fj_servindustrias].[ro_placa] ([IdEmpresa], [IdPlaca]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_planificacion_x_ruta_x_empleado] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdNomina_Tipo_Liq], [IdPeriodo]) REFERENCES [Fj_servindustrias].[ro_planificacion_x_ruta_x_empleado] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_tipo_Liq], [IdPeriodo]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_ruta] FOREIGN KEY ([IdEmpresa], [IdRuta]) REFERENCES [Fj_servindustrias].[ro_ruta] ([IdEmpresa], [IdRuta]),
    CONSTRAINT [FK_ro_planificacion_x_ruta_x_empleado_det_ro_zona] FOREIGN KEY ([IdEmpresa], [IdZona]) REFERENCES [Fj_servindustrias].[ro_zona] ([IdEmpresa], [IdZona])
);

