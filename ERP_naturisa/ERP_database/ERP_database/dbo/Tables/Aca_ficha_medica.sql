CREATE TABLE [dbo].[Aca_ficha_medica] (
    [IdInstitucion]              INT           NOT NULL,
    [IdEstudiante]               NUMERIC (18)  NOT NULL,
    [Grupo_Sanguineo_cat]        VARCHAR (35)  NOT NULL,
    [Seguro_medico]              VARCHAR (50)  NOT NULL,
    [Medica_contraIndic]         VARCHAR (MAX) NOT NULL,
    [Otras_Indicaciones_medicas] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Aca_ficha_medica] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdEstudiante] ASC),
    CONSTRAINT [FK_Aca_ficha_medica_Aca_Catalogo] FOREIGN KEY ([Grupo_Sanguineo_cat]) REFERENCES [dbo].[Aca_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Aca_ficha_medica_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante])
);

