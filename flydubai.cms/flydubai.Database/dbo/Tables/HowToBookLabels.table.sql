CREATE TABLE [dbo].[HowToBookLabels] (
    [HowToBookLabelsId]      INT            IDENTITY (1, 1) NOT NULL,
    [SummaryMainTitle]       NVARCHAR (MAX) NULL,
    [SummaryInstructionText] NVARCHAR (MAX) NULL,
    [TelephoneLinkText]      NVARCHAR (MAX) NULL,
    [AgentLinkText]          NVARCHAR (MAX) NULL,
    [LanguageId]             INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([HowToBookLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

