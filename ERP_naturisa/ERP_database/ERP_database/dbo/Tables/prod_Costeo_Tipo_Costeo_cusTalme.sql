CREATE TABLE [dbo].[prod_Costeo_Tipo_Costeo_cusTalme] (
    [IdEmpresa]     INT           NOT NULL,
    [IdTipo_Costeo] VARCHAR (20)  NOT NULL,
    [Descripcion]   VARCHAR (150) NOT NULL,
    [IdModeloProd]  INT           NULL,
    CONSTRAINT [PK_prod_Procesos_Costeo_cusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipo_Costeo] ASC)
);

