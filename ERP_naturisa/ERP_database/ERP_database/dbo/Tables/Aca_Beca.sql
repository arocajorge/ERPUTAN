CREATE TABLE [dbo].[Aca_Beca] (
    [IdInstitucion]    INT           NOT NULL,
    [IdBeca]           INT           NOT NULL,
    [IdRubro]          INT           NULL,
    [nom_beca]         VARCHAR (150) NOT NULL,
    [porcentaje]       FLOAT (53)    NOT NULL,
    [estado]           CHAR (1)      NOT NULL,
    [FechaAnulacion]   DATETIME      NULL,
    [MotivoAnulacion]  VARCHAR (150) NULL,
    [UsuarioAnulacion] VARCHAR (50)  NULL,
    [Fecha_Transac]    DATETIME      NULL,
    [Fecha_UltMod]     DATETIME      NULL,
    [IdUsuarioUltMod]  VARCHAR (50)  NULL,
    CONSTRAINT [PK_Aca_Beca] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdBeca] ASC),
    CONSTRAINT [FK_Aca_Beca_Aca_Institucion] FOREIGN KEY ([IdInstitucion]) REFERENCES [dbo].[Aca_Institucion] ([IdInstitucion])
);

