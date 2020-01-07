CREATE TABLE [Digitalizacion].[cp_XML_Documento] (
    [IdEmpresa]                 INT            NOT NULL,
    [IdDocumento]               NUMERIC (18)   NOT NULL,
    [Comprobante]               VARCHAR (50)   NOT NULL,
    [XML]                       VARCHAR (MAX)  NOT NULL,
    [Tipo]                      VARCHAR (20)   NOT NULL,
    [emi_RazonSocial]           VARCHAR (2000) NOT NULL,
    [emi_NombreComercial]       VARCHAR (2000) NOT NULL,
    [emi_Ruc]                   VARCHAR (20)   NOT NULL,
    [emi_DireccionMatriz]       VARCHAR (2000) NOT NULL,
    [emi_ContribuyenteEspecial] VARCHAR (50)   NOT NULL,
    [ClaveAcceso]               VARCHAR (200)  NOT NULL,
    [CodDocumento]              VARCHAR (20)   NOT NULL,
    [Establecimiento]           VARCHAR (10)   NOT NULL,
    [PuntoEmision]              VARCHAR (10)   NOT NULL,
    [NumeroDocumento]           VARCHAR (100)  NOT NULL,
    [FechaEmision]              DATE           NOT NULL,
    [rec_RazonSocial]           VARCHAR (2000) NOT NULL,
    [rec_Identificacion]        VARCHAR (20)   NOT NULL,
    [Subtotal0]                 FLOAT (53)     NOT NULL,
    [SubtotalIVA]               FLOAT (53)     NOT NULL,
    [Porcentaje]                FLOAT (53)     NOT NULL,
    [ValorIVA]                  FLOAT (53)     NOT NULL,
    [Total]                     FLOAT (53)     NOT NULL,
    [FormaPago]                 VARCHAR (2)    NULL,
    [Plazo]                     INT            NOT NULL,
    [ret_CodDocumentoTipo]      VARCHAR (20)   NULL,
    [ret_Establecimiento]       VARCHAR (3)    NULL,
    [ret_PuntoEmision]          VARCHAR (3)    NULL,
    [ret_NumeroDocumento]       VARCHAR (50)   NULL,
    [ret_Fecha]                 DATE           NULL,
    [ret_FechaAutorizacion]     DATE           NULL,
    [ret_NumeroAutorizacion]    VARCHAR (200)  NULL,
    [Estado]                    BIT            NOT NULL,
    [IdTipoCbte]                INT            NULL,
    [IdCbteCble]                NUMERIC (18)   NULL,
    [IdUsuarioCreacion]         VARCHAR (50)   NULL,
    [FechaCreacion]             DATETIME       NULL,
    [IdUsuarioModificacion]     VARCHAR (50)   NULL,
    [FechaModificacion]         DATETIME       NULL,
    [IdUsuarioAnulacion]        VARCHAR (50)   NULL,
    [FechaAnulacion]            DATETIME       NULL,
    CONSTRAINT [PK_cp_XML_Documento] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDocumento] ASC)
);









