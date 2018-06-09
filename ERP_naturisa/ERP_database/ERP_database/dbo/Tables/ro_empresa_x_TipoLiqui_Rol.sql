CREATE TABLE [dbo].[ro_empresa_x_TipoLiqui_Rol] (
    [IdEmpresa]       INT          NOT NULL,
    [IdTipoLiqui_Rol] VARCHAR (10) NOT NULL,
    [Secuencia]       INT          NOT NULL,
    [PorcSueldo]      FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_empresa_x_TipoLiqui_Rol_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdTipoLiqui_Rol] ASC, [Secuencia] ASC)
);

