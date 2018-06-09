CREATE TABLE [dbo].[Aca_Familiar_x_Estudiante_x_fa_cliente] (
    [IdInstitucion_fa]    INT          NOT NULL,
    [IdFamiliar_fa]       NUMERIC (18) NOT NULL,
    [IdParentesco_cat_fa] VARCHAR (35) NOT NULL,
    [IdEmpresa_cli]       INT          NOT NULL,
    [IdCliente_cli]       NUMERIC (18) NOT NULL,
    [observacion]         VARCHAR (50) NULL,
    CONSTRAINT [PK_Aca_Familiar_x_Estudiante_x_fa_cliente] PRIMARY KEY CLUSTERED ([IdInstitucion_fa] ASC, [IdFamiliar_fa] ASC, [IdParentesco_cat_fa] ASC, [IdEmpresa_cli] ASC, [IdCliente_cli] ASC)
);

