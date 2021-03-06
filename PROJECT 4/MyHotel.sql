USE [master]
GO
/****** Object:  Database [MyHotel]    Script Date: 06/10/2016 15:42:20 ******/
CREATE DATABASE [MyHotel] ON  PRIMARY 
( NAME = N'MyHotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.AREUS\MSSQL\DATA\MyHotel.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyHotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.AREUS\MSSQL\DATA\MyHotel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyHotel] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyHotel] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MyHotel] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MyHotel] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MyHotel] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MyHotel] SET ARITHABORT OFF
GO
ALTER DATABASE [MyHotel] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MyHotel] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MyHotel] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MyHotel] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MyHotel] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MyHotel] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MyHotel] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MyHotel] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MyHotel] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MyHotel] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MyHotel] SET  DISABLE_BROKER
GO
ALTER DATABASE [MyHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MyHotel] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MyHotel] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MyHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MyHotel] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MyHotel] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MyHotel] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MyHotel] SET  READ_WRITE
GO
ALTER DATABASE [MyHotel] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MyHotel] SET  MULTI_USER
GO
ALTER DATABASE [MyHotel] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MyHotel] SET DB_CHAINING OFF
GO
USE [MyHotel]
GO
/****** Object:  Table [dbo].[tb_transaction]    Script Date: 06/10/2016 15:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_transaction](
	[id_transaction] [varchar](4) NOT NULL,
	[id_customer] [varchar](4) NOT NULL,
	[id_room] [varchar](4) NOT NULL,
	[date_in] [date] NOT NULL,
	[days_of_stay] [int] NULL,
	[date_out] [date] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_tb_transaction] PRIMARY KEY CLUSTERED 
(
	[id_transaction] ASC,
	[id_customer] ASC,
	[id_room] ASC,
	[date_in] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_room]    Script Date: 06/10/2016 15:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_room](
	[id_room] [varchar](4) NOT NULL,
	[id_class] [varchar](50) NULL,
	[harga] [bigint] NULL,
	[staus] [varchar](50) NULL,
 CONSTRAINT [PK_tb_room] PRIMARY KEY CLUSTERED 
(
	[id_room] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_customer]    Script Date: 06/10/2016 15:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_customer](
	[id_customer] [varchar](4) NULL,
	[name] [varchar](50) NULL,
	[sex] [varchar](50) NULL,
	[id_type] [varchar](4) NULL,
	[id_number] [varchar](50) NULL,
	[number_telephone] [varchar](14) NULL,
	[address] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_class]    Script Date: 06/10/2016 15:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_class](
	[id_class] [varchar](4) NOT NULL,
	[name] [varchar](50) NULL,
	[price] [bigint] NULL,
	[bed_size] [varchar](50) NULL,
	[room_size] [varchar](50) NULL,
	[bathroom_type] [varchar](50) NULL,
	[room_feature] [varchar](50) NULL,
 CONSTRAINT [PK_tb_class] PRIMARY KEY CLUSTERED 
(
	[id_class] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_admin]    Script Date: 06/10/2016 15:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_admin](
	[id_admin] [varchar](4) NOT NULL,
	[nama] [varchar](50) NULL,
	[jenis_kelamin] [char](1) NULL,
	[alamat] [text] NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[status_admin] [char](1) NULL,
 CONSTRAINT [PK_tb_admin] PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
