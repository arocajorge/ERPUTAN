CREATE TABLE [dbo].[Aca_Anio_Lectivo] (
    [IdInstitucion]       INT           NOT NULL,
    [IdAnioLectivo]       INT           NOT NULL,
    [Descripcion]         VARCHAR (50)  NOT NULL,
    [FechaInicio]         DATE          NOT NULL,
    [FechaFin]            DATE          NOT NULL,
    [Estado]              NCHAR (1)     NULL,
    [UsuarioCreacion]     VARCHAR (25)  NULL,
    [UsuarioModificacion] VARCHAR (25)  NULL,
    [UsuarioAnulacion]    VARCHAR (25)  NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Anio_lectivo_1] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdAnioLectivo] ASC),
    CONSTRAINT [FK_Aca_Anio_Lectivo_Aca_Institucion] FOREIGN KEY ([IdInstitucion]) REFERENCES [dbo].[Aca_Institucion] ([IdInstitucion])
);

