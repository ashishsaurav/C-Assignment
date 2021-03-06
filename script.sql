USE [PracticeAssignment]
GO
/****** Object:  Table [dbo].[T_CompanyFunds]    Script Date: 9/14/2020 3:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_CompanyFunds](
	[FundID] [int] IDENTITY(1,1) NOT NULL,
	[FundName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_OrderAndSub]    Script Date: 9/14/2020 3:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_OrderAndSub](
	[Symbol] [varchar](50) NOT NULL,
	[Side] [varchar](50) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[AvgPrice] [decimal](18, 0) NOT NULL,
	[RemainingQuantity] [int] NOT NULL,
	[OrderStatus] [varchar](50) NOT NULL,
	[CLOrderId] [int] IDENTITY(1,1) NOT NULL,
	[ParentCLOrderId] [int] NULL,
	[StagedOrderId] [int] NULL,
	[OriginalCLOrderId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CLOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_TradedOrders]    Script Date: 9/14/2020 3:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_TradedOrders](
	[Symbol] [varchar](50) NOT NULL,
	[Side] [varchar](50) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[AvgPrice] [decimal](18, 0) NOT NULL,
	[RemainingQuantity] [int] NOT NULL,
	[OrderStatus] [varchar](50) NOT NULL,
	[CLOrderId] [int] IDENTITY(1,1) NOT NULL,
	[ParentCLOrderId] [int] NULL,
	[StagedOrderId] [int] NULL,
	[OriginalCLOrderId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CLOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 9/14/2020 3:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[T_TradedOrders]  WITH CHECK ADD FOREIGN KEY([ParentCLOrderId])
REFERENCES [dbo].[T_OrderAndSub] ([CLOrderId])
ON DELETE CASCADE
GO
