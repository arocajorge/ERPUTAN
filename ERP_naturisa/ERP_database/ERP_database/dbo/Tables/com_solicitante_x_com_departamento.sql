CREATE TABLE [dbo].[com_solicitante_x_com_departamento] (
    [IdEmpresa]      INT          NOT NULL,
    [IdSolicitante]  NUMERIC (18) NOT NULL,
    [Secuencia]      INT          NOT NULL,
    [IdDepartamento] NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_com_solicitante_x_com_departamento] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSolicitante] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_com_solicitante_x_com_departamento_com_departamento] FOREIGN KEY ([IdEmpresa], [IdDepartamento]) REFERENCES [dbo].[com_departamento] ([IdEmpresa], [IdDepartamento]),
    CONSTRAINT [FK_com_solicitante_x_com_departamento_com_solicitante] FOREIGN KEY ([IdEmpresa], [IdSolicitante]) REFERENCES [dbo].[com_solicitante] ([IdEmpresa], [IdSolicitante])
);

