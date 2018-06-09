CREATE TABLE [dbo].[pre_estadoAprobacion] (
    [CodEstado]   VARCHAR (3)  NOT NULL,
    [Descripcion] VARCHAR (50) NULL,
    CONSTRAINT [PK_pre_estadoAprobacion] PRIMARY KEY CLUSTERED ([CodEstado] ASC)
);

