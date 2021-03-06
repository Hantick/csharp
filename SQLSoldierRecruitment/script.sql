USE [PrzemyslawSzafranskiSQLZaddom2]
GO
/****** Object:  Table [dbo].[SoldiersAndMarinesTable]    Script Date: 27.11.2017 01:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoldiersAndMarinesTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[HP] [int] NOT NULL,
	[DMG] [int] NOT NULL,
	[Condition] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SoldiersAndMarinesTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SoldiersAndMarinesTable] ON 

INSERT [dbo].[SoldiersAndMarinesTable] ([Id], [Name], [HP], [DMG], [Condition]) VALUES (1, N'Przmek', 60, 40, N'Słaba')
INSERT [dbo].[SoldiersAndMarinesTable] ([Id], [Name], [HP], [DMG], [Condition]) VALUES (2, N'Zdzisław', 70, 30, N'Dobra')
INSERT [dbo].[SoldiersAndMarinesTable] ([Id], [Name], [HP], [DMG], [Condition]) VALUES (3, N'Nieznany żołnierz', 84, 36, N'W normie15')
INSERT [dbo].[SoldiersAndMarinesTable] ([Id], [Name], [HP], [DMG], [Condition]) VALUES (4, N'test', 62, 31, N'Dobra15')
SET IDENTITY_INSERT [dbo].[SoldiersAndMarinesTable] OFF
