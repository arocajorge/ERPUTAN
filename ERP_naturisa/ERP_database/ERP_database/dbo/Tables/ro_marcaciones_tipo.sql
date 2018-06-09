CREATE TABLE [dbo].[ro_marcaciones_tipo] (
    [IdTipoMarcaciones] VARCHAR (20) NOT NULL,
    [ma_descripcion]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ro_marcaciones_tipo] PRIMARY KEY CLUSTERED ([IdTipoMarcaciones] ASC)
);

