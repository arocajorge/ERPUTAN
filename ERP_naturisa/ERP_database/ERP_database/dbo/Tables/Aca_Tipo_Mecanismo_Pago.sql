CREATE TABLE [dbo].[Aca_Tipo_Mecanismo_Pago] (
    [Id_tipo_meca_pago]       INT            NOT NULL,
    [Id_tb_banco_x_mgbanco]   INT            NOT NULL,
    [idProceso_Bancario_Tipo] VARCHAR (25)   NULL,
    [Nombre]                  NVARCHAR (250) NULL,
    [Estado]                  CHAR (10)      NULL,
    [Tipo_cuenta]             NVARCHAR (50)  NULL,
    [Forma_pago]              NVARCHAR (50)  NULL,
    [Codigo]                  NVARCHAR (50)  NULL,
    [IdUsuarioCreacion]       VARCHAR (50)   NULL,
    [FechaCreacion]           DATETIME       NULL,
    [IdUsuarioModificacion]   VARCHAR (50)   NULL,
    [FechaModificacion]       DATETIME       NULL,
    [Nom_pc]                  VARCHAR (50)   NULL,
    [ip]                      VARCHAR (50)   NULL,
    [IdUsuario_Responsable]   NVARCHAR (50)  NULL,
    [IdUsuarioAnulacion]      VARCHAR (50)   NULL,
    [FechaAnulacion]          DATETIME       NULL,
    [MotivoAnulacion]         VARCHAR (300)  NULL,
    CONSTRAINT [PK_Aca_Tipo_Mecanismo_Pago] PRIMARY KEY CLUSTERED ([Id_tipo_meca_pago] ASC),
    CONSTRAINT [FK_Aca_Tipo_Mecanismo_Pago_Aca_Tipo_Mecanismo_Pago] FOREIGN KEY ([Id_tb_banco_x_mgbanco]) REFERENCES [CAH].[tb_banco_x_mg_banco] ([Id_tb_banco_x_mgbanco])
);

