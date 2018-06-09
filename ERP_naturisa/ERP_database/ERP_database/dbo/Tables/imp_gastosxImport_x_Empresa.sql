CREATE TABLE [dbo].[imp_gastosxImport_x_Empresa] (
    [IdEmpresa]         INT          NOT NULL,
    [IdGastoImp]        INT          NOT NULL,
    [IdCtaCble]         VARCHAR (20) NULL,
    [debcre_DebBanco]   CHAR (1)     NULL,
    [debCre_Provicion]  CHAR (1)     NULL,
    [AfectaLiquidacion] VARCHAR (2)  NULL,
    CONSTRAINT [PK_imp_gastosxImport_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGastoImp] ASC),
    CONSTRAINT [FK_imp_gastosxImport_x_Empresa_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_imp_gastosxImport_x_Empresa_imp_gastosxImport] FOREIGN KEY ([IdGastoImp]) REFERENCES [dbo].[imp_gastosxImport] ([IdGastoImp]),
    CONSTRAINT [FK_imp_gastosxImport_x_Empresa_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

