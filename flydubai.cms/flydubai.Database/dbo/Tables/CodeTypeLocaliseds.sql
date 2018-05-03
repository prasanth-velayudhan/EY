CREATE TABLE [dbo].[CodeTypeLocaliseds](
	[CodeTypeLocalisedId] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[CodeType_CodeTypeId] [nvarchar](128) NULL,
	[ImageID] [int] NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Status] [int] NOT NULL DEFAULT ((1)) );
