CREATE TABLE [dbo].[tb_sis_Documento_Tipo_Reporte_x_Empresa] (
    [IdEmpresa]            INT             NOT NULL,
    [codDocumentoTipo]     VARCHAR (20)    NOT NULL,
    [File_Disenio_Reporte] VARBINARY (MAX) NULL,
    CONSTRAINT [PK_tb_sis_Documento_Tipo_Reporte_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [codDocumentoTipo] ASC),
    CONSTRAINT [FK_tb_sis_Documento_Tipo_Reporte_x_Empresa_tb_sis_Documento_Tipo] FOREIGN KEY ([codDocumentoTipo]) REFERENCES [dbo].[tb_sis_Documento_Tipo] ([codDocumentoTipo])
);

