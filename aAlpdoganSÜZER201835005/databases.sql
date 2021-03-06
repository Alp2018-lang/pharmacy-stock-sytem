USE [master]
GO
/****** Object:  Database [Pharmacy store stock system]    Script Date: 5/1/2022 6:39:56 AM ******/
CREATE DATABASE [Pharmacy store stock system]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pharmacy store stock system', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pharmacy store stock system.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pharmacy store stock system_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pharmacy store stock system_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pharmacy store stock system] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pharmacy store stock system].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pharmacy store stock system] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pharmacy store stock system] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pharmacy store stock system] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pharmacy store stock system] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pharmacy store stock system] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pharmacy store stock system] SET  MULTI_USER 
GO
ALTER DATABASE [Pharmacy store stock system] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pharmacy store stock system] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pharmacy store stock system] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pharmacy store stock system] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pharmacy store stock system] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pharmacy store stock system] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Pharmacy store stock system] SET QUERY_STORE = OFF
GO
USE [Pharmacy store stock system]
GO
/****** Object:  Table [dbo].[parola]    Script Date: 5/1/2022 6:39:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parola](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nchar](10) NULL,
	[Sifre] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pharmacy]    Script Date: 5/1/2022 6:39:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pharmacy](
	[id] [nvarchar](50) NULL,
	[medicinename] [nvarchar](50) NULL,
	[medicinecompany] [nvarchar](50) NULL,
	[typeofthemedicine] [nvarchar](50) NULL,
	[stock] [nvarchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Pharmacy store stock system] SET  READ_WRITE 
GO
