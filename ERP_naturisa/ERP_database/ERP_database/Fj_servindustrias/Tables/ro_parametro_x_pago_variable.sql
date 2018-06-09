CREATE TABLE [Fj_servindustrias].[ro_parametro_x_pago_variable] (
    [IdEmpresa]             INT            NOT NULL,
    [IdNomina_Tipo]         INT            NOT NULL,
    [Id_Tipo_Pago_Variable] INT            NOT NULL,
    [Nombre]                VARCHAR (250)  NOT NULL,
    [Estado]                BIT            NOT NULL,
    [IdUsuario]             VARCHAR (50)   NULL,
    [Fecha_Transaccion]     DATETIME       NULL,
    [IdUsuarioUltModi]      VARCHAR (50)   NULL,
    [Fecha_UltMod]          DATETIME       NULL,
    [IdUsuarioUltAnu]       VARCHAR (50)   NULL,
    [Fecha_UltAnu]          DATETIME       NULL,
    [MotivoAnulacion]       VARCHAR (2000) NULL,
    [nom_pc]                VARCHAR (100)  NULL,
    [ip]                    VARCHAR (50)   NULL,
    CONSTRAINT [PK_ro_parametro_x_pago_variable] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [Id_Tipo_Pago_Variable] ASC)
);

