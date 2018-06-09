CREATE TABLE [Fj_servindustrias].[ro_empleado_x_parametro_x_pago_variable_Det] (
    [IdEmpresa]             INT          NOT NULL,
    [IdNomina_Tipo]         INT          NOT NULL,
    [IdEmpleado]            NUMERIC (18) NOT NULL,
    [Id_Tipo_Pago_Variable] INT          NOT NULL,
    [Secuencia]             INT          NOT NULL,
    CONSTRAINT [PK_ro_empleado_x_parametro_liquidacion_variable_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [Id_Tipo_Pago_Variable] ASC),
    CONSTRAINT [FK_ro_empleado_x_parametro_x_pago_variable_Det_ro_empleado_x_parametro_x_pago_variable] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado]) REFERENCES [Fj_servindustrias].[ro_empleado_x_parametro_x_pago_variable] ([IdEmpresa], [IdNomina_Tipo], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_x_parametro_x_pago_variable_Det_ro_parametro_x_pago_variable] FOREIGN KEY ([IdEmpresa], [IdNomina_Tipo], [Id_Tipo_Pago_Variable]) REFERENCES [Fj_servindustrias].[ro_parametro_x_pago_variable] ([IdEmpresa], [IdNomina_Tipo], [Id_Tipo_Pago_Variable])
);

