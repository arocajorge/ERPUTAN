CREATE TABLE [dbo].[prod_Clave_Autorizacion] (
    [IdEmpresa]           INT           NOT NULL,
    [IdGeneracion]        DECIMAL (18)  NOT NULL,
    [Secuencia]           INT           NOT NULL,
    [IdModeloProduccion]  INT           NULL,
    [Clave]               NVARCHAR (50) NULL,
    [IdUsuarioUsoDeClave] VARCHAR (50)  NULL,
    [FechaUsoDeClave]     DATETIME      NULL,
    [IdUsuarioGeneracion] VARCHAR (50)  NULL,
    [FechaGeneracion]     DATETIME      NULL,
    [IdTransaccion]       DECIMAL (18)  NULL,
    [Activo]              NCHAR (1)     NULL,
    CONSTRAINT [PK_prod_Clave_Autorizacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGeneracion] ASC, [Secuencia] ASC)
);

