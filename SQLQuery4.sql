USE [Inmobiliaria]
GO
/****** Object:  Database [Inmobiliaria]    Script Date: 11/06/2021 18:58:21 ******/
CREATE DATABASE [Inmobiliaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Inmobiliaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Inmobiliaria.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Inmobiliaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Inmobiliaria_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Inmobiliaria] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inmobiliaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inmobiliaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Inmobiliaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Inmobiliaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Inmobiliaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Inmobiliaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Inmobiliaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inmobiliaria] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Inmobiliaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inmobiliaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inmobiliaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inmobiliaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Inmobiliaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Inmobiliaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inmobiliaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Inmobiliaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inmobiliaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Inmobiliaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inmobiliaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inmobiliaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inmobiliaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inmobiliaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inmobiliaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inmobiliaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Inmobiliaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Inmobiliaria] SET  MULTI_USER 
GO
ALTER DATABASE [Inmobiliaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inmobiliaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Inmobiliaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Inmobiliaria] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Inmobiliaria]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](30) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[IdTipoDoc] [int] NOT NULL,
	[NDoc] [int] NOT NULL,
	[FechaNac] [smalldatetime] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[IdLocalidad] [int] NOT NULL,
	[Cel] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Activo] [bit] NOT NULL,
	[Observaciones] [nvarchar](250) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grupos]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupos](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[Grupo] [nvarchar](15) NOT NULL,
	[Acceso] [int] NOT NULL,
 CONSTRAINT [PK_Grupos] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inmuebles]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inmuebles](
	[IdInmueble] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoInmueble] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Depto] [nvarchar](5) NULL,
	[Piso] [nvarchar](5) NULL,
	[IdLocalidad] [int] NOT NULL,
	[IdPropietario] [int] NOT NULL,
	[CantHab] [int] NOT NULL,
	[Cochera] [bit] NOT NULL,
	[Patio] [bit] NOT NULL,
	[Parrilla] [bit] NOT NULL,
	[Pileta] [bit] NOT NULL,
	[FechaAlta] [smalldatetime] NOT NULL,
	[TerrenoM2] [int] NOT NULL,
	[ConstruccionM2] [int] NOT NULL,
	[Valuacion] [money] NULL,
	[EnVenta] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Observaciones] [nvarchar](250) NULL,
 CONSTRAINT [PK_Inmuebles] PRIMARY KEY CLUSTERED 
(
	[IdInmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[CodigoPostal] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Operaciones]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operaciones](
	[IdOperacion] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoOperacion] [int] NOT NULL,
	[FechaDesde] [smalldatetime] NOT NULL,
	[IdInmueble] [int] NOT NULL,
	[IdDestinatario] [int] NULL,
	[Monto] [money] NULL,
	[FechaHasta] [smalldatetime] NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_Operaciones] PRIMARY KEY CLUSTERED 
(
	[IdOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TiposDocs]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDocs](
	[IdTipoDoc] [int] IDENTITY(1,1) NOT NULL,
	[TipoDoc] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_TiposDocs] PRIMARY KEY CLUSTERED 
(
	[IdTipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TiposInmuebles]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposInmuebles](
	[IdTipoInmueble] [int] IDENTITY(1,1) NOT NULL,
	[TipoInmueble] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TiposInmuebles] PRIMARY KEY CLUSTERED 
(
	[IdTipoInmueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TiposOperaciones]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposOperaciones](
	[IdTipoOperacion] [int] IDENTITY(1,1) NOT NULL,
	[TipoOperacion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_TiposOperaciones] PRIMARY KEY CLUSTERED 
(
	[IdTipoOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](30) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Usuario] [nvarchar](15) NOT NULL,
	[Pass] [nvarchar](100) NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[IntentosFallidos] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_Clientes]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Clientes]
AS
SELECT        dbo.Clientes.Apellido + ', ' + dbo.Clientes.Nombre AS ApelNom, dbo.Clientes.IdCliente, dbo.Clientes.Apellido, dbo.Clientes.Nombre, dbo.Clientes.IdTipoDoc, dbo.Clientes.NDoc, dbo.Clientes.FechaNac, dbo.Clientes.Direccion, 
                         dbo.Clientes.IdLocalidad, dbo.Clientes.Cel, dbo.Clientes.Email, dbo.Clientes.Activo, dbo.Clientes.Observaciones, dbo.TiposDocs.TipoDoc, dbo.Localidades.Localidad
