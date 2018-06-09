CREATE TABLE [Fj_servindustrias].[ro_fectividad_x_empleado_Adm_x_periodo_Det] (
    [IdEmpresa]                       INT          NOT NULL,
    [IdNomina_Tipo]                   INT          NOT NULL,
    [IdNomina_Tipo_Liq]               INT          NOT NULL,
    [IdPeriodo]                       INT          NOT NULL,
    [IdEmpleado]                      NUMERIC (18) NOT NULL,
    [cod_Pago_Variable]               VARCHAR (50) NOT NULL,
    [Meta]                            FLOAT (53)   NULL,
    [Real]                            FLOAT (53)   NULL,
    [Cumplimiento]                    FLOAT (53)   NULL,
    [Variable_porcentaje_prorrateado] FLOAT (53)   NULL,
    CONSTRAINT [PK_ro_fectividad_x_empleado_Adm_x_periodo_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_Tipo_Liq] ASC, [IdPeriodo] ASC, [IdEmpleado] ASC, [cod_Pago_Variable] ASC),
    CONSTRAINT [FK_ro_fectividad_x_empleado_Adm_x_periodo_Det_ro_fectividad_x_empleado_Adm_x_periodo] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdNomina_Tipo_Liq], [IdPeriodo]) REFERENCES [Fj_servindustrias].[ro_fectividad_x_empleado_Adm_x_periodo] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_Tipo_Liq], [IdPeriodo]),
    CONSTRAINT [FK_ro_fectividad_x_empleado_Adm_x_periodo_Det_ro_parametro_x_pago_variable_tipo] FOREIGN KEY ([IdEmpresa], [cod_Pago_Variable]) REFERENCES [Fj_servindustrias].[ro_parametro_x_pago_variable_tipo] ([IdEmpresa], [cod_Pago_Variable]),
    CONSTRAINT [FK_ro_fectividad_x_empleado_Adm_x_periodo_Det_ro_periodo_x_ro_Nomina_TipoLiqui] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdNomina_Tipo_Liq], [IdPeriodo]) REFERENCES [dbo].[ro_periodo_x_ro_Nomina_TipoLiqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [IdPeriodo])
);

