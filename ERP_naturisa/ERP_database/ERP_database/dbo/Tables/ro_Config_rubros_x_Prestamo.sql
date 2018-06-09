CREATE TABLE [dbo].[ro_Config_rubros_x_Prestamo] (
    [IdEmpresa] INT          NOT NULL,
    [IdRubro]   VARCHAR (50) NOT NULL,
    [orden]     INT          NULL,
    CONSTRAINT [PK_ro_Config_rubros_x_Prestamo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC)
);

