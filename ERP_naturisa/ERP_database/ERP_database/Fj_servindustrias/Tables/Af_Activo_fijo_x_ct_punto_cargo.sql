CREATE TABLE [Fj_servindustrias].[Af_Activo_fijo_x_ct_punto_cargo] (
    [IdEmpresa_AF]     INT          NOT NULL,
    [IdActivoFijo_AF]  INT          NOT NULL,
    [IdEmpresa_PC]     INT          NOT NULL,
    [IdPunto_cargo_PC] INT          NOT NULL,
    [observacion]      VARCHAR (50) NULL,
    CONSTRAINT [PK_Af_Activo_fijo_x_ct_punto_cargo] PRIMARY KEY CLUSTERED ([IdEmpresa_PC] ASC, [IdPunto_cargo_PC] ASC)
);

