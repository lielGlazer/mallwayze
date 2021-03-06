USE [master]
GO
/****** Object:  Database [wayze]    Script Date: 31/05/2022 12:44:59 ******/
--CREATE DATABASE [wayze]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'wayzeShoop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\wayzeShoop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'wayzeShoop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\wayzeShoop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT
--GO
--ALTER DATABASE [wayze] SET COMPATIBILITY_LEVEL = 150
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [wayze].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [wayze] SET ANSI_NULL_DEFAULT OFF 
--GO
--ALTER DATABASE [wayze] SET ANSI_NULLS OFF 
--GO
--ALTER DATABASE [wayze] SET ANSI_PADDING OFF 
--GO
--ALTER DATABASE [wayze] SET ANSI_WARNINGS OFF 
--GO
--ALTER DATABASE [wayze] SET ARITHABORT OFF 
--GO
--ALTER DATABASE [wayze] SET AUTO_CLOSE OFF 
--GO
--ALTER DATABASE [wayze] SET AUTO_SHRINK OFF 
--GO
--ALTER DATABASE [wayze] SET AUTO_UPDATE_STATISTICS ON 
--GO
--ALTER DATABASE [wayze] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO
--ALTER DATABASE [wayze] SET CURSOR_DEFAULT  GLOBAL 
--GO
--ALTER DATABASE [wayze] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO
--ALTER DATABASE [wayze] SET NUMERIC_ROUNDABORT OFF 
--GO
--ALTER DATABASE [wayze] SET QUOTED_IDENTIFIER OFF 
--GO
--ALTER DATABASE [wayze] SET RECURSIVE_TRIGGERS OFF 
--GO
--ALTER DATABASE [wayze] SET  DISABLE_BROKER 
--GO
--ALTER DATABASE [wayze] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO
--ALTER DATABASE [wayze] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO
--ALTER DATABASE [wayze] SET TRUSTWORTHY OFF 
--GO
--ALTER DATABASE [wayze] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO
--ALTER DATABASE [wayze] SET PARAMETERIZATION SIMPLE 
--GO
--ALTER DATABASE [wayze] SET READ_COMMITTED_SNAPSHOT OFF 
--GO
--ALTER DATABASE [wayze] SET HONOR_BROKER_PRIORITY OFF 
--GO
--ALTER DATABASE [wayze] SET RECOVERY FULL 
--GO
--ALTER DATABASE [wayze] SET  MULTI_USER 
--GO
--ALTER DATABASE [wayze] SET PAGE_VERIFY CHECKSUM  
--GO
--ALTER DATABASE [wayze] SET DB_CHAINING OFF 
--GO
--ALTER DATABASE [wayze] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO
--ALTER DATABASE [wayze] SET TARGET_RECOVERY_TIME = 60 SECONDS 
--GO
--ALTER DATABASE [wayze] SET DELAYED_DURABILITY = DISABLED 
--GO
--ALTER DATABASE [wayze] SET ACCELERATED_DATABASE_RECOVERY = OFF  
--GO
--EXEC sys.sp_db_vardecimal_storage_format N'wayzeShoop', N'ON'
--GO
--ALTER DATABASE [wayze] SET QUERY_STORE = OFF
--GO
USE [wayzeShoop]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 31/05/2022 12:44:59 ******/
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
/****** Object:  Table [dbo].[CategoryForStor]    Script Date: 31/05/2022 12:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryForStor](
	[CategoryCodeForStore] [bigint] IDENTITY(1,1) NOT NULL,
	[categoryCode] [bigint] NOT NULL,
	[CodeStor] [bigint] NOT NULL,
 CONSTRAINT [PK_TatKatgory] PRIMARY KEY CLUSTERED 
(
	[CategoryCodeForStore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FavoriteStoresForTheUser]    Script Date: 31/05/2022 12:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FavoriteStoresForTheUser](
	[FavoriteCode] [bigint] IDENTITY(1,1) NOT NULL,
	[CodeStor] [bigint] NOT NULL,
	[UserCode] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 31/05/2022 12:44:59 ******/
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
/****** Object:  Table [dbo].[Stor]    Script Date: 31/05/2022 12:44:59 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 31/05/2022 12:44:59 ******/
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
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryCode], [NameCategory]) VALUES (1, N'אופטיקה')
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
SET IDENTITY_INSERT [dbo].[CategoryForStor] ON 

INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (7, 1, 10043)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (8, 1, 10065)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (9, 1, 10017)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (10, 1, 10045)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (11, 2, 10012)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (12, 2, 10070)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (13, 2, 10026)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (14, 2, 10041)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (15, 2, 10047)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (16, 2, 10028)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (17, 2, 10051)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (18, 2, 10056)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (19, 2, 10053)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (20, 2, 10062)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (21, 2, 10040)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (22, 2, 10082)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (23, 2, 10031)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (24, 2, 10061)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (25, 2, 10073)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (26, 2, 10063)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (27, 2, 10050)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (28, 2, 10076)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (29, 2, 10068)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (30, 2, 10069)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (31, 2, 10054)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (32, 2, 10080)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (33, 2, 10064)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (34, 2, 10022)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (35, 2, 10049)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (36, 3, 10041)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (37, 3, 10026)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (38, 3, 10028)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (39, 3, 10055)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (40, 3, 10051)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (41, 3, 10023)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (42, 3, 10057)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (43, 3, 10009)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (44, 3, 10010)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (45, 3, 10061)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (46, 3, 10063)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (47, 3, 10011)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (49, 3, 10046)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (50, 3, 10027)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (51, 3, 10015)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (52, 3, 10019)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (53, 3, 10020)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (54, 5, 10053)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (57, 2, 10082)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (58, 3, 10082)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (59, 5, 10054)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (61, 5, 10074)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (62, 5, 10077)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (63, 5, 10017)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (64, 5, 10046)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (65, 5, 10029)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (66, 5, 10039)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (67, 5, 10071)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (68, 5, 10033)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (69, 5, 10059)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (70, 5, 10004)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (71, 6, 10047)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (72, 6, 10051)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (73, 6, 10053)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (74, 6, 10009)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (75, 6, 10082)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (76, 6, 10061)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (77, 6, 10081)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (78, 6, 10063)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (79, 6, 10076)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (80, 6, 10030)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (81, 6, 10025)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (82, 7, 10044)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (83, 7, 10053)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (84, 7, 10060)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (85, 7, 10017)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (87, 7, 10018)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (88, 7, 10079)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (89, 7, 10027)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (90, 7, 10039)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (91, 7, 10073)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (92, 12, 10034)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (93, 12, 10038)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (94, 12, 10036)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (95, 12, 1)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (96, 12, 10029)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (97, 12, 10032)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (98, 8, 10070)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (99, 8, 10012)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (100, 8, 10056)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (101, 8, 10053)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (102, 8, 10009)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (103, 8, 10061)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (104, 8, 10037)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (105, 8, 10017)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (106, 8, 10046)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (107, 8, 10075)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (108, 9, 10003)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (109, 9, 10048)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (110, 9, 10067)
GO
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (111, 9, 10006)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (112, 9, 10042)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (114, 10, 10012)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (115, 10, 10047)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (116, 10, 10040)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (117, 10, 10062)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (119, 10, 10009)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (120, 11, 10079)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (121, 11, 10029)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (122, 11, 10034)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (124, 11, 10073)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (125, 11, 10005)
INSERT [dbo].[CategoryForStor] ([CategoryCodeForStore], [categoryCode], [CodeStor]) VALUES (126, 11, 10004)
SET IDENTITY_INSERT [dbo].[CategoryForStor] OFF
GO
SET IDENTITY_INSERT [dbo].[FavoriteStoresForTheUser] ON 

INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (1, 2, 1)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (2, 1, 1)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (10003, 10033, 6)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (6, 3, 8)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (7, 10002, 8)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (8, 10003, 1)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (9, 10012, 3)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (10, 10002, 4)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (11, 10004, 6)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (13, 10015, 3)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (14, 10022, 3)
INSERT [dbo].[FavoriteStoresForTheUser] ([FavoriteCode], [CodeStor], [UserCode]) VALUES (15, 10033, 4)
SET IDENTITY_INSERT [dbo].[FavoriteStoresForTheUser] OFF
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
INSERT [dbo].[Locations] ([LocationCode], [AxisX], [AxisY], [floor]) VALUES (10029, 11, 37, 1)
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[Stor] ON 

INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (1, 1, N'BUG', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (2, 2, N'פפאיה', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (3, 3, N'I  STORE', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10002, 4, N'LEIALONDON', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10003, 5, N'BBB', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10004, 6, N'זהר פרחים', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10005, 7, N'מפעל הפייס', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10006, 8, N'ארומה ', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10007, 9, N'אופטיקה הלפרין', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10008, 10, N'כספומט', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10009, 11, N'מגה ספורט', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10010, 12, N'OLIVIA', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10011, 13, N'TOPTEN', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10012, 14, N'H&M', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10013, 15, N'קפרי', CAST(N'10:00:00' AS Time), CAST(N'21:30:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10014, 16, N'מובייל', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10015, 17, N'מגנוליה', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10016, 18, N'רצ''י תכשיטים', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10017, 19, N'סופר פראם', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10018, 20, N'אייל מקיא''ז', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10019, 21, N'גראס', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10020, 22, N'ארנקי שולה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10021, 23, N'עונות', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10022, 24, N'אריסטושמט', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10023, 25, N'פנדורה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10024, 26, N'ספייסז', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10025, 27, N'EXIT', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10026, 28, N'MANGO', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10027, 29, N'SACARA', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10028, 30, N'דיזיגואל', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10029, 31, N'IROBOT', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10030, 32, N'טבע נאות', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10031, 33, N'לבנבנים', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10032, 34, N'דינמיקה', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10033, 35, N'הום סנטר', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10034, 36, N'פלאפון', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10035, 37, N'HELO', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10036, 38, N'GO MOBILE', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10037, 39, N'שילב', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10038, 40, N'מובי כל', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10039, 41, N'ללין', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10040, 42, N'אדידס', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10041, 43, N'פול אנד בר', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10042, 44, N'גרג', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10043, 45, N'אופטיקנה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10044, 46, N'MAC', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10045, 47, N'אירוקה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10046, 48, N'POPSY', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10047, 49, N'פוט לוקר', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10048, 50, N'MR. CORN', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10049, 51, N'אינטימה', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10050, 52, N'גולף', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10051, 53, N'אלדו', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10052, 54, N'היינס', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10053, 55, N'המשביר לצרכן', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10054, 56, N'פוקס', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10055, 57, N'לסטר', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10056, 58, N'הודיס', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10057, 59, N'פדני', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 1)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10058, 60, N'סטודיו פאשה', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10059, 61, N'ג''לטנמן', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10060, 62, N'ל''אוקסיטן', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10061, 63, N'קסטרו', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10062, 64, N'בילבונג', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10063, 65, N'רנואר', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10064, 66, N'GOLBARY', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10065, 67, N'קרולינה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10066, 68, N'עולם הממתקים', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10067, 69, N'RE-BAR', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10068, 70, N'תמנון', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10069, 71, N'קרייזי ליין', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10070, 72, N'זארה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10071, 73, N'גלריית מעצבים ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10072, 74, N'קפה קפה ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10073, 75, N'AMRICAN', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10074, 76, N'גולף אנד קו', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10075, 77, N'GOLF KIDS', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10076, 78, N'עמנואל', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10077, 79, N'הצורפים', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10078, 80, N'מתחם תינוקות ', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10079, 81, N'LAKE', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10080, 82, N'פולגת', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10081, 83, N'ליידי קומפורט', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10082, 84, N'פרופיל', CAST(N'10:00:00' AS Time), CAST(N'21:00:00' AS Time), 0)
INSERT [dbo].[Stor] ([CodeStor], [PlaceCode], [NameStor], [OpeningHours], [ClosingHours], [Sale]) VALUES (10084, 10029, N'כניסה ', NULL, NULL, 0)
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
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (20002, N'חנה', N'1234')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (20003, N'רבקה', N'1111')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (30002, N'ליאל', N'1111')
INSERT [dbo].[Users] ([UserCode], [UserName], [Password]) VALUES (30003, N'שוקי', N'9000')
SET IDENTITY_INSERT [dbo].[Users] OFF
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
ALTER TABLE [dbo].[Stor]  WITH CHECK ADD  CONSTRAINT [FK_Stor_Locations] FOREIGN KEY([PlaceCode])
REFERENCES [dbo].[Locations] ([LocationCode])
GO
ALTER TABLE [dbo].[Stor] CHECK CONSTRAINT [FK_Stor_Locations]
GO
USE [master]
GO
ALTER DATABASE [wayze] SET  READ_WRITE 
GO
