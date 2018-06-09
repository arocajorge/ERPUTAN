CREATE TABLE [dbo].[prd_GruposTrabajo] (
    [IdEmpresa]      INT           NOT NULL,
    [IdSucursal]     INT           NOT NULL,
    [IdGrupoTrabajo] INT           NOT NULL,
    [Descripcion]    VARCHAR (100) NOT NULL,
    [AreaProduccion] VARCHAR (100) NOT NULL,
    [Fecha]          DATE          NOT NULL,
    [Usuario]        VARCHAR (100) NOT NULL,
    [Estado]         VARCHAR (1)   NOT NULL,
    CONSTRAINT [PK_prd_GruposTrabajo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdGrupoTrabajo] ASC)
);

