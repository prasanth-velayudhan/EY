CREATE TABLE [dbo].[TAViewReportSearchLabels] (
    [Language]          NVARCHAR (128) NOT NULL,
    [SelectDates]       NVARCHAR (MAX) NULL,
    [AgencyName]        NVARCHAR (MAX) NULL,
    [EmailID]           NVARCHAR (MAX) NULL,
    [ReportStartDate]   NVARCHAR (MAX) NULL,
    [ReportEndDate]     NVARCHAR (MAX) NULL,
    [UpdateResults]     NVARCHAR (MAX) NULL,
    [DefaultAgencyname] NVARCHAR (MAX) NULL,
    [DefaultEmail]      NVARCHAR (MAX) NULL,
    [DefaultStartDate]  NVARCHAR (MAX) NULL,
    [DefaultEndDate]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ReportSearchLabel1] PRIMARY KEY CLUSTERED ([Language] ASC)
);

