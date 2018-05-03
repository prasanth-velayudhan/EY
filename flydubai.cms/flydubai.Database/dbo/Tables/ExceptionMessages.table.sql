CREATE TABLE [dbo].[ExceptionMessages] (
    [ExceptionMessageId] INT            IDENTITY (1, 1) NOT NULL,
    [Language]           NVARCHAR (MAX) NULL,
    [Key]                NVARCHAR (MAX) NULL,
    [Value]              NVARCHAR (MAX) NULL,
    [Area]               NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ExceptionMessageId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

