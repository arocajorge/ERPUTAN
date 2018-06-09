CREATE TABLE [CAH].[tb_banco_x_mg_banco] (
    [Id_tb_banco_x_mgbanco] INT           NOT NULL,
    [IdBanco_Erp]           INT           NULL,
    [IdBanco_Academico]     INT           NULL,
    [nombre]                VARCHAR (50)  NULL,
    [nota1]                 VARCHAR (850) NULL,
    [nota2]                 VARCHAR (850) NULL,
    [fecha_insert]          DATETIME      NULL,
    [fecha_update]          DATETIME      NULL,
    CONSTRAINT [PK_tb_banco_x_mg_banco_1] PRIMARY KEY CLUSTERED ([Id_tb_banco_x_mgbanco] ASC),
    CONSTRAINT [FK_tb_banco_x_mg_banco_tb_banco] FOREIGN KEY ([IdBanco_Erp]) REFERENCES [dbo].[tb_banco] ([IdBanco])
);

