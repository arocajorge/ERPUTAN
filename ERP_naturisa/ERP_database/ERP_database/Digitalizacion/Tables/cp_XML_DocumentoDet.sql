CREATE TABLE [Digitalizacion].[cp_XML_DocumentoDet] (
    [IdEmpresa]      INT           NOT NULL,
    [IdDocumento]    NUMERIC (18)  NOT NULL,
    [Secuencia]      INT           NOT NULL,
    [NombreProducto] VARCHAR (500) NULL,
    [Cantidad]       FLOAT (53)    NULL,
    [Precio]         FLOAT (53)    NULL,
    [PorcentajeIVA]  FLOAT (53)    NULL,
    [ValorIva]       FLOAT (53)    NULL,
    [Total]          FLOAT (53)    NULL,
    CONSTRAINT [PK_cp_XML_DocumentoDet] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_cp_XML_DocumentoDet_cp_XML_Documento] FOREIGN KEY ([IdEmpresa], [IdDocumento]) REFERENCES [Digitalizacion].[cp_XML_Documento] ([IdEmpresa], [IdDocumento])
);

