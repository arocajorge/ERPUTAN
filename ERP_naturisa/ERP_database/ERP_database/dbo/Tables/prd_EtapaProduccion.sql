CREATE TABLE [dbo].[prd_EtapaProduccion] (
    [IdEmpresa]           INT           NOT NULL,
    [IdProcesoProductivo] INT           NOT NULL,
    [IdEtapa]             INT           NOT NULL,
    [NombreEtapa]         VARCHAR (100) NOT NULL,
    [PorcentajeEtapa]     FLOAT (53)    NOT NULL,
    [Posicion]            INT           NOT NULL,
    CONSTRAINT [PK_prd_EtapaProduccion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProcesoProductivo] ASC, [IdEtapa] ASC)
);

