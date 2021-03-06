USE [master]
GO
/****** Object:  Database [VirtualCollege]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE DATABASE [VirtualCollege]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VirtualCollege', FILENAME = N'/var/opt/mssql/data/VirtualCollege.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VirtualCollege_log', FILENAME = N'/var/opt/mssql/data/VirtualCollege_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VirtualCollege] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VirtualCollege].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VirtualCollege] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VirtualCollege] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VirtualCollege] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VirtualCollege] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VirtualCollege] SET ARITHABORT OFF 
GO
ALTER DATABASE [VirtualCollege] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VirtualCollege] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VirtualCollege] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VirtualCollege] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VirtualCollege] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VirtualCollege] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VirtualCollege] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VirtualCollege] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VirtualCollege] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VirtualCollege] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VirtualCollege] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VirtualCollege] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VirtualCollege] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VirtualCollege] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VirtualCollege] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VirtualCollege] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VirtualCollege] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VirtualCollege] SET RECOVERY FULL 
GO
ALTER DATABASE [VirtualCollege] SET  MULTI_USER 
GO
ALTER DATABASE [VirtualCollege] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VirtualCollege] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VirtualCollege] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VirtualCollege] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VirtualCollege] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VirtualCollege', N'ON'
GO
ALTER DATABASE [VirtualCollege] SET QUERY_STORE = OFF
GO
USE [VirtualCollege]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AddressLine1] [nvarchar](max) NOT NULL,
	[AddressLine2] [nvarchar](max) NULL,
	[AddressLine3] [nvarchar](max) NULL,
	[PinCodeID] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DistrictID] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[Mobile] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[AddressID] [int] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Semester] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StateID] [int] NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Document]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Document](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IsMedia] [bit] NOT NULL,
	[IsAccepted] [bit] NOT NULL,
	[AcceptedById] [int] NULL,
	[DateTime] [datetime2](7) NOT NULL,
	[Data] [nvarchar](max) NOT NULL,
	[DocumentType] [nvarchar](max) NOT NULL,
	[MemberID] [int] NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[isActive] [bit] NOT NULL,
	[DateOfJoining] [datetime2](7) NOT NULL,
	[DateOfLeaving] [datetime2](7) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[MiddleName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[MemberId] [int] NULL,
	[PinCodeID] [int] NULL,
	[StateID] [int] NULL,
	[DateOfBirth] [datetime2](7) NULL,
	[Gender] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PinCode]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PinCode](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pincode] [int] NOT NULL,
	[CityID] [int] NULL,
 CONSTRAINT [PK_PinCode] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relative]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relative](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Relation] [int] NOT NULL,
	[ContactID] [int] NULL,
	[PersonID] [int] NULL,
 CONSTRAINT [PK_Relative] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Remark]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Remark](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NULL,
	[GivenByID] [int] NULL,
	[Rating] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Remark] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [int] NOT NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SemesterData]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemesterData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentDataId] [int] NULL,
 CONSTRAINT [PK_SemesterData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentData]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NULL,
	[SectionId] [int] NULL,
 CONSTRAINT [PK_StudentData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 1/3/2020 7:59:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NULL,
	[StudentDataId] [int] NULL,
	[SectionId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Address_PinCodeID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Address_PinCodeID] ON [dbo].[Address]
(
	[PinCodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Admin_MemberID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Admin_MemberID] ON [dbo].[Admin]
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_City_DistrictID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_City_DistrictID] ON [dbo].[City]
(
	[DistrictID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contacts_AddressID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Contacts_AddressID] ON [dbo].[Contacts]
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contacts_PersonId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Contacts_PersonId] ON [dbo].[Contacts]
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_District_StateID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_District_StateID] ON [dbo].[District]
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Document_AcceptedById]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Document_AcceptedById] ON [dbo].[Document]
(
	[AcceptedById] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Document_MemberID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Document_MemberID] ON [dbo].[Document]
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_People_MemberId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_People_MemberId] ON [dbo].[People]
(
	[MemberId] ASC
)
WHERE ([MemberId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_People_PinCodeID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_People_PinCodeID] ON [dbo].[People]
(
	[PinCodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_People_StateID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_People_StateID] ON [dbo].[People]
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PinCode_CityID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_PinCode_CityID] ON [dbo].[PinCode]
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Relative_ContactID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Relative_ContactID] ON [dbo].[Relative]
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Relative_PersonID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Relative_PersonID] ON [dbo].[Relative]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Remark_GivenByID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Remark_GivenByID] ON [dbo].[Remark]
(
	[GivenByID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Remark_PersonID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Remark_PersonID] ON [dbo].[Remark]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SemesterData_StudentDataId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_SemesterData_StudentDataId] ON [dbo].[SemesterData]
(
	[StudentDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudentData_CourseId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudentData_CourseId] ON [dbo].[StudentData]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudentData_SectionId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudentData_SectionId] ON [dbo].[StudentData]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_MemberID]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Students_MemberID] ON [dbo].[Students]
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_SectionId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Students_SectionId] ON [dbo].[Students]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_StudentDataId]    Script Date: 1/3/2020 7:59:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_Students_StudentDataId] ON [dbo].[Students]
(
	[StudentDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[People] ADD  DEFAULT ((0)) FOR [Gender]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_PinCode_PinCodeID] FOREIGN KEY([PinCodeID])
REFERENCES [dbo].[PinCode] ([ID])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_PinCode_PinCodeID]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Members_MemberID] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Members_MemberID]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_District_DistrictID] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[District] ([ID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_District_DistrictID]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Address_AddressID] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([ID])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Address_AddressID]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_People_PersonId] FOREIGN KEY([PersonId])
REFERENCES [dbo].[People] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_People_PersonId]
GO
ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_State_StateID] FOREIGN KEY([StateID])
REFERENCES [dbo].[State] ([ID])
GO
ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_State_StateID]
GO
ALTER TABLE [dbo].[Document]  WITH CHECK ADD  CONSTRAINT [FK_Document_Admin_AcceptedById] FOREIGN KEY([AcceptedById])
REFERENCES [dbo].[Admin] ([Id])
GO
ALTER TABLE [dbo].[Document] CHECK CONSTRAINT [FK_Document_Admin_AcceptedById]
GO
ALTER TABLE [dbo].[Document]  WITH CHECK ADD  CONSTRAINT [FK_Document_Members_MemberID] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Document] CHECK CONSTRAINT [FK_Document_Members_MemberID]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Members_MemberId] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Members_MemberId]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_PinCode_PinCodeID] FOREIGN KEY([PinCodeID])
REFERENCES [dbo].[PinCode] ([ID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_PinCode_PinCodeID]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_State_StateID] FOREIGN KEY([StateID])
REFERENCES [dbo].[State] ([ID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_State_StateID]
GO
ALTER TABLE [dbo].[PinCode]  WITH CHECK ADD  CONSTRAINT [FK_PinCode_City_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([ID])
GO
ALTER TABLE [dbo].[PinCode] CHECK CONSTRAINT [FK_PinCode_City_CityID]
GO
ALTER TABLE [dbo].[Relative]  WITH CHECK ADD  CONSTRAINT [FK_Relative_Contacts_ContactID] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contacts] ([ID])
GO
ALTER TABLE [dbo].[Relative] CHECK CONSTRAINT [FK_Relative_Contacts_ContactID]
GO
ALTER TABLE [dbo].[Relative]  WITH CHECK ADD  CONSTRAINT [FK_Relative_People_PersonID] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Relative] CHECK CONSTRAINT [FK_Relative_People_PersonID]
GO
ALTER TABLE [dbo].[Remark]  WITH CHECK ADD  CONSTRAINT [FK_Remark_Members_GivenByID] FOREIGN KEY([GivenByID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Remark] CHECK CONSTRAINT [FK_Remark_Members_GivenByID]
GO
ALTER TABLE [dbo].[Remark]  WITH CHECK ADD  CONSTRAINT [FK_Remark_People_PersonID] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Remark] CHECK CONSTRAINT [FK_Remark_People_PersonID]
GO
ALTER TABLE [dbo].[SemesterData]  WITH CHECK ADD  CONSTRAINT [FK_SemesterData_StudentData_StudentDataId] FOREIGN KEY([StudentDataId])
REFERENCES [dbo].[StudentData] ([Id])
GO
ALTER TABLE [dbo].[SemesterData] CHECK CONSTRAINT [FK_SemesterData_StudentData_StudentDataId]
GO
ALTER TABLE [dbo].[StudentData]  WITH CHECK ADD  CONSTRAINT [FK_StudentData_Course_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[StudentData] CHECK CONSTRAINT [FK_StudentData_Course_CourseId]
GO
ALTER TABLE [dbo].[StudentData]  WITH CHECK ADD  CONSTRAINT [FK_StudentData_Section_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Section] ([Id])
GO
ALTER TABLE [dbo].[StudentData] CHECK CONSTRAINT [FK_StudentData_Section_SectionId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Members_MemberID] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Members_MemberID]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Section_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Section] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Section_SectionId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_StudentData_StudentDataId] FOREIGN KEY([StudentDataId])
REFERENCES [dbo].[StudentData] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_StudentData_StudentDataId]
GO
USE [master]
GO
ALTER DATABASE [VirtualCollege] SET  READ_WRITE 
GO
