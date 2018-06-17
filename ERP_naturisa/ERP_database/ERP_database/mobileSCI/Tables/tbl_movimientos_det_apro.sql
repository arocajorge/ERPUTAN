CREATE TABLE [mobileSCI].[tbl_movimientos_det_apro] (
    [IdAprobacion]      NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [IdSincronizacion]  NUMERIC (18) NOT NULL,
    [IdSecuencia]       INT          NOT NULL,
    [IdEmpresa]         INT          NOT NULL,
    [IdSucursal]        INT          NOT NULL,
    [IdMovi_inven_tipo] INT          NOT NULL,
    [IdNumMovi]         NUMERIC (18) NOT NULL,
    [Secuencia]         INT          NOT NULL,
    CONSTRAINT [PK_tbl_movimientos_det_apro_1] PRIMARY KEY CLUSTERED ([IdAprobacion] ASC),
    CONSTRAINT [FK_tbl_movimientos_det_apro_tbl_movimientos_det] FOREIGN KEY ([IdSincronizacion], [IdSecuencia]) REFERENCES [mobileSCI].[tbl_movimientos_det] ([IdSincronizacion], [IdSecuencia])
);

