CREATE TABLE [mobileSCI].[tbl_usuario_x_bodega] (
    [IdUsuarioSCI] VARCHAR (50) NOT NULL,
    [IdSCI]        NUMERIC (18) NOT NULL,
    [IdEmpresa]    INT          NOT NULL,
    [IdSucursal]   INT          NOT NULL,
    [IdBodega]     INT          NOT NULL,
    CONSTRAINT [PK_tbl_usuario_x_bodega] PRIMARY KEY CLUSTERED ([IdUsuarioSCI] ASC, [IdSCI] ASC),
    CONSTRAINT [FK_tbl_usuario_x_bodega_tb_bodega] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega]) REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega]),
    CONSTRAINT [FK_tbl_usuario_x_bodega_tbl_usuario] FOREIGN KEY ([IdUsuarioSCI]) REFERENCES [mobileSCI].[tbl_usuario] ([IdUsuarioSCI])
);

