CREATE TABLE [dbo].[Aca_Familiar_x_Estudiante] (
    [IdInstitucion]                    INT          NOT NULL,
    [IdEstudiante]                     NUMERIC (18) NOT NULL,
    [IdFamiliar]                       NUMERIC (18) NOT NULL,
    [IdParentesco_cat]                 VARCHAR (35) NOT NULL,
    [activo]                           BIT          NOT NULL,
    [esta_autorizado_ret_alum]         BIT          NOT NULL,
    [esta_autorizado_recibir_not_mail] BIT          NOT NULL,
    [Vive_con_el_estudiante]           BIT          NOT NULL,
    [porcentaje_dual]                  INT          NULL,
    [FechaCreacion]                    DATETIME     CONSTRAINT [DF_Aca_Familiar_x_Estudiante_FechaCreacion] DEFAULT (getdate()) NULL,
    [FechaModificacion]                DATETIME     CONSTRAINT [DF_Aca_Familiar_x_Estudiante_FechaModificacion] DEFAULT (getdate()) NULL,
    [UsuarioCreacion]                  VARCHAR (50) NULL,
    [UsuarioModificacion]              VARCHAR (50) NULL,
    CONSTRAINT [PK_Aca_Familiar_x_Estudiante] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdEstudiante] ASC, [IdFamiliar] ASC, [IdParentesco_cat] ASC),
    CONSTRAINT [FK_Aca_Familiar_x_Estudiante_Aca_Catalogo] FOREIGN KEY ([IdParentesco_cat]) REFERENCES [dbo].[Aca_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Aca_Familiar_x_Estudiante_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante]),
    CONSTRAINT [FK_Aca_Familiar_x_Estudiante_Aca_Familiar] FOREIGN KEY ([IdInstitucion], [IdFamiliar]) REFERENCES [dbo].[Aca_Familiar] ([IdInstitucion], [IdFamiliar])
);

