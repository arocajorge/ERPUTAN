CREATE TABLE [dbo].[prod_GestionProductivaLaminado_x_paradas_CusTalme] (
    [IdEmpresa]           INT           NOT NULL,
    [IdGestionProductiva] NUMERIC (18)  NOT NULL,
    [IdTipoParada]        VARCHAR (10)  NOT NULL,
    [Secuencia]           INT           NOT NULL,
    [HoraIni]             TIME (7)      NULL,
    [HoraFin]             TIME (7)      NULL,
    [Descripcion]         VARCHAR (150) NULL,
    [causa]               VARCHAR (150) NULL,
    CONSTRAINT [PK_prod_GestionProductivaLaminado_x_paradas_CusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGestionProductiva] ASC, [IdTipoParada] ASC, [Secuencia] ASC)
);

