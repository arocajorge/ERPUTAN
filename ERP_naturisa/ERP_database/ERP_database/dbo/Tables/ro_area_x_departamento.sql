CREATE TABLE [dbo].[ro_area_x_departamento] (
    [IdEmpresa]      INT NOT NULL,
    [IdDivision]     INT NOT NULL,
    [IdArea]         INT NOT NULL,
    [IdDepartamento] INT NOT NULL,
    CONSTRAINT [PK_ro_area_x_departamento] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDivision] ASC, [IdArea] ASC, [IdDepartamento] ASC),
    CONSTRAINT [FK_ro_area_x_departamento_ro_area] FOREIGN KEY ([IdEmpresa], [IdDivision], [IdArea]) REFERENCES [dbo].[ro_area] ([IdEmpresa], [IdDivision], [IdArea])
);

