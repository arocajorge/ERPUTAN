CREATE TABLE [dbo].[ro_parametro_Egreso_Ingreso_x_implementos] (
    [IdEmpresa]          INT NOT NULL,
    [IdSucursal]         INT NOT NULL,
    [IdBodega]           INT NOT NULL,
    [IdTipo_mov_Ingreso] INT NOT NULL,
    [IdTipo_mov_Egreso]  INT NOT NULL,
    CONSTRAINT [PK_ro_parametro_Egreso_Ingreso_x_implementos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC)
);

