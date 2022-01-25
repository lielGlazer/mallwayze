USE [wayzeShoop]
GO

/****** Object:  Table [dbo].[OpeningHours]    Script Date: 25/01/2022 12:38:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OpeningHours](
	[OpeningTimeCode] [bigint] IDENTITY(1,1) NOT NULL,
	[OpeningHours] [datetime] NULL,
	[ClosingTime] [datetime] NULL,
 CONSTRAINT [PK_OpeningHours] PRIMARY KEY CLUSTERED 
(
	[OpeningTimeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

