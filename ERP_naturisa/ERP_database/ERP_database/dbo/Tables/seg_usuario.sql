CREATE TABLE [dbo].[seg_usuario] (
    [IdUsuario]                   VARCHAR (50)  NOT NULL,
    [Contrasena]                  VARCHAR (MAX) NULL,
    [estado]                      NVARCHAR (1)  NULL,
    [Fecha_Transaccion]           DATETIME      NULL,
    [IdUsuarioUltModi]            VARCHAR (20)  NULL,
    [Fecha_UltMod]                DATETIME      NULL,
    [IdUsuarioUltAnu]             VARCHAR (20)  NULL,
    [Fecha_UltAnu]                DATETIME      NULL,
    [MotivoAnulacion]             VARCHAR (100) NULL,
    [Nombre]                      VARCHAR (50)  NULL,
    [ExigirDirectivaContrasenia]  BIT           NULL,
    [CambiarContraseniaSgtSesion] BIT           NULL,
    CONSTRAINT [PK_seg_usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

