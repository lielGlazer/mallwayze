CREATE TABLE [dbo].[CategoryForStor] (
    [CodeStor]     BIGINT     IDENTITY (1, 1) NOT NULL,
    [categoryCode] BIGINT       NOT NULL,
    [categoryName] VARCHAR (50) NULL,
    CONSTRAINT [PK_TatKatgory] PRIMARY KEY CLUSTERED ([categoryCode] ASC),
    CONSTRAINT [FK_CategoryForStor_Stor] FOREIGN KEY ([CodeStor]) REFERENCES [dbo].[Stor] ([CodeStor]),
    CONSTRAINT [FK_CategoryForStor_Category] FOREIGN KEY ([categoryCode]) REFERENCES [dbo].[Category] ([CategoryCode])
);

