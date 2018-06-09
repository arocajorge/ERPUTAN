CREATE TABLE [dbo].[prod_Costeo_Rubros_x_Tipo_costeo_cusTalme] (
    [IdEmpresa]           INT           NOT NULL,
    [IdTipo_Costeo]       VARCHAR (20)  NOT NULL,
    [IdRubroCosteo]       VARCHAR (50)  NOT NULL,
    [IdGrupoCosteo]       VARCHAR (20)  NULL,
    [IdRubroCosteo_padre] VARCHAR (20)  NULL,
    [Descripcion]         VARCHAR (200) NULL,
    [posicion]            INT           NULL,
    [ObsrevacionSys]      VARCHAR (50)  NULL,
    CONSTRAINT [PK_prod_costeo_estructura_costeo_cusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Costeo] ASC, [IdRubroCosteo] ASC)
);

