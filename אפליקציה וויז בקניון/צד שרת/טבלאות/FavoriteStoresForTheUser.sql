USE [wayzeShoop]
GO

/****** Object:  Table [dbo].[FavoriteStoresForTheUser]    Script Date: 25/01/2022 12:37:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FavoriteStoresForTheUser](
	[UserCode] [bigint] NOT NULL,
	[CodeStor] [bigint] NOT NULL,
	[LikeStor] [bit] NOT NULL,
 CONSTRAINT [PK_FavoriteParkingForTheUser] PRIMARY KEY CLUSTERED 
(
	[LikeStor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[FavoriteStoresForTheUser]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteParkingForTheUser_Stor] FOREIGN KEY([CodeStor])
REFERENCES [dbo].[Stor] ([CodeStor])
GO

ALTER TABLE [dbo].[FavoriteStoresForTheUser] CHECK CONSTRAINT [FK_FavoriteParkingForTheUser_Stor]
GO

ALTER TABLE [dbo].[FavoriteStoresForTheUser]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteParkingForTheUser_Users] FOREIGN KEY([UserCode])
REFERENCES [dbo].[Users] ([UserCode])
GO

ALTER TABLE [dbo].[FavoriteStoresForTheUser] CHECK CONSTRAINT [FK_FavoriteParkingForTheUser_Users]
GO

