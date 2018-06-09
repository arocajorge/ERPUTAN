CREATE TABLE [dbo].[prd_ProcesoProductivo] (
    [IdEmpresa]           INT           NOT NULL,
    [IdProcesoProductivo] INT           NOT NULL,
    [Nombre]              VARCHAR (100) NOT NULL,
    [Estado]              CHAR (1)      NOT NULL,
    CONSTRAINT [PK_prd_ProcesoProductivo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProcesoProductivo] ASC)
);

