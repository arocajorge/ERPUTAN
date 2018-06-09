CREATE TABLE [CAH].[Aca_matricula_x_mg_matricula] (
    [IdInstitucion]    INT           NOT NULL,
    [IdSede]           INT           NOT NULL,
    [IdMatricula]      NUMERIC (18)  NOT NULL,
    [id_matricula_aca] NUMERIC (18)  NOT NULL,
    [nota1]            VARCHAR (500) NULL,
    CONSTRAINT [PK_mg_matricula_x_Aca_matricula] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdSede] ASC, [IdMatricula] ASC, [id_matricula_aca] ASC),
    CONSTRAINT [FK_mg_Aca_matricula_x_matricula_Aca_matricula] FOREIGN KEY ([IdInstitucion], [IdSede], [IdMatricula]) REFERENCES [dbo].[Aca_matricula] ([IdInstitucion], [IdSede], [IdMatricula])
);

