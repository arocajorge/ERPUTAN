CREATE TABLE [Edehsa].[in_Categoria_x_Formula] (
    [IdEmpresa]         INT           NOT NULL,
    [IdCategoria]       INT           NOT NULL,
    [descripcion_corta] VARCHAR (10)  NULL,
    [tiene_longitud]    BIT           NULL,
    [tiene_espesor]     BIT           NULL,
    [tiene_ancho]       BIT           NULL,
    [tiene_alto]        BIT           NULL,
    [tiene_ceja]        BIT           NULL,
    [tiene_diametro]    BIT           NULL,
    [densidad]          INT           CONSTRAINT [DF_in_Categoria_x_Formula_densidad] DEFAULT ((7850)) NOT NULL,
    [formula]           VARCHAR (250) NOT NULL,
    [estado]            BIT           NOT NULL,
    CONSTRAINT [PK_in_CategoriaCalculoPeso] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCategoria] ASC)
);

