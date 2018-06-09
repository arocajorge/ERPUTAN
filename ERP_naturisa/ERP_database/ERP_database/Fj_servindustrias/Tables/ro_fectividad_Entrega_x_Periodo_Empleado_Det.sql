CREATE TABLE [Fj_servindustrias].[ro_fectividad_Entrega_x_Periodo_Empleado_Det] (
    [IdEmpresa]                   INT           NOT NULL,
    [IdNomina_Tipo]               INT           NOT NULL,
    [IdNomina_tipo_Liq]           INT           NOT NULL,
    [IdPeriodo]                   INT           NOT NULL,
    [IdEmpleado]                  INT           NOT NULL,
    [IdRuta]                      INT           NOT NULL,
    [IdEfectividad]               INT           NOT NULL,
    [Efectividad_Entrega]         FLOAT (53)    NOT NULL,
    [Efectividad_Entrega_aplica]  FLOAT (53)    NOT NULL,
    [Efectividad_Volumen]         FLOAT (53)    NOT NULL,
    [Efectividad_Volumen_aplica]  FLOAT (53)    NOT NULL,
    [Recuperacion_cartera]        FLOAT (53)    NOT NULL,
    [Recuperacion_cartera_aplica] FLOAT (53)    NOT NULL,
    [Observacion]                 VARCHAR (200) NULL,
    CONSTRAINT [PK_ro_fectividad_Entrega_x_Periodo_Empleado_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_tipo_Liq] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC, [IdRuta] ASC, [IdEfectividad] ASC)
);

