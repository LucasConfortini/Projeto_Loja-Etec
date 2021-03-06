USE [master]
GO
/****** Object:  Database [loja]    Script Date: 11/10/2016 11:47:53 ******/
CREATE DATABASE [loja] ON  PRIMARY 
( NAME = N'loja', FILENAME = N'C:\BD\loja.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'loja_log', FILENAME = N'C:\BD\loja_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [loja] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [loja].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [loja] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [loja] SET ANSI_NULLS OFF
GO
ALTER DATABASE [loja] SET ANSI_PADDING OFF
GO
ALTER DATABASE [loja] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [loja] SET ARITHABORT OFF
GO
ALTER DATABASE [loja] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [loja] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [loja] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [loja] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [loja] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [loja] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [loja] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [loja] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [loja] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [loja] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [loja] SET  DISABLE_BROKER
GO
ALTER DATABASE [loja] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [loja] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [loja] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [loja] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [loja] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [loja] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [loja] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [loja] SET  READ_WRITE
GO
ALTER DATABASE [loja] SET RECOVERY SIMPLE
GO
ALTER DATABASE [loja] SET  MULTI_USER
GO
ALTER DATABASE [loja] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [loja] SET DB_CHAINING OFF
GO
USE [loja]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produto](
	[cod_prod] [int] IDENTITY(1,1) NOT NULL,
	[desc_prod] [varchar](30) NOT NULL,
	[custo_prod] [numeric](9, 2) NOT NULL,
	[qtd_prod] [int] NOT NULL,
	[qtd_min] [int] NOT NULL,
	[valor_venda] [numeric](9, 2) NOT NULL,
 CONSTRAINT [PK__produto__B776EC777F60ED59] PRIMARY KEY CLUSTERED 
(
	[cod_prod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[produto] ON
INSERT [dbo].[produto] ([cod_prod], [desc_prod], [custo_prod], [qtd_prod], [qtd_min], [valor_venda]) VALUES (1, N'Blusa preta', CAST(35.00 AS Numeric(9, 2)), 20, 5, CAST(49.90 AS Numeric(9, 2)))
INSERT [dbo].[produto] ([cod_prod], [desc_prod], [custo_prod], [qtd_prod], [qtd_min], [valor_venda]) VALUES (2, N'Vestido Azul', CAST(50.50 AS Numeric(9, 2)), 10, 2, CAST(90.00 AS Numeric(9, 2)))
INSERT [dbo].[produto] ([cod_prod], [desc_prod], [custo_prod], [qtd_prod], [qtd_min], [valor_venda]) VALUES (3, N'Calça Sawary', CAST(60.00 AS Numeric(9, 2)), 12, 5, CAST(90.00 AS Numeric(9, 2)))
SET IDENTITY_INSERT [dbo].[produto] OFF
/****** Object:  Table [dbo].[cliente]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[COD_CLI] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CLI] [varchar](50) NOT NULL,
	[END_CLI] [varchar](50) NULL,
	[DATA_NASC] [date] NULL,
	[NATURA_CLI] [varchar](30) NULL,
	[LIMITE_CLI] [numeric](7, 0) NULL,
	[REF_CLI] [varchar](30) NULL,
	[CPF_CLI] [varchar](14) NULL,
	[CNPJ_CLI] [varchar](14) NULL,
	[FONE_CLI] [varchar](14) NOT NULL,
	[EMAIL_CLI] [varchar](30) NULL,
	[CEP_CLI] [varchar](10) NULL,
	[RG_CLI] [varchar](12) NULL,
	[CEL_CLI] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CLI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (1, N'Venda à Vista', N'Venda à Vista', CAST(0xD4230B00 AS Date), NULL, CAST(9999 AS Numeric(7, 0)), N'Venda à Vista', N'111.222.333-99', NULL, N'(16)3226-5656', N'Venda à Vista', N'15900-000', N'2131564', N'(16)99325-7918')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (2, N'Mestre Carlos', N'Rua dos Mestrados', CAST(0x430F0B00 AS Date), NULL, CAST(5000 AS Numeric(7, 0)), N'Compra pela Internet', N'112,365,489-79', NULL, N'(16)9205-1466', N'MestreYoda@hotmail.com', N'15900-000', N'1235498', N'(16)99369-2469')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (3, N'Henrique Menezes', N'Talavasso', CAST(0xE3220B00 AS Date), NULL, CAST(1500 AS Numeric(7, 0)), N'Casa Fucci', N'326,549,684-63', NULL, N'(16)3252-3384', N'HenriquedoLol@hotmail.com', N'15900-000', N'2185496', N'(16)99265-8475')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (4, N'Leticia Bido', N'Prudente de Morais', CAST(0x2C220B00 AS Date), NULL, CAST(2500 AS Numeric(7, 0)), N'Casa Fucci', N'569,848,751-23', NULL, N'(16)3252-7946', N'Leticiabido@hotmail.com', N'15900-000', N'1245687', N'(16)99256-8472')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (5, N'Rosana Dionysio', N'Rua Fernando de Abreu n47', CAST(0xA5040B00 AS Date), N'Taquaritinga', CAST(1500 AS Numeric(7, 0)), N'Baby Chic', N'111,111,111-11', NULL, N'(16)3253-2526', N'Rosana.dionysio@etec.sp.gov.br', N'15900-000', N'1111111111', N'(16)99203-5689')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (6, N'Lucas Confortini', N'Talavasso', CAST(0x6B230B00 AS Date), N'Taquaritinga', CAST(1250 AS Numeric(7, 0)), N'Casa Fucci', N'123,154,845-43', NULL, N'(16)3252-9864', N'Lucas@gmaiil.com', N'15900-000', N'16854516', N'(16)99235-6844')
INSERT [dbo].[cliente] ([COD_CLI], [NOME_CLI], [END_CLI], [DATA_NASC], [NATURA_CLI], [LIMITE_CLI], [REF_CLI], [CPF_CLI], [CNPJ_CLI], [FONE_CLI], [EMAIL_CLI], [CEP_CLI], [RG_CLI], [CEL_CLI]) VALUES (7, N'Joao', N'Maria Luiza', CAST(0x32220B00 AS Date), N'Taquaritinga', CAST(1500 AS Numeric(7, 0)), NULL, N'011,111,111-11', NULL, N'(16)3252-3598', N'Jao@gmail.com', N'15900-000', N'21468512', N'(16)95986-2354')
SET IDENTITY_INSERT [dbo].[cliente] OFF
/****** Object:  Table [dbo].[funcionario]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[funcionario](
	[COD_FUNC] [int] IDENTITY(1,1) NOT NULL,
	[NOME_FUNC] [varchar](50) NOT NULL,
	[END_FUNC] [varchar](30) NOT NULL,
	[NASC_FUNC] [date] NOT NULL,
	[CPF_FUNC] [varchar](14) NOT NULL,
	[FONE_FUNC] [varchar](14) NOT NULL,
	[EMAIL_CLI] [varchar](30) NULL,
	[RG_FUNC] [varchar](12) NOT NULL,
	[SALARIO_FUNC] [money] NOT NULL,
	[LOGIN_FUNC] [varchar](20) NOT NULL,
	[FOTO_FUNC] [image] NULL,
	[CEL_FUNC] [varchar](15) NULL,
 CONSTRAINT [PK__funciona__BCF35E8E03317E3D] PRIMARY KEY CLUSTERED 
(
	[COD_FUNC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[funcionario] ON
INSERT [dbo].[funcionario] ([COD_FUNC], [NOME_FUNC], [END_FUNC], [NASC_FUNC], [CPF_FUNC], [FONE_FUNC], [EMAIL_CLI], [RG_FUNC], [SALARIO_FUNC], [LOGIN_FUNC], [FOTO_FUNC], [CEL_FUNC]) VALUES (1, N'Sagula', N'Alderico Bussadori Filho', CAST(0x6B230B00 AS Date), N'475,643,488-60', N'(16)3252-3384', N'Leosagula@gmail.com', N'159132689', 2000.0000, N'Saga', NULL, N'(16)99325-7918')
INSERT [dbo].[funcionario] ([COD_FUNC], [NOME_FUNC], [END_FUNC], [NASC_FUNC], [CPF_FUNC], [FONE_FUNC], [EMAIL_CLI], [RG_FUNC], [SALARIO_FUNC], [LOGIN_FUNC], [FOTO_FUNC], [CEL_FUNC]) VALUES (2, N'Carlos', N'Rua dos Mestres', CAST(0x870F0B00 AS Date), N'115,489,892-10', N'(16)3253-6924', N'Carlos@Yoda', N'136548965', 1500.0000, N'Carlos', NULL, N'(16)98165-8974')
INSERT [dbo].[funcionario] ([COD_FUNC], [NOME_FUNC], [END_FUNC], [NASC_FUNC], [CPF_FUNC], [FONE_FUNC], [EMAIL_CLI], [RG_FUNC], [SALARIO_FUNC], [LOGIN_FUNC], [FOTO_FUNC], [CEL_FUNC]) VALUES (3, N'Felipe Gustavo', N'Talavasso', CAST(0xF41D0B00 AS Date), N'121,654,987-45', N'(16)3252-6898', N'FehJapinha@hotmail.com', N'1354665', 1900.0000, N'Felipe', NULL, NULL)
SET IDENTITY_INSERT [dbo].[funcionario] OFF
/****** Object:  Table [dbo].[fornecedor]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fornecedor](
	[cod_fornc] [int] IDENTITY(1,1) NOT NULL,
	[nome_fornc] [varchar](50) NOT NULL,
	[cnpj] [varchar](14) NULL,
	[email] [varchar](30) NULL,
	[cep] [varchar](10) NOT NULL,
	[end_fornc] [varchar](50) NOT NULL,
	[fone] [varchar](14) NOT NULL,
	[celular] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_fornc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[fornecedor] ON
INSERT [dbo].[fornecedor] ([cod_fornc], [nome_fornc], [cnpj], [email], [cep], [end_fornc], [fone], [celular]) VALUES (1, N'Shopping do Vestido', NULL, N'vestidosshopping@hotmail.com', N'14862-000', N'Av.', N'(16)3253-6987', N'(16)99748-5632')
SET IDENTITY_INSERT [dbo].[fornecedor] OFF
/****** Object:  Table [dbo].[usuarios]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[user_cod] [int] IDENTITY(1,1) NOT NULL,
	[user_nome] [varchar](30) NOT NULL,
	[user_login] [varchar](20) NOT NULL,
	[user_senha] [varchar](20) NOT NULL,
	[user_nivel] [varchar](20) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[user_cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON
INSERT [dbo].[usuarios] ([user_cod], [user_nome], [user_login], [user_senha], [user_nivel]) VALUES (3, N'Sagula', N'A', N'admin', N'Administrador')
INSERT [dbo].[usuarios] ([user_cod], [user_nome], [user_login], [user_senha], [user_nivel]) VALUES (5, N'Lucas', N'Lucas', N'lucas', N'Funcionário')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
/****** Object:  Table [dbo].[contas_pessoais]    Script Date: 11/10/2016 11:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contas_pessoais](
	[num_conta] [int] IDENTITY(1,1) NOT NULL,
	[descri_pessoal] [varchar](30) NOT NULL,
	[valor_pag] [numeric](9, 2) NULL,
	[valor_pagar] [numeric](9, 2) NOT NULL,
	[data_venc] [date] NOT NULL,
	[data_pag] [date] NULL,
 CONSTRAINT [PK__contas_p__E223E92D0AD2A005] PRIMARY KEY CLUSTERED 
(
	[num_conta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[contas_pessoais] ON
INSERT [dbo].[contas_pessoais] ([num_conta], [descri_pessoal], [valor_pag], [valor_pagar], [data_venc], [data_pag]) VALUES (1, N'Agua', CAST(50.00 AS Numeric(9, 2)), CAST(50.00 AS Numeric(9, 2)), CAST(0x153C0B00 AS Date), CAST(0x153C0B00 AS Date))
INSERT [dbo].[contas_pessoais] ([num_conta], [descri_pessoal], [valor_pag], [valor_pagar], [data_venc], [data_pag]) VALUES (2, N'Energia', CAST(355.00 AS Numeric(9, 2)), CAST(350.00 AS Numeric(9, 2)), CAST(0x143C0B00 AS Date), CAST(0x163C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[contas_pessoais] OFF
/****** Object:  View [dbo].[View_ClientesAniversariantes]    Script Date: 11/10/2016 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ClientesAniversariantes]
AS
SELECT     COD_CLI, NOME_CLI, END_CLI, DATENAME(month, DATA_NASC) AS Mês, FONE_CLI, CEL_CLI, EMAIL_CLI, DATA_NASC
FROM         dbo.cliente
WHERE     (DATENAME(month, DATA_NASC) = DATENAME(month, GETDATE()))
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 255
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ClientesAniversariantes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ClientesAniversariantes'
GO
/****** Object:  Table [dbo].[venda]    Script Date: 11/10/2016 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venda](
	[cod_venda] [int] IDENTITY(1,1) NOT NULL,
	[dta_venda] [date] NOT NULL,
	[tipo_venda] [varchar](20) NOT NULL,
	[cod_cli] [int] NOT NULL,
	[cod_func] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_venda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[venda] ON
INSERT [dbo].[venda] ([cod_venda], [dta_venda], [tipo_venda], [cod_cli], [cod_func]) VALUES (1, CAST(0x9F3B0B00 AS Date), N'Finalizada', 1, 2)
INSERT [dbo].[venda] ([cod_venda], [dta_venda], [tipo_venda], [cod_cli], [cod_func]) VALUES (2, CAST(0x143C0B00 AS Date), N'Finalizada', 7, 2)
INSERT [dbo].[venda] ([cod_venda], [dta_venda], [tipo_venda], [cod_cli], [cod_func]) VALUES (3, CAST(0x143C0B00 AS Date), N'Finalizada', 6, 1)
SET IDENTITY_INSERT [dbo].[venda] OFF
/****** Object:  View [dbo].[View_ProdutosFalta]    Script Date: 11/10/2016 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ProdutosFalta]
AS
SELECT     cod_prod, desc_prod, qtd_prod, qtd_min
FROM         dbo.produto
WHERE     (qtd_prod = 0)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "produto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosFalta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosFalta'
GO
/****** Object:  View [dbo].[View_ProdutosemBaixa]    Script Date: 11/10/2016 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ProdutosemBaixa]
AS
SELECT     cod_prod, desc_prod, qtd_prod, qtd_min
FROM         dbo.produto
WHERE     (qtd_prod < qtd_min) AND (qtd_prod > 0)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "produto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 222
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosemBaixa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosemBaixa'
GO
/****** Object:  View [dbo].[View_FuncionariosAniversariantes]    Script Date: 11/10/2016 11:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_FuncionariosAniversariantes]
AS
SELECT     COD_FUNC, NOME_FUNC, DATENAME(month, NASC_FUNC) AS Expr1, CEL_FUNC, EMAIL_CLI, NASC_FUNC
FROM         dbo.funcionario
WHERE     (DATENAME(month, NASC_FUNC) = DATENAME(month, GETDATE()))
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "funcionario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 240
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FuncionariosAniversariantes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FuncionariosAniversariantes'
GO
/****** Object:  StoredProcedure [dbo].[EntradaEstoque]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EntradaEstoque]
(
	@qtd_prod numeric(30, 0),
	@Original_cod_prod int
)
AS
	SET NOCOUNT OFF;
UPDATE       produto
SET                qtd_prod =  qtd_prod + @qtd_prod
WHERE        (cod_prod = @Original_cod_prod);
GO
/****** Object:  Table [dbo].[compra]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[compra](
	[cod_compra] [int] IDENTITY(1,1) NOT NULL,
	[dta_compra] [date] NOT NULL,
	[sit_compra] [varchar](20) NOT NULL,
	[valor_total] [numeric](9, 2) NOT NULL,
	[cod_fornc] [int] NOT NULL,
 CONSTRAINT [PK__compra__7666303A182C9B23] PRIMARY KEY CLUSTERED 
(
	[cod_compra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[compra] ON
INSERT [dbo].[compra] ([cod_compra], [dta_compra], [sit_compra], [valor_total], [cod_fornc]) VALUES (1, CAST(0x153C0B00 AS Date), N'Aberta', CAST(0.00 AS Numeric(9, 2)), 1)
INSERT [dbo].[compra] ([cod_compra], [dta_compra], [sit_compra], [valor_total], [cod_fornc]) VALUES (2, CAST(0x153C0B00 AS Date), N'Aberta', CAST(550.00 AS Numeric(9, 2)), 1)
SET IDENTITY_INSERT [dbo].[compra] OFF
/****** Object:  StoredProcedure [dbo].[BaixaEstoque]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BaixaEstoque]
(
	@qtd_prod numeric(30, 0),
	@Original_cod_prod int
)
AS
	SET NOCOUNT OFF;
UPDATE       produto
SET                qtd_prod =  qtd_prod - @qtd_prod
WHERE        (cod_prod = @Original_cod_prod);
GO
/****** Object:  StoredProcedure [dbo].[AtualizarPrecoCusto]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AtualizarPrecoCusto]
(
	@custo_prod numeric(9, 2),
	@Original_cod_prod int
)
AS
	SET NOCOUNT OFF;
UPDATE       produto
SET                custo_prod = @custo_prod
WHERE        (cod_prod = @Original_cod_prod);
GO
/****** Object:  Table [dbo].[itens_venda]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itens_venda](
	[num_item] [int] IDENTITY(1,1) NOT NULL,
	[qtd_item] [int] NOT NULL,
	[valor_unit] [numeric](9, 2) NOT NULL,
	[cod_prod] [int] NOT NULL,
	[num_venda] [int] NOT NULL,
 CONSTRAINT [PK__itens_ve__C3D6FF531A14E395] PRIMARY KEY CLUSTERED 
(
	[num_item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[itens_venda] ON
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (1, 2, CAST(49.90 AS Numeric(9, 2)), 1, 1)
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (2, 3, CAST(90.00 AS Numeric(9, 2)), 3, 1)
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (4, 2, CAST(90.00 AS Numeric(9, 2)), 3, 2)
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (5, 5, CAST(49.90 AS Numeric(9, 2)), 1, 2)
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (6, 3, CAST(90.00 AS Numeric(9, 2)), 3, 3)
INSERT [dbo].[itens_venda] ([num_item], [qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (7, 2, CAST(45.50 AS Numeric(9, 2)), 1, 3)
SET IDENTITY_INSERT [dbo].[itens_venda] OFF
/****** Object:  Table [dbo].[itens_compra]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itens_compra](
	[num_itemC] [int] IDENTITY(1,1) NOT NULL,
	[qtd_itemC] [int] NOT NULL,
	[valor_unit] [numeric](9, 2) NOT NULL,
	[cod_prod] [int] NOT NULL,
	[cod_compra] [int] NOT NULL,
 CONSTRAINT [PK__itens_co__A006C5041DE57479] PRIMARY KEY CLUSTERED 
(
	[num_itemC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[itens_compra] ON
INSERT [dbo].[itens_compra] ([num_itemC], [qtd_itemC], [valor_unit], [cod_prod], [cod_compra]) VALUES (1, 15, CAST(29.90 AS Numeric(9, 2)), 1, 2)
INSERT [dbo].[itens_compra] ([num_itemC], [qtd_itemC], [valor_unit], [cod_prod], [cod_compra]) VALUES (3, 1, CAST(35.00 AS Numeric(9, 2)), 1, 2)
INSERT [dbo].[itens_compra] ([num_itemC], [qtd_itemC], [valor_unit], [cod_prod], [cod_compra]) VALUES (4, 5, CAST(50.50 AS Numeric(9, 2)), 2, 2)
INSERT [dbo].[itens_compra] ([num_itemC], [qtd_itemC], [valor_unit], [cod_prod], [cod_compra]) VALUES (6, 4, CAST(35.00 AS Numeric(9, 2)), 1, 2)
SET IDENTITY_INSERT [dbo].[itens_compra] OFF
/****** Object:  Table [dbo].[contas_pagar]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contas_pagar](
	[cod_conpag] [int] NOT NULL,
	[data_venc] [date] NOT NULL,
	[valor_conpag] [numeric](9, 2) NOT NULL,
	[dta_pag] [date] NULL,
	[valor_pago] [numeric](9, 2) NULL,
	[cod_compra] [int] NOT NULL,
 CONSTRAINT [PK__contas_p__F7E150011BFD2C07] PRIMARY KEY CLUSTERED 
(
	[cod_conpag] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conta_receber]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conta_receber](
	[cod_con] [int] IDENTITY(1,1) NOT NULL,
	[num_parc] [int] NOT NULL,
	[valor_con] [numeric](9, 2) NOT NULL,
	[dta_venc] [date] NOT NULL,
	[dta_rec] [date] NULL,
	[valor_rec] [numeric](9, 2) NULL,
	[cod_venda] [int] NOT NULL,
 CONSTRAINT [PK__conta_re__FEA2A0881FCDBCEB] PRIMARY KEY CLUSTERED 
(
	[cod_con] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[conta_receber] ON
INSERT [dbo].[conta_receber] ([cod_con], [num_parc], [valor_con], [dta_venc], [dta_rec], [valor_rec], [cod_venda]) VALUES (1, 1, CAST(369.80 AS Numeric(9, 2)), CAST(0x143C0B00 AS Date), CAST(0x143C0B00 AS Date), CAST(369.80 AS Numeric(9, 2)), 1)
INSERT [dbo].[conta_receber] ([cod_con], [num_parc], [valor_con], [dta_venc], [dta_rec], [valor_rec], [cod_venda]) VALUES (2, 1, CAST(429.50 AS Numeric(9, 2)), CAST(0x143C0B00 AS Date), CAST(0x143C0B00 AS Date), CAST(429.50 AS Numeric(9, 2)), 2)
INSERT [dbo].[conta_receber] ([cod_con], [num_parc], [valor_con], [dta_venc], [dta_rec], [valor_rec], [cod_venda]) VALUES (3, 1, CAST(120.00 AS Numeric(9, 2)), CAST(0x0C3C0B00 AS Date), NULL, NULL, 3)
INSERT [dbo].[conta_receber] ([cod_con], [num_parc], [valor_con], [dta_venc], [dta_rec], [valor_rec], [cod_venda]) VALUES (4, 2, CAST(120.00 AS Numeric(9, 2)), CAST(0x5D3C0B00 AS Date), NULL, NULL, 3)
INSERT [dbo].[conta_receber] ([cod_con], [num_parc], [valor_con], [dta_venc], [dta_rec], [valor_rec], [cod_venda]) VALUES (5, 3, CAST(120.00 AS Numeric(9, 2)), CAST(0x7C3C0B00 AS Date), NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[conta_receber] OFF
/****** Object:  View [dbo].[View_ComprasFornecedor]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ComprasFornecedor]
AS
SELECT     dbo.compra.cod_compra, dbo.compra.dta_compra, dbo.fornecedor.nome_fornc, dbo.compra.sit_compra, dbo.compra.valor_total
FROM         dbo.compra INNER JOIN
                      dbo.fornecedor ON dbo.compra.cod_fornc = dbo.fornecedor.cod_fornc
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "compra"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 150
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fornecedor"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 189
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ComprasFornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ComprasFornecedor'
GO
/****** Object:  View [dbo].[ViewItensVenda]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewItensVenda]
AS
SELECT     dbo.itens_venda.num_item, dbo.itens_venda.num_venda, dbo.itens_venda.cod_prod, dbo.produto.desc_prod AS Produto, dbo.itens_venda.qtd_item AS Quantidade, 
                      dbo.itens_venda.valor_unit AS [Valor Unitário], dbo.itens_venda.qtd_item * dbo.itens_venda.valor_unit AS SubTotal
FROM         dbo.itens_venda INNER JOIN
                      dbo.produto ON dbo.itens_venda.cod_prod = dbo.produto.cod_prod
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "itens_venda"
            Begin Extent = 
               Top = 21
               Left = 245
               Bottom = 208
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "produto"
            Begin Extent = 
               Top = 3
               Left = 500
               Bottom = 211
               Right = 690
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewItensVenda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewItensVenda'
GO
/****** Object:  View [dbo].[View_VendasCliFunc]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_VendasCliFunc]
AS
SELECT     dbo.venda.cod_venda, dbo.venda.dta_venda, dbo.cliente.NOME_CLI, dbo.funcionario.NOME_FUNC, dbo.venda.tipo_venda, 
                      SUM(dbo.itens_venda.valor_unit * dbo.itens_venda.qtd_item) AS Total
FROM         dbo.cliente INNER JOIN
                      dbo.venda ON dbo.cliente.COD_CLI = dbo.venda.cod_cli INNER JOIN
                      dbo.funcionario ON dbo.venda.cod_func = dbo.funcionario.COD_FUNC INNER JOIN
                      dbo.itens_venda ON dbo.venda.cod_venda = dbo.itens_venda.num_venda
GROUP BY dbo.venda.cod_venda, dbo.venda.dta_venda, dbo.cliente.NOME_CLI, dbo.funcionario.NOME_FUNC, dbo.venda.tipo_venda
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "funcionario"
            Begin Extent = 
               Top = 93
               Left = 252
               Bottom = 259
               Right = 442
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "venda"
            Begin Extent = 
               Top = 6
               Left = 494
               Bottom = 161
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "itens_venda"
            Begin Extent = 
               Top = 6
               Left = 722
               Bottom = 206
               Right = 912
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_VendasCliFunc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_VendasCliFunc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_VendasCliFunc'
GO
/****** Object:  View [dbo].[View_TotalVenda]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_TotalVenda]
AS
SELECT     num_venda, SUM(qtd_item * valor_unit) AS Total
FROM         dbo.itens_venda
GROUP BY num_venda
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "itens_venda"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TotalVenda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TotalVenda'
GO
/****** Object:  View [dbo].[View_ProdutosMaisVendidos]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ProdutosMaisVendidos]
AS
SELECT     TOP (100) PERCENT SUM(dbo.itens_venda.qtd_item) AS Quantidade_Vendida, dbo.produto.cod_prod, dbo.produto.desc_prod
FROM         dbo.itens_venda INNER JOIN
                      dbo.produto ON dbo.itens_venda.cod_prod = dbo.produto.cod_prod
GROUP BY dbo.produto.cod_prod, dbo.produto.desc_prod
ORDER BY Quantidade_vendida DESC
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "itens_venda"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "produto"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 146
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosMaisVendidos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ProdutosMaisVendidos'
GO
/****** Object:  View [dbo].[View_ItensCompra]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ItensCompra]
AS
SELECT     dbo.itens_compra.num_itemC, dbo.produto.desc_prod, dbo.itens_compra.qtd_itemC, dbo.itens_compra.valor_unit, dbo.itens_compra.cod_prod, 
                      dbo.itens_compra.cod_compra, dbo.itens_compra.qtd_itemC * dbo.itens_compra.valor_unit AS subtotal
FROM         dbo.itens_compra INNER JOIN
                      dbo.produto ON dbo.itens_compra.cod_prod = dbo.produto.cod_prod
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "itens_compra"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "produto"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 125
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ItensCompra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ItensCompra'
GO
/****** Object:  View [dbo].[View_ClientesInadimplentes]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ClientesInadimplentes]
AS
SELECT     dbo.conta_receber.cod_con, dbo.cliente.NOME_CLI, dbo.conta_receber.valor_con, dbo.conta_receber.dta_venc, dbo.cliente.FONE_CLI, dbo.cliente.CEL_CLI
FROM         dbo.cliente INNER JOIN
                      dbo.venda ON dbo.cliente.COD_CLI = dbo.venda.cod_cli INNER JOIN
                      dbo.conta_receber ON dbo.venda.cod_venda = dbo.conta_receber.cod_venda
WHERE     (dbo.conta_receber.dta_venc < GETDATE()) AND (dbo.conta_receber.dta_rec IS NULL)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 229
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "venda"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 125
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "conta_receber"
            Begin Extent = 
               Top = 6
               Left = 494
               Bottom = 217
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ClientesInadimplentes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ClientesInadimplentes'
GO
/****** Object:  StoredProcedure [dbo].[RemoverItemVenda]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoverItemVenda]
(
	@Original_num_item int
)
AS
	SET NOCOUNT OFF;
DELETE FROM itens_venda
WHERE        (num_item = @Original_num_item)
GO
/****** Object:  StoredProcedure [dbo].[RemoverItemCompra]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoverItemCompra]
(
	@Original_num_itemC int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[itens_compra] WHERE (([num_itemC] = @Original_num_itemC))
GO
/****** Object:  StoredProcedure [dbo].[QuitarContaReceber]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[QuitarContaReceber]
(
	@dta_rec date,
	@valor_rec numeric(9, 2),
	@Original_cod_con int
)
AS
	SET NOCOUNT OFF;
UPDATE       conta_receber
SET                dta_rec = @dta_rec, valor_rec = @valor_rec
WHERE        (cod_con = @Original_cod_con);
GO
/****** Object:  StoredProcedure [dbo].[InserirItemVenda]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirItemVenda]
(
	@qtd_item int,
	@valor_unit numeric(9, 2),
	@cod_prod int,
	@num_venda int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[itens_venda] ([qtd_item], [valor_unit], [cod_prod], [num_venda]) VALUES (@qtd_item, @valor_unit, @cod_prod, @num_venda)
GO
/****** Object:  StoredProcedure [dbo].[InserirItemCompra]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirItemCompra]
(
	@cod_compra int,
	@cod_prod int,
	@qtd_itemC int,
	@valor_unit numeric(9, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO itens_compra
                         (cod_compra, cod_prod, qtd_itemC, valor_unit)
VALUES        (@cod_compra,@cod_prod,@qtd_itemC,@valor_unit);
GO
/****** Object:  StoredProcedure [dbo].[InserirContaReceber]    Script Date: 11/10/2016 11:47:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirContaReceber]
(
	@cod_venda int,
	@num_parc int,
	@dta_venc date,
	@dta_rec date,
	@valor_con numeric(9, 2),
	@valor_rec numeric(9, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO conta_receber
                         (cod_venda, num_parc, dta_venc, dta_rec, valor_con, valor_rec)
VALUES        (@cod_venda,@num_parc,@dta_venc,@dta_rec,@valor_con,@valor_rec);
GO
/****** Object:  ForeignKey [FK_venda_cliente]    Script Date: 11/10/2016 11:47:56 ******/
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_cliente] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([COD_CLI])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_cliente]
GO
/****** Object:  ForeignKey [FK_venda_funcionario]    Script Date: 11/10/2016 11:47:56 ******/
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_funcionario] FOREIGN KEY([cod_func])
REFERENCES [dbo].[funcionario] ([COD_FUNC])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_funcionario]
GO
/****** Object:  ForeignKey [FK_compra_fornecedor]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_compra_fornecedor] FOREIGN KEY([cod_fornc])
REFERENCES [dbo].[fornecedor] ([cod_fornc])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_compra_fornecedor]
GO
/****** Object:  ForeignKey [FK_itens_venda_produto]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[itens_venda]  WITH CHECK ADD  CONSTRAINT [FK_itens_venda_produto] FOREIGN KEY([cod_prod])
REFERENCES [dbo].[produto] ([cod_prod])
GO
ALTER TABLE [dbo].[itens_venda] CHECK CONSTRAINT [FK_itens_venda_produto]
GO
/****** Object:  ForeignKey [FK_itens_venda_venda]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[itens_venda]  WITH CHECK ADD  CONSTRAINT [FK_itens_venda_venda] FOREIGN KEY([num_venda])
REFERENCES [dbo].[venda] ([cod_venda])
GO
ALTER TABLE [dbo].[itens_venda] CHECK CONSTRAINT [FK_itens_venda_venda]
GO
/****** Object:  ForeignKey [FK_itens_compra_compra]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[itens_compra]  WITH CHECK ADD  CONSTRAINT [FK_itens_compra_compra] FOREIGN KEY([cod_compra])
REFERENCES [dbo].[compra] ([cod_compra])
GO
ALTER TABLE [dbo].[itens_compra] CHECK CONSTRAINT [FK_itens_compra_compra]
GO
/****** Object:  ForeignKey [FK_itens_compra_produto]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[itens_compra]  WITH CHECK ADD  CONSTRAINT [FK_itens_compra_produto] FOREIGN KEY([cod_prod])
REFERENCES [dbo].[produto] ([cod_prod])
GO
ALTER TABLE [dbo].[itens_compra] CHECK CONSTRAINT [FK_itens_compra_produto]
GO
/****** Object:  ForeignKey [FK_contas_pagar_compra]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[contas_pagar]  WITH CHECK ADD  CONSTRAINT [FK_contas_pagar_compra] FOREIGN KEY([cod_compra])
REFERENCES [dbo].[compra] ([cod_compra])
GO
ALTER TABLE [dbo].[contas_pagar] CHECK CONSTRAINT [FK_contas_pagar_compra]
GO
/****** Object:  ForeignKey [FK_conta_recentes_venda]    Script Date: 11/10/2016 11:47:58 ******/
ALTER TABLE [dbo].[conta_receber]  WITH CHECK ADD  CONSTRAINT [FK_conta_recentes_venda] FOREIGN KEY([cod_venda])
REFERENCES [dbo].[venda] ([cod_venda])
GO
ALTER TABLE [dbo].[conta_receber] CHECK CONSTRAINT [FK_conta_recentes_venda]
GO
