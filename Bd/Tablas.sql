
USE [PruebaFinaktiva]

	/****** Object:  Table [dbo].[Tb_Rol]    Script Date: 12/10/2021 10:19:45 a. m. ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Tb_Rol](
		[Idrol] [int] IDENTITY(1,1) NOT NULL,
		[Descripcion] [varchar](100) NULL,
	 CONSTRAINT [PK_Tb_Rol] PRIMARY KEY CLUSTERED 
	(
		[Idrol] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	/****** Object:  Table [dbo].[Tb_User]    Script Date: 12/10/2021 10:19:45 a. m. ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	CREATE TABLE [dbo].[Tb_User](
		[idUser] [int] IDENTITY(1,1) NOT NULL,
		[Name] [varchar](100) NULL,
		[Password] [varchar](100) NULL,
		[idRol] [int] NULL,
	 CONSTRAINT [PK_Tb_User] PRIMARY KEY CLUSTERED 
	(
		[idUser] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
	GO
	SET IDENTITY_INSERT [dbo].[Tb_Rol] ON 
	GO
	INSERT [dbo].[Tb_Rol] ([Idrol], [Descripcion]) VALUES (1, N'Administrador')
	GO
	INSERT [dbo].[Tb_Rol] ([Idrol], [Descripcion]) VALUES (2, N'Operativo')
	GO
	SET IDENTITY_INSERT [dbo].[Tb_Rol] OFF
	GO
	SET IDENTITY_INSERT [dbo].[Tb_User] ON 
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (1, N'Victor', N'123', 1)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (2, N'Mateo', N'123', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (3, N'Jahela', N'123', 1)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (4, N'Daniela', N'123', 1)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (5, N'Lina', N'123', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (6, N'CARLOS', N'123', 1)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (9, N'CARLOS40', N'12345', 1)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (10, N'CARLOS60', N'12345', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (11, N'CARLOS60', N'12345', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (12, N'CARLOS60', N'12345', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (13, N'CARLOS100', N'12345', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (14, N'CARLOS200', N'12345', 2)
	GO
	INSERT [dbo].[Tb_User] ([idUser], [Name], [Password], [idRol]) VALUES (15, N'CARLOS200', N'12345', 2)
	GO
	SET IDENTITY_INSERT [dbo].[Tb_User] OFF
	GO

	


