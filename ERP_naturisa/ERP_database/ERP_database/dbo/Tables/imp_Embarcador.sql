CREATE TABLE [dbo].[imp_Embarcador] (
    [IdEmpresa]      INT           NOT NULL,
    [IdEmbarcador]   INT           NOT NULL,
    [em_descripcion] CHAR (100)    NOT NULL,
    [em_direccion]   CHAR (800)    NOT NULL,
    [em_telefono]    NVARCHAR (50) NOT NULL,
    [em_contacto]    VARCHAR (35)  NOT NULL,
    [em_email]       VARCHAR (35)  NOT NULL,
    [Estado]         CHAR (1)      NOT NULL,
    CONSTRAINT [PK_imp_Embarcador] PRIMARY KEY CLUSTERED ([IdEmbarcador] ASC, [IdEmpresa] ASC)
);

