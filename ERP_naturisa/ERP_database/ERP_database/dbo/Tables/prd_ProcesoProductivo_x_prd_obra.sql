CREATE TABLE [dbo].[prd_ProcesoProductivo_x_prd_obra] (
    [IdEmpresa_Pr]        INT          NOT NULL,
    [IdProcesoProductivo] INT          NOT NULL,
    [IdEmpresa_obra]      INT          NOT NULL,
    [CodObra]             VARCHAR (20) NOT NULL,
    [dummy]               CHAR (1)     NULL,
    CONSTRAINT [PK_prd_ProcesoProductivo_x_prd_obra] PRIMARY KEY CLUSTERED ([IdEmpresa_Pr] ASC, [IdProcesoProductivo] ASC, [IdEmpresa_obra] ASC, [CodObra] ASC)
);

