CREATE TABLE [dbo].[ct_EstadoResultadoPorAnio] (
    [IdEmpresa]  INT             NOT NULL,
    [IdCtaCble]  VARCHAR (50)    NOT NULL,
    [Anio]       INT             NOT NULL,
    [pc_cuenta]  VARCHAR (MAX)   NULL,
    [Nivel]      INT             NULL,
    [Naturaleza] VARCHAR (10)    NULL,
    [Grupo]      VARCHAR (10)    NULL,
    [Enero]      NUMERIC (18, 2) NULL,
    [Febrero]    NUMERIC (18, 2) NULL,
    [Marzo]      NUMERIC (18, 2) NULL,
    [Abril]      NUMERIC (18, 2) NULL,
    [Mayo]       NUMERIC (18, 2) NULL,
    [Junio]      NUMERIC (18, 2) NULL,
    [Julio]      NUMERIC (18, 2) NULL,
    [Agosto]     NUMERIC (18, 2) NULL,
    [Septiembre] NUMERIC (18, 2) NULL,
    [Octubre]    NUMERIC (18, 2) NULL,
    [Noviembre]  NUMERIC (18, 2) NULL,
    [Diciembre]  NUMERIC (18, 2) NULL,
    [Total]      NUMERIC (18, 2) NULL,
    CONSTRAINT [PK_ct_EstadoResultadoPorAnio] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCtaCble] ASC, [Anio] ASC)
);

