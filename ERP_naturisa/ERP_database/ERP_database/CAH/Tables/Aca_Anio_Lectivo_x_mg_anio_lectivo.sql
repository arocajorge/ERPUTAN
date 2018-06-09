CREATE TABLE [CAH].[Aca_Anio_Lectivo_x_mg_anio_lectivo] (
    [IdInstitucion]       INT           NOT NULL,
    [IdAnioLectivo]       INT           NOT NULL,
    [id_anio_lectivo_aca] NUMERIC (18)  NOT NULL,
    [nota1]               VARCHAR (250) NULL,
    CONSTRAINT [PK_Aca_Anio_Lectivo_x_mg_anio_lectivo] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdAnioLectivo] ASC, [id_anio_lectivo_aca] ASC),
    CONSTRAINT [FK_Aca_Anio_Lectivo_x_mg_anio_lectivo_Aca_Anio_Lectivo] FOREIGN KEY ([IdInstitucion], [IdAnioLectivo]) REFERENCES [dbo].[Aca_Anio_Lectivo] ([IdInstitucion], [IdAnioLectivo])
);

