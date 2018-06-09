CREATE TABLE [dbo].[ro_IdRol] (
    [IdRol]       VARCHAR (10) NOT NULL,
    [iAnio]       INT          NOT NULL,
    [iMes]        INT          NOT NULL,
    [iQuincena]   INT          NULL,
    [iSemana]     INT          NULL,
    [FechaInicio] DATE         NOT NULL,
    [FechaFin]    DATE         NOT NULL,
    [Cerrado]     CHAR (1)     NULL,
    CONSTRAINT [PK_ro_rol] PRIMARY KEY CLUSTERED ([IdRol] ASC)
);

