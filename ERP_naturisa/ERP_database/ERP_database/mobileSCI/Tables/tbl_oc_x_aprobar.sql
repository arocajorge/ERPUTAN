CREATE TABLE [mobileSCI].[tbl_oc_x_aprobar] (
    [IdRow]                  BIGINT         IDENTITY (1, 1) NOT NULL,
    [IdEmpresa]              INT            NOT NULL,
    [IdSucursal]             INT            NOT NULL,
    [IdOrdenCompra]          NUMERIC (18)   NOT NULL,
    [Secuencia]              INT            NOT NULL,
    [IdProducto]             NUMERIC (18)   NOT NULL,
    [IdUnidadMedida]         VARCHAR (25)   NOT NULL,
    [IdProveedor]            NUMERIC (18)   NOT NULL,
    [cant_oc]                FLOAT (53)     NOT NULL,
    [cant_in]                FLOAT (53)     NOT NULL,
    [saldo]                  FLOAT (53)     NOT NULL,
    [pr_descripcion]         NVARCHAR (500) NOT NULL,
    [pr_codigo]              NVARCHAR (40)  NOT NULL,
    [Descripcion]            VARCHAR (500)  NOT NULL,
    [pe_nombreCompleto]      VARCHAR (200)  NOT NULL,
    [oc_fecha]               DATETIME       NOT NULL,
    [oc_observacion]         VARCHAR (1000) NOT NULL,
    [IdUnidadMedida_Consumo] VARCHAR (25)   NOT NULL,
    [NomSucursal]            VARCHAR (1000) NULL,
    CONSTRAINT [PK_tbl_oc_x_aprobar] PRIMARY KEY CLUSTERED ([IdRow] ASC)
);



