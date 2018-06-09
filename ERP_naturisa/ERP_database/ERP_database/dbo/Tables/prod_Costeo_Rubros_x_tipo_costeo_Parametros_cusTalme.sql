CREATE TABLE [dbo].[prod_Costeo_Rubros_x_tipo_costeo_Parametros_cusTalme] (
    [IdEmpresa]     INT          NOT NULL,
    [IdTipo_Costeo] VARCHAR (20) NOT NULL,
    [IdRubroCosteo] VARCHAR (50) NOT NULL,
    [IdCtaCble]     VARCHAR (20) NOT NULL,
    [IdCentroCosto] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_prod_Costeo_Rubros_x_tipo_costeo_Parametros_cusTalme_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Costeo] ASC, [IdRubroCosteo] ASC, [IdCtaCble] ASC, [IdCentroCosto] ASC)
);

