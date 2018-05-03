CREATE TABLE [dbo].[FaqLabels] (
    [FaqLabelsId]               INT            IDENTITY (1, 1) NOT NULL,
    [MainHeaderText]            NVARCHAR (MAX) NULL,
    [AnswerLabelText]           NVARCHAR (MAX) NULL,
    [SeeAllFaqsLinkText]        NVARCHAR (MAX) NULL,
    [SearchFaqsTitleText]       NVARCHAR (MAX) NULL,
    [SearchFaqsInstructionText] NVARCHAR (MAX) NULL,
    [SearchFaqsDefaultOption]   NVARCHAR (MAX) NULL,
    [SearchButtonLabel]         NVARCHAR (MAX) NULL,
    [LanguageId]                INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([FaqLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

