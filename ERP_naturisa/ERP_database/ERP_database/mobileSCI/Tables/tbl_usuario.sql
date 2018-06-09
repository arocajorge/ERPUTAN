CREATE TABLE [mobileSCI].[tbl_usuario] (
    [IdUsuarioSCI] VARCHAR (50)  NOT NULL,
    [clave]        VARCHAR (200) NOT NULL,
    [nom_usuario]  VARCHAR (300) NULL,
    [estado]       BIT           NOT NULL,
    CONSTRAINT [PK_tbl_usuario] PRIMARY KEY CLUSTERED ([IdUsuarioSCI] ASC)
);

