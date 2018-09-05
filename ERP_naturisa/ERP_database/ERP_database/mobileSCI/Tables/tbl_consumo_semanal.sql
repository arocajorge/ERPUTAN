CREATE TABLE [mobileSCI].[tbl_consumo_semanal] (
    [IdEmpresa]                      INT            NOT NULL,
    [IdSucursal]                     INT            NOT NULL,
    [IdBodega]                       INT            NOT NULL,
    [IdProducto]                     NUMERIC (18)   NOT NULL,
    [IdCentroCosto]                  VARCHAR (20)   NOT NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20)   NOT NULL,
    [NomProducto]                    VARCHAR (1000) NOT NULL,
    [NomSubCentro]                   VARCHAR (1000) NOT NULL,
    [LUNES]                          FLOAT (53)     NOT NULL,
    [MARTES]                         FLOAT (53)     NOT NULL,
    [MIERCOLES]                      FLOAT (53)     NOT NULL,
    [JUEVES]                         FLOAT (53)     NOT NULL,
    [VIERNES]                        FLOAT (53)     NOT NULL,
    [SABADO]                         FLOAT (53)     NOT NULL,
    [DOMINGO]                        FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_tbl_consumo_semanal] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdProducto] ASC, [IdCentroCosto] ASC, [IdCentroCosto_sub_centro_costo] ASC)
);

