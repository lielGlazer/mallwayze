USE [wayzeShoop]
GO

/****** Object:  Table [dbo].[CategoryForStor]    Script Date: 25/01/2022 12:37:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CategoryForStor](
	[CodeStor] [bigint] NOT NULL,
	[categoryCode] [bigint] IDENTITY(1,1) NOT NULL,
	[categoryName] [varchar](50) NULL,
 CONSTRAINT [PK_TatKatgory] PRIMARY KEY CLUSTERED 
(
	[categoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CategoryForStor]  WITH CHECK ADD  CONSTRAINT [FK_CategoryForStor_Category] FOREIGN KEY([categoryCode])
REFERENCES [dbo].[Category] ([CategoryCode])
GO

ALTER TABLE [dbo].[CategoryForStor] CHECK CONSTRAINT [FK_CategoryForStor_Category]
GO

ALTER TABLE [dbo].[CategoryForStor]  WITH CHECK ADD  CONSTRAINT [FK_CategoryForStor_Stor] FOREIGN KEY([CodeStor])
REFERENCES [dbo].[Stor] ([CodeStor])
GO

ALTER TABLE [dbo].[CategoryForStor] CHECK CONSTRAINT [FK_CategoryForStor_Stor]
GO