FROM            dbo.Clientes INNER JOIN
                         dbo.Localidades ON dbo.Clientes.IdLocalidad = dbo.Localidades.IdLocalidad INNER JOIN
                         dbo.TiposDocs ON dbo.Clientes.IdTipoDoc = dbo.TiposDocs.IdTipoDoc

GO
/****** Object:  View [dbo].[View_Usuarios]    Script Date: 11/06/2021 18:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Usuarios]
AS
SELECT        dbo.Usuarios.IdUsuario, dbo.Usuarios.Apellido + ', ' + dbo.Usuarios.Nombre AS ApelNom, dbo.Usuarios.Usuario, dbo.Usuarios.Activo, dbo.Grupos.Grupo, dbo.Usuarios.IdGrupo, dbo.Usuarios.IntentosFallidos, 
                         CAST((CASE WHEN intentosfallidos = 3 THEN 1 ELSE 0 END) AS bit) AS Bloqueado
FROM            dbo.Grupos INNER JOIN
                         dbo.Usuarios ON dbo.Grupos.IdGrupo = dbo.Usuarios.IdGrupo

GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

GO
INSERT [dbo].[Clientes] ([IdCliente], [Apellido], [Nombre], [IdTipoDoc], [NDoc], [FechaNac], [Direccion], [IdLocalidad], [Cel], [Email], [Activo], [Observaciones]) VALUES (1, N'Rosas', N'Maria Andrea', 1, 30456000, CAST(N'1980-05-01 00:00:00' AS SmallDateTime), N'Bolivar 302', 11, N'15466841', N'dcecchi@frsn.utn.edu.ar', 0, N'observas')
GO
INSERT [dbo].[Clientes] ([IdCliente], [Apellido], [Nombre], [IdTipoDoc], [NDoc], [FechaNac], [Direccion], [IdLocalidad], [Cel], [Email], [Activo], [Observaciones]) VALUES (2, N'Garcia', N'Leandro', 1, 13200478, CAST(N'1978-03-18 00:00:00' AS SmallDateTime), N'Maipu 89', 1, N'15478559', N'garicaleandro@hotmail.com', 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Grupos] ON 

GO
INSERT [dbo].[Grupos] ([IdGrupo], [Grupo], [Acceso]) VALUES (1, N'Administrador', 10)
GO
INSERT [dbo].[Grupos] ([IdGrupo], [Grupo], [Acceso]) VALUES (2, N'Operario', 30)
GO
SET IDENTITY_INSERT [dbo].[Grupos] OFF
GO
SET IDENTITY_INSERT [dbo].[Inmuebles] ON 

GO
INSERT [dbo].[Inmuebles] ([IdInmueble], [IdTipoInmueble], [Direccion], [Depto], [Piso], [IdLocalidad], [IdPropietario], [CantHab], [Cochera], [Patio], [Parrilla], [Pileta], [FechaAlta], [TerrenoM2], [ConstruccionM2], [Valuacion], [EnVenta], [Activo], [Observaciones]) VALUES (1, 1, N'bolivar 33', NULL, NULL, 1, 1, 2, 1, 1, 1, 0, CAST(N'2021-05-13 00:00:00' AS SmallDateTime), 250, 180, 500000.0000, 1, 1, NULL)
GO
INSERT [dbo].[Inmuebles] ([IdInmueble], [IdTipoInmueble], [Direccion], [Depto], [Piso], [IdLocalidad], [IdPropietario], [CantHab], [Cochera], [Patio], [Parrilla], [Pileta], [FechaAlta], [TerrenoM2], [ConstruccionM2], [Valuacion], [EnVenta], [Activo], [Observaciones]) VALUES (4, 2, N'maipu 111', N'2', N'3', 10, 1, 3, 0, 0, 0, 0, CAST(N'2021-06-15 00:00:00' AS SmallDateTime), 300, 150, 650000.0000, 1, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Inmuebles] OFF
GO
SET IDENTITY_INSERT [dbo].[Localidades] ON 

GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (1, N'San Nicolas', N'2900')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (7, N'Pergamino', N'2700')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (9, N'Ramallo', N'2915')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (10, N'Cordoba Capital', N'5000')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (11, N'Rosario', N'2000')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (12, N'Villa Constitucion', N'2919')
GO
INSERT [dbo].[Localidades] ([IdLocalidad], [Localidad], [CodigoPostal]) VALUES (13, N'Villa Ramallo', N'2914')
GO
SET IDENTITY_INSERT [dbo].[Localidades] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposDocs] ON 

GO
INSERT [dbo].[TiposDocs] ([IdTipoDoc], [TipoDoc]) VALUES (1, N'DNI')
GO
INSERT [dbo].[TiposDocs] ([IdTipoDoc], [TipoDoc]) VALUES (2, N'PAS')
GO
SET IDENTITY_INSERT [dbo].[TiposDocs] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposInmuebles] ON 

GO
INSERT [dbo].[TiposInmuebles] ([IdTipoInmueble], [TipoInmueble]) VALUES (1, N'Casa')
GO
INSERT [dbo].[TiposInmuebles] ([IdTipoInmueble], [TipoInmueble]) VALUES (2, N'Depto')
GO
INSERT [dbo].[TiposInmuebles] ([IdTipoInmueble], [TipoInmueble]) VALUES (3, N'Quinta')
GO
SET IDENTITY_INSERT [dbo].[TiposInmuebles] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposOperaciones] ON 

GO
INSERT [dbo].[TiposOperaciones] ([IdTipoOperacion], [TipoOperacion]) VALUES (1, N'Compra/Venta')
GO
INSERT [dbo].[TiposOperaciones] ([IdTipoOperacion], [TipoOperacion]) VALUES (2, N'Alquiler')
GO
SET IDENTITY_INSERT [dbo].[TiposOperaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Apellido], [Nombre], [Usuario], [Pass], [IdGrupo], [Activo], [IntentosFallidos]) VALUES (1, N'garcia', N'ramon', N'rgarcia', N'4a9ca4596692e94f9d2912b06a0d007564a22ee750339a6021c2392149b25d6d', 2, 1, 0)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Apellido], [Nombre], [Usuario], [Pass], [IdGrupo], [Activo], [IntentosFallidos]) VALUES (2, N'lopez', N'andrea', N'alopezz', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Localidades]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_TiposDocs] FOREIGN KEY([IdTipoDoc])
REFERENCES [dbo].[TiposDocs] ([IdTipoDoc])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_TiposDocs]
GO
ALTER TABLE [dbo].[Inmuebles]  WITH CHECK ADD  CONSTRAINT [FK_Inmuebles_Clientes] FOREIGN KEY([IdPropietario])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Inmuebles] CHECK CONSTRAINT [FK_Inmuebles_Clientes]
GO
ALTER TABLE [dbo].[Inmuebles]  WITH CHECK ADD  CONSTRAINT [FK_Inmuebles_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Inmuebles] CHECK CONSTRAINT [FK_Inmuebles_Localidades]
GO
ALTER TABLE [dbo].[Inmuebles]  WITH CHECK ADD  CONSTRAINT [FK_Inmuebles_TiposInmuebles] FOREIGN KEY([IdTipoInmueble])
REFERENCES [dbo].[TiposInmuebles] ([IdTipoInmueble])
GO
ALTER TABLE [dbo].[Inmuebles] CHECK CONSTRAINT [FK_Inmuebles_TiposInmuebles]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_Clientes1] FOREIGN KEY([IdDestinatario])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_Clientes1]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_Inmuebles] FOREIGN KEY([IdInmueble])
REFERENCES [dbo].[Inmuebles] ([IdInmueble])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_Inmuebles]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_TiposOperaciones] FOREIGN KEY([IdTipoOperacion])
REFERENCES [dbo].[TiposOperaciones] ([IdTipoOperacion])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_TiposOperaciones]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Grupos] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[Grupos] ([IdGrupo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Grupos]
GO
USE [master]
GO
ALTER DATABASE [Inmobiliaria] SET  READ_WRITE 
GO
