USE [PayRollSystem]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 01/28/2014 16:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeCode] [nvarchar](6) NOT NULL,
	[EmployeeName] [nvarchar](70) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[PostCode] [nvarchar](10) NOT NULL,
	[Salary] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
