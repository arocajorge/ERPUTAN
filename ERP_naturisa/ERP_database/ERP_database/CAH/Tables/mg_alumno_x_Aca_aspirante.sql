CREATE TABLE [CAH].[mg_alumno_x_Aca_aspirante] (
    [id_alumno_academico] NUMERIC (18)  NOT NULL,
    [IdInstitucion]       INT           NOT NULL,
    [IdAspirante]         NUMERIC (18)  NOT NULL,
    [nota1]               VARCHAR (850) NULL,
    [nota2]               VARCHAR (850) NULL,
    CONSTRAINT [PK_mg_alumno_x_Aca_aspirante] PRIMARY KEY CLUSTERED ([id_alumno_academico] ASC, [IdInstitucion] ASC, [IdAspirante] ASC)
);

