CREATE TABLE [dbo].[prod_Costeo_Rubros_Grupos] (
    [IdEmpresa]     INT           NOT NULL,
    [IdGrupoCosteo] VARCHAR (20)  NOT NULL,
    [Descripcion]   VARCHAR (150) NOT NULL,
    [Posicion]      INT           NOT NULL,
    CONSTRAINT [PK_prod_Costeo_Rubros_Grupos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGrupoCosteo] ASC)
);

