CREATE TABLE [dbo].[CareersLabels] (
    [CareersLabelsId]      INT            IDENTITY (1, 1) NOT NULL,
    [ViewLatestVacancies]  NVARCHAR (MAX) NULL,
    [LatestVacanciesTitle] NVARCHAR (MAX) NULL,
    [LanguageId]           INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([CareersLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

