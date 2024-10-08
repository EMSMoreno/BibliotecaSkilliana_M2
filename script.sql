USE [master]
GO
/****** Object:  Database [BibliotecaSkilliana]    Script Date: 25/09/2024 23:03:45 ******/
CREATE DATABASE [BibliotecaSkilliana]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BibliotecaSkilliana', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BibliotecaSkilliana.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BibliotecaSkilliana_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BibliotecaSkilliana_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BibliotecaSkilliana] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BibliotecaSkilliana].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BibliotecaSkilliana] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ARITHABORT OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BibliotecaSkilliana] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BibliotecaSkilliana] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BibliotecaSkilliana] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BibliotecaSkilliana] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BibliotecaSkilliana] SET  MULTI_USER 
GO
ALTER DATABASE [BibliotecaSkilliana] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BibliotecaSkilliana] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BibliotecaSkilliana] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BibliotecaSkilliana] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BibliotecaSkilliana] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BibliotecaSkilliana] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BibliotecaSkilliana] SET QUERY_STORE = ON
GO
ALTER DATABASE [BibliotecaSkilliana] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BibliotecaSkilliana]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 25/09/2024 23:03:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[ID_Autor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Data_Nascimento] [date] NULL,
	[Biografia] [text] NULL,
	[Facebook] [varchar](255) NULL,
	[Instagram] [varchar](255) NULL,
	[X_Twitter] [varchar](255) NULL,
	[Codigo_Secao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emprestimo]    Script Date: 25/09/2024 23:03:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emprestimo](
	[ID_Emprestimo] [int] IDENTITY(1,1) NOT NULL,
	[Data_Registro] [date] NOT NULL,
	[Data_Prevista_Devolucao] [date] NOT NULL,
	[Numero_Socio] [int] NULL,
	[ID_Funcionario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Emprestimo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estante]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estante](
	[Codigo_Estante] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
	[Secao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Estante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[ID_Funcionario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Morada] [varchar](255) NULL,
	[Telefone] [varchar](20) NULL,
	[Email] [varchar](255) NULL,
	[Data_Nascimento] [date] NULL,
	[Numero_Funcionario] [int] NULL,
	[Tipo] [varchar](15) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Numero_Funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livro]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro](
	[ISBN] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](255) NOT NULL,
	[Data_Lancamento] [date] NULL,
	[Sinopse] [text] NULL,
	[Edicao] [varchar](100) NULL,
	[Editora] [varchar](255) NULL,
	[Idioma] [varchar](100) NULL,
	[Numero_Paginas] [int] NULL,
	[Estado] [varchar](10) NOT NULL,
	[Codigo_Estante] [int] NULL,
	[Quantidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livro_Autor]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro_Autor](
	[ISBN] [int] NOT NULL,
	[ID_Autor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC,
	[ID_Autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livro_Emprestimo]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro_Emprestimo](
	[ID_Emprestimo] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Emprestimo] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secao]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secao](
	[Codigo_Secao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Secao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 25/09/2024 23:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio](
	[Numero_Socio] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Numero_Cartao_Cidadao] [varchar](20) NULL,
	[Morada] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[Telefone] [varchar](20) NULL,
	[Data_Nascimento] [date] NULL,
	[Estado] [varchar](10) NOT NULL,
	[ID_Funcionario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_Socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Numero_Cartao_Cidadao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Livro] ADD  DEFAULT ((0)) FOR [Quantidade]
GO
ALTER TABLE [dbo].[Autor]  WITH CHECK ADD FOREIGN KEY([Codigo_Secao])
REFERENCES [dbo].[Secao] ([Codigo_Secao])
GO
ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD FOREIGN KEY([ID_Funcionario])
REFERENCES [dbo].[Funcionario] ([ID_Funcionario])
GO
ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD FOREIGN KEY([Numero_Socio])
REFERENCES [dbo].[Socio] ([Numero_Socio])
GO
ALTER TABLE [dbo].[Estante]  WITH CHECK ADD FOREIGN KEY([Secao])
REFERENCES [dbo].[Secao] ([Codigo_Secao])
GO
ALTER TABLE [dbo].[Livro]  WITH CHECK ADD FOREIGN KEY([Codigo_Estante])
REFERENCES [dbo].[Estante] ([Codigo_Estante])
GO
ALTER TABLE [dbo].[Livro_Autor]  WITH CHECK ADD FOREIGN KEY([ID_Autor])
REFERENCES [dbo].[Autor] ([ID_Autor])
GO
ALTER TABLE [dbo].[Livro_Autor]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Livro] ([ISBN])
GO
ALTER TABLE [dbo].[Livro_Emprestimo]  WITH CHECK ADD FOREIGN KEY([ID_Emprestimo])
REFERENCES [dbo].[Emprestimo] ([ID_Emprestimo])
GO
ALTER TABLE [dbo].[Livro_Emprestimo]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Livro] ([ISBN])
GO
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD FOREIGN KEY([ID_Funcionario])
REFERENCES [dbo].[Funcionario] ([ID_Funcionario])
GO
ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD CHECK  (([Estado]='Inativo' OR [Estado]='Ativo'))
GO
ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD CHECK  (([Tipo]='Armazenista' OR [Tipo]='Bibliotecario' OR [Tipo]='Administrador'))
GO
ALTER TABLE [dbo].[Livro]  WITH CHECK ADD CHECK  (([Estado]='Inativo' OR [Estado]='Ativo'))
GO
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD CHECK  (([Estado]='Inativo' OR [Estado]='Ativo'))
GO
USE [master]
GO
ALTER DATABASE [BibliotecaSkilliana] SET  READ_WRITE 
GO
