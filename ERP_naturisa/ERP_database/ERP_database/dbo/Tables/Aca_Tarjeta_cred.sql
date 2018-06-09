CREATE TABLE [dbo].[Aca_Tarjeta_cred] (
    [IdTarjeta]           INT           NOT NULL,
    [CodTarjeta]          VARCHAR (20)  NOT NULL,
    [nom_tarjeta]         VARCHAR (50)  NOT NULL,
    [estado]              NCHAR (10)    NOT NULL,
    [porc_comision]       FLOAT (53)    NOT NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [MotivoAnulacion]     VARCHAR (100) NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    CONSTRAINT [PK_Aca_Tarjeta_cred] PRIMARY KEY CLUSTERED ([IdTarjeta] ASC)
);

