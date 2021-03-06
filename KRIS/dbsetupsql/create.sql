USE [KRIS]
GO
/****** Object:  Table [dbo].[Bid]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bid](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bid_number] [nvarchar](50) NOT NULL,
	[counterparty_id] [int] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[status_date] [datetime] NOT NULL,
	[status_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
 CONSTRAINT [PK_Bid] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidProduct]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidProduct](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bid_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[product_count] [int] NOT NULL,
	[product_price] [int] NOT NULL,
 CONSTRAINT [PK_BidProduct] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Counterparty]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Counterparty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[inn] [nvarchar](15) NOT NULL,
	[kpp] [nvarchar](15) NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_counterparty] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CounterpartyAttrs]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CounterpartyAttrs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[counterparty_id] [int] NOT NULL,
	[attr_id] [int] NOT NULL,
	[attr_value] [nvarchar](50) NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_CounterpatryAttrs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dictionary]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dictionary](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entity_id] [int] NOT NULL,
	[term_name] [nvarchar](50) NOT NULL,
	[target] [nvarchar](max) NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_Dictionary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[action] [nvarchar](max) NOT NULL,
	[acttime] [datetime] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[type_id] [int] NOT NULL,
	[okei_id] [int] NOT NULL,
	[vendor_code] [nvarchar](50) NOT NULL,
	[recommended_price] [int] NOT NULL,
	[remainder] [int] NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductAttrs]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductAttrs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[attr_id] [int] NOT NULL,
	[attr_value] [nvarchar](50) NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_ProductAttrs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rolename] [varchar](50) NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[role_id] [int] NOT NULL,
	[deleted] [char](1) NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18.10.2020 21:31:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Bid_Counterparty] FOREIGN KEY([counterparty_id])
REFERENCES [dbo].[Counterparty] ([id])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Bid_Counterparty]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Bid_Dictionary] FOREIGN KEY([type_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Bid_Dictionary]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Bid_Status] FOREIGN KEY([status_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Bid_Status]
GO
ALTER TABLE [dbo].[BidProduct]  WITH CHECK ADD  CONSTRAINT [FK_BP_Bid] FOREIGN KEY([bid_id])
REFERENCES [dbo].[Bid] ([id])
GO
ALTER TABLE [dbo].[BidProduct] CHECK CONSTRAINT [FK_BP_Bid]
GO
ALTER TABLE [dbo].[BidProduct]  WITH CHECK ADD  CONSTRAINT [FK_BP_Product] FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[BidProduct] CHECK CONSTRAINT [FK_BP_Product]
GO
ALTER TABLE [dbo].[CounterpartyAttrs]  WITH CHECK ADD  CONSTRAINT [FK_CA_counterparty] FOREIGN KEY([counterparty_id])
REFERENCES [dbo].[Counterparty] ([id])
GO
ALTER TABLE [dbo].[CounterpartyAttrs] CHECK CONSTRAINT [FK_CA_counterparty]
GO
ALTER TABLE [dbo].[CounterpartyAttrs]  WITH CHECK ADD  CONSTRAINT [FK_CA_Dictionary] FOREIGN KEY([attr_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[CounterpartyAttrs] CHECK CONSTRAINT [FK_CA_Dictionary]
GO
ALTER TABLE [dbo].[Dictionary]  WITH CHECK ADD  CONSTRAINT [FK_Dictionary_Entity] FOREIGN KEY([entity_id])
REFERENCES [dbo].[Entity] ([id])
GO
ALTER TABLE [dbo].[Dictionary] CHECK CONSTRAINT [FK_Dictionary_Entity]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Dictionary] FOREIGN KEY([okei_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Dictionary]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Dictionary1] FOREIGN KEY([type_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Dictionary1]
GO
ALTER TABLE [dbo].[ProductAttrs]  WITH CHECK ADD  CONSTRAINT [FK_PA_Dictionary] FOREIGN KEY([attr_id])
REFERENCES [dbo].[Dictionary] ([id])
GO
ALTER TABLE [dbo].[ProductAttrs] CHECK CONSTRAINT [FK_PA_Dictionary]
GO
ALTER TABLE [dbo].[ProductAttrs]  WITH CHECK ADD  CONSTRAINT [FK_PA_Product] FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[ProductAttrs] CHECK CONSTRAINT [FK_PA_Product]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role] FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Users]
GO
