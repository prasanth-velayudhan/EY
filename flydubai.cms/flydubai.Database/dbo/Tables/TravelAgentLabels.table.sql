CREATE TABLE [dbo].[TravelAgentLabels] (
    [TravelAgentLabelsId]     INT            IDENTITY (1, 1) NOT NULL,
    [SearchModuleTitle]       NVARCHAR (MAX) NULL,
    [SearchModulePrompt]      NVARCHAR (MAX) NULL,
    [SearchModuleForm]        NVARCHAR (MAX) NULL,
    [SearchModuleCountry]     NVARCHAR (MAX) NULL,
    [SearchModuleCity]        NVARCHAR (MAX) NULL,
    [SearchModuleSelect]      NVARCHAR (MAX) NULL,
    [SearchModuleSubmit]      NVARCHAR (MAX) NULL,
    [ResultsModuleTitle]      NVARCHAR (MAX) NULL,
    [ResultsModuleSeeMapLink] NVARCHAR (MAX) NULL,
    [LanguageId]              INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([TravelAgentLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

