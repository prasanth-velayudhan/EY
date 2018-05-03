CREATE TABLE [dbo].[ExperienceLabels] (
    [ExperienceLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]              NVARCHAR (MAX) NULL,
    [SelectLabel]        NVARCHAR (MAX) NULL,
    [LanguageId]         INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ExperienceLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

