CREATE TABLE [dbo].[ro_Novedad_Subida_Bach] (
    [IdCarga]      INT          NOT NULL,
    [IdEmpresa]    INT          NOT NULL,
    [IdCalendario] VARCHAR (50) NOT NULL,
    [IdRubro]      VARCHAR (50) NOT NULL,
    [Fecha]        DATETIME     NOT NULL,
    [Estado]       VARCHAR (1)  NULL,
    CONSTRAINT [PK_ro_Novedad_Subida_Bach] PRIMARY KEY CLUSTERED ([IdCarga] ASC, [IdEmpresa] ASC, [IdCalendario] ASC, [IdRubro] ASC)
);

