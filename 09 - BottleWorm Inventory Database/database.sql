USE [master]
GO
/****** Object:  Database [BottleWorm]    Script Date: 6/28/2018 7:07:37 PM ******/
CREATE DATABASE [BottleWorm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BottleWorm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BottleWorm.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BottleWorm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BottleWorm_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BottleWorm] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BottleWorm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BottleWorm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BottleWorm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BottleWorm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BottleWorm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BottleWorm] SET ARITHABORT OFF 
GO
ALTER DATABASE [BottleWorm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BottleWorm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BottleWorm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BottleWorm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BottleWorm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BottleWorm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BottleWorm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BottleWorm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BottleWorm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BottleWorm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BottleWorm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BottleWorm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BottleWorm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BottleWorm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BottleWorm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BottleWorm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BottleWorm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BottleWorm] SET RECOVERY FULL 
GO
ALTER DATABASE [BottleWorm] SET  MULTI_USER 
GO
ALTER DATABASE [BottleWorm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BottleWorm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BottleWorm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BottleWorm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BottleWorm] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BottleWorm', N'ON'
GO
ALTER DATABASE [BottleWorm] SET QUERY_STORE = OFF
GO
USE [BottleWorm]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BottleWorm]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 6/28/2018 7:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NOT NULL,
	[AddressTypeId] [int] NOT NULL,
	[Street1] [nvarchar](50) NOT NULL,
	[Street2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[Zipcode] [int] NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AddressType]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AddressType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyingGroups]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyingGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BuyingGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DriverLisenceNumber] [int] NOT NULL,
	[Zipcode] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DistributionGroups]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DistributionGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistributorsId] [int] NOT NULL,
	[BuyingGroupsId] [int] NOT NULL,
 CONSTRAINT [PK_DistributionGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DistributorInventory]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DistributorInventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[DistributorsId] [int] NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_DistributorInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distributors]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distributors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistributionGroupsId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
	[LisenceNumber] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Balance] [money] NOT NULL,
 CONSTRAINT [PK_Distributors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeLocations]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeLocations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LocationId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeLocations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DriversLicense] [int] NOT NULL,
	[PhoneNumber] [int] NULL,
	[Wages] [money] NOT NULL,
	[IsEmployeed] [bit] NOT NULL,
	[Notes] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[IsManager] [bit] NOT NULL,
	[isClerk] [bit] NOT NULL,
	[IsOwner] [bit] NOT NULL,
	[isFullTime] [bit] NOT NULL,
	[IsPartTIme] [bit] NOT NULL,
 CONSTRAINT [PK_EmployeeType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InventorySpecialsId] [int] NOT NULL,
	[InventoryTypeId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Brand] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[OnHandCount] [int] NOT NULL,
	[ProductSize] [nvarchar](50) NULL,
	[SalesPrice] [money] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryGroup]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InventoryGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventorySpecials]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventorySpecials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SpecialsId] [int] NOT NULL,
	[DiscountPercent] [decimal](18, 0) NOT NULL,
	[RestrictionCount] [int] NOT NULL,
 CONSTRAINT [PK_InventorySpecials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryType]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InventoryGroupId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InventoryType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LineItems]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [int] NOT NULL,
	[InventoryId] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_LineItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StoreNumber] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [int] NULL,
	[SquareFootage] [decimal](18, 0) NULL,
	[HasFreezer] [bit] NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 6/28/2018 7:07:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[Id] [int] NOT NULL,
	[TransactionId] [int] NOT NULL,
	[CardNumber] [int] NULL,
	[IsGiftcard] [bit] NOT NULL,
	[Cash] [int] NULL,
	[IsPayPal] [bit] NOT NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specials]    Script Date: 6/28/2018 7:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LocationId] [int] NOT NULL,
	[TransactionsId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Specials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 6/28/2018 7:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Timecards]    Script Date: 6/28/2018 7:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timecards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LocationId] [int] NOT NULL,
	[ClockInTime] [datetime2](7) NOT NULL,
	[ClockOutTime] [datetime2](7) NULL,
 CONSTRAINT [PK_Timecards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 6/28/2018 7:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[LocationId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[SpecialsId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[TotalPrice] [money] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionStatus]    Script Date: 6/28/2018 7:07:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [int] NOT NULL,
	[IsDeclined] [bit] NOT NULL,
	[IsPending] [bit] NOT NULL,
	[IsCancelled] [bit] NOT NULL,
	[IsSuccess] [bit] NOT NULL,
 CONSTRAINT [PK_TransactionStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_AddressType] FOREIGN KEY([AddressTypeId])
REFERENCES [dbo].[AddressType] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_AddressType]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_State] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_State]
GO
ALTER TABLE [dbo].[DistributionGroups]  WITH CHECK ADD  CONSTRAINT [FK_DistributionGroups_BuyingGroups] FOREIGN KEY([BuyingGroupsId])
REFERENCES [dbo].[BuyingGroups] ([Id])
GO
ALTER TABLE [dbo].[DistributionGroups] CHECK CONSTRAINT [FK_DistributionGroups_BuyingGroups]
GO
ALTER TABLE [dbo].[DistributorInventory]  WITH CHECK ADD  CONSTRAINT [FK_DistributorInventory_Distributors] FOREIGN KEY([DistributorsId])
REFERENCES [dbo].[Distributors] ([Id])
GO
ALTER TABLE [dbo].[DistributorInventory] CHECK CONSTRAINT [FK_DistributorInventory_Distributors]
GO
ALTER TABLE [dbo].[DistributorInventory]  WITH CHECK ADD  CONSTRAINT [FK_DistributorInventory_Inventory] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[Inventory] ([Id])
GO
ALTER TABLE [dbo].[DistributorInventory] CHECK CONSTRAINT [FK_DistributorInventory_Inventory]
GO
ALTER TABLE [dbo].[Distributors]  WITH CHECK ADD  CONSTRAINT [FK_Distributors_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[Distributors] CHECK CONSTRAINT [FK_Distributors_Addresses]
GO
ALTER TABLE [dbo].[Distributors]  WITH CHECK ADD  CONSTRAINT [FK_Distributors_DistributionGroups] FOREIGN KEY([DistributionGroupsId])
REFERENCES [dbo].[DistributionGroups] ([Id])
GO
ALTER TABLE [dbo].[Distributors] CHECK CONSTRAINT [FK_Distributors_DistributionGroups]
GO
ALTER TABLE [dbo].[EmployeeLocations]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeLocations_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[EmployeeLocations] CHECK CONSTRAINT [FK_EmployeeLocations_Employees]
GO
ALTER TABLE [dbo].[EmployeeLocations]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeLocations_Locations] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([Id])
GO
ALTER TABLE [dbo].[EmployeeLocations] CHECK CONSTRAINT [FK_EmployeeLocations_Locations]
GO
ALTER TABLE [dbo].[EmployeeType]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeType_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[EmployeeType] CHECK CONSTRAINT [FK_EmployeeType_Employees]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_InventorySpecials] FOREIGN KEY([InventorySpecialsId])
REFERENCES [dbo].[InventorySpecials] ([Id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_InventorySpecials]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_InventoryType] FOREIGN KEY([InventoryTypeId])
REFERENCES [dbo].[InventoryType] ([Id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_InventoryType]
GO
ALTER TABLE [dbo].[InventorySpecials]  WITH CHECK ADD  CONSTRAINT [FK_InventorySpecials_Specials] FOREIGN KEY([SpecialsId])
REFERENCES [dbo].[Specials] ([Id])
GO
ALTER TABLE [dbo].[InventorySpecials] CHECK CONSTRAINT [FK_InventorySpecials_Specials]
GO
ALTER TABLE [dbo].[InventoryType]  WITH CHECK ADD  CONSTRAINT [FK_InventoryType_InventoryGroup] FOREIGN KEY([InventoryGroupId])
REFERENCES [dbo].[InventoryGroup] ([Id])
GO
ALTER TABLE [dbo].[InventoryType] CHECK CONSTRAINT [FK_InventoryType_InventoryGroup]
GO
ALTER TABLE [dbo].[LineItems]  WITH CHECK ADD  CONSTRAINT [FK_LineItems_Inventory] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[Inventory] ([Id])
GO
ALTER TABLE [dbo].[LineItems] CHECK CONSTRAINT [FK_LineItems_Inventory]
GO
ALTER TABLE [dbo].[LineItems]  WITH CHECK ADD  CONSTRAINT [FK_LineItems_Transactions] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transactions] ([Id])
GO
ALTER TABLE [dbo].[LineItems] CHECK CONSTRAINT [FK_LineItems_Transactions]
GO
ALTER TABLE [dbo].[PaymentMethods]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethods_Transactions] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transactions] ([Id])
GO
ALTER TABLE [dbo].[PaymentMethods] CHECK CONSTRAINT [FK_PaymentMethods_Transactions]
GO
ALTER TABLE [dbo].[Specials]  WITH CHECK ADD  CONSTRAINT [FK_Specials_Locations] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([Id])
GO
ALTER TABLE [dbo].[Specials] CHECK CONSTRAINT [FK_Specials_Locations]
GO
ALTER TABLE [dbo].[Specials]  WITH CHECK ADD  CONSTRAINT [FK_Specials_Transactions] FOREIGN KEY([TransactionsId])
REFERENCES [dbo].[Transactions] ([Id])
GO
ALTER TABLE [dbo].[Specials] CHECK CONSTRAINT [FK_Specials_Transactions]
GO
ALTER TABLE [dbo].[Timecards]  WITH CHECK ADD  CONSTRAINT [FK_Timecards_Locations] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([Id])
GO
ALTER TABLE [dbo].[Timecards] CHECK CONSTRAINT [FK_Timecards_Locations]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Customers]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Locations] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([Id])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Locations]
GO
ALTER TABLE [dbo].[TransactionStatus]  WITH CHECK ADD  CONSTRAINT [FK_TransactionStatus_Transactions] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transactions] ([Id])
GO
ALTER TABLE [dbo].[TransactionStatus] CHECK CONSTRAINT [FK_TransactionStatus_Transactions]
GO
USE [master]
GO
ALTER DATABASE [BottleWorm] SET  READ_WRITE 
GO
