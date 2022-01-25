USE [wayzeShoop]
GO

/****** Object:  Table [dbo].[OpeningHoursForDorkingDay]    Script Date: 25/01/2022 12:39:23 ******/
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

