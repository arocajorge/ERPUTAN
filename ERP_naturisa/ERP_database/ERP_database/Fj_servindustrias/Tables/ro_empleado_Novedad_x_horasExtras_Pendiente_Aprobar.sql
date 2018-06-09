CREATE TABLE [Fj_servindustrias].[ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdEmpleado]        NUMERIC (9)   NOT NULL,
    [IdRegistro]        VARCHAR (50)  NOT NULL,
    [IdRubro]           VARCHAR (10)  NOT NULL,
    [es_fecha_registro] DATETIME      NOT NULL,
    [Num_horasExtras]   VARCHAR (10)  NOT NULL,
    [Observacion]       VARCHAR (100) NULL,
    [Estado_aprobacion] BIT           NOT NULL,
    CONSTRAINT [PK_ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdRegistro] ASC, [IdRubro] ASC)
);

