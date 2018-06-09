CREATE TABLE [dbo].[in_movi_inve_detalle_x_Producto_CusCider] (
    [IdEmpresa]                        INT             NOT NULL,
    [IdSucursal]                       INT             NOT NULL,
    [IdBodega]                         INT             NOT NULL,
    [IdMovi_inven_tipo]                INT             NOT NULL,
    [IdNumMovi]                        NUMERIC (18)    NOT NULL,
    [mv_Secuencia]                     INT             NOT NULL,
    [Secuencia]                        INT             NOT NULL,
    [IdProducto]                       NUMERIC (10)    NOT NULL,
    [secmax]                           NUMERIC (18)    IDENTITY (1, 1) NOT NULL,
    [CodigoBarra]                      NVARCHAR (100)  NOT NULL,
    [mv_tipo_movi]                     NVARCHAR (1)    NOT NULL,
    [dm_cantidad]                      FLOAT (53)      NOT NULL,
    [dm_observacion]                   NVARCHAR (1000) NOT NULL,
    [dm_precio]                        FLOAT (53)      NOT NULL,
    [mv_costo]                         FLOAT (53)      NOT NULL,
    [et_IdEmpresa]                     INT             NULL,
    [et_IdProcesoProductivo]           INT             NULL,
    [et_IdEtapa]                       INT             NULL,
    [ot_IdEmpresa]                     INT             NULL,
    [ot_IdSucursal]                    INT             NULL,
    [ot_CodObra]                       VARCHAR (20)    NULL,
    [ot_IdOrdenTaller]                 NUMERIC (18)    NULL,
    [CodObra_preasignada]              VARCHAR (20)    NULL,
    [IdOrdenTaller_preasignada]        NUMERIC (18)    NULL,
    [Alto]                             FLOAT (53)      NULL,
    [Largo]                            FLOAT (53)      NULL,
    [Ancho]                            FLOAT (53)      NULL,
    [ocd_IdOrdenCompra]                NUMERIC (18)    NULL,
    [NumDocumentoRelacionadoProveedor] VARCHAR (25)    NULL,
    [NumFacturaProveedor]              VARCHAR (25)    NULL,
    CONSTRAINT [PK_in_movi_inve_detalle_x_Producto_CusCider] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [mv_Secuencia] ASC, [Secuencia] ASC, [IdProducto] ASC)
);


GO
CREATE NONCLUSTERED INDEX [Cl_ocd_IdOrdenCompra]
    ON [dbo].[in_movi_inve_detalle_x_Producto_CusCider]([ocd_IdOrdenCompra] ASC);

