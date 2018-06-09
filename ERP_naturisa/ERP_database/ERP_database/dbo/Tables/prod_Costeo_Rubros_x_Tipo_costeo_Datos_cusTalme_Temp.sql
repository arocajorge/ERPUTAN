CREATE TABLE [dbo].[prod_Costeo_Rubros_x_Tipo_costeo_Datos_cusTalme_Temp] (
    [IdEmpresa]     INT          NOT NULL,
    [IdTipo_Costeo] VARCHAR (20) NOT NULL,
    [IdRubroCosteo] VARCHAR (50) NOT NULL,
    [dc_valor]      FLOAT (53)   NULL,
    [anio]          INT          NULL,
    [mes]           INT          NULL
);

