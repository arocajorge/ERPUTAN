CREATE TABLE [CAH].[Aca_Familiar_x_Estudiante_x_fa_cliente_Auditoria] (
    [IdInstitucion_fa]    INT          NOT NULL,
    [IdFamiliar_fa]       NUMERIC (18) NOT NULL,
    [IdParentesco_cat_fa] VARCHAR (35) NOT NULL,
    [IdEmpresa_cli]       INT          NOT NULL,
    [IdCliente_cli]       NUMERIC (18) NOT NULL,
    [observacion]         VARCHAR (50) NULL
);

