CREATE TABLE [dbo].[com_comprador_familia] (
    [IdEmpresa]   INT          NOT NULL,
    [IdComprador] NUMERIC (18) NOT NULL,
    [Secuencia]   INT          NOT NULL,
    [IdFamilia]   INT          NOT NULL,
    CONSTRAINT [PK_com_comprador_familia] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdComprador] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_com_comprador_familia_com_comprador] FOREIGN KEY ([IdEmpresa], [IdComprador]) REFERENCES [dbo].[com_comprador] ([IdEmpresa], [IdComprador]),
    CONSTRAINT [FK_com_comprador_familia_in_Familia] FOREIGN KEY ([IdEmpresa], [IdFamilia]) REFERENCES [dbo].[in_Familia] ([IdEmpresa], [IdFamilia])
);

