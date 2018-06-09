CREATE TABLE [dbo].[prod_ProgramaProd] (
    [IdEmpresa]      INT          NOT NULL,
    [IdProgramaProd] INT          NOT NULL,
    [IdTurno]        INT          NULL,
    [Fecha]          DATETIME     NULL,
    [IdProducto]     NUMERIC (18) NULL,
    [IdCategoria]    VARCHAR (25) NULL,
    [Unidad]         DECIMAL (18) NULL,
    [Peso]           DECIMAL (18) NULL,
    [Toneladas]      DECIMAL (18) NULL,
    [Pedidos]        INT          NULL,
    [Estado]         VARCHAR (1)  NULL,
    CONSTRAINT [PK_prod_ProgramaProd] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProgramaProd] ASC)
);

