/****** Object:  Index [PK_CustomPageLocaliseds]    Script Date: 07/13/2014 16:56:28 ******/
ALTER TABLE [dbo].[CustomPageLocaliseds] ADD  CONSTRAINT [PK_CustomPageLocaliseds] PRIMARY KEY CLUSTERED 
(
	[CustomPageId] ASC,
	[LanguageId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

