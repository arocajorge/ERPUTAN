CREATE TABLE [mobileSCI].[tbl_bodega] (
    [IdEmpresaSCI] INT          NOT NULL,
    [IdSCI]        NUMERIC (18) NOT NULL,
    [IdEmpresa]    INT          NOT NULL,
    [IdSucursal]   INT          NOT NULL,
    [IdBodega]     INT          NOT NULL,
    CONSTRAINT [PK_tbl_bodega] PRIMARY KEY CLUSTERED ([IdEmpresaSCI] ASC, [IdSCI] ASC),
    CONSTRAINT [FK_tbl_bodega_tb_bodega] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega]) REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega])
);

