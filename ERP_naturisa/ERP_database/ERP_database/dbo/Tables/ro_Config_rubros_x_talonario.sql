CREATE TABLE [dbo].[ro_Config_rubros_x_talonario] (
    [IdEmpresa] INT          NOT NULL,
    [IdRubro]   VARCHAR (10) NOT NULL,
    [Secuencia] INT          NOT NULL,
    CONSTRAINT [PK_ro_Config_rubros_x_talonario] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC)
);

