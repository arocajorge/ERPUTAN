CREATE TABLE [dbo].[fa_cliente_contactos] (
    [IdEmpresa_cli]  INT           NOT NULL,
    [IdCliente]      NUMERIC (18)  NOT NULL,
    [IdEmpresa_cont] INT           NOT NULL,
    [IdContacto]     NUMERIC (18)  NOT NULL,
    [observacion]    VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_fa_cliente_contactos] PRIMARY KEY CLUSTERED ([IdEmpresa_cli] ASC, [IdCliente] ASC, [IdEmpresa_cont] ASC, [IdContacto] ASC),
    CONSTRAINT [FK_fa_cliente_contactos_fa_cliente] FOREIGN KEY ([IdEmpresa_cli], [IdCliente]) REFERENCES [dbo].[fa_cliente] ([IdEmpresa], [IdCliente]),
    CONSTRAINT [FK_fa_cliente_contactos_tb_contacto] FOREIGN KEY ([IdEmpresa_cont], [IdContacto]) REFERENCES [dbo].[tb_contacto] ([IdEmpresa], [IdContacto])
);

