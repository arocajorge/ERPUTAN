CREATE TABLE [dbo].[prd_GruposTrabajo_PorPP] (
    [IdProcesoProductivo] INT NOT NULL,
    [IdEtapa]             INT NOT NULL,
    [IdGrupoTrabajo]      INT NOT NULL,
    [IdSubgrupo]          INT NOT NULL,
    CONSTRAINT [PK_prd_GruposTrabajo_PorPP] PRIMARY KEY CLUSTERED ([IdProcesoProductivo] ASC, [IdEtapa] ASC, [IdGrupoTrabajo] ASC, [IdSubgrupo] ASC)
);

