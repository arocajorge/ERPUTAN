CREATE TABLE [Edehsa].[com_ListadoDisenoTipo] (
    [IdEmpresa]           INT          NOT NULL,
    [IdTipoListadoDiseno] INT          NOT NULL,
    [TipoListadoDiseno]   VARCHAR (20) NOT NULL,
    [Estado]              CHAR (1)     NOT NULL,
    CONSTRAINT [PK_com_ListadoDisenoTipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoListadoDiseno] ASC)
);

