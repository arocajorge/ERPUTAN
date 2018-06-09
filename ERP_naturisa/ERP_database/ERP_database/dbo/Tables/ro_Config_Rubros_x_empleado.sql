CREATE TABLE [dbo].[ro_Config_Rubros_x_empleado] (
    [IdEmpresa] INT          NOT NULL,
    [IdRubro]   VARCHAR (10) NOT NULL,
    [Estado]    CHAR (1)     NOT NULL,
    [OrdenPres] INT          NOT NULL,
    CONSTRAINT [PK_ro_cong_rubro_tipo_x_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC)
);

