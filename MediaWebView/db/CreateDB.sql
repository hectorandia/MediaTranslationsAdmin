USE [master]
GO

/****** Object:  Database [MediaTranslations]    Script Date: 3/9/2017 17:36:16 ******/
CREATE DATABASE [MediaTranslations]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MediaTranslations', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MediaTranslations.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MediaTranslations_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MediaTranslations_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [MediaTranslations] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MediaTranslations].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MediaTranslations] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MediaTranslations] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MediaTranslations] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MediaTranslations] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MediaTranslations] SET ARITHABORT OFF 
GO

ALTER DATABASE [MediaTranslations] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MediaTranslations] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MediaTranslations] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MediaTranslations] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MediaTranslations] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MediaTranslations] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MediaTranslations] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MediaTranslations] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MediaTranslations] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MediaTranslations] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MediaTranslations] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MediaTranslations] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MediaTranslations] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MediaTranslations] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MediaTranslations] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MediaTranslations] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MediaTranslations] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MediaTranslations] SET RECOVERY FULL 
GO

ALTER DATABASE [MediaTranslations] SET  MULTI_USER 
GO

ALTER DATABASE [MediaTranslations] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MediaTranslations] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MediaTranslations] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MediaTranslations] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [MediaTranslations] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MediaTranslations] SET  READ_WRITE 
GO


