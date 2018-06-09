CREATE TABLE [dbo].[prd_Obra] (
    [IdEmpresa]        INT             NOT NULL,
    [CodObra]          VARCHAR (20)    NOT NULL,
    [Descripcion]      VARCHAR (100)   NOT NULL,
    [Referencia]       TEXT            NULL,
    [PesoObra]         DECIMAL (18, 2) NULL,
    [Estado]           CHAR (1)        NOT NULL,
    [Fecha]            DATETIME        NOT NULL,
    [IdCentroCosto]    VARCHAR (20)    NOT NULL,
    [IdUsuario]        VARCHAR (20)    NOT NULL,
    [IdUsuarioAnu]     VARCHAR (20)    NULL,
    [MotivoAnu]        VARCHAR (100)   NULL,
    [IdUsuarioUltModi] VARCHAR (20)    NULL,
    [FechaAnu]         DATETIME        NULL,
    [FechaTransac]     DATETIME        NOT NULL,
    [FechaUltModi]     DATETIME        NULL,
    [IdCliente]        NUMERIC (18)    NOT NULL,
    CONSTRAINT [PK_prd_Obra] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [CodObra] ASC)
);

