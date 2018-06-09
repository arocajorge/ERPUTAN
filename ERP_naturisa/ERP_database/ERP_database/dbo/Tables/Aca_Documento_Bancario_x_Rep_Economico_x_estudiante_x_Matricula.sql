CREATE TABLE [dbo].[Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula] (
    [IdInstitucion]         INT           NOT NULL,
    [IdFamiliar]            NUMERIC (18)  NOT NULL,
    [IdParentesco_cat]      VARCHAR (35)  NOT NULL,
    [IdDocumento_Bancario]  INT           NOT NULL,
    [IdEstudiante]          NUMERIC (18)  NOT NULL,
    [IdMatricula]           NUMERIC (18)  NOT NULL,
    [Id_tipo_meca_pago]     INT           NOT NULL,
    [Id_tb_banco_x_mgbanco] INT           NOT NULL,
    [Observacion]           VARCHAR (200) NULL,
    CONSTRAINT [PK_Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula] PRIMARY KEY CLUSTERED ([IdInstitucion] ASC, [IdFamiliar] ASC, [IdParentesco_cat] ASC, [IdDocumento_Bancario] ASC, [IdEstudiante] ASC, [IdMatricula] ASC),
    CONSTRAINT [FK_Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Aca_Documento_Bancario_x_Rep_Economico] FOREIGN KEY ([IdInstitucion], [IdFamiliar], [IdParentesco_cat], [IdDocumento_Bancario]) REFERENCES [dbo].[Aca_Documento_Bancario_x_Rep_Economico] ([IdInstitucion], [IdFamiliar], [IdParentesco_cat], [IdDocumento_Bancario]),
    CONSTRAINT [FK_Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Aca_estudiante] FOREIGN KEY ([IdInstitucion], [IdEstudiante]) REFERENCES [dbo].[Aca_estudiante] ([IdInstitucion], [IdEstudiante]),
    CONSTRAINT [FK_Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Aca_Tipo_Mecanismo_Pago] FOREIGN KEY ([Id_tipo_meca_pago]) REFERENCES [dbo].[Aca_Tipo_Mecanismo_Pago] ([Id_tipo_meca_pago]),
    CONSTRAINT [FK_Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_tb_banco_x_mg_banco] FOREIGN KEY ([Id_tb_banco_x_mgbanco]) REFERENCES [CAH].[tb_banco_x_mg_banco] ([Id_tb_banco_x_mgbanco])
);

