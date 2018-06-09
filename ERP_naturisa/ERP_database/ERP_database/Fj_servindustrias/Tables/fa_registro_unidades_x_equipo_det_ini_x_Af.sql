CREATE TABLE [Fj_servindustrias].[fa_registro_unidades_x_equipo_det_ini_x_Af] (
    [IdEmpresa]           INT          NOT NULL,
    [IdRegistro]          DECIMAL (18) NOT NULL,
    [IdActivoFijo]        INT          NOT NULL,
    [IdUnidadFact_cat]    VARCHAR (50) NULL,
    [Af_ValorUnidad_Actu] FLOAT (53)   NULL,
    CONSTRAINT [PK_fa_registro_unidades_x_equipo_det_ini_x_Af_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRegistro] ASC, [IdActivoFijo] ASC)
);

