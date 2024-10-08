USE [master]
GO
/****** Object:  Database [gallery]    Script Date: 15.08.2024 14:03:13 ******/
CREATE DATABASE [gallery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gallery', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\gallery.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gallery_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\gallery_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [gallery] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gallery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gallery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gallery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gallery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gallery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gallery] SET ARITHABORT OFF 
GO
ALTER DATABASE [gallery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gallery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gallery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gallery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gallery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gallery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gallery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gallery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gallery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gallery] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gallery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gallery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gallery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gallery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gallery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gallery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gallery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gallery] SET RECOVERY FULL 
GO
ALTER DATABASE [gallery] SET  MULTI_USER 
GO
ALTER DATABASE [gallery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gallery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gallery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gallery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gallery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gallery] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gallery', N'ON'
GO
ALTER DATABASE [gallery] SET QUERY_STORE = ON
GO
ALTER DATABASE [gallery] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [gallery]
GO
/****** Object:  UserDefinedFunction [dbo].[mcosttofail]    Script Date: 15.08.2024 14:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[mcosttofail](@scode varchar(30))
returns int
as
begin 
	declare @counter int = 0;
	declare @mcost int; 
	declare @price int;
	
	
	SELECT @mcost = c.MaintenanceCost, @price = s.Price
    FROM cost c
    JOIN stock s ON c.SerialCode = s.SerialCode
	WHERE c.SerialCode = @scode;
	if @price is not null AND @mcost is not null
		begin 
		while @price > 0
			begin
				set @price -= @mcost;
				set @counter += 1;
				
			end		
		end
	return @counter;
	
end;
GO
/****** Object:  Table [dbo].[cost]    Script Date: 15.08.2024 14:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cost](
	[SerialCode] [varchar](30) NOT NULL,
	[MaintenanceCost] [decimal](10, 2) NOT NULL,
	[AnnualCost] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 15.08.2024 14:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[Contact] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 15.08.2024 14:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SerialCode] [varchar](30) NOT NULL,
	[ReceiptCode] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 15.08.2024 14:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[SerialCode] [varchar](30) NOT NULL,
	[Brand] [varchar](30) NOT NULL,
	[Model] [varchar](30) NOT NULL,
	[CarYear] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[ArrivalDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SerialCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cost]  WITH CHECK ADD  CONSTRAINT [FK__cost__SerialCode__398D8EEE] FOREIGN KEY([SerialCode])
REFERENCES [dbo].[stock] ([SerialCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cost] CHECK CONSTRAINT [FK__cost__SerialCode__398D8EEE]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__Customer__3E52440B] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__Customer__3E52440B]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__SerialCo__3F466844] FOREIGN KEY([SerialCode])
REFERENCES [dbo].[stock] ([SerialCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__SerialCo__3F466844]
GO
USE [master]
GO
ALTER DATABASE [gallery] SET  READ_WRITE 
GO
