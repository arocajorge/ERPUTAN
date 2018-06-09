CREATE TABLE [Fj_servindustrias].[ro_parametros_reporte] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdNomina_tipo_Liq] INT           NOT NULL,
    [IdRubro]           VARCHAR (50)  NOT NULL,
    [Orden]             INT           NOT NULL,
    [Id_Catalogo]       VARCHAR (10)  NOT NULL,
    [Descripcion]       VARCHAR (200) NULL,
    [Id_catalogo_repor] VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_ro_parametros_reporte_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdNomina_tipo_Liq] ASC, [IdRubro] ASC, [Orden] ASC)
);

