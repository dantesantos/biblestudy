USE [BibleContent]
GO

/****** Object:  Table [dbo].[ChapterQty]    Script Date: 05/02/2019 4:55:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChapterQty](
	[AuthorID] [int] NOT NULL,
	[AuthorName] [varchar](50) NOT NULL,
	[Qty] [int] NOT NULL,
 CONSTRAINT [PK_ChapterQty] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

