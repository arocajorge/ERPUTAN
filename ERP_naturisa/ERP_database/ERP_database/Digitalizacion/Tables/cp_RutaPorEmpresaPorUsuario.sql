CREATE TABLE [Digitalizacion].[cp_RutaPorEmpresaPorUsuario] (
    [IdEmpresa] INT           NOT NULL,
    [IdUsuario] VARCHAR (50)  NOT NULL,
    [RutaXML]   VARCHAR (MAX) NULL,
    CONSTRAINT [PK_cp_RutaPorEmpresaPorUsuario] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdUsuario] ASC)
);

