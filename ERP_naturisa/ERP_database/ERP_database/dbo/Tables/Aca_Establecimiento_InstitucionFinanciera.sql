CREATE TABLE [dbo].[Aca_Establecimiento_InstitucionFinanciera] (
    [IdIntitucionFinanciera] INT           NOT NULL,
    [IdCodigoFee_catalogo]   VARCHAR (35)  NOT NULL,
    [Numero_establecimiento] VARCHAR (25)  NOT NULL,
    [Estado]                 CHAR (1)      NOT NULL,
    [FechaCreacion]          DATETIME      NULL,
    [FechaModificacion]      DATETIME      NULL,
    [FechaAnulacion]         DATETIME      NULL,
    [UsuarioCreacion]        VARCHAR (25)  NULL,
    [UsuarioModificacion]    VARCHAR (25)  NULL,
    [UsuarioAnulacion]       VARCHAR (25)  NULL,
    [MotivoAnulacion]        VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Establecimiento_InstitucionFinanciera] PRIMARY KEY CLUSTERED ([IdIntitucionFinanciera] ASC, [IdCodigoFee_catalogo] ASC)
);

