USE [RegistroPolicial]
GO
/****** Object:  Table [dbo].[Delito]    Script Date: 04/06/2019 04:53:08 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Delito](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[origen] [varchar](50) NULL,
	[categoria] [varchar](50) NULL,
	[subCategoria] [varchar](50) NULL,
	[modalidad] [varchar](50) NULL,
	[victima] [varchar](50) NULL,
	[subVictima] [varchar](50) NULL,
	[fechaIngreso] [datetime] NULL,
	[oficina] [varchar](50) NULL,
	[delegacion] [varchar](50) NULL,
	[perjuicio] [varchar](50) NULL,
	[moneda] [varchar](50) NULL,
	[tentativa] [varchar](50) NULL,
	[observaciones] [varchar](50) NULL,
	[narracion] [varchar](50) NULL,
	[numeroUnico] [varchar](50) NULL,
 CONSTRAINT [PK_Delito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DelitoPersonaJuridica]    Script Date: 04/06/2019 04:53:08 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelitoPersonaJuridica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDelito] [int] NULL,
	[idPersonaJuridica] [int] NULL,
 CONSTRAINT [PK_DelitoPersonaJuridica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonaJuridica]    Script Date: 04/06/2019 04:53:08 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaJuridica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](50) NULL,
	[cedulaJuridica] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[razon] [varchar](50) NULL,
	[intensidad] [varchar](50) NULL,
	[nombreFantasia] [varchar](50) NULL,
	[atributo] [varchar](50) NULL,
	[filial] [varchar](50) NULL,
	[allanada] [bit] NULL,
	[observaciones] [varchar](250) NULL,
 CONSTRAINT [PK_PersonaJuridica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DelitoPersonaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_DelitoPersonaJuridica_Delito] FOREIGN KEY([idDelito])
REFERENCES [dbo].[Delito] ([id])
GO
ALTER TABLE [dbo].[DelitoPersonaJuridica] CHECK CONSTRAINT [FK_DelitoPersonaJuridica_Delito]
GO
ALTER TABLE [dbo].[DelitoPersonaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_DelitoPersonaJuridica_PersonaJuridica] FOREIGN KEY([idPersonaJuridica])
REFERENCES [dbo].[PersonaJuridica] ([id])
GO
ALTER TABLE [dbo].[DelitoPersonaJuridica] CHECK CONSTRAINT [FK_DelitoPersonaJuridica_PersonaJuridica]
GO
