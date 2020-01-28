CREATE TABLE [Digitalizacion].[cp_XML_DocumentoRetAnulado] (
    [IdEmpresa]              INT            NOT NULL,
    [IdDocumento]            NUMERIC (18)   NOT NULL,
    [SecuenciaAnu]           INT            NOT NULL,
    [Comprobante]            VARCHAR (50)   NOT NULL,
    [emi_Ruc]                VARCHAR (20)   NOT NULL,
    [emi_RazonSocial]        VARCHAR (2000) NOT NULL,
    [FechaEmision]           DATE           NOT NULL,
    [ret_CodDocumentoTipo]   VARCHAR (20)   NULL,
    [ret_Establecimiento]    VARCHAR (3)    NULL,
    [ret_PuntoEmision]       VARCHAR (3)    NULL,
    [ret_NumeroDocumento]    VARCHAR (50)   NULL,
    [ret_Fecha]              DATE           NULL,
    [ret_FechaAutorizacion]  DATE           NULL,
    [ret_NumeroAutorizacion] VARCHAR (200)  NULL,
    [IdUsuarioAnulacion]     VARCHAR (50)   NULL,
    [FechaAnulacion]         DATETIME       NULL,
    CONSTRAINT [PK_cp_XML_DocumentoRetAnulado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC, [SecuenciaAnu] ASC)
);

