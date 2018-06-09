CREATE TABLE [dbo].[pre_presupuesto_tipoRubro] (
    [IdTipoRubro] VARCHAR (20) NOT NULL,
    [Descripcion] VARCHAR (50) NULL,
    [Tabla]       VARCHAR (50) NULL,
    CONSTRAINT [PK_pre_presupuesto_tipo] PRIMARY KEY CLUSTERED ([IdTipoRubro] ASC)
);

