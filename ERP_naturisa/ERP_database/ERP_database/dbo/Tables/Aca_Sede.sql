CREATE TABLE [dbo].[Aca_Sede] (
    [IdSede]              INT           NOT NULL,
    [IdInstitucion]       INT           NOT NULL,
    [IdEmpresa]           INT           NULL,
    [IdSucursal]          INT           NULL,
    [CodSede]             VARCHAR (25)  NOT NULL,
    [CodAlterno]          VARCHAR (25)  NOT NULL,
    [Descripcion_sede]    VARCHAR (50)  NOT NULL,
    [estado]              NCHAR (1)     NOT NULL,
    [FechaCreacion]       DATETIME      NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [FechaModificacion]   DATETIME      NULL,
    [UsuarioCreacion]     VARCHAR (25)  NULL,
    [UsuarioModificacion] VARCHAR (25)  NULL,
    [UsuarioAnulacion]    VARCHAR (25)  NULL,
    [MotivoAnulacion]     VARCHAR (150) NULL,
    CONSTRAINT [PK_Aca_Sede] PRIMARY KEY CLUSTERED ([IdSede] ASC),
    CONSTRAINT [FK_Aca_Sede_Aca_Institucion] FOREIGN KEY ([IdInstitucion]) REFERENCES [dbo].[Aca_Institucion] ([IdInstitucion]),
    CONSTRAINT [FK_Aca_Sede_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);

