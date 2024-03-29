USE [master]
GO
/****** Object:  Database [yapimalzemeleri]    Script Date: 31.12.2022 19:35:08 ******/
CREATE DATABASE [yapimalzemeleri]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'yapimalzemeleri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\yapimalzemeleri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'yapimalzemeleri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\yapimalzemeleri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [yapimalzemeleri] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [yapimalzemeleri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [yapimalzemeleri] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET ARITHABORT OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [yapimalzemeleri] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [yapimalzemeleri] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET  DISABLE_BROKER 
GO
ALTER DATABASE [yapimalzemeleri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [yapimalzemeleri] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [yapimalzemeleri] SET  MULTI_USER 
GO
ALTER DATABASE [yapimalzemeleri] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [yapimalzemeleri] SET DB_CHAINING OFF 
GO
ALTER DATABASE [yapimalzemeleri] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [yapimalzemeleri] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [yapimalzemeleri] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [yapimalzemeleri] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [yapimalzemeleri] SET QUERY_STORE = OFF
GO
USE [yapimalzemeleri]
GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 31.12.2022 19:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdminTc] [numeric](18, 0) NOT NULL,
	[AdminSifre] [varchar](max) NOT NULL,
 CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciTable]    Script Date: 31.12.2022 19:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](50) NOT NULL,
	[KullaniciSifre] [varchar](max) NOT NULL,
	[KullaniciTelefon] [nvarchar](50) NOT NULL,
	[KullaniciTc] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_KullaniciTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparislerTable]    Script Date: 31.12.2022 19:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparislerTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciId] [int] NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[UrunAdi] [nvarchar](500) NOT NULL,
	[Tutar] [int] NOT NULL,
 CONSTRAINT [PK_SiparislerTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunTable]    Script Date: 31.12.2022 19:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunTable](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [nvarchar](50) NOT NULL,
	[Fiyat] [int] NOT NULL,
 CONSTRAINT [PK_UrunTable] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminTable] ON 

INSERT [dbo].[AdminTable] ([Id], [AdminTc], [AdminSifre]) VALUES (1, CAST(43333503756 AS Numeric(18, 0)), N'4949')
SET IDENTITY_INSERT [dbo].[AdminTable] OFF
GO
SET IDENTITY_INSERT [dbo].[KullaniciTable] ON 

INSERT [dbo].[KullaniciTable] ([Id], [KullaniciAd], [KullaniciSifre], [KullaniciTelefon], [KullaniciTc]) VALUES (1, N'Ömer', N'4949', N'(0505) 986-3923', CAST(11111111111 AS Numeric(18, 0)))
INSERT [dbo].[KullaniciTable] ([Id], [KullaniciAd], [KullaniciSifre], [KullaniciTelefon], [KullaniciTc]) VALUES (14, N'mustafa', N'2525', N'(8888) 888-8888', CAST(88888888888 AS Numeric(18, 0)))
INSERT [dbo].[KullaniciTable] ([Id], [KullaniciAd], [KullaniciSifre], [KullaniciTelefon], [KullaniciTc]) VALUES (1007, N'emin', N'6363', N'(3333) 333-3333', CAST(33333333333 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[KullaniciTable] OFF
GO
SET IDENTITY_INSERT [dbo].[SiparislerTable] ON 

INSERT [dbo].[SiparislerTable] ([Id], [KullaniciId], [KullaniciAdi], [UrunAdi], [Tutar]) VALUES (48, 1, N'ömer', N'10luk Çivi , Sekizlik Çivi , Cam Çivi , Tel Çivi , Çelik ÇiVİ , ', 190)
INSERT [dbo].[SiparislerTable] ([Id], [KullaniciId], [KullaniciAdi], [UrunAdi], [Tutar]) VALUES (55, 14, N'mustafa', N'Dış Cephe Boya , 10luk Çivi , Tel Çivi , ', 195)
INSERT [dbo].[SiparislerTable] ([Id], [KullaniciId], [KullaniciAdi], [UrunAdi], [Tutar]) VALUES (1052, 1007, N'emin', N'Beton Çivisi , Beton Çivisi , Beton Çivisi , ', 60)
INSERT [dbo].[SiparislerTable] ([Id], [KullaniciId], [KullaniciAdi], [UrunAdi], [Tutar]) VALUES (2052, 1, N'Ömer', N'Dış Cephe Boya , Cam Çivi , Derz Dolgu , ', 433)
SET IDENTITY_INSERT [dbo].[SiparislerTable] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunTable] ON 

INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (1, N'Kireç Taşı', 144)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (2, N'İç Cephe Boya', 256)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (3, N'Astar', 758)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (4, N'Ahşap Boya', 245)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (5, N'Dış Cephe Boya', 135)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (6, N'Beton Çivisi', 20)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (7, N'10luk Çivi', 10)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (8, N'Sekizlik Çivi', 30)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (9, N'Cam Çivi', 40)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (10, N'Tel Çivi', 50)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (11, N'Çelik ÇiVİ', 60)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (12, N'Kalekim', 150)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (14, N'Derz Dolgu', 258)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (15, N'Çimento', 240)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (16, N'Hazır Sıva Harcı', 135)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (17, N'Alçı Harcı', 175)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (18, N'Saten Harç', 149)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (19, N'Banyo Seramik', 250)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (20, N'Duvar Seramik', 350)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (21, N'Havuz Seramik', 450)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (22, N'Zemin Seramik', 550)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (23, N'Mutfak Seramik', 650)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (27, N'İzo Tuğla', 25)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (28, N'Tomson Tuğla', 35)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (29, N'Baca Tuğla', 45)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (30, N'Yığma Tuğla', 55)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (33, N'25lik Tuğla', 65)
INSERT [dbo].[UrunTable] ([UrunId], [UrunAd], [Fiyat]) VALUES (34, N'Yatay Tuğla', 80)
SET IDENTITY_INSERT [dbo].[UrunTable] OFF
GO
USE [master]
GO
ALTER DATABASE [yapimalzemeleri] SET  READ_WRITE 
GO
