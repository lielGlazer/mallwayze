USE [wayzeShoop]
GO

/****** Object:  Table [dbo].[Stor]    Script Date: 25/01/2022 12:39:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stor](
	[CodeStor] [bigint] IDENTITY(1,1) NOT NULL,
	[PlaceCode] [bigint] NULL,
	[NameStor] [varchar](50) NULL,
	[OpeningHours] [time](7) NULL,
	[ClosingHours] [time](7) NULL,
	[Sale] [bit] NULL,
 CONSTRAINT [PK_Stor] PRIMARY KEY CLUSTERED 
(
	[CodeStor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Stor]  WITH CHECK ADD  CONSTRAINT [FK_Stor_Locations] FOREIGN KEY([PlaceCode])
REFERENCES [dbo].[Locations] ([LocationCode])
GO

ALTER TABLE [dbo].[Stor] CHECK CONSTRAINT [FK_Stor_Locations]
GO

