use master
go
create database CATALOGO_DB
go
use CATALOGO_DB
go
USE [CATALOGO_DB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 08/09/2019 10:32:14 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 08/09/2019 10:32:24 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
insert into MARCAS values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 'https://drive.google.com/uc?export=view&id=1zPr0rfMNr49qVg9CQ8gNUN27YSbJQPBl', 69.999),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 5, 1, 'https://drive.google.com/uc?export=view&id=1xvSeja6uv5x1a5MDskesY8iFF3o5O7eK', 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 'sin_imagen_para_que_de_error....muejeje', 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 'https://drive.google.com/uc?export=view&id=1wXnx0mKQBzE0qgCNnTvMkMGaihPHoJ5O', 49500),
('A23', 'Apple TV', 'lindo loro', 2, 3, 'https://drive.google.com/uc?export=view&id=1VpWreXeW6lXiJMvxXgcoKGceZva7NPf5', 7850)
select * from ARTICULOS