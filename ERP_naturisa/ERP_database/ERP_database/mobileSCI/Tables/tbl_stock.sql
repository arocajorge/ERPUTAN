CREATE TABLE [mobileSCI].[tbl_stock] (
    [IdRow]                  NUMERIC (18)   IDENTITY (1, 1) NOT NULL,
    [IdEmpresa]              INT            NOT NULL,
    [IdSucursal]             INT            NOT NULL,
    [IdBodega]               INT            NOT NULL,
    [IdProducto]             NUMERIC (18)   NOT NULL,
    [CodProducto]            NVARCHAR (40)  NOT NULL,
    [NomProducto]            NVARCHAR (500) NOT NULL,
    [IdUnidadMedida_Consumo] VARCHAR (25)   NOT NULL,
    [Stock]                  FLOAT (53)     NOT NULL,
    [NomUnidadMedida]        VARCHAR (500)  NOT NULL,
    [CodProdProducto]        VARCHAR (50)   NULL,
    [CodProdSubcentro]       VARCHAR (50)   NULL,
    CONSTRAINT [PK_tbl_stock] PRIMARY KEY CLUSTERED ([IdRow] ASC)
);



