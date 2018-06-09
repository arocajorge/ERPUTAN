CREATE TABLE [Fj_servindustrias].[ro_parametro_x_pago_variable_tipo] (
    [IdEmpresa]         INT           NOT NULL,
    [cod_Pago_Variable] VARCHAR (50)  NOT NULL,
    [nom_Pago_Variable] VARCHAR (250) NOT NULL,
    [IdRubro]           VARCHAR (50)  NULL,
    CONSTRAINT [PK_ro_parametro_x_pago_variable_tipo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [cod_Pago_Variable] ASC)
);

