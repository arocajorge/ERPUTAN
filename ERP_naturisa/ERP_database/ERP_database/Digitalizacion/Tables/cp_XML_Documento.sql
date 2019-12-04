CREATE TABLE [Digitalizacion].[cp_XML_Documento] (
    [IdEmpresa]                 INT            NOT NULL,
    [IdDocumento]               NUMERIC (18)   NOT NULL,
    [Comprobante]               VARCHAR (50)   NULL,
    [XML]                       VARCHAR (MAX)  NULL,
    [Tipo]                      VARCHAR (20)   NULL,
    [emi_RazonSocial]           VARCHAR (2000) NULL,
    [emi_NombreComercial]       VARCHAR (2000) NULL,
    [emi_Ruc]                   VARCHAR (20)   NULL,
    [emi_DireccionMatriz]       VARCHAR (2000) NULL,
    [emi_ContribuyenteEspecial] VARCHAR (50)   NULL,
    [ClaveAcceso]               VARCHAR (200)  NULL,
    [CodDocumento]              VARCHAR (20)   NULL,
    [Establecimiento]           VARCHAR (10)   NULL,
    [PuntoEmision]              VARCHAR (10)   NULL,
    [NumeroDocumento]           VARCHAR (100)  NULL,
    [FechaEmision]              DATE           NULL,
    [rec_RazonSocial]           VARCHAR (2000) NULL,
    [rec_Identificacion]        VARCHAR (20)   NULL,
    [Subtotal0]                 FLOAT (53)     NULL,
    [SubtotalIVA]               FLOAT (53)     NULL,
    [Porcentaje]                FLOAT (53)     NULL,
    [ValorIVA]                  FLOAT (53)     NULL,
    [Total]                     FLOAT (53)     NULL,
    [FormaPago]                 VARCHAR (2)    NULL,
    [Plazo]                     INT            NULL,
    [ret_CodDocumentoTipo]      VARCHAR (20)   NULL,
    [ret_Establecimiento]       VARCHAR (3)    NULL,
    [ret_PuntoEmision]          VARCHAR (3)    NULL,
    [ret_NumeroDocumento]       VARCHAR (50)   NULL,
    [ret_Fecha]                 DATE           NULL,
    [ret_FechaAutorizacion]     DATE           NULL,
    [ret_NumeroAutorizacion]    VARCHAR (200)  NULL,
    [Estado]                    BIT            NULL,
    [IdTipoCbte]                INT            NULL,
    [IdCbteCble]                NUMERIC (18)   NULL,
    CONSTRAINT [PK_cp_XML_Documento] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC)
);





