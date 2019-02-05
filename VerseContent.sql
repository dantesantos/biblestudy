USE [BibleContent]
GO

/****** Object:  Table [dbo].[VerseContent]    Script Date: 05/02/2019 4:56:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VerseContent](
	[AuthorID] [int] NOT NULL,
	[ChapterID] [int] NOT NULL,
	[Verse] [int] NOT NULL,
	[VerseContent] [varchar](5000) NOT NULL
) ON [PRIMARY]
GO

