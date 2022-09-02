USE [LAB-HUB-2022]
GO

/****** Object:  Table [dbo].[User]    Script Date: 9/2/2022 11:47:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [char](50) NULL,
	[PassWord] [char](200) NULL,
	[FullName] [nvarchar](100) NULL,
	[Email] [char](50) NULL,
	[PhoneNumber] [char](15) NULL,
	[Address] [nvarchar](500) NULL,
	[Department] [nvarchar](100) NULL,
	[Position] [nvarchar](100) NULL,
	[RoleId] [int] NULL,
	[Status] [int] NULL,
	[IsDeleted] [bit] NULL,
	[GroupID] [varchar](20) NULL,
	[UserType] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_GroupID]  DEFAULT ('MEMBER') FOR [GroupID]
GO


