CREATE TABLE [dbo].[imp_Tipo_docu_pago_x_Empresa_x_tipocbte] (
    [IdEmpresa]       INT          NOT NULL,
    [CodDocu_Pago]    VARCHAR (10) NOT NULL,
    [IdTipoCbte]      INT          NULL,
    [IdTipoCbte_Anul] INT          NULL,
    CONSTRAINT [PK_imp_Tipo_docu_pago_x_Empresa_x_tipocbte] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [CodDocu_Pago] ASC),
    CONSTRAINT [FK_imp_Tipo_docu_pago_x_Empresa_x_tipocbte_ct_cbtecble_tipo] FOREIGN KEY ([IdEmpresa], [IdTipoCbte]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Tipo_docu_pago_x_Empresa_x_tipocbte_ct_cbtecble_tipo1] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_Anul]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_Tipo_docu_pago_x_Empresa_x_tipocbte_imp_Tipo_docu_pago] FOREIGN KEY ([CodDocu_Pago]) REFERENCES [dbo].[imp_Tipo_docu_pago] ([CodDocu_Pago])
);

