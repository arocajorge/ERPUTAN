CREATE TABLE [dbo].[ro_area_x_ro_departamento] (
    [IdEmpresa]      INT NOT NULL,
    [IdDivision]     INT NOT NULL,
    [IdArea]         INT NOT NULL,
    [IdDepartamento] INT NOT NULL,
    CONSTRAINT [PK_ro_area_x_ro_departamento] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDivision] ASC, [IdArea] ASC, [IdDepartamento] ASC)
);

