CREATE TABLE [dbo].[prod_LiquidacionChatarraDetalle] (
    [IdEmpresa]           INT          NOT NULL,
    [IdLiquidacion]       NUMERIC (18) NOT NULL,
    [Secuencia]           INT          NOT NULL,
    [LLeno]               FLOAT (53)   NULL,
    [Vacio]               FLOAT (53)   NULL,
    [Merma]               FLOAT (53)   NULL,
    [Neta]                FLOAT (53)   NULL,
    [fecha_pesaje_lleno]  DATETIME     NULL,
    [fecha_pesaje_vacion] DATETIME     NULL,
    [Placa]               VARCHAR (10) NULL,
    CONSTRAINT [PK_prod_LiquidacionChatarraDetalle] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC, [Secuencia] ASC)
);

