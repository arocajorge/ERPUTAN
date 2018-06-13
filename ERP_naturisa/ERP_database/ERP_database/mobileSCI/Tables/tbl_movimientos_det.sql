CREATE TABLE [mobileSCI].[tbl_movimientos_det] (
    [IdSincronizacion]               NUMERIC (18) NOT NULL,
    [IdSecuencia]                    INT          NOT NULL,
    [IdEmpresa]                      INT          NOT NULL,
    [IdSucursal]                     INT          NOT NULL,
    [IdBodega]                       INT          NOT NULL,
    [IdProducto]                     NUMERIC (18) NOT NULL,
    [IdUnidadMedida]                 VARCHAR (25) NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NULL,
    [Fecha]                          DATETIME     NOT NULL,
    [cantidad]                       FLOAT (53)   NOT NULL,
    [IdEmpresa_oc]                   INT          NULL,
    [IdSucursal_oc]                  INT          NULL,
    [IdOrdenCompra]                  NUMERIC (18) NULL,
    [secuencia_oc]                   INT          NULL,
    [Aprobado]                       BIT          NOT NULL,
    [Estado]                         VARCHAR (1)  NOT NULL,
    CONSTRAINT [PK_tbl_movimientos_det] PRIMARY KEY CLUSTERED ([IdSincronizacion] ASC, [IdSecuencia] ASC),
    CONSTRAINT [FK_tbl_movimientos_det_tbl_movimientos] FOREIGN KEY ([IdSincronizacion]) REFERENCES [mobileSCI].[tbl_movimientos] ([IdSincronizacion])
);



