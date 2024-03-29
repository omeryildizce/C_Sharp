USE [master]
GO
/****** Object:  Database [ETrade_CSharp]    Script Date: 27.05.2022 13:50:05 ******/
CREATE DATABASE [ETrade_CSharp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ETrade_CSharp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ETrade_CSharp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ETrade_CSharp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ETrade_CSharp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ETrade_CSharp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ETrade_CSharp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ETrade_CSharp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET ARITHABORT OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ETrade_CSharp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ETrade_CSharp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ETrade_CSharp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ETrade_CSharp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET RECOVERY FULL 
GO
ALTER DATABASE [ETrade_CSharp] SET  MULTI_USER 
GO
ALTER DATABASE [ETrade_CSharp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ETrade_CSharp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ETrade_CSharp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ETrade_CSharp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ETrade_CSharp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ETrade_CSharp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ETrade_CSharp', N'ON'
GO
ALTER DATABASE [ETrade_CSharp] SET QUERY_STORE = OFF
GO
USE [ETrade_CSharp]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27.05.2022 13:50:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[StockAmount] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ETrade_CSharp] SET  READ_WRITE 
GO
