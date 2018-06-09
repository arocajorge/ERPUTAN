CREATE TABLE [dbo].[Aca_InstitucionFinanciera] (
    [IdInstitucionFinaciera] INT             NOT NULL,
    [IdTipoCuenta_catalogo]  VARCHAR (35)    NOT NULL,
    [CodigoInstitucion]      VARCHAR (25)    NOT NULL,
    [NombreInstitucion]      VARCHAR (150)   NOT NULL,
    [CodAlterno]             CHAR (3)        NOT NULL,
    [NombreAlterno]          VARCHAR (150)   NOT NULL,
    [Porc_comision]          DECIMAL (18, 2) NOT NULL,
    [Estado]                 CHAR (1)        NOT NULL,
    [FechaCreacion]          DATETIME        NULL,
    [FechaModificacion]      DATETIME        NULL,
    [FechaAnulacion]         DATETIME        NULL,
    [UsuarioCreacion]        VARCHAR (25)    NULL,
    [UsuarioModificacion]    VARCHAR (25)    NULL,
    [UsuarioAnulacion]       VARCHAR (25)    NULL,
    [MotivoAnulacion]        VARCHAR (150)   NULL,
    CONSTRAINT [PK_Aca_InstitucionFinanciera_1] PRIMARY KEY CLUSTERED ([IdInstitucionFinaciera] ASC),
    CONSTRAINT [FK_Aca_InstitucionFinanciera_Aca_Catalogo] FOREIGN KEY ([IdTipoCuenta_catalogo]) REFERENCES [dbo].[Aca_Catalogo] ([IdCatalogo])
);

