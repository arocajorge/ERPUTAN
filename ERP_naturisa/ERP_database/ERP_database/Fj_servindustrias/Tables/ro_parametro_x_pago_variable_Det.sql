CREATE TABLE [Fj_servindustrias].[ro_parametro_x_pago_variable_Det] (
    [Idempresa]                       INT          NOT NULL,
    [IdNomina_Tipo]                   INT          NOT NULL,
    [Id_Tipo_Pago_Variable]           INT          NOT NULL,
    [cod_Pago_Variable]               VARCHAR (50) NOT NULL,
    [Meta]                            FLOAT (53)   NOT NULL,
    [Variable_porcentaje_prorrateado] FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_parametro_x_pago_variable_Det_1] PRIMARY KEY CLUSTERED ([Idempresa] ASC, [IdNomina_Tipo] ASC, [Id_Tipo_Pago_Variable] ASC, [cod_Pago_Variable] ASC),
    CONSTRAINT [FK_ro_parametro_x_pago_variable_Det_ro_parametro_x_pago_variable] FOREIGN KEY ([Idempresa], [IdNomina_Tipo], [Id_Tipo_Pago_Variable]) REFERENCES [Fj_servindustrias].[ro_parametro_x_pago_variable] ([IdEmpresa], [IdNomina_Tipo], [Id_Tipo_Pago_Variable]),
    CONSTRAINT [FK_ro_parametro_x_pago_variable_Det_ro_parametro_x_pago_variable_tipo] FOREIGN KEY ([Idempresa], [cod_Pago_Variable]) REFERENCES [Fj_servindustrias].[ro_parametro_x_pago_variable_tipo] ([IdEmpresa], [cod_Pago_Variable]),
    CONSTRAINT [FK_ro_parametro_x_pago_variable_Det_tb_empresa] FOREIGN KEY ([Idempresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

