USE [master]
GO
/****** Object:  Database [wayzeShoop]    Script Date: 01/02/2022 11:54:44 ******/
CREATE DATABASE [wayzeShoop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'wayzeShoop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\wayzeShoop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'wayzeShoop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\wayzeShoop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [wayzeShoop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [wayzeShoop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [wayzeShoop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [wayzeShoop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [wayzeShoop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [wayzeShoop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [wayzeShoop] SET ARITHABORT OFF 
GO
ALTER DATABASE [wayzeShoop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [wayzeShoop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [wayzeShoop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [wayzeShoop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [wayzeShoop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [wayzeShoop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [wayzeShoop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [wayzeShoop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [wayzeShoop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [wayzeShoop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [wayzeShoop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [wayzeShoop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [wayzeShoop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [wayzeShoop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [wayzeShoop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [wayzeShoop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [wayzeShoop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [wayzeShoop] SET RECOVERY FULL 
GO
ALTER DATABASE [wayzeShoop] SET  MULTI_USER 
GO
ALTER DATABASE [wayzeShoop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [wayzeShoop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [wayzeShoop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [wayzeShoop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [wayzeShoop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [wayzeShoop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'wayzeShoop', N'ON'
GO
ALTER DATABASE [wayzeShoop] SET QUERY_STORE = OFF
GO
USE [wayzeShoop]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 01/02/2022 11:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryCode] [bigint] IDENTITY(1,1) NOT NULL,
	[NameCategory] [varchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryForStor]    Script Date: 01/02/2022 11:54:44 ******/
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
/****** Object:  Table [dbo].[FavoriteStoresForTheUser]    Script Date: 01/02/2022 11:54:44 ******/
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
/****** Object:  Table [dbo].[Locations]    Script Date: 01/02/2022 11:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationCode] [bigint] IDENTITY(1,1) NOT NULL,
	[AxisX] [float] NULL,
	[AxisY] [float] NULL,
	[floor] [int] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpeningHours]    Script Date: 01/02/2022 11:54:44 ******/
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
/****** Object:  Table [dbo].[OpeningHoursForDorkingDay]    Script Date: 01/02/2022 11:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpeningHoursForDorkingDay](
	[OpeningHoursCodeForWorkingDay] [bigint] IDENTITY(1,1) NOT NULL,
	[StoreCode] [bigint] NULL,
	[WorkingDayCode] [bigint] NULL,
	[OpeningTimeCode1] [bigint] NULL,
	[OpeningTimeCode2] [bigint] NULL,
 CONSTRAINT [PK_OpeningHoursForDorkingDay] PRIMARY KEY CLUSTERED 
(
	[OpeningHoursCodeForWorkingDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stor]    Script Date: 01/02/2022 11:54:44 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 01/02/2022 11:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserCode] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkingDaysWeek]    Script Date: 01/02/2022 11:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkingDaysWeek](
	[WorkingDayCode] [bigint] IDENTITY(1,1) NOT NULL,
	[NameOfWorkDay] [varchar](50) NULL,
 CONSTRAINT [PK_WorkingDaysWeek] PRIMARY KEY CLUSTERED 
(
	[WorkingDayCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (1, N'אופטיקה ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (2, N'אופנה ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (3, N'אקססוריז')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (4, N'בילוי ופנאי ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (5, N'בית ומתנות ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (6, N'הנעלה ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (7, N'טיפוח וקוסמטיקה ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (8, N'ילדים ותינוקות ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (9, N'מסעדות קפה ומזון מהיר ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (10, N'ספורט ומחנאות ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (11, N'שירותים ')
INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (12, N'תקשורת ואלקטרוניקה ')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (1, 12, 37, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (2, 13, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (3, 13.5, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (4, 14, 35, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (5, 14, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (6, 12.5, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (7, 11, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (8, 10, 37, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (9, 10, 35, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (10, 8, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (11, 8, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (12, 8.5, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (13, 7.5, 34.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (14, 3, 36, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (15, 7.5, 33, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (16, 6, 31.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (17, 6, 30, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (18, 6, 29, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (19, 5, 29.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (20, 5, 28, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (21, 7, 28, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (22, 7, 28.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (23, 7, 29, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (24, 7, 30, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (25, 7, 31, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (26, 7.5, 31.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (27, 8, 32, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (28, 9, 28, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (29, 8.5, 32.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (30, 9, 33, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (31, 10, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (32, 10.5, 34.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (33, 11, 35, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (34, 10, 34.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (35, 16, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (36, 14, 33, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (37, 12.5, 34, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (38, 12, 35, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (39, 8, 25, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (40, 7, 26, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (41, 4, 27, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (42, 8, 24, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (43, 4, 25, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (44, 6, 26, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (45, 4, 23, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (46, 8, 23, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (47, 7.8, 23, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (48, 7.3, 22, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (49, 4.5, 22, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (50, 6, 21, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (51, 3, 21, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (52, 5, 19.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (53, 7, 19, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (54, 7, 18.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (55, 8, 16, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (56, 5, 19, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (57, 6, 18, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (58, 5, 17, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (59, 4.8, 16, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (60, 4.5, 15.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (61, 4, 15, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (62, 4, 14.5, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (63, 5, 13, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (64, 5, 12, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (65, 5, 10, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (66, 5, 7, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (67, 6, 9, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (68, 6, 11, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (69, 6, 14, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (70, 7, 13, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (71, 7, 12, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (72, 7, 11, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (73, 8, 7, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (74, 6, 7.8, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (75, 4.5, 6, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (76, 5.2, 4.2, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (77, 6, 4, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (78, 7, 4, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (79, 8.5, 4, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (80, 10, 4.2, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (81, 11, 4, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (82, 10, 3, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (83, 11, 3, 1)
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (84, 11.2, 2.2, 1)
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[Stor] ON 

INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (1, 1, N'BUG', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (2, 2, N'פפאיה', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (3, 3, N'I  STORE', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
SET IDENTITY_INSERT [dbo].[Stor] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (1, N'ליאל', N'1200')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (2, N'נחמן', N'1201')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (3, N'דביר', N'1202')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (4, N'אורי', N'1203')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (5, N'נדב', N'1204')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (6, N'דן', N'1205')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (7, N'דודו', N'1206')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (8, N'עדן', N'1207')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (9, N'עידו', N'1208')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (10, N'אייל', N'1209')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (11, N'ששון', N'1210')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (12, N'מלי', N'1211')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (13, N'אהבה ', N'1212')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (14, N'שירה ', N'1213')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (15, N'תהילה ', N'1215')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (16, N'תהל ', N'1216')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (17, N'רינת ', N'1217')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (18, N'חיה ', N'1218')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (19, N'תכלת ', N'1219')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (20, N'הודיה ', N'1220')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (10002, N'שוקי', N'9000')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (10003, N'שוקי', N'9000')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkingDaysWeek] ON 

INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (1, N'חמישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (2, N'שישי')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (3, N'ראשון')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (4, N'שני ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (5, N'שלישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (6, N'חמישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (7, N'מוצש')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (8, N'רביעי')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (9, N'שלישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (10, N'שני ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (11, N'ראשון ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (12, N'שישי')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (13, N'שני ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (14, N'ראשון ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (15, N'רביעי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (16, N'חמישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (17, N'מוצש')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (18, N'מוצש')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (19, N'שלישי ')
INSERT [dbo].[WorkingDaysWeek] ([WorkingDayCode], [NameOfWorkDay]) VALUES (20, N'שישי')
SET IDENTITY_INSERT [dbo].[WorkingDaysWeek] OFF
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
ALTER TABLE [dbo].[OpeningHoursForDorkingDay]  WITH CHECK ADD  CONSTRAINT [FK_OpeningHoursForDorkingDay_OpeningHours] FOREIGN KEY([OpeningTimeCode1])
REFERENCES [dbo].[OpeningHours] ([OpeningTimeCode])
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay] CHECK CONSTRAINT [FK_OpeningHoursForDorkingDay_OpeningHours]
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay]  WITH CHECK ADD  CONSTRAINT [FK_OpeningHoursForDorkingDay_OpeningHours3] FOREIGN KEY([OpeningTimeCode1])
REFERENCES [dbo].[OpeningHours] ([OpeningTimeCode])
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay] CHECK CONSTRAINT [FK_OpeningHoursForDorkingDay_OpeningHours3]
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay]  WITH CHECK ADD  CONSTRAINT [FK_OpeningHoursForDorkingDay_Stor] FOREIGN KEY([StoreCode])
REFERENCES [dbo].[Stor] ([CodeStor])
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay] CHECK CONSTRAINT [FK_OpeningHoursForDorkingDay_Stor]
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay]  WITH CHECK ADD  CONSTRAINT [FK_OpeningHoursForDorkingDay_Stor1] FOREIGN KEY([StoreCode])
REFERENCES [dbo].[Stor] ([CodeStor])
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay] CHECK CONSTRAINT [FK_OpeningHoursForDorkingDay_Stor1]
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay]  WITH CHECK ADD  CONSTRAINT [FK_OpeningHoursForDorkingDay_WorkingDaysWeek] FOREIGN KEY([WorkingDayCode])
REFERENCES [dbo].[WorkingDaysWeek] ([WorkingDayCode])
GO
ALTER TABLE [dbo].[OpeningHoursForDorkingDay] CHECK CONSTRAINT [FK_OpeningHoursForDorkingDay_WorkingDaysWeek]
GO
ALTER TABLE [dbo].[Stor]  WITH CHECK ADD  CONSTRAINT [FK_Stor_Locations] FOREIGN KEY([PlaceCode])
REFERENCES [dbo].[Locations] ([LocationCode])
GO
ALTER TABLE [dbo].[Stor] CHECK CONSTRAINT [FK_Stor_Locations]
GO
USE [master]
GO
ALTER DATABASE [wayzeShoop] SET  READ_WRITE 
GO
