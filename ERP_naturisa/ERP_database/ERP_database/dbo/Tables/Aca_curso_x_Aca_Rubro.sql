CREATE TABLE [dbo].[Aca_curso_x_Aca_Rubro] (
    [IdCurso]     INT          NOT NULL,
    [IdRubro]     INT          NOT NULL,
    [observacion] VARCHAR (60) NULL,
    [estado]      BIT          NOT NULL,
    CONSTRAINT [PK_Aca_curso_x_Aca_Rubro] PRIMARY KEY CLUSTERED ([IdCurso] ASC, [IdRubro] ASC)
);

