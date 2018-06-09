CREATE TABLE [Fj_servindustrias].[ro_marcaciones_x_empleado_x_incidentes_falt_Perm] (
    [IdEmpresa]            INT           NOT NULL,
    [IdNomina_Tipo]        INT           NOT NULL,
    [IdEmpleado]           NUMERIC (18)  NOT NULL,
    [IdRegistro]           VARCHAR (50)  NOT NULL,
    [IdTurno]              NUMERIC (18)  NOT NULL,
    [es_fecha_registro]    DATETIME      NOT NULL,
    [Id_catalogo_Cat]      VARCHAR (10)  NOT NULL,
    [Observacion]          VARCHAR (100) NULL,
    [es_jornada_desfasada] BIT           NOT NULL,
    [IdDisco]              INT           NULL,
    [IdRuta]               INT           NULL,
    [IdSala]               INT           NULL,
    CONSTRAINT [PK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdRegistro] ASC, [IdTurno] ASC, [es_fecha_registro] ASC, [Id_catalogo_Cat] ASC),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_ro_catalogo] FOREIGN KEY ([Id_catalogo_Cat]) REFERENCES [dbo].[ro_catalogo] ([CodCatalogo]),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_ro_disco] FOREIGN KEY ([IdEmpresa], [IdDisco]) REFERENCES [Fj_servindustrias].[ro_disco] ([IdEmpresa], [IdDisco]),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_ro_ruta] FOREIGN KEY ([IdEmpresa], [IdRuta]) REFERENCES [Fj_servindustrias].[ro_ruta] ([IdEmpresa], [IdRuta]),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_ro_sala] FOREIGN KEY ([IdEmpresa], [IdSala]) REFERENCES [Fj_servindustrias].[ro_sala] ([IdEmpresa], [IdSala]),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_ro_turno] FOREIGN KEY ([IdEmpresa], [IdTurno]) REFERENCES [dbo].[ro_turno] ([IdEmpresa], [IdTurno]),
    CONSTRAINT [FK_ro_marcaciones_x_empleado_x_incidentes_falt_Perm_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

