CREATE TABLE [Digitalizacion].[cp_XML_Documento_Retencion] (
    [IdEmpresa]           INT          NOT NULL,
    [IdDocumento]         NUMERIC (18) NOT NULL,
    [Secuencia]           INT          NOT NULL,
    [re_tipoRet]          CHAR (3)     NOT NULL,
    [re_baseRetencion]    FLOAT (53)   NOT NULL,
    [IdCodigo_SRI]        INT          NOT NULL,
    [re_Codigo_impuesto]  VARCHAR (50) NOT NULL,
    [re_Porcen_retencion] FLOAT (53)   NOT NULL,
    [re_valor_retencion]  FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_cp_XML_Documento_Retencion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_cp_XML_Documento_Retencion_cp_XML_Documento] FOREIGN KEY ([IdEmpresa], [IdDocumento]) REFERENCES [Digitalizacion].[cp_XML_Documento] ([IdEmpresa], [IdDocumento])
);

