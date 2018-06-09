CREATE TABLE [dbo].[ro_empresa_x_rubro] (
    [IdEmpresa] INT          NOT NULL,
    [IdRubro]   VARCHAR (10) NOT NULL,
    [Valor]     FLOAT (53)   NULL,
    CONSTRAINT [PK_ro_Config_Rubros_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC)
);

