CREATE TABLE [dbo].[seg_Menu] (
    [IdMenu]                   INT           NOT NULL,
    [IdMenuPadre]              INT           NULL,
    [DescripcionMenu]          VARCHAR (255) NOT NULL,
    [PosicionMenu]             INT           NOT NULL,
    [Habilitado]               BIT           NOT NULL,
    [Tiene_FormularioAsociado] BIT           NOT NULL,
    [nom_Formulario]           VARCHAR (255) NOT NULL,
    [nom_Asembly]              VARCHAR (200) NOT NULL,
    [imagen_grande]            IMAGE         NULL,
    [imagen_peque]             IMAGE         NULL,
    [icono]                    IMAGE         NULL,
    [nivel]                    INT           NULL,
    CONSTRAINT [PK_seg_Menu] PRIMARY KEY CLUSTERED ([IdMenu] ASC)
);

