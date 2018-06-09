CREATE TABLE [dbo].[prd_GrupoTrabajo] (
    [IdEmpresa]           INT           NOT NULL,
    [IdSucursal]          INT           NOT NULL,
    [IdGrupoTrabajo]      INT           NOT NULL,
    [Descripcion]         VARCHAR (150) NOT NULL,
    [FechaCreacion]       DATETIME      NOT NULL,
    [IdLider]             NUMERIC (18)  NOT NULL,
    [IdProcesoProductivo] INT           NOT NULL,
    [IdEtapa]             INT           NOT NULL,
    [Estado]              CHAR (1)      NOT NULL,
    [IdGrupo]             INT           NULL,
    CONSTRAINT [PK_prd_GrupoTrabajo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdGrupoTrabajo] ASC)
);

