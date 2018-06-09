CREATE TABLE [dbo].[imp_Tipo_docu_pago] (
    [CodDocu_Pago]  VARCHAR (10)  NOT NULL,
    [Descripcion]   VARCHAR (150) NOT NULL,
    [PideBanco]     CHAR (1)      NOT NULL,
    [PideProveedor] CHAR (1)      NOT NULL,
    CONSTRAINT [PK_imp_documento_x_gas] PRIMARY KEY CLUSTERED ([CodDocu_Pago] ASC)
);

