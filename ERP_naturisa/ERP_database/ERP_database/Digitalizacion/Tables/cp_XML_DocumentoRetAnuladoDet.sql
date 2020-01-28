CREATE TABLE [Digitalizacion].[cp_XML_DocumentoRetAnuladoDet] (
    [IdEmpresa]           INT          NOT NULL,
    [IdDocumento]         NUMERIC (18) NOT NULL,
    [SecuenciaAnu]        INT          NOT NULL,
    [Secuencia]           INT          NOT NULL,
    [re_tipoRet]          CHAR (3)     NOT NULL,
    [re_baseRetencion]    FLOAT (53)   NOT NULL,
    [IdCodigo_SRI]        INT          NOT NULL,
    [re_Codigo_impuesto]  VARCHAR (50) NOT NULL,
    [re_Porcen_retencion] FLOAT (53)   NOT NULL,
    [re_valor_retencion]  FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_cp_XML_DocumentoRetAnuladoDet] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC, [SecuenciaAnu] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_cp_XML_DocumentoRetAnuladoDet_cp_XML_DocumentoRetAnulado] FOREIGN KEY ([IdEmpresa], [IdDocumento], [SecuenciaAnu]) REFERENCES [Digitalizacion].[cp_XML_DocumentoRetAnulado] ([IdEmpresa], [IdDocumento], [SecuenciaAnu])
);

