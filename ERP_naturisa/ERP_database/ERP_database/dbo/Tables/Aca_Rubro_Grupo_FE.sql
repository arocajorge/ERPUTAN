CREATE TABLE [dbo].[Aca_Rubro_Grupo_FE] (
    [IdInstitucion]       INT           NOT NULL,
    [IdGrupoFE]           INT           NOT NULL,
    [CodGrupoFE]          VARCHAR (50)  NOT NULL,
    [nom_GrupoFe]         VARCHAR (100) NOT NULL,
    [estado]              CHAR (1)      NOT NULL,
    [FechaModificacion]   DATETIME      NULL,
    [FechaCreacion]       DATETIME      NULL,
    [UsuarioModificacion] VARCHAR (50)  NULL,
    [UsuarioCreacion]     VARCHAR (50)  NULL,
    [FechaAnulacion]      DATETIME      NULL,
    [UsuarioAnulacion]    VARCHAR (50)  NULL,
    [MotivoAnulacion]     VARCHAR (50)  NULL,
    CONSTRAINT [PK_Aca_Rubro_Grupo_FE] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdGrupoFE] ASC)
);

