CREATE TABLE [dbo].[imp_gastosxImport] (
    [IdGastoImp]    INT           NOT NULL,
    [CodGastoImp]   NCHAR (10)    NULL,
    [ga_decripcion] VARCHAR (100) NULL,
    [ga_estado]     CHAR (1)      NULL,
    CONSTRAINT [PK_imp_Aranceles] PRIMARY KEY CLUSTERED ([IdGastoImp] ASC)
);

