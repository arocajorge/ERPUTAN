CREATE TABLE [dbo].[Aca_Rubro_Tipo] (
    [IdTipoRubro]               INT           NOT NULL,
    [codTipoRubro]              VARCHAR (50)  NOT NULL,
    [descripcion_tipo]          VARCHAR (150) NOT NULL,
    [estado]                    CHAR (1)      NOT NULL,
    [IdRubroComportamiento_cat] VARCHAR (35)  NULL,
    [FechaModificacion]         DATETIME      NULL,
    [FechaCreacion]             DATETIME      NULL,
    [UsuarioModificacion]       VARCHAR (50)  NULL,
    [UsuarioCreacion]           VARCHAR (50)  NULL,
    [FechaAnulacion]            DATETIME      NULL,
    [UsuarioAnulacion]          VARCHAR (50)  NULL,
    [MotivoAnulacion]           VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Rubro_Tipo] PRIMARY KEY CLUSTERED ([IdTipoRubro] ASC),
    CONSTRAINT [FK_Aca_Rubro_Tipo_Aca_Catalogo] FOREIGN KEY ([IdRubroComportamiento_cat]) REFERENCES [dbo].[Aca_Catalogo] ([IdCatalogo])
);

