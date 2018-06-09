CREATE TABLE [dbo].[ro_marcaciones_Equipo_x_TipoMarcacion] (
    [IdEquipoMar]                  INT          NOT NULL,
    [IdTipoMarcaciones_sys]        VARCHAR (20) NOT NULL,
    [IdTipoMarcaciones_Biometrico] VARCHAR (20) NULL,
    CONSTRAINT [PK_ro_TipoMarcacion_x_Equipo_Bio] PRIMARY KEY CLUSTERED ([IdEquipoMar] ASC, [IdTipoMarcaciones_sys] ASC),
    CONSTRAINT [FK_ro_marcaciones_Equipo_x_TipoMarcacion_ro_marcaciones_tipo] FOREIGN KEY ([IdTipoMarcaciones_sys]) REFERENCES [dbo].[ro_marcaciones_tipo] ([IdTipoMarcaciones])
);

