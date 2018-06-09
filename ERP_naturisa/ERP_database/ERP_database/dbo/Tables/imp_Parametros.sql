CREATE TABLE [dbo].[imp_Parametros] (
    [IdEmpresa]                         INT          NOT NULL,
    [IdTipoCbte_DiarioFob]              INT          NULL,
    [IdTipoCbte_DiarioLiquidacion]      INT          NULL,
    [IdTipoCbte_DiarioFob_Anul]         INT          NULL,
    [IdTipoCbte_DiarioLiquidacion_Anul] INT          NULL,
    [IdCtaCble_para_Importaciones]      VARCHAR (20) NULL,
    [IdMovi_Inve_Tipo_Importacion]      INT          NULL,
    CONSTRAINT [PK_imp_Parametros] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_imp_Parametros_ct_cbtecble_tipo] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_DiarioFob]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Parametros_ct_cbtecble_tipo1] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_DiarioLiquidacion]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Parametros_ct_cbtecble_tipo2] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_DiarioFob_Anul]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Parametros_ct_cbtecble_tipo3] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_DiarioLiquidacion_Anul]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Parametros_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble_para_Importaciones]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_imp_Parametros_in_movi_inven_tipo] FOREIGN KEY ([IdEmpresa], [IdMovi_Inve_Tipo_Importacion]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_imp_Parametros_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

