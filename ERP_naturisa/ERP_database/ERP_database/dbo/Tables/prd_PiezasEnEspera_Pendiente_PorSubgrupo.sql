CREATE TABLE [dbo].[prd_PiezasEnEspera_Pendiente_PorSubgrupo] (
    [IdGrupo]                                    INT NOT NULL,
    [IdSubGrupo]                                 INT NOT NULL,
    [IdProcesoProductivo]                        INT NOT NULL,
    [IdEtapa]                                    INT NOT NULL,
    [Cant_Pieza_Pendie_Por_Procesar_PorSubgrupo] INT NULL,
    CONSTRAINT [PK_prd_PiezasEnEspera_Pendiente_PorSubgrupo] PRIMARY KEY CLUSTERED ([IdGrupo] ASC, [IdSubGrupo] ASC, [IdProcesoProductivo] ASC)
);

