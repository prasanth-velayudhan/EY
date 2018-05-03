CREATE TABLE [dbo].[GoogleAnalytics] (
    [VersionId]             INT            IDENTITY (1, 1) NOT NULL,
    [RegularAnalytics]      NVARCHAR (MAX) NULL,
    [ConfirmationAnalytics] NVARCHAR (MAX) NULL,
    [PaymentAnalytics]      NVARCHAR (MAX) NULL,
    [EverypageAnalytics]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_GoogleAnalytics] PRIMARY KEY CLUSTERED ([VersionId] ASC)
);







