USE [master]
GO

/****** Object:  Database [LevelUp]    Script Date: 22/10/2013 4:58:01 p.m. ******/
CREATE DATABASE [LevelUp]
 ON  PRIMARY 
( NAME = N'DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LevelUp.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LevelUp_log.ldf' , SIZE = 1792KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [LevelUp] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
BEGIN
EXEC [LevelUp].[dbo].[sp_fulltext_database] @action = 'enable'
END
GO

ALTER DATABASE [LevelUp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LevelUp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LevelUp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LevelUp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LevelUp] SET ARITHABORT OFF 
GO
ALTER DATABASE [LevelUp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LevelUp] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LevelUp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LevelUp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LevelUp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LevelUp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LevelUp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LevelUp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LevelUp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LevelUp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LevelUp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LevelUp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LevelUp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LevelUp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LevelUp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LevelUp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LevelUp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LevelUp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LevelUp] SET RECOVERY FULL 
GO
ALTER DATABASE [LevelUp] SET  MULTI_USER 
GO
ALTER DATABASE [LevelUp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LevelUp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LevelUp] SET  READ_WRITE 
GO

USE [LevelUp]
GO

/****** Object:  Table [dbo].[Ciudad]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[fk_idProvincia] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContactosPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContactosPorUsuario](
	[fk_idTipoContacto] [int] NOT NULL,
	[fk_idUsuario] [int] NOT NULL,
	[Valor] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[idContrato] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NULL,
	[fk_idPuesto] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[fk_idCreador] [int] NOT NULL,
	[fk_idUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[idContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[idDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[idDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Direccion](
	[idDireccion] [int] IDENTITY(1,1) NOT NULL,
	[fk_idCiudad] [int] NOT NULL,
	[Señal1] [varchar](200) NOT NULL,
	[Señal2] [varchar](200) NULL,
	[ZipCode] [varchar](50) NULL,
	[Latitud] [varchar](50) NULL,
	[Longitud] [varchar](50) NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DireccionesPorInstitucion]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DireccionesPorInstitucion](
	[fk_idDireccion] [int] NOT NULL,
	[fk_idInstitucion] [int] NOT NULL,
	[Detalle] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DireccionesPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DireccionesPorUsuario](
	[fk_idDireccion] [int] NOT NULL,
	[fk_idUsuario] [int] NOT NULL,
	[Detalle] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoLogro]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoLogro](
	[idEstadoLogro] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoLogro] PRIMARY KEY CLUSTERED 
(
	[idEstadoLogro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoPremio]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoPremio](
	[idEstadoPremio] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoPremio] PRIMARY KEY CLUSTERED 
(
	[idEstadoPremio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoRegla]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoRegla](
	[idEstadoRegla] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoRegla] PRIMARY KEY CLUSTERED 
(
	[idEstadoRegla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoUsuario](
	[idEstadoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoUsuario] PRIMARY KEY CLUSTERED 
(
	[idEstadoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evento](
	[idEvento] [int] IDENTITY(1,1) NOT NULL,
	[fk_idUsuario] [int] NOT NULL,
	[fk_idSeveridad] [int] NOT NULL,
	[fk_idModulo] [int] NOT NULL,
	[fk_idTipoEvento] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Referencia1] [int] NULL,
	[Referencia2] [int] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genero](
	[idGenero] [int] IDENTITY(1,1) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[idGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GruposDeUsuarios]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GruposDeUsuarios](
	[idGrupoDeUsuarios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_GruposDeUsuarios] PRIMARY KEY CLUSTERED 
(
	[idGrupoDeUsuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Institucion]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Institucion](
	[idInstitucion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Institucion] PRIMARY KEY CLUSTERED 
(
	[idInstitucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Logros]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Logros](
	[idLogro] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NULL,
	[fk_idCreador] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[NumMaximo] [int] NULL,
	[fk_idEstadoLogro] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[EsGlobal] [bit] NOT NULL,
 CONSTRAINT [PK_Logros] PRIMARY KEY CLUSTERED 
(
	[idLogro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogrosPorDepartamento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogrosPorDepartamento](
	[fk_idLogro] [int] NOT NULL,
	[fk_idDepartamento] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LogrosPorRegla]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogrosPorRegla](
	[fk_Logro] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[fk_idRegla] [int] NOT NULL,
	[fk_idCreador] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LogrosPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogrosPorUsuario](
	[fk_idUsuario] [int] NOT NULL,
	[fk_idLogro] [int] NOT NULL,
	[Detalles] [varchar](200) NULL,
	[fk_idCreador] [int] NOT NULL,
	[FechaObtencion] [date] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modulo](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Modulo] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Moneda](
	[idMoneda] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Simbolo] [nchar](1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED 
(
	[idMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[idPais] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](70) NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permisos](
	[idPermiso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Codigo] [varchar](100) NOT NULL,
	[BinaryMap] [varchar](200) NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PermisosPorGrupo]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosPorGrupo](
	[fk_idGrupo] [int] NOT NULL,
	[fk_idPermiso] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PermisosPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosPorUsuario](
	[fk_idUsuario] [int] NOT NULL,
	[fk_idPermiso] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Premio]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Premio](
	[idPremio] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](200) NOT NULL,
	[Descripcion] [varchar](700) NULL,
	[Foto] [varchar](200) NULL,
	[Cantidad] [int] NULL,
	[Monto] [float] NULL,
	[fk_idMoneda] [int] NOT NULL,
	[fk_idTipoPremio] [int] NOT NULL,
	[fk_idCreador] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[fk_idEstadoPremio] [int] NOT NULL,
	[EsGlobal] [bit] NOT NULL,
 CONSTRAINT [PK_Premios] PRIMARY KEY CLUSTERED 
(
	[idPremio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PremiosPorDepartamento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PremiosPorDepartamento](
	[fk_idPremio] [int] NOT NULL,
	[fk_idDepartamento] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PremiosPorRegla]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PremiosPorRegla](
	[fk_idPremio] [int] NOT NULL,
	[fk_idRegla] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PremiosPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PremiosPorUsuario](
	[fk_idUsuario] [int] NOT NULL,
	[fk_idPremio] [int] NOT NULL,
	[FechaObtencion] [date] NOT NULL,
	[FechaRetiro] [date] NULL,
	[fk_idConcededor] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[idProvincia] [int] IDENTITY(1,1) NOT NULL,
	[fk_idPais] [int] NOT NULL,
	[Nombre] [varchar](70) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[idProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Puestos](
	[idPuesto] [int] IDENTITY(1,1) NOT NULL,
	[Puesto] [varchar](100) NOT NULL,
	[fk_idDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[idPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Regla]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Regla](
	[idRegla] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[fk_idEstadoRegla] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NULL,
	[fk_idCreador] [int] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Regla] PRIMARY KEY CLUSTERED 
(
	[idRegla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReglasPorDepartamento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReglasPorDepartamento](
	[fk_idRegla] [int] NOT NULL,
	[fk_idDepartamento] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Severidad]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Severidad](
	[idSeveridad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Severidad] PRIMARY KEY CLUSTERED 
(
	[idSeveridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TasaCambio]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TasaCambio](
	[fk_idMoneda1] [int] NOT NULL,
	[fk_idMoneda2] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[TasaCambio] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoContacto]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoContacto](
	[idTipoContacto] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoContacto] PRIMARY KEY CLUSTERED 
(
	[idTipoContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEvento](
	[idTipoEvento] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[idTipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPremio]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPremio](
	[idTipoPremio] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoPremio] PRIMARY KEY CLUSTERED 
(
	[idTipoPremio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Titulos]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Titulos](
	[idTitulo] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[GradoAcademico] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Titulos] PRIMARY KEY CLUSTERED 
(
	[idTitulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TitulosPorInstituciones]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TitulosPorInstituciones](
	[fk_idTitulo] [int] NOT NULL,
	[fk_idInstitucion] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TitulosPorUsuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TitulosPorUsuario](
	[fk_idTitulo] [int] NOT NULL,
	[fk_idUsuario] [int] NOT NULL,
	[fk_idInstitucion] [int] NOT NULL,
	[FechaObtencion] [date] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[fk_idCreador] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NULL,
	[Contraseña] [varchar](200) NOT NULL,
	[fk_idEstadoUsuario] [int] NOT NULL,
	[Username] [varchar](70) NOT NULL,
	[Foto] [varchar](200) NULL,
	[fk_idGenero] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UN_Username] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuariosPorGrupo]    Script Date: 24/10/2013 5:01:32 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosPorGrupo](
	[fk_idUsuario] [int] NOT NULL,
	[fk_idGrupo] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Logros] ADD  CONSTRAINT [DF_Logros_EsGlobal]  DEFAULT ((0)) FOR [EsGlobal]
GO
ALTER TABLE [dbo].[Premio] ADD  CONSTRAINT [DF_Premio_EsGlobal]  DEFAULT ((0)) FOR [EsGlobal]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Ciudad_Provincia] FOREIGN KEY([fk_idProvincia])
REFERENCES [dbo].[Provincia] ([idProvincia])
GO
ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [FK_Ciudad_Provincia]
GO
ALTER TABLE [dbo].[ContactosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_ContactosPorUsuario_TipoContacto] FOREIGN KEY([fk_idTipoContacto])
REFERENCES [dbo].[TipoContacto] ([idTipoContacto])
GO
ALTER TABLE [dbo].[ContactosPorUsuario] CHECK CONSTRAINT [FK_ContactosPorUsuario_TipoContacto]
GO
ALTER TABLE [dbo].[ContactosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_ContactosPorUsuario_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[ContactosPorUsuario] CHECK CONSTRAINT [FK_ContactosPorUsuario_Usuario]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Puestos] FOREIGN KEY([fk_idPuesto])
REFERENCES [dbo].[Puestos] ([idPuesto])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Puestos]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Usuario]
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD  CONSTRAINT [FK_Contratos_Usuario1] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Contratos] CHECK CONSTRAINT [FK_Contratos_Usuario1]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Ciudad] FOREIGN KEY([fk_idCiudad])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Ciudad]
GO
ALTER TABLE [dbo].[DireccionesPorInstitucion]  WITH CHECK ADD  CONSTRAINT [FK_DireccionesPorInstitucion_Direccion] FOREIGN KEY([fk_idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[DireccionesPorInstitucion] CHECK CONSTRAINT [FK_DireccionesPorInstitucion_Direccion]
GO
ALTER TABLE [dbo].[DireccionesPorInstitucion]  WITH CHECK ADD  CONSTRAINT [FK_DireccionesPorInstitucion_Institucion] FOREIGN KEY([fk_idInstitucion])
REFERENCES [dbo].[Institucion] ([idInstitucion])
GO
ALTER TABLE [dbo].[DireccionesPorInstitucion] CHECK CONSTRAINT [FK_DireccionesPorInstitucion_Institucion]
GO
ALTER TABLE [dbo].[DireccionesPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_DireccionesPorUsuario_Direccion] FOREIGN KEY([fk_idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[DireccionesPorUsuario] CHECK CONSTRAINT [FK_DireccionesPorUsuario_Direccion]
GO
ALTER TABLE [dbo].[DireccionesPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_DireccionesPorUsuario_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[DireccionesPorUsuario] CHECK CONSTRAINT [FK_DireccionesPorUsuario_Usuario]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Modulo] FOREIGN KEY([fk_idModulo])
REFERENCES [dbo].[Modulo] ([idModulo])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Modulo]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Severidad] FOREIGN KEY([fk_idSeveridad])
REFERENCES [dbo].[Severidad] ([idSeveridad])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Severidad]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_TipoEvento] FOREIGN KEY([fk_idTipoEvento])
REFERENCES [dbo].[TipoEvento] ([idTipoEvento])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_TipoEvento]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Usuario]
GO
ALTER TABLE [dbo].[Logros]  WITH CHECK ADD  CONSTRAINT [FK_Logros_EstadoLogro] FOREIGN KEY([fk_idEstadoLogro])
REFERENCES [dbo].[EstadoLogro] ([idEstadoLogro])
GO
ALTER TABLE [dbo].[Logros] CHECK CONSTRAINT [FK_Logros_EstadoLogro]
GO
ALTER TABLE [dbo].[Logros]  WITH CHECK ADD  CONSTRAINT [FK_Logros_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Logros] CHECK CONSTRAINT [FK_Logros_Usuario]
GO
ALTER TABLE [dbo].[LogrosPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorDepartamento_Departamento] FOREIGN KEY([fk_idDepartamento])
REFERENCES [dbo].[Departamento] ([idDepartamento])
GO
ALTER TABLE [dbo].[LogrosPorDepartamento] CHECK CONSTRAINT [FK_LogrosPorDepartamento_Departamento]
GO
ALTER TABLE [dbo].[LogrosPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorDepartamento_Logros] FOREIGN KEY([fk_idLogro])
REFERENCES [dbo].[Logros] ([idLogro])
GO
ALTER TABLE [dbo].[LogrosPorDepartamento] CHECK CONSTRAINT [FK_LogrosPorDepartamento_Logros]
GO
ALTER TABLE [dbo].[LogrosPorRegla]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorRegla_Logros] FOREIGN KEY([fk_Logro])
REFERENCES [dbo].[Logros] ([idLogro])
GO
ALTER TABLE [dbo].[LogrosPorRegla] CHECK CONSTRAINT [FK_LogrosPorRegla_Logros]
GO
ALTER TABLE [dbo].[LogrosPorRegla]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorRegla_Regla] FOREIGN KEY([fk_idRegla])
REFERENCES [dbo].[Regla] ([idRegla])
GO
ALTER TABLE [dbo].[LogrosPorRegla] CHECK CONSTRAINT [FK_LogrosPorRegla_Regla]
GO
ALTER TABLE [dbo].[LogrosPorRegla]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorRegla_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[LogrosPorRegla] CHECK CONSTRAINT [FK_LogrosPorRegla_Usuario]
GO
ALTER TABLE [dbo].[LogrosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorUsuario_Logros] FOREIGN KEY([fk_idLogro])
REFERENCES [dbo].[Logros] ([idLogro])
GO
ALTER TABLE [dbo].[LogrosPorUsuario] CHECK CONSTRAINT [FK_LogrosPorUsuario_Logros]
GO
ALTER TABLE [dbo].[LogrosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorUsuario_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[LogrosPorUsuario] CHECK CONSTRAINT [FK_LogrosPorUsuario_Usuario]
GO
ALTER TABLE [dbo].[LogrosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_LogrosPorUsuario_Usuario1] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[LogrosPorUsuario] CHECK CONSTRAINT [FK_LogrosPorUsuario_Usuario1]
GO
ALTER TABLE [dbo].[PermisosPorGrupo]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXGrupo_GruposDeUsuarios] FOREIGN KEY([fk_idGrupo])
REFERENCES [dbo].[GruposDeUsuarios] ([idGrupoDeUsuarios])
GO
ALTER TABLE [dbo].[PermisosPorGrupo] CHECK CONSTRAINT [FK_PermisosXGrupo_GruposDeUsuarios]
GO
ALTER TABLE [dbo].[PermisosPorGrupo]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXGrupo_Permisos] FOREIGN KEY([fk_idPermiso])
REFERENCES [dbo].[Permisos] ([idPermiso])
GO
ALTER TABLE [dbo].[PermisosPorGrupo] CHECK CONSTRAINT [FK_PermisosXGrupo_Permisos]
GO
ALTER TABLE [dbo].[PermisosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXUsuario_Permisos] FOREIGN KEY([fk_idPermiso])
REFERENCES [dbo].[Permisos] ([idPermiso])
GO
ALTER TABLE [dbo].[PermisosPorUsuario] CHECK CONSTRAINT [FK_PermisosXUsuario_Permisos]
GO
ALTER TABLE [dbo].[PermisosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PermisosXUsuario_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[PermisosPorUsuario] CHECK CONSTRAINT [FK_PermisosXUsuario_Usuario]
GO
ALTER TABLE [dbo].[Premio]  WITH CHECK ADD  CONSTRAINT [FK_Premio_EstadoPremio] FOREIGN KEY([fk_idEstadoPremio])
REFERENCES [dbo].[EstadoPremio] ([idEstadoPremio])
GO
ALTER TABLE [dbo].[Premio] CHECK CONSTRAINT [FK_Premio_EstadoPremio]
GO
ALTER TABLE [dbo].[Premio]  WITH CHECK ADD  CONSTRAINT [FK_Premio_Moneda] FOREIGN KEY([fk_idMoneda])
REFERENCES [dbo].[Moneda] ([idMoneda])
GO
ALTER TABLE [dbo].[Premio] CHECK CONSTRAINT [FK_Premio_Moneda]
GO
ALTER TABLE [dbo].[Premio]  WITH CHECK ADD  CONSTRAINT [FK_Premio_TipoPremio] FOREIGN KEY([fk_idTipoPremio])
REFERENCES [dbo].[TipoPremio] ([idTipoPremio])
GO
ALTER TABLE [dbo].[Premio] CHECK CONSTRAINT [FK_Premio_TipoPremio]
GO
ALTER TABLE [dbo].[Premio]  WITH CHECK ADD  CONSTRAINT [FK_Premio_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Premio] CHECK CONSTRAINT [FK_Premio_Usuario]
GO
ALTER TABLE [dbo].[PremiosPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorDepartamento_Departamento] FOREIGN KEY([fk_idDepartamento])
REFERENCES [dbo].[Departamento] ([idDepartamento])
GO
ALTER TABLE [dbo].[PremiosPorDepartamento] CHECK CONSTRAINT [FK_PremiosPorDepartamento_Departamento]
GO
ALTER TABLE [dbo].[PremiosPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorDepartamento_Premio] FOREIGN KEY([fk_idPremio])
REFERENCES [dbo].[Premio] ([idPremio])
GO
ALTER TABLE [dbo].[PremiosPorDepartamento] CHECK CONSTRAINT [FK_PremiosPorDepartamento_Premio]
GO
ALTER TABLE [dbo].[PremiosPorRegla]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorRegla_Premio] FOREIGN KEY([fk_idPremio])
REFERENCES [dbo].[Premio] ([idPremio])
GO
ALTER TABLE [dbo].[PremiosPorRegla] CHECK CONSTRAINT [FK_PremiosPorRegla_Premio]
GO
ALTER TABLE [dbo].[PremiosPorRegla]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorRegla_Regla] FOREIGN KEY([fk_idRegla])
REFERENCES [dbo].[Regla] ([idRegla])
GO
ALTER TABLE [dbo].[PremiosPorRegla] CHECK CONSTRAINT [FK_PremiosPorRegla_Regla]
GO
ALTER TABLE [dbo].[PremiosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorUsuario_Premio] FOREIGN KEY([fk_idPremio])
REFERENCES [dbo].[Premio] ([idPremio])
GO
ALTER TABLE [dbo].[PremiosPorUsuario] CHECK CONSTRAINT [FK_PremiosPorUsuario_Premio]
GO
ALTER TABLE [dbo].[PremiosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorUsuario_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[PremiosPorUsuario] CHECK CONSTRAINT [FK_PremiosPorUsuario_Usuario]
GO
ALTER TABLE [dbo].[PremiosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PremiosPorUsuario_Usuario1] FOREIGN KEY([fk_idConcededor])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[PremiosPorUsuario] CHECK CONSTRAINT [FK_PremiosPorUsuario_Usuario1]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY([fk_idPais])
REFERENCES [dbo].[Pais] ([idPais])
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Pais]
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD  CONSTRAINT [FK_Puestos_Departamento] FOREIGN KEY([fk_idDepartamento])
REFERENCES [dbo].[Departamento] ([idDepartamento])
GO
ALTER TABLE [dbo].[Puestos] CHECK CONSTRAINT [FK_Puestos_Departamento]
GO
ALTER TABLE [dbo].[Regla]  WITH CHECK ADD  CONSTRAINT [FK_Regla_EstadoRegla] FOREIGN KEY([fk_idEstadoRegla])
REFERENCES [dbo].[EstadoRegla] ([idEstadoRegla])
GO
ALTER TABLE [dbo].[Regla] CHECK CONSTRAINT [FK_Regla_EstadoRegla]
GO
ALTER TABLE [dbo].[Regla]  WITH CHECK ADD  CONSTRAINT [FK_Regla_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Regla] CHECK CONSTRAINT [FK_Regla_Usuario]
GO
ALTER TABLE [dbo].[ReglasPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_ReglasPorDepartamento_Departamento] FOREIGN KEY([fk_idDepartamento])
REFERENCES [dbo].[Departamento] ([idDepartamento])
GO
ALTER TABLE [dbo].[ReglasPorDepartamento] CHECK CONSTRAINT [FK_ReglasPorDepartamento_Departamento]
GO
ALTER TABLE [dbo].[ReglasPorDepartamento]  WITH CHECK ADD  CONSTRAINT [FK_ReglasPorDepartamento_Regla] FOREIGN KEY([fk_idRegla])
REFERENCES [dbo].[Regla] ([idRegla])
GO
ALTER TABLE [dbo].[ReglasPorDepartamento] CHECK CONSTRAINT [FK_ReglasPorDepartamento_Regla]
GO
ALTER TABLE [dbo].[TasaCambio]  WITH CHECK ADD  CONSTRAINT [FK_TasaCambio_Moneda] FOREIGN KEY([fk_idMoneda1])
REFERENCES [dbo].[Moneda] ([idMoneda])
GO
ALTER TABLE [dbo].[TasaCambio] CHECK CONSTRAINT [FK_TasaCambio_Moneda]
GO
ALTER TABLE [dbo].[TasaCambio]  WITH CHECK ADD  CONSTRAINT [FK_TasaCambio_Moneda1] FOREIGN KEY([fk_idMoneda2])
REFERENCES [dbo].[Moneda] ([idMoneda])
GO
ALTER TABLE [dbo].[TasaCambio] CHECK CONSTRAINT [FK_TasaCambio_Moneda1]
GO
ALTER TABLE [dbo].[TitulosPorInstituciones]  WITH CHECK ADD  CONSTRAINT [FK_TitulosPorInstituciones_Institucion] FOREIGN KEY([fk_idInstitucion])
REFERENCES [dbo].[Institucion] ([idInstitucion])
GO
ALTER TABLE [dbo].[TitulosPorInstituciones] CHECK CONSTRAINT [FK_TitulosPorInstituciones_Institucion]
GO
ALTER TABLE [dbo].[TitulosPorInstituciones]  WITH CHECK ADD  CONSTRAINT [FK_TitulosPorInstituciones_Titulos] FOREIGN KEY([fk_idTitulo])
REFERENCES [dbo].[Titulos] ([idTitulo])
GO
ALTER TABLE [dbo].[TitulosPorInstituciones] CHECK CONSTRAINT [FK_TitulosPorInstituciones_Titulos]
GO
ALTER TABLE [dbo].[TitulosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TitulosPorExpediente_Institucion] FOREIGN KEY([fk_idInstitucion])
REFERENCES [dbo].[Institucion] ([idInstitucion])
GO
ALTER TABLE [dbo].[TitulosPorUsuario] CHECK CONSTRAINT [FK_TitulosPorExpediente_Institucion]
GO
ALTER TABLE [dbo].[TitulosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_titulosPorexpediente_Titulos] FOREIGN KEY([fk_idTitulo])
REFERENCES [dbo].[Titulos] ([idTitulo])
GO
ALTER TABLE [dbo].[TitulosPorUsuario] CHECK CONSTRAINT [FK_titulosPorexpediente_Titulos]
GO
ALTER TABLE [dbo].[TitulosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TitulosPorExpediente_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[TitulosPorUsuario] CHECK CONSTRAINT [FK_TitulosPorExpediente_Usuario]
GO
ALTER TABLE [dbo].[TitulosPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TitulosPorUsuario_Usuario] FOREIGN KEY([fk_idCreador])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[TitulosPorUsuario] CHECK CONSTRAINT [FK_TitulosPorUsuario_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_EstadoUsuario] FOREIGN KEY([fk_idEstadoUsuario])
REFERENCES [dbo].[EstadoUsuario] ([idEstadoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_EstadoUsuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Genero] FOREIGN KEY([fk_idGenero])
REFERENCES [dbo].[Genero] ([idGenero])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Genero]
GO
ALTER TABLE [dbo].[UsuariosPorGrupo]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosXGrupo_GruposDeUsuarios] FOREIGN KEY([fk_idGrupo])
REFERENCES [dbo].[GruposDeUsuarios] ([idGrupoDeUsuarios])
GO
ALTER TABLE [dbo].[UsuariosPorGrupo] CHECK CONSTRAINT [FK_UsuariosXGrupo_GruposDeUsuarios]
GO
ALTER TABLE [dbo].[UsuariosPorGrupo]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosXGrupo_Usuario] FOREIGN KEY([fk_idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[UsuariosPorGrupo] CHECK CONSTRAINT [FK_UsuariosXGrupo_Usuario]
GO
