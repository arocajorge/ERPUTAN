CREATE TABLE [dbo].[prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme] (
    [IdEmpresa]        INT          NOT NULL,
    [IdTipo_Costeo]    VARCHAR (20) NOT NULL,
    [IdRubroCosteo]    VARCHAR (50) NOT NULL,
    [Anio]             INT          NOT NULL,
    [mes]              INT          NOT NULL,
    [ValorParcial_Mes] FLOAT (53)   NOT NULL,
    [Valorkilos_Mes]   FLOAT (53)   NOT NULL,
    [ValorDolares_Mes] FLOAT (53)   NOT NULL,
    [ValorParcial_Acu] FLOAT (53)   NOT NULL,
    [Valorkilos_Acu]   FLOAT (53)   NOT NULL,
    [ValorDolares_Acu] FLOAT (53)   NOT NULL,
    [CostoUnitario]    FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Costeo] ASC, [IdRubroCosteo] ASC, [Anio] ASC, [mes] ASC)
);

