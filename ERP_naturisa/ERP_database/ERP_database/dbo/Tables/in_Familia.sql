CREATE TABLE [dbo].[in_Familia] (
    [IdEmpresa]      INT           NOT NULL,
    [IdFamilia]      INT           NOT NULL,
    [fa_Codigo]      VARCHAR (50)  NULL,
    [fa_Descripcion] VARCHAR (500) NOT NULL,
    [Estado]         BIT           NOT NULL,
    CONSTRAINT [PK_in_Familia] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdFamilia] ASC)
);

