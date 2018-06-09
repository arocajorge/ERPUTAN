CREATE TABLE [dbo].[Aca_estudiante_x_Alergia] (
    [IdInstitucion]      INT           NOT NULL,
    [IdEstudiante]       NUMERIC (18)  NOT NULL,
    [IdAlergia_catalogo] VARCHAR (35)  NOT NULL,
    [descripcion]        VARCHAR (550) NOT NULL,
    [activo]             BIT           NOT NULL,
    CONSTRAINT [PK_Aca_estudiante_x_Alergia] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdEstudiante] ASC, [IdAlergia_catalogo] ASC),
    CONSTRAINT [FK_Aca_estudiante_x_Alergia_Aca_Catalogo] FOREIGN KEY ([IdAlergia_catalogo]) REFERENCES [dbo].[Aca_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Aca_estudiante_x_Alergia_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante])
);

