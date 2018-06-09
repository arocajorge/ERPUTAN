CREATE TABLE [dbo].[ro_participacion_utilidad] (
    [IdEmpresa]                  INT           NOT NULL,
    [IdPeriodo]                  INT           NOT NULL,
    [UtilidadDerechoIndividual]  FLOAT (53)    NOT NULL,
    [UtilidadCargaFamiliar]      FLOAT (53)    NOT NULL,
    [LimiteDistribucionUtilidad] FLOAT (53)    NOT NULL,
    [FechaIngresa]               DATETIME      NOT NULL,
    [UsuarioIngresa]             VARCHAR (25)  NOT NULL,
    [Observacion]                VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_participacion_utilidad] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC)
);

