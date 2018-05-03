CREATE TABLE [dbo].[ExceptionMessageAreas] (
    [ExceptionMessageAreaId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ExceptionMessageAreaId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

