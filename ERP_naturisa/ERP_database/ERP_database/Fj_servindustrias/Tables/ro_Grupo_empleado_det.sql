CREATE TABLE [Fj_servindustrias].[ro_Grupo_empleado_det] (
    [IdEmpresa]          INT          NOT NULL,
    [IdGrupo]            INT          NOT NULL,
    [cod_Pago_Variable]  VARCHAR (50) NOT NULL,
    [Porcentaje_calculo] FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_Grupo_empleado_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGrupo] ASC, [cod_Pago_Variable] ASC),
    CONSTRAINT [FK_ro_Grupo_empleado_det_ro_Grupo_empleado] FOREIGN KEY ([IdEmpresa], [IdGrupo]) REFERENCES [Fj_servindustrias].[ro_Grupo_empleado] ([IdEmpresa], [IdGrupo]),
    CONSTRAINT [FK_ro_Grupo_empleado_det_ro_parametro_x_pago_variable_tipo] FOREIGN KEY ([IdEmpresa], [cod_Pago_Variable]) REFERENCES [Fj_servindustrias].[ro_parametro_x_pago_variable_tipo] ([IdEmpresa], [cod_Pago_Variable])
);

