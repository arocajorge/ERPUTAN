CREATE TABLE [dbo].[in_Producto] (
    [IdEmpresa]               INT             NOT NULL,
    [IdProducto]              NUMERIC (18)    NOT NULL,
    [pr_codigo]               NVARCHAR (40)   NOT NULL,
    [pr_descripcion]          NVARCHAR (500)  NOT NULL,
    [pr_descripcion_2]        NVARCHAR (500)  NULL,
    [IdProductoTipo]          INT             NOT NULL,
    [IdMarca]                 INT             NOT NULL,
    [IdPresentacion]          VARCHAR (25)    NULL,
    [IdCategoria]             VARCHAR (25)    NOT NULL,
    [IdLinea]                 INT             NOT NULL,
    [IdGrupo]                 INT             NOT NULL,
    [IdSubGrupo]              INT             NOT NULL,
    [IdUnidadMedida]          VARCHAR (25)    NOT NULL,
    [IdUnidadMedida_Consumo]  VARCHAR (25)    NOT NULL,
    [IdNaturaleza]            VARCHAR (15)    NULL,
    [IdMotivo_Vta]            INT             NULL,
    [pr_codigo_barra]         NVARCHAR (25)   NOT NULL,
    [pr_observacion]          NVARCHAR (1000) NOT NULL,
    [pr_precio_publico]       FLOAT (53)      NOT NULL,
    [pr_precio_mayor]         FLOAT (53)      NOT NULL,
    [pr_precio_minimo]        FLOAT (53)      NOT NULL,
    [pr_precio_puerta]        FLOAT (53)      NOT NULL,
    [pr_ManejaIva]            CHAR (10)       NOT NULL,
    [pr_ManejaSeries]         CHAR (10)       NOT NULL,
    [pr_costo_fob]            FLOAT (53)      NOT NULL,
    [pr_costo_CIF]            FLOAT (53)      NOT NULL,
    [pr_costo_promedio]       FLOAT (53)      NOT NULL,
    [pr_DiasMaritimo]         INT             NOT NULL,
    [pr_DiasAereo]            INT             NOT NULL,
    [pr_DiasTerrestre]        INT             NOT NULL,
    [pr_largo]                FLOAT (53)      NOT NULL,
    [pr_alto]                 FLOAT (53)      NOT NULL,
    [pr_profundidad]          FLOAT (53)      NOT NULL,
    [pr_peso]                 FLOAT (53)      NOT NULL,
    [pr_imagenPeque]          IMAGE           NULL,
    [pr_imagen_Grande]        IMAGE           NULL,
    [pr_partidaArancel]       VARCHAR (15)    NOT NULL,
    [pr_porcentajeArancel]    MONEY           NOT NULL,
    [pr_Por_descuento]        FLOAT (53)      NOT NULL,
    [pr_stock_maximo]         FLOAT (53)      NOT NULL,
    [pr_stock_minimo]         FLOAT (53)      NOT NULL,
    [IdUsuario]               NVARCHAR (20)   NOT NULL,
    [Fecha_Transac]           DATETIME        NOT NULL,
    [IdUsuarioUltMod]         NVARCHAR (20)   NOT NULL,
    [Fecha_UltMod]            DATETIME        NOT NULL,
    [IdUsuarioUltAnu]         NVARCHAR (20)   NULL,
    [Fecha_UltAnu]            DATETIME        NULL,
    [pr_motivoAnulacion]      NVARCHAR (50)   NULL,
    [nom_pc]                  NVARCHAR (50)   NOT NULL,
    [ip]                      NVARCHAR (25)   NOT NULL,
    [Estado]                  CHAR (1)        NOT NULL,
    [AnchoEspecifico]         FLOAT (53)      NULL,
    [PesoEspecifico]          FLOAT (53)      NULL,
    [ManejaKardex]            CHAR (1)        NULL,
    [IdCod_Impuesto_Iva]      VARCHAR (50)    NOT NULL,
    [IdCod_Impuesto_Ice]      VARCHAR (50)    NOT NULL,
    [Aparece_modu_Ventas]     BIT             NOT NULL,
    [Aparece_modu_Compras]    BIT             NOT NULL,
    [Aparece_modu_Inventario] BIT             NOT NULL,
    [Aparece_modu_Activo_F]   BIT             NOT NULL,
    [mobile_cod_produccion]   VARCHAR (100)   NULL,
    CONSTRAINT [PK_in_Producto] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto] ASC),
    CONSTRAINT [FK_in_Producto_fa_motivo_venta] FOREIGN KEY ([IdEmpresa], [IdMotivo_Vta]) REFERENCES [dbo].[fa_motivo_venta] ([IdEmpresa], [IdMotivo_Vta]),
    CONSTRAINT [FK_in_Producto_in_Marca] FOREIGN KEY ([IdEmpresa], [IdMarca]) REFERENCES [dbo].[in_Marca] ([IdEmpresa], [IdMarca]),
    CONSTRAINT [FK_in_Producto_in_presentacion] FOREIGN KEY ([IdEmpresa], [IdPresentacion]) REFERENCES [dbo].[in_presentacion] ([IdEmpresa], [IdPresentacion]),
    CONSTRAINT [FK_in_Producto_in_ProductoTipo] FOREIGN KEY ([IdEmpresa], [IdProductoTipo]) REFERENCES [dbo].[in_ProductoTipo] ([IdEmpresa], [IdProductoTipo]),
    CONSTRAINT [FK_in_Producto_in_subgrupo] FOREIGN KEY ([IdEmpresa], [IdCategoria], [IdLinea], [IdGrupo], [IdSubGrupo]) REFERENCES [dbo].[in_subgrupo] ([IdEmpresa], [IdCategoria], [IdLinea], [IdGrupo], [IdSubgrupo]),
    CONSTRAINT [FK_in_Producto_in_UnidadMedida] FOREIGN KEY ([IdUnidadMedida]) REFERENCES [dbo].[in_UnidadMedida] ([IdUnidadMedida]),
    CONSTRAINT [FK_in_Producto_in_UnidadMedida1] FOREIGN KEY ([IdUnidadMedida_Consumo]) REFERENCES [dbo].[in_UnidadMedida] ([IdUnidadMedida]),
    CONSTRAINT [FK_in_Producto_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);




GO
create  trigger dbo.trg_In_Producto 
on dbo.in_producto
after INSERT ,UPDATE,DELETE
AS


IF NOT EXISTS (
			SELECT IdTabla 
           FROM dbo.tb_sis_Actualizaciones_x_tablas
           where IdTabla='in_Producto'
          )  
BEGIN  
	INSERT INTO dbo.tb_sis_Actualizaciones_x_tablas
	(IdTabla,ult_fecha_update,ult_proceso)
	VALUES
	('in_Producto',GETDATE(),'insert')
END


UPDATE dbo.tb_sis_Actualizaciones_x_tablas
set ult_fecha_update=GETDATE()
,ult_proceso=''
where IdTabla='in_Producto'