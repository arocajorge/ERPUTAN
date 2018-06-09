CREATE TABLE [dbo].[ro_catalogoTipo] (
    [IdTipoCatalogo] INT           NOT NULL,
    [Codigo]         VARCHAR (10)  NULL,
    [tc_Descripcion] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ro_CatalogoTipo] PRIMARY KEY CLUSTERED ([IdTipoCatalogo] ASC)
);

