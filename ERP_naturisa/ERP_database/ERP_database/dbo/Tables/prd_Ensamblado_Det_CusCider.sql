CREATE TABLE [dbo].[prd_Ensamblado_Det_CusCider] (
    [IdEmpresa]    INT            NOT NULL,
    [IdSucursal]   INT            NOT NULL,
    [IdEnsamblado] NUMERIC (18)   NOT NULL,
    [Secuencia]    INT            NOT NULL,
    [IdProducto]   NUMERIC (18)   NOT NULL,
    [CodigoBarra]  NVARCHAR (100) NOT NULL,
    [Observacion]  VARCHAR (1000) NULL,
    [en_cantidad]  INT            NOT NULL,
    CONSTRAINT [PK_prd_Ensamblado_Det_CusCider] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdEnsamblado] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_prd_Ensamblado_Det_CusCider_prd_Ensamblado_CusCider] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdEnsamblado]) REFERENCES [dbo].[prd_Ensamblado_CusCider] ([IdEmpresa], [IdSucursal], [IdEnsamblado]),
    CONSTRAINT [FK_prd_Ensamblado_Det_CusCider_prd_Ensamblado_Det_CusCider] FOREIGN KEY ([IdEmpresa], [IdProducto]) REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
);

