CREATE TABLE [dbo].[pr_mat_insu] (
    [codigo]      INT           NOT NULL,
    [descripcion] VARCHAR (200) NULL,
    [status]      CHAR (1)      NULL,
    [fktipo]      CHAR (1)      NULL,
    CONSTRAINT [PK_pr_mat_insu] PRIMARY KEY CLUSTERED ([codigo] ASC)
);

